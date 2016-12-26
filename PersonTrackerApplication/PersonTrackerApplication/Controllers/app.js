var mainModule = angular.module("mainModule", ['ngRoute']);



mainModule.config(function ($routeProvider) {
    $routeProvider

        .when('/', {
            templateUrl: '/home.html',
            controller: 'homePretragaController'
        })

        .when('/prijaviNestanak', {
            templateUrl: '/prijaviNestanak.html',
            controller: 'prijaviNestanakController'
        })

        .when('/prijaviDelinkventa', {
            templateUrl: '/prijaviDelinkventa.html',
            controller: 'prijaviDelinkventaController'
        })
        .when('/statistike', {
            templateUrl: '/statistike.html',
            controller: 'statistikeController'
        });

});