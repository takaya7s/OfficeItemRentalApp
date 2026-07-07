using System;
using System.Windows.Forms;

namespace OfficeItemRentalApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new MainForm());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message + Environment.NewLine + "データファイルを確認してから再実行してください。",
                    "起動エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
