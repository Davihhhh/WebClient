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
            buttonGet = new Button();
            buttonPost = new Button();
            buttonPut = new Button();
            buttonDelete = new Button();
            textBoxDataGet = new TextBox();
            textBoxTabDel = new TextBox();
            textBoxIdDel = new TextBox();
            labelTabellaDel = new Label();
            labelIdDel = new Label();
            textBoxIdGet = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDatiPP = new TextBox();
            textBoxTabellaPP = new TextBox();
            groupBoxDelete = new GroupBox();
            groupBoxPP = new GroupBox();
            groupBoxGet = new GroupBox();
            buttonOptions = new Button();
            groupBoxOptions = new GroupBox();
            richTextBoxOptions = new RichTextBox();
            dataGridViewGet = new DataGridView();
            groupBoxGet.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGet).BeginInit();
            SuspendLayout();
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(296, 62);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(75, 23);
            buttonGet.TabIndex = 0;
            buttonGet.Text = "GET";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // buttonPost
            // 
            buttonPost.Location = new Point(1099, 66);
            buttonPost.Name = "buttonPost";
            buttonPost.Size = new Size(75, 23);
            buttonPost.TabIndex = 1;
            buttonPost.Text = "POST";
            buttonPost.UseVisualStyleBackColor = true;
            buttonPost.Click += buttonPost_Click;
            // 
            // buttonPut
            // 
            buttonPut.Location = new Point(1099, 110);
            buttonPut.Name = "buttonPut";
            buttonPut.Size = new Size(75, 23);
            buttonPut.TabIndex = 2;
            buttonPut.Text = "PUT";
            buttonPut.UseVisualStyleBackColor = true;
            buttonPut.Click += buttonPut_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(670, 317);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxDataGet
            // 
            textBoxDataGet.Location = new Point(30, 41);
            textBoxDataGet.Name = "textBoxDataGet";
            textBoxDataGet.Size = new Size(235, 23);
            textBoxDataGet.TabIndex = 4;
            // 
            // textBoxTabDel
            // 
            textBoxTabDel.Location = new Point(537, 290);
            textBoxTabDel.Name = "textBoxTabDel";
            textBoxTabDel.Size = new Size(100, 23);
            textBoxTabDel.TabIndex = 6;
            textBoxTabDel.TextChanged += textBox2_TextChanged;
            // 
            // textBoxIdDel
            // 
            textBoxIdDel.Location = new Point(537, 343);
            textBoxIdDel.Name = "textBoxIdDel";
            textBoxIdDel.Size = new Size(100, 23);
            textBoxIdDel.TabIndex = 7;
            textBoxIdDel.TextChanged += textBox3_TextChanged;
            // 
            // labelTabellaDel
            // 
            labelTabellaDel.AutoSize = true;
            labelTabellaDel.Location = new Point(537, 272);
            labelTabellaDel.Name = "labelTabellaDel";
            labelTabellaDel.Size = new Size(43, 15);
            labelTabellaDel.TabIndex = 8;
            labelTabellaDel.Text = "Tabella";
            labelTabellaDel.TextAlign = ContentAlignment.TopCenter;
            labelTabellaDel.Click += label1_Click;
            // 
            // labelIdDel
            // 
            labelIdDel.AutoSize = true;
            labelIdDel.Location = new Point(537, 325);
            labelIdDel.Name = "labelIdDel";
            labelIdDel.Size = new Size(18, 15);
            labelIdDel.TabIndex = 9;
            labelIdDel.Text = "ID";
            labelIdDel.Click += labelIdDel_Click;
            // 
            // textBoxIdGet
            // 
            textBoxIdGet.Location = new Point(30, 86);
            textBoxIdGet.Name = "textBoxIdGet";
            textBoxIdGet.Size = new Size(235, 23);
            textBoxIdGet.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "Tabella";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 109);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 16;
            label3.Text = "Dati";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 43);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 15;
            label4.Text = "Tabella";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDatiPP
            // 
            textBoxDatiPP.Location = new Point(514, 127);
            textBoxDatiPP.Name = "textBoxDatiPP";
            textBoxDatiPP.Size = new Size(527, 23);
            textBoxDatiPP.TabIndex = 14;
            // 
            // textBoxTabellaPP
            // 
            textBoxTabellaPP.Location = new Point(514, 61);
            textBoxTabellaPP.Name = "textBoxTabellaPP";
            textBoxTabellaPP.Size = new Size(182, 23);
            textBoxTabellaPP.TabIndex = 13;
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.BackColor = SystemColors.GradientActiveCaption;
            groupBoxDelete.Location = new Point(483, 237);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(344, 181);
            groupBoxDelete.TabIndex = 17;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "DELETE";
            // 
            // groupBoxPP
            // 
            groupBoxPP.BackColor = SystemColors.GradientActiveCaption;
            groupBoxPP.Location = new Point(470, 23);
            groupBoxPP.Name = "groupBoxPP";
            groupBoxPP.Size = new Size(747, 143);
            groupBoxPP.TabIndex = 18;
            groupBoxPP.TabStop = false;
            groupBoxPP.Text = "POST/PUT";
            // 
            // groupBoxGet
            // 
            groupBoxGet.BackColor = SystemColors.GradientActiveCaption;
            groupBoxGet.Controls.Add(dataGridViewGet);
            groupBoxGet.Location = new Point(12, 3);
            groupBoxGet.Name = "groupBoxGet";
            groupBoxGet.Size = new Size(429, 717);
            groupBoxGet.TabIndex = 19;
            groupBoxGet.TabStop = false;
            groupBoxGet.Text = "GET";
            // 
            // buttonOptions
            // 
            buttonOptions.Location = new Point(337, 60);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(75, 23);
            buttonOptions.TabIndex = 20;
            buttonOptions.Text = "OPTIONS";
            buttonOptions.UseVisualStyleBackColor = true;
            buttonOptions.Click += buttonOptions_Click;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.BackColor = SystemColors.GradientActiveCaption;
            groupBoxOptions.Controls.Add(buttonOptions);
            groupBoxOptions.Controls.Add(richTextBoxOptions);
            groupBoxOptions.Location = new Point(483, 462);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(449, 190);
            groupBoxOptions.TabIndex = 25;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "OPTIONS";
            // 
            // richTextBoxOptions
            // 
            richTextBoxOptions.Location = new Point(19, 22);
            richTextBoxOptions.Name = "richTextBoxOptions";
            richTextBoxOptions.Size = new Size(312, 153);
            richTextBoxOptions.TabIndex = 0;
            richTextBoxOptions.Text = "";
            // 
            // dataGridViewGet
            // 
            dataGridViewGet.BackgroundColor = SystemColors.Control;
            dataGridViewGet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGet.Location = new Point(18, 144);
            dataGridViewGet.Name = "dataGridViewGet";
            dataGridViewGet.RowTemplate.Height = 25;
            dataGridViewGet.Size = new Size(377, 455);
            dataGridViewGet.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 701);
            Controls.Add(groupBoxOptions);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBoxDatiPP);
            Controls.Add(textBoxTabellaPP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxIdGet);
            Controls.Add(labelIdDel);
            Controls.Add(labelTabellaDel);
            Controls.Add(textBoxIdDel);
            Controls.Add(textBoxTabDel);
            Controls.Add(textBoxDataGet);
            Controls.Add(buttonDelete);
            Controls.Add(buttonPut);
            Controls.Add(buttonPost);
            Controls.Add(buttonGet);
            Controls.Add(groupBoxDelete);
            Controls.Add(groupBoxPP);
            Controls.Add(groupBoxGet);
            Name = "Form1";
            Load += Form1_Load;
            groupBoxGet.ResumeLayout(false);
            groupBoxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGet;
        private Button buttonPost;
        private Button buttonPut;
        private Button buttonDelete;
        private TextBox textBoxDataGet;
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
        private GroupBox groupBoxDelete;
        private GroupBox groupBoxPP;
        private GroupBox groupBoxGet;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonOptions;
        private GroupBox groupBoxOptions;
        private RichTextBox richTextBoxOptions;
        private DataGridView dataGridViewGet;
    }
}