// webpack.config.js

const path = require('path');

module.exports = {
    mode: 'development',
    entry: './src/index.js',
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: 'react-bundle.js'
    },
    module: {
        rules: [
            // Esta regla es para procesar JavaScript (JSX) con Babel.
            // Seguramente ya la tienes.
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader'
                }
            },

            // ¡ESTA ES LA PARTE QUE SOLUCIONA TU ERROR!
            // Añade esta regla si no la tienes, o corrígela si está mal.
            {
                test: /\.css$/,
                use: [
                    'style-loader',   // 2. Inyecta el CSS final en la página.
                    'css-loader',     // 1. Resuelve los imports de CSS.
                    'postcss-loader'  // 0. Procesa el CSS con PostCSS y Tailwind.
                ]
            }
        ]
    },
    resolve: {
        extensions: ['.js', '.jsx']
    }
};