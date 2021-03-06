/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace BankService.Interfaces
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Account : TBase
  {

    public long AccountNumber { get; set; }

    public long Balance { get; set; }

    public long CreditAmount { get; set; }

    public string ProductName { get; set; }

    public string AccountOpened { get; set; }

    public bool Active { get; set; }

    public string CurrencyCode { get; set; }

    public int InterestRate { get; set; }

    public int AccumulatedInterest { get; set; }

    public Account() {
    }

    public Account(long accountNumber, long balance, long creditAmount, string productName, string accountOpened, bool active, string currencyCode, int interestRate, int accumulatedInterest) : this() {
      this.AccountNumber = accountNumber;
      this.Balance = balance;
      this.CreditAmount = creditAmount;
      this.ProductName = productName;
      this.AccountOpened = accountOpened;
      this.Active = active;
      this.CurrencyCode = currencyCode;
      this.InterestRate = interestRate;
      this.AccumulatedInterest = accumulatedInterest;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_accountNumber = false;
        bool isset_balance = false;
        bool isset_creditAmount = false;
        bool isset_productName = false;
        bool isset_accountOpened = false;
        bool isset_active = false;
        bool isset_currencyCode = false;
        bool isset_interestRate = false;
        bool isset_accumulatedInterest = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64) {
                AccountNumber = iprot.ReadI64();
                isset_accountNumber = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I64) {
                Balance = iprot.ReadI64();
                isset_balance = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I64) {
                CreditAmount = iprot.ReadI64();
                isset_creditAmount = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                ProductName = iprot.ReadString();
                isset_productName = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                AccountOpened = iprot.ReadString();
                isset_accountOpened = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Bool) {
                Active = iprot.ReadBool();
                isset_active = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                CurrencyCode = iprot.ReadString();
                isset_currencyCode = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I32) {
                InterestRate = iprot.ReadI32();
                isset_interestRate = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I32) {
                AccumulatedInterest = iprot.ReadI32();
                isset_accumulatedInterest = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_accountNumber)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_balance)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_creditAmount)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_productName)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_accountOpened)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_active)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_currencyCode)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_interestRate)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_accumulatedInterest)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("Account");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "accountNumber";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(AccountNumber);
        oprot.WriteFieldEnd();
        field.Name = "balance";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Balance);
        oprot.WriteFieldEnd();
        field.Name = "creditAmount";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(CreditAmount);
        oprot.WriteFieldEnd();
        field.Name = "productName";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ProductName);
        oprot.WriteFieldEnd();
        field.Name = "accountOpened";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AccountOpened);
        oprot.WriteFieldEnd();
        field.Name = "active";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Active);
        oprot.WriteFieldEnd();
        field.Name = "currencyCode";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CurrencyCode);
        oprot.WriteFieldEnd();
        field.Name = "interestRate";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InterestRate);
        oprot.WriteFieldEnd();
        field.Name = "accumulatedInterest";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AccumulatedInterest);
        oprot.WriteFieldEnd();
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Account(");
      __sb.Append(", AccountNumber: ");
      __sb.Append(AccountNumber);
      __sb.Append(", Balance: ");
      __sb.Append(Balance);
      __sb.Append(", CreditAmount: ");
      __sb.Append(CreditAmount);
      __sb.Append(", ProductName: ");
      __sb.Append(ProductName);
      __sb.Append(", AccountOpened: ");
      __sb.Append(AccountOpened);
      __sb.Append(", Active: ");
      __sb.Append(Active);
      __sb.Append(", CurrencyCode: ");
      __sb.Append(CurrencyCode);
      __sb.Append(", InterestRate: ");
      __sb.Append(InterestRate);
      __sb.Append(", AccumulatedInterest: ");
      __sb.Append(AccumulatedInterest);
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
