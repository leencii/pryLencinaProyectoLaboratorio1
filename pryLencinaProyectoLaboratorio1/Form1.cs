using System.Globalization;

namespace pryLencinaProyectoLaboratorio1
{
    public partial class Form1 : Form
    {
        private readonly float[,] ventas = new float[5, 4];
        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private readonly string[] categorias = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };
        private readonly CultureInfo culturaArgentina = CultureInfo.GetCultureInfo("es-AR");
        private bool datosValidados;

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrilla();
            DeshabilitarConsultas();
        }

        private void ConfigurarGrilla()
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Mozo",
                HeaderText = "Mozo",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 145
            });

            for (int columna = 0; columna < categorias.Length; columna++)
            {
                dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"Categoria{columna}",
                    HeaderText = categorias[columna],
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Width = 170
                });
            }

            foreach (string mozo in mozos)
            {
                dgvVentas.Rows.Add(mozo, "", "", "", "");
            }

            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
            dgvVentas.CurrentCellDirtyStateChanged += dgvVentas_CurrentCellDirtyStateChanged;
        }

        private void dgvVentas_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvVentas.IsCurrentCellDirty)
            {
                dgvVentas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvVentas_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                datosValidados = false;
                DeshabilitarConsultas();
            }
        }

        private void btnValidar_Click(object? sender, EventArgs e)
        {
            for (int fila = 0; fila < mozos.Length; fila++)
            {
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    string texto = Convert.ToString(dgvVentas.Rows[fila].Cells[columna + 1].Value)?.Trim() ?? string.Empty;
                    if (!TryParseImporte(texto, out float importe) || importe < 0)
                    {
                        datosValidados = false;
                        DeshabilitarConsultas();
                        MessageBox.Show(
                            $"La celda de {mozos[fila]} en '{categorias[columna]}' debe contener un importe numérico mayor o igual a cero.",
                            "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvVentas.CurrentCell = dgvVentas.Rows[fila].Cells[columna + 1];
                        dgvVentas.BeginEdit(true);
                        return;
                    }

                    ventas[fila, columna] = importe;
                }
            }

            datosValidados = true;
            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Todos los datos son válidos.", "Validación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool TryParseImporte(string texto, out float importe)
        {
            return float.TryParse(texto, NumberStyles.Float, culturaArgentina, out importe)
                || float.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out importe);
        }

        private void btnMozoDelDia_Click(object? sender, EventArgs e)
        {
            if (!datosValidados) return;

            int indiceMayor = 0;
            float mayor = ObtenerTotalMozo(0);
            for (int fila = 1; fila < mozos.Length; fila++)
            {
                float totalMozo = ObtenerTotalMozo(fila);
                if (totalMozo > mayor)
                {
                    mayor = totalMozo;
                    indiceMayor = fila;
                }
            }

            txtNombreMozo.Text = mozos[indiceMayor];
            txtImporteMozo.Text = FormatearImporte(mayor);
        }

        private void btnTotales_Click(object? sender, EventArgs e)
        {
            if (!datosValidados) return;

            float totalGeneral = 0;
            float[] totalesPorCategoria = new float[categorias.Length];
            for (int fila = 0; fila < mozos.Length; fila++)
            {
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    totalGeneral += ventas[fila, columna];
                    totalesPorCategoria[columna] += ventas[fila, columna];
                }
            }

            txtTotalGeneral.Text = FormatearImporte(totalGeneral);
            txtTotalComidas.Text = FormatearImporte(totalesPorCategoria[0]);
            txtTotalBebidasSinAlcohol.Text = FormatearImporte(totalesPorCategoria[1]);
            txtTotalBebidasConAlcohol.Text = FormatearImporte(totalesPorCategoria[2]);
            txtTotalPostres.Text = FormatearImporte(totalesPorCategoria[3]);
        }

        private float ObtenerTotalMozo(int fila)
        {
            float total = 0;
            for (int columna = 0; columna < categorias.Length; columna++)
            {
                total += ventas[fila, columna];
            }

            return total;
        }

        private string FormatearImporte(float importe)
        {
            return importe.ToString("N2", culturaArgentina);
        }

        private void DeshabilitarConsultas()
        {
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            txtNombreMozo.Clear();
            txtImporteMozo.Clear();
            txtTotalGeneral.Clear();
            txtTotalComidas.Clear();
            txtTotalBebidasSinAlcohol.Clear();
            txtTotalBebidasConAlcohol.Clear();
            txtTotalPostres.Clear();
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
