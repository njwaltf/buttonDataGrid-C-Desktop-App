namespace buttonDataGrid
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadeFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rAnime = new System.Windows.Forms.RadioButton();
            this.rGame = new System.Windows.Forms.RadioButton();
            this.rComic = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(157, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asal";
            // 
            // txtMadeFrom
            // 
            this.txtMadeFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMadeFrom.Location = new System.Drawing.Point(157, 131);
            this.txtMadeFrom.Name = "txtMadeFrom";
            this.txtMadeFrom.Size = new System.Drawing.Size(186, 26);
            this.txtMadeFrom.TabIndex = 2;
            this.txtMadeFrom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deskripsi";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(157, 248);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(309, 99);
            this.txtDesc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // rAnime
            // 
            this.rAnime.AutoSize = true;
            this.rAnime.Location = new System.Drawing.Point(253, 189);
            this.rAnime.Name = "rAnime";
            this.rAnime.Size = new System.Drawing.Size(79, 24);
            this.rAnime.TabIndex = 10;
            this.rAnime.TabStop = true;
            this.rAnime.Text = "Anime";
            this.rAnime.UseVisualStyleBackColor = true;
            this.rAnime.CheckedChanged += new System.EventHandler(this.rAnime_CheckedChanged);
            // 
            // rGame
            // 
            this.rGame.AutoSize = true;
            this.rGame.Location = new System.Drawing.Point(156, 189);
            this.rGame.Name = "rGame";
            this.rGame.Size = new System.Drawing.Size(78, 24);
            this.rGame.TabIndex = 11;
            this.rGame.TabStop = true;
            this.rGame.Text = "Game";
            this.rGame.UseVisualStyleBackColor = true;
            this.rGame.CheckedChanged += new System.EventHandler(this.rGame_CheckedChanged);
            // 
            // rComic
            // 
            this.rComic.AutoSize = true;
            this.rComic.Location = new System.Drawing.Point(348, 191);
            this.rComic.Name = "rComic";
            this.rComic.Size = new System.Drawing.Size(78, 24);
            this.rComic.TabIndex = 12;
            this.rComic.TabStop = true;
            this.rComic.Text = "Comic";
            this.rComic.UseVisualStyleBackColor = true;
            this.rComic.CheckedChanged += new System.EventHandler(this.rComic_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rComic);
            this.Controls.Add(this.rGame);
            this.Controls.Add(this.rAnime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMadeFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rAnime;
        private System.Windows.Forms.RadioButton rGame;
        private System.Windows.Forms.RadioButton rComic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}