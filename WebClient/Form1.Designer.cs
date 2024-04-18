namespace WebClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDataGet = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxTabDel = new System.Windows.Forms.TextBox();
            this.textBoxIdDel = new System.Windows.Forms.TextBox();
            this.labelTabellaDel = new System.Windows.Forms.Label();
            this.labelIdDel = new System.Windows.Forms.Label();
            this.textBoxIdGet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatiPP = new System.Windows.Forms.TextBox();
            this.textBoxTabellaPP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(296, 62);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1099, 66);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(1099, 110);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(75, 23);
            this.buttonPut.TabIndex = 2;
            this.buttonPut.Text = "PUT";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(644, 292);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDataGet
            // 
            this.textBoxDataGet.Location = new System.Drawing.Point(30, 41);
            this.textBoxDataGet.Name = "textBoxDataGet";
            this.textBoxDataGet.Size = new System.Drawing.Size(235, 23);
            this.textBoxDataGet.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(30, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 562);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBoxTabDel
            // 
            this.textBoxTabDel.Location = new System.Drawing.Point(511, 265);
            this.textBoxTabDel.Name = "textBoxTabDel";
            this.textBoxTabDel.Size = new System.Drawing.Size(100, 23);
            this.textBoxTabDel.TabIndex = 6;
            this.textBoxTabDel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIdDel
            // 
            this.textBoxIdDel.Location = new System.Drawing.Point(511, 318);
            this.textBoxIdDel.Name = "textBoxIdDel";
            this.textBoxIdDel.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdDel.TabIndex = 7;
            this.textBoxIdDel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelTabellaDel
            // 
            this.labelTabellaDel.AutoSize = true;
            this.labelTabellaDel.Location = new System.Drawing.Point(511, 247);
            this.labelTabellaDel.Name = "labelTabellaDel";
            this.labelTabellaDel.Size = new System.Drawing.Size(43, 15);
            this.labelTabellaDel.TabIndex = 8;
            this.labelTabellaDel.Text = "Tabella";
            this.labelTabellaDel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTabellaDel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelIdDel
            // 
            this.labelIdDel.AutoSize = true;
            this.labelIdDel.Location = new System.Drawing.Point(511, 300);
            this.labelIdDel.Name = "labelIdDel";
            this.labelIdDel.Size = new System.Drawing.Size(18, 15);
            this.labelIdDel.TabIndex = 9;
            this.labelIdDel.Text = "ID";
            this.labelIdDel.Click += new System.EventHandler(this.labelIdDel_Click);
            // 
            // textBoxIdGet
            // 
            this.textBoxIdGet.Location = new System.Drawing.Point(30, 86);
            this.textBoxIdGet.Name = "textBoxIdGet";
            this.textBoxIdGet.Size = new System.Drawing.Size(235, 23);
            this.textBoxIdGet.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tabella";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tabella";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxDatiPP
            // 
            this.textBoxDatiPP.Location = new System.Drawing.Point(514, 127);
            this.textBoxDatiPP.Name = "textBoxDatiPP";
            this.textBoxDatiPP.Size = new System.Drawing.Size(527, 23);
            this.textBoxDatiPP.TabIndex = 14;
            // 
            // textBoxTabellaPP
            // 
            this.textBoxTabellaPP.Location = new System.Drawing.Point(514, 61);
            this.textBoxTabellaPP.Name = "textBoxTabellaPP";
            this.textBoxTabellaPP.Size = new System.Drawing.Size(182, 23);
            this.textBoxTabellaPP.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDatiPP);
            this.Controls.Add(this.textBoxTabellaPP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdGet);
            this.Controls.Add(this.labelIdDel);
            this.Controls.Add(this.labelTabellaDel);
            this.Controls.Add(this.textBoxIdDel);
            this.Controls.Add(this.textBoxTabDel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxDataGet);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonGet);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGet;
        private Button buttonPost;
        private Button buttonPut;
        private Button buttonDelete;
        private TextBox textBoxDataGet;
        private ListView listView1;
        private TextBox textBoxTabDel;
        private TextBox textBoxIdDel;
        private Label labelTabellaDel;
        private Label labelIdDel;
        private TextBox textBoxIdGet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDatiPP;
        private TextBox textBoxTabellaPP;
    }
}