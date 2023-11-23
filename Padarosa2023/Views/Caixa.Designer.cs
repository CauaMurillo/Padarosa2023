namespace Padarosa2023.Views
{
    partial class Caixa
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
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblNumCom = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbxPagamento = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AllowUserToResizeColumns = false;
            this.dgvCaixa.AllowUserToResizeRows = false;
            this.dgvCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(12, 77);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.Size = new System.Drawing.Size(624, 226);
            this.dgvCaixa.TabIndex = 3;
            // 
            // lblNumCom
            // 
            this.lblNumCom.AutoSize = true;
            this.lblNumCom.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCom.Location = new System.Drawing.Point(54, 25);
            this.lblNumCom.Name = "lblNumCom";
            this.lblNumCom.Size = new System.Drawing.Size(187, 35);
            this.lblNumCom.TabIndex = 4;
            this.lblNumCom.Text = "N° Comanda:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(256, 25);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(149, 43);
            this.txbComanda.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightGray;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Location = new System.Drawing.Point(425, 25);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(108, 43);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Buscar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.AutoSize = true;
            this.cbxPagamento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPagamento.Location = new System.Drawing.Point(455, 430);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(181, 23);
            this.cbxPagamento.TabIndex = 10;
            this.cbxPagamento.Text = "PAGAMENTO RECEBIDO";
            this.cbxPagamento.UseVisualStyleBackColor = true;
            this.cbxPagamento.CheckedChanged += new System.EventHandler(this.cbxPagamento_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncerrar.Location = new System.Drawing.Point(455, 459);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(171, 38);
            this.btnEncerrar.TabIndex = 11;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(480, 345);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 25);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Click += new System.EventHandler(this.label1_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 508);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.lblNumCom);
            this.Controls.Add(this.dgvCaixa);
            this.DoubleBuffered = true;
            this.Name = "Caixa";
            this.Text = "                 ";
            this.Load += new System.EventHandler(this.Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblNumCom;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox cbxPagamento;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblPreco;
    }
}