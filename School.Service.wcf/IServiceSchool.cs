using School.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace School.Service.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "I" in both code and config file together.
    [ServiceContract]
    public interface IServiceSchool
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        IEnumerable<Alumno> GetAlumnosByNombes(string alumnoName);

        [OperationContract]
        bool AddAlumno(Alumno alumno);

        [OperationContract]
        Alumno GetAlumnoById(int id);

        [OperationContract]
        IEnumerable<Grado> GetAllGrados();

        [OperationContract]
        IEnumerable<Seccion> GetAllSecciones();

        [OperationContract]
        int  GetIdGrado(string name);

        [OperationContract]
        int GetIdSeccion(string name);

        [OperationContract]
        bool AddMatricula(Matricula matricula);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
