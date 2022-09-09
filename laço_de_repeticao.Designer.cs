namespace WindowsFormsApp1
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
            this.pnlFor = new System.Windows.Forms.Panel();
            this.pnlDoWhile = new System.Windows.Forms.Panel();
            this.pnlWhile = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblForResultado = new System.Windows.Forms.Label();
            this.lblDoWhile = new System.Windows.Forms.Label();
            this.lblDWhileResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWhileResultado = new System.Windows.Forms.Label();
            this.pnlFor.SuspendLayout();
            this.pnlDoWhile.SuspendLayout();
            this.pnlWhile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFor
            // 
            this.pnlFor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlFor.Controls.Add(this.lblForResultado);
            this.pnlFor.Controls.Add(this.lblFor);
            this.pnlFor.Location = new System.Drawing.Point(21, 143);
            this.pnlFor.Name = "pnlFor";
            this.pnlFor.Size = new System.Drawing.Size(692, 92);
            this.pnlFor.TabIndex = 0;
            // 
            // pnlDoWhile
            // 
            this.pnlDoWhile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDoWhile.Controls.Add(this.lblDWhileResultado);
            this.pnlDoWhile.Controls.Add(this.lblDoWhile);
            this.pnlDoWhile.Location = new System.Drawing.Point(21, 261);
            this.pnlDoWhile.Name = "pnlDoWhile";
            this.pnlDoWhile.Size = new System.Drawing.Size(692, 92);
            this.pnlDoWhile.TabIndex = 1;
            // 
            // pnlWhile
            // 
            this.pnlWhile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlWhile.Controls.Add(this.lblWhileResultado);
            this.pnlWhile.Controls.Add(this.label5);
            this.pnlWhile.Location = new System.Drawing.Point(21, 370);
            this.pnlWhile.Name = "pnlWhile";
            this.pnlWhile.Size = new System.Drawing.Size(692, 92);
            this.pnlWhile.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(301, 62);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(150, 55);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(3, 14);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(62, 34);
            this.lblFor.TabIndex = 0;
            this.lblFor.Text = "For";
            // 
            // lblForResultado
            // 
            this.lblForResultado.AutoSize = true;
            this.lblForResultado.Location = new System.Drawing.Point(3, 48);
            this.lblForResultado.Name = "lblForResultado";
            this.lblForResultado.Size = new System.Drawing.Size(0, 34);
            this.lblForResultado.TabIndex = 1;
            // 
            // lblDoWhile
            // 
            this.lblDoWhile.AutoSize = true;
            this.lblDoWhile.Location = new System.Drawing.Point(3, 9);
            this.lblDoWhile.Name = "lblDoWhile";
            this.lblDoWhile.Size = new System.Drawing.Size(145, 34);
            this.lblDoWhile.TabIndex = 2;
            this.lblDoWhile.Text = "Do-While";
            // 
            // lblDWhileResultado
            // 
            this.lblDWhileResultado.AutoSize = true;
            this.lblDWhileResultado.Location = new System.Drawing.Point(3, 43);
            this.lblDWhileResultado.Name = "lblDWhileResultado";
            this.lblDWhileResultado.Size = new System.Drawing.Size(0, 34);
            this.lblDWhileResultado.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "While";
            // 
            // lblWhileResultado
            // 
            this.lblWhileResultado.AutoSize = true;
            this.lblWhileResultado.Location = new System.Drawing.Point(3, 45);
            this.lblWhileResultado.Name = "lblWhileResultado";
            this.lblWhileResultado.Size = new System.Drawing.Size(0, 34);
            this.lblWhileResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 474);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.pnlWhile);
            this.Controls.Add(this.pnlDoWhile);
            this.Controls.Add(this.pnlFor);
            this.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlFor.ResumeLayout(false);
            this.pnlFor.PerformLayout();
            this.pnlDoWhile.ResumeLayout(false);
            this.pnlDoWhile.PerformLayout();
            this.pnlWhile.ResumeLayout(false);
            this.pnlWhile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFor;
        private System.Windows.Forms.Label lblForResultado;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Panel pnlDoWhile;
        private System.Windows.Forms.Label lblDWhileResultado;
        private System.Windows.Forms.Label lblDoWhile;
        private System.Windows.Forms.Panel pnlWhile;
        private System.Windows.Forms.Label lblWhileResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExecutar;
    }
}

