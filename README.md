# 備品貸出管理アプリ

社内備品（ノートPC、プロジェクター等）の貸出状況を管理する C# 7.3 / .NET Framework 4.8 のアプリです。

今回、既存の `OfficeItemRentalApp.Core` を再利用し、GUIアプリの起動プロジェクトとして `OfficeItemRentalApp` を追加しました。
既存の `OfficeItemRentalApp.CLI` も残してあるため、コンソール版も引き続き利用できます。

## プロジェクト構成

```text
OfficeItemRentalApp/
├─ OfficeItemRentalApp.sln
├─ NuGet.config
├─ README.md
├─ TEST_CASES.md
├─ OfficeItemRentalApp/                 GUIアプリ（WinForms）
│  ├─ OfficeItemRentalApp.csproj
│  ├─ Program.cs
│  ├─ MainForm.cs                  画面ロジック
│  ├─ MainForm.Designer.cs         デザイナー生成相当の画面定義
│  ├─ MainForm.resx
│  └─ App.config
├─ OfficeItemRentalApp.Core/            業務ロジック、モデル、JSON保存
│  ├─ OfficeItemRentalApp.Core.csproj
│  ├─ Models/
│  └─ Services/
└─ OfficeItemRentalApp.CLI/             既存のコンソール版
   ├─ OfficeItemRentalApp.CLI.csproj
   ├─ Program.cs
   └─ ConsoleUI/                       コンソール画面・入力処理
```

## 前提環境

- Windows
- Visual Studio 2022 などの .NET Framework 4.8 開発環境
- .NET Framework 4.8 Developer Pack
- C# 7.3
- NuGet パッケージ復元ができること

`System.Text.Json` は .NET Framework 4.8 標準同梱ではないため、NuGet パッケージとして参照しています。

## GUI版の実行方法

### Visual Studio で実行する場合

1. `OfficeItemRentalApp.sln` を開きます。
2. NuGet パッケージを復元します。
3. スタートアッププロジェクトを `OfficeItemRentalApp` に設定します。
4. ビルドして実行します。

### コマンドでビルドする場合

```powershell
dotnet restore .\OfficeItemRentalApp.sln --configfile NuGet.config
dotnet build .\OfficeItemRentalApp.sln --no-restore -m:1 -p:UseSharedCompilation=false
```

GUI版の exe は通常、以下に生成されます。

```powershell
.\OfficeItemRentalApp\bin\Debug\net48\OfficeItemRentalApp.exe
```

## WinFormsデザイナーについて

`MainForm` は、Visual Studio のデザイナーで安全に開きやすいように、標準のWinForms生成に近い構成へ分離しています。

- `MainForm.cs`: 業務処理、イベントハンドラ、表示更新処理
- `MainForm.Designer.cs`: コントロール生成、配置、プロパティ設定、イベント接続
- `MainForm.resx`: デザイナー用リソース

`InitializeComponent()` 内には、匿名デリゲート、ラムダ式、動的な座標計算、独自の画面生成メソッド呼び出しを置かない方針です。

## GUI版の実装機能

### 備品一覧

- 登録済み備品の一覧表示
- 状態表示（利用可 / 貸出中）
- 借主、貸出日、返却予定日、督促対象の表示
- 返却予定日を過ぎた未返却備品を薄赤で表示
- 一覧で選択した備品IDを、貸出・返却・履歴入力欄へ自動反映
- 右クリックメニューから、貸出、返却、借主検索、貸出履歴を選択可能

### 備品登録

- 備品ID、備品名、区分を入力して登録
- 区分は `PC`、`プロジェクター`、`その他` から選択
- 備品IDの重複を禁止（大文字小文字は区別しません）

### 貸出・返却

- 備品ID、借主、貸出日、返却予定日を入力して貸出登録
- 貸出中備品の二重貸出を防止
- 備品ID、返却日を入力して返却登録
- 貸出日より前の返却予定日、貸出日より前の返却日は登録不可

### 検索・履歴

- 借主キーワードによる現在貸出中備品の検索
- 借主キーワード欄は Enter キーでも検索可能
- 「貸出中すべて」は借主キーワード欄を消さずに全件表示
- 備品IDごとの貸出履歴表示
- 備品ID欄は Enter キーでも履歴表示可能
- 返却済み / 貸出中の履歴状態を表示
- 貸出記録IDは `1`, `2`, `3` のような純粋な連番数値で採番
- 備品別貸出履歴は新しい記録を上に表示

## 保存先

データは GUIアプリの実行フォルダ配下に保存されます。

```text
data/item-rentals.json
```

例:

```text
OfficeItemRentalApp\bin\Debug\net48\data\item-rentals.json
```

アプリを終了しても登録内容と履歴は残ります。

## 既存CLI版の実行方法

```powershell
dotnet restore .\OfficeItemRentalApp.CLI\OfficeItemRentalApp.CLI.csproj --configfile NuGet.config
dotnet build .\OfficeItemRentalApp.sln --no-restore -m:1 -p:UseSharedCompilation=false
.\OfficeItemRentalApp.CLI\bin\Debug\net48\OfficeItemRentalApp.CLI.exe
```

## 明記していない仕様への対応方針

- データベースは使用せず、JSONファイルに保存します。
- 督促対象は「返却予定日が今日より前」かつ「未返却」の貸出として判定します。
- 備品マスタと貸出履歴を分け、返却日が未設定の貸出履歴を「現在貸出中」として扱います。
- 備品情報の編集、削除、履歴削除、社員マスタ管理は今回の実装対象外です。
- GUIはWinFormsで、画面は1フォーム構成です。
