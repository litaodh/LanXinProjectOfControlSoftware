using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries
{
    public enum SignalType
    {
        CameraSignal,
        CaissonSignal,
        MagneticSteelSignal,
        LEDSignal
    }

    public enum CameraType
    {
        Linear,
        Area
    }

    public enum TransmissionMode
    {
        Net,
        SerialPort,
        SDK
    }

    public class CameraSerie
    {
        public const string DALSALinea2K = "DALSALinea2K";
        public const string DALSALinea4K = "DALSALinea4K";
        public const string DALSANano = "DALSANano";
    }
    /// <summary>
    /// 
    /// </summary>
    public enum EnableType
    {
        FLASH,
        RAM
    }
    /// <summary>
    /// TTL板卡回复STATE位定义
    /// </summary>
    public enum TTLSignalBoardCommandState
    {
        //接收到的命令正常     
        UART_OK_REC = 0x00, 
        //接收到的命令头错误，即开始标志错误  
        UART_ERR_REC_HEAD = 0x80,
        //接收到的命令校验错误
        UART_ERR_REC_CHECK=0x81,
        //接收到的命令超出范围
        UART_ERR_CMD_OUT=0x82,
        //FLASH操作错误
        EEPROM_ERR_WROVERT=0x83,
        //未知
        UNKNOWN= 0xFF
    }
}
