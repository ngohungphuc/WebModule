﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity;

namespace AspNet5ModularApp.Data.EF.Sqlite
{
  public interface IModelRegistrar
  {
    void RegisterModels(ModelBuilder modelbuilder);
  }
}