﻿using Pluck.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Services
{
    interface ICardService
    {
        int GetCardID(Card card);
    }
}
