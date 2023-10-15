using MotoApp3.Entities;
using MotoApp3.Repositories;

var employeeRepository = new GenericRepository<int>();
employeeRepository.Add(new Employee { FirstName = "Wiktoria" });
employeeRepository.Add(new Employee { FirstName = "Mery" });
employeeRepository.Add(new Employee { FirstName = "Nastia" });
employeeRepository.Save();


