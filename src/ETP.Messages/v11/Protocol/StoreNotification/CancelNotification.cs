// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.StoreNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class CancelNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""CancelNotification"",""namespace"":""Energistics.Protocol.StoreNotification"",""fields"":[{""name"":""requestUuid"",""type"":""string""}],""messageType"":""4"",""protocol"":""5"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Protocol.StoreNotification.CancelNotification"",""depends"":[]}");
		private string _requestUuid;
		public virtual Schema Schema
		{
			get
			{
				return CancelNotification._SCHEMA;
			}
		}
		public string RequestUuid
		{
			get
			{
				return this._requestUuid;
			}
			set
			{
				this._requestUuid = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._requestUuid;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._requestUuid = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
