

using Cinema.Clases;

namespace Cinema.Forms
{
    public partial class Ver : Form
    {
        internal Pelicula Peliculas { get; set; } = new();
        public Ver()
        {
            InitializeComponent();
        }

        private void Ver_Shown(object sender, EventArgs e)
        {
            dgvView.Columns.Add("ColumnNombre", "Nombre");
            dgvView.Columns.Add("ColumnGenero", "Genero");
            dgvView.Columns.Add("ColumnClasificacion", "Clasificacion");
            dgvView.Columns.Add("ColumnPrecio", "Precio");

            dgvView.Rows.Add();
            dgvView.CurrentRow.Cells[0].Value = Peliculas.Nombre;
            dgvView.CurrentRow.Cells[1].Value = Peliculas.Genero;
            dgvView.CurrentRow.Cells[2].Value = Peliculas.Clasificacion;
            dgvView.CurrentRow.Cells[3].Value = Peliculas.Precio.ToString();
        }
    }
}
