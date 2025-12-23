// // Пустой массив
// var arr = new Array();
//
// const length = 10;
// // Масив заданной длины
// var arr2 = new Array(length);

// arr2.fill(0);
// arr2.fill(1);
// arr2.fill(2);
// arr2.fill(3);
// arr2.fill(4);
// arr2.fill(5);
// arr2.fill(6);
// arr2.fill(7);
// arr2.fill(8);
// arr2.fill(9);
// arr2.fill(11);

// arr2[0] = 1;
// arr2[1] = 2;
// arr2[2] = 3;
// arr2[3] = 4;
// arr2[4] = 5;
// arr2[5] = 6;
// arr2[6] = 7;
// arr2[7] = 8;
// arr2[8] = 9;
// arr2[9] = 10;
// arr2[10] = 11;
// arr2[11] = 12;
// arr2[12] = 13;
//
//
// for (let i = 0; i < 13; i++) {
//   console.log(arr2[i]);
// }


// var arr = [1, 2, 3, 4, 5];
// var index = arr.indexOf(4);     // 0 _____> 9
// //var index = arr.lastIndexOf(); // 0 <_____ 9
// console.log(`Index: ${index}`);
//
// index = arr.indexOf(598); // если указанного числа несуществует, то дает -1
// console.log(index);


// var arr = [51, -2, 69, -32, 0, 66, 78, 39, -41];
//
// var counter = 0;
// var index = arr.indexOf(65);
// while(index !== -1) {
//   counter++; // Инкремент(+) counter = counter + 1 тоже самое что и counter += 1;
//   index = arr.indexOf(65, index + 1);
//
// }
// console.log(counter);
