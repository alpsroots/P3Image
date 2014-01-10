using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class CategoriaModel
    {
        public virtual int Id
        {
            get;
            set;
        }

        [DisplayName("Descrição")]
        public virtual string Descricao
        {
            get;
            set;
        }
    }
}