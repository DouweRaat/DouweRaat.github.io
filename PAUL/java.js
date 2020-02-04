function openNav() {
  if (screen.width > 1023) {
    document.getElementById("mySidenav").style.width = "250px";
  }
  else {
    document.getElementById("mySidenav").style.width = "400px";
  }
}

function closeNav() {
document.getElementById("mySidenav").style.width = "0";
}
