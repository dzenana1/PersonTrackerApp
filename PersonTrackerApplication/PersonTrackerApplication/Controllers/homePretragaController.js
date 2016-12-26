mainModule.directive('template-comment', function () {
    return {
        restrict: 'M',
        link: function (scope, elem, attr) {
            alert(attr.myDirectiveName); //alerts "this is all an argument"
        }
    };
});

mainModule.controller('homePretragaController', ['$scope', '$http', '$log', function ($scope, $http, $log, ngAuthSettings) {

    $scope.parametarPretrage = null;
    var serviceBase = "http://localhost:4094/";
    $scope.listaNestalih = [];

    $scope.btn_add = function (txtcomment, imeKorisnika, prezimeKorisnika, emailKorisnika, idNestali) {
        if ($scope.txtcomment != '') {
            //$http.post(serviceBase + 'api/Komentar/RegisterCom?komentar=' + txtcomment + '&ime=' + imeKorisnika + '&prezime=' + prezimeKorisnika + '&email=' + emailKorisnika + '&idNestali=' + idNestali)
            //    .success(function (data) {
            //        $scope.greeting = data;
            //    })

            $scope.txtcomment = "";
            console.log("nss")
        }

    }


    $scope.izlistajPretraga = function () {
        $http.get(serviceBase + 'api/Pretraga/Pretrazi?parametarPretrage=' + $scope.parametarPretrage)
        .success(function (data) {
            $scope.listaNestalih = data;
        }
        )

    }


}]);

