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
	public class KalturaBulkUpload : KalturaObjectBase
	{
		#region Private Fields
		private long _Id = long.MinValue;
		private string _UploadedBy = null;
		private string _UploadedByUserId = null;
		private int _UploadedOn = Int32.MinValue;
		private int _NumOfEntries = Int32.MinValue;
		private KalturaBatchJobStatus _Status = (KalturaBatchJobStatus)Int32.MinValue;
		private string _LogFileUrl = null;
		private string _CsvFileUrl = null;
		private string _BulkFileUrl = null;
		private KalturaBulkUploadType _BulkUploadType = null;
		private IList<KalturaBulkUploadResult> _Results;
		private string _Error = null;
		private KalturaBatchJobErrorTypes _ErrorType = (KalturaBatchJobErrorTypes)Int32.MinValue;
		private int _ErrorNumber = Int32.MinValue;
		private string _FileName = null;
		private string _Description = null;
		private int _NumOfObjects = Int32.MinValue;
		private KalturaBulkUploadObjectType _BulkUploadObjectType = null;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string UploadedBy
		{
			get { return _UploadedBy; }
			set 
			{ 
				_UploadedBy = value;
				OnPropertyChanged("UploadedBy");
			}
		}
		public string UploadedByUserId
		{
			get { return _UploadedByUserId; }
			set 
			{ 
				_UploadedByUserId = value;
				OnPropertyChanged("UploadedByUserId");
			}
		}
		public int UploadedOn
		{
			get { return _UploadedOn; }
			set 
			{ 
				_UploadedOn = value;
				OnPropertyChanged("UploadedOn");
			}
		}
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
			set 
			{ 
				_NumOfEntries = value;
				OnPropertyChanged("NumOfEntries");
			}
		}
		public KalturaBatchJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string LogFileUrl
		{
			get { return _LogFileUrl; }
			set 
			{ 
				_LogFileUrl = value;
				OnPropertyChanged("LogFileUrl");
			}
		}
		public string CsvFileUrl
		{
			get { return _CsvFileUrl; }
			set 
			{ 
				_CsvFileUrl = value;
				OnPropertyChanged("CsvFileUrl");
			}
		}
		public string BulkFileUrl
		{
			get { return _BulkFileUrl; }
			set 
			{ 
				_BulkFileUrl = value;
				OnPropertyChanged("BulkFileUrl");
			}
		}
		public KalturaBulkUploadType BulkUploadType
		{
			get { return _BulkUploadType; }
			set 
			{ 
				_BulkUploadType = value;
				OnPropertyChanged("BulkUploadType");
			}
		}
		public new IList<KalturaBulkUploadResult> Results
		{
			get { return _Results; }
			set 
			{ 
				_Results = value;
				OnPropertyChanged("Results");
			}
		}
		public string Error
		{
			get { return _Error; }
			set 
			{ 
				_Error = value;
				OnPropertyChanged("Error");
			}
		}
		public KalturaBatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			set 
			{ 
				_ErrorNumber = value;
				OnPropertyChanged("ErrorNumber");
			}
		}
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
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
		public int NumOfObjects
		{
			get { return _NumOfObjects; }
			set 
			{ 
				_NumOfObjects = value;
				OnPropertyChanged("NumOfObjects");
			}
		}
		public KalturaBulkUploadObjectType BulkUploadObjectType
		{
			get { return _BulkUploadObjectType; }
			set 
			{ 
				_BulkUploadObjectType = value;
				OnPropertyChanged("BulkUploadObjectType");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUpload()
		{
		}

		public KalturaBulkUpload(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(txt);
						continue;
					case "uploadedBy":
						this._UploadedBy = txt;
						continue;
					case "uploadedByUserId":
						this._UploadedByUserId = txt;
						continue;
					case "uploadedOn":
						this._UploadedOn = ParseInt(txt);
						continue;
					case "numOfEntries":
						this._NumOfEntries = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaBatchJobStatus)ParseEnum(typeof(KalturaBatchJobStatus), txt);
						continue;
					case "logFileUrl":
						this._LogFileUrl = txt;
						continue;
					case "csvFileUrl":
						this._CsvFileUrl = txt;
						continue;
					case "bulkFileUrl":
						this._BulkFileUrl = txt;
						continue;
					case "bulkUploadType":
						this._BulkUploadType = (KalturaBulkUploadType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadType), txt);
						continue;
					case "results":
						this._Results = new List<KalturaBulkUploadResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Results.Add((KalturaBulkUploadResult)KalturaObjectFactory.Create(arrayNode, "KalturaBulkUploadResult"));
						}
						continue;
					case "error":
						this._Error = txt;
						continue;
					case "errorType":
						this._ErrorType = (KalturaBatchJobErrorTypes)ParseEnum(typeof(KalturaBatchJobErrorTypes), txt);
						continue;
					case "errorNumber":
						this._ErrorNumber = ParseInt(txt);
						continue;
					case "fileName":
						this._FileName = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "numOfObjects":
						this._NumOfObjects = ParseInt(txt);
						continue;
					case "bulkUploadObjectType":
						this._BulkUploadObjectType = (KalturaBulkUploadObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadObjectType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUpload");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("uploadedBy", this._UploadedBy);
			kparams.AddIfNotNull("uploadedByUserId", this._UploadedByUserId);
			kparams.AddIfNotNull("uploadedOn", this._UploadedOn);
			kparams.AddIfNotNull("numOfEntries", this._NumOfEntries);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("logFileUrl", this._LogFileUrl);
			kparams.AddIfNotNull("csvFileUrl", this._CsvFileUrl);
			kparams.AddIfNotNull("bulkFileUrl", this._BulkFileUrl);
			kparams.AddIfNotNull("bulkUploadType", this._BulkUploadType);
			kparams.AddIfNotNull("results", this._Results);
			kparams.AddIfNotNull("error", this._Error);
			kparams.AddIfNotNull("errorType", this._ErrorType);
			kparams.AddIfNotNull("errorNumber", this._ErrorNumber);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("numOfObjects", this._NumOfObjects);
			kparams.AddIfNotNull("bulkUploadObjectType", this._BulkUploadObjectType);
			return kparams;
		}
		#endregion
	}
}

