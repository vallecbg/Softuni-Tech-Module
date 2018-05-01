function solve(arr){
    let newArr = [];
    let count = Number(arr[0]);
    for (let i = 1; i < arr.length; i++) {
        let obj = arr[i].split(" - ");
        let index = Number(obj[0]);
        let value = Number(obj[1]);
        newArr[index] = value;
    }
    for (var i = 0; i < count; i++) {
        var obj = Number(newArr[i]);
        if(isNaN(obj))
            obj = 0;
        console.log(obj);
    }
}