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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class ScheduleEventResourceAddRequestBuilder : RequestBuilder<ScheduleEventResource>
	{
		#region Constants
		public const string SCHEDULE_EVENT_RESOURCE = "scheduleEventResource";
		#endregion

		public ScheduleEventResource ScheduleEventResource { get; set; }

		public ScheduleEventResourceAddRequestBuilder()
			: base("schedule_scheduleeventresource", "add")
		{
		}

		public ScheduleEventResourceAddRequestBuilder(ScheduleEventResource scheduleEventResource)
			: this()
		{
			this.ScheduleEventResource = scheduleEventResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventResource"))
				kparams.AddIfNotNull("scheduleEventResource", ScheduleEventResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleEventResource>(result);
		}
	}

	public class ScheduleEventResourceDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		#endregion

		public int ScheduleEventId { get; set; }
		public int ScheduleResourceId { get; set; }

		public ScheduleEventResourceDeleteRequestBuilder()
			: base("schedule_scheduleeventresource", "delete")
		{
		}

		public ScheduleEventResourceDeleteRequestBuilder(int scheduleEventId, int scheduleResourceId)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
			this.ScheduleResourceId = scheduleResourceId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class ScheduleEventResourceGetRequestBuilder : RequestBuilder<ScheduleEventResource>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		#endregion

		public int ScheduleEventId { get; set; }
		public int ScheduleResourceId { get; set; }

		public ScheduleEventResourceGetRequestBuilder()
			: base("schedule_scheduleeventresource", "get")
		{
		}

		public ScheduleEventResourceGetRequestBuilder(int scheduleEventId, int scheduleResourceId)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
			this.ScheduleResourceId = scheduleResourceId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleEventResource>(result);
		}
	}

	public class ScheduleEventResourceListRequestBuilder : RequestBuilder<ListResponse<ScheduleEventResource>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		public const string FILTER_BLACKOUT_CONFLICTS = "filterBlackoutConflicts";
		#endregion

		public ScheduleEventResourceFilter Filter { get; set; }
		public FilterPager Pager { get; set; }
		public bool FilterBlackoutConflicts { get; set; }

		public ScheduleEventResourceListRequestBuilder()
			: base("schedule_scheduleeventresource", "list")
		{
		}

		public ScheduleEventResourceListRequestBuilder(ScheduleEventResourceFilter filter, FilterPager pager, bool filterBlackoutConflicts)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
			this.FilterBlackoutConflicts = filterBlackoutConflicts;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			if (!isMapped("filterBlackoutConflicts"))
				kparams.AddIfNotNull("filterBlackoutConflicts", FilterBlackoutConflicts);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<ScheduleEventResource>>(result);
		}
	}

	public class ScheduleEventResourceUpdateRequestBuilder : RequestBuilder<ScheduleEventResource>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		public const string SCHEDULE_EVENT_RESOURCE = "scheduleEventResource";
		#endregion

		public int ScheduleEventId { get; set; }
		public int ScheduleResourceId { get; set; }
		public ScheduleEventResource ScheduleEventResource { get; set; }

		public ScheduleEventResourceUpdateRequestBuilder()
			: base("schedule_scheduleeventresource", "update")
		{
		}

		public ScheduleEventResourceUpdateRequestBuilder(int scheduleEventId, int scheduleResourceId, ScheduleEventResource scheduleEventResource)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
			this.ScheduleResourceId = scheduleResourceId;
			this.ScheduleEventResource = scheduleEventResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			if (!isMapped("scheduleEventResource"))
				kparams.AddIfNotNull("scheduleEventResource", ScheduleEventResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleEventResource>(result);
		}
	}


	public class ScheduleEventResourceService
	{
		private ScheduleEventResourceService()
		{
		}

		public static ScheduleEventResourceAddRequestBuilder Add(ScheduleEventResource scheduleEventResource)
		{
			return new ScheduleEventResourceAddRequestBuilder(scheduleEventResource);
		}

		public static ScheduleEventResourceDeleteRequestBuilder Delete(int scheduleEventId, int scheduleResourceId)
		{
			return new ScheduleEventResourceDeleteRequestBuilder(scheduleEventId, scheduleResourceId);
		}

		public static ScheduleEventResourceGetRequestBuilder Get(int scheduleEventId, int scheduleResourceId)
		{
			return new ScheduleEventResourceGetRequestBuilder(scheduleEventId, scheduleResourceId);
		}

		public static ScheduleEventResourceListRequestBuilder List(ScheduleEventResourceFilter filter = null, FilterPager pager = null, bool filterBlackoutConflicts = true)
		{
			return new ScheduleEventResourceListRequestBuilder(filter, pager, filterBlackoutConflicts);
		}

		public static ScheduleEventResourceUpdateRequestBuilder Update(int scheduleEventId, int scheduleResourceId, ScheduleEventResource scheduleEventResource)
		{
			return new ScheduleEventResourceUpdateRequestBuilder(scheduleEventId, scheduleResourceId, scheduleEventResource);
		}
	}
}
