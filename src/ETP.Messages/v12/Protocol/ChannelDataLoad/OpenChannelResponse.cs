// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class OpenChannelResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""OpenChannelResponse"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelDataLoad"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""uuid"",""type"":{""type"":""fixed"",""name"":""Uuid"",""namespace"":""Energistics.Etp.v12.Datatypes"",""size"":16,""fullName"":""Energistics.Etp.v12.Datatypes.Uuid"",""depends"":[]}},{""name"":""id"",""type"":""long""},{""name"":""lastIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""infill"",""default"":true,""type"":""boolean""},{""name"":""dataChanges"",""default"":true,""type"":""boolean""},{""name"":""openStatus"",""default"":true,""type"":""boolean""},{""name"":""openError"",""default"":"""",""type"":""string""}],""protocol"":""22"",""messageType"":""2"",""senderRole"":""consumer"",""protocolRoles"":""producer,consumer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Uuid"",
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}");
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Uuid _uuid;
		private long _id;
		private Energistics.Etp.v12.Datatypes.IndexValue _lastIndex;
		private bool _infill;
		private bool _dataChanges;
		private bool _openStatus;
		private string _openError;
		public virtual Schema Schema
		{
			get
			{
				return OpenChannelResponse._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public long Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.IndexValue LastIndex
		{
			get
			{
				return this._lastIndex;
			}
			set
			{
				this._lastIndex = value;
			}
		}
		public bool Infill
		{
			get
			{
				return this._infill;
			}
			set
			{
				this._infill = value;
			}
		}
		public bool DataChanges
		{
			get
			{
				return this._dataChanges;
			}
			set
			{
				this._dataChanges = value;
			}
		}
		public bool OpenStatus
		{
			get
			{
				return this._openStatus;
			}
			set
			{
				this._openStatus = value;
			}
		}
		public string OpenError
		{
			get
			{
				return this._openError;
			}
			set
			{
				this._openError = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._uuid;
			case 2: return this._id;
			case 3: return this._lastIndex;
			case 4: return this._infill;
			case 5: return this._dataChanges;
			case 6: return this._openStatus;
			case 7: return this._openError;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._uuid = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 2: this._id = (System.Int64)fieldValue; break;
			case 3: this._lastIndex = (Energistics.Etp.v12.Datatypes.IndexValue)fieldValue; break;
			case 4: this._infill = (System.Boolean)fieldValue; break;
			case 5: this._dataChanges = (System.Boolean)fieldValue; break;
			case 6: this._openStatus = (System.Boolean)fieldValue; break;
			case 7: this._openError = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
