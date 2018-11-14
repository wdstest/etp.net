﻿//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2018 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides enumerations of protocol message types.
    /// </summary>
    public static class MessageTypes
    {
        /// <summary>
        /// An enumeration of Core protocol message types.
        /// </summary>
        public enum Core
        {
            RequestSession = 1,
            OpenSession = 2,
            CloseSession = 5,
            RenewSecurityToken = 6,
            ProtocolException = 1000,
            Acknowledge = 1001
        }

        /// <summary>
        /// An enumeration of Channel Streaming protocol message types.
        /// </summary>
        public enum ChannelStreaming
        {
            ChannelMetadata = 1,
            ChannelData,
            StartStreaming,
            StopStreaming
        }

        /// <summary>
        /// An enumeration of Channel Subscribe protocol message types.
        /// </summary>
        public enum ChannelSubscribe
        {
            GetChannelMetadata = 1,
            GetChannelMetadataResponse = 2,
            SubscribeChannels = 3,
            RealtimeData = 4,
            InfillData = 5,
            ChangedData = 6,
            UnsubscribeChannels = 7,
            SubscriptionStopped = 8,
            GetRange = 9,
            GetRangeResponse = 10
        }

        /// <summary>
        /// An enumeration of Channel Data Load protocol message types.
        /// </summary>
        public enum ChannelDataLoad
        {
            OpenChannel = 1,
            OpenChannelResponse,
            CloseChannel,
            RealtimeData,
            InfillData,
            ChangedData
        }

        /// <summary>
        /// An enumeration of Channel Data Frame protocol message types.
        /// </summary>
        public enum ChannelDataFrame
        {
            RequestChannelData = 1,
            ChannelNotUsed,
            ChannelMetadata,
            ChannelDataFrameSet
        }

        /// <summary>
        /// An enumeration of Discovery protocol message types.
        /// </summary>
        public enum Discovery
        {
            GetResources = 1,
            GetResourcesResponse,
            GetResources2,
            GetResourcesResponse2
        }

        /// <summary>
        /// An enumeration of Discovery Query protocol message types.
        /// </summary>
        public enum DiscoveryQuery
        {
            FindResources = 1,
            FindResourcesResponse
        }

        /// <summary>
        /// An enumeration of Store protocol message types.
        /// </summary>
        public enum Store
        {
            GetObject = 1,
            PutObject,
            DeleteObject,
            Object
        }

        /// <summary>
        /// An enumeration of Store Query protocol message types.
        /// </summary>
        public enum StoreQuery
        {
            FindObjects = 1,
            FindObjectsResponse
        }

        /// <summary>
        /// An enumeration of Store Notification protocol message types.
        /// </summary>
        public enum StoreNotification
        {
            SubscribeNotification = 1,
            ObjectChanged,
            ObjectDeleted,
            UnsubscribeNotification,
            ObjectAccessRevoked,
            SubscribeNotification2
        }

        /// <summary>
        /// An enumeration of Growing Object protocol message types.
        /// </summary>
        public enum GrowingObject
        {
            DeletePart = 1,
            DeletePartsByRange,
            GetPart,
            GetPartsByRange,
            PutPart,
            ObjectPart,
            ReplacePartsByRange,
            GetPartsMetadata,
            GetPartsMetadataResponse
        }

        /// <summary>
        /// An enumeration of Growing Object Notification protocol message types.
        /// </summary>
        public enum GrowingObjectNotification
        {
            SubscribePartNotification = 1,
            PartChanged,
            PartDeleted,
            UnsubscribePartNotification,
            PartsDeletedByRange,
            PartsReplacedByRange,
            SubscribePartNotification2
        }

        /// <summary>
        /// An enumeration of Growing Object Query protocol message types.
        /// </summary>
        public enum GrowingObjectQuery
        {
            FindParts = 1,
            FindPartsResponse
        }

        /// <summary>
        /// An enumeration of Data Array protocol message types.
        /// </summary>
        public enum DataArray
        {
            DataArray = 1,
            GetDataArray,
            GetDataArraySlice,
            PutDataArray,
            PutDataArraySlice,
            DescribeDataArray,
            DataArrayMetadata
        }

        /// <summary>
        /// An enumeration of Witsml Soap protocol message types.
        /// </summary>
        public enum WitsmlSoap
        {
            AddToStore = 1,
            AddToStoreResponse,
            DeleteFromStore,
            DeleteFromStoreResponse,
            GetBaseMsg,
            GetBaseMsgResponse,
            GetCap,
            GetCapResponse,
            GetFromStore,
            GetFromStoreResponse,
            GetVersion,
            GetVersionResponse,
            UpdateInStore,
            UpdateInStoreResponse
        }
    }
}
