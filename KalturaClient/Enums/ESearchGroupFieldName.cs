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
	public sealed class ESearchGroupFieldName : StringEnum
	{
		public static readonly ESearchGroupFieldName COMPANY = new ESearchGroupFieldName("company");
		public static readonly ESearchGroupFieldName COUNTRY = new ESearchGroupFieldName("country");
		public static readonly ESearchGroupFieldName CREATED_AT = new ESearchGroupFieldName("created_at");
		public static readonly ESearchGroupFieldName EMAIL = new ESearchGroupFieldName("email");
		public static readonly ESearchGroupFieldName FIRST_NAME = new ESearchGroupFieldName("first_name");
		public static readonly ESearchGroupFieldName GROUP_IDS = new ESearchGroupFieldName("group_ids");
		public static readonly ESearchGroupFieldName LAST_NAME = new ESearchGroupFieldName("last_name");
		public static readonly ESearchGroupFieldName PERMISSION_NAMES = new ESearchGroupFieldName("permission_names");
		public static readonly ESearchGroupFieldName ROLE_IDS = new ESearchGroupFieldName("role_ids");
		public static readonly ESearchGroupFieldName SCREEN_NAME = new ESearchGroupFieldName("screen_name");
		public static readonly ESearchGroupFieldName TAGS = new ESearchGroupFieldName("tags");
		public static readonly ESearchGroupFieldName TITLE = new ESearchGroupFieldName("title");
		public static readonly ESearchGroupFieldName UPDATED_AT = new ESearchGroupFieldName("updated_at");
		public static readonly ESearchGroupFieldName USER_ID = new ESearchGroupFieldName("user_id");

		private ESearchGroupFieldName(string name) : base(name) { }
	}
}
