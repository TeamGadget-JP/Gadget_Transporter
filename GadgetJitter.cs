using UnityEngine;
using UnityEditor;

public class GadgetJitter : EditorWindow
{
    private Vector3 posJitter = new Vector3(1.0f, 1.0f, 1.0f); 
    private Vector3 rotJitter = new Vector3(1.0f, 2.0f, 1.0f);   
    private float scaleJitter = 1.0f; // 1.0 = 1%

    // 単位やスケールの違いを吸収するマスター倍率
    private float masterMultiplier = 0.001f; 

    // Pivotを無視してメッシュの中心を基準にするか
    private bool useMeshCenter = true;

    [MenuItem("Tools/Gadget Jitter (Randomizer)")]
    public static void ShowWindow()
    {
        GetWindow<GadgetJitter>("Gadget Jitter");
    }

    private void OnGUI()
    {
        GUILayout.Label("Add Imperfection (ゆらぎ付与)", EditorStyles.boldLabel);
        
        EditorGUILayout.BeginVertical("box");
        posJitter = EditorGUILayout.Vector3Field("Position Jitter (Base)", posJitter);
        rotJitter = EditorGUILayout.Vector3Field("Rotation Jitter (deg)", rotJitter);
        // %でそのまま入力できるように修正（1と入力すれば1%）
        scaleJitter = EditorGUILayout.FloatField("Scale Jitter (±%)", scaleJitter);
        EditorGUILayout.EndVertical();

        GUILayout.Space(5);
        masterMultiplier = EditorGUILayout.FloatField("Master Multiplier", masterMultiplier);
        GUILayout.Label("※ Positionに掛かる最終倍率です。\n1.0 ならそのまま、0.001 なら 1/1000の移動量になります。", EditorStyles.helpBox);

        GUILayout.Space(5);
        // これが今回の魔法のチェックボックスです
        useMeshCenter = EditorGUILayout.ToggleLeft(" Rotate/Scale around Mesh Center\n (Pivotが遠くにあるCADモデル用)", useMeshCenter, GUILayout.Height(35));

        GUILayout.Space(10);
        GUI.backgroundColor = new Color(0.8f, 1.0f, 0.8f);
        if (GUILayout.Button("Apply Jitter to Selected", GUILayout.Height(35)))
        {
            ApplyJitter();
        }
        GUI.backgroundColor = Color.white;
    }

    private void ApplyJitter()
    {
        Undo.RecordObjects(Selection.transforms, "Apply Jitter");
        
        foreach (Transform t in Selection.transforms)
        {
            // 1. メッシュの視覚的な中心を取得（なければTransformの位置）
            Vector3 center = t.position;
            if (useMeshCenter)
            {
                Renderer rnd = t.GetComponentInChildren<Renderer>();
                if (rnd != null) center = rnd.bounds.center;
            }

            // 2. Position Jitter (マスター倍率を掛ける)
            Vector3 finalPosJitter = posJitter * masterMultiplier;
            t.position += new Vector3(
                Random.Range(-finalPosJitter.x, finalPosJitter.x),
                Random.Range(-finalPosJitter.y, finalPosJitter.y),
                Random.Range(-finalPosJitter.z, finalPosJitter.z)
            );

            // 3. Rotation Jitter
            float rx = Random.Range(-rotJitter.x, rotJitter.x);
            float ry = Random.Range(-rotJitter.y, rotJitter.y);
            float rz = Random.Range(-rotJitter.z, rotJitter.z);

            if (useMeshCenter)
            {
                // Pivotではなく、石のど真ん中を軸にして回転させる
                t.RotateAround(center, Vector3.right, rx);
                t.RotateAround(center, Vector3.up, ry);
                t.RotateAround(center, Vector3.forward, rz);
            }
            else
            {
                t.rotation *= Quaternion.Euler(rx, ry, rz);
            }

            // 4. Scale Jitter
            float s = 1.0f + Random.Range(-scaleJitter / 100f, scaleJitter / 100f);
            t.localScale = new Vector3(t.localScale.x * s, t.localScale.y * s, t.localScale.z * s);
            
            if (useMeshCenter)
            {
                // 遠いPivot基準でスケールしたことによる「石の吹き飛び（移動）」を数学的に打ち消す
                t.position += (center - t.position) * (1.0f - s);
            }
        }
    }
}