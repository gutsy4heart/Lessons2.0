// console.log(1)
// console.log(2)
// console.log(3)
// console.log(4)
// console.log(5)
// console.log(6)
// console.log(7)
// console.log(8)
// console.log(9)
// console.log(10)


// for (let i = 1; i <= 10; i++)
// {
//    console.log(i)
// }
// i++ -> postfiksniy increment + 1
// ++i -> prefiksniy increment + 1
// i-- -> postfiksniy decrement - 1
// --i -> prefiksniy decrement - 1

// i = 5
// console.log(i)
// let result = i + 5;
// console.log(result)

// let i = 1
// while(i > 0) {
//   console.log(i)
//   i++;
// }
//
// let i = 1
// while(i <= 10) {
//   console.log(i)
//   i++;
// }

// break -> выход из цикла
// for(let i=1; i <= 10; i++)  {
//   if(i === 5){
//     break;
//   }
//   console.log(i);
// }

// continue -> пропуск итерации
// for(let i=1; i <= 10; i++)  {
//   if(i === 5){
//     continue;
//   }
//   console.log(i);
// }

// Задание 1 . Нужно посчитать количество нечетных чисел от 1 до 100
// let count = 0;
//
// for (let i = 0; i <= 100; i++) {
//   if(i % 2 !== 0){
//     console.log(i);
//     count++;
//   }
// }
// console.log(`Количество нечетных чисел: ${count}`);


// Задание 2. Посчитать факториал числа
// let n = 5
// let result = 1;
// for (let i = 1; i <= n; i++) {
//   result *= i;
//   // result = result * i
// }
// console.log(result);


// Задание 3. Вывести все буквы строки
// let text = "Hello World";
// for (let i = 0; i < text.length; i++) {
//   console.log(text[i]);
// }

// Задание 4. Посчитать количество гласных букв
// let str = 'javascript';
// let count = 0;
// let vowels = 'aeiou';
// for (let i = 0; i < str.length; i++) {
//   if(vowels.includes(str[i])) {
//     count++;
//   }
// }
// console.log(count);


// // Задание 5. Реверс числа
// let num = 12345;
// let reversed = 0;
// // 123 % 10 = 3
// // 12 % 10 = 2
// // 1 % 10 = 1
// // Overall: 321
// while(num > 0){
//   reversed = reversed * 10 + (num % 10);
//   num = Math.floor(num / 10);
// }
// console.log(reversed);