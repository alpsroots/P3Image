using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
	public class ListaCamposModel
	{
        public virtual Int32 Id
        {
            get;
            set;
        }

        public virtual String Descricao
        {
            get;
            set;
        }

        public virtual Int32 IdCampo
        {
            get;
            set;
        }
	}
}