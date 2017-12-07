using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ScrollOutScrollView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            Debug.WriteLine(InnerScroll.VerticalOffset);
            if (InnerScroll.VerticalOffset == InnerScroll.ScrollableHeight)
            {
                InnerScroll.VerticalScrollMode = ScrollMode.Disabled;
               // ScrollViewer.SetVerticalScrollMode(InnerScroll, ScrollMode.Disabled);
            }else if(InnerScroll.VerticalOffset == 0)
            {
                InnerScroll.VerticalScrollMode = ScrollMode.Disabled;
               // ScrollViewer.SetVerticalScrollMode(InnerScroll, ScrollMode.Disabled);
            }    
        }


        private void PointerEnter(object sender, PointerRoutedEventArgs e)
        {
            InnerScroll.VerticalScrollMode = ScrollMode.Enabled;
           // ScrollViewer.SetVerticalScrollMode(InnerScroll, ScrollMode.Enabled);
        }
    }
}
