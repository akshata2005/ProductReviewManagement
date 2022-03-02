using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductID=1,UserID=1,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=2,UserID=1,Rating=4,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=3,UserID=2,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=4,UserID=2,Rating=4,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=5,UserID=3,Rating=3,Review="Good",IsLike=false },
                new ProductReview(){ ProductID=6,UserID=4,Rating=4,Review="Good",IsLike=false },
                new ProductReview(){ ProductID=1,UserID=3,Rating=5,Review="Nice",IsLike=true },
                new ProductReview(){ ProductID=8,UserID=10,Rating=3,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=9,UserID=10,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=10,UserID=10,Rating=2,Review="Bad",IsLike=true },
                new ProductReview(){ ProductID=11,UserID=1,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=12,UserID=1,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=4,UserID=2,Rating=1.5,Review="Bad",IsLike=false },
                new ProductReview(){ ProductID=14,UserID=5,Rating=3,Review="nice",IsLike=true },
                new ProductReview(){ ProductID=15,UserID=1,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=5,UserID=10,Rating=2,Review="Not bad",IsLike=false},
                new ProductReview(){ ProductID=17,UserID=7,Rating=3.5,Review="Nice",IsLike=true },
                new ProductReview(){ ProductID=10,UserID=3,Rating=1,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=6,UserID=1,Rating=5,Review="Good",IsLike=true },
                new ProductReview(){ ProductID=20,UserID=10,Rating=5,Review="Good",IsLike=true },
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " +
                    "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
            Console.WriteLine("Top three records");
            ProductManagement.TopRecords(productReviewList);
            Console.WriteLine("Record based on ProductID");
            ProductManagement.SelectedRecord(productReviewList);
        }
    }
}
