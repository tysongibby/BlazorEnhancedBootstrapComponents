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
        public int BoxHeight { get; set; } = 5;
        public class DualSelectOption
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }

        private List<DualSelectOption> notSelected = new List<DualSelectOption>();
        private List<DualSelectOption> notSelectedDisplay = new List<DualSelectOption>();
        private List<DualSelectOption> selectedDisplay = new List<DualSelectOption>();
        private readonly string removeAllText = "<<";
        private string searchNotSelectedText = string.Empty;
        private string searchSelectedText = string.Empty;


        protected override void OnInitialized()
        {
            notSelected = Options;
            notSelectedDisplay = notSelected;
        }
        
        private void SearchNotSelected(ChangeEventArgs e)
        {
            searchNotSelectedText = (string)e.Value;
            notSelectedDisplay = notSelected.Where(ns => ns.Value.Contains(searchNotSelectedText, StringComparison.OrdinalIgnoreCase)).ToList();
            //StateHasChanged();
        }

        private void SearchSelected(ChangeEventArgs e)
        {
            searchSelectedText = (string)e.Value;
            selectedDisplay = Selected.Where(ns => ns.Value.Contains(searchSelectedText, StringComparison.OrdinalIgnoreCase)).ToList();
            //StateHasChanged();
        }

        private void Select(DualSelectOption option)
        {
            // update lists
            notSelected.Remove(option);
            Selected.Add(option);

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = Selected;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void Deselect(DualSelectOption option)
        {
            // update lists
            Selected.Remove(option);
            notSelected.Add(option);

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = Selected;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void SelectAll()
        {
            // update lists
            Selected.AddRange(notSelected);            
            notSelected.Clear();

            // set display text
            selectedDisplay = Selected;
            notSelectedDisplay = notSelected;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void DeselectAll()
        {
            // update lists
            notSelected.AddRange(Selected);            
            Selected.Clear();

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = Selected;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

    }
}
