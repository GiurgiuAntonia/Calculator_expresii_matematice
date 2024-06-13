namespace Calculator_Expresii_Matematice
{
    partial class Evaluator
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
            this.reztxt = new System.Windows.Forms.Label();
            this.reztxtf = new System.Windows.Forms.Label();
            this.calctxt = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.rezutxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exp_ant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceți expresia matematica ";
            // 
            // reztxt
            // 
            this.reztxt.AutoSize = true;
            this.reztxt.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reztxt.Location = new System.Drawing.Point(130, 216);
            this.reztxt.Name = "reztxt";
            this.reztxt.Size = new System.Drawing.Size(110, 31);
            this.reztxt.TabIndex = 1;
            this.reztxt.Text = "rezultat:";
            // 
            // reztxtf
            // 
            this.reztxtf.AutoSize = true;
            this.reztxtf.Location = new System.Drawing.Point(215, 223);
            this.reztxtf.Name = "reztxtf";
            this.reztxtf.Size = new System.Drawing.Size(0, 16);
            this.reztxtf.TabIndex = 2;
            // 
            // calctxt
            // 
            this.calctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calctxt.Location = new System.Drawing.Point(69, 165);
            this.calctxt.Name = "calctxt";
            this.calctxt.Size = new System.Drawing.Size(307, 34);
            this.calctxt.TabIndex = 3;
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_calc.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(136, 274);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(167, 56);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "calculează";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // rezutxt
            // 
            this.rezutxt.AutoSize = true;
            this.rezutxt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezutxt.Location = new System.Drawing.Point(263, 221);
            this.rezutxt.Name = "rezutxt";
            this.rezutxt.Size = new System.Drawing.Size(25, 22);
            this.rezutxt.TabIndex = 5;
            this.rezutxt.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "expresia anterioara:";
            // 
            // exp_ant
            // 
            this.exp_ant.AutoSize = true;
            this.exp_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_ant.Location = new System.Drawing.Point(263, 123);
            this.exp_ant.Name = "exp_ant";
            this.exp_ant.Size = new System.Drawing.Size(25, 22);
            this.exp_ant.TabIndex = 7;
            this.exp_ant.Text = "...";
            // 
            // Evaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.exp_ant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rezutxt);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.calctxt);
            this.Controls.Add(this.reztxtf);
            this.Controls.Add(this.reztxt);
            this.Controls.Add(this.label1);
            this.Name = "Evaluator";
            this.Text = "Evaluator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reztxt;
        private System.Windows.Forms.Label reztxtf;
        private System.Windows.Forms.TextBox calctxt;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label rezutxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exp_ant;
    }
}

