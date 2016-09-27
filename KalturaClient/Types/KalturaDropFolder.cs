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
	public class KalturaDropFolder : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private KalturaDropFolderType _Type = null;
		private KalturaDropFolderStatus _Status = (KalturaDropFolderStatus)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private string _Path = null;
		private int _FileSizeCheckInterval = Int32.MinValue;
		private KalturaDropFolderFileDeletePolicy _FileDeletePolicy = (KalturaDropFolderFileDeletePolicy)Int32.MinValue;
		private int _AutoFileDeleteDays = Int32.MinValue;
		private KalturaDropFolderFileHandlerType _FileHandlerType = null;
		private string _FileNamePatterns = null;
		private KalturaDropFolderFileHandlerConfig _FileHandlerConfig;
		private string _Tags = null;
		private KalturaDropFolderErrorCode _ErrorCode = null;
		private string _ErrorDescription = null;
		private string _IgnoreFileNamePatterns = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _LastAccessedAt = Int32.MinValue;
		private bool? _Incremental = null;
		private int _LastFileTimestamp = Int32.MinValue;
		private int _MetadataProfileId = Int32.MinValue;
		private string _CategoriesMetadataFieldName = null;
		private bool? _EnforceEntitlement = null;
		private bool? _ShouldValidateKS = null;
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public KalturaDropFolderType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaDropFolderStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public string Path
		{
			get { return _Path; }
			set 
			{ 
				_Path = value;
				OnPropertyChanged("Path");
			}
		}
		public int FileSizeCheckInterval
		{
			get { return _FileSizeCheckInterval; }
			set 
			{ 
				_FileSizeCheckInterval = value;
				OnPropertyChanged("FileSizeCheckInterval");
			}
		}
		public KalturaDropFolderFileDeletePolicy FileDeletePolicy
		{
			get { return _FileDeletePolicy; }
			set 
			{ 
				_FileDeletePolicy = value;
				OnPropertyChanged("FileDeletePolicy");
			}
		}
		public int AutoFileDeleteDays
		{
			get { return _AutoFileDeleteDays; }
			set 
			{ 
				_AutoFileDeleteDays = value;
				OnPropertyChanged("AutoFileDeleteDays");
			}
		}
		public KalturaDropFolderFileHandlerType FileHandlerType
		{
			get { return _FileHandlerType; }
			set 
			{ 
				_FileHandlerType = value;
				OnPropertyChanged("FileHandlerType");
			}
		}
		public string FileNamePatterns
		{
			get { return _FileNamePatterns; }
			set 
			{ 
				_FileNamePatterns = value;
				OnPropertyChanged("FileNamePatterns");
			}
		}
		public KalturaDropFolderFileHandlerConfig FileHandlerConfig
		{
			get { return _FileHandlerConfig; }
			set 
			{ 
				_FileHandlerConfig = value;
				OnPropertyChanged("FileHandlerConfig");
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
		public KalturaDropFolderErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		public string IgnoreFileNamePatterns
		{
			get { return _IgnoreFileNamePatterns; }
			set 
			{ 
				_IgnoreFileNamePatterns = value;
				OnPropertyChanged("IgnoreFileNamePatterns");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int LastAccessedAt
		{
			get { return _LastAccessedAt; }
			set 
			{ 
				_LastAccessedAt = value;
				OnPropertyChanged("LastAccessedAt");
			}
		}
		public bool? Incremental
		{
			get { return _Incremental; }
			set 
			{ 
				_Incremental = value;
				OnPropertyChanged("Incremental");
			}
		}
		public int LastFileTimestamp
		{
			get { return _LastFileTimestamp; }
			set 
			{ 
				_LastFileTimestamp = value;
				OnPropertyChanged("LastFileTimestamp");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public string CategoriesMetadataFieldName
		{
			get { return _CategoriesMetadataFieldName; }
			set 
			{ 
				_CategoriesMetadataFieldName = value;
				OnPropertyChanged("CategoriesMetadataFieldName");
			}
		}
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		public bool? ShouldValidateKS
		{
			get { return _ShouldValidateKS; }
			set 
			{ 
				_ShouldValidateKS = value;
				OnPropertyChanged("ShouldValidateKS");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolder()
		{
		}

		public KalturaDropFolder(XmlElement node) : base(node)
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
					case "description":
						this._Description = txt;
						continue;
					case "type":
						this._Type = (KalturaDropFolderType)KalturaStringEnum.Parse(typeof(KalturaDropFolderType), txt);
						continue;
					case "status":
						this._Status = (KalturaDropFolderStatus)ParseEnum(typeof(KalturaDropFolderStatus), txt);
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(txt);
						continue;
					case "dc":
						this._Dc = ParseInt(txt);
						continue;
					case "path":
						this._Path = txt;
						continue;
					case "fileSizeCheckInterval":
						this._FileSizeCheckInterval = ParseInt(txt);
						continue;
					case "fileDeletePolicy":
						this._FileDeletePolicy = (KalturaDropFolderFileDeletePolicy)ParseEnum(typeof(KalturaDropFolderFileDeletePolicy), txt);
						continue;
					case "autoFileDeleteDays":
						this._AutoFileDeleteDays = ParseInt(txt);
						continue;
					case "fileHandlerType":
						this._FileHandlerType = (KalturaDropFolderFileHandlerType)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileHandlerType), txt);
						continue;
					case "fileNamePatterns":
						this._FileNamePatterns = txt;
						continue;
					case "fileHandlerConfig":
						this._FileHandlerConfig = (KalturaDropFolderFileHandlerConfig)KalturaObjectFactory.Create(propertyNode, "KalturaDropFolderFileHandlerConfig");
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "errorCode":
						this._ErrorCode = (KalturaDropFolderErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderErrorCode), txt);
						continue;
					case "errorDescription":
						this._ErrorDescription = txt;
						continue;
					case "ignoreFileNamePatterns":
						this._IgnoreFileNamePatterns = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "lastAccessedAt":
						this._LastAccessedAt = ParseInt(txt);
						continue;
					case "incremental":
						this._Incremental = ParseBool(txt);
						continue;
					case "lastFileTimestamp":
						this._LastFileTimestamp = ParseInt(txt);
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(txt);
						continue;
					case "categoriesMetadataFieldName":
						this._CategoriesMetadataFieldName = txt;
						continue;
					case "enforceEntitlement":
						this._EnforceEntitlement = ParseBool(txt);
						continue;
					case "shouldValidateKS":
						this._ShouldValidateKS = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDropFolder");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("path", this._Path);
			kparams.AddIfNotNull("fileSizeCheckInterval", this._FileSizeCheckInterval);
			kparams.AddIfNotNull("fileDeletePolicy", this._FileDeletePolicy);
			kparams.AddIfNotNull("autoFileDeleteDays", this._AutoFileDeleteDays);
			kparams.AddIfNotNull("fileHandlerType", this._FileHandlerType);
			kparams.AddIfNotNull("fileNamePatterns", this._FileNamePatterns);
			kparams.AddIfNotNull("fileHandlerConfig", this._FileHandlerConfig);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("errorCode", this._ErrorCode);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			kparams.AddIfNotNull("ignoreFileNamePatterns", this._IgnoreFileNamePatterns);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("lastAccessedAt", this._LastAccessedAt);
			kparams.AddIfNotNull("incremental", this._Incremental);
			kparams.AddIfNotNull("lastFileTimestamp", this._LastFileTimestamp);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("categoriesMetadataFieldName", this._CategoriesMetadataFieldName);
			kparams.AddIfNotNull("enforceEntitlement", this._EnforceEntitlement);
			kparams.AddIfNotNull("shouldValidateKS", this._ShouldValidateKS);
			return kparams;
		}
		#endregion
	}
}

