using Hospital_management;
using System.Numerics;
using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        char again;
        
        do
        {
            int num;
            Console.WriteLine("---------------------------WELCOME TO TAMLUK HOSPITAL------------------------------");
            Console.WriteLine("press 1.doctor    press 2.staff   press 3.patient   press 4.bed   press 5.medicine  press 6.labratory");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine(" -------------------------------Doctor----------------------------------");


                    do
                    {

                        Console.WriteLine("welcome to doctor session");
                        Console.WriteLine("press 1.add_doctor press 2.cheekdoctorlist");
                        int n1;
                        n1 = Convert.ToInt32(Console.ReadLine());
                        switch (n1)
                        {
                            case 1:
                                Console.WriteLine("enter the doctor id");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the doctor name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter the doctor address ");
                                string address = Console.ReadLine();
                                Console.WriteLine("enter the age");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the doctor gender");
                                string gender = Console.ReadLine();
                                Console.WriteLine("enter the doctor room no");
                                int room = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the doctor visit cost");
                                int vistcost = Convert.ToInt32(Console.ReadLine());

                                Doctor doctor = new Doctor();
                                doctor.Id = id;
                                doctor.Name = name;
                                doctor.Address = address;
                                doctor.Age = age;
                                doctor.Gender = gender;
                                doctor.Room = room;
                                doctor.Visit_cost = vistcost;


                                hospital.Add_doctor(doctor);
                                break;
                            case 2:
                                hospital.Cheek_doctorlist();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;
                        }
                        Console.WriteLine("if  stay continue doctor session press'y'");
                        again = Convert.ToChar(Console.ReadLine());
                    } while (again == 'y');
                    break;
                case 2:
                    Console.WriteLine("---------------------------------- Staff------------------------------------");
                    do
                    {
                        Console.WriteLine("welcome to staff session");
                        Console.WriteLine("press 1.add_staff press 2.cheekstafflist");
                        int n2;
                        n2 = Convert.ToInt32(Console.ReadLine());
                        switch (n2)
                        {
                            case 1:
                                Console.WriteLine("enter the staff id");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the staff name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter the age");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the staff gender");
                                string gender = Console.ReadLine();
                                Console.WriteLine("enter the staff room no");
                                int room = Convert.ToInt32(Console.ReadLine());


                                Staff staff = new Staff();
                                staff.Id = id;
                                staff.Name = name;
                                staff.Age = age;
                                staff.Gender = gender;
                                staff.Room = room;
                                hospital.Add_Staff(staff);

                                break;
                            case 2:
                                hospital.Cheek_Stafflist();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;

                        }
                        Console.WriteLine("if stay continue staff session press 'y'");
                        again = Convert.ToChar(Console.ReadLine());

                    } while (again == 'y');
                    break;
                case 3:
                    Console.WriteLine("--------------------------------Patient------------------------------------");
                    do
                    {
                        Console.WriteLine("welcome to patient session");
                        Console.WriteLine("press 1.add_patient press 2.cheekpatientlist");
                        int n3;
                        n3 = Convert.ToInt32(Console.ReadLine());
                        switch (n3)
                        {
                            case 1:
                                Console.WriteLine("enter the doctor id");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the doctor name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter the doctor address ");
                                string address = Console.ReadLine();
                                Console.WriteLine("enter the age");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the doctor gender");
                                string gender = Console.ReadLine();
                                Console.WriteLine("enter patient blood group");
                                string blood = Console.ReadLine();


                                Patient patient = new Patient();
                                patient.Id = id;
                                patient.Name = name;
                                patient.Address = address;
                                patient.Age = age;
                                patient.Gender = gender;
                                patient.Blood_group = blood;
                               



                                hospital.Add_patient(patient);

                                break;
                            case 2:
                                hospital.Cheek_patientlist();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;

                        }
                        Console.WriteLine("if stay continue patient session press 'y'");
                        again = Convert.ToChar(Console.ReadLine());


                    } while (again == 'y');
                    break;
                case 4:
                    Console.WriteLine(" -------------------------------Bed----------------------------------");


                    do
                    {

                        Console.WriteLine("welcome to bed session");
                        Console.WriteLine("press 1.add_bed press 2.cheekbed avalable");
                        int n4;
                        n4 = Convert.ToInt32(Console.ReadLine());
                        switch (n4)
                        {
                            case 1:
                                Console.WriteLine("enter the bed no");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Bed bed = new Bed();
                                bed.Bed_no = id;

                                hospital.Add_bed(bed);
                                break;
                            case 2:
                                hospital.Cheek_bed_available();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;

                        }
                        Console.WriteLine("if stay continue bed session press 'y'");
                        again = Convert.ToChar(Console.ReadLine());




                    } while (again == 'y');
                    break;
                case 5:
                    Console.WriteLine(" -------------------------------medicine----------------------------------");


                    do
                    {

                        Console.WriteLine("welcome to medicine session");
                        Console.WriteLine("press 1.add_medicine press 2.cheekmedicine_list ");
                        int n5;
                        n5 = Convert.ToInt32(Console.ReadLine());
                        switch (n5)
                        {
                            case 1:
                                Console.WriteLine("enter the medicine name");
                                string name =Console.ReadLine();
                                Console.WriteLine("enter the medicine cost");
                                int cost1 =Convert.ToInt32 (Console.ReadLine());
                                Console.WriteLine("enter the medicine count");
                                int count = Convert.ToInt32(Console.ReadLine());

                                Medicine medicine= new Medicine();
                                medicine.Medicine_name = name;
                                medicine.Medicine_cost = cost1;
                                medicine.Count = count;

                                hospital.Add_medicine(medicine);
                                break;
                            case 2:
                                hospital.Cheekmedicine_list();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;

                        }
                        Console.WriteLine("if stay continue bed session press 'y'");
                        again = Convert.ToChar(Console.ReadLine());




                    } while (again == 'y');
                    break;
                case 6:
                    Console.WriteLine(" -------------------------------labratory----------------------------------");


                    do
                    {

                        Console.WriteLine("welcome to labratory session");
                        Console.WriteLine("press 1.add_instrument press 2.cheekinstrument_list ");
                        int n6;
                        n6= Convert.ToInt32(Console.ReadLine());
                        switch (n6)
                        {
                            case 1:
                                Console.WriteLine("enter the instrument name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter the instrument cost");
                                int cost1 = Convert.ToInt32(Console.ReadLine());
                                

                                Labratory labratory= new Labratory();
                                labratory.Instrumental_name = name;
                                labratory.Cost = cost1;
                                

                                hospital.Add_instruent(labratory);
                                break;
                            case 2:
                                hospital.cheekinsrument_list();
                                break;
                            default:
                                Console.WriteLine("wrong choice");
                                break;

                        }
                        Console.WriteLine("if stay continue labratory session press 'y'");
                        again = Convert.ToChar(Console.ReadLine());




                    } while (again == 'y');
                    break;

            }
            Console.WriteLine("if  stay continue hospital press 'y'");
            again = Convert.ToChar(Console.ReadLine());

        } while (again == 'y');

    }
}