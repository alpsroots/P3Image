using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models
{
    public class SubCategoriaModel
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

        public virtual CategoriaModel Categoria
        {
            get;
            set;
        }

        public virtual IList<CamposModel> Campos
        {
            get;
            set;
        }
    }
}