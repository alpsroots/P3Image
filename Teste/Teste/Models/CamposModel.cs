using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class CamposModel
    {
        public virtual Int32 Id
        {
            get;
            set;
        }

        public virtual Int32 Ordem
        {
            get;
            set;
        }

        public virtual String Descricao
        {
            get;
            set;
        }

        public virtual String Tipo
        {
            get;
            set;
        }

        public virtual Int32 IdSubCategoria
        {
            get;
            set;
        }

        public virtual IList<ListaCamposModel> ListaCampos
        {
            get;
            set;
        }
    }
}