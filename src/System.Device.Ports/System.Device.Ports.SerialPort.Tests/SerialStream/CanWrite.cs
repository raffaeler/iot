﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.IO;
using System.IO.PortsTests;
using Legacy.Support;
using Xunit;

namespace System.Device.Ports.SerialPort.Tests
{
    public class SerialStream_CanWrite : PortsTest
    {
        #region Test Cases

        // [ConditionalFact(nameof(HasOneSerialPort))]
        public void CanWrite_Open_Close()
        {
            using (SerialPort com = new SerialPort(TCSupport.LocalMachineSerialInfo.FirstAvailablePortName))
            {
                com.Open();
                Stream serialStream = com.BaseStream;
                com.Close();

                Debug.WriteLine("Verifying CanWrite property throws exception After Open() then Close()");

                Assert.False(serialStream.CanWrite);
            }
        }

        // [ConditionalFact(nameof(HasOneSerialPort))]
        public void CanWrite_Open_BaseStreamClose()
        {
            using (SerialPort com = new SerialPort(TCSupport.LocalMachineSerialInfo.FirstAvailablePortName))
            {
                com.Open();
                Stream serialStream = com.BaseStream;
                com.BaseStream.Close();

                Debug.WriteLine("Verifying CanWrite property throws exception After Open() then BaseStream.Close()");

                Assert.False(serialStream.CanWrite);
            }
        }

        // [ConditionalFact(nameof(HasOneSerialPort))]
        public void CanWrite_AfterOpen()
        {
            using (SerialPort com = new SerialPort(TCSupport.LocalMachineSerialInfo.FirstAvailablePortName))
            {
                com.Open();

                Debug.WriteLine("Verifying CanWrite property returns true after a call to Open()");

                Assert.True(com.BaseStream.CanWrite);
            }
        }
        #endregion

        #region Verification for Test Cases

        #endregion
    }
}
