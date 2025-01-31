namespace MonitoramentoSistema
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBLcpu = new System.Windows.Forms.Label();
            this.LBLmemoria = new System.Windows.Forms.Label();
            this.LBLdisco = new System.Windows.Forms.Label();
            this.PBcpu = new System.Windows.Forms.ProgressBar();
            this.PBmemoria = new System.Windows.Forms.ProgressBar();
            this.PBdisco = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBinterntetin = new System.Windows.Forms.Label();
            this.LBconnect = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 23);
            this.panel2.TabIndex = 0;
            // 
            // LBLcpu
            // 
            this.LBLcpu.AutoSize = true;
            this.LBLcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcpu.Location = new System.Drawing.Point(58, 93);
            this.LBLcpu.Name = "LBLcpu";
            this.LBLcpu.Size = new System.Drawing.Size(38, 16);
            this.LBLcpu.TabIndex = 1;
            this.LBLcpu.Text = "CPU";
            // 
            // LBLmemoria
            // 
            this.LBLmemoria.AutoSize = true;
            this.LBLmemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmemoria.Location = new System.Drawing.Point(58, 154);
            this.LBLmemoria.Name = "LBLmemoria";
            this.LBLmemoria.Size = new System.Drawing.Size(77, 16);
            this.LBLmemoria.TabIndex = 1;
            this.LBLmemoria.Text = "MEMORIA";
            // 
            // LBLdisco
            // 
            this.LBLdisco.AutoSize = true;
            this.LBLdisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLdisco.Location = new System.Drawing.Point(58, 223);
            this.LBLdisco.Name = "LBLdisco";
            this.LBLdisco.Size = new System.Drawing.Size(53, 16);
            this.LBLdisco.TabIndex = 1;
            this.LBLdisco.Text = "DISCO";
            // 
            // PBcpu
            // 
            this.PBcpu.Location = new System.Drawing.Point(61, 112);
            this.PBcpu.Name = "PBcpu";
            this.PBcpu.Size = new System.Drawing.Size(335, 23);
            this.PBcpu.TabIndex = 2;
            // 
            // PBmemoria
            // 
            this.PBmemoria.Location = new System.Drawing.Point(61, 173);
            this.PBmemoria.Name = "PBmemoria";
            this.PBmemoria.Size = new System.Drawing.Size(335, 23);
            this.PBmemoria.TabIndex = 2;
            // 
            // PBdisco
            // 
            this.PBdisco.Location = new System.Drawing.Point(61, 242);
            this.PBdisco.Name = "PBdisco";
            this.PBdisco.Size = new System.Drawing.Size(335, 23);
            this.PBdisco.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBinterntetin
            // 
            this.LBinterntetin.AutoSize = true;
            this.LBinterntetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBinterntetin.Location = new System.Drawing.Point(17, 27);
            this.LBinterntetin.Name = "LBinterntetin";
            this.LBinterntetin.Size = new System.Drawing.Size(103, 16);
            this.LBinterntetin.TabIndex = 1;
            this.LBinterntetin.Text = "INTERNET IN";
            // 
            // LBconnect
            // 
            this.LBconnect.AutoSize = true;
            this.LBconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBconnect.Location = new System.Drawing.Point(17, 57);
            this.LBconnect.Name = "LBconnect";
            this.LBconnect.Size = new System.Drawing.Size(84, 16);
            this.LBconnect.TabIndex = 1;
            this.LBconnect.Text = "INTERNET";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBinterntetin);
            this.groupBox1.Controls.Add(this.LBconnect);
            this.groupBox1.Location = new System.Drawing.Point(61, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "</> Code Master";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabiano Targa Prudencio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(458, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PBdisco);
            this.Controls.Add(this.PBmemoria);
            this.Controls.Add(this.PBcpu);
            this.Controls.Add(this.LBLdisco);
            this.Controls.Add(this.LBLmemoria);
            this.Controls.Add(this.LBLcpu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBLcpu;
        private System.Windows.Forms.Label LBLmemoria;
        private System.Windows.Forms.Label LBLdisco;
        private System.Windows.Forms.ProgressBar PBcpu;
        private System.Windows.Forms.ProgressBar PBmemoria;
        private System.Windows.Forms.ProgressBar PBdisco;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBinterntetin;
        private System.Windows.Forms.Label LBconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

