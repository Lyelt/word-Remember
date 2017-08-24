using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Web;

namespace WordRemember
{
    public partial class Form1 : Form
    {
        const string accountSid = "AC745428833581bbdeba62d57c2350a2b6";
        const string authToken = "a235fd21288955916afea1269aae577c";
        public int numLetters;
        public string scrambledWord;
        public string beginWord;
        public string endWord;
        public string otherWord;
        public string[] words = { };
        public List<string> resultList = new List<string>();
        public string inFile = string.Empty;

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                InitializeClient(); 
                inFile = dictionary_textBox.Text;
                words = File.ReadAllLines(inFile);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(string.Format("Could not find file: " + inFile), "File Not Found Exception");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(ex.Message + ex.StackTrace), "Failed to initialize.");
            }
        }

        private void InitializeClient()
        {
            TwilioClient.Init(accountSid, authToken);
        }

        private void substringButton_CheckedChanged(object sender, EventArgs e)
        {
            textbox_beginWord.Enabled = substringButton.Checked;
            textbox_endWord.Enabled = substringButton.Checked;
            textbox_other.Enabled = substringButton.Checked;

            textbox_scrambled.Enabled = !substringButton.Checked;
            numeric_numLetters.Enabled = !substringButton.Checked;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            resultList.Clear();
            if (unscrambleButton.Checked)
            {
                numLetters = (int)numeric_numLetters.Value;
                scrambledWord = textbox_scrambled.Text;
                GenerateUnscrambledWords();
                sendText_button.Enabled = true;
            }
            else
            {
                beginWord = textbox_beginWord.Text;
                endWord = textbox_endWord.Text;
                GenerateSubstringWords();
            }

            outputBox.Items.Clear();
            foreach (var result in resultList)
            {
                outputBox.Items.Add(result);
                outputBox.Refresh();
            }
        }

        private void GenerateSubstringWords()
        {
            foreach (var word in words)
            {
                if (word.StartsWith(beginWord) && word.EndsWith(endWord))
                {
                    resultList.Add(word);
                }
            }
        }

        private void GenerateUnscrambledWords()
        {
            foreach (var word in words)
            {
                var wordLetters = word.ToCharArray().ToList();
                var matchLetters = scrambledWord.ToCharArray().ToList();

                bool correctLength = word.Length == numLetters;
                bool correctLetters = true;

                if (!correctLength)
                    continue;

                foreach (char c in wordLetters)
                {
                    // If the array contains one of the letters, remove it from the char array
                    if (matchLetters.Contains(c))
                    {
                        matchLetters.Remove(c);
                    }
                    else
                    {
                        correctLetters = false;
                        break;
                    }
                }

                if (correctLetters)
                {
                    resultList.Add(word);
                }
            }
        }

        private void sendText_button_Click(object sender, EventArgs e)
        {
            SendText();
        }

        private void SendText()
        {
            try
            {
                string msg = GetTextMsg();

                MessageResource.Create(
                    from: new PhoneNumber("+12038711101"),
                    to: new PhoneNumber(phoneNumber_textBox.Text),
                    body: msg
                );

                outputBox.Items.Clear();
                resultList.Clear();
                MessageBox.Show("Message sent successfully.", "Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(ex.Message + ex.StackTrace), "Failed to send SMS message");
            }
        }

        private string GetTextMsg()
        {
            StringBuilder sb = new StringBuilder(string.Format("Hugs and kisses! Here is '{0}' unscrambled into {1}-letter words.\n----------\n", scrambledWord, numLetters));
            foreach (var word in resultList)
            {
                sb.AppendLine(string.Format(" - " + word));
            }

            return sb.ToString();
        }
    }
}
