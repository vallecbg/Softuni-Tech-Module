function solve(arr){
    for (var i = 0; i < arr.length; i++) {
        var obj = arr[i];
        if(obj == "Stop"){
            return;
        }
        console.log(obj);
    }
}