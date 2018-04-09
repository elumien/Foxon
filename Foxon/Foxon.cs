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
            Format(0);
        }

        private void RainbowButton_Click(object sender, EventArgs e)
        {
            Format(1);
        }

        private void Format(int type)
        {
            string inputText = InputRichTextBox.Text;
            inputText = inputText.Trim();
            string[] variables = inputText.Split('\n');


            string outputText = "";
            for (int i = 0; i < variables.Length; i++)
            {
                switch (type)
                {
                    case 0:
                        if (i == variables.Length - 1)
                        {
                            outputText += variables[i];
                        }
                        else
                        {
                            outputText += variables[i] + "|";
                        }
                    break;

                    case 1:
                        if (i == variables.Length - 1)
                        {
                            outputText += variables[i];
                        }
                        else
                        {
                            outputText += variables[i] + "\t";
                        }
                        break;

                }

            }
            OutputRichTextBox.Text = outputText;
        }


    }
}
