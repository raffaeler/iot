// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

// Disable these StyleCop rules for this file, as we are using native names here.
#pragma warning disable SA1300 // Element should begin with upper-case letter
#pragma warning disable SA1307 // Field should begin with upper-case letter
#pragma warning disable CS1591

using System.Runtime.InteropServices;

partial class Interop
{
    /// <summary>
    /// This class is used to dynamically switch between the
    /// direct calls to the V4L2 driver (through libc iotctls and other functions)
    /// or passing by the libcamera interoperability layer functions
    /// that have the same functions with the same signature
    /// </summary>
    internal class V4L2Helper
    {
        public static int ioctl(bool useCompatibilityLayer, int fd, int request, IntPtr argp)
        {
            if (useCompatibilityLayer)
            {
                return Interop.V4L2Compat.ioctl(fd, request, argp);
            }

            return Interop.ioctl(fd, request, argp);
        }

        public static int open(bool useCompatibilityLayer, [MarshalAs(UnmanagedType.LPStr)] string pathname, FileOpenFlags flags)
        {
            if (useCompatibilityLayer)
            {
                return Interop.V4L2Compat.open(pathname, flags);
            }

            return Interop.open(pathname, flags);
        }

        public static int close(bool useCompatibilityLayer, int fd)
        {
            if (useCompatibilityLayer)
            {
                return Interop.V4L2Compat.close(fd);
            }

            return Interop.close(fd);
        }

        public static IntPtr mmap(bool useCompatibilityLayer, IntPtr addr, int length, MemoryMappedProtections prot, MemoryMappedFlags flags, int fd, int offset)
        {
            if (useCompatibilityLayer)
            {
                return Interop.V4L2Compat.mmap(addr, length, prot, flags, fd, offset);
            }

            return Interop.mmap(addr, length, prot, flags, fd, offset);
        }

        public static int munmap(bool useCompatibilityLayer, IntPtr addr, int length)
        {
            if (useCompatibilityLayer)
            {
                return Interop.V4L2Compat.munmap(addr, length);
            }

            return Interop.munmap(addr, length);
        }
    }
}
