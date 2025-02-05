import React, { useState, useEffect } from 'react';

function ProductPage() {
    const [products, setProducts] = useState([]);
    const [productImages] = useState({
        fruits: {
            kiwi: "../productimages/kiwi.png",
            lemon: "../productimages/lemon.png",
            mulberry: "../productimages/mulberry.png",
            strawberry: "../productimages/strawberry.png",
            apple: "../productimages/apple.png",
            banana: "../productimages/banana.png",
        },
        vegetables: {
            potato: "../productimages/potato.png",
            redonion: "../productimages/redonion.png",
            cucumber: "../productimages/cucumber.png",
            beetroot: "../productimages/beetroot.png",
            tomato: "../productimages/tomato.png",
            carrot: "../productimages/carrot.png",
            greenchilli: "../productimages/greenchilli.png",
            greenbell: "../productimages/greenbell.png",
        },
        essentials: {
            milk: "../productimages/milk.png",
            cookingoil: "../productimages/cookingoil.png",
            rice: "../productimages/rice.png",
            water: "../productimages/water.png",
            proteinpowder: "../productimages/proteinpowder.png",
        },
        eggandmeat: {
            chicken: "../productimages/chicken.png",
            egg: "../productimages/egg.png",
            fish: "../productimages/fish.png",
        },
    });
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchProducts = async () => {
            try {
                const response = await fetch("http://localhost:5062/api/products");
                if (!response.ok) {
                    throw new Error("Failed to fetch products");
                }
                const data = await response.json();
                setProducts(data.map((product) => ({
                    ProductId: product.ProductId,
                    Title: product.Title,
                    Description: product.Description,
                    Price: product.Price,
                    Weight: product.Weight,
                    Images: product.Images,
                    Category: product.GetProductCategoryKey(),
                })));
            } catch (error) {
                setError(error.message);
            } finally {
                setLoading(false);
            }
        };

        fetchProducts();
    }, []);

    if (loading) return <div>Loading...</div>;
    if (error) return <div>Error: {error}</div>;

    return (
        <div className="product-container">
            {products.map((product) => {
                console.log("Product details:", product);
                const imageSrc =
                    productImages[product.Category]?.[product.Title.toLowerCase().replace(/\s+/g, '')] || // Check if category & product exist in state, remove spaces for product name
                    (product.Images && product.Images.length > 0 ? product.Images[0] : '/images/default.jpg'); // Use backend image if available, otherwise fallback

                return (
                    <div key={product.ProductId} className="card">
                        <img src={imageSrc} alt={product.Title} />
                        <h3>{product.Title}</h3>
                        <p>{product.Description}</p>
                        <p>Weight: {product.Weight}g</p>
                        <p>Price: ₹{product.Price.toFixed(2)}</p>
                        <p>Category: {product.Category}</p>
                    </div>
                );
            })}
        </div>
    );
}

export default ProductPage;