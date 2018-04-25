const Product = require('../models').Product;

module.exports = {
	index: (req, res) => {
		Product.findAll().then(products => {
			res.render('product/index', {'entries':products});
		});
	},

	createGet: (req, res) => {
		res.render('product/create');
	},

	createPost: (req, res) => {
		let args = req.body;
		Product.create(args).then(() => {
			res.redirect('/');
		})
	},

	editGet: (req, res) => {
		let id = req.params.id;

		Product.findById(id).then(product => {
			res.render("product/edit", product.dataValues);
		})
	},

	editPost: (req, res) => {
		let id = req.params.id;
		let body = req.body;

		Product.findById(id).then(product => {
			product.updateAttributes(body).then(() => {
				res.redirect('/');
			})
		})
	}
};