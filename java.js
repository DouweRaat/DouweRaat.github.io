alert("STEVE JOBS!!!!!!!!!!");
var plaatjes = ["https://s3-storage.textopus.nl/wp-content/uploads/2011/10/19133230/Steve-Jobs-1955-2011.jpg", "https://assets.entrepreneur.com/content/3x2/1300/steve-jobs-an-extraordinary-career1.jpg?width=700&crop=2:1", "https://media.wired.com/photos/5932639bedfced5820d10022/master/w_1025,c_limit/steve-jobs.jpg", "https://www.want.nl/wp-content/uploads/2017/04/stevejobsadobe.jpg"];
var button = document.getElementById("button");
var clicks = document.getElementById("aantalkliks");
var getal = 0;
button.addEventListener("click", verander, berekenClicks);

function verander(){
  index = Math.floor(Math.random()*plaatjes.length);
  plaatje.src = plaatjes[index];
}

function berekenClicks() {
  getal++;
  clicks.innerHTML = getal;
}
