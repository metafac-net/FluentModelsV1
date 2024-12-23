﻿using System;

namespace FluentModels
{

    /// <summary>
    /// Marks a value type in the model as a proxy for an external type.
    /// </summary>
    [Obsolete("This package has been deprecated. Please use package Metafac.CG4.SChemas.")]
    [AttributeUsage(AttributeTargets.Struct)]
    public class ProxyAttribute : Attribute
    {
        public readonly string ExternalName;
        public readonly string ConcreteName;

        public ProxyAttribute(string externalName, string concreteName)
        {
            ExternalName = externalName;
            ConcreteName = concreteName;
        }
    }
}
