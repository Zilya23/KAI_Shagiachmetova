using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors; // Подключение CORS

namespace Labs3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Убираем XML-форматтер
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Включаем атрибутную маршрутизацию
            config.MapHttpAttributeRoutes();

            // Настройка маршрутов по умолчанию
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Включаем CORS
            var cors = new EnableCorsAttribute("*", "*", "*"); // Разрешить все запросы
            config.EnableCors(cors);
        }
    }
}
