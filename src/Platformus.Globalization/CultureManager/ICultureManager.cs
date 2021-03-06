﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Platformus.Globalization.Data.Entities;

namespace Platformus.Globalization
{
  public interface ICultureManager
  {
    Culture GetCulture(int id);
    Culture GetCulture(string code);
    Culture GetNeutralCulture();
    Culture GetDefaultCulture();
    Culture GetBackendUiCulture();
    Culture GetCurrentCulture();
    IEnumerable<Culture> GetCultures();
    IEnumerable<Culture> GetNotNeutralCultures();
    void InvalidateCache();
  }
}