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

const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');

function switchTheme(e) {
    if (e.target.checked) {
        document.documentElement.setAttribute('data-theme', 'light');
        localStorage.setItem('theme', 'light');
        document.getElementById('logo').src='https://cdn.discordapp.com/attachments/664068594669191169/675313240669945876/logo_light_mode.png';
    }
    else {
        document.documentElement.setAttribute('data-theme', 'dark');
        localStorage.setItem('theme', 'dark');
        document.getElementById('logo').src='https://cdn.discordapp.com/attachments/664068594669191169/675313236555464704/logo_dark_mode.png';
    }
}

toggleSwitch.addEventListener('change', switchTheme, false);

const currentTheme = localStorage.getItem('theme') ? localStorage.getItem('theme') : null;

if (currentTheme) {
    document.documentElement.setAttribute('data-theme', currentTheme);

    if (currentTheme === 'light') {
        toggleSwitch.checked = true;
        document.getElementById('logo').src='https://cdn.discordapp.com/attachments/664068594669191169/675313240669945876/logo_light_mode.png';
    }
}
