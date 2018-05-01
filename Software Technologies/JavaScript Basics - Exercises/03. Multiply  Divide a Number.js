function solve(arr){
    let n = Number(arr[0]);
    let x = Number(arr[1]);
    if(x >= n){
        return console.log(n * x);
    }
    else if(n > x){
        return console.log(n / x);
    }
}