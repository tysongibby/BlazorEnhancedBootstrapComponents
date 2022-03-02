using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultipleSelect.Pages
{
    public partial class DualSelect
    {
        [Parameter]
        public List<Item> Items { get; set; } = new List<Item>();

        public List<Item> NotSelected { get; set; } = new List<Item>();
        public List<Item> Selected { get; set; } = new List<Item>();
        private string removeAllText = "<<";
        private int BoxSize { get; set; } = 5;

        protected override void OnInitialized()
        {
            NotSelected = Items;
        }

        private void Select(Item item)
        {
            NotSelected.Remove(item);
            Selected.Add(item);
        }

        private void Deselect(Item item)
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

    public class Item
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
