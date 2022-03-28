using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Pages
{
    public partial class ESingleSelect
    {
        [Parameter]
        public List<SingleSelectOption> Options { get; set; } = new List<SingleSelectOption>();
        public SingleSelectOption SelectedOption { get; set; } = new SingleSelectOption { Id = 0, Value = " " };

        private int boxSize = 5;

        private void Select(SingleSelectOption option)
        {
            SelectedOption = option;
        }

        public class SingleSelectOption
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }
    }
}
