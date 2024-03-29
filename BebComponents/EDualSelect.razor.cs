﻿using BebComponents.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BebComponents
{
    /// <summary>
    /// Dual Multiple select Blazor component. Holds options available for selection in the left select element and selected options in the right select element. 
    /// Set "AvailableOptions" by creating a List of SelectOptions: List<SelectOption>{ SelectOption { Id = int, Value = string } }
    /// "SelectedOptions" retrieves the list DualSelectOptions which contains the options selected by the user. Returned via @ref= .
    /// "BoxHeight" allows configuration of the row height of the text box of the multiple select elements.
    /// </summary>
    public partial class EDualSelect
    {
        /// <summary>
        /// List of options availble to use for selection.
        /// </summary>
        [Parameter]       
        public List<Option> AvailableOptions { get; set; } = new List<Option>(); 
        /// <summary>
        /// List of options selected by the user. Returned via @ref= .
        /// </summary>
        [Parameter]
        public List<Option> SelectedOptions { get; set; } = new List<Option>();
        /// <summary>
        /// Row height of the text boxes for the multiple select elements.
        /// </summary>
        [Parameter]
        public int BoxHeight { get; set; } = 5;

        private List<Option> notSelected = new List<Option>();
        private List<Option> notSelectedDisplay = new List<Option>();
        private List<Option> selectedDisplay = new List<Option>();
        private readonly string removeAllText = "<<";
        private string searchNotSelectedText = string.Empty;
        private string searchSelectedText = string.Empty;


        protected override void OnInitialized()
        {
            notSelected = AvailableOptions;
            notSelectedDisplay = notSelected;
        }
        
        private void SearchNotSelected(ChangeEventArgs e)
        {
            searchNotSelectedText = (string)e.Value;
            notSelectedDisplay = notSelected.Where(ns => ns.Text.Contains(searchNotSelectedText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void SearchSelected(ChangeEventArgs e)
        {
            searchSelectedText = (string)e.Value;
            selectedDisplay = SelectedOptions.Where(ns => ns.Text.Contains(searchSelectedText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void Select(Option option)
        {
            // update lists
            notSelected.Remove(option);
            SelectedOptions.Add(option);

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = SelectedOptions;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void Deselect(Option option)
        {
            // update lists
            SelectedOptions.Remove(option);
            notSelected.Add(option);

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = SelectedOptions;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void SelectAll()
        {
            // update lists
            SelectedOptions.AddRange(notSelected);            
            notSelected.Clear();

            // set display text
            selectedDisplay = SelectedOptions;
            notSelectedDisplay = notSelected;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

        private void DeselectAll()
        {
            // update lists
            notSelected.AddRange(SelectedOptions);            
            SelectedOptions.Clear();

            // set display text
            notSelectedDisplay = notSelected;
            selectedDisplay = SelectedOptions;

            // clear search fields (not working as these are unbound fields)
            searchNotSelectedText = string.Empty;
            searchSelectedText = string.Empty;
        }

    }
}
