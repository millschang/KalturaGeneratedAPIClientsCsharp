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
	public class MetadataFieldChangedCondition : MatchCondition
	{
		#region Constants
		public const string XPATH = "xPath";
		public const string PROFILE_ID = "profileId";
		public const string PROFILE_SYSTEM_NAME = "profileSystemName";
		public const string VERSION_A = "versionA";
		public const string VERSION_B = "versionB";
		#endregion

		#region Private Fields
		private string _XPath = null;
		private int _ProfileId = Int32.MinValue;
		private string _ProfileSystemName = null;
		private string _VersionA = null;
		private string _VersionB = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use XPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string XPath
		{
			get { return _XPath; }
			set 
			{ 
				_XPath = value;
				OnPropertyChanged("XPath");
			}
		}
		/// <summary>
		/// Use ProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProfileId
		{
			get { return _ProfileId; }
			set 
			{ 
				_ProfileId = value;
				OnPropertyChanged("ProfileId");
			}
		}
		/// <summary>
		/// Use ProfileSystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ProfileSystemName
		{
			get { return _ProfileSystemName; }
			set 
			{ 
				_ProfileSystemName = value;
				OnPropertyChanged("ProfileSystemName");
			}
		}
		/// <summary>
		/// Use VersionAAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionA
		{
			get { return _VersionA; }
			set 
			{ 
				_VersionA = value;
				OnPropertyChanged("VersionA");
			}
		}
		/// <summary>
		/// Use VersionBAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionB
		{
			get { return _VersionB; }
			set 
			{ 
				_VersionB = value;
				OnPropertyChanged("VersionB");
			}
		}
		#endregion

		#region CTor
		public MetadataFieldChangedCondition()
		{
		}

		public MetadataFieldChangedCondition(JToken node) : base(node)
		{
			if(node["xPath"] != null)
			{
				this._XPath = node["xPath"].Value<string>();
			}
			if(node["profileId"] != null)
			{
				this._ProfileId = ParseInt(node["profileId"].Value<string>());
			}
			if(node["profileSystemName"] != null)
			{
				this._ProfileSystemName = node["profileSystemName"].Value<string>();
			}
			if(node["versionA"] != null)
			{
				this._VersionA = node["versionA"].Value<string>();
			}
			if(node["versionB"] != null)
			{
				this._VersionB = node["versionB"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataFieldChangedCondition");
			kparams.AddIfNotNull("xPath", this._XPath);
			kparams.AddIfNotNull("profileId", this._ProfileId);
			kparams.AddIfNotNull("profileSystemName", this._ProfileSystemName);
			kparams.AddIfNotNull("versionA", this._VersionA);
			kparams.AddIfNotNull("versionB", this._VersionB);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XPATH:
					return "XPath";
				case PROFILE_ID:
					return "ProfileId";
				case PROFILE_SYSTEM_NAME:
					return "ProfileSystemName";
				case VERSION_A:
					return "VersionA";
				case VERSION_B:
					return "VersionB";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

