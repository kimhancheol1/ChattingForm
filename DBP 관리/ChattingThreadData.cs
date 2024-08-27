using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_관리
{
    internal class ChattingThreadData
    {
        public static int chattingRoomCnt = 0;
        public Thread chattingThread;
        public Form_ChattingRoom chattingWindow;
        public int chattingRoomNum;
        private static object obj = new object();

        public ChattingThreadData(Thread chattingThread, Form_ChattingRoom chattingWindow)
        {
            lock (obj)
            {
                this.chattingThread = chattingThread;
                this.chattingWindow = chattingWindow;
                this.chattingRoomNum = ++chattingRoomCnt;
            }
        }
    }
}
