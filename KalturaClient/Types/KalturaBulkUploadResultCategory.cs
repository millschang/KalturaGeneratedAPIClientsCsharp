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
	public class KalturaBulkUploadResultCategory : KalturaBulkUploadResult
	{
		#region Private Fields
		private string _RelativePath = null;
		private string _Name = null;
		private string _ReferenceId = null;
		private string _Description = null;
		private string _Tags = null;
		private int _AppearInList = Int32.MinValue;
		private int _Privacy = Int32.MinValue;
		private int _InheritanceType = Int32.MinValue;
		private int _UserJoinPolicy = Int32.MinValue;
		private int _DefaultPermissionLevel = Int32.MinValue;
		private string _Owner = null;
		private int _ContributionPolicy = Int32.MinValue;
		private int _PartnerSortValue = Int32.MinValue;
		private bool? _Moderation = null;
		#endregion

		#region Properties
		public string RelativePath
		{
			get { return _RelativePath; }
			set 
			{ 
				_RelativePath = value;
				OnPropertyChanged("RelativePath");
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
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public int AppearInList
		{
			get { return _AppearInList; }
			set 
			{ 
				_AppearInList = value;
				OnPropertyChanged("AppearInList");
			}
		}
		public int Privacy
		{
			get { return _Privacy; }
			set 
			{ 
				_Privacy = value;
				OnPropertyChanged("Privacy");
			}
		}
		public int InheritanceType
		{
			get { return _InheritanceType; }
			set 
			{ 
				_InheritanceType = value;
				OnPropertyChanged("InheritanceType");
			}
		}
		public int UserJoinPolicy
		{
			get { return _UserJoinPolicy; }
			set 
			{ 
				_UserJoinPolicy = value;
				OnPropertyChanged("UserJoinPolicy");
			}
		}
		public int DefaultPermissionLevel
		{
			get { return _DefaultPermissionLevel; }
			set 
			{ 
				_DefaultPermissionLevel = value;
				OnPropertyChanged("DefaultPermissionLevel");
			}
		}
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		public int ContributionPolicy
		{
			get { return _ContributionPolicy; }
			set 
			{ 
				_ContributionPolicy = value;
				OnPropertyChanged("ContributionPolicy");
			}
		}
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		public bool? Moderation
		{
			get { return _Moderation; }
			set 
			{ 
				_Moderation = value;
				OnPropertyChanged("Moderation");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUploadResultCategory()
		{
		}

		public KalturaBulkUploadResultCategory(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "relativePath":
						this._RelativePath = txt;
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "referenceId":
						this._ReferenceId = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "appearInList":
						this._AppearInList = ParseInt(txt);
						continue;
					case "privacy":
						this._Privacy = ParseInt(txt);
						continue;
					case "inheritanceType":
						this._InheritanceType = ParseInt(txt);
						continue;
					case "userJoinPolicy":
						this._UserJoinPolicy = ParseInt(txt);
						continue;
					case "defaultPermissionLevel":
						this._DefaultPermissionLevel = ParseInt(txt);
						continue;
					case "owner":
						this._Owner = txt;
						continue;
					case "contributionPolicy":
						this._ContributionPolicy = ParseInt(txt);
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(txt);
						continue;
					case "moderation":
						this._Moderation = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadResultCategory");
			kparams.AddIfNotNull("relativePath", this._RelativePath);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("appearInList", this._AppearInList);
			kparams.AddIfNotNull("privacy", this._Privacy);
			kparams.AddIfNotNull("inheritanceType", this._InheritanceType);
			kparams.AddIfNotNull("userJoinPolicy", this._UserJoinPolicy);
			kparams.AddIfNotNull("defaultPermissionLevel", this._DefaultPermissionLevel);
			kparams.AddIfNotNull("owner", this._Owner);
			kparams.AddIfNotNull("contributionPolicy", this._ContributionPolicy);
			kparams.AddIfNotNull("partnerSortValue", this._PartnerSortValue);
			kparams.AddIfNotNull("moderation", this._Moderation);
			return kparams;
		}
		#endregion
	}
}

