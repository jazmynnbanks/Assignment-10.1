using System.Text.Json;
using System.Xml.Serialization;
namespace Assignment_10._1
{
    public partial class Form1 : Form
    {
        Student student;
        string jsonFilePath = @"C:\MSSA Folder\PCAD17-Json.txt";
        string xmlpath = @"C:\MSSA Folder\PCAD17-XML.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.StudentId = Convert.ToInt32(txtID.Text);
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;
            student.GPA = Convert.ToSingle(txtGPA.Text);

            MessageBox.Show("Student Created Successfully!");

        }

        private void btnJSONSer_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonFilePath))
            {
                File.Delete(jsonFilePath);
            }

            string jsonString = JsonSerializer.Serialize(student);
            File.WriteAllText(jsonFilePath, jsonString);
            MessageBox.Show("Student data serialized to JSON successfully!");
        }

        private void btnJSONDES_Click(object sender, EventArgs e)
        {
            FileStream jsonStream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<Student>(jsonStream);
            MessageBox.Show($"Student ID: {obj.StudentId}\nName: {obj.Name}\nAddress: {obj.Address}\nGPA: {obj.GPA}");


        }

        private void btnXMLSER_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }
            FileStream xmlStream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(xmlStream, student);
            xmlStream.Close();
            MessageBox.Show("Student data serialized to XML successfully!");
        }

        private void XMLDES_Click(object sender, EventArgs e)
        {
            FileStream xmlStream = new FileStream(xmlpath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            var obj = xmlSerializer.Deserialize(xmlStream) as Student;
            MessageBox.Show($"Student ID: {obj.StudentId}\nName: {obj.Name}\nAddress: {obj.Address}\nGPA: {obj.GPA}");
            xmlStream.Close();
        }
    }

}

