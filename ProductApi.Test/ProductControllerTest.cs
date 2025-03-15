using Moq;
using ProductApi.Controllers;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Test
{
    public class ProductControllerTest
    {
        private readonly Mock<IProductService> _productService;

        public ProductControllerTest()
        {
            _productService = new Mock<IProductService>();
        }

        /*
         * Hier soll die gesamte Produktliste getestet werden
         */
        [Fact]
        public void GetProductList_ProductList()
        {
            //arrange
            var productList = GetProductsData();
            _productService.Setup(x => x.GetProductList())
                .Returns(productList);
            var productController = new ProductController(_productService.Object);

            //act
            var productResult = productController.ProductList();

            //assert

            /*
             * Auf Null, Anzahl Einträge in der Liste, Listenvergleich mit productList testen 
             */
        }

        /*
         * Hier soll ein bestimmtes Produkt aus der Liste getestet werden (z.B. Produkt mit ProductId 2)
         */
        [Fact]
        public void GetProductByID_Product()
        {
            //arrange

            //act
            
            //assert

        }

        /*
         * Hier soll getestet werden, ob ein Produkt mit einem bestimmten Namen in der Liste existiert oder nicht
         */
        [Theory]
        [InlineData("IPhone")]
        public void CheckProductExistOrNotByProductName_Product(string productName)
        {
            //arrange


            //act

            //assert

        }

        /*
         * Hier soll ein Produkt hinzugefügt werden und getestet werden, ob das Produkt hinzugefügt wurde oder nicht
         */
        [Fact]
        public void AddProduct_Product()
        {
            //arrange


            //act


            //assert

        }

        private List<Product> GetProductsData()
        {
            List<Product> productsData = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "IPhone",
                    ProductDescription = "IPhone 12",
                    ProductPrice = 55000,
                    ProductStock = 10
                },
                 new Product
                {
                    ProductId = 2,
                    ProductName = "Laptop",
                    ProductDescription = "HP Pavilion",
                    ProductPrice = 100000,
                    ProductStock = 20
                },
                 new Product
                {
                    ProductId = 3,
                    ProductName = "TV",
                    ProductDescription = "Samsung Smart TV",
                    ProductPrice = 35000,
                    ProductStock = 30
                },
            };

            return productsData;
        }
    }
}
