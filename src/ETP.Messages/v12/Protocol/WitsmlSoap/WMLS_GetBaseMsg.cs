// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.WitsmlSoap
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class WMLS_GetBaseMsg : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""WMLS_GetBaseMsg"",""namespace"":""Energistics.Etp.v12.Protocol.WitsmlSoap"",""fields"":[{""name"":""ReturnValueIn"",""type"":""int""}],""protocol"":""8"",""messageType"":""5"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.WitsmlSoap.WMLS_GetBaseMsg"",""depends"":[]}");
		private int _ReturnValueIn;
		public virtual Schema Schema
		{
			get
			{
				return WMLS_GetBaseMsg._SCHEMA;
			}
		}
		public int ReturnValueIn
		{
			get
			{
				return this._ReturnValueIn;
			}
			set
			{
				this._ReturnValueIn = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._ReturnValueIn;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._ReturnValueIn = (System.Int32)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
