using Cinema.Clases;
using Cinema.Forms;

namespace Cinema
{
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
            dgvList.DataSource = bindingSource;
        }

        private void btnAdd_Principal(object sender, EventArgs e)
        {
            AddForm add = new();
            add.ShowDialog();

            if (add.Success)
            {

                if(bindingSource.DataSource != null)
                {

                    (bindingSource.DataSource as List<Pelicula>).AddRange(add.Peliculas);
                }
                else
                {
                    bindingSource.DataSource = add.Peliculas;
                }
             
            }

            //refresh y validar
            bindingSource.ResetBindings(false);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new();

            Pelicula peliculaActual = bindingSource.Current as Pelicula;

            //for (int i = 0; i < this.Pelicula.Count; i++)
            //{
            edit.Peliculas.Nombre = dgvList.CurrentRow.Cells[0].Value.ToString();
            edit.Peliculas.Genero = dgvList.CurrentRow.Cells[1].Value.ToString();
            edit.Peliculas.Clasificacion = dgvList.CurrentRow.Cells[2].Value.ToString();
            edit.Peliculas.Precio = float.Parse(dgvList.CurrentRow.Cells[3].Value.ToString());
            if (edit.ShowDialog() == DialogResult.OK)
            {
                dgvList.CurrentRow.Cells[0].Value = edit.Peliculas.Nombre;
                dgvList.CurrentRow.Cells[1].Value = edit.Peliculas.Genero;
                dgvList.CurrentRow.Cells[2].Value = edit.Peliculas.Clasificacion;
                dgvList.CurrentRow.Cells[3].Value = edit.Peliculas.Precio;
            }
            //}
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Ver ver = new Ver();
            ver.Peliculas.Nombre = dgvList.CurrentRow.Cells[0].Value.ToString();
            ver.Peliculas.Genero = dgvList.CurrentRow.Cells[1].Value.ToString();
            ver.Peliculas.Clasificacion = dgvList.CurrentRow.Cells[2].Value.ToString();
            ver.Peliculas.Precio = float.Parse(dgvList.CurrentRow.Cells[3].Value.ToString());
            ver.ShowDialog();

        }
    }
}