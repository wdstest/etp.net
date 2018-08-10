// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes.ChannelData
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelRangeInfo : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelRangeInfo"",""namespace"":""Energistics.Datatypes.ChannelData"",""fields"":[{""name"":""channelId"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""startIndex"",""type"":""long""},{""name"":""endIndex"",""type"":""long""}],""fullName"":""Energistics.Datatypes.ChannelData.ChannelRangeInfo"",""depends"":[]}");
		private IList<System.Int64> _channelId;
		private long _startIndex;
		private long _endIndex;
		public virtual Schema Schema
		{
			get
			{
				return ChannelRangeInfo._SCHEMA;
			}
		}
		public IList<System.Int64> ChannelId
		{
			get
			{
				return this._channelId;
			}
			set
			{
				this._channelId = value;
			}
		}
		public long StartIndex
		{
			get
			{
				return this._startIndex;
			}
			set
			{
				this._startIndex = value;
			}
		}
		public long EndIndex
		{
			get
			{
				return this._endIndex;
			}
			set
			{
				this._endIndex = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channelId;
			case 1: return this._startIndex;
			case 2: return this._endIndex;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channelId = (IList<System.Int64>)fieldValue; break;
			case 1: this._startIndex = (System.Int64)fieldValue; break;
			case 2: this._endIndex = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}