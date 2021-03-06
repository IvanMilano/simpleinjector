﻿using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using SimpleInjector.Advanced;

namespace ThaWeb
{
    public class ImportPropertySelectionBehavior : IPropertySelectionBehavior
    {
        public bool SelectProperty(Type implementationType, PropertyInfo prop) =>
            prop.GetCustomAttributes(typeof(ImportAttribute)).Any();
    }
}