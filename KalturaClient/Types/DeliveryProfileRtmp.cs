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
	public class DeliveryProfileRtmp : DeliveryProfile
	{
		#region Constants
		public const string ENFORCE_RTMPE = "enforceRtmpe";
		public const string PREFIX = "prefix";
		#endregion

		#region Private Fields
		private bool? _EnforceRtmpe = null;
		private string _Prefix = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EnforceRtmpeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnforceRtmpe
		{
			get { return _EnforceRtmpe; }
			set 
			{ 
				_EnforceRtmpe = value;
				OnPropertyChanged("EnforceRtmpe");
			}
		}
		/// <summary>
		/// Use PrefixAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Prefix
		{
			get { return _Prefix; }
			set 
			{ 
				_Prefix = value;
				OnPropertyChanged("Prefix");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileRtmp()
		{
		}

		public DeliveryProfileRtmp(JToken node) : base(node)
		{
			if(node["enforceRtmpe"] != null)
			{
				this._EnforceRtmpe = ParseBool(node["enforceRtmpe"].Value<string>());
			}
			if(node["prefix"] != null)
			{
				this._Prefix = node["prefix"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileRtmp");
			kparams.AddIfNotNull("enforceRtmpe", this._EnforceRtmpe);
			kparams.AddIfNotNull("prefix", this._Prefix);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENFORCE_RTMPE:
					return "EnforceRtmpe";
				case PREFIX:
					return "Prefix";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

