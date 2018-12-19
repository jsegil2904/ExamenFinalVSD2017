using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace School.UI.SistemaMatricula
{
    public partial class Matricular : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                GetAlumno();
        }
        private void GetAlumno()
        {

            if (String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                return;
            var id = Convert.ToInt32(Request.QueryString["id"]);

            var cliente =
                new ServiceReferenceSchool.ServiceSchoolClient();

            var alumno = cliente.GetAlumnoById(id);
            var grados = cliente.GetAllGrados();
            
            inputUserName.Value = alumno.Nombres;
            inputUserApellido.Value = alumno.Apellidos;

            ddlGrados.DataSource = grados.Select(item=>item.Nivel).ToList();
            ddlGrados.DataBind();
            
            alID.Value = alumno.AlumnoID.ToString();
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Response.Redirect("../Matricula/Consultar.aspx");

        }
        private void Guardar()
        {
            
            var service = new ServiceReferenceSchool.ServiceSchoolClient();

            service.AddMatricula(
               new ServiceReferenceSchool.Matricula()
               {
                   Fecha = DateTime.Now,
                   GradoID = service.GetIdGrado(ddlGrados.SelectedValue),
                   SeccionID = service.GetIdSeccion(ddlSecciones.SelectedValue),
                   AlumnoID = Convert.ToInt32(alID.Value),
               });
        }

        protected void ddlGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbChanged();
        }

        private void cmbChanged()
        {
            var cliente =
                new ServiceReferenceSchool.ServiceSchoolClient();
            var secciones = cliente.GetAllSecciones();

            var selectGrado = cliente.GetIdGrado(ddlGrados.SelectedValue);

            ddlSecciones.DataSource = secciones.Where(item => item.GradoID == selectGrado).Select(item => item.Nombre).ToList();
            ddlSecciones.DataBind();
        }

        protected void ddlGrados_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}