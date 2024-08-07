
var themeChanger = {
    changeCss: function (cdnRoute) {
        var oldLink = document.getElementById("WoTheme"); // we have this id on the <link> that references the theme

        if (cdnRoute === oldLink.getAttribute("href")) {
            return;
        }

        var newLink = document.createElement("link");
        newLink.setAttribute("id", "WoTheme");
        newLink.setAttribute("rel", "stylesheet");
        newLink.setAttribute("href", cdnRoute);
        newLink.setAttribute("crossorigin", "anonymous");
        newLink.onload = () => {
            oldLink.parentElement.removeChild(oldLink);
        };

        document.getElementsByTagName("head")[0].appendChild(newLink);
    }
}