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
	public sealed class UiConfAdminOrderBy : StringEnum
	{
		public static readonly UiConfAdminOrderBy CREATED_AT_ASC = new UiConfAdminOrderBy("+createdAt");
		public static readonly UiConfAdminOrderBy ID_ASC = new UiConfAdminOrderBy("+id");
		public static readonly UiConfAdminOrderBy NAME_ASC = new UiConfAdminOrderBy("+name");
		public static readonly UiConfAdminOrderBy UPDATED_AT_ASC = new UiConfAdminOrderBy("+updatedAt");
		public static readonly UiConfAdminOrderBy CREATED_AT_DESC = new UiConfAdminOrderBy("-createdAt");
		public static readonly UiConfAdminOrderBy ID_DESC = new UiConfAdminOrderBy("-id");
		public static readonly UiConfAdminOrderBy NAME_DESC = new UiConfAdminOrderBy("-name");
		public static readonly UiConfAdminOrderBy UPDATED_AT_DESC = new UiConfAdminOrderBy("-updatedAt");

		private UiConfAdminOrderBy(string name) : base(name) { }
	}
}
