// //1a
// for (let i=10; i>=0; i--){
//  console.log(i)
// }
// console.log("Happy New Year!!");
// //1b
// let i=10
// while(i>=0){
//     console.log(i);
//     i--;
// }
// console.log("Happy New Year!!");

//2
// function silnia(n){
//     let m = 1;
//     for (let i=1;i<=n; i++){
//         m*=1;
//     }
//     return m;
// }
// console.log(silnia(5))

// //3

// function pelnoletniosc(n){
//     if(n < 18){
//         window.open("https://www.w3schools.com");
//     }
//     else
//     {
//         alert("Jesteś pełnoletni!");
//     }
// }
// pelnoletniosc(19);

// //4

// const zad4 = (clickedBtn) => {
//     document.querySelectorAll('.butt').forEach((btn) => {
//         btn.classList.remove('active')
//     })
//     clickedBtn.classList.add('active')
// }
// zad4('red')

// //5

// function showHide(id) {
//     var el = document.getElementById(id);
//     if (el.style.display === "block") {
//       el.style.display = "none";
//     } else {
//       el.style.display = "block";
//     }
//   }

//6
// function dodaj(){
//     let item = document.getElementById('zad6').value;
//     let lista = document.getElementById('lista');
//     let li = document.getElementById('li');

//     li.innerHTML = item;
//     lista.appendChild(li);
// }

//7

// function tablica(){
//     let imie = document.getElementById("imie").value;
//     let nazwisko = document.getElementById("nazwisko").value;
//     let tabela = document.getElementById("table");
//     let wiersz = document.createElement('tr');
//     let kolumna_imie = document.createElement('td');
//     let kolumna_nazwisko = document.createElement('td');

//     kolumna_imie.innerHTML=imie;
//     kolumna_nazwisko.innerHTML=nazwisko;

//     wiersz.appendChild(kolumna_imie);
//     wiersz.appendChild(kolumna_nazwisko);
//     tabela.appendChild(wiersz);

//     document.getElementById("imie").value=' ';
//     document.getElementById("nazwisko").value=' ';
// }

//8

// function temperatura(celc){
//     let celcjusz = document.getElementById("zad8").value;
//     let farenhajt = (celcjusz * 2) + 30;
//     document.getElementById('wynik').innerHTML = farenhajt;

// }