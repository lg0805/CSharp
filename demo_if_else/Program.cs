using demo_if_else;

namespace demo_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank mybank = new Bank();
        }
    }

    public class Bank
    {
        public void CreateAccount()
        {
            User user = new User();

            Console.WriteLine("请输入账户姓名：");
            user.name = Console.ReadLine();
            user.account = "179708066356";
            Console.WriteLine("请输入账户密码：");
            user.password = Console.ReadLine();
            Console.WriteLine("请输入身份证号：");
            user.identityNum = Console.ReadLine();
            Console.WriteLine("请输入账户存款金额：");
            user.balance = double.Parse(Console.ReadLine());

            Console.WriteLine("账户信息：{0},姓名：{1}, 存款金额:{2}创建成功！",
            user.account, user.name, user.balance);
            Console.ReadKey();
        }
    }

    public class User
    {
        public string name;
        public string password;
        public string identityNum;
        public double balance;
        public string account;

        public User()
        {
            this.name = "Alice";
            this.password = "123";
            this.identityNum = "111";
            this.balance = 0.0;
            this.account = "123";

        }
    }
}