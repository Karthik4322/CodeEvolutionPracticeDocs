import React, { useState } from 'react';
import axios from 'axios';

const ProductForm = ({ productId }) => {
    const [product, setProduct] = useState({
        title: '',
        description: '',
        price: 0,
        images: []
    });
    const [files, setFiles] = useState([]);

    const handleChange = (e) => {
        setProduct({ ...product, [e.target.name]: e.target.value });
    };

    const handleFileChange = (e) => {
        setFiles([...e.target.files]);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        const formData = new FormData();
        formData.append('title', product.title);
        formData.append('description', product.description);
        formData.append('price', product.price);
        files.forEach((file) => {
            formData.append('images', file);
        });

        try {
            if (productId) {
                await axios.put(`http://localhost:5062/api/products/${productId}`, formData, {
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
            } else {
                await axios.post('http://localhost:5062/api/products', formData, {
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
            }
            // Redirect or show success message
        } catch (error) {
            console.error('Error saving product:', error);
        }
    };

    return (
        <form onSubmit={handleSubmit}>
            <input name="title" value={product.title} onChange={handleChange} placeholder="Title" required />
            <textarea name="description" value={product.description} onChange={handleChange} placeholder="Description" />
            <input type="number" name="price" value={product.price} onChange={handleChange} placeholder="Price" required />
            <input type="file" name="images" onChange={handleFileChange} multiple />
            <button type="submit">Save</button>
        </form>
    );
};

export default ProductForm;