
namespace ControlC
{
    partial class FrmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPrincipal));
            this.tableViewControl = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.timerControlC = new System.Windows.Forms.Timer(this.components);
            this.btnClearAreaTransferencia = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.columnCdControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableViewControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableViewControl
            // 
            this.tableViewControl.AllowUserToAddRows = false;
            this.tableViewControl.AllowUserToDeleteRows = false;
            this.tableViewControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableViewControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCdControl,
            this.columnText});
            this.tableViewControl.Location = new System.Drawing.Point(12, 50);
            this.tableViewControl.Name = "tableViewControl";
            this.tableViewControl.ReadOnly = true;
            this.tableViewControl.Size = new System.Drawing.Size(414, 255);
            this.tableViewControl.TabIndex = 0;
            this.tableViewControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableViewControl_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(221, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(205, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timerControlC
            // 
            this.timerControlC.Enabled = true;
            this.timerControlC.Interval = 1000;
            this.timerControlC.Tick += new System.EventHandler(this.timerControlC_Tick);
            // 
            // btnClearAreaTransferencia
            // 
            this.btnClearAreaTransferencia.Location = new System.Drawing.Point(12, 12);
            this.btnClearAreaTransferencia.Name = "btnClearAreaTransferencia";
            this.btnClearAreaTransferencia.Size = new System.Drawing.Size(203, 32);
            this.btnClearAreaTransferencia.TabIndex = 2;
            this.btnClearAreaTransferencia.Text = "Clear Área Transferência";
            this.btnClearAreaTransferencia.UseVisualStyleBackColor = true;
            this.btnClearAreaTransferencia.Click += new System.EventHandler(this.btnClearAreaTransferencia_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "A aplicação está rodando em segundo plano!";
            this.notifyIcon.BalloonTipTitle = "Informativo:";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ControlC";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // columnCdControl
            // 
            this.columnCdControl.HeaderText = "Data e Hora";
            this.columnCdControl.Name = "columnCdControl";
            this.columnCdControl.ReadOnly = true;
            // 
            // columnText
            // 
            this.columnText.HeaderText = "Text";
            this.columnText.Name = "columnText";
            this.columnText.ReadOnly = true;
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(439, 319);
            this.Controls.Add(this.btnClearAreaTransferencia);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tableViewControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlC";
            this.Resize += new System.EventHandler(this.FrmTelaPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tableViewControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableViewControl;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Timer timerControlC;
        private System.Windows.Forms.Button btnClearAreaTransferencia;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCdControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnText;
    }
}

