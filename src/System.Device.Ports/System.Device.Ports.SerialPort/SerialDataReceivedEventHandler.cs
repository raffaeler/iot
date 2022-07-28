﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Device.Ports.SerialPort
{
    /// <summary>
    /// Represents the method that will handle the DataReceived event of a SerialPort object.
    /// </summary>
    /// <param name="sender">The sender of the event, which is the SerialPort object.</param>
    /// <param name="e">A SerialDataReceivedEventArgs object that contains the event data.</param>
    public delegate void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e);
}