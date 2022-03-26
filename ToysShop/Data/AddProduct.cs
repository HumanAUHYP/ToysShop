using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

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
            return (builder) =>
            {
                seq = InputString(builder, "Название:", "text", seq);
                seq = InputString(builder, "Описание:", "text", seq);
                seq = InputString(builder, "Производитель:", "text", seq);
                seq = InputString(builder, "Стоимость:", "number", seq);
                seq = InputString(builder, "Актуальный:", "checkbox", seq);
                seq = InputString(builder, "Количество:", "number", seq);
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
                builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Close));
                builder.AddContent(++seq, "Ok");
                builder.CloseElement();
            };
        }
    }
}
