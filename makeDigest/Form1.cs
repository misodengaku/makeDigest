using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makeDigest
{
    public partial class Form1 : Form
	{
		private static readonly string passwordChars = "0123456789abcdefghijklmnopqrstuvwxyz";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a1 = textBox1.Text;
            var nonce = textBox2.Text;
            var nc = textBox3.Text;
            var cnonce = textBox4.Text;
            var qop = textBox5.Text;
            var a2 = textBox6.Text;

            var response = GetMD5(a1 + ":" + nonce + ":" + nc + ":" + cnonce + ":" + qop + ":" + a2);
			textBox8.Text = response;
			textBox7.Text = "Authorization: Digest username=\"" + userNameBox.Text + "\", realm=\"" + realmBox.Text + "\", nonce=\"" + nonce + "\", uri=\"" + urlBox.Text + "\", algorithm=MD5, response=\"" + response + "\", qop=\"" + textBox5.Text + "\", nc=" + textBox3.Text + ", cnonce=\"" + cnonce + "\"";
        }

        private string GetMD5(string str)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var data = Encoding.UTF8.GetBytes(str);
            var bs = md5.ComputeHash(data);
            md5.Clear();
            string result = BitConverter.ToString(bs).ToLower().Replace("-","");

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
			Dive("", 13, respBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = GeneratePassword(8);
        }

        public string GeneratePassword(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                int pos = r.Next(passwordChars.Length);
                char c = passwordChars[pos];
                sb.Append(c);
            }

            return sb.ToString();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = GetMD5(userNameBox.Text + ":" + realmBox.Text + ":" + passwordBox.Text);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox6.Text = GetMD5(((string)(comboBox1.SelectedItem)) + ":" + urlBox.Text);
		}

		//よくない
		int maxlength = 14;
		string ValidChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ,|+_-=\\][{}';\":/.,<>?!@#$%^&*()";
		private void Attack(string targetresp)
		{
			int level = 1;
			string prefix = "";
			var user = userNameBox.Text;
			var realm = realmBox.Text;
			var nonce = textBox2.Text;
			var nc = textBox3.Text;
			var cnonce = textBox4.Text;
			var qop = textBox5.Text;
			var a2 = GetMD5(((string)(comboBox1.SelectedItem)) + ":" + urlBox.Text);
			while (level <= 12)
			{
				foreach (char c in ValidChars)
				{
					prefix += c;
					var a1 = GetMD5(user + ":" + realm + ":" + prefix);
					var response = GetMD5(a1 + ":" + nonce + ":" + nc + ":" + cnonce + ":" + qop + ":" + a2);
					if (level < maxlength)
					{
						//Dive(prefix + c, level);
					}
				}
			}
		}



		private void Dive(string prefix, int level, string targetresp)
		{
			
			var user = userNameBox.Text;
			var realm = realmBox.Text;
			var nonce = textBox2.Text;
			var nc = textBox3.Text;
			var cnonce = textBox4.Text;
			var qop = textBox5.Text;
			var a2 = GetMD5(((string)(comboBox1.SelectedItem)) + ":" + urlBox.Text);
			level += 1;
			foreach (char c in ValidChars)
			{
				var a1 = GetMD5(user + ":" + realm + ":" + prefix);
				var response = GetMD5(a1 + ":" + nonce + ":" + nc + ":" + cnonce + ":" + qop + ":" + a2);
				if (targetresp == response)
					break;
				if (level < maxlength)
				{
					Dive(prefix + c, level, targetresp);
				}
			}
		}

    }
}
