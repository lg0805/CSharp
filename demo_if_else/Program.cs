using demo_if_else;

namespace demo_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank mybank = new Bank();
            mybank.CreateAccount();
        }
    }

    public class Bank
    {
        public void CreateAccount()
        {
            User user = new User();

            Console.WriteLine("请输入账户姓名：");
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            user.name = Console.ReadLine();
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
            user.account = "179708066356";
            Console.WriteLine("请输入账户密码：");
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            user.password = Console.ReadLine();
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
            Console.WriteLine("请输入身份证号：");
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            user.identityNum = Console.ReadLine();
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
            Console.WriteLine("请输入账户存款金额：");
            user.balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("账户信息：{0},姓名：{1}, 存款金额:{2}创建成功！",
            user.account, user.name, user.balance);
            // Console.ReadKey();
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
            this.name = "";
            this.password = "";
            this.identityNum = "";
            this.balance = 0.0;
            this.account = "";

        }
    }
}