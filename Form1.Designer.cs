namespace url_encode_gui {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtInput);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
			this.splitContainer1.Size = new System.Drawing.Size(414, 334);
			this.splitContainer1.SplitterDistance = 156;
			this.splitContainer1.TabIndex = 0;
			// 
			// txtInput
			// 
			this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtInput.Location = new System.Drawing.Point(3, 3);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(408, 150);
			this.txtInput.TabIndex = 0;
			this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Copy Text";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(3, 3);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(408, 139);
			this.txtOutput.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 334);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(422, 334);
			this.Name = "Form1";
			this.Text = "URL Encoder";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button button1;
	}
}

