mainModule.controller('prijaviNestanakController', ['$scope','$http','$log', function ($scope, $http, $log, ngAuthSettings) {


    var serviceBase = "http://localhost:4094/";

    $scope.imeNestali = null;
    $scope.prezimeNestali = null;
    $scope.godRodenjaNestali = null;
    $scope.mjestoNVidenjaNestali = null;
    $scope.datumVidjenjaNestali = null;
    $scope.slikaNestali = null;
    $scope.imeKorisnika = null;
    $scope.prezimeKorisnika = null;
    $scope.emailKorisnika = null;
    $scope.brojTelefonaKorisnika = null;


    $scope.dodajNestalog = function () {



        var nestali = {
            Ime: $scope.imeNestali,
            Prezime: $scope.prezimeNestali,
            GodinaRodenja: $scope.godRodenjaNestali,
            Fotografija: null,
            DatumNestanka:null,
            MjestoNestanka: $scope.mjestoNVidenjaNestali,
            //idKorisnik: 16,
            //Korisnik: {
            //    idKorisnik: 16,
            //    ime: $scope.imeKorisnika,
            //    prezime: $scope.prezimeKorisnika,
            //    email: $scope.emailKorisnika,
            //    brojTelefona: $scope.brojTelefonaKorisnika
            //}
        }
        $log.info(nestali)
        $http.post(serviceBase + 'api/Nestali/Register',nestali)
        .success(function (data) {
            $scope.greeting = data;            
        })
    }


}]);

