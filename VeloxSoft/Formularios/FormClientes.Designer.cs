namespace VeloxSoft.Formularios
{
    partial class FormClientes
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
            pnlClientes = new Panel();
            tlpFondo = new TableLayoutPanel();
            pnDetallesC = new Panel();
            pnlNombre = new Panel();
            textNombre = new TextBox();
            lblNombre = new Label();
            lblTitulo = new Label();
            pnlClientes.SuspendLayout();
            tlpFondo.SuspendLayout();
            pnDetallesC.SuspendLayout();
            pnlNombre.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.FromArgb(52, 133, 63);
            pnlClientes.Controls.Add(tlpFondo);
            pnlClientes.Dock = DockStyle.Fill;
            pnlClientes.Location = new Point(0, 0);
            pnlClientes.Margin = new Padding(3, 4, 3, 4);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(1320, 811);
            pnlClientes.TabIndex = 0;
            // 
            // tlpFondo
            // 
            tlpFondo.ColumnCount = 2;
            tlpFondo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.4545441F));
            tlpFondo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.5454559F));
            tlpFondo.Controls.Add(pnDetallesC, 0, 0);
            tlpFondo.Dock = DockStyle.Left;
            tlpFondo.Location = new Point(0, 0);
            tlpFondo.Margin = new Padding(3, 4, 3, 4);
            tlpFondo.Name = "tlpFondo";
            tlpFondo.RowCount = 1;
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFondo.Size = new Size(1320, 811);
            tlpFondo.TabIndex = 0;
            tlpFondo.Paint += tlpFondo_Paint;
            // 
            // pnDetallesC
            // 
            pnDetallesC.Anchor = AnchorStyles.None;
            pnDetallesC.BackColor = Color.FromArgb(192, 255, 192);
            pnDetallesC.Controls.Add(pnlNombre);
            pnDetallesC.Controls.Add(lblNombre);
            pnDetallesC.Controls.Add(lblTitulo);
            pnDetallesC.Location = new Point(121, 39);
            pnDetallesC.Margin = new Padding(3, 4, 3, 4);
            pnDetallesC.Name = "pnDetallesC";
            pnDetallesC.Size = new Size(489, 732);
            pnDetallesC.TabIndex = 0;
            pnDetallesC.Paint += pnDetallesC_Paint;
            pnDetallesC.Resize += pnDetallesC_Resize;
            // 
            // pnlNombre
            // 
            pnlNombre.BackColor = Color.White;
            pnlNombre.Controls.Add(textNombre);
            pnlNombre.Cursor = Cursors.IBeam;
            pnlNombre.Location = new Point(143, 84);
            pnlNombre.Margin = new Padding(3, 4, 3, 4);
            pnlNombre.Name = "pnlNombre";
            pnlNombre.Size = new Size(326, 36);
            pnlNombre.TabIndex = 2;
            pnlNombre.Paint += pnlNombre_Paint;
            // 
            // textNombre
            // 
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Location = new Point(3, 3);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(319, 20);
            textNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(19, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(19, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(278, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalles De CLientes";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 811);
            Controls.Add(pnlClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClientes";
            Text = "FormClientes";
            pnlClientes.ResumeLayout(false);
            tlpFondo.ResumeLayout(false);
            pnDetallesC.ResumeLayout(false);
            pnDetallesC.PerformLayout();
            pnlNombre.ResumeLayout(false);
            pnlNombre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClientes;
        private TableLayoutPanel tlpFondo;
        private Panel pnDetallesC;
        private Panel pnlNombre;
        private TextBox textNombre;
        private Label lblNombre;
        private Label lblTitulo;
    }
}