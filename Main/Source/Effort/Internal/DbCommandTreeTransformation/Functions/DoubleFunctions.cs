﻿// --------------------------------------------------------------------------------------------
// <copyright file="DoubleFunctions.cs" company="Effort Team">
//     Copyright (C) Effort Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------

namespace Effort.Internal.DbCommandTreeTransformation.Functions
{
    using System;
    using System.Reflection;
    using Effort.Internal.Common;

    internal class DoubleFunctions
    {
        public static readonly MethodInfo Truncate =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Truncate(0.0));

        public static readonly MethodInfo Ceiling =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Ceiling(0.0));

        public static readonly MethodInfo Floor =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Floor(0.0));

        public static readonly MethodInfo Round =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Round(0.0));

        public static readonly MethodInfo RoundDigits =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Round(0.0, 0));

        public static readonly MethodInfo Pow =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Pow(0.0, 0.0));

        public static readonly MethodInfo Abs =
            ReflectionHelper.GetMethodInfo(() => DbFunctions.Abs(0.0));
    }
}
