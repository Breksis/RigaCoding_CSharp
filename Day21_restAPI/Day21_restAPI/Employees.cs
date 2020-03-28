using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Day21_restAPI
{
    class Employees
    {
        public String id;
        public String employee_name;
        public String employee_salary;
        public String employee_age;
        public String profile_image; 

        public Employees(String id, String employee_name, String employee_salary, String employee_age, String profile_image)
        {
            this.id = id;
            this.employee_name = employee_name;
            this.employee_salary = employee_salary;
            this.employee_age = employee_age;
            this.profile_image = profile_image;
        }
    }
}
