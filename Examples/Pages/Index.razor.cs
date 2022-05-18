using Examples.Pages.PageModels;
using BebComponents;
using static BebComponents.EDualSelect;
using static BebComponents.ESingleSelect;
using static BebComponents.ESelect;
using BebComponents.DataModels;

namespace Examples.Pages
{    
    public partial class Index
    {
        // ** DUAL SELECT **
        private EDualSelect dualSelect;
        private List<Option> resultList = new();
        private readonly List<Option> DualSelectOptions = new List<Option>
        {
            new Option{ Text=1, Value="One"},
            new Option{ Text=2, Value="Two"},
            new Option{ Text=3, Value="Three"},
            new Option{ Text=4, Value="Four"},
            new Option{ Text=5, Value="Five"},
            new Option{ Text=6, Value="Six"},
            new Option{ Text=7, Value="Seven"},
            new Option{ Text=8, Value="Eight"},
            new Option{ Text=9, Value="Nine"},
            new Option{ Text=10, Value="Ten"},
            new Option{ Text=11, Value="Eleven"},
        };

        private void SubmitEDualSelect()
        {
            resultList = new List<Option> { };
            resultList = dualSelect.SelectedOptions;
        }



        // ** SELECT
        private ESingleSelect eSingleSelect;
        private string eSingleSelectResult;
        private readonly List<Option> singleSelectOptions = new List<Option>
        {
            new Option{ Text=1, Value="One"},
            new Option{ Text=2, Value="Two"},
            new Option{ Text=3, Value="Three"},
            new Option{ Text=4, Value="Four"},
            new Option{ Text=5, Value="Five"},
            new Option{ Text=6, Value="Six"},
            new Option{ Text=7, Value="Seven"},
            new Option{ Text=8, Value="Eight"},
            new Option{ Text=9, Value="Nine"},
            new Option{ Text=10, Value="Ten"},
            new Option{ Text=11, Value="Eleven"},
        };

        private void SubmitESingleSelect()
        {
            eSingleSelectResult = eSingleSelect.SelectedOption.Value;
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
            new Option { Text = 1, Value = "Jones" },
            new Option { Text = 2, Value = "Smith" },
            new Option { Text = 3, Value = "Bender" },
            new Option { Text = 4, Value = "Baggio" },
            new Option { Text = 5, Value = "Allen" },
            new Option { Text = 6, Value = "Biggs" },
            new Option { Text = 7, Value = "Randall" },
            new Option { Text = 8, Value = "Anderson" },
            new Option { Text = 8, Value = "Reeves" }
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
            new Option { Text = 1, Value = "Bo Jangles" },
            new Option { Text = 2, Value = "Dumbleydorey" },
            new Option { Text = 3, Value = "Bilbo" },
            new Option { Text = 4, Value = "Frodo" },
            new Option { Text = 5, Value = "Rad Karl" },
            new Option { Text = 6, Value = "Grumpy Daryl" },
            new Option { Text = 7, Value = "Calvey" },
            new Option { Text = 8, Value = "Honey Cakes" },
            new Option { Text = 8, Value = "Wonder Muffin" }
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
