public enum Course
{
    Django,
    OODP,
    Project
}


public class StudentEnrollmentSystem
{
    public Dictionary<Course, Queue<Student>> waitlist;
    public Dictionary<Course, List<Student>> enrolledStudents;

    public StudentEnrollmentSystem()
    {
        waitlist = new Dictionary<Course, Queue<Student>>
        {
            {Course.Django, new Queue<Student>()},
            {Course.OODP, new Queue<Student>()},
            {Course.Project, new Queue<Student>()}
        };

        enrolledStudents = new Dictionary<Course, List<Student>>
        {
            {Course.Django, new List<Student>()},
            {Course.OODP, new List<Student>()},
            {Course.Project, new List<Student>()}
        };
    }

    public void EnrollStudent(string name, string id, Course course)
    {
        Student stu = new(id, name);
        waitlist[course].Enqueue(stu);
    }

    public string CheckStatus(string id)
    {
        foreach (var pair in waitlist) 
        {
            var test = pair.Value.Where(x => x.ID == id).ToList();
            if (!(test.Count == 0))
            {
                return $"Student with {test[0].ID} is in the waitlist for {pair.Key} course.";
                
            }
        }

        foreach (var pair in enrolledStudents)
        {
            var test = pair.Value.Where(x => x.ID == id).ToList();
            if (!(test.Count == 0))
            {
                return $"Student with {test[0].ID} enrolled in {pair.Key} course.";
            }
        }

        return $"Student with ID {id} not found.";
    }

    public void EnrollNextStudent(Course course)
    {
        Student enrolling = waitlist[course].Dequeue();
        enrolledStudents[course].Add(enrolling);
    }

    public List<Student> GetEnrolledStudentsByCourse(Course course)
    {
        return enrolledStudents[course];
    }
}
