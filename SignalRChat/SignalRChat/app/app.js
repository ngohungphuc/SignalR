(function () {
    angular.module('app', []);

    $(function () {
        $.connection.hub.logging = true;
        $.connection.hub.start();
    });

    $.connection.error(function (err) {
        console.log('Error occured ' + err);
    });

    //create a service name chat
    angular.module('app').value('chat', $.connection.chat);
})();