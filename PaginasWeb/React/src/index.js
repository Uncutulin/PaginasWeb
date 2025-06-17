import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css'; // <-- ESTA ES LA LÍNEA CLAVE QUE FALTA
import Counter from './Counter';

// Busca el div con el id 'react-counter-container' en la página
const container = document.getElementById('react-counter-container');

if (container) {
    // Obtiene el valor inicial del atributo data-*
    const startValue = parseInt(container.dataset.startValue, 10) || 0;

    // Crea la raíz de React y renderiza el componente
    const root = ReactDOM.createRoot(container);
    root.render(<Counter startValue={startValue} />);
}

// ...