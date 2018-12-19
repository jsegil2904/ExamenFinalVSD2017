using School.UI.SistemaMatricula.ServiceReferenceSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School.UI.SistemaMatricula
{
    public partial class Consultar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Consulta();
            }
                
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
        private void Consulta()
        {
            
            var service = new ServiceReferenceSchool.ServiceSchoolClient();
            Alumno[] data;

            data = service.GetAlumnosByNombes(txtNombreAlumno.Value);
            grdAlumnos.DataSource = data;
            grdAlumnos.DataBind();

        }
    }
}