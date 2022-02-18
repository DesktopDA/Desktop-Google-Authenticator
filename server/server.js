const express = require('express');
const port = 4000;

const app = express();

app.all('*', function (req, res, next) {
    res.header('Access-Control-Allow-Origin', '*');
    res.header('Access-Control-Allow-Methods', 'PUT, GET, POST, DELETE, OPTIONS');
    res.header('Access-Control-Allow-Headers', 'Content-Type');
    next();
});

require('./routes/general.route')(app);

app.listen(port, () => {
    console.log('Init Server ... ' + port);
});