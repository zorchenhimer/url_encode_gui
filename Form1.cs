using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace url_encode_gui {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void txtInput_TextChanged(object sender, EventArgs e) {
			doUpdate();
		}

		private void doUpdate() {
			txtOutput.Text = "";
			if(txtInput.Text.Length == 0)
				return;

			//txtOutput.Text = System.Uri.EscapeUriString(txtInput.Text);
			txtOutput.Text = encode_string(txtInput.Text);
		}

		private void button1_Click(object sender, EventArgs e) {
			Clipboard.SetText(txtOutput.Text);
		}

		private string encode_string(string character) { 
			string ret = System.Uri.EscapeUriString(character);
			ret = ret.Replace(";", "%3B");
			ret = ret.Replace("!", "%21");
			ret = ret.Replace("#", "%23");
			ret = ret.Replace("$", "%24");
			ret = ret.Replace("&", "%26");
			ret = ret.Replace("'", "%27");
			ret = ret.Replace("(", "%28");
			ret = ret.Replace(")", "%29");
			ret = ret.Replace("*", "%2A");
			ret = ret.Replace("+", "%2B");
			ret = ret.Replace(",", "%2C");
			ret = ret.Replace("/", "%2F");
			ret = ret.Replace("=", "%3D");
			ret = ret.Replace("?", "%3F");
			ret = ret.Replace("@", "%40");
			ret = ret.Replace("~", "%7E");
			return ret;
		}
	}
}
