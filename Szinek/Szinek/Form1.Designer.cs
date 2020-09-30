namespace Szinek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Hatter = new System.Windows.Forms.TextBox();
            this.textBox_Szoveg = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_Hatterszin = new System.Windows.Forms.Button();
            this.button_Szoveg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Háttérszín:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szövegszín:";
            // 
            // textBox_Hatter
            // 
            this.textBox_Hatter.Location = new System.Drawing.Point(181, 45);
            this.textBox_Hatter.Name = "textBox_Hatter";
            this.textBox_Hatter.Size = new System.Drawing.Size(100, 22);
            this.textBox_Hatter.TabIndex = 2;
            // 
            // textBox_Szoveg
            // 
            this.textBox_Szoveg.Location = new System.Drawing.Point(181, 89);
            this.textBox_Szoveg.Name = "textBox_Szoveg";
            this.textBox_Szoveg.Size = new System.Drawing.Size(100, 22);
            this.textBox_Szoveg.TabIndex = 3;
            // 
            // button_Hatterszin
            // 
            this.button_Hatterszin.Location = new System.Drawing.Point(367, 38);
            this.button_Hatterszin.Name = "button_Hatterszin";
            this.button_Hatterszin.Size = new System.Drawing.Size(95, 23);
            this.button_Hatterszin.TabIndex = 4;
            this.button_Hatterszin.Text = "Háttérszín";
            this.button_Hatterszin.UseVisualStyleBackColor = true;
            this.button_Hatterszin.Click += new System.EventHandler(this.Hatterszin_Click);
            // 
            // button_Szoveg
            // 
            this.button_Szoveg.Location = new System.Drawing.Point(367, 87);
            this.button_Szoveg.Name = "button_Szoveg";
            this.button_Szoveg.Size = new System.Drawing.Size(95, 23);
            this.button_Szoveg.TabIndex = 5;
            this.button_Szoveg.Text = "SZövegSzín";
            this.button_Szoveg.UseVisualStyleBackColor = true;
            this.button_Szoveg.Click += new System.EventHandler(this.Szovegszin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Szoveg);
            this.Controls.Add(this.button_Hatterszin);
            this.Controls.Add(this.textBox_Szoveg);
            this.Controls.Add(this.textBox_Hatter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Szinek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Hatter;
        private System.Windows.Forms.TextBox textBox_Szoveg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_Hatterszin;
        private System.Windows.Forms.Button button_Szoveg;
    }
}

