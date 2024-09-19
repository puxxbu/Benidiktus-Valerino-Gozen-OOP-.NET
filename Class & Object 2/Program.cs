

namespace UserBootcam
{

    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 user1 = new UserBootcamp11();
            user1.NamaUser = "Pablo";

            Console.WriteLine($"Name: {user1.NamaUser}");
        }
    }
    public class UserBootcamp11
    {
        string nama;
        string role;
        int eMoney;


        public string NamaUser
        {
            //get { return nama; }
            //set { nama = value; }
            //get => nama; set => nama = value;
            get; set;
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }
    }
}