# 1. inport package
    Install-Package Owin
    Install-Package Microsoft.AspNet.Cors
    Install-Package Microsoft.AspNet.WebApi.Client
    Install-Package Microsoft.AspNet.WebApi.Core
    Install-Package Microsoft.AspNet.WebApi.Owin
    Install-Package Microsoft.AspNet.WebApi.WebHost
    Install-Package Microsoft.Owin
    Install-Package Microsoft.Owin.Host.SystemWeb
    Install-Package Microsoft.Owin.Security
    Install-Package Microsoft.Owin.Security.OAuth
    Install-Package Microsoft.Owin.Cors

# 2. using 
    $.ajax({
        url: "/api/security/token",
        type: "POST",
        dataType: "json",
        contentType: "application/x-www-form-urlencoded",
        data: {grant_type:'password',username:'huangzl',password:'123'},
        success: function (data) {
            console.log(data)
        }
    });
