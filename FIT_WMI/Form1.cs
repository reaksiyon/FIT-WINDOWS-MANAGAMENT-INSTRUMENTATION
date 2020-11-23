using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FIT_WMI
{
    public partial class Form1 : Form
    {

        //globals

        public SqlConnection sCon = new SqlConnection("Data Source=DESKTOP-1D6IJM8\\SQLEXPRESS;Initial Catalog=wmi;Integrated Security=True");

        public String queryText = "";
        public String _rID = "";
        public String _rPASS = "";
      
        public string asset_ID = "";
        public string asset_NAME = "";
        public string asset_IP = "";
        public string asset_PROTOCOL = "";

        public string assetDetail_CPU = "";
        public string assetDetail_MEMORY = "";
        public string assetDetail_DISK = "";
        public string assetDetail_DISK_USAGE = "";
        
        //globals_end




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.MaximizeBox = false;

        }



        public String getLOCAL_WmiInfo() //local
        {
            String result = "Null";
            ManagementScope scope = null;

            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                //options.Username = "username";
                //options.Password = "password";

                scope = new ManagementScope("", options);
                scope.Connect();

                string _wmiLIB = wmiCB.Text.ToString();
                ObjectQuery query = new ObjectQuery("Select * from " + _wmiLIB); // select * 
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection)
                {
                    result = m[queryCB.Text].ToString();
                }

            }
            catch (Exception EX)
            {
                result = "ERR, " + queryCB.Text + " IS NOT FOUND IN " + wmiCB.Text + " CLASS!";

            }

            return result;
        }


        public String getREMOTE_WmiInfo() // remote
        {
            String result = "error???";
            ManagementScope scope = null;

            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                //options.Username = "username";
                //options.Password = "password";

                scope = new ManagementScope("", options);
                scope.Connect();

                string _wmiLIB = wmiCB.Text.ToString();
                ObjectQuery query = new ObjectQuery("Select * from " + _wmiLIB); // select * 
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection)
                {
                    result = m[queryCB.Text].ToString();
                }

            }
            catch (Exception EX)
            {
                result = "ERR, QUERY IS NOT FOUND IN " + wmiCB.Text + " CLASS!";

            }

            return result;
        }


        private void qCB_Click(object sender, EventArgs e)
        {
            queryText = queryCB.Text;
            if (queryCB.Text == "" || wmiCB.Text == "")
            {
                MessageBox.Show("QUERY or WMI LIBRARY cannot be null!", "ERROR!");
            }
            else
            {
                qAnswer.Text = getLOCAL_WmiInfo();

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public void rConnect_Click(object sender, EventArgs e)
        {

            sCon.Open();

            if (sCon.State == ConnectionState.Open)
            {
              
                _rID = rID.Text;
                _rPASS = rPASS.Text;
                

                if (_rID.Contains(";") || _rID.Contains(" ") || _rPASS.Contains(";") || _rPASS.Contains(" ")) // SQL INJECTION FIX
                {
                    _rID = "";
                    _rPASS = "";
                    MessageBox.Show("You cannot use special characters in login page!","Special Character");
                }

                string L_WMI = "Select * from Asset Where Username = '" + _rID.Trim() + "' and Password = '" + _rPASS.Trim() + "'";



                /*   string L_WMI = "Select * from Asset Where Username = @username "
             + "WHERE Password = @password;";


                       SqlCommand sCMD = new SqlCommand(L_WMI, sCon);
                       sCMD.Parameters.Add("@username", SqlDbType.VarChar);
                   sCMD.Parameters["@username"].Value = _rID;

                   sCMD.Parameters.Add("@password", SqlDbType.VarChar);
                   sCMD.Parameters["@password"].Value = _rPASS;

                   */



                SqlDataAdapter sda = new SqlDataAdapter(L_WMI, sCon);
                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);


                SqlDataReader reader = null;

                if (dtbl.Rows.Count == 1) //if login success
                {
                    

                    login_hide(); //hide login ui

                    //--------------------ASSET------------------------- 
                    SqlCommand sCMD = new SqlCommand("Select * from Asset Where Username = '" + _rID.Trim() + "' and Password = '" + _rPASS.Trim() + "'", sCon);
                    reader = sCMD.ExecuteReader();

                    while (reader.Read())
                    {
                        asset_ID = reader["id"].ToString();
                        asset_NAME = reader["Name"].ToString();
                        asset_IP = reader["IP"].ToString();
                        asset_PROTOCOL = reader["Protocol"].ToString();
                    }
                    //-------------------------------------------------- 
                    rName.Text = asset_NAME;
                    rIP.Text = asset_IP;
                    rProtocol.Text = asset_PROTOCOL;
                    reader.Close();


                    //--------------------ASSET_DETAIL------------------ 
                    SqlCommand cmdASSETDETAIL = new SqlCommand("Select * from Asset_Detail Where aid = '" + asset_ID + "'", sCon);
                    reader = cmdASSETDETAIL.ExecuteReader();

                    while (reader.Read())
                    {
                        assetDetail_CPU = reader["CPU"].ToString();
                        assetDetail_MEMORY = reader["Memory"].ToString();
                        assetDetail_DISK = reader["Disk"].ToString();
                        assetDetail_DISK_USAGE = reader["Disk Usage"].ToString();
                    }
                    reader.Close();
                    //-------------------------------------------------- 

                    //--------------------ALARM------------------------- 
                    AlarmDataGridView.DataSource = GetAlarmData();
                    //--------------------------------------------------
                    // rA_DATE.Text = alarm_DATETIME;
                    // rA_DETAIL.Text = alarm_DETAIL;

                    //--------------------TRANSACTION------------------- 
                    TransactiondataGridView.DataSource = GetTransactionData();
                    //--------------------------------------------------



                }
                else // if login denied
                {
                    MessageBox.Show("Username or password is wrong!", "ERROR");
                }

                sCon.Close();
            }
            else
            {
                MessageBox.Show("DATABASE CONNECTION ERROR!", "WARNING");
            }


           

        }

        public DataTable GetAlarmData()
        {
            DataTable dtAlarm = new DataTable();

            using (SqlCommand alarmCMD = new SqlCommand("Select aid, alarm_datetime, alarm_detail from [Alarm] Where asset = '" + asset_ID + "'", sCon))
            {
                
                SqlDataReader reader = alarmCMD.ExecuteReader();
                dtAlarm.Load(reader);
                reader.Close();
            }
            return dtAlarm;
        }



        public DataTable GetTransactionData()
        {
            DataTable dtTransaction = new DataTable();

            using (SqlCommand transactionCMD = new SqlCommand("Select tid, discovery_time, Status, CPU, Memory, Disk, Disk Usage from [Transaction] Where Asset = '" + asset_ID + "'", sCon))
            {

                SqlDataReader reader = transactionCMD.ExecuteReader();
                dtTransaction.Load(reader);
                reader.Close();
            }
            return dtTransaction;
        }

        public void login_hide()
        {
            ridlabel.Visible = false;
            rID.Visible = false;
            rpasslabel.Visible = false;
            rPASS.Visible = false;
            rConnect.Visible = false;

            IPLabel.Visible = true;
            nameLabel.Visible = true;
            ProtocolLabel.Visible = true;
            rIP.Visible = true;
            rName.Visible = true;
            rProtocol.Visible = true;

            rqtext.Visible = true;
            rQuery.Visible = true;
            rCheck.Visible = true;

            disconnectButton.Visible = true;
        }

        public void disconnect_show()
        {
            ridlabel.Visible = true;
            rID.Visible = true;
            rpasslabel.Visible = true;
            rPASS.Visible = true;
            rConnect.Visible = true;

            IPLabel.Visible = false;
            nameLabel.Visible = false;
            ProtocolLabel.Visible = false;
            rIP.Visible = false;
            rName.Visible = false;
            rProtocol.Visible = false;

            rqtext.Visible = false;
            rQuery.Visible = false;
            rCheck.Visible = false;

            rResult.Text = "-";

            AlarmDataGridView.DataSource = "null";
            AlarmDataGridView.Refresh();

            TransactiondataGridView.DataSource = "null";
            TransactiondataGridView.Refresh();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void queryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void wmiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryCB.Items.Clear();
            queryCB.Text = "";

            StreamReader sr = new StreamReader(Application.StartupPath + "\\WIN32CLASS\\" + wmiCB.Text + ".txt");
            string temp = sr.ReadToEnd();
            string[] temp2 = temp.Split('\n');
            foreach (string s in temp2)
            {

                string item = s.Remove(s.Length - 1);
                queryCB.Items.Add(item);

            }
           

            sr.Close();

        
          

            //  queryCB.Items.Add
        }

        private void rQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rCheck_Click(object sender, EventArgs e)
        {
            if (rQuery.Text == "CPU")
                rResult.Text = assetDetail_CPU;
            if (rQuery.Text == "MEMORY")
                rResult.Text = assetDetail_MEMORY;
            if (rQuery.Text == "DISK")
                rResult.Text = assetDetail_DISK;
            if (rQuery.Text == "DISK_USAGE")
                rResult.Text = assetDetail_DISK_USAGE;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        


        private void disconnect_Click(object sender, EventArgs e)
        {
            asset_ID = "";
            rID.Text = "";
            rPASS.Text = "";
            disconnect_show();
            disconnectButton.Visible = false;
        }


        //-------------------------------------- UNIT TESTS ---------------------------------

        public bool ConnectTest()
        {
           // sCon.Open();
            string L_WMI = "Select * from Asset Where Username = '" + _rID.Trim() + "' and Password = '" + _rPASS.Trim() + "'";


            SqlDataAdapter sda = new SqlDataAdapter(L_WMI, sCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);


            

            if (dtbl.Rows.Count == 1) //if login success
            {
                return true;
            }

                return false;
        }

        public bool addAlarm()
        {
            sCon.Open();

            SqlDataReader reader = null;

            
            SqlCommand sCMD = new SqlCommand("Select * from Asset Where Username = '" + _rID.Trim() + "'", sCon);
            reader = sCMD.ExecuteReader();

            while (reader.Read())
            {
                asset_ID = reader["id"].ToString();
            }
            reader.Close();

            //  SqlCommand alarmCMD = new SqlCommand("Select aid, alarm_datetime, alarm_detail from [Alarm] Where asset = '" + asset_ID + "'", sCon);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sCon;
            cmd.CommandText = "INSERT INTO [Alarm] (asset, alarm_datetime, alarm_detail) VALUES (@asset,@a_dtime,@a_d)";

            
            cmd.Parameters.AddWithValue("@asset", asset_ID);
            cmd.Parameters.AddWithValue("@a_dtime", DateTime.Now.ToString("yyyy-MM-dd h:mm:ss"));
            cmd.Parameters.AddWithValue("@a_d", "Wrong Password");

            cmd.ExecuteNonQuery();
            sCon.Close();

            return true;

        }

        public bool addTransaction()
        {
            sCon.Open();

            SqlDataReader reader = null;


            SqlCommand sCMD = new SqlCommand("Select * from Asset Where Username = '" + _rID.Trim() + "' and Password = '" + _rPASS.Trim() + "'", sCon);
            reader = sCMD.ExecuteReader();

            while (reader.Read())
            {
                asset_ID = reader["id"].ToString();
            }
            reader.Close();
            reader = null;

            SqlCommand cmdASSETDETAIL = new SqlCommand("Select * from Asset_Detail Where aid = '" + asset_ID + "'", sCon);
            reader = cmdASSETDETAIL.ExecuteReader();

            
            while (reader.Read())
            {
                assetDetail_CPU = reader["CPU"].ToString();
                assetDetail_MEMORY = reader["Memory"].ToString();
                assetDetail_DISK = reader["Disk"].ToString();
                assetDetail_DISK_USAGE = reader["Disk Usage"].ToString();
            }
            reader.Close();

            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sCon;
            cmd.CommandText = "INSERT INTO [Transaction] (discovery_Time, Asset, Status, CPU, Memory, Disk, [Disk Usage]) VALUES (@discovery_Time, @Asset, @Status, @CPU, @Memory, @Disk, @DiskUsage)";

            cmd.Parameters.AddWithValue("@discovery_Time", DateTime.Now.ToString("yyyy-MM-dd h:mm:ss"));
            cmd.Parameters.AddWithValue("@Asset", asset_ID);
            cmd.Parameters.AddWithValue("@Status","Success");
            cmd.Parameters.AddWithValue("@CPU", assetDetail_CPU);
            cmd.Parameters.AddWithValue("@Memory", assetDetail_MEMORY);
            cmd.Parameters.AddWithValue("@Disk", assetDetail_DISK);
            cmd.Parameters.AddWithValue("@DiskUsage", assetDetail_DISK_USAGE);

            cmd.ExecuteNonQuery();
            sCon.Close();

            return true;

        }






    }
}
