using System;

namespace EmployeeData
{

    class Employee
    {

        public string _firstName;
        public string _lastName;
        public double _monthlySalary;

        //creating getter and setter properties

        public string FirstName
        {

            get => _firstName;
            set => _firstName = value;

        }
        public string LastName
        {

            get => _lastName;
            set => _lastName = value;

        }

        public double MonthlySalary
        {

            get => _monthlySalary;

            set
            {

                if (value < 0)
                    value = 0.0;

                _monthlySalary = value;

            }
        }

        //constructor
        public Employee(string firstName, string lastName, double monthlySalary)
        {

            _firstName = firstName ?? throw new Exception();
            _lastName = lastName ?? throw new Exception();
            _monthlySalary = monthlySalary;


        }

        //creating overridable method giveRaise()...
        public virtual void getRaise(double raise)
        {

            _monthlySalary += _monthlySalary * (raise / 100);

        }

        //overriding ToString from object class

        public override string ToString()
        {
            return $"Employee Name : {_firstName} {_lastName}  \nMonthly Salary : Rs.{_monthlySalary}";


        }


    }


    class PermanentEmployee : Employee
    {

        private double _hra;
        private double _da;
        private double _pf;

        string _joiningDate;
        string _retirementDate;

        public PermanentEmployee(string firstName, string lastName, double monthlySalary, string joiningDate, string retirementDate) : base(firstName, lastName, monthlySalary)
        {
            _da = base._monthlySalary * 0.12;
            _hra = (_da + _monthlySalary) * 0.05;
            _pf = _da;
            _joiningDate = joiningDate;
            _retirementDate = retirementDate;

        }

        //setting only read only properties
        public double HRA
        {

            get => _hra;
        }
        public double DA
        {

            get => _da;
        }
        public double PF
        {

            get => _pf;
        }

        public override void getRaise(double raise)
        {
            base.getRaise(raise);
            _monthlySalary += _hra + _da;

        }

        public override string ToString()
        {
            return $"{base.ToString()}\nJoining date: {_joiningDate}\nRetirement date:{_retirementDate}";
        }

    }
}