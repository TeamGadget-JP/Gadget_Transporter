# Gadget Transporter

Welcome to "Gadget Transporter"! This is an ultimate bridge and asset-fetching (GetBack) tool designed to seamlessly connect Unity Editor with ZBrush and 3D-Coat.

## ⚠️ Important Notice

* **No Support (As-Is):** I am a solo developer working in the industrial engineering field. Therefore, providing individual technical support is practically impossible. This tool is provided "as-is" and completely free, without official support.

## 🙏 Support the Project!

This tool is completely free to use. However, if you find it helpful for your workflow, I would greatly appreciate it if you could **Subscribe to my YouTube channel and Like the videos!** Your support is my greatest motivation to continue developing tools like this! 
▶️ https://www.youtube.com/channel/UCj9OYwzMAIgYAeVkTV4wczw

---

## 🚀 Key Features

* **📤 Send To (Export):**
  * **ZBrush Direct Auto-Import:** Instantly sends selected Unity meshes to ZBrush. Automatically generates and executes ZScripts to bypass manual import dialogs.
  * **3D-Coat Applink:** Sends meshes directly to 3D-Coat's Applink Exchange folder and auto-launches the application (Supports Per Pixel Painting and Retopo rooms).
  * **Standard Export:** Quickly export selected objects as OBJ or FBX with adjustable scale.
* **📥 GetBack (Import):**
  * **One-Click Fetch:** Scans your designated export folder for OBJ/FBX files and accompanying textures.
  * **Auto-Processing:** Automatically imports the model, creates a material, assigns textures (Color, Normal, Metallic, Emission), and builds a Prefab.
  * **Smart Cleanup:** Automatically moves processed source files into a `_History` folder to keep your workspace clean.

---

## 🛠️ Setup & How to Use

### 1. Initial Setup
1. In Unity, open the tool via the top menu: `Gadget > Gadget Transporter`.
2. Expand the **⚙️ Path Settings** foldout.
3. Assign the executable paths for `ZBrush.exe` and `3D-Coat.exe`.
4. Set the **3D-Coat Exchange** folder (Usually `C:\Users\Public\Documents\Applinks\3D-Coat\Exchange`).
5. Set the **GetBack Source** folder (The folder where you export your finished models from external apps).

### 2. Exporting to External Apps
1. Select one or more 3D models in your Unity Hierarchy.
2. Click **Send to ZBrush** or **Send to 3D-Coat**. The tool will automatically format the mesh (flipping axes if necessary for the target app) and send it over.

### 3. Getting Assets Back (GetBack)
1. Export your finished model and textures from ZBrush/3D-Coat to your specified **GetBack Source** folder.
2. In the Gadget Transporter window, select whether you want to automatically **Create Prefab** and/or **Add to Scene**.
3. Click the green **GetBack (Fetch & Process)** button. The tool will handle the rest!

---

## 💡 Pro Tips

* **3D-Coat Retopo Scale:** When sending a model to 3D-Coat's Retopo room, you might experience scale mismatches. A recommended workflow is to set the **Export Scale to `100`** when sending, and set the **Import Scale to `0.01`** (1/100) when using GetBack. This ensures the scale remains perfectly consistent when brought back to Unity.

---

## ⚖️ License
This software is provided under a proprietary license. Unauthorized redistribution, modification, and reverse engineering (decompiling) are strictly prohibited. 
For full details, please read the [LICENSE](./LICENSE) file.

===========================================================================

# Gadget Transporter (日本語版)

「Gadget Transporter」へようこそ！このツールは、UnityエディタとZBrush、および3D-Coatをシームレスに連携させるための究極のブリッジ＆アセット回収（GetBack）ツールです。

## ⚠️ 重要な注意事項（必ずお読みください）

* **サポートなし（現状渡し）:** 開発者は普段、FA・産業機械系の本業を抱える個人エンジニアです。そのため、個別の環境に合わせた技術サポートを提供することは事実上不可能です。本ツールは「完全無料・サポート対象外」として提供されます。

## 🙏 開発者からのお願い

本ツールは完全無料でお使いいただけます。もし皆様の制作のお役に立てましたら、ぜひ**YouTubeチャンネルの登録と高評価**をお願いいたします！ 皆様からの応援が、今後の開発の最大のモチベーションになります！ 
▶️ https://www.youtube.com/channel/UCj9OYwzMAIgYAeVkTV4wczw

---

## 🚀 主要機能

* **📤 Send To（外部アプリへ送信）:**
  * **ZBrushへのダイレクトインポート:** 選択したメッシュをZBrushへ即座に送信。ZScriptを自動生成・実行するため、手動のインポートダイアログをスキップできます。
  * **3D-Coat Applink接続:** メッシュを3D-CoatのExchangeフォルダへ直接直接送信し、アプリを自動起動します（Per Pixel PaintingおよびRetopoルームに対応）。
  * **標準エクスポート:** 選択したオブジェクトをスケール調整付きでOBJまたはFBXとして素早く書き出します。
* **📥 GetBack（アセットの自動回収）:**
  * **ワンクリック回収:** 指定したフォルダをスキャンし、出力されたOBJ/FBXと関連テクスチャを自動検知します。
  * **自動セットアップ:** モデルのインポート、マテリアルの作成、テクスチャの自動割り当て（Color, Normal, Metallic, Emission等）、そしてPrefabの生成までを全自動で行います。
  * **スマートクリーンアップ:** 処理が完了した元ファイルは自動的に `_History` フォルダへ移動し、作業フォルダを常にクリーンに保ちます。

---

## 🛠️ 初期設定と使い方

### 1. 初期設定
1. Unity上部メニューから `Gadget > Gadget Transporter` を開きます。
2. **⚙️ Path Settings** を展開します。
3. `ZBrush.exe` と `3D-Coat.exe` の実行ファイルパスを指定します。
4. **3D-Coat Exchange** フォルダを指定します（通常は `C:\Users\Public\Documents\Applinks\3D-Coat\Exchange`）。
5. **GetBack Source** フォルダを指定します（外部アプリから完成モデルをエクスポートする先のフォルダ）。

### 2. 外部アプリへの送信
1. ヒエラルキーで3Dモデルを選択します。
2. **Send to ZBrush** または **Send to 3D-Coat** ボタンを押します。対象アプリに合わせて自動で軸の反転処理等が行われ、送信されます。

### 3. アセットの回収 (GetBack)
1. ZBrushや3D-Coatでの作業が完了したら、指定した **GetBack Source** フォルダへモデルとテクスチャをエクスポートします。
2. Transporterウィンドウで、**Create Prefab**（プレハブ化）や **Add to Scene**（シーンへ配置）のオプションを選択します。
3. 緑色の **GetBack (Fetch & Process)** ボタンを押せば、あとはツールが全て自動で処理します！

---

## 💡 Pro Tips（便利なTips）

* **3D-Coat リトポルームのスケール設定:** 3D-CoatのRetopoルームへモデルを送る際、環境によってはスケールが合わなくなることがあります。これを防ぐためのオススメの設定は、送信時の **Export Scale を `100`** にし、戻す時の **Import Scale を `0.01`**（1/100）にしてGetBackを行うことです。これにより、Unity上で元のスケールにぴったり一致させることができます。

---

## ⚖️ License
本ソフトウェアは独自ライセンスのもとで提供されています。無断再配布、改変、および逆コンパイル（リバースエンジニアリング）は固く禁じられています。
詳細については、[LICENSE](./LICENSE) ファイルをご確認ください。
