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
	public class KalturaLiveChannelSegment : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private string _Tags = null;
		private KalturaLiveChannelSegmentType _Type = null;
		private KalturaLiveChannelSegmentStatus _Status = null;
		private string _ChannelId = null;
		private string _EntryId = null;
		private KalturaLiveChannelSegmentTriggerType _TriggerType = null;
		private string _TriggerSegmentId = null;
		private float _StartTime = Single.MinValue;
		private float _Duration = Single.MinValue;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public KalturaLiveChannelSegmentType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaLiveChannelSegmentStatus Status
		{
			get { return _Status; }
		}
		public string ChannelId
		{
			get { return _ChannelId; }
			set 
			{ 
				_ChannelId = value;
				OnPropertyChanged("ChannelId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public KalturaLiveChannelSegmentTriggerType TriggerType
		{
			get { return _TriggerType; }
			set 
			{ 
				_TriggerType = value;
				OnPropertyChanged("TriggerType");
			}
		}
		public string TriggerSegmentId
		{
			get { return _TriggerSegmentId; }
			set 
			{ 
				_TriggerSegmentId = value;
				OnPropertyChanged("TriggerSegmentId");
			}
		}
		public float StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public float Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveChannelSegment()
		{
		}

		public KalturaLiveChannelSegment(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "type":
						this._Type = (KalturaLiveChannelSegmentType)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentType), txt);
						continue;
					case "status":
						this._Status = (KalturaLiveChannelSegmentStatus)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentStatus), txt);
						continue;
					case "channelId":
						this._ChannelId = txt;
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "triggerType":
						this._TriggerType = (KalturaLiveChannelSegmentTriggerType)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentTriggerType), txt);
						continue;
					case "triggerSegmentId":
						this._TriggerSegmentId = txt;
						continue;
					case "startTime":
						this._StartTime = ParseFloat(txt);
						continue;
					case "duration":
						this._Duration = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveChannelSegment");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("channelId", this._ChannelId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("triggerType", this._TriggerType);
			kparams.AddIfNotNull("triggerSegmentId", this._TriggerSegmentId);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("duration", this._Duration);
			return kparams;
		}
		#endregion
	}
}

