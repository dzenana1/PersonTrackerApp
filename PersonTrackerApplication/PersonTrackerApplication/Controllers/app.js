var mainModule = angular.module("mainModule", ['ngRoute']);



mainModule.config(function ($routeProvider) {
    $routeProvider

        .when('/', {
            templateUrl: '/home.html',
        })

        .when('/prijaviNestanak', {
            templateUrl: '/prijaviNestanak.html',
            controller: 'prijaviNestanakController'
        })

        .when('/prijaviDelinkventa', {
            templateUrl: '/prijaviDelinkventa.html',
            controller: 'prijaviDelinkventaController'
        })

        .when('/pretraga', {
            templateUrl: '/pretraga.html',
            controller: 'pretragaController'
        })

        .when('/statistike', {
            templateUrl: '/statistike.html',
            controller: 'statistikeController'
        });

});




