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
	public class KalturaAssetParams : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private KalturaNullableBoolean _IsSystemDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Tags = null;
		private IList<KalturaString> _RequiredPermissions;
		private int _SourceRemoteStorageProfileId = Int32.MinValue;
		private int _RemoteStorageProfileIds = Int32.MinValue;
		private KalturaMediaParserType _MediaParserType = null;
		private string _SourceAssetParamsIds = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public KalturaNullableBoolean IsSystemDefault
		{
			get { return _IsSystemDefault; }
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public new IList<KalturaString> RequiredPermissions
		{
			get { return _RequiredPermissions; }
			set 
			{ 
				_RequiredPermissions = value;
				OnPropertyChanged("RequiredPermissions");
			}
		}
		public int SourceRemoteStorageProfileId
		{
			get { return _SourceRemoteStorageProfileId; }
			set 
			{ 
				_SourceRemoteStorageProfileId = value;
				OnPropertyChanged("SourceRemoteStorageProfileId");
			}
		}
		public int RemoteStorageProfileIds
		{
			get { return _RemoteStorageProfileIds; }
			set 
			{ 
				_RemoteStorageProfileIds = value;
				OnPropertyChanged("RemoteStorageProfileIds");
			}
		}
		public KalturaMediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		public string SourceAssetParamsIds
		{
			get { return _SourceAssetParamsIds; }
			set 
			{ 
				_SourceAssetParamsIds = value;
				OnPropertyChanged("SourceAssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParams()
		{
		}

		public KalturaAssetParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "isSystemDefault":
						this._IsSystemDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "requiredPermissions":
						this._RequiredPermissions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredPermissions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "sourceRemoteStorageProfileId":
						this._SourceRemoteStorageProfileId = ParseInt(txt);
						continue;
					case "remoteStorageProfileIds":
						this._RemoteStorageProfileIds = ParseInt(txt);
						continue;
					case "mediaParserType":
						this._MediaParserType = (KalturaMediaParserType)KalturaStringEnum.Parse(typeof(KalturaMediaParserType), txt);
						continue;
					case "sourceAssetParamsIds":
						this._SourceAssetParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAssetParams");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("isSystemDefault", this._IsSystemDefault);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("requiredPermissions", this._RequiredPermissions);
			kparams.AddIfNotNull("sourceRemoteStorageProfileId", this._SourceRemoteStorageProfileId);
			kparams.AddIfNotNull("remoteStorageProfileIds", this._RemoteStorageProfileIds);
			kparams.AddIfNotNull("mediaParserType", this._MediaParserType);
			kparams.AddIfNotNull("sourceAssetParamsIds", this._SourceAssetParamsIds);
			return kparams;
		}
		#endregion
	}
}

