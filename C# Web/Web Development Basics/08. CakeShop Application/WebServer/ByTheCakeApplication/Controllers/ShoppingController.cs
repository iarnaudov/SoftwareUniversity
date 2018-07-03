namespace WebServer.ByTheCakeApplication.Controllers
{
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Server.Http;
    using Server.Http.Contracts;
    using Server.Http.Response;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ViewModels;
    using WebServer.ByTheCakeApplication.Data;

    public class ShoppingController : Controller
    {
        private readonly IUserService users;
        private readonly IProductService products;
        private readonly IShoppingService shopping;

        public ShoppingController()
        {
            this.users = new UserService();
            this.products = new ProductService();
            this.shopping = new ShoppingService();
        }

        public IHttpResponse AddToCart(IHttpRequest req)
        {
            var id = int.Parse(req.UrlParameters["id"]);

            var productExists = this.products.Exists(id);

            if (!productExists)
            {
                return new NotFoundResponse();
            }

            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);
            shoppingCart.ProductIds.Add(id);

            var redirectUrl = "/search";

            const string searchTermKey = "searchTerm";

            if (req.UrlParameters.ContainsKey(searchTermKey))
            {
                redirectUrl = $"{redirectUrl}?{searchTermKey}={req.UrlParameters[searchTermKey]}";
            }

            return new RedirectResponse(redirectUrl);
        }

        public IHttpResponse ShowCart(IHttpRequest req)
        {
            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            if (!shoppingCart.ProductIds.Any())
            {
                this.ViewData["cartItems"] = "No items in your cart";
                this.ViewData["totalCost"] = "0.00";
            }
            else
            {
                var productsInCart = this.products
                    .FindProductsInCart(shoppingCart.ProductIds);

                var items = productsInCart
                    .Select(pr => $"<div>{pr.Name} - ${pr.Price:F2}</div><br />");

                var totalPrice = productsInCart
                    .Sum(pr => pr.Price);
                
                this.ViewData["cartItems"] = string.Join(string.Empty, items);
                this.ViewData["totalCost"] = $"{totalPrice:F2}";
            }

            return this.FileViewResponse(@"shopping\cart");
        }

        public IHttpResponse FinishOrder(IHttpRequest req)
        {
            var username = req.Session.Get<string>(SessionStore.CurrentUserKey);
            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            var userId = this.users.GetUserId(username);
            if (userId == null)
            {
                throw new InvalidOperationException($"User {username} does not exist");
            }

            var productIds = shoppingCart.ProductIds;
            if (!productIds.Any())
            {
                return new RedirectResponse("/");
            }

            this.shopping.CreateOrder(userId.Value, productIds);

            shoppingCart.ProductIds.Clear();

            return this.FileViewResponse(@"shopping\finish-order");
        }

        public IHttpResponse ShowAllOrders(IHttpRequest req)
        {
            var username = req.Session.Get<string>(SessionStore.CurrentUserKey);
            var userId = this.users.GetUserId(username);

            using (var db = new ByTheCakeDbContext())
            {
                var allOrders = db.Orders.Include(o => o.Products).Where(o => o.UserId == userId).ToList();

                foreach (var order in allOrders)
                {
                    db.Entry(order).Collection(o => o.Products).Load();
                    foreach (var product in order.Products)
                    {
                        db.Entry(product).Reference(op => op.Product).Load();
                    }
                }

                if (!allOrders.Any())
                {
                    this.ViewData["orders"] = $"Sorry Bro, no orders";
                }
                else
                {
                    var orders = allOrders
                     .Select(o => $"<tr><td><a href='orderDetails/{o.Id}'>{o.Id}</a></td><td>{o.CreationDate.ToString("dd-MM-yyyy")}</td>" +
                     $"<td>{o.Products.Sum(p => p.Product.Price).ToString("F2")}</td>" +
                     $"</tr>");

                    this.ViewData["orders"] = string.Join(string.Empty, orders);
                }    
            }

            return this.FileViewResponse(@"shopping\orders");
        }

        internal IHttpResponse OrderDetails(IHttpRequest req)
        {
            int orderId;
            
            if (!int.TryParse(req.UrlParameters["id"], out orderId) || !this.products.OrderExists(orderId))
            {
                return this.FileViewResponse(@"notFound");
            }
            

            using (var db = new ByTheCakeDbContext())
            {
                var order = db.Orders.Include(o => o.Products).FirstOrDefault(o => o.Id == orderId);
             
                foreach (var op in order.Products)
                {
                    db.Entry(op).Reference(o => o.Product).Load();
                }

                var productsList = order.Products.Select(op => op.Product).ToList();

                var products = productsList.Select(o => $"<tr><td>{o.Name}</td><td>{o.Price.ToString("F2")}</td></tr>");

                this.ViewData["products"] = string.Join(string.Empty, products);
                this.ViewData["createdDate"] = order.CreationDate.ToString("dd-MM-yyyy");
                this.ViewData["orderId"] = orderId.ToString();
            }
         
           return this.FileViewResponse(@"shopping\orderDetails");
        }
    }
}
