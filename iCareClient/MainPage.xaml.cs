using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

 

namespace iCareClient
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool firstLoad = true;
 
   
        public MainPage()
        {
            this.InitializeComponent();      
           
        }

       
 
       

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected   override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private  void webView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            if (firstLoad)
            {
                //async
                 // await new MessageDialog(firstLoad.ToString()).ShowAsync();
                firstLoad = false;             
            }
        }

       
    }
}
