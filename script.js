// Responsiveness of navbar

function showSidebar(){
    const sidebar = document.querySelector('.sidebar')
    const menu = document.querySelector('.nav-item')
    sidebar.style.display = 'block'
    addEventListener('click', function(){
        menu.style.display = 'none'
    })
}
function hideSidebar(){
    const sidebar = document.querySelector('.sidebar')
    sidebar.style.display = 'none'
}

window.addEventListener('scroll', function() {
    const navbar = document.querySelector('.navbar'); // Adjust the selector to match your navbar's class or ID
    if (window.scrollY > 8) {
      navbar.classList.add('navbar-shadow');
    } else {
      navbar.classList.remove('navbar-shadow');
    }
  });