namespace GeneratePassword
{
    partial class frmPass
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
            this.btnGen = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.numLenght = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.gbPass = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblCopy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.gbPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGen.Location = new System.Drawing.Point(277, 108);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(103, 58);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lbPass
            // 
            this.lbPass.FormattingEnabled = true;
            this.lbPass.Location = new System.Drawing.Point(386, 10);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(281, 303);
            this.lbPass.TabIndex = 1;
            this.lbPass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPass_MouseDoubleClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(12, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Password lenght";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(13, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(182, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Amount of passwords";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLenght
            // 
            this.numLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLenght.Location = new System.Drawing.Point(16, 35);
            this.numLenght.Name = "numLenght";
            this.numLenght.Size = new System.Drawing.Size(120, 22);
            this.numLenght.TabIndex = 4;
            // 
            // numNumber
            // 
            this.numNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numNumber.Location = new System.Drawing.Point(17, 108);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 22);
            this.numNumber.TabIndex = 5;
            // 
            // gbPass
            // 
            this.gbPass.Controls.Add(this.rb3);
            this.gbPass.Controls.Add(this.rb2);
            this.gbPass.Controls.Add(this.rb1);
            this.gbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPass.Location = new System.Drawing.Point(17, 170);
            this.gbPass.Name = "gbPass";
            this.gbPass.Size = new System.Drawing.Size(272, 140);
            this.gbPass.TabIndex = 6;
            this.gbPass.TabStop = false;
            this.gbPass.Text = "Password type";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb3.Location = new System.Drawing.Point(6, 114);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(262, 20);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Numbers, letters and special characters";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb2.Location = new System.Drawing.Point(6, 67);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(146, 20);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Numbers and letters";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb1.Location = new System.Drawing.Point(6, 21);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(108, 20);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Only numbers";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lblCopy
            // 
            this.lblCopy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCopy.Location = new System.Drawing.Point(17, 317);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(650, 55);
            this.lblCopy.TabIndex = 7;
            this.lblCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 381);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.gbPass);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.numLenght);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.btnGen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.gbPass.ResumeLayout(false);
            this.gbPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ListBox lbPass;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown numLenght;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.GroupBox gbPass;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblCopy;
    }
}

