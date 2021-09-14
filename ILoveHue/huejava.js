var input1 = document.getElementById("input1");
var input2 = document.getElementById("input2");
var uitslag = document.getElementById("uitslag");
var generateButton = document.getElementById("generateButton");
var lampAanOfUitButton = document.getElementById("lampAanOfUitButton");
var feedback = document.getElementById("feedback");

generateButton.addEventListener("click", geefUitslag);

function geefUitslag() {
  var procent = input1.value.length * input2.value.length * 19;
  while (procent > 100) {
    procent = procent - 100;
  }
  if (input1.value == "") {
    uitslag.innerHTML = "0%";
    feedback.innerHTML = "Vul allebei de vakjes in.";
  }
  else if (input2.value == "") {
    uitslag.innerHTML = "0%";
    feedback.innerHTML = "Vul allebei de vakjes in.";
  }
  else if (input1.value == input2.value) {
    uitslag.innerHTML = "100%";
    feedback.innerHTML = "Egoïst.";
  }
  else if (procent < 25) {
    uitslag.innerHTML = procent + "%";
    feedback.innerHTML = "Nope.";
  }
  else if (procent < 50) {
    uitslag.innerHTML = procent + "%";
    feedback.innerHTML = "Misschien.";
  }
  else if (procent < 75) {
    uitslag.innerHTML = procent + "%";
    feedback.innerHTML = "Veel kans.";
  }
  else {
    uitslag.innerHTML = procent + "%";
    feedback.innerHTML = "Perfect.";
  }
}
