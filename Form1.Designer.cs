namespace CalculadoraInteligente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonVirg = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubt = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDivi = new System.Windows.Forms.Button();
            this.buttonClea = new System.Windows.Forms.Button();
            this.buttonRese = new System.Windows.Forms.Button();
            this.buttonEqua = new System.Windows.Forms.Button();
            this.txtOper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.Window;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(237, 13);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(140, 35);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVisor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.BackColor = System.Drawing.SystemColors.Window;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(184, 20);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(21, 24);
            this.lblOper.TabIndex = 1;
            this.lblOper.Text = "=";
            this.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(18, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(91, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(164, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(18, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(91, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(164, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(18, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(91, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(164, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 44);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Location = new System.Drawing.Point(18, 261);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(140, 44);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonVirg
            // 
            this.buttonVirg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVirg.Location = new System.Drawing.Point(164, 261);
            this.buttonVirg.Name = "buttonVirg";
            this.buttonVirg.Size = new System.Drawing.Size(67, 44);
            this.buttonVirg.TabIndex = 12;
            this.buttonVirg.Text = ",";
            this.buttonVirg.UseVisualStyleBackColor = true;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoma.Location = new System.Drawing.Point(237, 111);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(67, 44);
            this.buttonSoma.TabIndex = 13;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubt
            // 
            this.buttonSubt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubt.Location = new System.Drawing.Point(237, 161);
            this.buttonSubt.Name = "buttonSubt";
            this.buttonSubt.Size = new System.Drawing.Size(67, 44);
            this.buttonSubt.TabIndex = 14;
            this.buttonSubt.Text = "-";
            this.buttonSubt.UseVisualStyleBackColor = true;
            this.buttonSubt.Click += new System.EventHandler(this.buttonSubt_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMult.Location = new System.Drawing.Point(237, 211);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(67, 44);
            this.buttonMult.TabIndex = 15;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDivi
            // 
            this.buttonDivi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivi.Location = new System.Drawing.Point(237, 261);
            this.buttonDivi.Name = "buttonDivi";
            this.buttonDivi.Size = new System.Drawing.Size(67, 44);
            this.buttonDivi.TabIndex = 16;
            this.buttonDivi.Text = "/";
            this.buttonDivi.UseVisualStyleBackColor = true;
            this.buttonDivi.Click += new System.EventHandler(this.buttonDivi_Click);
            // 
            // buttonClea
            // 
            this.buttonClea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClea.Location = new System.Drawing.Point(310, 111);
            this.buttonClea.Name = "buttonClea";
            this.buttonClea.Size = new System.Drawing.Size(67, 44);
            this.buttonClea.TabIndex = 17;
            this.buttonClea.Tag = "";
            this.buttonClea.Text = "CE";
            this.buttonClea.UseVisualStyleBackColor = true;
            // 
            // buttonRese
            // 
            this.buttonRese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRese.Location = new System.Drawing.Point(310, 161);
            this.buttonRese.Name = "buttonRese";
            this.buttonRese.Size = new System.Drawing.Size(67, 44);
            this.buttonRese.TabIndex = 18;
            this.buttonRese.Text = "C";
            this.buttonRese.UseVisualStyleBackColor = true;
            // 
            // buttonEqua
            // 
            this.buttonEqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEqua.Location = new System.Drawing.Point(310, 211);
            this.buttonEqua.Name = "buttonEqua";
            this.buttonEqua.Size = new System.Drawing.Size(67, 94);
            this.buttonEqua.TabIndex = 19;
            this.buttonEqua.Text = "=";
            this.buttonEqua.UseVisualStyleBackColor = true;
            this.buttonEqua.Click += new System.EventHandler(this.buttonEqua_Click);
            // 
            // txtOper
            // 
            this.txtOper.BackColor = System.Drawing.SystemColors.Window;
            this.txtOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOper.Location = new System.Drawing.Point(18, 13);
            this.txtOper.Name = "txtOper";
            this.txtOper.ReadOnly = true;
            this.txtOper.Size = new System.Drawing.Size(140, 35);
            this.txtOper.TabIndex = 20;
            this.txtOper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 338);
            this.Controls.Add(this.txtOper);
            this.Controls.Add(this.buttonEqua);
            this.Controls.Add(this.buttonRese);
            this.Controls.Add(this.buttonClea);
            this.Controls.Add(this.buttonDivi);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSubt);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonVirg);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtVisor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonVirg;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubt;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDivi;
        private System.Windows.Forms.Button buttonClea;
        private System.Windows.Forms.Button buttonRese;
        private System.Windows.Forms.Button buttonEqua;
        private System.Windows.Forms.TextBox txtOper;
    }
}

