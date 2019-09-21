var myApp = angular.module("myApp", []);
myApp.controller("myTestWebApi", function ($scope, $http) {
    
    var successCallBack = function (response) {
        $scope.result = response.data;

    };
    var ErrorCallback = function (response) {
        $scope.error = response.data;

    };
	$http({
		method: 'Get',
		url: 'http://localhost:61647/pets'

	}).then(successCallBack, ErrorCallback);
          
});

