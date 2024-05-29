using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T2_GonzalesTasaycoDiego.Models
{
    public class Distribuidor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "Ingresar ID obligatoriamente")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingresar Nombre del Distribuidor obligatoriamente")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "Ingresar Razon Social obligatoriamente")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Ingresar Telefono obligatoriamente")]
        public int Telefono { get; set; }


        [Required(ErrorMessage = "Ingresar Año obligatoriamente")]
        [Range( 1900, 3000, ErrorMessage = "El año ingresado debe ser de ( 1900 - 3000 )")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "Ingresar Contacto obligatoriamente")]
        public string Contacto { get; set; }


    }
}
