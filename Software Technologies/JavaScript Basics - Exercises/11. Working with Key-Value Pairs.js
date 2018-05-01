function solve(arr){
    let object = {};
    for (let i = 0; i < arr.length - 1; i++) {
        let inputTokens = arr[i].split(' ');
        let key = inputTokens[0];
        let value = inputTokens[1];
        object[key] = value;
    }
    let outputKey = arr[arr.length - 1];
    if(object[outputKey] === undefined){
        console.log("None");
        return;
    }
    console.log(object[outputKey])
}