/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
using System.Globalization;

namespace Lab5;

public static class InputDialog
{
    public static bool TryGetInputDouble(string moduleName, out double value)
    {
        value = 0;

        using Form prompt = new();
        prompt.Width = 360;
        prompt.Height = 170;
        prompt.Text = $"Input for {moduleName}";
        prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
        prompt.MaximizeBox = false;
        prompt.MinimizeBox = false;
        prompt.StartPosition = FormStartPosition.CenterParent;

        Label inputLabel = new()
        {
            Left = 16,
            Top = 18,
            Width = 320,
            Text = "Enter a numeric value:"
        };

        TextBox inputTextBox = new()
        {
            Left = 16,
            Top = 45,
            Width = 320
        };

        Button confirmButton = new()
        {
            Left = 180,
            Top = 80,
            Width = 75,
            Text = "OK",
            DialogResult = DialogResult.OK
        };

        Button cancelButton = new()
        {
            Left = 261,
            Top = 80,
            Width = 75,
            Text = "Cancel",
            DialogResult = DialogResult.Cancel
        };

        prompt.Controls.Add(inputLabel);
        prompt.Controls.Add(inputTextBox);
        prompt.Controls.Add(confirmButton);
        prompt.Controls.Add(cancelButton);
        prompt.AcceptButton = confirmButton;
        prompt.CancelButton = cancelButton;

        while (true)
        {
            DialogResult result = prompt.ShowDialog();
            if (result != DialogResult.OK)
            {
                return false;
            }

            if (double.TryParse(
                    inputTextBox.Text,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    CultureInfo.CurrentCulture,
                    out value)
                || double.TryParse(
                    inputTextBox.Text,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    CultureInfo.InvariantCulture,
                    out value))
            {
                return true;
            }

            MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            inputTextBox.SelectAll();
            inputTextBox.Focus();
        }
    }
}
