const homeController = require('./../controllers/home');

module.exports = (app) => {
    app.get('/', homeController.indexGet);
};

