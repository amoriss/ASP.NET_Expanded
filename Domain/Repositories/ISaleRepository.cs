using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface ISaleRepository
    {
        public IEnumerable<Sale> GetSalesByProductID(int productID);
        public IEnumerable<Sale> GetSalesByEmployeeID(int employeeID);       
        public IEnumerable<Sale> GetSalesByDate(DateTime date);
        public IEnumerable<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
        public IEnumerable<Sale> GetSalesByCategory(int categoryID);
        public double GetTotalSalesByProductID(int productID);
        public double GetTotalSalesByEmployeeID(int employeeID);
        public double GetTotalSalesByDate(DateTime date);
        public double GetTotalSalesByDateRange(DateTime startDate, DateTime endDate);
        public void InsertSale(Sale sale);
        public void UpdateSale(Sale sale);
        public void DeleteSale(Sale sale);



    }
}
