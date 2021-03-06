﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Platformus.Barebone.Backend.Metadata.Providers;

namespace Platformus.Barebone.Backend.ViewComponents
{
  public class BackendMenuViewComponent : ViewComponentBase
  {
    private IMenuGroupsProvider menuGroupsProvider;

    public BackendMenuViewComponent(IStorage storage, IMenuGroupsProvider menuGroupsProvider)
      : base(storage)
    {
      this.menuGroupsProvider = menuGroupsProvider;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
      return this.View(this.menuGroupsProvider.GetMenuGroups(this));
    }
  }
}