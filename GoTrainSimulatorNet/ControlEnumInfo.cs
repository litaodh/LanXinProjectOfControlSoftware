﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

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
        [Description("线阵相机")]     
        Linea,
        [Description("面阵相机")]
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

        public static List<string> GetSerieNames()
        {
            FieldInfo[] serieInfos = typeof(CameraSerie).GetFields(BindingFlags.Static | BindingFlags.Public);
            List<string> names = new List<string>();
            foreach(var info in serieInfos)
            {
                names.Add(info.GetRawConstantValue().ToString());
            }

            return names;
        }
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
    /// <summary>
    /// 行车方向
    /// </summary>
    public enum GoTrainDirection
    {
        Left,
        Right,
        HasNo
    }
    /// <summary>
    /// 磁钢端
    /// </summary>
    public enum MagneticSteelEnd
    {
        Near,
        Far
    }
    /// <summary>
    /// 设备端
    /// </summary>
    public enum DeviceEnd
    {       
        Left,       
        Right
    }

    public class Tools
    {
        public static string GetEnumDesc(Enum e)
        {
            FieldInfo enumInfo = e.GetType().GetField(e.ToString());
            DescriptionAttribute[] EnumAtrributes = (DescriptionAttribute[])enumInfo.
                GetCustomAttributes(typeof(DescriptionAttribute), false);

            if(EnumAtrributes.Length>0)
            {
                return EnumAtrributes[0].Description;
            }

            return e.ToString();
        }
    }
}
