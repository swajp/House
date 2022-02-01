namespace House
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pboxBackColor = new System.Windows.Forms.PictureBox();
            this.pboxForeColor = new System.Windows.Forms.PictureBox();
            this.numericHorizontal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericVertical = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorBackDia = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericVertical);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericHorizontal);
            this.panel1.Controls.Add(this.pboxForeColor);
            this.panel1.Controls.Add(this.pboxBackColor);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(12, 24);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generuj";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pboxBackColor
            // 
            this.pboxBackColor.BackColor = System.Drawing.Color.White;
            this.pboxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBackColor.Location = new System.Drawing.Point(104, 13);
            this.pboxBackColor.Name = "pboxBackColor";
            this.pboxBackColor.Size = new System.Drawing.Size(26, 23);
            this.pboxBackColor.TabIndex = 1;
            this.pboxBackColor.TabStop = false;
            this.pboxBackColor.UseWaitCursor = true;
            this.pboxBackColor.Click += new System.EventHandler(this.pboxBackColor_Click);
            // 
            // pboxForeColor
            // 
            this.pboxForeColor.BackColor = System.Drawing.Color.White;
            this.pboxForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxForeColor.Location = new System.Drawing.Point(117, 24);
            this.pboxForeColor.Name = "pboxForeColor";
            this.pboxForeColor.Size = new System.Drawing.Size(26, 23);
            this.pboxForeColor.TabIndex = 2;
            this.pboxForeColor.TabStop = false;
            this.pboxForeColor.Click += new System.EventHandler(this.pboxForeColor_Click);
            // 
            // numericHorizontal
            // 
            this.numericHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.numericHorizontal.ForeColor = System.Drawing.Color.White;
            this.numericHorizontal.Location = new System.Drawing.Point(169, 27);
            this.numericHorizontal.Name = "numericHorizontal";
            this.numericHorizontal.Size = new System.Drawing.Size(53, 20);
            this.numericHorizontal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vedle";
            // 
            // numericVertical
            // 
            this.numericVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.numericVertical.ForeColor = System.Drawing.Color.White;
            this.numericVertical.Location = new System.Drawing.Point(237, 27);
            this.numericVertical.Name = "numericVertical";
            this.numericVertical.Size = new System.Drawing.Size(53, 20);
            this.numericVertical.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nad";
            // 
            // numericHeight
            // 
            this.numericHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.numericHeight.ForeColor = System.Drawing.Color.White;
            this.numericHeight.Location = new System.Drawing.Point(306, 27);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(53, 20);
            this.numericHeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Výška domu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "px";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Okno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericHorizontal;
        private System.Windows.Forms.PictureBox pboxForeColor;
        private System.Windows.Forms.PictureBox pboxBackColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorBackDia;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

