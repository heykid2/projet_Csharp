﻿const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/navalwar",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:5297',
        secure: false
    });

    app.use(appProxy);
};
