namespace School.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matricula")]
    public partial class Matricula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatriculoID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int GradoID { get; set; }

        public int SeccionID { get; set; }

        public int AlumnoID { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Grado Grado { get; set; }
    }
}
