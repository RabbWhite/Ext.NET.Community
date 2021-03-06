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

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class CapsLockDetectorDirectEvents : ComponentDirectEvents
    {
        public CapsLockDetectorDirectEvents() { }

        public CapsLockDetectorDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent capslockon;

        /// <summary>
        /// Fires when capslock is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockon", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent CapsLockOn
        {
            get
            {
                return this.capslockon ?? (this.capslockon = new ComponentDirectEvent());
            }
        }

        private ComponentDirectEvent capslockoff;

        /// <summary>
        /// Fires when capslock deactivating is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockoff", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent CapsLockOff
        {
            get
            {
                return this.capslockoff ?? (this.capslockoff = new ComponentDirectEvent());
            }
        }
    }
}