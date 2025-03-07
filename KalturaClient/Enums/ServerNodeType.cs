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
namespace Kaltura.Enums
{
	public sealed class ServerNodeType : StringEnum
	{
		public static readonly ServerNodeType CONFERENCE_SERVER = new ServerNodeType("conference.CONFERENCE_SERVER");
		public static readonly ServerNodeType LIVE_CLUSTER_MEDIA_SERVER = new ServerNodeType("liveCluster.LIVE_CLUSTER_MEDIA_SERVER");
		public static readonly ServerNodeType SIP_SERVER = new ServerNodeType("sip.SIP_SERVER");
		public static readonly ServerNodeType WOWZA_MEDIA_SERVER = new ServerNodeType("wowza.WOWZA_MEDIA_SERVER");
		public static readonly ServerNodeType EDGE = new ServerNodeType("1");

		private ServerNodeType(string name) : base(name) { }
	}
}
