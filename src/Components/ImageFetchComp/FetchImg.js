import {React,useState,useEffect} from 'react'

function FetchImg() {
    const [productImages, setProductImages] = useState({
       
        fruits: {
            kiwi: ".../productimages/kiwi.png"
            lemon: ".../productimages/lemon.png"
            mulberry: ".../productimages/mulberry.png"
            strawberry: ".../productimages/strawberry.png"
            apple: ".../productimages/apple.png"
            banana: ".../productimages/banana.png"
            
          },
        vegetables: {
          potato: ".../productimages/potato.png"
          redonion: ".../productimages/redonion.png"
          cucumber: ".../productimages/cucumber.png"
          beetroot: ".../productimages/potato.png"
          tomato: ".../productimages/potato.png"
          carrot: ".../productimages/potato.png"
          greenchilli: ".../productimages/greenchilli.png"
          greenbell: ".../productimages/greenbell.png"
          
        },
        essentials: {
            milk: ".../productimages/milk.png"
            cookingoil: ".../productimages/cookingoil.png"
            rice: ".../productimages/rice.png"
            water: ".../productimages/water.png"
            proteinpowder: ".../productimages/proteinpowder.png"
              
          },
          eggandmeat: {
            chicken: ".../productimages/chicken.png"
            egg: ".../productimages/egg.png"
            fish: ".../productimages/fish.png"          
          },
      });
    
      useEffect(() => {
        fetch("http://localhost:5062/api/products")
          .then(response => response.json())
          .then(data => setProducts(data));
      }, []);
          
      {products.map((product) => {
        const category = product.Category.toLowerCase();
        const productName = product.Title.toLowerCase();
        
        const imageSrc =
          productImages[category]?.[productName] ||  // Check if category & product exist in state
          product.Images?.[0] ||  // Use backend image if available
          `/images/${category}/default.jpg`; // Fallback default category image
      
        return (
          <div key={product.productId} className="card">
            <img src={imageSrc} alt={product.Title} />
            <h3>{product.Title}</h3>
            <p>{product.Description}</p>
            <p>Category: {product.Category}</p>
          </div>
        );
      })}
      
}

export default FetchImg