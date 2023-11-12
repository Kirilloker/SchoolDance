using Microsoft.VisualBasic.ApplicationServices;
using SchoolDance.Class.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDance.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            dataGridView1.DataSource = GetAllUser();
            dataGridView1.DataSource = GetAllUser();



            this.AutoSize = true;
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            //dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // При изменении ячейки
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Изменился данный объект
                Student student = ((List<Student>)dataGridView1.DataSource)[e.RowIndex];

                Console.WriteLine(student.Id);
                DB_API.UpdateStudent(student);
            }
        }

        public static List<Student> GetAllUser()
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    return db.students.ToList();
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }


    }
}
