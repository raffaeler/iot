﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Device.Ports.SerialPort.Linux;

namespace System.Device.Ports.SerialPort
{
    internal partial class LinuxSerialPort : SerialPort
    {
        private const string DefaultPortName = "/dev/ttyUSB0";
        private TermiosIo _tio;

        public LinuxSerialPort()
        {
            PortName = DefaultPortName;
            _tio = new();
            _tio.CanonicalMode = false;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected void SaveParameters()
        {
            _tio.TcSetAttr(LinuxConstants.TCSANOW);
        }

        protected internal override void OpenPort()
        {
            _tio.TcGetAttr();   // read the current values of the port after opening it
            throw new NotImplementedException();
        }

        protected internal override void ClosePort(bool disposing)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetBaudRate(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            var speed = _tio.GetStandardSpeed(value);
            if (speed == 0)
            {
                speed = (uint)value;
            }

            try
            {
                _tio.CfSetISpeed(speed);
                _tio.CfSetOSpeed(speed);
                return;
            }
            catch (Exception)
            {
                // when the speed cannot be sent using the standard API
                // we can just go on and try setting it via ioctl
            }

            // This will write the termios structure to the driver using ioctl
            _tio.CustomBaudRate = speed;
        }

        protected internal override void SetParity(Parity value)
        {
            _tio.Parity = value;
        }

        protected internal override void SetDataBits(int value)
        {
            _tio.DataBits = value;
        }

        protected internal override void SetStopBits(StopBits value)
        {
            switch (value)
            {
                case StopBits.One:
                    _tio.StopBits = 1;
                    break;

                case StopBits.Two:
                    _tio.StopBits = 2;
                    break;

                case StopBits.None:
                case StopBits.OnePointFive:
                default:
                    throw new NotSupportedException($"Stop bits {value} is not supported on this platform");
            }
        }

        protected internal override void SetBreakState(bool value)
        {
            // there is no "stop the break" in Linux
            if (value)
            {
                // 0 means default which is 250ms
                // https://github.com/torvalds/linux/blob/62bad54b26db8bc98e28749cd76b2d890edb4258/drivers/tty/tty_io.c#L2744
                _tio.TcSendBreak(0);
            }
        }

        protected internal override int GetBytesToRead()
        {
            return (int)_tio.AvailableBytes;
        }

        protected internal override int GetBytesToWrite()
        {
            return (int)_tio.OutputBufferBytes;
        }

        protected internal override bool GetCDHolding()
        {
            return _tio.SignalCD;
        }

        protected internal override bool GetCtsHolding()
        {
            return _tio.SignalCTS;
        }

        protected internal override void SetDiscardNull(bool value)
        {
            throw new NotImplementedException();
        }

        protected internal override bool GetDsrHolding()
        {
            return _tio.SignalDSR;
        }

        protected internal override bool GetDtrEnable()
        {
            return _tio.SignalDTR;
        }

        protected internal override void SetDtrEnable(bool value)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetHandshake(Handshake value)
        {
            _tio.Handshake = value;
        }

        protected internal override void SetParityReplace(byte value)
        {
            throw new NotImplementedException();
        }

        // TODO: get?
        protected internal override void SetReadTimeout(int value)
        {
            if (value == 0)
            {
                _tio.VTime = 0;
                _tio.VMin = 0;
                return;
            }

            if (value == SerialPort.InfiniteTimeout)
            {
                _tio.VTime = 0;     // blocking read
                _tio.VMin = 255;    // number of bytes to read before returning
                return;
            }

            _tio.VTime = (byte)(value * 10);
            _tio.VMin = 0;
        }

        protected internal override bool GetRtsEnable()
        {
            return _tio.SignalRTS;
        }

        protected internal override void SetRtsEnable(bool value, bool setField)
        {
            throw new NotImplementedException();
        }

        protected internal override void SetWriteTimeout(int value)
        {
            throw new NotImplementedException();
        }

        public override void DiscardInBuffer()
        {
            _tio.TcFlush(LinuxConstants.TCIFLUSH);
        }

        public override void DiscardOutBuffer()
        {
            _tio.TcFlush(LinuxConstants.TCOFLUSH);
        }

        protected internal override void InitializeBuffers(int readBufferSize, int writeBufferSize)
        {
            throw new NotImplementedException();
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }
    }
}
