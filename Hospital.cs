using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    public class Hospital
    {
       

        List<Doctor> Doctors { get; set; }
        List<Staff> staffs { get; set; }
        List<Patient> patients { get; set; }
        List<Medicine> medicines { get; set; }
        List<Bed> beds { get; set; }
        List<Labratory> labratorys { get; set; }


        public Hospital()
        {
            Doctors = new List<Doctor>();
            Doctor doctor1 = new Doctor();
            doctor1.Id = 24;
            doctor1.Name = "DR.Bikash";
            doctor1.Address = "Kolkata";
            doctor1.Age = 21;
            doctor1.Gender = "Male";
            doctor1.Room = 201;
            doctor1.Visit_cost = 2000;

            Doctor doctor2 = new Doctor();
           doctor2.Id = 27;
           doctor2.Name = "DR,Bibek";
           doctor2.Address = "Kolkata";
           doctor2.Age = 28;
           doctor2.Gender = "Male";
           doctor2.Room = 205;
           doctor2.Visit_cost = 500;

            Doctor doctor3 = new Doctor();
            doctor3.Id = 78;
            doctor3.Name = "DR.totan";
            doctor3.Address = "moyna";
            doctor3.Age = 15;
            doctor3.Gender = "Male";
            doctor3.Room = 277;
            doctor3.Visit_cost = 4500;




            Doctors.Add(doctor1);
            Doctors.Add(doctor2);
            Doctors.Add(doctor3);

            staffs = new List<Staff>();
            Staff staff1 = new Staff();
            staff1.Id = 4;
            staff1.Name = "sumana";
            staff1.Room = 202 ;
            staff1.Age = 25;
            staff1.Gender ="femal" ;

            Staff staff2 = new Staff();
            staff2.Id = 7;
            staff2.Name = "roni";
            staff2.Room = 222;
            staff2.Age = 45;
            staff2.Gender = "male";

            Staff staff3 = new Staff();
            staff3.Id = 1;
            staff3.Name = "somu";
            staff3.Room = 122;
            staff3.Age = 25;
            staff3.Gender = "female";

            staffs.Add(staff1);
            staffs.Add(staff2);
            staffs.Add(staff3);


            patients = new List<Patient>();
            Patient patient1 = new Patient();
            patient1.Id = 2;
            patient1.Name = "sudip";
            patient1.Address = "Tamluk";
            patient1.Age = 31;
            patient1.Gender = "Male";
            patient1.Blood_group = "B+";

            Patient patient2 = new Patient();
            patient2.Id = 3;
            patient2.Name = "Mohan";
            patient2.Address = "Tamluk";
            patient2.Age = 50;
            patient2.Gender = "Male";
            patient2.Blood_group = "AB";

            Patient patient3 = new Patient();
            patient3.Id = 3;
            patient3.Name = "Tania";
            patient3.Address = "Moyna";
            patient3.Age = 55;
            patient3.Gender = "femal";
            patient3.Blood_group = "AB-";


            patients.Add(patient1);
            patients.Add(patient2);
            patients.Add(patient3);

            medicines= new List<Medicine>();
            Medicine medicine1 = new Medicine();
            medicine1.Medicine_name = "A";
            medicine1.Medicine_cost = 100;
            medicine1.Count = 60;

            medicines = new List<Medicine>();
            Medicine medicine2 = new Medicine();
            medicine2.Medicine_name = "KL";
            medicine2.Medicine_cost = 10;
            medicine2.Count = 770;

            medicines = new List<Medicine>();
            Medicine medicine3 = new Medicine();
            medicine3.Medicine_name = "XV";
            medicine3.Medicine_cost = 500;
            medicine3.Count = 64;

            medicines.Add(medicine1);
            medicines.Add(medicine2);
            medicines.Add(medicine3);

            labratorys= new List<Labratory>();
            Labratory labratory1 = new Labratory();
            labratory1.Instrumental_name = "x-ray";
            labratory1.Cost = 800;

            Labratory labratory2 = new Labratory();
            labratory2.Instrumental_name = "ct-scan";
            labratory2.Cost = 1800;

            Labratory labratory3 = new Labratory();
            labratory3.Instrumental_name = "blood ";
            labratory3.Cost = 200;

            Labratory labratory4 = new Labratory();
            labratory4.Instrumental_name = "rj";
            labratory4.Cost = 400;

            labratorys.Add(labratory1);
            labratorys.Add(labratory2);
            labratorys.Add(labratory3);
            labratorys.Add(labratory4);








        }
        public void  Add_doctor( Doctor  doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine("doctor add succesfully");



        }
        public void Cheek_doctorlist()
            
        {
            Console.WriteLine("Id \t\t" +   "Name\t\t\t" +    "Address\t\t"  +       "Age\t\t" +      "Gender\t\t"+      "Room\t\t"+         "Visitcost\t\t" );
            for(int i = 0; i < Doctors.Count; i++)
            {
             Console.WriteLine( Doctors[i].Id+"\t\t" +  Doctors[i].Name +"\t\t" +  Doctors[i].Address + "\t\t" +   Doctors[i].Age + "\t\t"+  Doctors[i].Gender + "\t\t"+  Doctors[i].Room +"\t\t"+  Doctors[i].Visit_cost);
            }

        }



        public void Add_Staff(Staff staff)
        {
            staffs.Add(staff);
            Console.WriteLine("staff add succesfully");


        }
        public void Cheek_Stafflist()
        {
            Console.WriteLine("Id \t\t" + "Name\t\t"  + "Age\t\t" + "Gender\t\t" + "Room\t\t" );
            for (int i = 0; i < staffs.Count; i++)
            {
                Console.WriteLine(staffs[i].Id + "\t\t" + staffs[i].Name +  "\t\t" + staffs[i].Age + "\t\t" + staffs[i].Gender + "\t\t" + staffs[i].Room );
            }

        }






        public void Add_patient(Patient patient)
        {
            Bed bed = new Bed();



            if (patients.Count == bed.total_bed)
            {
                Console.WriteLine("bed are not available");



            }
            else
            {
                patients.Add(patient);
                Console.WriteLine("patient add succesfully");
            }





        }
        public void Cheek_patientlist()
        {
            Console.WriteLine("Id \t\t" + "Name\t\t" + "Address\t\t" + "Age\t\t" + "Gender\t\t" + "Blood group\t\t" );
            for (int i = 0; i < patients.Count; i++)
            {
                Console.WriteLine(patients[i].Id + "\t\t" + patients[i].Name + "\t\t" + patients[i].Address + "\t\t" + patients[i].Age + "\t\t" + patients[i].Gender + "\t\t" + patients[i].Blood_group );
            }

        }
        public void Add_bed(Bed bed)
        {
            
            beds.Add(bed);
            Console.WriteLine("bed add succesfully");



        }
        public void Cheek_bed_available()
        {
        
        }

        public void Add_medicine(Medicine medicine)
        {
            medicines.Add(medicine);
            Console.WriteLine("bed add succesfully");




        }
        public void Cheekmedicine_list()
        {
            Console.WriteLine("medicine name\t\t" + "medicine cost\t\t" + "count\t\t" );
            for (int i = 0; i < medicines.Count; i++)
            {
                Console.WriteLine(medicines[i].Medicine_name + "\t\t\t" + medicines[i].Medicine_cost + "\t\t\t" + medicines[i].Count );
            }


        }
        public void Add_instruent(Labratory labratory)
        {
            labratorys.Add(labratory);
            Console.WriteLine("instrument add succesfully");



        }
        public void cheekinsrument_list()
        {
            Console.WriteLine("intrument name\t\t\t" + "cheekup cost");
            for (int i = 0; i < labratorys.Count; i++)
            {
                Console.WriteLine(labratorys[i].Instrumental_name + "\t\t\t\t" + labratorys[i].Cost);
            }


        }







    }
    
   
   
}
