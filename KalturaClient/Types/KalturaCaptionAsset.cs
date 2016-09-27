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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaCaptionAsset : KalturaAsset
	{
		#region Private Fields
		private int _CaptionParamsId = Int32.MinValue;
		private KalturaLanguage _Language = null;
		private KalturaLanguageCode _LanguageCode = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Label = null;
		private KalturaCaptionType _Format = null;
		private KalturaCaptionAssetStatus _Status = (KalturaCaptionAssetStatus)Int32.MinValue;
		private string _ParentId = null;
		private int _Accuracy = Int32.MinValue;
		#endregion

		#region Properties
		public int CaptionParamsId
		{
			get { return _CaptionParamsId; }
			set 
			{ 
				_CaptionParamsId = value;
				OnPropertyChanged("CaptionParamsId");
			}
		}
		public KalturaLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public KalturaLanguageCode LanguageCode
		{
			get { return _LanguageCode; }
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public KalturaCaptionType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public KalturaCaptionAssetStatus Status
		{
			get { return _Status; }
		}
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public int Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionAsset()
		{
		}

		public KalturaCaptionAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "captionParamsId":
						this._CaptionParamsId = ParseInt(txt);
						continue;
					case "language":
						this._Language = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "languageCode":
						this._LanguageCode = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "isDefault":
						this._IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "label":
						this._Label = txt;
						continue;
					case "format":
						this._Format = (KalturaCaptionType)KalturaStringEnum.Parse(typeof(KalturaCaptionType), txt);
						continue;
					case "status":
						this._Status = (KalturaCaptionAssetStatus)ParseEnum(typeof(KalturaCaptionAssetStatus), txt);
						continue;
					case "parentId":
						this._ParentId = txt;
						continue;
					case "accuracy":
						this._Accuracy = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCaptionAsset");
			kparams.AddIfNotNull("captionParamsId", this._CaptionParamsId);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("languageCode", this._LanguageCode);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("accuracy", this._Accuracy);
			return kparams;
		}
		#endregion
	}
}

