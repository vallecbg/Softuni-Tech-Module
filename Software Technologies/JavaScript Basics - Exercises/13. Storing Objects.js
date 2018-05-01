function solve(arr){
    let object = {};
    for (let i = 0; i < arr.length; i++) {
        let inputTokens = arr[i].split(" -> ");
        let name = inputTokens[0];
        let age = inputTokens[1];
        let grade = inputTokens[2];
        object["name"] = name;
        object["age"] = age;
        object["grade"] = grade;
        console.log(`Name: ${object["name"]}`);
        console.log(`Age: ${object["age"]}`);
        console.log(`Grade: ${object["grade"]}`);
    }

}