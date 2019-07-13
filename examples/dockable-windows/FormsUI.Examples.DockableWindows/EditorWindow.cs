﻿using FormsUI.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI.Examples.DockableWindows
{
    public partial class EditorWindow : BaseDockableWindow
    {
        public EditorWindow(IAppWindow<TextEditorModel> appWindow)
            : base(appWindow, false)
        {
            InitializeComponent();
        }
    }
}