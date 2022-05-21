//using BebComponents.DataModels;
//using Microsoft.AspNetCore.Components;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;

//namespace BebComponents
//{
//    public partial class EMultipleSelect
//    {
//        [Parameter]
//        public string Id { get; set; }
//        [Parameter]
//        public List<Option> Options { get; set; } = new List<Option>();
//        [Parameter]
//        public Option SelectedOption { get; set; } = new Option { Text = " ", Value = " " };
//        [Parameter]
//        public int BoxHieght { get; set; } = 5;
//        [Parameter]
//        public string BoxWidth { get; set; } = "auto";
//        [Parameter, EditorRequired]
//        public Expression<Func<string>> ValidationFor { get; set; } = default!;

//        private void SelectOption(Option option)
//        {
//            SelectedOption = option;
//        }
//        protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
//        {
//            try
//            {
//                result = value;
//                validationErrorMessage = null;
//                return true;
//            }
//            catch (Exception exception)
//            {
//                result = null;
//                validationErrorMessage = exception.Message;
//                return false;
//            }

//        }
//    }
//}
