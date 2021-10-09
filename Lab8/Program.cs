using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {

        public static DataClasses1DataContext context = new DataClasses1DataContext();
        static void Main(string[] args)
        {
            //DataSource();
            //Filtering();
            //Ordering();
            //Grouping();
            //Joining();
            //DataSourceLAMBDA();
            //FilteringLAMBDA();
            //OrderingLAMBDA();
            GroupingLAMBDA();
            //JoiningLAMBDA();
            Console.Read();
        }

        static void IntroToLINQ()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numbers)
            {
                Console.WriteLine("{0,1}", num);
            }
        }

        static void DataSource()
        {
            var queryAllCustomers =
                from cust in context.clientes
                select cust;
            foreach (var item in queryAllCustomers)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }

        static void Filtering()
        {
            var queryLondonCustomers =
                from cust in context.clientes
                where cust.Ciudad == "Londres"
                select cust;

            foreach (var item in queryLondonCustomers)
            {
                Console.WriteLine(item.Ciudad);
            }
        }

        static void Ordering()
        {
            var queryLondonCustomers3 =
                from cust in context.clientes
                where cust.Ciudad == "London"
                orderby cust.NombreCompañia ascending
                select cust;

            foreach (var item in queryLondonCustomers3)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }

        static void Grouping()
        {
            var queryCustomersByCity =
                from cust in context.clientes
                group cust by cust.Ciudad;

            foreach (var customerGroup in queryCustomersByCity)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (clientes customer in customerGroup)
                {
                    Console.WriteLine("     {0}", customer.NombreCompañia);
                }
            }
        }

        static void Grouping2()
        {
            var custQuery =
                from cust in context.clientes
                group cust by cust.Ciudad into custGroup
                where custGroup.Count() > 2
                orderby custGroup.Key
                select custGroup;

            foreach (var item in custQuery)
            {
                Console.WriteLine(item.Key);

            }
        }

        static void Joining()
        {
            var innerJoinQuery =
                from cust in context.clientes
                join dist in context.Pedidos on cust.idCliente equals dist.IdCliente
                select new { CustomerName = cust.NombreCompañia, DistributorName = dist.PaisDestinatario };

            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine(item.CustomerName);
            }
        }

        static void DataSourceLAMBDA()
        {
            var queryAllCustomers = context.clientes.ToList();
            foreach (var item in queryAllCustomers)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }

        static void FilteringLAMBDA()
        {
            var queryLondonCustomers =
                context.clientes.Where(x => x.Ciudad == "Londres").ToList();
            foreach (var item in queryLondonCustomers)
            {
                Console.WriteLine(item.Ciudad);
            }
        }

        static void OrderingLAMBDA()
        {
            var queryLondonCustomers3 =
                context.clientes.
                    Where(x => x.Ciudad == "London").
                    OrderBy(x => x.NombreCompañia).ToList();
            foreach (var item in queryLondonCustomers3)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }

        static void GroupingLAMBDA()
        {
            var queryCustomersByCity =
                context.clientes.GroupBy(x => x.Ciudad).ToList();
            foreach (var customerGroup in queryCustomersByCity)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (clientes customer in customerGroup)
                {
                    Console.WriteLine("     {0}", customer.NombreCompañia);
                }
            }
        }

        static void Grouping2LAMBDA()
        {
            var custQuery =
                context.clientes.
                    GroupBy(x => x.Ciudad).
                    Where(x => x.Count() > 2 == true).
                    OrderBy(x => x.Key).ToList();
            foreach (var item in custQuery)
            {
                Console.WriteLine(item.Key);

            }
        }

        static void JoiningLAMBDA()
        {
            var innerJoinQuery =
                context.clientes.
                    Join(context.Pedidos,
                    x => x.idCliente,
                    p => p.IdCliente,
                    (x, p) => new { Clientes = x, Pedidos = p }).
                    Select(xp => new { CustomerName = xp.Clientes.NombreCompañia, DistributorName = xp.Pedidos.PaisDestinatario });
            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine(item.CustomerName);
            }
        }
    }
}
