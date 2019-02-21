using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashCounter.DataAccessLayer
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }

        public Product(int categoryId, string name, double price, string author)
        {
            CategoryId = categoryId;
            Name = name;
            Price = price;
            Author = author;
        }

        public Product(int categoryId, string name, double price, DateTime date, int id, string author)
        {
            CategoryId = categoryId;
            Name = name;
            Price = price;
            Date = date;
            Id = id;
            Author = author;
        }

        public static bool InsertProduct(Product product, DateTime currentDate)
        {
            bool result = false;
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("Category", product.CategoryId);
                    helper.AddSQLCommandParameter("Name", product.Name);
                    helper.AddSQLCommandParameter("Price", product.Price);
                    helper.AddSQLCommandParameter("CurrentDate", currentDate);
                    helper.AddSQLCommandParameter("Author", product.Author);
                    //String.Format("{0:dd.MM.yyyy HH:mm:ss}", 
                    //helper.Execute("INSERT INTO Products (Category, Name, Price, CurrentDate) VALUES (@Category, @Name, @Price, @CurrentDate)");

                    var result1 = helper.ExecuteAndReturnIdentity("INSERT INTO Products (Category, Name, Price, CurrentDate, Author) VALUES (@Category, @Name, @Price, @CurrentDate, @Author)");

                    result = true;
                }
            }
            catch (Exception ex) { result = false; }

            return result;
        }

        public static DataTable GetAllProducts()
        {
            DataTable result = new DataTable();

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    result = helper.GetTable(@"SELECT c.Name AS Category, p.Name, p.Price, p.CurrentDate, p.Id, p.Author 
                                               FROM Products p
                                               INNER JOIN Categories c ON p.Category = c.Id");                    

                }
            }
            catch (Exception cEx)
            {
            }

            return result;
        }

        public static DataTable GetGeneralProducts(DateTime from, DateTime to)
        {
            DataTable result = new DataTable();

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("from", from);
                    helper.AddSQLCommandParameter("to", to);
                    result = helper.GetTable(@"SELECT d.Name AS Category, ROUND(SUM(p.Price), 2) AS Sum
                                               FROM Products AS p INNER JOIN
                                               Categories AS c ON p.Category = c.Id INNER JOIN
                                               Division AS d ON c.Division = d.Id
                                               WHERE p.CurrentDate >= @from  AND p.CurrentDate <= @to
                                               GROUP BY d.Name");

                }
            }
            catch (Exception cEx)
            {
            }

            return result;
        }

        public static DataTable GetDetailedProducts(DateTime from, DateTime to)
        {
            DataTable result = new DataTable();

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("from", from);
                    helper.AddSQLCommandParameter("to", to);
                    result = helper.GetTable(@"SELECT c.Name AS Category, ROUND(SUM(p.Price),2) AS Sum
                                               FROM Products AS p INNER JOIN
                                               Categories AS c ON p.Category = c.Id
                                               WHERE p.CurrentDate >= @from  AND p.CurrentDate <= @to
                                               GROUP BY c.Name");

                }
            }
            catch (Exception cEx)
            {
            }

            return result;
        }

        public static double GetSumOfallProducts()
        {
            var result = 0.0;

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    DataRowCollection dataRowCollection = helper.GetDataRowCollection(@"SELECT SUM(Price) AS Expr1 FROM Products");

                    DataRow row = dataRowCollection[0];

                    if (!string.IsNullOrEmpty(row["Expr1"].ToString()))
                        result = ((double)row["Expr1"]);
                

                }
            }
            catch (Exception cEx)
            {
            }

            

            return result;

        }
        
        public static bool UpdateProduct(Product product)
        {
            bool result = false;
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("Category", product.CategoryId);
                    helper.AddSQLCommandParameter("Name", product.Name);
                    helper.AddSQLCommandParameter("Price", product.Price);
                    helper.AddSQLCommandParameter("CurrentDate",  product.Date);
                    helper.AddSQLCommandParameter("Id", product.Id);
                    helper.AddSQLCommandParameter("Author", product.Author);

                    helper.Execute(@"UPDATE Products SET Category=@Category, Name=@Name, Price=@Price, CurrentDate = @CurrentDate, Author = @Author WHERE Id=@Id");

                    result = true;
                }
            }
            catch (Exception ex) { result = false; }
            return result;
        }

        public static bool RemoveProductById(int id)
        {
            bool result = false;
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("Id", id);

                    helper.Execute(@"Delete from Products WHERE Id=@Id");

                    result = true;
                }
            }
            catch (Exception ex) { result = false; }
            return result;
        }

        public static double GetLastDayProducts(out DateTime lastDate)
        {
            double result = 0;
            lastDate = DateTime.Now;

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    var data = helper.GetDataRowCollection(@"SELECT MAX(CurrentDate) FROM Products");
                    lastDate = (DateTime)data[0][0];

                    helper.AddSQLCommandParameter("year", lastDate.Year.ToString());
                    helper.AddSQLCommandParameter("month", lastDate.Month.ToString());
                    helper.AddSQLCommandParameter("day", lastDate.Day.ToString());

                    data = helper.GetDataRowCollection(@"SELECT Id, Name, Price FROM Products WHERE 
                                                         DATEPART(year, CurrentDate) = @year AND 
                                                         DATEPART(month, CurrentDate) = @month AND 
                                                         DATEPART(day, CurrentDate) = @day");

                    for (int i = 0; i < data.Count; i++)
                    {
                        DataRow row = data[i];

                        if (!string.IsNullOrEmpty(row["Price"].ToString()))
                            result += ((double)row["Price"]);

                    }
                }
            }
            catch (Exception cEx)
            {
            }

            return result;
        }
    }
}
