using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace Teste.Models
{
    public class FormModel
    {
        public virtual Int32 CategoriasID
        {
            get;
            set;
        }

        public virtual Int32 SubCategoriasID
        {
            get;
            set;
        }

        public List<ControleModel> Controles
        {
            get;
            set;
        }

        public FormModel GerarCampos(List<CamposModel> campos)
        {
            FormModel formModel = new FormModel()
            {
                Controles = new List<ControleModel>()
            };

            campos.OrderBy(c => c.Ordem).ToList().ForEach(item => formModel.Controles.Add(new ControleModel()
            {
                Label = item.Descricao,
                Name = item.Descricao,
                Type = item.Tipo.ToLower(),
                Values = new SelectList(item.ListaCampos, "Id", "Descricao")
            }));

            return formModel;
        }
    }
}