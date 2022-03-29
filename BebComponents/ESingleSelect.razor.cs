using BebComponents.DataModels;
using Microsoft.AspNetCore.Components;


namespace BebComponents
{
    public partial class ESingleSelect
    {
        [Parameter]
        public List<SelectOption> Options { get; set; } = new List<SelectOption>();
        [Parameter]
        public SelectOption SelectedOption { get; set; } = new SelectOption { Id = 0, Value = " " };

        private int boxSize = 5;

        private void Select(SelectOption option)
        {
            SelectedOption = option;
        }

    }
}
