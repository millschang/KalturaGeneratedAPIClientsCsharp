// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2017  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class OptionalAnswer : ObjectBase
	{
		#region Constants
		public const string KEY = "key";
		public const string TEXT = "text";
		public const string WEIGHT = "weight";
		public const string IS_CORRECT = "isCorrect";
		#endregion

		#region Private Fields
		private string _Key = null;
		private string _Text = null;
		private float _Weight = Single.MinValue;
		private NullableBoolean _IsCorrect = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public float Weight
		{
			get { return _Weight; }
			set 
			{ 
				_Weight = value;
				OnPropertyChanged("Weight");
			}
		}
		public NullableBoolean IsCorrect
		{
			get { return _IsCorrect; }
			set 
			{ 
				_IsCorrect = value;
				OnPropertyChanged("IsCorrect");
			}
		}
		#endregion

		#region CTor
		public OptionalAnswer()
		{
		}

		public OptionalAnswer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "key":
						this._Key = propertyNode.InnerText;
						continue;
					case "text":
						this._Text = propertyNode.InnerText;
						continue;
					case "weight":
						this._Weight = ParseFloat(propertyNode.InnerText);
						continue;
					case "isCorrect":
						this._IsCorrect = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaOptionalAnswer");
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("weight", this._Weight);
			kparams.AddIfNotNull("isCorrect", this._IsCorrect);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY:
					return "Key";
				case TEXT:
					return "Text";
				case WEIGHT:
					return "Weight";
				case IS_CORRECT:
					return "IsCorrect";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

