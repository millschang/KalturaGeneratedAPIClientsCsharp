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
	public class ReportFilter : ObjectBase
	{
		#region Constants
		public const string DIMENSION = "dimension";
		public const string VALUES = "values";
		#endregion

		#region Private Fields
		private string _Dimension = null;
		private string _Values = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DimensionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Dimension
		{
			get { return _Dimension; }
			set 
			{ 
				_Dimension = value;
				OnPropertyChanged("Dimension");
			}
		}
		/// <summary>
		/// Use ValuesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Values
		{
			get { return _Values; }
			set 
			{ 
				_Values = value;
				OnPropertyChanged("Values");
			}
		}
		#endregion

		#region CTor
		public ReportFilter()
		{
		}

		public ReportFilter(JToken node) : base(node)
		{
			if(node["dimension"] != null)
			{
				this._Dimension = node["dimension"].Value<string>();
			}
			if(node["values"] != null)
			{
				this._Values = node["values"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportFilter");
			kparams.AddIfNotNull("dimension", this._Dimension);
			kparams.AddIfNotNull("values", this._Values);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DIMENSION:
					return "Dimension";
				case VALUES:
					return "Values";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

