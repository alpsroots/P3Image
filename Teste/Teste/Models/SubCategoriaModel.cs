using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class SubCategoriaModel
    {
        public virtual int Id
        {
            get;
            set;
        }

        [Required(ErrorMessage="Informe a Categoria.")]
        [DisplayName("Categoria")]        
        public virtual CategoriaModel Categoria
        {
            get;
            set;
        }

        [Required(ErrorMessage="Informe a Descrição.")]
        [DisplayName("Descrição")]
        public virtual string Descricao
        {
            get;
            set;
        }
    }
}