using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex3.lib;

namespace Ex3
{
    internal sealed class Utils
    {
        public static string TranslateOrderState(OrderState state)
        {
            string s = "";
            switch (state)
            {
                case OrderState.Unaurhorized: s = "未批准"; break;
                case OrderState.Unfinished: s = "未完成"; break;
                case OrderState.Finished: s = "已完成"; break;
            }
            return s;
        }

        public static string TranslateOrderState(int state)
        {
            switch (state)
            {
                case 0: return TranslateOrderState(OrderState.Unaurhorized);
                case 1: return TranslateOrderState(OrderState.Unfinished);
                case 2: return TranslateOrderState(OrderState.Finished);
            }

            throw new Exception("Coder's fault");
        }
    }
}