using System.ComponentModel;

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