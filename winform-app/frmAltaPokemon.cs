using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if(pokemon == null)
                {
                    pokemon = new Pokemon();
                }
                pokemon.Nombre = txbNombre.Text;
                pokemon.Descripcion = txbDescripcion.Text;
                pokemon.Numero = (int)nudNumero.Value;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                pokemon.UrlImagen = txbImagen.Text;

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Pokemon agregado exitosamente!!");
                }

                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Pokemon agregado exitosamente!!");
                }
                
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en la carga");
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";


                if (pokemon!=null)
                {
                    btnAgregar.Text = "Actualizar";
                    nudNumero.Value = pokemon.Numero;
                    txbDescripcion.Text = pokemon.Descripcion;
                    txbImagen.Text = pokemon.UrlImagen;
                    txbNombre.Text = pokemon.Nombre;
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAltaPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txbImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txbImagen.Text);
            
        }
    }
}
