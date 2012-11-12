<%@ Application Language="C#" %>
<%@ Import Namespace="Piranha.WebPages" %>
<%@ Import Namespace="System.Web.Mvc" %>
<script runat="server">
    /// <summary>
    /// Handle url rewriting for permalink requests.
    /// </summary>
    void Application_BeginRequest(object sender, EventArgs e)
    {
        WebPiranha.BeginRequest(HttpContext.Current);
        var test = ViewEngines.Engines;
        
        Console.WriteLine(test.ToArray().ToString());
    }
</script>
