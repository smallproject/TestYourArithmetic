namespace Test_Your_Arithmetic
{
    partial class formmain
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
            this.components = new System.ComponentModel.Container();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblfun = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.txtbanswer = new System.Windows.Forms.TextBox();
            this.lblanswer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(244, 266);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "btnsend";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblfun
            // 
            this.lblfun.AutoSize = true;
            this.lblfun.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfun.Location = new System.Drawing.Point(12, 9);
            this.lblfun.Name = "lblfun";
            this.lblfun.Size = new System.Drawing.Size(56, 17);
            this.lblfun.TabIndex = 1;
            this.lblfun.Text = "lblfun";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Location = new System.Drawing.Point(12, 57);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(96, 17);
            this.lblquestion.TabIndex = 2;
            this.lblquestion.Text = "lblquestion";
            // 
            // txtbanswer
            // 
            this.txtbanswer.Location = new System.Drawing.Point(126, 80);
            this.txtbanswer.Name = "txtbanswer";
            this.txtbanswer.Size = new System.Drawing.Size(100, 23);
            this.txtbanswer.TabIndex = 3;
            this.txtbanswer.Text = "txtbanswer";
            this.txtbanswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbanswer_KeyPress);
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(12, 83);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(80, 17);
            this.lblanswer.TabIndex = 4;
            this.lblanswer.Text = "lblanswer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(12, 270);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(64, 17);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "lbltime";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(12, 253);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(64, 17);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "lbldate";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(12, 188);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(72, 17);
            this.lblscore.TabIndex = 7;
            this.lblscore.Text = "lblscore";
            // 
            // formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.txtbanswer);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.lblfun);
            this.Controls.Add(this.btnsend);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formmain";
            this.Text = "formmain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblfun;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.TextBox txtbanswer;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblscore;
    }
}

