﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Device.Ports.SerialPort
{
    internal static class LinuxErrors
    {
        public const int EPERM = 1;             // Operation not permitted
        public const int ENOENT = 2;            // No such file or directory
        public const int ESRCH = 3;             // No such process
        public const int EINTR = 4;             // Interrupted system call
        public const int EIO = 5;               // Input/output error
        public const int ENXIO = 6;             // No such device or address
        public const int E2BIG = 7;             // Argument list too long
        public const int ENOEXEC = 8;           // Exec format error
        public const int EBADF = 9;             // Bad file descriptor
        public const int ECHILD = 10;           // No child processes
                                                // public const int EWOULDBLOCK = 11;   // Resource temporarily unavailable
        public const int EAGAIN = 11;           // Resource temporarily unavailable
        public const int ENOMEM = 12;           // Cannot allocate memory
        public const int EACCES = 13;           // Permission denied
        public const int EFAULT = 14;           // Bad address
        public const int ENOTBLK = 15;          // Block device required
        public const int EBUSY = 16;            // Device or resource busy
        public const int EEXIST = 17;           // File exists
        public const int EXDEV = 18;            // Invalid cross-device link
        public const int ENODEV = 19;           // No such device
        public const int ENOTDIR = 20;          // Not a directory
        public const int EISDIR = 21;           // Is a directory
        public const int EINVAL = 22;           // Invalid argument
        public const int ENFILE = 23;           // Too many open files in system
        public const int EMFILE = 24;           // Too many open files
        public const int ENOTTY = 25;           // Inappropriate ioctl for device
        public const int ETXTBSY = 26;          // Text file busy
        public const int EFBIG = 27;            // File too large
        public const int ENOSPC = 28;           // No space left on device
        public const int ESPIPE = 29;           // Illegal seek
        public const int EROFS = 30;            // Read-only file system
        public const int EMLINK = 31;           // Too many links
        public const int EPIPE = 32;            // Broken pipe
        public const int EDOM = 33;             // Numerical argument out of domain
        public const int ERANGE = 34;           // Numerical result out of range
                                                // public const int EDEADLOCK = 35;     // Resource deadlock avoided
        public const int EDEADLK = 35;          // Resource deadlock avoided
        public const int ENAMETOOLONG = 36;     // File name too long
        public const int ENOLCK = 37;           // No locks available
        public const int ENOSYS = 38;           // Function not implemented
        public const int ENOTEMPTY = 39;        // Directory not empty
        public const int ELOOP = 40;            // Too many levels of symbolic links
        public const int ENOMSG = 42;           // No message of desired type
        public const int EIDRM = 43;            // Identifier removed
        public const int ECHRNG = 44;           // Channel number out of range
        public const int EL2NSYNC = 45;         // Level 2 not synchronized
        public const int EL3HLT = 46;           // Level 3 halted
        public const int EL3RST = 47;           // Level 3 reset
        public const int ELNRNG = 48;           // Link number out of range
        public const int EUNATCH = 49;          // Protocol driver not attached
        public const int ENOCSI = 50;           // No CSI structure available
        public const int EL2HLT = 51;           // Level 2 halted
        public const int EBADE = 52;            // Invalid exchange
        public const int EBADR = 53;            // Invalid request descriptor
        public const int EXFULL = 54;           // Exchange full
        public const int ENOANO = 55;           // No anode
        public const int EBADRQC = 56;          // Invalid request code
        public const int EBADSLT = 57;          // Invalid slot
        public const int EBFONT = 59;           // Bad font file format
        public const int ENOSTR = 60;           // Device not a stream
        public const int ENODATA = 61;          // No data available
        public const int ETIME = 62;            // Timer expired
        public const int ENOSR = 63;            // Out of streams resources
        public const int ENONET = 64;           // Machine is not on the network
        public const int ENOPKG = 65;           // Package not installed
        public const int EREMOTE = 66;          // Object is remote
        public const int ENOLINK = 67;          // Link has been severed
        public const int EADV = 68;             // Advertise error
        public const int ESRMNT = 69;           // Srmount error
        public const int ECOMM = 70;            // Communication error on send
        public const int EPROTO = 71;           // Protocol error
        public const int EMULTIHOP = 72;        // Multihop attempted
        public const int EDOTDOT = 73;          // RFS specific error
        public const int EBADMSG = 74;          // Bad message
        public const int EOVERFLOW = 75;        // Value too large for defined data type
        public const int ENOTUNIQ = 76;         // Name not unique on network
        public const int EBADFD = 77;           // File descriptor in bad state
        public const int EREMCHG = 78;          // Remote address changed
        public const int ELIBACC = 79;          // Can not access a needed shared library
        public const int ELIBBAD = 80;          // Accessing a corrupted shared library
        public const int ELIBSCN = 81;          // .lib section in a.out corrupted
        public const int ELIBMAX = 82;          // Attempting to link in too many shared libraries
        public const int ELIBEXEC = 83;         // Cannot exec a shared library directly
        public const int EILSEQ = 84;           // Invalid or incomplete multibyte or wide character
        public const int ERESTART = 85;         // Interrupted system call should be restarted
        public const int ESTRPIPE = 86;         // Streams pipe error
        public const int EUSERS = 87;           // Too many users
        public const int ENOTSOCK = 88;         // Socket operation on non-socket
        public const int EDESTADDRREQ = 89;     // Destination address required
        public const int EMSGSIZE = 90;         // Message too long
        public const int EPROTOTYPE = 91;       // Protocol wrong type for socket
        public const int ENOPROTOOPT = 92;      // Protocol not available
        public const int EPROTONOSUPPORT = 93;  // Protocol not supported
        public const int ESOCKTNOSUPPORT = 94;  // Socket type not supported
                                                // public const int ENOTSUP = 95;       // Operation not supported
        public const int EOPNOTSUPP = 95;       // Operation not supported
        public const int EPFNOSUPPORT = 96;     // Protocol family not supported
        public const int EAFNOSUPPORT = 97;     // Address family not supported by protocol
        public const int EADDRINUSE = 98;       // Address already in use
        public const int EADDRNOTAVAIL = 99;    // Cannot assign requested address
        public const int ENETDOWN = 100;        // Network is down
        public const int ENETUNREACH = 101;     // Network is unreachable
        public const int ENETRESET = 102;       // Network dropped connection on reset
        public const int ECONNABORTED = 103;    // Software caused connection abort
        public const int ECONNRESET = 104;      // Connection reset by peer
        public const int ENOBUFS = 105;         // No buffer space available
        public const int EISCONN = 106;         // Transport endpoint is already connected
        public const int ENOTCONN = 107;        // Transport endpoint is not connected
        public const int ESHUTDOWN = 108;       // Cannot send after transport endpoint shutdown
        public const int ETOOMANYREFS = 109;    // Too many references: cannot splice
        public const int ETIMEDOUT = 110;       // Connection timed out
        public const int ECONNREFUSED = 111;    // Connection refused
        public const int EHOSTDOWN = 112;       // Host is down
        public const int EHOSTUNREACH = 113;    // No route to host
        public const int EALREADY = 114;        // Operation already in progress
        public const int EINPROGRESS = 115;     // Operation now in progress
        public const int ESTALE = 116;          // Stale file handle
        public const int EUCLEAN = 117;         // Structure needs cleaning
        public const int ENOTNAM = 118;         // Not a XENIX named type file
        public const int ENAVAIL = 119;         // No XENIX semaphores available
        public const int EISNAM = 120;          // Is a named type file
        public const int EREMOTEIO = 121;       // Remote I/O error
        public const int EDQUOT = 122;          // Disk quota exceeded
        public const int ENOMEDIUM = 123;       // No medium found
        public const int EMEDIUMTYPE = 124;     // Wrong medium type
        public const int ECANCELED = 125;       // Operation canceled
        public const int ENOKEY = 126;          // Required key not available
        public const int EKEYEXPIRED = 127;     // Key has expired
        public const int EKEYREVOKED = 128;     // Key has been revoked
        public const int EKEYREJECTED = 129;    // Key was rejected by service
        public const int EOWNERDEAD = 130;      // Owner died
        public const int ENOTRECOVERABLE = 131; // State not recoverable
        public const int ERFKILL = 132;         // Operation not possible due to RF-kill
        public const int EHWPOISON = 133;       // Memory page has hardware error

        public static string GetLastErrorDescription()
            => GetErrorDescription(Marshal.GetLastWin32Error());

        public static string GetErrorDescription(int errno)
        {
            return errno switch
            {
                EPERM => "Operation not permitted",
                ENOENT => "No such file or directory",
                ESRCH => "No such process",
                EINTR => "Interrupted system call",
                EIO => "Input/output error",
                ENXIO => "No such device or address",
                E2BIG => "Argument list too long",
                ENOEXEC => "Exec format error",
                EBADF => "Bad file descriptor",
                ECHILD => "No child processes",
                EAGAIN => "Resource temporarily unavailable",
                ENOMEM => "Cannot allocate memory",
                EACCES => "Permission denied",
                EFAULT => "Bad address",
                ENOTBLK => "Block device required",
                EBUSY => "Device or resource busy",
                EEXIST => "File exists",
                EXDEV => "Invalid cross-device link",
                ENODEV => "No such device",
                ENOTDIR => "Not a directory",
                EISDIR => "Is a directory",
                EINVAL => "Invalid argument",
                ENFILE => "Too many open files in system",
                EMFILE => "Too many open files",
                ENOTTY => "Inappropriate ioctl for device",
                ETXTBSY => "Text file busy",
                EFBIG => "File too large",
                ENOSPC => "No space left on device",
                ESPIPE => "Illegal seek",
                EROFS => "Read-only file system",
                EMLINK => "Too many links",
                EPIPE => "Broken pipe",
                EDOM => "Numerical argument out of domain",
                ERANGE => "Numerical result out of range",
                EDEADLK => "Resource deadlock avoided",
                ENAMETOOLONG => "File name too long",
                ENOLCK => "No locks available",
                ENOSYS => "Function not implemented",
                ENOTEMPTY => "Directory not empty",
                ELOOP => "Too many levels of symbolic links",
                ENOMSG => "No message of desired type",
                EIDRM => "Identifier removed",
                ECHRNG => "Channel number out of range",
                EL2NSYNC => "Level 2 not synchronized",
                EL3HLT => "Level 3 halted",
                EL3RST => "Level 3 reset",
                ELNRNG => "Link number out of range",
                EUNATCH => "Protocol driver not attached",
                ENOCSI => "No CSI structure available",
                EL2HLT => "Level 2 halted",
                EBADE => "Invalid exchange",
                EBADR => "Invalid request descriptor",
                EXFULL => "Exchange full",
                ENOANO => "No anode",
                EBADRQC => "Invalid request    ",
                EBADSLT => "Invalid slot",
                EBFONT => "Bad font file format",
                ENOSTR => "Device not a stream",
                ENODATA => "No data available",
                ETIME => "Timer expired",
                ENOSR => "Out of streams resources",
                ENONET => "Machine is not on the network",
                ENOPKG => "Package not installed",
                EREMOTE => "Object is remote",
                ENOLINK => "Link has been severed",
                EADV => "Advertise error",
                ESRMNT => "Srmount error",
                ECOMM => "Communication error on send",
                EPROTO => "Protocol error",
                EMULTIHOP => "Multihop attempted",
                EDOTDOT => "RFS specific error",
                EBADMSG => "Bad message",
                EOVERFLOW => "Value too large for defined data type",
                ENOTUNIQ => "Name not unique on network",
                EBADFD => "File descriptor in bad state",
                EREMCHG => "Remote address changed ",
                ELIBACC => "Can not access a needed shared library",
                ELIBBAD => "Accessing a corrupted shared library",
                ELIBSCN => ".lib section in a.out corrupted",
                ELIBMAX => "Attempting to link in too many shared libraries",
                ELIBEXEC => "Cannot exec a shared library directly",
                EILSEQ => "Invalid or incomplete multibyte or wide character",
                ERESTART => "Interrupted system call should be restarted",
                ESTRPIPE => "Streams pipe error",
                EUSERS => "Too many users",
                ENOTSOCK => "Socket operation on non-socket",
                EDESTADDRREQ => "Destination address required",
                EMSGSIZE => "Message too long",
                EPROTOTYPE => "Protocol wrong type for socket",
                ENOPROTOOPT => "Protocol not available",
                EPROTONOSUPPORT => "Protocol not supported",
                ESOCKTNOSUPPORT => "Socket type not supported",
                EOPNOTSUPP => "Operation not supported",
                EPFNOSUPPORT => "Protocol family not supported",
                EAFNOSUPPORT => "Address family not supported by protocol",
                EADDRINUSE => "Address already in use",
                EADDRNOTAVAIL => "Cannot assign requested address",
                ENETDOWN => "Network is down",
                ENETUNREACH => "Network is unreachable ",
                ENETRESET => "Network dropped connection on reset",
                ECONNABORTED => "Software caused connection abort",
                ECONNRESET => "Connection reset by peer",
                ENOBUFS => "No buffer space available",
                EISCONN => "Transport endpoint is already connected",
                ENOTCONN => "Transport endpoint is not connected",
                ESHUTDOWN => "Cannot send after transport endpoint shutdown",
                ETOOMANYREFS => "Too many references: cannot splice",
                ETIMEDOUT => "Connection timed out",
                ECONNREFUSED => "Connection refused",
                EHOSTDOWN => "Host is down",
                EHOSTUNREACH => "No route to host",
                EALREADY => "Operation already in progress",
                EINPROGRESS => "Operation now in progress",
                ESTALE => "Stale file handle",
                EUCLEAN => "Structure needs cleaning",
                ENOTNAM => "Not a XENIX named type file",
                ENAVAIL => "No XENIX semaphores available",
                EISNAM => "Is a named type file",
                EREMOTEIO => "Remote I/O error",
                EDQUOT => "Disk quota exceeded",
                ENOMEDIUM => "No medium found",
                EMEDIUMTYPE => "Wrong medium type",
                ECANCELED => "Operation canceled",
                ENOKEY => "Required key not available",
                EKEYEXPIRED => "Key has expired",
                EKEYREVOKED => "Key has been revoked",
                EKEYREJECTED => "Key was rejected by service",
                EOWNERDEAD => "Owner died",
                ENOTRECOVERABLE => "State not recoverable",
                ERFKILL => "Operation not possible due to RF-kill",
                EHWPOISON => "Memory page has hardware error",

                _ => "(no description)",
            };
        }

        public static bool IsError(int errno) => errno != 0;

    }
}
