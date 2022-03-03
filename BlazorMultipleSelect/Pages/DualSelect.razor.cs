using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultipleSelect.Pages
{
    /// <summary>
    /// Dual Multiple select Blazor component. Holds non-selected options in the left select element and selected options in the right select element. 
    /// Set Options by creating a List of DualSelectOptions: List<DualSelectOption>{ DualSelectOption { Id = int, Value = string } }
    /// Retrieve "Selected" by using "@ref=" in component tag to get resulting list of DualSelectOptions. 
    /// </summary>
    public partial class DualSelect
    {
        [Parameter]
        public List<DualSelectOption> Options { get; set; } = new List<DualSelectOption>();

        public List<DualSelectOption> NotSelected { get; set; } = new List<DualSelectOption>();
        public List<DualSelectOption> Selected { get; set; } = new List<DualSelectOption>();
        private string removeAllText = "<<";
        private int BoxSize { get; set; } = 5;

        protected override void OnInitialized()
        {
            NotSelected = Options;
        }

        private void Select(DualSelectOption option)
        {
            NotSelected.Remove(option);
            Selected.Add(option);
        }

        private void Deselect(DualSelectOption option)
        {
            Selected.Remove(option);
            NotSelected.Add(option);
        }

        private void SelectAll()
        {
            Selected.AddRange(NotSelected);
            NotSelected.Clear();
        }

        private void DeselectAll()
        {
            NotSelected.AddRange(Selected);
            Selected.Clear();
        }

        public class DualSelectOption
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }
    }
}
