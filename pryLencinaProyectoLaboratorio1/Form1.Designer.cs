namespace pryLencinaProyectoLaboratorio1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlan;
        private Label lblTurno;
        private Label lblMeses;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox chkEstudiante;
        private CheckBox chkCasillero;
        private GroupBox grpPago;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnHistorial;
        private Button btnGuardar;
        private Label lblAyuda;
        private DataGridView dgvSocios;
        private Panel pnlSeparador;
        private Label lblDatosCargados;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlan = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            chkEstudiante = new CheckBox();
            chkCasillero = new CheckBox();
            grpPago = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnHistorial = new Button();
            btnGuardar = new Button();
            lblAyuda = new Label();
            dgvSocios = new DataGridView();
            pnlSeparador = new Panel();
            lblDatosCargados = new Label();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            grpPago.SuspendLayout();
            SuspendLayout();

            pnlEncabezado.BackColor = Color.FromArgb(26, 59, 105);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Size = new Size(1100, 80);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblSubtitulo);

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.Location = new Point(28, 15);
            lblTitulo.Text = "💪 GIMNASIO SIGLO";
            lblTitulo.ForeColor = Color.White;

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblSubtitulo.Location = new Point(28, 45);
            lblSubtitulo.Text = "Sistema de Inscripción de Socios";
            lblSubtitulo.ForeColor = Color.FromArgb(173, 216, 230);

            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(32, 108);
            lblNombre.Text = "👤";
            lblNombre.ForeColor = Color.FromArgb(45, 45, 48);
            txtNombre.Location = new Point(70, 104);
            txtNombre.MaxLength = 30;
            txtNombre.Size = new Size(300, 24);
            txtNombre.TabIndex = 0;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.BackColor = Color.White;
            txtNombre.ForeColor = Color.Black;
            txtNombre.PlaceholderText = "Ingresá nombre y apellido completo";
            txtNombre.TextChanged += txtNombre_TextChanged;

            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEdad.Location = new Point(32, 150);
            lblEdad.Text = "🎂";
            lblEdad.ForeColor = Color.FromArgb(45, 45, 48);
            txtEdad.Location = new Point(70, 146);
            txtEdad.MaxLength = 3;
            txtEdad.Size = new Size(100, 24);
            txtEdad.Font = new Font("Segoe UI", 10F);
            txtEdad.BackColor = Color.White;
            txtEdad.ForeColor = Color.Black;
            txtEdad.PlaceholderText = "Edad";
            txtEdad.TabIndex = 1;
            txtEdad.KeyPress += SoloNumeros_KeyPress;
            txtEdad.TextChanged += Datos_TextChanged;

            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(190, 148);
            chkEstudiante.Text = "✓ Estudiante";
            chkEstudiante.Font = new Font("Segoe UI", 10F);
            chkEstudiante.ForeColor = Color.FromArgb(45, 45, 48);
            chkEstudiante.TabIndex = 2;

            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlan.Location = new Point(32, 172);
            lblPlan.Text = "🏋️";
            lblPlan.ForeColor = Color.FromArgb(45, 45, 48);
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(70, 168);
            cboPlan.Size = new Size(250, 24);
            cboPlan.Font = new Font("Segoe UI", 10F);
            cboPlan.BackColor = Color.White;
            cboPlan.ForeColor = Color.Black;
            cboPlan.TabIndex = 3;
            cboPlan.SelectedIndexChanged += Datos_TextChanged;

            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTurno.Location = new Point(32, 214);
            lblTurno.Text = "⏰";
            lblTurno.ForeColor = Color.FromArgb(45, 45, 48);
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(70, 210);
            cboTurno.Size = new Size(250, 24);
            cboTurno.Font = new Font("Segoe UI", 10F);
            cboTurno.BackColor = Color.White;
            cboTurno.ForeColor = Color.Black;
            cboTurno.TabIndex = 4;

            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMeses.Location = new Point(32, 256);
            lblMeses.Text = "📅";
            lblMeses.ForeColor = Color.FromArgb(45, 45, 48);
            txtMeses.Location = new Point(70, 252);
            txtMeses.MaxLength = 2;
            txtMeses.Size = new Size(100, 24);
            txtMeses.Font = new Font("Segoe UI", 10F);
            txtMeses.BackColor = Color.White;
            txtMeses.ForeColor = Color.Black;
            txtMeses.PlaceholderText = "1-12";
            txtMeses.TabIndex = 5;
            txtMeses.KeyPress += SoloNumeros_KeyPress;
            txtMeses.TextChanged += Datos_TextChanged;

            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(190, 256);
            chkCasillero.Text = "📦 Casillero ($ 3.000/mes)";
            chkCasillero.Font = new Font("Segoe UI", 10F);
            chkCasillero.ForeColor = Color.FromArgb(45, 45, 48);
            chkCasillero.TabIndex = 6;

            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Location = new Point(32, 370);
            grpPago.Size = new Size(380, 75);
            grpPago.TabStop = false;
            grpPago.Text = "💳 Forma de pago";
            grpPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPago.ForeColor = Color.FromArgb(31, 78, 121);
            grpPago.BackColor = Color.FromArgb(240, 248, 255);
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(18, 35);
            rbtEfectivo.Text = "💰 Efectivo (-10%)";
            rbtEfectivo.Font = new Font("Segoe UI", 10F);
            rbtEfectivo.ForeColor = Color.FromArgb(45, 45, 48);
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(200, 35);
            rbtTarjeta.Text = "🏧 Tarjeta";
            rbtTarjeta.Font = new Font("Segoe UI", 10F);
            rbtTarjeta.ForeColor = Color.FromArgb(45, 45, 48);
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;

            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCuotas.Location = new Point(32, 460);
            lblCuotas.Text = "🧮";
            lblCuotas.ForeColor = Color.FromArgb(45, 45, 48);
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(70, 456);
            cboCuotas.Size = new Size(100, 24);
            cboCuotas.Font = new Font("Segoe UI", 10F);
            cboCuotas.BackColor = Color.White;
            cboCuotas.ForeColor = Color.Black;
            cboCuotas.TabIndex = 7;

            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(32, 525);
            btnCalcular.Size = new Size(180, 45);
            btnCalcular.Text = "✓ CALCULAR";
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.BackColor = Color.FromArgb(0, 120, 215);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.TabIndex = 8;
            btnCalcular.Click += btnCalcular_Click;

            btnLimpiar.Location = new Point(230, 525);
            btnLimpiar.Size = new Size(180, 45);
            btnLimpiar.Text = "🔄 LIMPIAR";
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.BackColor = Color.FromArgb(107, 105, 123);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Click += btnLimpiar_Click;

            btnHistorial.Location = new Point(32, 580);
            btnHistorial.Size = new Size(180, 35);
            btnHistorial.Text = "📊 HISTORIAL";
            btnHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistorial.BackColor = Color.FromArgb(34, 139, 34);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.TabIndex = 10;
            btnHistorial.Click += btnHistorial_Click;

            btnGuardar.Location = new Point(230, 580);
            btnGuardar.Size = new Size(180, 35);
            btnGuardar.Text = "💾 GUARDAR CSV";
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.BackColor = Color.FromArgb(220, 20, 60);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.TabIndex = 11;
            btnGuardar.Click += btnGuardar_Click;

            lblAyuda.AutoSize = true;
            lblAyuda.ForeColor = Color.FromArgb(70, 130, 180);
            lblAyuda.Location = new Point(32, 310);
            lblAyuda.MaximumSize = new Size(500, 0);
                        lblAyuda.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
                        lblAyuda.Text = "💡 Seleccioná estudiante si aplica\n📦 Agregá casillero si lo necesitás\n💳 Elegí forma de pago y cuotas";

                        pnlSeparador.BackColor = Color.FromArgb(200, 200, 200);
                        pnlSeparador.Height = 2;
                        pnlSeparador.Location = new Point(0, 375);
                        pnlSeparador.Size = new Size(1100, 2);

                        lblDatosCargados.AutoSize = true;
                        lblDatosCargados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        lblDatosCargados.Location = new Point(550, 108);
                        lblDatosCargados.Text = "📋 SOCIOS REGISTRADOS";
                        lblDatosCargados.ForeColor = Color.FromArgb(26, 59, 105);

                        dgvSocios.AllowUserToAddRows = false;
                        dgvSocios.AllowUserToDeleteRows = false;
                        dgvSocios.BackgroundColor = Color.White;
                        dgvSocios.BorderStyle = BorderStyle.Fixed3D;
                        dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvSocios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 59, 105);
                        dgvSocios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvSocios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        dgvSocios.Location = new Point(550, 140);
                        dgvSocios.ReadOnly = true;
                        dgvSocios.RowHeadersVisible = false;
                        dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvSocios.Size = new Size(520, 480);
                        dgvSocios.TabIndex = 20;
                        dgvSocios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

                        AcceptButton = btnCalcular;
                        AutoScaleMode = AutoScaleMode.Font;
                        BackColor = Color.FromArgb(250, 250, 250);
                        ClientSize = new Size(1100, 640);
                        Controls.Add(pnlEncabezado);
                        Controls.Add(lblDatosCargados);
                        Controls.Add(dgvSocios);
                        Controls.Add(pnlSeparador);
                        Controls.Add(lblNombre);
                        Controls.Add(txtNombre);
                        Controls.Add(lblEdad);
                        Controls.Add(txtEdad);
                        Controls.Add(chkEstudiante);
                        Controls.Add(lblPlan);
                        Controls.Add(cboPlan);
                        Controls.Add(lblTurno);
                        Controls.Add(cboTurno);
                        Controls.Add(lblMeses);
                        Controls.Add(txtMeses);
                        Controls.Add(chkCasillero);
                        Controls.Add(lblAyuda);
                        Controls.Add(grpPago);
                        Controls.Add(lblCuotas);
                        Controls.Add(cboCuotas);
                        Controls.Add(btnCalcular);
                        Controls.Add(btnLimpiar);
                        Controls.Add(btnHistorial);
                        Controls.Add(btnGuardar);
                        Font = new Font("Segoe UI", 9.5F);
                        FormBorderStyle = FormBorderStyle.FixedSingle;
                        MaximizeBox = false;
                        StartPosition = FormStartPosition.CenterScreen;
                        Text = "Gimnasio Siglo - Sistema de Inscripción";
                        Load += Form1_Load;
                        pnlEncabezado.ResumeLayout(false);
                        pnlEncabezado.PerformLayout();
                        grpPago.ResumeLayout(false);
                        grpPago.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
                        ResumeLayout(false);
                        PerformLayout();
                    }

                    #endregion
                }
            }
