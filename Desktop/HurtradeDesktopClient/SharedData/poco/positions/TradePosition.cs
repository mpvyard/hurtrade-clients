﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedData.poco.positions
{
    public class TradePosition
    {
        public static string ORDER_TYPE_BUY = "b";
        public static string ORDER_TYPE_SELL = "s";
    
        public static string ORDER_STATE_PENDING_OPEN = "pending_dealer_open";
        public static string ORDER_STATE_OPEN = "open";
        public static string ORDER_STATE_PENDING_CLOSE = "pending_dealer_close";
        public static string ORDER_STATE_CLOSED = "closed";

        //is this buy or sell?
        private string orderType;
        //what commodity are we trading?
        private string commodity;
        //how much are we trading, can change in cases of hedge so not final
        private decimal amount;
        //p/l of this position
        private decimal currentPl;
        //a unique identifier for this order
        private Guid orderId;
        //the price at which the commodity was requested
        private decimal openPrice;
        //the price at which the commodity was requested close or was closed
        private decimal closePrice;
        //what state the order currently is in
        private string orderState;
        //locally populated
        private string clientName;

        //timestamps
        private DateTime createdat;
        private DateTime endedat;
        private DateTime closedat;
        private DateTime approvedopenat;
        private DateTime approvedcloseat;


        public string OrderType { get => orderType; set => orderType = value; }
        public string Commodity { get => commodity; set => commodity = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public decimal CurrentPl { get => currentPl; set => currentPl = value; }
        public Guid OrderId { get => orderId; set => orderId = value; }
        public decimal OpenPrice { get => openPrice; set => openPrice = value; }
        public string OrderState { get => orderState; set => orderState = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public DateTime Createdat { get => createdat; set => createdat = value; }
        public DateTime Endedat { get => endedat; set => endedat = value; }
        public DateTime Closedat { get => closedat; set => closedat = value; }
        public DateTime Approvedopenat { get => approvedopenat; set => approvedopenat = value; }
        public DateTime Approvedcloseat { get => approvedcloseat; set => approvedcloseat = value; }
        public decimal ClosePrice { get => closePrice; set => closePrice = value; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            TradePosition p = obj as TradePosition;
            if (p == null)
            {
                return false;
            }

            return p.OrderId.Equals(OrderId);
        }

        public bool Equals(TradePosition p)
        {
            if (p == null)
            {
                return false;
            }

            return p.OrderId.Equals(OrderId);
        }

        public override int GetHashCode()
        {
            return OrderId.GetHashCode();
        }
    }
}