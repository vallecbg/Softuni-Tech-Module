const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Task = sequelize.define('Task', {
        title:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        status:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        }
    }, {
        timestamps: false
    });

    return Task;
};