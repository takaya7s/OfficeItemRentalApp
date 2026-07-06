# 備品貸出管理アプリ

社内備品（ノートPC、プロジェクター等）の貸出状況を管理する C# 7.3 / .NET Framework 4.8 のコンソールアプリです。

## 実行方法

### 前提環境

- .NET Framework 4.8
- .NET Framework 4.8 Developer Pack、または Visual Studio の .NET Framework 4.8 開発環境
- C# 7.3
- NuGet パッケージ復元ができること

`System.Text.Json` は .NET Framework 4.8 標準同梱ではないため、NuGet パッケージとして参照しています。

### コマンドで実行する場合

1. ソリューションフォルダに移動します。

   ```powershell
   cd E:\dev\Codex\work\OfficeItemRentalApp
   ```

2. NuGet パッケージを復元してビルドします。

   ```powershell
   dotnet restore .\OfficeItemRentalApp.CLI\OfficeItemRentalApp.CLI.csproj --configfile NuGet.config
   dotnet build OfficeItemRentalApp.sln --no-restore -m:1 -p:UseSharedCompilation=false
   ```

3. 生成された exe を実行します。

   ```powershell
   .\OfficeItemRentalApp.CLI\bin\Debug\net48\OfficeItemRentalApp.CLI.exe
   ```

Visual Studio で開く場合は、`OfficeItemRentalApp.sln` を開いてビルド、実行してください。

起動後はメニュー番号を入力して操作します。

   ```text
   ===== 備品貸出管理システム =====
   1. 備品登録
   2. 貸出処理
   3. 返却処理
   4. 備品一覧表示
   5. 社員別貸出状況の確認
   6. 備品別の貸出履歴表示
   7. 終了
   ```

## 実装機能

- 備品登録（備品ID、備品名、区分）
- 貸出処理（借主、貸出日、返却予定日を記録）
- 貸出中備品の二重貸出防止
- 返却処理（返却日を記録）
- 備品一覧表示（貸出中、利用可、督促対象を表示）
- 社員別の現在貸出中備品一覧
- 備品別の貸出履歴表示
- メニュー形式での操作と終了

## テスト

テストケースと実施手順は [TEST_CASES.md](TEST_CASES.md) に記載しています。

## ファイル構成

```text
OfficeItemRentalApp/
├─ OfficeItemRentalApp.sln             ソリューションファイル
├─ README.md
├─ TEST_CASES.md
├─ OfficeItemRentalApp.CLI/
│  ├─ OfficeItemRentalApp.CLI.csproj   起動プロジェクト
│  └─ Program.cs                       アプリ起動処理
└─ OfficeItemRentalApp.Core/
   ├─ OfficeItemRentalApp.Core.csproj  Core プロジェクト
   ├─ ConsoleUI/
   │  ├─ ItemRentalConsoleApp.cs        メニュー表示とコンソール操作
   │  ├─ ConsoleInput.cs                入力受付、日付入力、区分選択
   │  └─ DisplayFormatter.cs            日付や督促表示の整形
   ├─ Models/
   │  ├─ Item.cs                        備品データ
   │  ├─ ItemCategory.cs                備品区分
   │  ├─ RentalDatabase.cs              保存対象データ全体
   │  └─ RentalRecord.cs                貸出記録
   └─ Services/
      ├─ ItemRentalService.cs           貸出、返却、検索、履歴取得の業務ロジック
      └─ JsonDataStore.cs               JSON ファイル保存と読み込み
```

## 明記していない仕様への対応方針

- データはアプリ実行ディレクトリ配下の `data/item-rentals.json` に保存します。アプリを終了しても登録内容と履歴は残ります。
- JSON 保存には NuGet パッケージの `System.Text.Json` を使用しています。
- 貸出日は入力できます。空欄の場合は実行日の今日を自動設定します。
- 返却日も入力できます。空欄の場合は実行日の今日を自動設定します。
- 日付入力は `yyyy/MM/dd`、`yyyy-MM-dd`、`yyyyMMdd` に対応しています。
- 督促対象は「返却予定日が今日より前」かつ「未返却」の貸出として判定します。
- 備品IDの重複は、大文字小文字を区別せずに禁止します。
- 社員別貸出状況は、社員名の部分一致で検索できるようにしています。
- 備品の削除、備品情報の編集、履歴削除は今回の最低限要件に含めていません。

## 実装時に工夫した点

- 後から修正しやすいように、起動処理だけを `OfficeItemRentalApp.CLI` に残し、コンソールUI、業務ロジック、データモデル、保存処理を `OfficeItemRentalApp.Core` に分けました。
- 備品マスタと貸出記録を分け、返却日が未登録の貸出記録を「現在貸出中」として扱う構成にしました。
- 現在状況、督促対象、社員別検索、備品別履歴を同じ貸出記録から集計できるようにしました。
- JSON 保存にして、データベースなしでも試作ツールとして継続利用できるようにしました。
- 貸出日より前の返却予定日、貸出日より前の返却日は登録できないようにしました。

## 時間があれば改善したい点

- 備品情報の編集、削除、廃棄済み管理
- CSV インポート/エクスポート
- 返却期限が近い備品の一覧表示
- 社員名や部署のマスタ管理
- 将来的な Web UI 化やデータベース化
