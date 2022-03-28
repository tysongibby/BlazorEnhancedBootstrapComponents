using BlazorComponents.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorComponents.Pages.EDualSelect;
using static BlazorComponents.Pages.ESingleSelect;

namespace BlazorComponents.Pages
{    
    public partial class Index
    {
        EDualSelect dualSelect;
        List<DualSelectOption> resultList = new List<DualSelectOption>();
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

        ESingleSelect singleSelect;
        string singleSelectResult;
        List<SingleSelectOption> SingleSelectOptions = new List<SingleSelectOption>
        {
            new SingleSelectOption{ Id=1, Value="One"},
            new SingleSelectOption{ Id=2, Value="Two"},
            new SingleSelectOption{ Id=3, Value="Three"},
            new SingleSelectOption{ Id=4, Value="Four"},
            new SingleSelectOption{ Id=5, Value="Five"},
            new SingleSelectOption{ Id=6, Value="Six"},
            new SingleSelectOption{ Id=7, Value="Seven"},
            new SingleSelectOption{ Id=8, Value="Eight"},
            new SingleSelectOption{ Id=9, Value="Nine"},
            new SingleSelectOption{ Id=10, Value="Ten"},
            new SingleSelectOption{ Id=11, Value="Eleven"},
        };


        private void SubmitSingleSelect()
        {
            singleSelectResult = singleSelect.SelectedOption.Value;
        }

    }
}
