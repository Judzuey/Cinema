using Cinema.Clases;


namespace Cinema.Forms
{
    public partial class Edit : Form
    {
        internal Pelicula Peliculas { get; set; } = new();
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Shown(object sender, EventArgs e)
        {
            txtName.Text = Peliculas.Nombre;
            txtCategory.Text = Peliculas.Genero;
            txtClassification.Text = Peliculas.Clasificacion;
            txtPrice.Text = Peliculas.Precio.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Peliculas.Nombre = txtName.Text;
            Peliculas.Genero = txtCategory.Text;
            Peliculas.Clasificacion = txtClassification.Text;
            Peliculas.Precio = float.Parse(txtPrice.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
