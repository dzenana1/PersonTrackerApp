mainModule.controller('prijaviNestanakController', ['$scope', '$q', '$http', '$log', function ($scope, $q, $http, $log, ngAuthSettings) {

  
    var serviceBase = "http://localhost:4094/";
    $scope.imeNestali = null;
    $scope.prezimeNestali = null;
    $scope.godRodenjaNestali = null;
    $scope.mjestoNVidenjaNestali = null;
    $scope.datumVidjenjaNestali = null;
    $scope.slika = null;
    $scope.imeKorisnika = null;
    $scope.prezimeKorisnika = null;
    $scope.emailKorisnika = null;

    
    $scope.dodajNestalog = function () {
        alert("TU");

        var filesSelected = document.getElementById("slika").files;
        if (filesSelected.length > 0) {
            var fileToLoad = filesSelected[0];

            var fileReader = new FileReader();

            fileReader.onload = function (fileLoadedEvent) {
                var srcData = fileLoadedEvent.target.result; // <--- data: base64

                var nestali = {
                    Ime: $scope.imeNestali,
                    Prezime: $scope.prezimeNestali,
                    GodinaRodenja: $scope.godRodenjaNestali,
                    Fotografija: srcData,
                    DatumNestanka: $scope.datumVidjenjaNestali,
                    MjestoNestanka: $scope.mjestoVidenjaNestali,
                    Korisnik: {
                        Ime: $scope.imeKorisnika,
                        Prezime: $scope.prezimeKorisnika,
                        Email: $scope.emailKorisnika,
                    }
                }
                $log.info(nestali)
                $http.post(serviceBase + 'api/Nestali/Register', nestali)
                .success(function (data) {
                    $scope.greeting = data;
                })
                alert("Gotovo");
            }
            fileReader.readAsDataURL(fileToLoad);
        }
    }

    
}]);