using BlazorMultipleSelect.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultipleSelect.Pages
{
    public partial class Index
    {
        private string removeAllText = "<<";
        [Parameter]
        public List<ItemModel> NotSelected { get; set; } = new List<ItemModel>();
        [Parameter]
        public List<ItemModel> Selected { get; set; } = new List<ItemModel>();

        protected override void OnInitialized()
        {
            NotSelected = new List<ItemModel> 
            {
                new ItemModel {Name = "One", Value = 1},
                new ItemModel {Name = "Two", Value = 2},
                new ItemModel {Name = "Three", Value = 3},
                new ItemModel {Name = "Four", Value = 4},
                new ItemModel {Name = "Five", Value = 5}
            };
        }

        private void Select(ItemModel item)
        {
            NotSelected.Remove(item);
            Selected.Add(item);
        }

        private void Deselect(ItemModel item)
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
}
