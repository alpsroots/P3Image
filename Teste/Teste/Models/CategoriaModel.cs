using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class CategoriaModel
    {
        public virtual Int32 Id
        {
            get;
            set;
        }

        [DisplayName("Descrição")]
        [Required(ErrorMessage="Descrição é um campo obrigatório.")]
        public virtual String Descricao
        {
            get;
            set;
        }
    }
}