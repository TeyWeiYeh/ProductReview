function reloadPageAndNavigate(url) {
    location.reload();
    setTimeout(function () {
        window.location.href = url;
    }, 2000); //set delay of 100ms
}

function reloadApp() {
    window.location.reload(true);
}