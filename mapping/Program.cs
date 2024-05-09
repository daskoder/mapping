using AutoMapper;

namespace mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            employee emp = new employee();

            emp.Id = 11;
            emp.Name = "name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            //mapping algab
            //data transfor object
            employeeDto dto = new employeeDto();    
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id+" "+dto.Name+" "+ dto.Title+" "+dto.Description);
            Console.WriteLine("----------------[nyyd hakkab AutoMapper]------------------------");

            //tegie ja täitsime andmetega employee
            employee Employee = new employee
            {
                Id = 123,
            Name = "name123",
            Title = "Title123",
            Description = "Desc123",
        };
            var mapper = Program.InitializeAutoMapper();

            var empdto2 = mapper.Map<employee, employeeDto>(Employee);

            Console.WriteLine(empdto2.Id + " " + empdto2.Name + " " + empdto2.Title + " " + empdto2.Description);

            //Andmete teiseldamine
        }
        //Mapper on Automapper nugetist saadud class
        public static Mapper InitializeAutoMapper()
        {
            //anna kõik mappi seadistused
            var config = new MapperConfiguration(cfg =>
            {
                //mappime Employee ja Employeedto classid mavahel ära
                cfg.CreateMap<employee,employeeDto>();
            });
            //loob mappimise instantsi mapperist ja returnib selle
            var mapper = new Mapper(config);    
            return mapper;
        }
    }
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
    // dto - data transfer object
    public class employeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
