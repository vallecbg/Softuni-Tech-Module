function solve(arr){
    let count = 0;
    for (let obj of arr) {
        let num = Number(obj);
        if(num == 0){
            return console.log("Positive");
        }
        else if(num < 0){
            count++;
        }
    }
    if(count % 2 == 1)
        console.log("Negative");
    else
        console.log("Positive");
}