using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using ToysShopCore;

namespace ToysShop.Data
{
    public class AddProduct : ModalTemplate
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Добавление товара");
            };
        }
        protected override RenderFragment Body()
        {
            int seq = 0;
            string name = "";
            string description = "";
            string distributor = "";
            string price = "";
            string actually = "";
            string count = "";

            return (builder) =>
            {
                seq = InputString(builder, "Название:", "text", "name", seq);
                seq = InputString(builder, "Описание:", "text", "description", seq);
                seq = InputString(builder, "Производитель:", "text", "distributor", seq);
                seq = InputString(builder, "Стоимость:", "number", "price", seq);
                seq = InputString(builder, "Актуальный:", "checkbox", "actually", seq);
                seq = InputString(builder, "Количество:", "number", "count", seq);
                string[] prodParamsArray = new string[] { name, description, distributor, price, actually, count };
                //Globals.product = new Product(prodParamsArray);
            };
        }

        protected override RenderFragment Footer()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "button");
                builder.AddAttribute(++seq, "type", "button");
                builder.AddAttribute(++seq, "class", "btn btn-success");
                builder.AddAttribute(++seq, "data-dismiss", "modal");
                builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, AddProducts));
                builder.AddContent(++seq, "Ok");
                builder.CloseElement();
            };
        }

        protected virtual void AddProducts()
        {
            Globals.ProductStorage.Add(Globals.product);
        }
    }
}
