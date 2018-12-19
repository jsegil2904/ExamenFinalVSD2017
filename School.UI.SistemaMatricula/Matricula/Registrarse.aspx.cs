using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School.UI.SistemaMatricula
{
    public partial class Registrarse : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
            
        }
        private void Guardar()
        {
            var valorGenero="";
            if (inputSexo1.Checked)
            {
                valorGenero = inputSexo1.Value.ToString();
            }
            else if (inputSexo2.Checked)
            {
                valorGenero = inputSexo2.Value;
            }
                
            var service = new ServiceReferenceSchool.ServiceSchoolClient();
           
             service.AddAlumno(
                new ServiceReferenceSchool.Alumno()
                {
                    Nombres = inputUserName.Value,
                    Apellidos = inputUserApellido.Value,
                    Direccion = inputUserAddress.Value,
                    Sexo = valorGenero,
                    FechaNacimiento = Convert.ToDateTime(inputUserDateBirthday.Value)
                });
            
        }

        private void Limpiar()
        {
            inputUserName.Value = "";
            inputUserApellido.Value = "";
            inputUserAddress.Value = "";
            inputUserDateBirthday.Value = "01/01/1990"; 

        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}