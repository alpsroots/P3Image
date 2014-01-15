using System.Collections.Generic;
using System.ComponentModel;

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

        [DisplayName("Categoria")]
        public virtual CategoriaModel Categoria
        {
            get;
            set;
        }

        [DisplayName("Campos")]
        public virtual IList<CamposModel> Campos
        {
            get;
            set;
        }
    }
}