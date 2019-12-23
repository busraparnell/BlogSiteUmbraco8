angular.module("umbraco").controller("WordCounterApp", function($scope, editorState, userService, contentResource) {
    var vm = this;
    vm.CurrentNodeId = editorState.current.id;
    vm.CurrentNodeAlias = editorState.current.contentTypeAlias;

    var counter = contentResource.getById(vm.CurrentNodeId).then(function (node) {
        var properties = node.variants[0].tabs[0].properties;
        
        vm.propertyWordCount = {};

        var index;
        for (index = 0; index < properties.length; ++index) {
            var words = properties[index].value;
            var wordCount = words.trim().split(/\s+/).length;

            vm.propertyWordCount[properties[index].label] = wordCount;
            if (wordCount > 1) {
                vm.propertyWordCount[properties[index].label] = wordCount + " words.";
            } else {
                vm.propertyWordCount[properties[index].label] = wordCount + " word.";
            }
        }
    });

    var user = userService.getCurrentUser().then(function(user) {
        vm.UserName = user.name;
    });
    $scope.model.badge = {
        count: 5, // the number for the badge - anything non-zero triggers the badge
        type: "warning" // optional: determines the badge color - "warning" = dark yellow, "alert" = red, anything else = blue (matching the top-menu background color)
    };
});
