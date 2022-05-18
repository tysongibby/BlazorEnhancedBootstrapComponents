using BebComponents.DataModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BebComponents
{
    public partial class ESingleSelect
    {
        [Parameter]
        public List<Option> Options { get; set; } = new List<Option>();
        [Parameter]
        public Option SelectedOption { get; set; } = new Option { Text = " ", Value = " " };

        private int boxSize = 5;

        private void Select(Option option)
        {
            SelectedOption = option;
        }

    }
}
