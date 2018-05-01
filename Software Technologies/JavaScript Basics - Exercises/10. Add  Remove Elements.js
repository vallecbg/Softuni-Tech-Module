function solve(arr){
    let newArr = [];
    for (let i = 0; i < arr.length; i++) {
        let inputTokens = arr[i].split(' ');
        let command = inputTokens[0];
        let number = Number(inputTokens[1]);
        if(command === "add"){
            newArr.push(number);
        }
        else if(command === "remove"){
            if(number > -1) {
                newArr.splice(number, 1);
            }
        }
    }
    for (let obj of newArr) {
        console.log(obj);
    }
}