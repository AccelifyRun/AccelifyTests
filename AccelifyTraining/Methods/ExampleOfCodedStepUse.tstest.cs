using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace AccelifyTraining
{

    public class checkeventpresence : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
    static readonly Random rnd = new Random();
    public static DateTime GetRandomDate(DateTime from, DateTime to)
    {
        var range = to - from;

        var randTimeSpan = new System.TimeSpan((long)(rnd.NextDouble() * range.Ticks)); 

        return from + randTimeSpan;
    

}
        [CodedStep(@"Put_Random_in")]
        public void CreateEventMethod_Put_Random()
        {
            String date1 = GetRandomDate(new DateTime(2016, 8, 1),new DateTime(2016, 12, 1)).ToString("MM/dd/yyyy");
            SetExtractedValue("RandomDate", date1);
        }
             
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void checkeventpresence_CodedStep()
        {
            
        }
    
        [CodedStep(@"New Coded Step")]
        public void checkeventpresence_CodedStep1()
        {
            
        }
    
        [CodedStep(@"New Coded Step")]
        public void checkeventpresence_CodedStep2()
        {
            
        }
    }
}
