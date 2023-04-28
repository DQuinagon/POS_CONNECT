using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_CONNECT.Properties;

namespace POS_CONNECT.Interface
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

       public string frmIsActive = null;
        //menu bar 
        #region
        private void barReports_Click(object sender, EventArgs e)
        {
            activeAudit();
            frmIsActive = "reports";
            displayContainer();
        }

        private void barLogs_Click(object sender, EventArgs e)
        {
            activeAudit();
            frmIsActive = "logs";
            displayContainer();
        }

        private void barSync_Click(object sender, EventArgs e)
        {
            activeAudit();
            frmIsActive = "sync";
            displayContainer();
        }

        private void barConnection_Click(object sender, EventArgs e)
        {
            activeConfig();
            frmIsActive = "connection";
            displayContainer();
        }

        private void barGeneral_Click(object sender, EventArgs e)
        {
            activeConfig();
            frmIsActive = "general";
            displayContainer();
        }

        private void barMapping_Click(object sender, EventArgs e)
        {
            activeConfig();
            frmIsActive = "mapping";
            displayContainer();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeHelp();
            frmIsActive = "license";
            displayContainer();
        }

        private void barManual_Click(object sender, EventArgs e)
        {
            activeHelp();
            frmIsActive = "manual";
            displayContainer();
        }

        private void barAbout_Click(object sender, EventArgs e)
        {
            activeHelp();
            frmIsActive = "about";
            displayContainer();
        }

        private void barDashboard_Click(object sender, EventArgs e)
        {
            activeDashboard();
            frmIsActive = "dashboard";
            displayContainer();

        }

        //function for set active menu bar
        public void activeDashboard()
        {
            //activate bar dashboard
            barDashboard.ForeColor = Color.FromArgb(5, 51, 99);
            barDashboard.Image = global::POS_CONNECT.Properties.Resources.dashboard_active;
            barDashboard.BackgroundImage = global::POS_CONNECT.Properties.Resources.barActive;
            barDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //deactivate other button
            barAudit.ForeColor = Color.Black;
            barAudit.Image = global::POS_CONNECT.Properties.Resources.audit_inactive;
            barAudit.BackgroundImage = null;
            barConfig.ForeColor = Color.Black;
            barConfig.Image = global::POS_CONNECT.Properties.Resources.config_inactive;
            barConfig.BackgroundImage = null;
            barHelp.ForeColor = Color.Black;
            barHelp.Image = global::POS_CONNECT.Properties.Resources.help_inactive;
            barHelp.BackgroundImage = null;

            barHelp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barAudit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void activeHelp()
        {
            //activate help
            barHelp.ForeColor = Color.FromArgb(5, 51, 99);
            barHelp.Image = global::POS_CONNECT.Properties.Resources.help_active;
            barHelp.BackgroundImage = global::POS_CONNECT.Properties.Resources.barActive;
            barHelp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //deactivate other button
            barAudit.ForeColor = Color.Black;
            barAudit.Image = global::POS_CONNECT.Properties.Resources.audit_inactive;
            barAudit.BackgroundImage = null;
            barConfig.ForeColor = Color.Black;
            barConfig.Image = global::POS_CONNECT.Properties.Resources.config_inactive;
            barConfig.BackgroundImage = null;
            barDashboard.ForeColor = Color.Black;
            barDashboard.Image = global::POS_CONNECT.Properties.Resources.dashboard_inactive;
            barDashboard.BackgroundImage = null;

            barDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barAudit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void activeConfig()
        {
            //activate config
            barConfig.ForeColor = Color.FromArgb(5, 51, 99);
            barConfig.Image = global::POS_CONNECT.Properties.Resources.config_active;
            barConfig.BackgroundImage = global::POS_CONNECT.Properties.Resources.barActive;
            barConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //deactivate other button
            barAudit.ForeColor = Color.Black;
            barAudit.Image = global::POS_CONNECT.Properties.Resources.audit_inactive;
            barAudit.BackgroundImage = null;
            barHelp.ForeColor = Color.Black;
            barHelp.Image = global::POS_CONNECT.Properties.Resources.help_inactive;
            barHelp.BackgroundImage = null;
            barDashboard.ForeColor = Color.Black;
            barDashboard.Image = global::POS_CONNECT.Properties.Resources.dashboard_inactive;
            barDashboard.BackgroundImage = null;

            barDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barHelp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barAudit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void activeAudit()
        {
            barAudit.ForeColor = Color.FromArgb(5, 51, 99);
            barAudit.Image = global::POS_CONNECT.Properties.Resources.audit_active;
            barAudit.BackgroundImage = global::POS_CONNECT.Properties.Resources.barActive;
            barAudit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //deactivate other button
            barConfig.ForeColor = Color.Black;
            barConfig.Image = global::POS_CONNECT.Properties.Resources.config_inactive;
            barConfig.BackgroundImage = null;
            barHelp.ForeColor = Color.Black;
            barHelp.Image = global::POS_CONNECT.Properties.Resources.help_inactive;
            barHelp.BackgroundImage = null;
            barDashboard.ForeColor = Color.Black;
            barDashboard.Image = global::POS_CONNECT.Properties.Resources.dashboard_inactive;
            barDashboard.BackgroundImage = null;

            barDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barHelp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        #endregion

        public void displayContainer()
        {
            if (frmIsActive == "dashboard")
            {
                dashboard frmdashboard = new dashboard();
                frmdashboard.TopLevel = false;
                container.Controls.Add(frmdashboard);
                frmdashboard.BringToFront();
                frmdashboard.Show();
            }
            else if (frmIsActive == "reports")
            {

            }
            else if (frmIsActive == "sync")
            {

            }
            else if (frmIsActive == "logs")
            {

            }
            else if (frmIsActive == "general")
            {

            }
            else if (frmIsActive == "connection")
            {

            }
            else if (frmIsActive == "mapping")
            {

            }
            else if (frmIsActive == "license")
            {

            }
            else if(frmIsActive == "manual")
            {

            }else if(frmIsActive == "about")
            {

            }
            
        }
        private void menu_Resize(object sender, EventArgs e)
        {
            container.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);

            displayContainer();
        }
    }


}
