namespace Kodansha_KanjiSearch
{
    partial class KanjiSearchUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanjiSearchUI));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.kanjiSearchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.historyView = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(620, 40);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 21);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "About";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // kanjiSearchBox
            // 
            this.kanjiSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kanjiSearchBox.Depth = 0;
            this.kanjiSearchBox.Hint = "Enter Kanji(s)/ID to search";
            this.kanjiSearchBox.Location = new System.Drawing.Point(23, 86);
            this.kanjiSearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.kanjiSearchBox.Name = "kanjiSearchBox";
            this.kanjiSearchBox.PasswordChar = '\0';
            this.kanjiSearchBox.SelectedText = "";
            this.kanjiSearchBox.SelectionLength = 0;
            this.kanjiSearchBox.SelectionStart = 0;
            this.kanjiSearchBox.Size = new System.Drawing.Size(457, 28);
            this.kanjiSearchBox.TabIndex = 1;
            this.kanjiSearchBox.UseSystemPasswordChar = false;
            this.kanjiSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBtn.AutoSize = true;
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Depth = 0;
            this.searchBtn.Location = new System.Drawing.Point(178, 123);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Primary = false;
            this.searchBtn.Size = new System.Drawing.Size(79, 36);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outputBox);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.kanjiSearchBox);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 533);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchTab";
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(23, 214);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(444, 313);
            this.outputBox.TabIndex = 3;
            this.outputBox.Text = "";
            this.outputBox.WordWrap = false;
            this.outputBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.outputBox_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.materialFlatButton1);
            this.groupBox2.Controls.Add(this.historyView);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(504, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 533);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(23, 491);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(140, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Clear History";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // historyView
            // 
            this.historyView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historyView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historyView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyView.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.historyView.ForeColor = System.Drawing.SystemColors.Window;
            this.historyView.FormattingEnabled = true;
            this.historyView.ItemHeight = 25;
            this.historyView.Location = new System.Drawing.Point(6, 34);
            this.historyView.Name = "historyView";
            this.historyView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyView.Size = new System.Drawing.Size(179, 450);
            this.historyView.TabIndex = 0;
            this.historyView.SelectedIndexChanged += new System.EventHandler(this.historyView_SelectedIndexChanged);
            // 
            // KanjiSearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(707, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KanjiSearchUI";
            this.Text = "Kodansha KanjiSearch 漢字";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField kanjiSearchBox;
        private MaterialSkin.Controls.MaterialFlatButton searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.ListBox historyView;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;




    }
}

