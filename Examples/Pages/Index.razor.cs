using Examples.Pages.PageModels;
using BebComponents;
using static BebComponents.EDualSelect;
using static BebComponents.EMultipleSelect;
using static BebComponents.ESelect;
using BebComponents.DataModels;
using System.Collections.Generic;

namespace Examples.Pages
{    
    public partial class Index
    {
        // ** DUAL SELECT **
        private EDualSelect dualSelect;
        private List<Option> resultList = new();
        private readonly List<Option> DualSelectOptions = new List<Option>
        {
            new Option{ Value="1", Text="One"},
            new Option{ Value="2", Text="Two"},
            new Option{ Value="3", Text="Three"},
            new Option{ Value="4", Text="Four"},
            new Option{ Value="5", Text="Five"},
            new Option{ Value="6", Text="Six"},
            new Option{ Value="7", Text="Seven"},
            new Option{ Value="8", Text="Eight"},
            new Option{ Value="9", Text="Nine"},
            new Option{ Value="10", Text="Ten"},
            new Option{ Value="11", Text="Eleven"},
        };

        private void SubmitEDualSelect()
        {
            resultList = new List<Option> { };
            resultList = dualSelect.SelectedOptions;
        }



        // ** SELECT
        private EMultipleSelect eMultipleSelect;
        private string eMultipleSelectResult;
        private readonly List<Option> multipleSelectOptions = new List<Option>
        {
            new Option{ Value="1", Text="One"},
            new Option{ Value="2", Text="Two"},
            new Option{ Value="3", Text="Three"},
            new Option{ Value="4", Text="Four"},
            new Option{ Value="5", Text="Five"},
            new Option{ Value="6", Text="Six"},
            new Option{ Value="7", Text="Seven"},
            new Option{ Value="8", Text="Eight"},
            new Option{ Value="9", Text="Nine"},
            new Option{ Value="10", Text="Ten"},
            new Option{ Value="11", Text="Eleven"},
        };

        private void SubmitEMultipleSelect()
        {
            eMultipleSelectResult = eMultipleSelect.SelectedOption.Value;
        }


        // ** INPUT TYPE="TEXT" **
        public IndexFormModel Form { get; set; } = new IndexFormModel();
        private string firstName = string.Empty;

        public void ValidFormSubmit()
        {
            firstName = Form.FirstName;
        }



        // ** SELECT
        private ESelect eSelect;
        private string eSelectResult;
        private readonly List<Option> options = new List<Option>
        {            
            new Option { Value = "1", Text = "Jones" },
            new Option { Value = "2", Text = "Smith" },
            new Option { Value = "3", Text = "Bender" },
            new Option { Value = "4", Text = "Baggio" },
            new Option { Value = "5", Text = "Allen" },
            new Option { Value = "6", Text = "Biggs" },
            new Option { Value = "7", Text = "Randall" },
            new Option { Value = "8", Text = "Anderson" },
            new Option { Value = "9", Text = "Reeves" }
        };

        private void SubmitESelect()
        {
            eSelectResult = eSelect.SelectedOption.Value;
        }

        // ** SELECT2
        private bool enhancedSelect2 = false;
        private ESelect eSelect2;
        private string eSelectResult2;
        private readonly List<Option> options2 = new List<Option>
        {
            new Option { Text = "1", Value = "Bo Jangles" },
            new Option { Text = "2", Value = "Dumbleydorey" },
            new Option { Text = "3", Value = "Bilbo" },
            new Option { Text = "4", Value = "Frodo" },
            new Option { Text = "5", Value = "Rad Karl" },
            new Option { Text = "6", Value = "Grumpy Daryl" },
            new Option { Text = "7", Value = "Calvey" },
            new Option { Text = "8", Value = "Honey Cakes" },
            new Option { Text = "9", Value = "Wonder Muffin" }
        };

        private void EnableEnhancedSelect2()
        {
            enhancedSelect2 = true;
        }

        private void SubmitESelect2()
        {
            eSelectResult2 = eSelect2.SelectedOption.Value;
        }



    }
}
