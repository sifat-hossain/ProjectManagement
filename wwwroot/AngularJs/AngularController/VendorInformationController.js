/// <reference path="../angular.js" />

var app = angular.module("myModule", []);

app.controller("myController", function ($scope, $http) {

    $scope.VendorInformationList = [{
        VendorId: null,
        VendorName: '',
        VendorTradeLicenceNo: '',
        VendorEmail: '',
        VendorPhone: '',
        VendorClearence: '',
    }];

    $scope.init = function () {
        debugger
        $scope.GetVendorInformation()
    };

    $scope.GetVendorInformation = function () {
        debugger
        $http({
            method: 'get',
            url: '/VendorInformation/GetVendorInformation'
        }).then(function (response) {
            debugger
            $scope.VendorInformationList = response.data;
        })
    }
})