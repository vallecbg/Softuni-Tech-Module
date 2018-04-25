const Sequelize = require('sequelize');

module.exports = function(sequelize){
    let Film = sequelize.define('Film', {
        name:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        genre:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        director:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        year:{
            type: Sequelize.INTEGER,
            allowNull: false,
            required: true
        }
    }, {
        timestamps:false
    });


    return Film;
};