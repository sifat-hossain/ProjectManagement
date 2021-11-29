/// <reference path="../angular.js" />


var app = angular.module("mymodule", []);

app.controller("mycontroller", function ($scope) {

    $scope.PsiModel = [{
        PsiStartDate: null,
        PsiEndDate: null,
        initialize: function (data) {
            this.PsiStartDate = data ? data.PsiStartDate : null;
            this.PsiEndDate = data ? data.PsiEndDate : null;
        }
    }]

    $scope.activePsiEndDate = function () {
        debugger
        $scope.minDate = $scope.PsiModel.PsiStartDate;
    }
});