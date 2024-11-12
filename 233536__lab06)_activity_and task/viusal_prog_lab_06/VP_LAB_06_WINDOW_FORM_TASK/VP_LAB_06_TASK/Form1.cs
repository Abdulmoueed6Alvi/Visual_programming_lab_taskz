namespace VP_LAB_06_TASK
{
    public partial class Form1 : Form
    {
        public class student
        {
            public string name { get; set; }
            public string fathername { get; set; }
            public string age { get; set; }
            public string classes { get; set; }
            public string gender { get; set; }
        }
        List<student> students = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            student std = new student();
            std.name = textBox1.Text;
            std.fathername = textBox2.Text;
            std.age = textBox3.Text;
            std.classes = textBox4.Text;
            std.gender = textBox5.Text;
            students.Add(std);
            dataGridView1.DataSource= null;
 
            dataGridView1.DataSource = students;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
