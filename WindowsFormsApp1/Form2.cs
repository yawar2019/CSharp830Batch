using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BOESUM\\SQLEXPRESS;Initial Catalog=test;Integrated Security=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BOESUM\\SQLEXPRESS;Initial Catalog=test;User Id=1211;Password=vvvv");


        public Form2()
        {
            InitializeComponent();
        }

        // private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedIndex == 1) {
        //        //MessageBox.Show(comboBox1.Text +" is no1 in ODI");
        //        // MessageBox.Show(comboBox1.SelectedItem +" is no1 in ODI");
        //        //MessageBox.Show(comboBox1.SelectedText + " is no1 in ODI");
        //     //   MessageBox.Show(comboBox1.SelectedValue + " is no1 in ODI");

        //    }
        //    else
        //    {
        //        MessageBox.Show(comboBox1.Text + " is 2nd in ODI");

        //    }

        // }

        private async void Form2_Load(object sender, EventArgs e)
        {
            ServiceReferenceEmployeeResponse.WebService1SoapClient emp = new  ServiceReferenceEmployeeResponse.WebService1SoapClient();

           

            dataGridView1.DataSource = emp.EmployeeData();



            //  comboBox1.Items.Insert(0, "--Select Country--");


        }

        public async static Task<DataTable> getEmployeeData()
        {
            SqlCommand sqlCommand = new SqlCommand("sp_getEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public async Task<int> SaveEmployeeData()
        {
            if(txtEmpId.Text==null|| txtEmpId.Text==string.Empty)
            {
                txtEmpId.Text ="0";
            }

            if (textBox2.Text == null || textBox2.Text == string.Empty)
            {
                textBox2.Text = "0";
            }

            int? EmpId = Convert.ToInt32(txtEmpId.Text);
            string Name = textBox1.Text;
            int? Salary = Convert.ToInt32(textBox2.Text);

            string StoreprocName = string.Empty;

            if (EmpId > 0)
            {
                StoreprocName = "sp_updateEmployee";
                //update task
            }
            else
            {
                //insert task
                StoreprocName = "sp_saveEmployee";

            }

            SqlCommand cmd = new SqlCommand(StoreprocName,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", Name);
            cmd.Parameters.AddWithValue("@EmpSalary", Salary);
            if (EmpId > 0)
            {
                cmd.Parameters.AddWithValue("@EmpId", EmpId);
            }
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        private async void brnSave_Click(object sender, EventArgs e)
        {
           int i= await SaveEmployeeData();
        
            if(i>0)
            {
                lblmsg.Text = "Successfully Updated Record";
                DataTable dt = await getEmployeeData();

                dataGridView1.DataSource = dt;
            }
        }
    }
}




//ALTER PROCEDURE [dbo].[sp_updateEmployee]
//@EmpId int,
//@EmpName varchar(50),
//@EmpSalary int

//AS
//BEGIN

//Update  [test].[dbo].[tbl_Employee]
//   set 
//      [EmpName]=@EmpName
//      ,[EmpSalary]=@EmpSalary

//  Where [EmpId]=@EmpId

//  END
//ALTER PROCEDURE [dbo].[sp_updateEmployee]
//@EmpId int,
//@EmpName varchar(50),
//@EmpSalary int

//AS
//BEGIN

//Update  [test].[dbo].[tbl_Employee]
//   set 
//      [EmpName]=@EmpName
//      ,[EmpSalary]=@EmpSalary

//  Where [EmpId]=@EmpId

//  END



//Save


//ALTER PROCEDURE [dbo].[sp_saveEmployee]
//@EmpName varchar(50),
//@EmpSalary int

//AS
//BEGIN

//Insert into [test].[dbo].[tbl_Employee] 
// (EmpName,EmpSalary) values
// (@EmpName,@EmpSalary)


//  END
//ALTER PROCEDURE [dbo].[sp_saveEmployee]
//@EmpName varchar(50),
//@EmpSalary int

//AS
//BEGIN

//Insert into [test].[dbo].[tbl_Employee] 
// (EmpName,EmpSalary) values
// (@EmpName,@EmpSalary)


//  END


//Delete



//ALTER PROCEDURE [dbo].[sp_deleteEmployee]
//@EmpId int
//AS
//BEGIN
//DELETE FROM  [test].[dbo].[tbl_Employee] Where [EmpId]=@EmpId
//END
//ALTER PROCEDURE [dbo].[sp_deleteEmployee]
//@EmpId int
//AS
//BEGIN
//DELETE FROM  [test].[dbo].[tbl_Employee] Where [EmpId]=@EmpId
//END



//Get


//ALTER PROCEDURE[dbo].[sp_getEmployee]

//AS
//BEGIN

//SELECT  [EmpId]
//      ,[EmpName]
//      ,[EmpSalary]
//FROM[test].[dbo].[tbl_Employee]


  //END