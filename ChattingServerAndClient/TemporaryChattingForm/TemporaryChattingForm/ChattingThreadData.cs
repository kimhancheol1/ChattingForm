using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryChattingForm
{
    internal class ChattingThreadData
    {
        public static int chattingRoomCnt = 0;
        public Thread chattingThread;
        public ChattingForm chattingWindow;
        public int chattingRoomNum;
        private static object obj = new object();

        public ChattingThreadData(Thread chattingThread, ChattingForm chattingWindow)
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
