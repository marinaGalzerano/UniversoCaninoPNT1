using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Prueba.Models
{
    public class Product
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Descr { get; set; }

        public double Price { get; set; }

        [EnumDataType(typeof(TIPO_ANIMAL))]
        public TIPO_ANIMAL Tipo { get; set; }

    }
}

