namespace FirstASP.customConstraints;
public class CustomConstraints: IRouteConstraint
{

    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        throw new NotImplementedException();
    }
}