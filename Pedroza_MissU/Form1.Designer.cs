namespace Pedroza_MissU
{
    partial class Form1
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
            this.top20 = new System.Windows.Forms.ListBox();
            this.top10 = new System.Windows.Forms.ListBox();
            this.top3 = new System.Windows.Forms.ListBox();
            this.MissUniverse = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // top20
            // 
            this.top20.FormattingEnabled = true;
            this.top20.Location = new System.Drawing.Point(41, 32);
            this.top20.Name = "top20";
            this.top20.Size = new System.Drawing.Size(159, 303);
            this.top20.TabIndex = 0;
            this.top20.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // top10
            // 
            this.top10.FormattingEnabled = true;
            this.top10.Location = new System.Drawing.Point(248, 32);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(159, 303);
            this.top10.TabIndex = 1;
            this.top10.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // top3
            // 
            this.top3.FormattingEnabled = true;
            this.top3.Location = new System.Drawing.Point(460, 32);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(159, 303);
            this.top3.TabIndex = 2;
            this.top3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // MissUniverse
            // 
            this.MissUniverse.FormattingEnabled = true;
            this.MissUniverse.Location = new System.Drawing.Point(688, 32);
            this.MissUniverse.Name = "MissUniverse";
            this.MissUniverse.Size = new System.Drawing.Size(159, 303);
            this.MissUniverse.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print top 10";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Print top 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Miss Universe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(78, 363);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 7;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MissUniverse);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.top10);
            this.Controls.Add(this.top20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox top20;
        private System.Windows.Forms.ListBox top10;
        private System.Windows.Forms.ListBox top3;
        private System.Windows.Forms.ListBox MissUniverse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button upload;
    }
}

