﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace timetracker.Services
{
    public static class PromptDouble
    {
        public static string ShowDialog(string text, string caption)
        {
            Form promptDouble = new Form()
            {
                Width = 460,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Text = caption + text,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabelAlias = new Label() { Left = 30, Top = 10, Text = "Alias for " + text };
            
            TextBox textBoxAlias = new TextBox() { Left = 30, Top = 35, Width = 400 };
            Label textLabelAddress = new Label() { Left = 30, Top = 70, Text = "Address for " + text };
            TextBox textBoxAddress = new TextBox() { Left = 30, Top = 95, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 290, Width = 60, Top = 130, DialogResult = DialogResult.OK };
            Button cancelation = new Button() { Text = "Cancel", Left = 370, Width = 60, Top = 130, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { promptDouble.Close(); };
            cancelation.Click += (sender, e) => { promptDouble.Close(); };
            promptDouble.Controls.Add(textBoxAlias);
            promptDouble.Controls.Add(textBoxAddress);
            promptDouble.Controls.Add(confirmation);
            promptDouble.Controls.Add(cancelation);
            promptDouble.Controls.Add(textLabelAlias);
            promptDouble.Controls.Add(textLabelAddress);
            promptDouble.AcceptButton = confirmation;


            List<string> lst = new List<string>();
            lst.Add(textBoxAlias.Text);
            lst.Add(textBoxAddress.Text);

            return promptDouble.ShowDialog() == DialogResult.OK ? lst.ToString() : null;
        }
    }
}
