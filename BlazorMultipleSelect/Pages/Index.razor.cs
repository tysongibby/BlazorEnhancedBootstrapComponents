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
        List<Item> resultList = new List<Item>();
        List<Item> Items = new List<Item>
        {
            new Item{ Id=1, Value="One"},
            new Item{ Id=2, Value="Two"},
            new Item{ Id=3, Value="Three"},
            new Item{ Id=4, Value="Four"},
            new Item{ Id=5, Value="Five"},
            new Item{ Id=6, Value="Six"},
            new Item{ Id=7, Value="Seven"},
            new Item{ Id=8, Value="Eight"},
            new Item{ Id=9, Value="Nine"},
            new Item{ Id=10, Value="Ten"},
            new Item{ Id=11, Value="Eleven"},
        };

        private void Next()
        {
            resultList = new List<Item> { };
            resultList = dualSelect.Selected;
        }
    }
}
