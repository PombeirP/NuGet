﻿using System;
using System.Linq;

namespace NuGet.Dialog.Providers {
    internal static class PackageExtensions {

        public static bool HasPowerShellScript(this IPackage package) {
            return package.HasPowerShellScript(new string[] { "init.ps1", "install.ps1", "uninstall.ps1" });
        }

        public static bool HasPowerShellScript(this IPackage package, string[] names) {
            return package.GetFiles().Any(file => names.Any(name => file.Path.EndsWith(name, StringComparison.OrdinalIgnoreCase)));
        }
    }
}