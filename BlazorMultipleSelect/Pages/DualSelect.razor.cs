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
        public List<DualSelectOption> Selected { get; set; } = new List<DualSelectOption>();
        public int BoxSize { get; set; } = 5;

        private List<DualSelectOption> notSelected = new List<DualSelectOption>();
        private List<DualSelectOption> notSelectedDisplay = new List<DualSelectOption>();
        private string removeAllText = "<<";
        private string searchNotSelectedText = string.Empty;
        

        protected override void OnInitialized()
        {
            notSelected = Options;
            notSelectedDisplay = notSelected;
        }

        private void SearchTheOptions(ChangeEventArgs e)
        {
            searchNotSelectedText = (string)e.Value;
            notSelectedDisplay = notSelected.Where(ns => ns.Value.Contains(searchNotSelectedText)).ToList();
            StateHasChanged();
        }

        private void Select(DualSelectOption option)
        {
            notSelected.Remove(option);
            Selected.Add(option);
            notSelectedDisplay = notSelected;
        }

        private void Deselect(DualSelectOption option)
        {
            Selected.Remove(option);
            notSelected.Add(option);
            notSelectedDisplay = notSelected;
        }

        private void SelectAll()
        {
            Selected.AddRange(notSelected);
            notSelected.Clear();
        }

        private void DeselectAll()
        {
            notSelected.AddRange(Selected);
            Selected.Clear();
        }

        public class DualSelectOption
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }
    }
}
