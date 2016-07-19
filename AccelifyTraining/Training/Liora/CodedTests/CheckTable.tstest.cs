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

    public class CheckTable : BaseWebAiiTest
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
        
        // Add your test methods here...
    
        [CodedStep(@"Check Partial Filter New")]
        public void CheckPartialFilterNew_CodedStep()
        {
                        
                        HtmlTable table1 = Find.ByExpression<HtmlTable>("tagname=table", "role=grid");
                        int r = table1.Rows.Count;
                       // object myData = GetExtractedValue("letters");
                       // string letters = Convert.ToString(myData);
                        object myData = Data["Let"];
                        Log.WriteLine("Current Let is "+myData);
                        string letters = Convert.ToString(myData);
                        letters = letters.ToUpper();
                        Log.WriteLine("Current number of rows is "+r);
                     for (int i = 1; i < r; i++)
                    {
                        HtmlTableRow row = table1.Rows[i];
                        //ToDo change cell index to 2 for last name checking
                        HtmlTableCell cell = row.Cells[2];
                        string fullname = cell.InnerText;
                        Log.WriteLine("Student full name is "+fullname);
                        string[] name = fullname.Split(',');
                        string FirstName = name[1];
                        FirstName = FirstName.Trim();
                        string LastName = name[0];
                        int rownumberh = i+1;
                        Log.WriteLine("Student first name in row number "+rownumberh+" is "+FirstName);
                        Log.WriteLine("Student last name in row number "+rownumberh+" is "+LastName);
                        //Assert.IsTrue(FirstName.Contains(letters));
                        Assert.IsTrue(FirstName.StartsWith(letters));
                    }
        }
    }
}
