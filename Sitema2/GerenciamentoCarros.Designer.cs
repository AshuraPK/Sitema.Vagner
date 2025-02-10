namespace Sitema2
{
    partial class GerenciamentoCarros
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
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonRemoverCarros = new System.Windows.Forms.Button();
            this.buttonPequisar = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciamento de Carros";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(621, 366);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(108, 49);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCarros
            // 
            this.buttonRemoverCarros.Location = new System.Drawing.Point(621, 176);
            this.buttonRemoverCarros.Name = "buttonRemoverCarros";
            this.buttonRemoverCarros.Size = new System.Drawing.Size(108, 58);
            this.buttonRemoverCarros.TabIndex = 7;
            this.buttonRemoverCarros.Text = "Remover Carros";
            this.buttonRemoverCarros.UseVisualStyleBackColor = true;
            // 
            // buttonPequisar
            // 
            this.buttonPequisar.Location = new System.Drawing.Point(621, 88);
            this.buttonPequisar.Name = "buttonPequisar";
            this.buttonPequisar.Size = new System.Drawing.Size(108, 53);
            this.buttonPequisar.TabIndex = 6;
            this.buttonPequisar.Text = "Pesquisar  Carros";
            this.buttonPequisar.UseVisualStyleBackColor = true;
            this.buttonPequisar.Click += new System.EventHandler(this.buttonPequisar_Click);
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(71, 88);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(486, 327);
            this.dgvCarros.TabIndex = 5;
            // 
            // GerenciamentoCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemoverCarros);
            this.Controls.Add(this.buttonPequisar);
            this.Controls.Add(this.dgvCarros);
            this.Name = "GerenciamentoCarros";
            this.Text = "GerenciamentoCarros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonRemoverCarros;
        private System.Windows.Forms.Button buttonPequisar;
        private System.Windows.Forms.DataGridView dgvCarros;
    }
}