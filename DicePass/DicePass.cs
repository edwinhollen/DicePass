using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DicePass
{
    public partial class DicePass : Form
    {
        private String wordlist_location = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/wordlist.asc";
        private Dictionary<String, String> wordList;
        private readonly char[] extraChars = {
                                              '~', '!', '#', '$', '%', '^',
                                              '&', '*', '(', ')', '-', '=',
                                              '+', '[', ']', '\\', '{', '}',
                                              ':', ';', '"', '\'', '<', '>',
                                              '?', '/', '0', '1', '2', '3',
                                              '4', '5', '6', '7', '8', '9'
                                          };
        public DicePass()
        {
            InitializeComponent();
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            String pass = "";
            rich_rolls.Text = "";
            lbl_status.Text = "Generating...";
            for (int w = 0; w < num_words.Value; w++)
            {
                string rollString = "";
                for (int r = 0; r < 5; r++)
                {
                    rollString += random.Next(1, 6).ToString();
                    
                }
                string word = wordList[rollString];
                pass += word;
                pass += " ";

                rich_rolls.AppendText(rollString + "\t" + word + "\n");
            }

            if (chk_extraChar.Checked)
            {
                int thirdRoll = random.Next(1, 6);
                int fourthRoll = random.Next(1, 6);
                String extraChar = Char.ToString(extraChars[random.Next(0, extraChars.Length - 1)]);
                int extraCharInsertAt = random.Next(0, pass.Length - 1);
                pass = pass.Insert(extraCharInsertAt, extraChar);
            }

            txt_output.Text = pass.Trim();

            

            txt_output.Focus();
            txt_output.SelectAll();
            lbl_status.Text = "OK";
        }

        private void chk_showRolls_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showRolls.Checked)
            {
                rich_rolls.Visible = true;
            }
            else
            {
                rich_rolls.Visible = false;
            }
        }

        private void DicePass_Load(object sender, EventArgs e)
        {
            wordList = new Dictionary<String, String>();
            btn_generate.Enabled = false;
            lbl_status.Text = "Error: Can't find wordlist.asc";
            rich_rolls.Visible = false;



            if (System.IO.File.Exists(wordlist_location))
            {
                string[] lines = System.IO.File.ReadAllLines(wordlist_location);
                for (int l = 0; l < lines.Length; l++)
                {
                    string line = lines[l];
                    if (line.Length < 5)
                    {
                        continue;
                    }
                    else if (line.Equals((String)("-----BEGIN PGP SIGNED MESSAGE-----")))
                    {
                        continue;
                    }
                    else if (line.Equals((String)("-----BEGIN PGP SIGNATURE-----")))
                    {
                        break;
                    }
                    else
                    {
                        string[] lineParts = line.Split('\t');
                        wordList.Add(lineParts[0], lineParts[1]);
                    }
                }

                lbl_status.Text = "OK";
                btn_generate.Enabled = true;
            }
        }
    }
}
