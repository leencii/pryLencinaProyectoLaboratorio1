using System.Globalization;
using System.Text;

namespace pryLencinaProyectoLaboratorio1
{
    public partial class Form1 : Form
    {
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const decimal DESCUENTO_MENOR = 0.25m;
        private const decimal DESCUENTO_ADULTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        private const decimal DESCUENTO_EFECTIVO = 0.10m;
        private const decimal RECARGO_TRES_CUOTAS = 0.10m;
        private const decimal RECARGO_SEIS_CUOTAS = 0.20m;
        private const int EDAD_MINIMA = 14;
        private const int EDAD_MENOR = 18;
        private const int EDAD_ADULTO_MAYOR = 65;
        private const int MESES_MINIMOS = 1;
        private const int MESES_MAXIMOS = 12;

        private struct SOCIO
        {
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;
            public decimal ValorCuota;
        }

        private List<SOCIO> registroSocios = new List<SOCIO>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            EstadoInicial();
            CargarDatosEnGrid();
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = MESES_MINIMOS.ToString();
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnHistorial_Click(object? sender, EventArgs e)
        {
            MostrarHistorial();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            GuardarRegistros();
        }

        private void SoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object? sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.ToUpperInvariant();
            txtNombre.SelectionStart = txtNombre.Text.Length;
            ActualizarEstadoBoton();
        }

        private void Datos_TextChanged(object? sender, EventArgs e)
        {
            ActualizarEstadoBoton();
        }

        private void ActualizarEstadoBoton()
        {
            bool edadValida = int.TryParse(txtEdad.Text, out _);
            bool mesesValidos = int.TryParse(txtMeses.Text, out int meses)
                && meses >= MESES_MINIMOS && meses <= MESES_MAXIMOS;

            btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text)
                && edadValida
                && mesesValidos
                && cboPlan.SelectedIndex >= 0
                && cboTurno.SelectedIndex >= 0;
        }

        private void rbtTarjeta_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
        }

        private void rbtEfectivo_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbtEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Ingresá una edad válida.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show($"La edad mínima para inscribirse es de {EDAD_MINIMA} años.", "Inscripción no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMeses.Text, out int meses)
                || meses < MESES_MINIMOS || meses > MESES_MAXIMOS)
            {
                MessageBox.Show($"La cantidad de meses debe estar entre {MESES_MINIMOS} y {MESES_MAXIMOS}.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeses.Focus();
                return;
            }

            string nombre = txtNombre.Text.Trim().ToUpperInvariant();
            string plan = cboPlan.SelectedItem?.ToString() ?? string.Empty;
            string horario = cboTurno.SelectedItem?.ToString() ?? string.Empty;
            decimal precioMensual;

            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Seleccioná un plan.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
            decimal subtotal = precioMensual * meses;
            decimal porcentajeDescuento;

            if (edad < EDAD_MENOR)
            {
                porcentajeDescuento = DESCUENTO_MENOR;
            }
            else
            {
                if (edad >= EDAD_ADULTO_MAYOR)
                {
                    porcentajeDescuento = DESCUENTO_ADULTO_MAYOR;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                    }
                    else
                    {
                        porcentajeDescuento = 0m;
                    }
                }
            }

            decimal importeConDescuento = subtotal - (subtotal * porcentajeDescuento);
            decimal porcentajeAjuste;
            int cuotas = 1;
            string formaPago;

            if (rbtEfectivo.Checked)
            {
                porcentajeAjuste = -DESCUENTO_EFECTIVO;
                formaPago = "Efectivo";
            }
            else
            {
                if (!int.TryParse(cboCuotas.SelectedItem?.ToString(), out cuotas))
                {
                    MessageBox.Show("Seleccioná la cantidad de cuotas.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cuotas == 1)
                {
                    porcentajeAjuste = 0m;
                }
                else if (cuotas == 3)
                {
                    porcentajeAjuste = RECARGO_TRES_CUOTAS;
                }
                else
                {
                    porcentajeAjuste = RECARGO_SEIS_CUOTAS;
                }

                formaPago = $"Tarjeta en {cuotas} cuota{(cuotas == 1 ? string.Empty : "s")}";
            }

            decimal total = importeConDescuento + (importeConDescuento * porcentajeAjuste);
            string categoria = edad < EDAD_MENOR ? "Menor" : "Mayor";
            decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;
            SOCIO socio = new()
            {
                Nombre = nombre,
                Edad = edad,
                Categoria = categoria,
                Plan = plan,
                Horario = horario,
                Meses = meses,
                FormaPago = formaPago,
                Total = total,
                ValorCuota = valorCuota
            };

            registroSocios.Add(socio);
            CargarDatosEnGrid();

            string mensaje = $"Nombre: {socio.Nombre}\n"
                + $"Edad: {socio.Edad} años ({socio.Categoria})\n"
                + $"Plan: {socio.Plan}\n"
                + $"Horario: {socio.Horario}\n"
                + $"Meses: {socio.Meses}\n"
                + $"Forma de pago: {socio.FormaPago}\n"
                + $"Total: {FormatearMoneda(socio.Total)}\n"
                + $"Valor de cuota: {FormatearMoneda(socio.ValorCuota)}\n\n"
                + $"✓ Inscripción guardada (Total registros: {registroSocios.Count})";

            MessageBox.Show(mensaje, "Resumen de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }

        private static string FormatearMoneda(decimal importe)
        {
            return importe.ToString("C2", CultureInfo.GetCultureInfo("es-AR"));
        }

        private void GuardarRegistros()
        {
            if (registroSocios.Count == 0)
            {
                MessageBox.Show("No hay registros para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
                    $"Inscripciones_Gimnasio_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.csv");

                using (StreamWriter writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    writer.WriteLine("Nombre,Edad,Categoría,Plan,Horario,Meses,Forma de Pago,Total,Valor Cuota");

                    foreach (var socio in registroSocios)
                    {
                        string linea = $"\"{socio.Nombre}\",{socio.Edad},\"{socio.Categoria}\",\"{socio.Plan}\",\"{socio.Horario}\"," +
                            $"{socio.Meses},\"{socio.FormaPago}\"," +
                            $"{socio.Total.ToString("F2")},{socio.ValorCuota.ToString("F2")}";
                        writer.WriteLine(linea);
                    }
                }

                MessageBox.Show($"✓ {registroSocios.Count} registro(s) guardado(s) en:\n\n{rutaArchivo}", 
                    "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosEnGrid()
        {
            dgvSocios.DataSource = null;

            var bondingList = new BindingSource(registroSocios.Select(s => new
            {
                s.Nombre,
                s.Edad,
                s.Categoria,
                s.Plan,
                s.Horario,
                s.Meses,
                s.FormaPago,
                Total = s.Total.ToString("C2"),
                Cuota = s.ValorCuota.ToString("C2")
            }).ToList(), null);

            dgvSocios.DataSource = bondingList;

            dgvSocios.Columns["Nombre"].Width = 100;
            dgvSocios.Columns["Edad"].Width = 50;
            dgvSocios.Columns["Categoria"].Width = 70;
            dgvSocios.Columns["Plan"].Width = 80;
            dgvSocios.Columns["Horario"].Width = 70;
            dgvSocios.Columns["Meses"].Width = 50;
            dgvSocios.Columns["FormaPago"].Width = 90;
            dgvSocios.Columns["Total"].Width = 80;
            dgvSocios.Columns["Cuota"].Width = 80;

            foreach (DataGridViewColumn column in dgvSocios.Columns)
            {
                column.HeaderText = column.HeaderText.Replace("FormaPago", "Forma de Pago");
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void MostrarHistorial()
        {
            if (registroSocios.Count == 0)
            {
                MessageBox.Show("No hay registros guardados.", "Historial vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"📊 HISTORIAL DE INSCRIPCIONES ({registroSocios.Count} socios)");
            sb.AppendLine("═".PadRight(80, '═'));

            decimal totalRecaudado = 0;

            for (int i = 0; i < registroSocios.Count; i++)
            {
                var socio = registroSocios[i];
                totalRecaudado += socio.Total;

                sb.AppendLine($"\n{i + 1}. {socio.Nombre}");
                sb.AppendLine($"   Edad: {socio.Edad} años ({socio.Categoria})");
                sb.AppendLine($"   Plan: {socio.Plan} - Horario: {socio.Horario}");
                sb.AppendLine($"   Meses: {socio.Meses} | Pago: {socio.FormaPago}");
                sb.AppendLine($"   Total: {FormatearMoneda(socio.Total)} | Cuota: {FormatearMoneda(socio.ValorCuota)}");
            }

            sb.AppendLine("\n" + "═".PadRight(80, '═'));
            sb.AppendLine($"💰 Total recaudado: {FormatearMoneda(totalRecaudado)}");
            sb.AppendLine($"📈 Promedio por socio: {FormatearMoneda(totalRecaudado / registroSocios.Count)}");

            MessageBox.Show(sb.ToString(), "Historial de Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
