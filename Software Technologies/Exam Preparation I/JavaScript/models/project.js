const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Project = sequelize.define('Project',{
        Title:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        Description:{
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        Budget:{
            type: Sequelize.INTEGER,
            allowNull: false,
            required: true
        }
    },{
        timestamps:false
    });

    return Project;
};