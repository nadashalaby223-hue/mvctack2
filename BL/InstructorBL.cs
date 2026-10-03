using mvctack2.Models;

namespace mvctack2.BL
{
    public class InstructorBL
    {
        public List<Instructor> GetAllInstructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Ahmed", Imag = "ahmed.jpg", Salary = 8000, Address = "Cairo", Dept_id = 1, Crs_id = 1 },
                new Instructor { Id = 2, Name = "Sara", Imag = "sara.jpg", Salary = 9000, Address = "Giza", Dept_id = 2, Crs_id = 2 },
                new Instructor { Id = 3, Name = "Mona", Imag = "mona.jpg", Salary = 7500, Address = "Alexandria", Dept_id = 1, Crs_id = 3 }
            };
            return instructors;
        }

        public Instructor? GetInstructorById(int id)
        {
            return GetAllInstructors().FirstOrDefault(i => i.Id == id);
        }
    }
}