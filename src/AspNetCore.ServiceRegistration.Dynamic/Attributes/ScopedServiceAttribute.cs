﻿// <copyright file="ScopedServiceAttribute.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

using System;

namespace AspNetCore.ServiceRegistration.Dynamic.Attributes
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ScopedServiceAttribute : Attribute
    {
    }
}