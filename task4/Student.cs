namespace StudentManagement {
    public class Student
    {
        public string Name { get; set; }
        public double  Grade { get; set; }
        public int Age { get; set; }
    

        public Student(string name,double grade,int age){
            this.Name = name;
            this.Grade = grade;
            this.Age = age;
        }
    }
}