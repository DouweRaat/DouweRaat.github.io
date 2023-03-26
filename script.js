//<------------------------------------------------ Image switcher ------------------------------------------------------------>

legoImage = document.getElementById('LEGOimage');
legoImages = ['images/LEGO1.png', 'images/LEGO2.jpg', 'images/LEGO3.png', 'images/LEGO4.jpg'];
var legoIndex = 1;

holoImage = document.getElementById('HOLOimage');
holoImages = ['images/HOLO1.jpg', 'images/HOLO2.jpg'];
var holoIndex = 1;

questImage = document.getElementById('QUESTimage');
questImages = ['images/QUEST1.png', 'images/QUEST2.png'];
var questIndex = 1;

bobImage = document.getElementById('BOBimage');
bobImages = ['images/BOB1.PNG', 'images/BOB2.PNG', 'images/BOB3.PNG', 'images/BOB4.PNG', 'images/BOB5.PNG', 'images/BOB6.PNG', 'images/BOB7.PNG', 'images/BOB8.PNG', 'images/BOB9.PNG'];
var bobIndex = 1;

cppImage = document.getElementById('CPPimage');
cppImages = ['images/C++1.svg.png', 'images/C++2.jpg'];
var cppIndex = 1;

function updateImages() {
    legoImage.src = legoImages[legoIndex];
    legoIndex = (legoIndex + 1) % legoImages.length;
    holoImage.src = holoImages[holoIndex];
    holoIndex = (holoIndex + 1) % holoImages.length;
    questImage.src = questImages[questIndex];
    questIndex = (questIndex + 1) % questImages.length;
    bobImage.src = bobImages[bobIndex];
    bobIndex = (bobIndex + 1) % bobImages.length;
    cppImage.src = cppImages[cppIndex];
    cppIndex = (cppIndex + 1) % cppImages.length;
}
setInterval(updateImages, 5000)

//<------------------------------------------------ Pop-up code ------------------------------------------------------------>
//Lego
var legoModal = document.getElementById("legoModal");
var legoSpan = document.getElementsByClassName("close")[0];

legoImage.onclick = function() {
    legoModal.style.display = "block";
}

legoSpan.onclick = function() {
    legoModal.style.display = "none";
}

//holo
var holoModal = document.getElementById("holoModal");
var holoSpan = document.getElementsByClassName("close")[1];

holoImage.onclick = function() {
    holoModal.style.display = "block";
}

holoSpan.onclick = function() {
    holoModal.style.display = "none";
}

//quest
var questModal = document.getElementById("questModal");
var questSpan = document.getElementsByClassName("close")[2];

questImage.onclick = function() {
    questModal.style.display = "block";
}

questSpan.onclick = function() {
    questModal.style.display = "none";
}

//bob
var bobModal = document.getElementById("bobModal");
var bobSpan = document.getElementsByClassName("close")[3];

bobImage.onclick = function() {
    bobModal.style.display = "block";
}

bobSpan.onclick = function() {
    bobModal.style.display = "none";
}

//cpp
var cppModal = document.getElementById("cppModal");
var cppSpan = document.getElementsByClassName("close")[4];

cppImage.onclick = function() {
    cppModal.style.display = "block";
}

cppSpan.onclick = function() {
    cppModal.style.display = "none";
}

window.onclick = function(event) {
    if (event.target == legoModal) {
        legoModal.style.display = "none";
    }
    else if (event.target == holoModal) {
        holoModal.style.display = "none";
    }
    else if (event.target == questModal) {
        questModal.style.display = "none";
    }
    else if (event.target == bobModal) {
        bobModal.style.display = "none";
    }
    else if (event.target == cppModal) {
        cppModal.style.display = "none";
    }
}