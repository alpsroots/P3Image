using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste.Models
{
    public class ControleModel
    {
        public string Type
        {
            get;
            set;
        }

        public string Label
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public SelectList Values
        {
            get;
            set;
        }
    }
}