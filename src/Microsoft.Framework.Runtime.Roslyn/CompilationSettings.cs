// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;

namespace Microsoft.Framework.Runtime.Roslyn
{
    public class CompilationSettings
    {
        public IEnumerable<string> Defines { get; set; }
        public CSharpCompilationOptions CompilationOptions { get; set; }
    }
}
