using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels.General
{
    public class BaseRetornoApi<Entity> where Entity : BaseViewModel
    {
        public int Count { get; set; }
        public int PaginaAtual { get; set; }
        public List<Entity> Data { get; set; }
    }
}
