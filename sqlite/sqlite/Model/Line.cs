using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqliteDemo.Model
{
    public class LINE : IComparable<LINE>
    {
        public LINE()
        {
            Dial = new char[10];
        }
        /// <summary>
        /// 通道类型
        /// </summary>
        public int iType
        {
            get;
            set;
        }

        public string TypeName
        {
            get;
            set;
        }


        /// <summary>
        /// 来电号码
        /// </summary>
        public string CallerID
        {
            get;
            set;
        }

        /// <summary>
        /// dtmf按键
        /// </summary>
        public string Dtmf
        {
            get;
            set;
        }

        /// <summary>
        /// 摘机标志
        /// </summary>
        public int HookOff
        {
            get;
            set;
        }

        /// <summary>
        /// 振铃标志
        /// </summary>
        public int Ring
        {
            get;
            set;
        }

        /// <summary>
        /// 判断未接来电的时间计数，一般有振铃时超过5秒还没有摘机说明是未接来电。
        /// </summary>
        public int TimeCount
        {
            get;
            set;
        }

        /// <summary>
        ///  存储channel no, 与i相同
        /// </summary>
        public ushort channelNo { get; set; }

        /// <summary>
        ///  拍叉簧转接内线时保存转接内线的channel no
        /// </summary>
        public ushort UserChannelNo { get; set; }

        /// <summary>
        ///  座席号
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        ///  座席号(显示)
        /// </summary>
        public string AgentName { get; set; }

        public int Len { get; set; }


        public char[] Dial;

        public int number { get; set; }

        /// <summary>
        /// 1为座席间呼叫 2.为外呼 3.为外呼后客户已接听 4.来电时内线转接 5.转接时原内线标识 6.转接时转接的内线标识
        /// </summary>
        public int CallByAgent { get; set; }

        public string MainUniqueId { get; set; }

        public int ReceivedCount { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool DialOutFg { get; set; }

        private bool _channelEnabled = true;
        public bool ChannelEnabled
        {
            get
            {
                return _channelEnabled;
            }
            set
            {
                _channelEnabled = value;
            }
        }

        public int CompareTo(LINE other)
        {
            return this.ReceivedCount.CompareTo(other.ReceivedCount);
        }
    }

}
