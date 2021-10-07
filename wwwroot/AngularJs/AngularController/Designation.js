/// <reference path="../angular.js" />


var app = angular.module("mymodule", []);

app.controller("mycontroller", function ($scope, $http) {
    $scope.init = function () {
        $scope.GetDesignation();
    };

    $scope.DesignationList = [{
        DesignationId: null,
        DesignationName: '',
    }];

    $scope.GetDesignation = function () {
        debugger
       
        $http({
            method: 'Get',
            url: "/Designation/GetAllDesignation"
        }).then(function (response) {
            debugger
            $scope.DesignationList = response.data;

           
        })

    };

})