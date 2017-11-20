using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                prevEndCal.SelectedDate = DateTime.Now.Date;
                newStartCal.SelectedDate = DateTime.Now.Date.AddDays(14);
                newEndCal.SelectedDate = DateTime.Now.Date.AddDays(21);
                newStartCal.VisibleDate = newStartCal.SelectedDate;
                newEndCal.VisibleDate = newEndCal.SelectedDate;
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            //ensure spy name and assignment name are entered and return error message if not
            if (codeNameTextBox.Text == "" || assignmentTextBox.Text == "")
            {
                string errorMsg = "";
                if (codeNameTextBox.Text == "")
                {
                    if (assignmentTextBox.Text == "")
                    {
                        msgLabel.Text = "You must specify a spy name and an assignment name.";
                    }
                    else
                    {
                        msgLabel.Text = "You must specify a spy name.";
                    }
  
                }
                else
                {
                    msgLabel.Text = "You must specify an assignment name.";
                }

            }
            //ensure 14-day window between assignments, return error message if not, reset start date
            else if (newStartCal.SelectedDate.Subtract(prevEndCal.SelectedDate).Days < 14)
            {
                msgLabel.Text = "Spy must have 14 days between end of previous assignment and start of new assignment.";
                newStartCal.SelectedDate = DateTime.Now.Date.AddDays(14);
                newStartCal.VisibleDate = newStartCal.SelectedDate;

            }
            else
            //calculate budget and display to user
            {
                int budget = newEndCal.SelectedDate.Subtract(newStartCal.SelectedDate).Days * 500;
                budget += (newEndCal.SelectedDate.Subtract(newStartCal.SelectedDate).Days > 21) ? 1000 : 0;
                msgLabel.Text = string.Format("Spy Budget for <b>{0}</b> on <b>{1}</b>: {2:C}", codeNameTextBox.Text, assignmentTextBox.Text, budget);
            }
        }
    }
}