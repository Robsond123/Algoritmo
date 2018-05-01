using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    class Teste
    {
        public List<Employee> employees;
        public List<Companny> compannies;

        public  void InitialValues()
        {
            employees = new List<Employee>();
            compannies = new List<Companny>();

            Employee e = new Employee();
            e.Name = "Olavo";
            e.Address = "Rua Catharina Braun, 105 - Agua Verde, Blumenau";
            e.OfficeHour = 8;
            employees.Add(e);

            Companny c1 = new Companny();
            c1.Name = "Cooper";
            c1.Address = "R.Benjamin Constant, 2597 - Vila Nova, Blumenau – SC";
            c1.StartTimeAttendance = 8;
            c1.EndTimeAttendance = 22;
            c1.TimeSpentVisiting = 2;
            compannies.Add(c1);

            Companny c2 = new Companny();
            c2.Name = "Hipermercado Big";
            c2.Address = "R.Sete de Setembro, 2883 - Velha, Blumenau – SC";
            c2.StartTimeAttendance = 8;
            c2.EndTimeAttendance = 22;
            c2.TimeSpentVisiting = 1.30f;
            compannies.Add(c2);

            Companny c3 = new Companny();
            c3.Name = "Supermercado Angeloni";
            c3.Address = "R.Humberto de Campos, 77 - Velha, Blumenau – SC";
            c3.StartTimeAttendance = 8;
            c3.EndTimeAttendance = 22;
            c3.TimeSpentVisiting = 2;
            compannies.Add(c3);

            Companny c4 = new Companny();
            c4.Name = " Bistek Supermercado";
            c4.Address = "R.Amazonas, 466 - Garcia, Blumenau – SC";
            c4.StartTimeAttendance = 8;
            c4.EndTimeAttendance = 22;
            c4.TimeSpentVisiting = 2;
            compannies.Add(c4);

        }

        public void DestinyPopulation(String StartAddress, String EndAddress)
        {
            for (int i = 0; i < compannies.Count; i++)
            {
                //Destiny destiny = new Destiny();
                //destiny.StratAnddress(StartAddress);


            }

        }


        public  int DistanceCalculation(string StartAddress, string EndAddress)
        {
            if (StartAddress.Equals("Rua Catharina Braun, 105 - Agua Verde, Blumenau") && EndAddress.Equals("R.Benjamin Constant, 2597 - Vila Nova, Blumenau – SC"))
            {
                return 4;
            }

            if (StartAddress.Equals("Rua Catharina Braun, 105 - Agua Verde, Blumenau") && EndAddress.Equals("R.Sete de Setembro, 2883 - Velha, Blumenau – SC"))
            {
                return 7;
            }
            if (StartAddress.Equals("Rua Catharina Braun, 105 - Agua Verde, Blumenau") && EndAddress.Equals("R.Humberto de Campos, 77 - Velha, Blumenau – SC"))
            {
                return 7;
            }
            if (StartAddress.Equals("Rua Catharina Braun, 105 - Agua Verde, Blumenau") && EndAddress.Equals("R.Amazonas, 466 - Garcia, Blumenau – SC"))
            {
                return 12;
            }
            if (StartAddress.Equals("R.Benjamin Constant, 2597 - Vila Nova, Blumenau – SC") && EndAddress.Equals("R.Sete de Setembro, 2883 - Velha, Blumenau – SC"))
            {
                return 5;
            }
            if (StartAddress.Equals("R.Benjamin Constant, 2597 - Vila Nova, Blumenau – SC") && EndAddress.Equals("R.Humberto de Campos, 77 - Velha, Blumenau – SC"))
            {
                return 5;
            }
            if (StartAddress.Equals("R.Benjamin Constant, 2597 - Vila Nova, Blumenau – SC") && EndAddress.Equals("R.Amazonas, 466 - Garcia, Blumenau – SC"))
            {
                return 11;
            }
            if (StartAddress.Equals("R.Sete de Setembro, 2883 - Velha, Blumenau – SC") && EndAddress.Equals("R.Humberto de Campos, 77 - Velha, Blumenau – SC"))
            {
                return 1;
            }
            if (StartAddress.Equals("R.Sete de Setembro, 2883 - Velha, Blumenau – SC") && EndAddress.Equals("R.Amazonas, 466 - Garcia, Blumenau – SC"))
            {
                return 7;
            }

            return 0;
        }
        
    }

    class Routes
    {
        public string AnddressVisit;

    }

    class Destiny
    {
        public String StratAnddress;
        public String EndAnddress;
        public float TimeOfTravel;
    }

    class Employee
    {
        public String Name;
        public String Address;
        public float OfficeHour;

    }

    class Companny
    {
        public String Name;
        public String Address;
        public float StartTimeAttendance;
        public float EndTimeAttendance;
        public float TimeSpentVisiting;
    }


}
