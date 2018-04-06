using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loxon
{
    public partial class MagicFox : Form
    {
        public MagicFox()
        {
            InitializeComponent();
        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            string inputText = InputRichTextBox.Text;
            inputText = inputText.Trim();
            string[] variables = inputText.Split(null);
            string outputText = "";
            for (int i = 0; i < variables.Length; i++)
            {
                if (i == variables.Length - 1)
                {
                    outputText += variables[i];
                }
                else
                {
                    outputText += variables[i] + "|";
                }
                
            }
            OutputRichTextBox.Text = outputText;
        }
    }
}
