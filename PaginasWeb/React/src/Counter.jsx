import React, { useState } from 'react';

// Un componente de contador simple
function Counter({ startValue = 0 }) {
    const [count, setCount] = useState(startValue);

    return (
        <div style={{ border: '1px solid #007bff', padding: '15px', borderRadius: '5px', textAlign: 'center' }}>
            <h4>Componente Contador (React)</h4>
            <p>Valor inicial recibido desde Razor: <strong>{startValue}</strong></p>
            <p>Contador actual: <strong>{count}</strong></p>
            <button className="btn btn-primary" onClick={() => setCount(count + 1)}>
                Incrementar
            </button>
        </div>
    );
}

export default Counter;