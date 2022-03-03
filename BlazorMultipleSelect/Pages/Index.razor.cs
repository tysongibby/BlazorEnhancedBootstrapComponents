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
        DualSelect dualSelect;
        List<Option> resultList = new List<Option>();
        List<Option> Items = new List<Option>
        {
            new Option{ Id=1, Value="One"},
            new Option{ Id=2, Value="Two"},
            new Option{ Id=3, Value="Three"},
            new Option{ Id=4, Value="Four"},
            new Option{ Id=5, Value="Five"},
            new Option{ Id=6, Value="Six"},
            new Option{ Id=7, Value="Seven"},
            new Option{ Id=8, Value="Eight"},
            new Option{ Id=9, Value="Nine"},
            new Option{ Id=10, Value="Ten"},
            new Option{ Id=11, Value="Eleven"},
        };

        private void Next()
        {
            resultList = new List<Option> { };
            resultList = dualSelect.Selected;
        }
    }
}
