using Cinema.Clases;
using Cinema.Forms;

namespace Cinema
{
    public partial class Cinema : Form
    {
        internal List<Pelicula> Peliculas { get; set; } = new();

        public Cinema()
        {
            InitializeComponent();

        }

        private void btnAdd_Principal(object sender, EventArgs e)
        {
            AddForm add = new();
            add.ShowDialog();

            if (add.Success)
            {
                this.Peliculas = add.Peliculas;
                dgvList.DataSource = this.Peliculas;
            }

            /*if (add.ShowDialog() == DialogResult.OK)
            {
                dgvList.DataSource = add.dgvPeliculas;

                if(add.Success)
                {
                    this.Peliculas = add.Peliculas;
                }
            }   */         
        }
    }
}