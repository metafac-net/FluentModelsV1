﻿using System;

namespace FluentModels
{
    [Obsolete("This package has been deprecated. Please use package Metafac.CG4.SChemas.")]
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
        public readonly int Tag;
        public readonly ModelState State;
        public readonly string? Reason;

        public EntityAttribute(int tag, ModelState state = ModelState.Active, string? reason = null)
        {
            if (tag <= 0) throw new ArgumentOutOfRangeException(nameof(tag), tag, "Must be > 0");
            Tag = tag;
            State = state;
            Reason = reason;
        }

        public bool Deprecated => State.HasFlag(ModelState.Deprecated);
        public bool IsRedacted => State.HasFlag(ModelState.Hidden);
    }
}
