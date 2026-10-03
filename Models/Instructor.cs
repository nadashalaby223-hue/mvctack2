namespace mvctack2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Imag { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int Dept_id { get; set; }
        public int Crs_id { get; set; }
    }
}