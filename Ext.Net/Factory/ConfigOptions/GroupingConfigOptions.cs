/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0.beta - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-03-07
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Grouping
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("fType", new ConfigOption("fType", new SerializationOptions("ftype"), "", this.FType ));
                list.Add("depthToIndent", new ConfigOption("depthToIndent", null, 17, this.DepthToIndent ));
                list.Add("enableGroupingMenu", new ConfigOption("enableGroupingMenu", null, true, this.EnableGroupingMenu ));
                list.Add("enableNoGroups", new ConfigOption("enableNoGroups", null, true, this.EnableNoGroups ));
                list.Add("groupByText", new ConfigOption("groupByText", null, "", this.GroupByText ));
                list.Add("groupHeaderTpl", new ConfigOption("groupHeaderTpl", null, "", this.GroupHeaderTpl ));
                list.Add("hideGroupedHeader", new ConfigOption("hideGroupedHeader", null, false, this.HideGroupedHeader ));
                list.Add("showGroupsText", new ConfigOption("showGroupsText", null, "", this.ShowGroupsText ));
                list.Add("startCollapsed", new ConfigOption("startCollapsed", null, false, this.StartCollapsed ));

                return list;
            }
        }
    }
}