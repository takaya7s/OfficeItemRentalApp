using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeItemRentalApp.Models;
using OfficeItemRentalApp.Services;

namespace OfficeItemRentalApp
{
    public sealed partial class MainForm : Form
    {
        private readonly string dataPath;
        private readonly JsonDataStore store;
        private ItemRentalService rentalService;

        public MainForm()
        {
            dataPath = Path.Combine(Application.StartupPath, "data", "item-rentals.json");
            store = new JsonDataStore(dataPath);
            rentalService = new ItemRentalService(store.Load(), store);

            InitializeComponent();
            InitializeRuntimeValues();
            RefreshAllViews("起動しました。保存先: " + dataPath);
        }

        private void InitializeRuntimeValues()
        {
            categoryComboBox.Items.Add(new CategoryComboItem(ItemCategory.Pc, "PC"));
            categoryComboBox.Items.Add(new CategoryComboItem(ItemCategory.Projector, "プロジェクター"));
            categoryComboBox.Items.Add(new CategoryComboItem(ItemCategory.Other, "その他"));
            categoryComboBox.SelectedIndex = 0;

            rentalDatePicker.Value = DateTime.Today;
            dueDatePicker.Value = DateTime.Today.AddDays(7);
            returnDatePicker.Value = DateTime.Today;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReloadFromFile();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterItem();
        }

        private void ClearItemInputButton_Click(object sender, EventArgs e)
        {
            ClearItemInput();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            RentItem();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturnItem();
        }

        private void BorrowerSearchButton_Click(object sender, EventArgs e)
        {
            SearchBorrowerRentals();
        }

        private void BorrowerAllButton_Click(object sender, EventArgs e)
        {
            SearchBorrowerRentals(string.Empty);
        }

        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            ShowItemHistory();
        }

        private void BorrowerKeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            SearchBorrowerRentals();
        }

        private void HistoryItemIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            ShowItemHistory();
        }

        private void ItemGridContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            string itemId;
            if (!TryGetSelectedItemId(itemGrid, out itemId))
            {
                e.Cancel = true;
                return;
            }

            var currentRental = rentalService.FindCurrentRental(itemId);
            itemGridRentToolStripMenuItem.Enabled = currentRental == null;
            itemGridReturnToolStripMenuItem.Enabled = currentRental != null;
            itemGridBorrowerSearchToolStripMenuItem.Enabled = currentRental != null;
            itemGridHistoryToolStripMenuItem.Enabled = true;
        }

        private void ItemGridRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRentFromItemList();
        }

        private void ItemGridReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReturnFromItemList();
        }

        private void ItemGridBorrowerSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBorrowerSearchFromItemList();
        }

        private void ItemGridHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHistoryFromItemList();
        }

        private void ItemGrid_SelectionChanged(object sender, EventArgs e)
        {
            ApplySelectedItemToInputs(itemGrid);
        }

        private void ItemGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplySelectedItemToInputs(itemGrid);
        }

        private void ItemGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
            {
                return;
            }

            itemGrid.ClearSelection();
            itemGrid.Rows[e.RowIndex].Selected = true;

            if (e.ColumnIndex >= 0)
            {
                itemGrid.CurrentCell = itemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }

            ApplySelectedItemToInputs(itemGrid);
        }

        private void RentalItemGrid_SelectionChanged(object sender, EventArgs e)
        {
            ApplySelectedItemToInputs(rentalItemGrid);
        }

        private void RentalItemGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplySelectedItemToInputs(rentalItemGrid);
        }

        private void OpenRentFromItemList()
        {
            string itemId;
            if (!TryGetSelectedItemId(itemGrid, out itemId))
            {
                return;
            }

            ApplySelectedItemToInputs(itemGrid);
            mainTabControl.SelectedTab = rentReturnTabPage;
            rentItemIdTextBox.Text = itemId;
            borrowerNameTextBox.Focus();
            SetStatus(string.Format("{0} の貸出入力を開きました。", itemId));
        }

        private void OpenReturnFromItemList()
        {
            string itemId;
            if (!TryGetSelectedItemId(itemGrid, out itemId))
            {
                return;
            }

            ApplySelectedItemToInputs(itemGrid);
            mainTabControl.SelectedTab = rentReturnTabPage;
            returnItemIdTextBox.Text = itemId;
            returnDatePicker.Focus();
            SetStatus(string.Format("{0} の返却入力を開きました。", itemId));
        }

        private void OpenBorrowerSearchFromItemList()
        {
            string itemId;
            if (!TryGetSelectedItemId(itemGrid, out itemId))
            {
                return;
            }

            var currentRental = rentalService.FindCurrentRental(itemId);
            if (currentRental == null)
            {
                ShowWarning("この備品は現在貸出中ではありません。");
                return;
            }

            mainTabControl.SelectedTab = searchHistoryTabPage;
            borrowerKeywordTextBox.Text = currentRental.BorrowerName;
            SearchBorrowerRentals();
            borrowerKeywordTextBox.Focus();
        }

        private void OpenHistoryFromItemList()
        {
            string itemId;
            if (!TryGetSelectedItemId(itemGrid, out itemId))
            {
                return;
            }

            mainTabControl.SelectedTab = searchHistoryTabPage;
            historyItemIdTextBox.Text = itemId;
            ShowItemHistory();
            historyItemIdTextBox.Focus();
        }

        private void ClearItemInput()
        {
            itemIdTextBox.Clear();
            itemNameTextBox.Clear();
            categoryComboBox.SelectedIndex = 0;
            itemIdTextBox.Focus();
        }

        private void RegisterItem()
        {
            var itemId = itemIdTextBox.Text.Trim();
            var itemName = itemNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemId))
            {
                ShowWarning("備品IDを入力してください。");
                itemIdTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(itemName))
            {
                ShowWarning("備品名を入力してください。");
                itemNameTextBox.Focus();
                return;
            }

            var categoryItem = categoryComboBox.SelectedItem as CategoryComboItem;
            var category = categoryItem == null ? ItemCategory.Other : categoryItem.Category;
            var result = rentalService.RegisterItem(itemId, itemName, category);

            switch (result.Status)
            {
                case RegisterItemStatus.Success:
                    ClearItemInput();
                    RefreshAllViews("備品を登録しました。");
                    break;
                case RegisterItemStatus.DuplicateId:
                    ShowWarning("同じ備品IDがすでに登録されています。");
                    break;
            }
        }

        private void RentItem()
        {
            var itemId = rentItemIdTextBox.Text.Trim();
            var borrowerName = borrowerNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemId))
            {
                ShowWarning("備品IDを入力してください。");
                rentItemIdTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(borrowerName))
            {
                ShowWarning("借主を入力してください。");
                borrowerNameTextBox.Focus();
                return;
            }

            var rentalDate = rentalDatePicker.Value.Date;
            var dueDate = dueDatePicker.Value.Date;
            var result = rentalService.RentItem(itemId, borrowerName, rentalDate, dueDate);

            switch (result.Status)
            {
                case RentItemStatus.Success:
                    borrowerNameTextBox.Clear();
                    dueDatePicker.Value = DateTime.Today.AddDays(7);
                    RefreshAllViews("貸出を登録しました。");
                    break;
                case RentItemStatus.ItemNotFound:
                    ShowWarning("指定された備品IDは登録されていません。");
                    break;
                case RentItemStatus.AlreadyRented:
                    var current = result.ExistingRental;
                    var message = current == null
                        ? "この備品は現在貸出中です。"
                        : string.Format("この備品は現在貸出中です。\n借主: {0}, 返却予定日: {1}", current.BorrowerName, FormatDate(current.DueDate));
                    ShowWarning(message);
                    break;
                case RentItemStatus.DueDateBeforeRentalDate:
                    ShowWarning("返却予定日は貸出日以降の日付を指定してください。");
                    break;
            }
        }

        private void ReturnItem()
        {
            var itemId = returnItemIdTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemId))
            {
                ShowWarning("備品IDを入力してください。");
                returnItemIdTextBox.Focus();
                return;
            }

            var result = rentalService.ReturnItem(itemId, returnDatePicker.Value.Date);
            switch (result.Status)
            {
                case ReturnItemStatus.Success:
                    RefreshAllViews("返却を登録しました。");
                    break;
                case ReturnItemStatus.ItemNotFound:
                    ShowWarning("指定された備品IDは登録されていません。");
                    break;
                case ReturnItemStatus.NotRented:
                    ShowWarning("この備品は現在貸出中ではありません。");
                    break;
                case ReturnItemStatus.ReturnDateBeforeRentalDate:
                    ShowWarning("返却日は貸出日以降の日付を指定してください。");
                    break;
            }
        }

        private void SearchBorrowerRentals()
        {
            SearchBorrowerRentals(borrowerKeywordTextBox.Text.Trim());
        }

        private void SearchBorrowerRentals(string keyword)
        {
            borrowerGrid.Rows.Clear();
            keyword = keyword ?? string.Empty;
            var rows = rentalService.GetCurrentRentalsByBorrower(keyword, DateTime.Today);

            foreach (var row in rows)
            {
                if (row.Item == null)
                {
                    continue;
                }

                var index = borrowerGrid.Rows.Add(
                    row.Item.Id,
                    row.Item.Name,
                    GetCategoryDisplayName(row.Item.Category),
                    row.Rental.BorrowerName,
                    FormatDate(row.Rental.RentalDate),
                    FormatDate(row.Rental.DueDate),
                    row.IsOverdue ? "督促対象" : string.Empty);

                if (row.IsOverdue)
                {
                    borrowerGrid.Rows[index].DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }

            if (rows.Count == 0)
            {
                SetStatus(string.IsNullOrWhiteSpace(keyword) ? "貸出中の備品はありません。" : "該当する貸出中の備品はありません。");
                return;
            }

            SetStatus(string.IsNullOrWhiteSpace(keyword)
                ? string.Format("{0}件の貸出中備品をすべて表示しました。", rows.Count)
                : string.Format("{0}件の貸出中備品を表示しました。", rows.Count));
        }

        private void ShowItemHistory()
        {
            historyGrid.Rows.Clear();
            var itemId = historyItemIdTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemId))
            {
                ShowWarning("備品IDを入力してください。");
                historyItemIdTextBox.Focus();
                return;
            }

            var result = rentalService.GetItemHistory(itemId);
            if (result.Status == ItemHistoryStatus.ItemNotFound)
            {
                ShowWarning("指定された備品IDは登録されていません。");
                return;
            }

            foreach (var rental in result.Rentals)
            {
                historyGrid.Rows.Add(
                    rental.RecordId,
                    rental.BorrowerName,
                    FormatDate(rental.RentalDate),
                    FormatDate(rental.DueDate),
                    rental.ReturnDate.HasValue ? FormatDate(rental.ReturnDate.Value) : string.Empty,
                    rental.ReturnDate.HasValue ? "返却済み" : "貸出中");
            }

            SetStatus(string.Format("{0} / {1} の履歴を表示しました。", result.Item.Id, result.Item.Name));
        }

        private void ReloadFromFile()
        {
            rentalService = new ItemRentalService(store.Load(), store);
            RefreshAllViews("ファイルから再読み込みしました。");
        }

        private void RefreshAllViews(string message)
        {
            FillItemGrid(itemGrid);
            FillItemGrid(rentalItemGrid);
            SearchBorrowerRentals();
            SetStatus(message);
        }

        private void FillItemGrid(DataGridView grid)
        {
            if (grid == null)
            {
                return;
            }

            grid.Rows.Clear();
            var rows = rentalService.GetItemList(DateTime.Today);

            foreach (var row in rows)
            {
                var item = row.Item;
                var rental = row.CurrentRental;
                var index = grid.Rows.Add(
                    item.Id,
                    item.Name,
                    GetCategoryDisplayName(item.Category),
                    rental == null ? "利用可" : "貸出中",
                    rental == null ? string.Empty : rental.BorrowerName,
                    rental == null ? string.Empty : FormatDate(rental.RentalDate),
                    rental == null ? string.Empty : FormatDate(rental.DueDate),
                    row.IsOverdue ? "督促対象" : string.Empty);

                grid.Rows[index].Tag = item.Id;
                if (row.IsOverdue)
                {
                    grid.Rows[index].DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }
        }

        private static bool TryGetSelectedItemId(DataGridView grid, out string itemId)
        {
            itemId = string.Empty;

            if (grid == null || grid.CurrentRow == null || grid.CurrentRow.Tag == null)
            {
                return false;
            }

            itemId = grid.CurrentRow.Tag.ToString();
            return !string.IsNullOrWhiteSpace(itemId);
        }

        private void ApplySelectedItemToInputs(DataGridView grid)
        {
            if (grid == null || grid.CurrentRow == null || grid.CurrentRow.Tag == null)
            {
                return;
            }

            var itemId = grid.CurrentRow.Tag.ToString();

            if (rentItemIdTextBox != null)
            {
                rentItemIdTextBox.Text = itemId;
            }

            if (returnItemIdTextBox != null)
            {
                returnItemIdTextBox.Text = itemId;
            }

            if (historyItemIdTextBox != null)
            {
                historyItemIdTextBox.Text = itemId;
            }
        }

        private static string FormatDate(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

        private static string GetCategoryDisplayName(ItemCategory category)
        {
            switch (category)
            {
                case ItemCategory.Pc:
                    return "PC";
                case ItemCategory.Projector:
                    return "プロジェクター";
                case ItemCategory.Other:
                default:
                    return "その他";
            }
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(this, message, "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SetStatus(message);
        }

        private void SetStatus(string message)
        {
            if (statusLabel != null)
            {
                statusLabel.Text = message;
            }
        }

        private sealed class CategoryComboItem
        {
            public CategoryComboItem(ItemCategory category, string displayName)
            {
                Category = category;
                DisplayName = displayName;
            }

            public ItemCategory Category { get; private set; }

            public string DisplayName { get; private set; }

            public override string ToString()
            {
                return DisplayName;
            }
        }
    }
}
