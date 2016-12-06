mainModule.controller('prijaviNestanakController', ['$scope','$http','$log', function ($scope, $http, $log, ngAuthSettings) {


    var serviceBase = "http://localhost:4094/";

    $scope.imeNestali = null;
    $scope.prezimeNestali = null;
    $scope.godRodenjaNestali = null;
    $scope.muskiNestali = null;
    $scope.zenskiNestali = null;
    $scope.visinaNestali = null;
    $scope.tezinaNestali = null;
    $scope.komentarNestali = null;
    $scope.mjestoNVidenjaNestali = null;
    $scope.datumVidjenjaNestali = null;
    $scope.slikaNestali = null;
    $scope.imeKorisnika = null;
    $scope.prezimeKorisnika = null;
    $scope.emailKorisnika = null;
    $scope.brojTelefonaKorisnika = null;
    $scope.pol = null;


    $scope.dodajNestalog = function () {
        if ($scope.muskiNestali)
            $scope.pol = "M";
        else
            $scope.pol = "F";


        var nestali = {
            idNestali: 103,
            ime: $scope.imeNestali,
            prezime: $scope.prezimeNestali,
            godinaRodenja: $scope.godRodenjaNestali,
            fotografija: null,
            datumNestanka:null,
           // fotografija: "QEA="+$scope.slikaNestali,
            //datumNestanka: $scope.datumVidjenjaNestali,
            mjestoNestanka: $scope.mjestoNVidenjaNestali,
            idKorisnik: 16,
           // spol: $scope.pol, //spol je u bazi varbinary pa ga sad ne mogu dodati
            komentar: $scope.komentarNestali,
            visina: $scope.visinaNestali,
            tezina: $scope.tezinaNestali,
            Korisnik: {
                idKorisnik: 16,
                ime: $scope.imeKorisnika,
                prezime: $scope.prezimeKorisnika,
                email: $scope.emailKorisnika,
                brojTelefona: $scope.brojTelefonaKorisnika
            }
        }
        $log.info(nestali)
        $http.post(serviceBase + 'api/Nestali/Register',nestali)
        .success(function (data) {
            $scope.greeting = data;            
        })
    }


}]);

