namespace oefeniningen17_08_2020
{
    partial class oef2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProgram = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btUpProgram = new System.Windows.Forms.Button();
            this.btDownProgram = new System.Windows.Forms.Button();
            this.btUpLevel = new System.Windows.Forms.Button();
            this.btDownLevel = new System.Windows.Forms.Button();
            this.numericUpDownProgram = new System.Windows.Forms.NumericUpDown();
            this.btGotoProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level :";
            // 
            // lbProgram
            // 
            this.lbProgram.AutoSize = true;
            this.lbProgram.Location = new System.Drawing.Point(82, 59);
            this.lbProgram.Name = "lbProgram";
            this.lbProgram.Size = new System.Drawing.Size(0, 13);
            this.lbProgram.TabIndex = 2;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(197, 59);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(31, 13);
            this.lbLevel.TabIndex = 3;
            this.lbLevel.Text = "        ";
            // 
            // btUpProgram
            // 
            this.btUpProgram.Location = new System.Drawing.Point(27, 23);
            this.btUpProgram.Name = "btUpProgram";
            this.btUpProgram.Size = new System.Drawing.Size(75, 23);
            this.btUpProgram.TabIndex = 4;
            this.btUpProgram.Text = "up";
            this.btUpProgram.UseVisualStyleBackColor = true;
            this.btUpProgram.Click += new System.EventHandler(this.btUpProgram_Click);
            // 
            // btDownProgram
            // 
            this.btDownProgram.Location = new System.Drawing.Point(27, 86);
            this.btDownProgram.Name = "btDownProgram";
            this.btDownProgram.Size = new System.Drawing.Size(75, 23);
            this.btDownProgram.TabIndex = 5;
            this.btDownProgram.Text = "down";
            this.btDownProgram.UseVisualStyleBackColor = true;
            this.btDownProgram.Click += new System.EventHandler(this.btDownProgram_Click);
            // 
            // btUpLevel
            // 
            this.btUpLevel.Location = new System.Drawing.Point(155, 23);
            this.btUpLevel.Name = "btUpLevel";
            this.btUpLevel.Size = new System.Drawing.Size(75, 23);
            this.btUpLevel.TabIndex = 6;
            this.btUpLevel.Text = "up";
            this.btUpLevel.UseVisualStyleBackColor = true;
            // 
            // btDownLevel
            // 
            this.btDownLevel.Location = new System.Drawing.Point(155, 86);
            this.btDownLevel.Name = "btDownLevel";
            this.btDownLevel.Size = new System.Drawing.Size(75, 23);
            this.btDownLevel.TabIndex = 7;
            this.btDownLevel.Text = "down";
            this.btDownLevel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownProgram
            // 
            this.numericUpDownProgram.Location = new System.Drawing.Point(33, 138);
            this.numericUpDownProgram.Name = "numericUpDownProgram";
            this.numericUpDownProgram.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownProgram.TabIndex = 8;
            // 
            // btGotoProgram
            // 
            this.btGotoProgram.Location = new System.Drawing.Point(155, 138);
            this.btGotoProgram.Name = "btGotoProgram";
            this.btGotoProgram.Size = new System.Drawing.Size(87, 23);
            this.btGotoProgram.TabIndex = 9;
            this.btGotoProgram.Text = "goto program";
            this.btGotoProgram.UseVisualStyleBackColor = true;
            this.btGotoProgram.Click += new System.EventHandler(this.btGotoProgram_Click);
            // 
            // oef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGotoProgram);
            this.Controls.Add(this.numericUpDownProgram);
            this.Controls.Add(this.btDownLevel);
            this.Controls.Add(this.btUpLevel);
            this.Controls.Add(this.btDownProgram);
            this.Controls.Add(this.btUpProgram);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "oef2";
            this.Text = "oef2";
            this.Load += new System.EventHandler(this.oef2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProgram;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Button btUpProgram;
        private System.Windows.Forms.Button btDownProgram;
        private System.Windows.Forms.Button btUpLevel;
        private System.Windows.Forms.Button btDownLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownProgram;
        private System.Windows.Forms.Button btGotoProgram;
    }
}