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
	public class Dictionary : ObjectBase
	{
		#region Constants
		public const string LANGUAGE = "language";
		public const string DATA = "data";
		#endregion

		#region Private Fields
		private CatalogItemLanguage _Language = null;
		private string _Data = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CatalogItemLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use DataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		#endregion

		#region CTor
		public Dictionary()
		{
		}

		public Dictionary(JToken node) : base(node)
		{
			if(node["language"] != null)
			{
				this._Language = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["language"].Value<string>());
			}
			if(node["data"] != null)
			{
				this._Data = node["data"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDictionary");
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("data", this._Data);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LANGUAGE:
					return "Language";
				case DATA:
					return "Data";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

