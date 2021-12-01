//#region Task1
// let number1 = parseInt(prompt());
// let number2 = parseInt(prompt());
// let result = number1 + number2;

// if (number1 == number2) {
//     console.log(result * 3);
// } else {
//     console.log(result);
// }
//#endregion
//#region Task2
// let num1 = parseInt(prompt());
// let num2 = parseInt(prompt());

// console.log("Is first number positive?")
// if (num1 > 0) {
//     console.log("Yes first number is positive")
// } else {
//     console.log("No")
// }

// console.log("Is second number negative?")
// if (num2 < 0) {
//     console.log("Yes second number is negative")
// } else {
//     console.log("No")
// }
//#endregion
//#region Task3
// function RecrangleArea(x, y) {
//     console.log("Uzunlugu daxil edin: ")
//     x = parseInt(prompt());
//     console.log("Eni daxil edin: ")
//     y = parseInt(prompt());
//     let result2 = x * y;
//     return result2;
// }

// console.log("Duzbucaqlinin sahe cavabi: " + RecrangleArea());
//#endregion
//#region Task4
// for (let i = 1; i < 1000; i++) {
//     if (i % 3 == 0 && i % 5 == 0) {
//         console.log(i);
//     }
// }
//#endregion
//#region Task5
// for (let i = 0; i < 5; i++) {
//     for (let j = 0; j <= i; j++) {
//         document.write(" " + "*");
//     }
//     document.write("<br>")
// }
//#endregion
//#region Task6
//////Yalniz Musbet ededler ucun*
function reverseNumber(numrev) {

    return (

        parseFloat(
            numrev = prompt()
            .toString()
            .split('')
            .reverse()
            .join('')
        ) * Math.sign(numrev)
    )
}
console.log(reverseNum());
//#endregion