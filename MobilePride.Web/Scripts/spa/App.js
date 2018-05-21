(function () {
    "use strict";

    angular.module('MobilePride', ['ui.router'])
        .config(config)
        .run(run);

    config.$inject = ["$stateProvider", "$locationProvider", "$urlRouterProvider", "$httpProvider"];

    function config($stateProvider, $locationProvider, $urlRouterProvider, $httpProvider) {
        $urlRouterProvider.otherwise("/login");
        $locationProvider.hashPrefix('');
        $stateProvider
            .state('login', {
                url: "/login",
                templateUrl: "/scripts/spa/mobilePride/login/login.html",
                controller: "loginCtrl",
             })
    };

    run.$inject = [];

    function run() {

    };
})();