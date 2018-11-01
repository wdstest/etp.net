// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.DirectedDiscovery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetResourcesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetResourcesResponse"",""namespace"":""Energistics.Etp.v12.Protocol.DirectedDiscovery"",""fields"":[{""name"":""resource"",""type"":{""type"":""record"",""name"":""GraphResource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""channelSubscribable"",""default"":false,""type"":""boolean""},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}},{""name"":""resourceType"",""type"":""string""},{""name"":""sourceCount"",""default"":-1,""type"":""int""},{""name"":""targetCount"",""default"":-1,""type"":""int""},{""name"":""contentCount"",""default"":-1,""type"":""int""},{""name"":""uuid"",""default"":"""",""type"":""string""},{""name"":""lastChanged"",""type"":""long""},{""name"":""objectNotifiable"",""default"":false,""type"":""boolean""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.GraphResource"",""depends"":[]}}],""protocol"":""30"",""messageType"":""2"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.DirectedDiscovery.GetResourcesResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.GraphResource""
]}");
		private Energistics.Etp.v12.Datatypes.Object.GraphResource _resource;
		public virtual Schema Schema
		{
			get
			{
				return GetResourcesResponse._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.GraphResource Resource
		{
			get
			{
				return this._resource;
			}
			set
			{
				this._resource = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._resource;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._resource = (Energistics.Etp.v12.Datatypes.Object.GraphResource)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
