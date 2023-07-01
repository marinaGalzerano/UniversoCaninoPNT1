window.document.addEventListener('DOMContentLoaded', function () {
    const catalogSelect = document.getElementById('CatalogSelect');
    const loginButton = document.getElementById('LoginButton');
    
    // Evento para redireccionar según la opción seleccionada en el catálogo
    catalogSelect.addEventListener('change', function() {
      const selectedOption = catalogSelect.value;
      if (selectedOption) {
        window.location.href = selectedOption;
      }
    });
    
    // Evento para redireccionar al hacer clic en el botón de inicio de sesión
    loginButton.addEventListener('click', function() {
      window.location.href = 'login.html';
    });    
}) 
