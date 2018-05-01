function solve(arr){
    let obj = {};
    for (let i = 0; i < arr.length; i++) {
        let inputTokens = arr[i].split(" -> ");
        let name = inputTokens[0];
        let info = inputTokens[1];
        if(name === "age"){
            let num = Number(inputTokens[1]);
            obj[name] = num;
        }
        else if(name === "grade"){
            let num = Number(inputTokens[1]);
            obj[name] = num;
        }
        else {
            obj[name] = info;
        }
    }
    let output = JSON.stringify(obj);
    console.log(output);
}