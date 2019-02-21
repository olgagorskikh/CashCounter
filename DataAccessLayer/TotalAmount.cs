using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashCounter.DataAccessLayer
{
    public class TotalAmount
    {
        public double Amount { get; set; }

        public static TotalAmount GetTotalAmount()
        {
            var result = new TotalAmount();

            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    DataRowCollection dataRowCollection = helper.GetDataRowCollection("SELECT * FROM TotalAmount");

                    for (int i = 0; i < dataRowCollection.Count; i++)
                    {
                        DataRow row = dataRowCollection[i];
                        TotalAmount currentAmount = new TotalAmount();


                        if (!string.IsNullOrEmpty(row["Amount"].ToString()))
                            currentAmount.Amount = ((double)row["Amount"]);


                        result = currentAmount;
                    }
                }
            }
            catch (Exception cEx)
            {
                //Diagnostics.RegisterError("SQL error during deleting folder: " + cEx.Message, cEx);
                //throw new CoreException(cEx.Message, cEx);
            }

            return result;
        }

        public static bool ChangeTotalAmount(TotalAmount total)
        {
            bool result = false;
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    helper.AddSQLCommandParameter("Amount", total.Amount);

                    helper.Execute("UPDATE TotalAmount SET Amount=@Amount");

                    result = true;
                }
            }
            catch (Exception ex) { result = false; }
            return result;
        }
    }
}
