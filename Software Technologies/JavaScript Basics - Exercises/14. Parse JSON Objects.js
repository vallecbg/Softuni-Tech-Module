function solve(arr){
    for (var i = 0; i < arr.length; i++) {
        let obj = JSON.parse(arr[i]);
        let name = obj["name"];
        let age = obj["age"];
        let date = obj["date"];
        console.log(`Name: ${name}`);
        console.log(`Age: ${age}`);
        console.log(`Date: ${date}`);
    }
}