using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Pages
{
    public partial class ESelect
    {
        [Parameter]
        public List<SelectOption> Options { get; set; } = new List<SelectOption>();
        public SelectOption SelectedOption { get; set; } = new SelectOption { Id = 0, Value = " " };

        private int boxSize = 5;

        private void Select(SelectOption option)
        {
            SelectedOption = option;
        }

        public class SelectOption
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }
    }
}
