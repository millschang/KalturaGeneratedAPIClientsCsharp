// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class MediaServerNode : DeliveryServerNode
	{
		#region Constants
		public const string APPLICATION_NAME = "applicationName";
		public const string MEDIA_SERVER_PORT_CONFIG = "mediaServerPortConfig";
		public const string MEDIA_SERVER_PLAYBACK_DOMAIN_CONFIG = "mediaServerPlaybackDomainConfig";
		#endregion

		#region Private Fields
		private string _ApplicationName = null;
		private IList<KeyValue> _MediaServerPortConfig;
		private IList<KeyValue> _MediaServerPlaybackDomainConfig;
		#endregion

		#region Properties
		/// <summary>
		/// Use ApplicationNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ApplicationName
		{
			get { return _ApplicationName; }
			set 
			{ 
				_ApplicationName = value;
				OnPropertyChanged("ApplicationName");
			}
		}
		/// <summary>
		/// Use MediaServerPortConfigAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> MediaServerPortConfig
		{
			get { return _MediaServerPortConfig; }
			set 
			{ 
				_MediaServerPortConfig = value;
				OnPropertyChanged("MediaServerPortConfig");
			}
		}
		/// <summary>
		/// Use MediaServerPlaybackDomainConfigAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> MediaServerPlaybackDomainConfig
		{
			get { return _MediaServerPlaybackDomainConfig; }
			set 
			{ 
				_MediaServerPlaybackDomainConfig = value;
				OnPropertyChanged("MediaServerPlaybackDomainConfig");
			}
		}
		#endregion

		#region CTor
		public MediaServerNode()
		{
		}

		public MediaServerNode(JToken node) : base(node)
		{
			if(node["applicationName"] != null)
			{
				this._ApplicationName = node["applicationName"].Value<string>();
			}
			if(node["mediaServerPortConfig"] != null)
			{
				this._MediaServerPortConfig = new List<KeyValue>();
				foreach(var arrayNode in node["mediaServerPortConfig"].Children())
				{
					this._MediaServerPortConfig.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mediaServerPlaybackDomainConfig"] != null)
			{
				this._MediaServerPlaybackDomainConfig = new List<KeyValue>();
				foreach(var arrayNode in node["mediaServerPlaybackDomainConfig"].Children())
				{
					this._MediaServerPlaybackDomainConfig.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaServerNode");
			kparams.AddIfNotNull("applicationName", this._ApplicationName);
			kparams.AddIfNotNull("mediaServerPortConfig", this._MediaServerPortConfig);
			kparams.AddIfNotNull("mediaServerPlaybackDomainConfig", this._MediaServerPlaybackDomainConfig);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case APPLICATION_NAME:
					return "ApplicationName";
				case MEDIA_SERVER_PORT_CONFIG:
					return "MediaServerPortConfig";
				case MEDIA_SERVER_PLAYBACK_DOMAIN_CONFIG:
					return "MediaServerPlaybackDomainConfig";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

