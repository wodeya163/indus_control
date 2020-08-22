using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ModbusDAL
{
    public class Modbus
    {
        private SerialPort MySeialPort;
        private int BandRate;
        private string PortNumber;
        private int DataBits;
        private Parity ParityBit;
        private StopBits StopBit;

        public Modbus()
        {
            MySeialPort = new SerialPort();
        }
         

    }

}
