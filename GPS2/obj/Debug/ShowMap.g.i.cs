﻿

#pragma checksum "C:\Users\Ta Tuan Anh\Dropbox\TA\STUDY\IT\IT POLAND\Summer Semester\Prgramming in Windows Mobile\Project labs\20150418\GPS\GPS2\GPS2\GPS2\ShowMap.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "998F7496118762887C2854E58032E7FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPS2
{
    partial class ShowMap : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock geolocation; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Maps.MapControl MapControl1; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///ShowMap.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            geolocation = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("geolocation");
            MapControl1 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)this.FindName("MapControl1");
        }
    }
}


