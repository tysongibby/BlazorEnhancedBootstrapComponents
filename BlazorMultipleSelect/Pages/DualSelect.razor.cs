using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultipleSelect.Pages
{
    /// <summary>
    /// Dual Multiple select Blazor component. Holds non-selected options in the left select element and selected options in the right select element. Retrieve "Selected" by using "@ref=" in component tag to get resulting list of selected options. Option(int Id, string Value)
    /// </summary>
    public partial class DualSelect
    {
        [Parameter]
        public List<Option> Options { get; set; } = new List<Option>();

        public List<Option> NotSelected { get; set; } = new List<Option>();
        public List<Option> Selected { get; set; } = new List<Option>();
        private string removeAllText = "<<";
        private int BoxSize { get; set; } = 5;

        protected override void OnInitialized()
        {
            NotSelected = Options;
        }

        private void Select(Option item)
        {
            NotSelected.Remove(item);
            Selected.Add(item);
        }

        private void Deselect(Option item)
        {
            Selected.Remove(item);
            NotSelected.Add(item);
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
    }

    public class Option
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
