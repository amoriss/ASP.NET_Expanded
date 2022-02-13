using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IReviewRepository
    {
        public IEnumerable<Review> GetReviews();
        public Review GetReview(int id);
        public IEnumerable<Review> GetReviewForProduct(int productID);
        public void InsertReview(Review review);
        public void UpdateReview(Review review);
        public void DeleteReview(Review review);
    }
}
