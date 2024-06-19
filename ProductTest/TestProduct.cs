using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTest
{
    public class TestProduct
    {
        [Test]
        public void ProductConstructor_ValidInputRedmi14_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Redmi 14";
            int price = 650;
            int stock = 7;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
