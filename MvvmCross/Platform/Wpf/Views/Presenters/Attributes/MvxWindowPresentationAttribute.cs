﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Core.Views;

namespace MvvmCross.Wpf.Views.Presenters.Attributes
{
    public class MvxWindowPresentationAttribute : MvxBasePresentationAttribute
    {
        public string Identifier { get; set; }
        public bool Modal { get; set; }
    }
}
