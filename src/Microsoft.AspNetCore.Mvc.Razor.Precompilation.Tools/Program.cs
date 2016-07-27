﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Microsoft.AspNetCore.Mvc.Razor.Precompilation.Tools
{
    public class Program
    {
        public static int Main(string[] args)
        {
#if DEBUG
            DebugHelper.HandleDebugSwitch(ref args);
#endif

            var app = new PrecompilationApplication(typeof(Program));
            PrecompileCommandBase.Register<PrecompileDispatchCommand>(app);
            return app.Execute(args);
        }
    }
}
