using BlazorComponents.Pages.PageModels;
using BebComponents;
using static BebComponents.EDualSelect;
using static BebComponents.ESingleSelect;

namespace BlazorComponents.Pages
{    
    public partial class Index
    {
        // ** DUAL SELECT **
        private EDualSelect dualSelect;
        private List<DualSelectOption> resultList = new List<DualSelectOption>();
        List<DualSelectOption> DualSelectOptions = new List<DualSelectOption>
        {
            new DualSelectOption{ Id=1, Value="One"},
            new DualSelectOption{ Id=2, Value="Two"},
            new DualSelectOption{ Id=3, Value="Three"},
            new DualSelectOption{ Id=4, Value="Four"},
            new DualSelectOption{ Id=5, Value="Five"},
            new DualSelectOption{ Id=6, Value="Six"},
            new DualSelectOption{ Id=7, Value="Seven"},
            new DualSelectOption{ Id=8, Value="Eight"},
            new DualSelectOption{ Id=9, Value="Nine"},
            new DualSelectOption{ Id=10, Value="Ten"},
            new DualSelectOption{ Id=11, Value="Eleven"},
        };

        private void SubmitDualSelect()
        {
            resultList = new List<DualSelectOption> { };
            resultList = dualSelect.SelectedOptions;
        }



        // ** SELECT
        private ESingleSelect eSingleSelect;
        private string SelectResult;
        List<SelectOption> SelectOptions = new List<SelectOption>
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

        private void SubmitSelect()
        {
            SelectResult = eSingleSelect.SelectedOption.Value;
        }


        // ** INPUT TYPE="TEXT" **
        public IndexFormModel Form { get; set; } = new IndexFormModel();
        private string firstName = string.Empty;

        public void ValidFormSubmit()
        {
            firstName = Form.FirstName;
        }


    }
}
