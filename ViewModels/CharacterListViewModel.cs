﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAplication.ViewModels
{
    public class CharacterListViewModel
    {
        public IEnumerable<CharacterListItemViewModel> Characters { get; set; }
    }
}
