﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Device.Ports.SerialPort
{
    internal class LinuxSerialPort : SerialPort
    {
        private const string DefaultPortName = "/dev/tty0";

        public LinuxSerialPort()
        {
            _portName = DefaultPortName;
        }

        protected internal override void SetBaudRate(int baudRate)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetParity(Parity parity)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetDataBits(int dataBits)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetStopBits(StopBits stopBits)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetBreakState(bool breakState)
        {
            throw new NotImplementedException();
        }

        protected internal override int GetBytesToRead()
        {
            throw new NotImplementedException();
        }

        protected internal override int GetBytesToWrite()
        {
            throw new NotImplementedException();
        }

        protected internal override int GetCDHolding()
        {
            throw new NotImplementedException();
        }

        protected internal override int GetCtsHolding()
        {
            throw new NotImplementedException();
        }

        protected internal override void SetDiscardNull(bool value)
        {
            throw new NotImplementedException();
        }

        protected internal override int GetDsrHolding()
        {
            throw new NotImplementedException();
        }

        protected internal override void SetDtrEnable(bool value)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetHandshake(Handshake handshake)
        {
            throw new NotImplementedException();
        }

        protected internal override byte SetParityReplace(byte parityReplace)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetReadTimeout(int timeout)
        {
            throw new NotImplementedException();
        }

        protected internal override bool GetRtsEnable()
        {
            throw new NotImplementedException();
        }

        protected internal override void SetRtsEnable(bool value, bool setField)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetWriteBufferSize(int writeBufferSize)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetWriteTimeout(int writeTimeout)
        {
            throw new NotImplementedException();
        }

        protected internal override void OpenPort()
        {
            throw new NotImplementedException();
        }

        protected internal override void ClosePort()
        {
            throw new NotImplementedException();
        }

        public override void DiscardInBuffer()
        {
            throw new NotImplementedException();
        }

        public override void DiscardOutBuffer()
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected internal override void InitializeBuffers(int readBufferSize, int writeBufferSize)
        {
            throw new NotImplementedException();
        }
    }
}
