<%@ Application Language="C#" %>
<script runat="server">
    /// <summary>
    /// Handle url rewriting for permalink requests.
    /// </summary>
    void Application_BeginRequest(object sender, EventArgs e) {
        Piranha.WebPages.WebPiranha.BeginRequest(Context) ;
    }
</script>
