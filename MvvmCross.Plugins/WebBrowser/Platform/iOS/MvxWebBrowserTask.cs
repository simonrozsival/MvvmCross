﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Foundation;
using MvvmCross.Platform.iOS.Platform;

namespace MvvmCross.Plugins.WebBrowser.iOS
{
    [Preserve(AllMembers = true)]
	public class MvxWebBrowserTask : MvxIosTask, IMvxWebBrowserTask
    {
        public void ShowWebPage(string url)
        {
            var nsurl = new NSUrl(url);
            DoUrlOpen(nsurl);
        }
    }
}