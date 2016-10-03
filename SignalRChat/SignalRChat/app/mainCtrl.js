angular.module('app').controller('mainCtrl', function ($scope, chat) {
    $scope.messages = [];
    $scope.sendMessage = function () {
        chat.server.sendMessage($scope.newMessage);
        $scope.newMessage = "";
    }

    chat.client.newMessage = function onNewMessage(message) {
        $scope.messages.push({ message: message });
        //start this event
        $scope.$apply();
        console.log(message);
    }
});