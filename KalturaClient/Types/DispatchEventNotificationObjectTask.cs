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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class DispatchEventNotificationObjectTask : ObjectTask
	{
		#region Constants
		public const string EVENT_NOTIFICATION_TEMPLATE_ID = "eventNotificationTemplateId";
		#endregion

		#region Private Fields
		private int _EventNotificationTemplateId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int EventNotificationTemplateId
		{
			get { return _EventNotificationTemplateId; }
			set 
			{ 
				_EventNotificationTemplateId = value;
				OnPropertyChanged("EventNotificationTemplateId");
			}
		}
		#endregion

		#region CTor
		public DispatchEventNotificationObjectTask()
		{
		}

		public DispatchEventNotificationObjectTask(JToken node) : base(node)
		{
			if(node["eventNotificationTemplateId"] != null)
			{
				this._EventNotificationTemplateId = ParseInt(node["eventNotificationTemplateId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDispatchEventNotificationObjectTask");
			kparams.AddIfNotNull("eventNotificationTemplateId", this._EventNotificationTemplateId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EVENT_NOTIFICATION_TEMPLATE_ID:
					return "EventNotificationTemplateId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

