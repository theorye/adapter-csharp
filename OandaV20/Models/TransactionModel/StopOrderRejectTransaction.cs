﻿using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class StopOrderRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // STOP_ORDER_REJECT
        public InstrumentName Instrument;
        public double Units;
        public PriceValue Price;
        public PriceValue PriceBound;
        public TimeInForce TimeInForce; // GTC
        public DateTime GTDTime;
        public OrderPositionFill PositionFill; // DEFAULT
        public OrderTriggerCondition TriggerCondition; //DEFAULT
        public StopOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TakeProfitDetails TakeProfitOnFill;
        public StopLossDetails StopLossOnFill;
        public TrailingStopLossDetails TrailingStopLossOnFill;
        public ClientExtensions TradeClientExtensions;
        public OrderID IntendedReplacesOrderID;
        public TransactionRejectReason RejectReason;

        public StopOrderRejectTransaction ()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.STOP_ORDER_REJECT);
            this.Instrument = new InstrumentName();
            this.Price = new PriceValue();
            this.PriceBound = new PriceValue();
            this.TimeInForce = new TimeInForce();
            this.GTDTime = new DateTime();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new StopOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.TakeProfitOnFill = new TakeProfitDetails();
            this.StopLossOnFill = new StopLossDetails();
            this.TrailingStopLossOnFill = new TrailingStopLossDetails();
            this.TradeClientExtensions = new ClientExtensions();
            this.IntendedReplacesOrderID = new OrderID();
            this.RejectReason = new TransactionRejectReason();
        }

        public StopOrderRejectTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, InstrumentName instrument, double units, PriceValue price, PriceValue priceBound, TimeInForce timeInForce, DateTime gTDTime, OrderPositionFill positionFill, OrderTriggerCondition triggerCondition, StopOrderReason reason, ClientExtensions clientExtensions, TakeProfitDetails takeProfitOnFill, StopLossDetails stopLossOnFill, TrailingStopLossDetails trailingStopLossOnFill, ClientExtensions tradeClientExtensions, OrderID intededReplacesOrderID, TransactionRejectReason rejectReason)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.Price = price;
            this.PriceBound = priceBound;
            this.TimeInForce = timeInForce;
            this.GTDTime = gTDTime;
            this.PositionFill = positionFill;
            this.TriggerCondition = triggerCondition;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
            this.IntendedReplacesOrderID = intededReplacesOrderID;
            this.RejectReason = rejectReason;
        }
    }
}
