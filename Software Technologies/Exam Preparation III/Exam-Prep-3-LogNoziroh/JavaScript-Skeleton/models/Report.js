const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Report = sequelize.define('Report', {
        status:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        message:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        origin:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        }
    }, {
        timestamps: false
    });

    return Report;
};