﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI.Windows
{
    public sealed class MenuStripMerge : ToolStripMerge
    {
        /// <summary>
        /// Initializes a new instance of <c>MenuStripMerge</c> class.
        /// </summary>
        /// <param name="menuStrip">The menu strip to be merged into main menu.</param>
        /// <param name="positionTag">The position in the main menu where the menu strip should be merged.</param>
        public MenuStripMerge(ContextMenuStrip menuStrip, string positionTag)
            : this(menuStrip, positionTag, true) { }

        /// <summary>
        /// Initializes a new instance of <c>MenuStripMerge</c> class.
        /// </summary>
        /// <param name="menuStrip">The menu strip to be merged into main menu.</param>
        /// <param name="position">The position in the main menu where the menu strip should be merged.</param>
        /// <param name="needHide">A <see cref="bool"/> value which indicates whether the menu strip should be hidden when
        /// the hosting window is hidden.</param>
        public MenuStripMerge(ContextMenuStrip menuStrip, string positionTag, bool needHide)
            : base(menuStrip, needHide)
        {
            PositionTag = positionTag;
        }

        public string PositionTag { get; }
    }
}
