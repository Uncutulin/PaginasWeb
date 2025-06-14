// En CommonsNuget/wwwroot/js/loader.js

function loadCSS(url) {
    const link = document.createElement('link');
    link.rel = 'stylesheet';
    link.href = url;
    document.head.appendChild(link);
}

function loadScript(url, async = true, defer = false) { // Añadido async/defer
    const script = document.createElement('script');
    script.src = url;
    script.async = async;
    script.defer = defer;
    document.body.appendChild(script); // O document.head según la necesidad
}

// La ruta base para los activos de esta biblioteca.
// Esta es la parte delicada, ya que "_content/CommonsNuget/" es una convención
// del middleware de la aplicación anfitriona.
const basePath = '/_content/CommonsNuget/'; // O una forma más robusta de determinarla

// Cargar CSS
loadCSS(basePath + 'css/adminlte.min.css');

// Cargar JS (considerar el orden y el atributo async/defer)
// jQuery a menudo necesita cargarse de forma síncrona o antes que otros que dependen de él.
// Por defecto, los scripts añadidos dinámicamente son asíncronos.
// Para forzar el orden, podrías cargarlos secuencialmente o usar callbacks/promesas.

// Ejemplo simple (podría necesitar ajustes para dependencias estrictas):
loadScript(basePath + 'js/jquery-3.7.1.min.js', false); // Intentar cargar jQuery primero, no asíncrono
loadScript(basePath + 'js/adminlte.min.js', true, true); // AdminLTE puede ser deferred