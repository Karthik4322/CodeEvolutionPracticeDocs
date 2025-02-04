import React, { useState, useEffect } from 'react';
import './css/ProductPage.css'; // Import CSS for styling

const ProductPage = () => {
  // State for products, search term, selected category, loading status, and cart
  const [products, setProducts] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [selectedCategory, setSelectedCategory] = useState('All');
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [cart, setCart] = useState([]); // Cart state
  const [isLoggedIn, setIsLoggedIn] = useState(false); // Login state

  // Fetch products from the backend API
  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await fetch('http://localhost:5062/api/products'); // Replace with your backend API endpoint
        if (!response.ok) {
          throw new Error('Failed to fetch products');
        }
        const data = await response.json();
        setProducts(data);
      } catch (error) {
        setError(error.message);
      } finally {
        setLoading(false);
      }
    };

    fetchProducts();
  }, []);

  // Handle search input change
  const handleSearchChange = (event) => {
    setSearchTerm(event.target.value);
  };

  // Handle category dropdown change
  const handleCategoryChange = (event) => {
    setSelectedCategory(event.target.value);
  };

  // Handle adding a product to the cart
  const handleAddToCart = (product) => {
    setCart([...cart, product]); // Add product to cart
    alert(`${product.title} added to cart!`);
  };

  // Handle viewing the cart
  const handleViewCart = () => {
    if (!isLoggedIn) {
      alert('Please log in to view your cart.'); // Prompt to log in
    } else {
      // Redirect to cart page or show cart details navigation of login page
      alert('Redirecting to cart page...');
    }
  };

  // Filter products based on search term and selected category
  const filteredProducts = products.filter((product) => {
    const matchesSearch = product.title.toLowerCase().includes(searchTerm.toLowerCase());
    const matchesCategory = selectedCategory === 'All' || product.category === selectedCategory;
    return matchesSearch && matchesCategory;
  });

  // Display loading or error messages
  if (loading) {
    return <div className="loading">Loading...</div>;
  }

  if (error) {
    return <div className="error">Error: {error}</div>;
  }

  return (
    <div className="product-page">
      {/* Search Bar */}
      <div className="search-bar">
        <input
          type="text"
          placeholder="Search products..."
          value={searchTerm}
          onChange={handleSearchChange}
        />
      </div>

      {/* Category Dropdown */}
      <div className="category-filter">
        <label htmlFor="category">Category: </label>
        <select id="category" value={selectedCategory} onChange={handleCategoryChange}>
          <option value="All">All</option>
          <option value="Fruits">Fruits</option>
          <option value="Dairy">Dairy</option>
          <option value="Vegetables">Vegetables</option>
          {/* Add more categories as needed */}
        </select>
      </div>

      {/* Product Cards */}
      <div className="product-list">
        {filteredProducts.length > 0 ? (
          filteredProducts.map((product) => (
            <div key={product.productId} className="product-card">
              <img src={product.thumbnail} alt={product.title} />
              <h3>{product.title}</h3>
              <p>₹{product.price.toFixed(2)}</p>
              <div className="button-group">
                <button
                  onClick={() => handleAddToCart(product)}
                  disabled={cart.some((item) => item.productId === product.productId)} // Disable if product is in cart
                >
                  Add to Cart
                </button>
                <button onClick={handleViewCart}>View Cart</button>
              </div>
            </div>
          ))
        ) : (
          <div className="no-results">No products found.</div>
        )}
      </div>
    </div>
  );
};

export default ProductPage;