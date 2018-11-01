// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Discovery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetResourcesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetResourcesResponse"",""namespace"":""Energistics.Etp.v12.Protocol.Discovery"",""fields"":[{""name"":""resource"",""type"":{""type"":""record"",""name"":""Resource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""channelSubscribable"",""default"":false,""type"":""boolean""},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}},{""name"":""resourceType"",""type"":""string""},{""name"":""childCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""uuid"",""default"":"""",""type"":""string""},{""name"":""lastChanged"",""type"":[""null"",""long""]},{""name"":""objectNotifiable"",""default"":false,""type"":""boolean""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.Resource"",""depends"":[]}}],""protocol"":""3"",""messageType"":""2"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.Resource""
]}");
		private Energistics.Etp.v12.Datatypes.Object.Resource _resource;
		public virtual Schema Schema
		{
			get
			{
				return GetResourcesResponse._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.Resource Resource
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
			case 0: this._resource = (Energistics.Etp.v12.Datatypes.Object.Resource)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
