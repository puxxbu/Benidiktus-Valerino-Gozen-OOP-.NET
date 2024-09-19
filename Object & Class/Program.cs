namespace UserManagement
{
    class  User
    {
        //Attribute
        public string name = "Pablo"; 
        string role = "Admin";
        int eMoney = 123123212;

        //Method
        public void userDetail()
        {
            Console.WriteLine($"Name: {name} Ini detail usernya.");
        }

        static void Main(string[] args)
        {
            //Kelas merupakan blueprint dari object
            User user1 = new User();
            user1.userDetail(); 
        }
    }
}