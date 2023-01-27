function friendController($scope, $http) {
    $scope.loading = true;
    $scope.addMode = false;

    //Used to display the data  
    $http.get('/api/Friend/').success(function (data) {
        $scope.friends = data;
        $scope.loading = false;
    })
        .error(function () {
            $scope.error = "An Error has occured while loading posts!";
            $scope.loading = false;
        });

    $scope.toggleEdit = function () {
        this.friend.editMode = !this.friend.editMode;
    };
    $scope.toggleAdd = function () {
        $scope.addMode = !$scope.addMode;
    };

    //Used to save a record after edit  
    $scope.save = function () {
        alert("Edit");
        $scope.loading = true;
        var frien = this.friend;
        alert(emp);
        $http.put('/api/Friend/', frien).success(function (data) {
            alert("Saved Successfully!!");
            emp.editMode = false;
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Saving Friend! " + data;
            $scope.loading = false;

        });
    };

    //Used to add a new record  
    $scope.add = function () {
        $scope.loading = true;
        $http.post('/api/Friend/', this.newfriend).success(function (data) {
            alert("Added Successfully!!");
            $scope.addMode = false;
            $scope.friends.push(data);
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Adding Friend! " + data;
            $scope.loading = false;

        });
    };

    //Used to edit a record  
    $scope.deletefriend = function () {
        $scope.loading = true;
        var friendid = this.friend.FriendId;
        $http.delete('/api/Friend/' + friendid).success(function (data) {
            alert("Deleted Successfully!!");
            $.each($scope.friends, function (i) {
                if ($scope.friends[i].FriendId === friendid) {
                    $scope.friends.splice(i, 1);
                    return false;
                }
            });
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Saving Friend! " + data;
            $scope.loading = false;

        });
    };

}