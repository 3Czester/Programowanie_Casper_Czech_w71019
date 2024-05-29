

// let tablica = [];
// for (let i = 0 ; i<10; i++){
//      tablica[i] = parseFloat(prompt("Podaj liczby: "));
// }

// console.log(tablica);

// let liczba = parseFloat(prompt("Podaj szukaną liczbę: "));

// console.log(liczba);

// let licznik = 0;

// for (let i = 0 ; i<10; i++){
//     if(tablica[i] == liczba){
//         licznik += 1;}
// }

// console.log(licznik)


// let tablica = [1,2,3,4,5,6];
// console.log(tablica);
// let liczba = parseInt(prompt("Podaj liczbę całkowitą: "));
// let index = parseInt(prompt("Podaj indeks: "));
// tablica.splice(index, 0, liczba);
// console.log(tablica);
// console.log(tablica.reverse());

// let dlugosc = parseInt(prompt("Jak długa ma być tablica? "));
// let dolnaG = parseInt(prompt("Dolna granica losowania: "));
// let gornaG = parseInt(prompt("Gorna granica losowania: "));

// let tablica = [];

// for (let i = 0; i<dlugosc; i++){
//     tablica.push(Math.floor(Math.random()*(dolnaG+gornaG+1)-dolnaG));
// }
// console.log(tablica);

//5
// let tablica = [1,2,3,4,5,6,7,8,9,10];

// let suma = tablica.reduce(function(licz, liczba){
//     return licz + liczba;
// }, 0);
// console.log('Suma wartości:', suma);

// let parzyste = tablica.filter(function(liczba){
//     return liczba % 2 == 0;
// });
// console.log('Liczby parzyste:', parzyste);

// let mnozenie_3 = tablica.map(function(liczba){
//     return liczba * 3;
// });
// console.log('Pomnożone przez 3:', mnozenie_3);

// let album = 67201;
// let tab = tablica.push(album);
// let indeks = tablica.indexOf(album);
// console.log('Tablica z albumem:', tab);
// console.log('Index w talicy:', indeks);

// let srednia = suma / tablica.length;
// console.log('Średnia arytmetyczna:', srednia);

// let najw = Math.max.apply(null, tablica);
// console.log('Najwieksza liczba:', najw);

// let szukana = 2;
// let wystopienia = tablica.filter(function(liczba){
//     return liczba;
// }).length;
// console.log('Ilość:', szukana + ':', wystopienia);

//6
// function Fibonacci(n) {
//     const fibonacci = [0, 1]; 
//     for (let i = 2; i < n; i++) {
//         fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
//     }
//     return fibonacci;
// }
// const fibonacci100 = Fibonacci(100);
// console.log('Pierwsze 100 liczb Fibonacciego:', fibonacci100);

// let tablica = [1,5,6,8,332,53,23];
// function suma(tab){
// tablica.sort(function(a,b){
//     return b - a;
// });
// return tablica[0]+tablica[1];
// }
// let wynik = suma(tablica);
// console.log('Suma najwiekszych liczb:', wynik);

// function duplikaty(tab){
//     let tablica = [];
//     for (let i =0;i<Array.length; i++){
//         if(tablica.indexOf(tab[i])=== -1){
//             tablica.push(tab[i])
//         }
//     }
//     return tablica;
// }
// let tablica = [1,1,2,2,3,3,4,5,6,6,7,7,8,8];
// let usunieta = duplikaty(tablica);
// console.log('Tablica bez duplikatów: ', usunieta);