using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenParcial
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (cmbAnimal.Text == "Serpiente")
            {
                
            }
        }

        protected void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresoAnimal_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Animal> animales = new List<Animal>();
            animales = archivo.Leer();
            if (animales = null)
    }
}