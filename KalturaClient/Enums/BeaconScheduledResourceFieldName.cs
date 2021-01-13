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
namespace Kaltura.Enums
{
	public sealed class BeaconScheduledResourceFieldName : StringEnum
	{
		public static readonly BeaconScheduledResourceFieldName EVENT_TYPE = new BeaconScheduledResourceFieldName("event_type");
		public static readonly BeaconScheduledResourceFieldName IS_LOG = new BeaconScheduledResourceFieldName("is_log");
		public static readonly BeaconScheduledResourceFieldName OBJECT_ID = new BeaconScheduledResourceFieldName("object_id");
		public static readonly BeaconScheduledResourceFieldName RECORDING = new BeaconScheduledResourceFieldName("recording");
		public static readonly BeaconScheduledResourceFieldName RESOURCE_NAME = new BeaconScheduledResourceFieldName("resource_name");
		public static readonly BeaconScheduledResourceFieldName STATUS = new BeaconScheduledResourceFieldName("status");
		public static readonly BeaconScheduledResourceFieldName UPDATED_AT = new BeaconScheduledResourceFieldName("updated_at");

		private BeaconScheduledResourceFieldName(string name) : base(name) { }
	}
}
