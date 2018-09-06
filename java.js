for (var i = 0; i < 25; i++) { 
 alert("STEVE JOBS!!!!!!!!!!");
}
var naam = prompt("Hoe heet jij?");
var zin = document.getElementById("naam");
alert("Welkom op deze site, " + naam);

var plaatjes = ["https://s3-storage.textopus.nl/wp-content/uploads/2011/10/19133230/Steve-Jobs-1955-2011.jpg", "https://assets.entrepreneur.com/content/3x2/1300/steve-jobs-an-extraordinary-career1.jpg?width=700&crop=2:1", "https://media.wired.com/photos/5932639bedfced5820d10022/master/w_1025,c_limit/steve-jobs.jpg", "https://www.want.nl/wp-content/uploads/2017/04/stevejobsadobe.jpg"];
var button = document.getElementById("button");
var hello_there = document.getElementById("hello_there");
var clicks = document.getElementById("aantalkliks");
var plaatje = document.getElementById("plaatje");
var getal = 0;
button.addEventListener("click", functie);
button.addEventListener("click", general_kenobi);

function functie(){
  index = Math.floor(Math.random()*plaatjes.length);
  plaatje = plaatjes[index];
  getal++;
  clicks.innerHTML = getal;
}

function general_kenobi(){
  var awnser = prompt("Hello there!");
  if (awnser == "General Kenobi"){
    alert("YEET!");
  }
  else {
    for (var i = 0; i < Infinity; i++) { 
     alert("GENERAL KENOBI!!!");
    }
  }
}
