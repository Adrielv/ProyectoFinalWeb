using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalWeb.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Ingrese un Nombree")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Ingrese un Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una dirrecion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Ingrese un telefono")]
        public string Telefono { get; set; }




        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
          
        }
    }
}
