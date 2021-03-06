using Android.App;
using Android.Runtime;
using Skobbler.SdkDemo.Model;
using System;
using System.Collections.Generic;

namespace Skobbler.SdkDemo.Application
{
    [Application]
    class DemoApplication : Android.App.Application
    {
        public DemoApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public string MapResourcesDirPath { get; set; }
        public Dictionary<string, DownloadPackage> PackageMap { get; set; }
        public string MapCreatorFilePath { get; set; }
    }
}