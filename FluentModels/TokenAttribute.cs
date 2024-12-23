using System;

namespace FluentModels
{
    /// <summary>
    /// Annotates a model entity with a name/value pair.
    /// </summary>
    [Obsolete("This package has been deprecated. Please use package Metafac.CG4.SChemas.")]
    public class TokenAttribute : Attribute
    {
        public readonly string Name;
        public readonly string Value;

        public TokenAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
