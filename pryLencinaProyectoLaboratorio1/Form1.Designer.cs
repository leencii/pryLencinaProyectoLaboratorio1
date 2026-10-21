namespace pryLencinaProyectoLaboratorio1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblIndicacion;
        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private GroupBox grpMozoDelDia;
        private Label lblNombreMozo;
        private Label lblImporteMozo;
        private TextBox txtNombreMozo;
        private TextBox txtImporteMozo;
        private GroupBox grpTotales;
        private Label lblTotalGeneral;
        private Label lblComidas;
        private Label lblBebidasSinAlcohol;
        private Label lblBebidasConAlcohol;
        private Label lblPostres;
        private TextBox txtTotalGeneral;
        private TextBox txtTotalComidas;
        private TextBox txtTotalBebidasSinAlcohol;
        private TextBox txtTotalBebidasConAlcohol;
        private TextBox txtTotalPostres;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblIndicacion = new Label();
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            grpMozoDelDia = new GroupBox();
            lblNombreMozo = new Label();
            lblImporteMozo = new Label();
            txtNombreMozo = new TextBox();
            txtImporteMozo = new TextBox();
            grpTotales = new GroupBox();
            lblTotalGeneral = new Label();
            lblComidas = new Label();
            lblBebidasSinAlcohol = new Label();
            lblBebidasConAlcohol = new Label();
            lblPostres = new Label();
            txtTotalGeneral = new TextBox();
            txtTotalComidas = new TextBox();
            txtTotalBebidasSinAlcohol = new TextBox();
            txtTotalBebidasConAlcohol = new TextBox();
            txtTotalPostres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpMozoDelDia.SuspendLayout();
            grpTotales.SuspendLayout();
            SuspendLayout();

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.Location = new Point(28, 22);
            lblTitulo.Text = "Bar La Milanga";

            lblIndicacion.AutoSize = true;
            lblIndicacion.Font = new Font("Segoe UI", 10F);
            lblIndicacion.Location = new Point(31, 70);
            lblIndicacion.Text = "Ingrese los importes de venta de cada mozo y presione 'Validar Datos'.";

            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.Fixed3D;
            dgvVentas.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(72, 87, 104), ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(30, 105);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 25;
            dgvVentas.RowTemplate.Height = 32;
            dgvVentas.Size = new Size(840, 230);
            dgvVentas.TabIndex = 0;

            btnValidar.BackColor = Color.FromArgb(37, 99, 155);
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.Location = new Point(30, 355);
            btnValidar.Size = new Size(175, 40);
            btnValidar.Text = "Validar Datos";
            btnValidar.Click += btnValidar_Click;

            grpMozoDelDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMozoDelDia.Location = new Point(30, 420);
            grpMozoDelDia.Size = new Size(400, 120);
            grpMozoDelDia.Text = "Consulta";
            grpMozoDelDia.Controls.Add(btnMozoDelDia);
            grpMozoDelDia.Controls.Add(lblNombreMozo);
            grpMozoDelDia.Controls.Add(txtNombreMozo);
            grpMozoDelDia.Controls.Add(lblImporteMozo);
            grpMozoDelDia.Controls.Add(txtImporteMozo);

            btnMozoDelDia.Location = new Point(15, 33);
            btnMozoDelDia.Size = new Size(145, 35);
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.Click += btnMozoDelDia_Click;

            lblNombreMozo.AutoSize = true;
            lblNombreMozo.Font = new Font("Segoe UI", 9F);
            lblNombreMozo.Location = new Point(175, 28);
            lblNombreMozo.Text = "Nombre:";
            txtNombreMozo.Location = new Point(175, 48);
            txtNombreMozo.ReadOnly = true;
            txtNombreMozo.Size = new Size(100, 23);
            lblImporteMozo.AutoSize = true;
            lblImporteMozo.Font = new Font("Segoe UI", 9F);
            lblImporteMozo.Location = new Point(285, 28);
            lblImporteMozo.Text = "Importe:";
            txtImporteMozo.Location = new Point(285, 48);
            txtImporteMozo.ReadOnly = true;
            txtImporteMozo.Size = new Size(100, 23);

            grpTotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTotales.Location = new Point(450, 355);
            grpTotales.Size = new Size(420, 185);
            grpTotales.Text = "Totales";
            grpTotales.Controls.Add(btnTotales);
            grpTotales.Controls.Add(lblTotalGeneral);
            grpTotales.Controls.Add(txtTotalGeneral);
            grpTotales.Controls.Add(lblComidas);
            grpTotales.Controls.Add(txtTotalComidas);
            grpTotales.Controls.Add(lblBebidasSinAlcohol);
            grpTotales.Controls.Add(txtTotalBebidasSinAlcohol);
            grpTotales.Controls.Add(lblBebidasConAlcohol);
            grpTotales.Controls.Add(txtTotalBebidasConAlcohol);
            grpTotales.Controls.Add(lblPostres);
            grpTotales.Controls.Add(txtTotalPostres);

            btnTotales.Location = new Point(15, 33);
            btnTotales.Size = new Size(105, 35);
            btnTotales.Text = "Totales";
            btnTotales.Click += btnTotales_Click;

            ConfigurarEtiqueta(lblTotalGeneral, "Total general:", 140, 31);
            ConfigurarEtiqueta(lblComidas, "Comidas:", 140, 59);
            ConfigurarEtiqueta(lblBebidasSinAlcohol, "Bebidas sin alcohol:", 140, 87);
            ConfigurarEtiqueta(lblBebidasConAlcohol, "Bebidas con alcohol:", 140, 115);
            ConfigurarEtiqueta(lblPostres, "Postres:", 140, 143);
            ConfigurarResultado(txtTotalGeneral, 270, 28);
            ConfigurarResultado(txtTotalComidas, 270, 56);
            ConfigurarResultado(txtTotalBebidasSinAlcohol, 270, 84);
            ConfigurarResultado(txtTotalBebidasConAlcohol, 270, 112);
            ConfigurarResultado(txtTotalPostres, 270, 140);

            btnCerrar.BackColor = Color.FromArgb(150, 50, 50);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.Location = new Point(30, 575);
            btnCerrar.Size = new Size(175, 38);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            ClientSize = new Size(920, 640);
            Controls.Add(lblTitulo);
            Controls.Add(lblIndicacion);
            Controls.Add(dgvVentas);
            Controls.Add(btnValidar);
            Controls.Add(grpMozoDelDia);
            Controls.Add(grpTotales);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga - Ventas diarias";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpMozoDelDia.ResumeLayout(false);
            grpMozoDelDia.PerformLayout();
            grpTotales.ResumeLayout(false);
            grpTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private static void ConfigurarEtiqueta(Label etiqueta, string texto, int x, int y)
        {
            etiqueta.AutoSize = true;
            etiqueta.Font = new Font("Segoe UI", 9F);
            etiqueta.Location = new Point(x, y);
            etiqueta.Text = texto;
        }

        private static void ConfigurarResultado(TextBox caja, int x, int y)
        {
            caja.Location = new Point(x, y);
            caja.ReadOnly = true;
            caja.Size = new Size(130, 23);
        }
    }
}
