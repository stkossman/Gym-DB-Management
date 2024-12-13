using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();

            CheckBox[] q1 = { SurveyCheckFirstQa, SurveyCheckFirstQb, SurveyCheckFirstQc };

            foreach (var checkBox in q1)
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    HandleSingleSelection(q1, (CheckBox)sender);
                };
            }

            CheckBox[] q2 = { SurveyCheckSecondQa, SurveyCheckSecondQb, SurveyCheckSecondQc, SurveyCheckSecondQd };

            foreach (var checkBox in q2)
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    HandleSingleSelection(q2, (CheckBox)sender);
                };
            }

            CheckBox[] q3 = { SurveyCheckThirdQa, SurveyCheckThirdQb };

            foreach (var checkBox in q3)
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    HandleSingleSelection(q3, (CheckBox)sender);
                };
            }

            CheckBox[] q4 = { SurveyCheckFourQa, SurveyCheckFourQb, SurveyCheckFourQc, SurveyCheckFourQd };

            foreach (var checkBox in q4)
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    HandleSingleSelection(q4, (CheckBox)sender);
                };
            }

            CheckBox[] q5 = { SurveyCheckFiveQa, SurveyCheckFiveQb, SurveyCheckFiveQc, SurveyCheckFiveQd };

            foreach (var checkBox in q5)
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    HandleSingleSelection(q5, (CheckBox)sender);
                };
            }
        }

        private void HandleSingleSelection(CheckBox[] group, CheckBox selectedCheckBox)
        {
            foreach (var checkBox in group)
            {
                if (checkBox != selectedCheckBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void SurveyBtnSumbit_Click(object sender, EventArgs e)
        {
            string recommendation = GetMembershipRecommendation();
            MessageBox.Show(recommendation, "Membership Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetMembershipRecommendation()
        {
            if (SurveyCheckFirstQa.Checked && SurveyCheckSecondQa.Checked)
            {
                return "We recommend the Basic Membership for beginners focused on general fitness.";
            }
            else if (SurveyCheckFirstQb.Checked && SurveyCheckThirdQb.Checked)
            {
                return "We recommend the Advanced Membership for individuals focusing on strength training.";
            }
            else if (SurveyCheckFirstQc.Checked && SurveyCheckFourQd.Checked)
            {
                return "We recommend the Premium Membership for personalized coaching and advanced features.";
            }
            else if (SurveyCheckFiveQd.Checked)
            {
                return "We recommend the Family Membership for group access and family benefits.";
            }
            else
            {
                return "Based on your responses, we recommend discussing options with our staff to find the best fit.";
            }
        }
    }
}
