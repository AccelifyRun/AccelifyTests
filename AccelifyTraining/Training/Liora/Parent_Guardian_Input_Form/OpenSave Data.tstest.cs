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

    public class OpenSave_Data : BaseWebAiiTest
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
        // Add your test methods here...
        
        public static DateTime GetRandomDate(DateTime from, DateTime to)
         {
            var range = to - from;

            var randTimeSpan = new System.TimeSpan((long)(rnd.NextDouble() * range.Ticks)); 

            return from + randTimeSpan;
          }
         
        [CodedStep(@"Generate random date1")]
        public void Fill_Parent_Guardian_RandomDay1_CodedStep()
        {
            String date = GetRandomDate(DateTime.Today,new DateTime(2017, 1, 1)).ToString("MM/dd/yyyy");
            SetExtractedValue("RandomDate",date);
                        
        }
    }
}
