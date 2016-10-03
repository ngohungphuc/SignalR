angular.module('app').controller('mainCtrl', function ($scope, chat) {
    $scope.messages = [];
    $scope.sendMessage = function () {
        chat.server.sendMessage('hi');
        $scope.newMessage = "";
    }
});