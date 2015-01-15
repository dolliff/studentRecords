using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace studentRecords
{
    class students
    {
        private ObservableCollection<student> _studentData;

        public students()
        {
            readStudents();
        }

        public ObservableCollection<student> studentData
        {
            get { return _studentData; }
        }

        public void writeStudents()
        {
            XmlWriter writer = XmlWriter.Create("c:\\dave\\students.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("students");

            foreach (student thisStudent in _studentData)
            {
                writer.WriteStartElement("student");
                writer.WriteElementString("firstName", thisStudent.firstName);
                writer.WriteElementString("grade", thisStudent.grade.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        public void readStudents()
        {
            XmlReader reader = XmlReader.Create("C:\\dave\\students.xml");
            _studentData = new ObservableCollection<student>();

            while (reader.Read())
            {
                if (reader.Name == "student")
                {
                    student newStudent = new student();
                    reader.Read();

                    if (reader.Name == "firstName")
                    {
                        reader.Read();
                        newStudent.firstName = reader.Value;
                    }
                    reader.Read();
                    reader.Read();
                    if (reader.Name == "grade")
                    {
                        reader.Read();
                        newStudent.grade = int.Parse(reader.Value);
                    }
                    reader.Read();
                    reader.Read();
                    _studentData.Add(newStudent);
                }
            }
        }
    }
}
