using System.Windows.Forms;

namespace timetracker.Services
{
    /// <summary>
    /// Helper static class to display a Prompt Dialog 
    /// </summary>
    public static class Prompt
    {
        /// <summary>
        /// Create a prompt dialog
        /// </summary>
        /// <param name="text">Prompt text</param>
        /// <param name="caption">Window caption</param>
        /// <returns>User Input if user clicks "OK" or null if input cancelled.</returns>
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 460,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 30, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 30, Top = 35, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 290, Width = 60, Top = 70, DialogResult = DialogResult.OK };
            Button cancelation = new Button() { Text = "Cancel", Left = 370, Width = 60, Top = 70, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancelation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
