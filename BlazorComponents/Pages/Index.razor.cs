using BlazorComponents.Pages.PageModels;
using BebComponents;
using static BebComponents.EDualSelect;
using static BebComponents.ESingleSelect;
using static BebComponents.ESelect;
using BebComponents.DataModels;

namespace BlazorComponents.Pages
{    
    public partial class Index
    {
        // ** DUAL SELECT **
        private EDualSelect dualSelect;
        private List<SelectOption> resultList = new();
        private readonly List<SelectOption> DualSelectOptions = new List<SelectOption>
        {
            new SelectOption{ Id=1, Value="One"},
            new SelectOption{ Id=2, Value="Two"},
            new SelectOption{ Id=3, Value="Three"},
            new SelectOption{ Id=4, Value="Four"},
            new SelectOption{ Id=5, Value="Five"},
            new SelectOption{ Id=6, Value="Six"},
            new SelectOption{ Id=7, Value="Seven"},
            new SelectOption{ Id=8, Value="Eight"},
            new SelectOption{ Id=9, Value="Nine"},
            new SelectOption{ Id=10, Value="Ten"},
            new SelectOption{ Id=11, Value="Eleven"},
        };

        private void SubmitEDualSelect()
        {
            resultList = new List<SelectOption> { };
            resultList = dualSelect.SelectedOptions;
        }



        // ** SELECT
        private ESingleSelect eSingleSelect;
        private string eSingleSelectResult;
        private readonly List<SelectOption> singleSelectOptions = new List<SelectOption>
        {
            new SelectOption{ Id=1, Value="One"},
            new SelectOption{ Id=2, Value="Two"},
            new SelectOption{ Id=3, Value="Three"},
            new SelectOption{ Id=4, Value="Four"},
            new SelectOption{ Id=5, Value="Five"},
            new SelectOption{ Id=6, Value="Six"},
            new SelectOption{ Id=7, Value="Seven"},
            new SelectOption{ Id=8, Value="Eight"},
            new SelectOption{ Id=9, Value="Nine"},
            new SelectOption{ Id=10, Value="Ten"},
            new SelectOption{ Id=11, Value="Eleven"},
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
        private readonly List<SelectOption> options = new List<SelectOption>
        {            
            new SelectOption { Id = 1, Value = "Jones" },
            new SelectOption { Id = 2, Value = "Smith" },
            new SelectOption { Id = 3, Value = "Bender" },
            new SelectOption { Id = 4, Value = "Baggio" },
            new SelectOption { Id = 5, Value = "Allen" },
            new SelectOption { Id = 6, Value = "Biggs" },
            new SelectOption { Id = 7, Value = "Randall" },
            new SelectOption { Id = 8, Value = "Anderson" },
            new SelectOption { Id = 8, Value = "Reeves" }
        };

        private void SubmitESelect()
        {
            eSelectResult = eSelect.SelectedOption.Value;
        }

        // ** SELECT2
        private bool enhancedSelect2 = false;
        private ESelect eSelect2;
        private string eSelectResult2;
        private readonly List<SelectOption> options2 = new List<SelectOption>
        {
            new SelectOption { Id = 1, Value = "Bo Jangles" },
            new SelectOption { Id = 2, Value = "Dumbleydorey" },
            new SelectOption { Id = 3, Value = "Bilbo" },
            new SelectOption { Id = 4, Value = "Frodo" },
            new SelectOption { Id = 5, Value = "Rad Karl" },
            new SelectOption { Id = 6, Value = "Grumpy Daryl" },
            new SelectOption { Id = 7, Value = "Calvey" },
            new SelectOption { Id = 8, Value = "Honey Cakes" },
            new SelectOption { Id = 8, Value = "Wonder Muffin" }
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
