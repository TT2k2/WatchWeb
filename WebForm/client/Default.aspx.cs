using System;
using System.Globalization;
using System.Web.UI;

namespace WebForm.client
{
    public partial class Default : Page
    {
        // Consider moving service client initialization to a method to handle resource disposal if necessary
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    using (var trademark = new TrademarkService.TrademarkServiceSoapClient())
                    using (var product = new ProductService.ProductServiceSoapClient())
                    using (var slider = new SliderService.SliderServiceSoapClient())
                    {
                        rptCategoryList.DataSource = trademark.GetTable();
                        rptCategoryList.DataBind();
                        rptProductList.DataSource = product.GetTable();
                        rptProductList.DataBind();
                        rptSliderList.DataSource = slider.GetTableActive();
                        rptSliderList.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    // Example: Log exception to a file or monitoring system
                    // Logger.LogError(ex);
                    Response.Write("An error occurred: " + ex.Message);
                }
            }
        }

        public static string ObjToVnd(object obj)
        {
            if (obj == null) return string.Empty;
            if (int.TryParse(obj.ToString(), out int value))
            {
                return value.ToString("C0", new CultureInfo("vi-VN"));
            }
            return string.Empty;
        }

        public static string PriceSales(object price, object percentSales)
        {
            if (price == null || percentSales == null) return string.Empty;
            if (int.TryParse(price.ToString(), out int priceValue) &&
                int.TryParse(percentSales.ToString(), out int percentSalesValue))
            {
                int value = priceValue - (priceValue * percentSalesValue / 100);
                return ObjToVnd(value);
            }
            return string.Empty;
        }
    }
}
