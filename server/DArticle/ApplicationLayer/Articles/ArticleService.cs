using AutoMapper;
using System;
using DEmployee.Helpers.Repository;
using DEmployee.DomainModelLayer.Employees;
using DEmployee.InfrastructureLayer;

namespace DEmployee.ApplicationLayer.Employees
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public Employee Add(Employee employeeDto)
        {
            Employee employee = Employee.Create(employeeDto.Name, employeeDto.Birthday, employeeDto.Description, employeeDto.Gender);
            this.employeeRepository.Add(employee);

            return employee;
        }

        public Employee Remove(Guid employeeId)
        {

            Employee employee = this.employeeRepository.FindById(employeeId);

            this.employeeRepository.Remove(employee);

            return employee;
        }

        public Employee Get(Guid employeeId)
        {
            Employee employee = this.employeeRepository.FindById(employeeId);

            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employeeRepository.GetAll();
        }
        public Employee Update(Guid id, string description)
        {

            Employee employee = this.employeeRepository.FindById(id);

            employee.SetDescription(description);

            return employee;
        }
    }
}
