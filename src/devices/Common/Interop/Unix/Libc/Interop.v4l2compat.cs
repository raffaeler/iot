// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Disable these StyleCop rules for this file, as we are using native names here.
#pragma warning disable SA1300 // Element should begin with upper-case letter
#pragma warning disable CS1591 // Public member is not documented - These members are not public in the final package

using System;
using System.Runtime.InteropServices;

partial class Interop
{
    partial class V4L2Compat
    {
        [DllImport(V4L2CompatLibrary, SetLastError = true)]
        public static extern int ioctl(int fd, int request, IntPtr argp);

        [DllImport(V4L2CompatLibrary, SetLastError = true)]
        public static extern int open([MarshalAs(UnmanagedType.LPStr)] string pathname, FileOpenFlags flags);

        [DllImport(V4L2CompatLibrary)]
        public static extern int close(int fd);

        [DllImport(V4L2CompatLibrary, SetLastError = true)]
        public static extern IntPtr mmap(IntPtr addr, int length, MemoryMappedProtections prot, MemoryMappedFlags flags, int fd, int offset);

        [DllImport(V4L2CompatLibrary)]
        public static extern int munmap(IntPtr addr, int length);
    }
}
