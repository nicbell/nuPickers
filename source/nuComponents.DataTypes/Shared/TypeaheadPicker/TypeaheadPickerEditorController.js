﻿
angular
    .module('umbraco')
    .controller("nuComponents.DataTypes.Shared.TypeaheadPicker.TypeaheadPickerEditorController",
        ['$scope', 'nuComponents.DataTypes.Shared.DataSource.DataSourceResource',
        function ($scope, dataSourceResource) {

            $scope.clear = function () {
                $scope.selectableOptions = null;
            };

            // setup a watch on the input
            $scope.$watch('typeahead', function (newValue, oldValue) {                

                if (newValue != null && newValue.length > 0) {

                    dataSourceResource.getEditorOptions($scope.model.config, newValue).then(function (response) {

                        if (response.data.length > 0) {
                            $scope.selectableOptions = response.data;
                        }
                        else {
                            $scope.typeahead = oldValue;
                        }                                                
                        
                    });

                }
                else {
                    $scope.selectableOptions = null;
                }

            });

        }]);
