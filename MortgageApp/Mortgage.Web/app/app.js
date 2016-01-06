var app = angular.module("app", ['ngRoute']);

// Angular routing partial views

app.config(function ($routeProvider) {
    $routeProvider
        .when('/home', {
            templateUrl: 'app/views/home/home.html',
            controller: 'RepaymantController'
        })
        .when('/repaymentCalculator', {
            templateUrl: 'app/views/home/repaymentCalculator.html',
            controller: 'RepaymantController'
        })
        .otherwise({
            redirectTo: '/home'
        });
});


// Conroller
app.controller('RepaymantController', function ($scope, $http) {

    $scope.resultMode = false;

    $scope.message = "Click on the hyper link to view the repaymant calculator.";

    // AJAX post for cominicate with server
    // url - api/Repaymant/getRepaymentData/
    //
    $scope.calculate = function () {
        $scope.loading = true;
        $http.post('api/Repaymant/getRepaymentData/', this.repaymant).success(function (data) {
            $scope.resultMode = true;
            $scope.errorMode = false;
            $scope.MonthlyRepaymant = data.MonthlyRepaymant;
            $scope.TotalToBePaid = data.TotalToBePaid;
            
        }).error(function (data) {
            $scope.error = "Error - " + data;
            $scope.resultMode = false;
            $scope.errorMode = true;
        });
    };
});