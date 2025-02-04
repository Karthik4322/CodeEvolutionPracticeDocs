// import React from 'react';
// import { Carousel, Card } from 'react-bootstrap';
// import { FaStar } from 'react-icons/fa';

// // Import assets
// import Dairy from './Assets/Dairy.jpg';
// import Fruit from './Assets/Fruit.jpg';
// import Spice from './Assets/Spice.jpg';
// import Vegetables from './Assets/Vegetables.jpg';
// import person1 from './Assets/person1.jpg';
// import person2 from './Assets/person2.jpg';
// import person3 from './Assets/person3.jpg';
// import brand1 from './Assets/brand1.png';
// import brand2 from './Assets/brand2.jpg';
// import brand3 from './Assets/brand3.png';
// import brand4 from './Assets/brand4.png';

// // Reusable ProductCard Component
// const ProductCard = ({ image, title, description }) => (
//   <div className="col-md-3 mb-4">
//     <Card
//       style={{
//         boxShadow: '0 10px 20px rgba(0, 0, 0, 0.1)',
//         borderRadius: '12px',
//         overflow: 'hidden',
//         backgroundColor: '#fff',
//       }}
//     >
//       <Card.Img variant="top" src={image} alt={title} style={{ height: '250px', objectFit: 'cover' }} />
//       <Card.Body style={{ backgroundColor: 'hsl(180, 100.00%, 99.80%)' }}>
//         <Card.Title className="text-center">{title}</Card.Title>
//         <Card.Text className="text-center">{description}</Card.Text>
//       </Card.Body>
//     </Card>
//   </div>
// );

// // Reusable ReviewCard Component
// const ReviewCard = ({ image, name, reviewText, rating }) => (
//   <div className="col-md-4 mb-4">
//     <div
//       style={{
//         backgroundColor: '#f8f5e1',
//         padding: '30px',
//         borderRadius: '10px',
//         boxShadow: '0 4px 8px rgba(0, 0, 0, 0.1)',
//         textAlign: 'center',
//       }}
//     >
//       <div className="review-img" style={{ borderRadius: '50%', overflow: 'hidden', marginBottom: '20px' }}>
//         <img src={image} alt={`Customer ${name}`} style={{ width: '100px', height: '100px', objectFit: 'cover', borderRadius: '50%' }} />
//       </div>
//       <h5 style={{ fontSize: '1.2rem', fontWeight: '500' }}>{name}</h5>
//       <p style={{ fontSize: '1rem', fontStyle: 'italic', margin: '10px 0', fontWeight: '300', color: '#777' }}>
//         {reviewText}
//       </p>
//       <div className="d-flex justify-content-center">
//         {[...Array(5)].map((_, starIndex) => (
//           <FaStar key={starIndex} style={{ color: starIndex < rating ? '#FFD700' : '#ddd', fontSize: '20px' }} />
//         ))}
//       </div>
//     </div>
//   </div>
// );

// // Reusable ServiceCard Component
// const ServiceCard = ({ icon, title, description }) => (
//   <div className="col-md-3 mb-4">
//     <div
//       style={{
//         padding: '20px',
//         backgroundColor: '#333',
//         borderRadius: '10px',
//         boxShadow: 'rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px',
//         textAlign: 'center',
//       }}
//     >
//       <div style={{ fontSize: '30px', marginBottom: '15px', color: '#fff' }}>{icon}</div>
//       <span style={{ fontSize: '18px', fontWeight: 'bold', display: 'block', marginBottom: '10px', color: '#fff' }}>
//         {title}
//       </span>
//       <span style={{ fontSize: '14px', color: '#ccc' }}>{description}</span>
//     </div>
//   </div>
// );

// const Home = () => (
//   <div
//     style={{
//       background: 'linear-gradient(0deg, rgba(34,193,195,1) 0%, rgba(49,253,148,1) 100%)',
//       minHeight: '100vh',
//       paddingBottom: '50px',
//       color: '#333',
//     }}
//   >
//     {/* Carousel Section */}
//     <Carousel interval={1500}>
//       {[
//         { image: Fruit, title: 'Fresh Fruits', description: 'Handpicked fresh fruits from the farm.' },
//         { image: Spice, title: 'Premium Spices', description: 'Pure and organic spices for your kitchen.' },
//         { image: Vegetables, title: 'Healthy Vegetables', description: 'Fresh and nutritious vegetables for your health.' },
//         { image: Dairy, title: 'Dairy', description: 'Fresh and organic dairy products, straight from the farm to your table.' },
//       ].map((item, index) => (
//         <Carousel.Item key={index}>
//           <div
//             className="d-block w-100"
//             style={{
//               height: '500px',
//               position: 'relative',
//             }}
//           >
//             <img
//               src={item.image}
//               alt={`carousel-item-${index}`}
//               className="d-block w-100"
//               style={{
//                 objectFit: 'cover',
//                 height: '100%',
//                 width: '100%',
//                 objectPosition: 'center',
//               }}
//             />
//             <div className="carousel-caption d-none d-md-block">
//               <h3>{item.title}</h3>
//               <p>{item.description}</p>
//             </div>
//           </div>
//         </Carousel.Item>
//       ))}
//     </Carousel>

//     <div className="container" style={{ marginTop: '1rem', marginBottom: '3rem' }}>
//       <h3 className="text-center mb-2" style={{ fontWeight: '800', color: 'black', letterSpacing: '1px' }}>
//         Welcome To Freshio Store
//       </h3>
//       <p className="text-center mb-5" style={{ fontFamily: 'Poppins, sans-serif', fontSize: '1.2rem', lineHeight: '1.6', color: '#333', fontWeight: '500', textAlign: 'center' }}>
//         Freshio Organic Store offers a wide range of fresh, farm-to-table organic products, ensuring quality, sustainability, and healthy living. Explore our selection of fruits, vegetables, dairy, and more!
//       </p>
//     </div>

//     {/* Services Section */}
//     <div className="container my-5">
//       <h2 className="text-center mb-5" style={{ fontWeight: 'bold', color: 'black' }}>Our Services</h2>
//       <div className="row mt-5" style={{ display: 'flex', gap: '20px', justifyContent: 'space-between' }}>
//         {[
//           { title: 'Delivery', description: 'Fast and reliable delivery', icon: '🚚' },
//           { title: '100% Organic', description: 'Fresh and organic products', icon: '🍃' },
//           { title: 'Special Offers', description: 'Exclusive discounts and deals', icon: '🎉' },
//           { title: 'Free Shipping', description: 'On orders above ₹499', icon: '🆓' },
//         ].map((item, index) => <ServiceCard key={index} {...item} />)}
//       </div>
//     </div>

//     {/* Best Selling Products Section */}
//     <div className="container my-5">
//       <h2 className="text-center mb-5" style={{ fontWeight: 'bold', color: 'black' }}>Best Selling Products</h2>
//       <div className="row d-flex justify-content-between mt-5">
//         {[
//           { image: Dairy, title: 'Dairy', description: 'Fresh and organic dairy products.' },
//           { image: Vegetables, title: 'Vegetables', description: 'Handpicked vegetables from farms.' },
//           { image: Fruit, title: 'Fruits', description: 'Delicious and healthy organic fruits.' },
//           { image: Spice, title: 'Spices', description: 'Premium spices for cooking needs.' },
//         ].map((item, index) => <ProductCard key={index} {...item} />)}
//       </div>
//     </div>

//     {/* Customer Reviews Section */}
//     <div className="container my-5">
//       <h2 className="text-center mb-4" style={{ color: 'black', fontWeight: 'bold' }}>Customer Reviews</h2>
//       <div className="row">
//         {[
//           { image: person1, name: 'John Doe', reviewText: 'The organic dairy products are amazing! Fresh and tasty.', rating: 5 },
//           { image: person2, name: 'Jane Smith', reviewText: 'Handpicked organic vegetables are just top quality. Highly recommend!', rating: 4 },
//           { image: person3, name: 'Mark Johnson', reviewText: 'Delicious and fresh organic fruits. Perfect for healthy eating!', rating: 5 },
//         ].map((item, index) => <ReviewCard key={index} {...item} />)}
//       </div>
//     </div>

//     {/* Brands Section */}
//     <div className="container my-5">
//       <h2 className="text-center mb-4" style={{ color: 'black', fontWeight: 'bold' }}>Our Brands</h2>
//       <div className="row justify-content-center">
//         {[brand1, brand2, brand3, brand4].map((brand, index) => (
//           <div key={index} className="col-12 col-md-3 mb-4">
//             <div className="brand-box">
//               <img src={brand} alt={`Brand ${index + 1}`} style={{ width: '100%', height: '210px', borderRadius: '8px' }} />
//             </div>
//           </div>
//         ))}
//       </div>
//     </div>
//   </div>
// );

// export default Home;


// import React from 'react';
// import { Carousel } from 'react-bootstrap';
// import ProductCard from '../CardsComponents/ProductCard';
// import ReviewCard from '../CardsComponents/ReviewCard';
// import ServiceCard from '../CardsComponents/ServiceCard';
// import '../UserComponents/css/Home.css';

// // Import assets
// // import Dairy from '../../Assets/Dairy.jpg';
// // import Fruit from '../../Assets/Fruit.jpg';
// // import Milk from '../../Assets/milk.jpg';
// // import Apple from '../../Assets/apple.jpg';
// // import Strawberry from '../../Assets/strawberry.jpg';
// // import Potato from '../../Assets/potato.jpg';
// // import Onion from '../../Assets/onion.jpg';
// // import Egg from '../../Assets/egg.jpg';
// // import Vegetables from '../../Assets/Vegetables.jpg';
// // import person1 from '../../Assets/person1.jpg';
// // import person2 from '../../Assets/person2.jpg';
// // import person3 from '../../Assets/person3.jpg';
// // import brand1 from '../../Assets/brand1.png';
// // import brand2 from '../../Assets/brand2.jpg';
// // import brand3 from '../../Assets/brand3.png';
// // import brand4 from '../../Assets/brand4.png';
// import commonimage from '../../shared/constant/constantimage';

// const Home = () => (
//   <div
//     style={{
//       background: 'silver',
//       minHeight: '100vh',
//       paddingBottom: '30px',
//       color: '#333',
//     }}
//   >
//     {/* Carousel Section */}
    
//     <Carousel className="custom-carousel" interval={1500} style={{height: '600px', overflow: 'hidden'}}>
//   {[ 
//     { image: commonimage.home},
//     { image: commonimage.Fruit, title: 'Fresh Fruits', description: 'Handpicked fresh fruits from the farm.' },
//     { image: commonimage.Vegetables, title: 'Healthy Vegetables', description: 'Fresh and nutritious vegetables for your health.' },
//     { image: commonimage.Dairy, title: 'Dairy', description: 'Fresh and organic dairy products, straight from the farm to your table.' }
//   ].map((item, index) => (
//     <Carousel.Item key={index}>
//       <div className="d-block w-100" style={{ height: '100%' }}>
//         <img 
//           src={item.image} 
//           alt={`carousel-item-${index}`} 
//           className="d-block w-100" 
//           style={{height: '600px', objectFit: 'cover'}} 
//         />
//         <div className="carousel-caption d-none d-md-block">
//           <h3>{item.title}</h3>
//           <p>{item.description}</p>
//         </div>
//       </div>
//     </Carousel.Item>
//   ))}
// </Carousel>


//     {/* Welcome Section */}
//     <div className="container mt-3 text-center">
//       <h3 className="fw-bold text-dark">Welcome To Freshio Store</h3>
//       <p className="fw-medium text-secondary px-3">Freshio Organic Store offers a wide range of fresh, farm-to-table organic products, ensuring quality, sustainability, and healthy living.</p>
//     </div>

//     <div className="container my-5">
//       <h2 className="text-center fw-bold text-dark">Our Services</h2>
//       <div className="row mt-4 service-container">
//         {[
//           { title: 'Delivery', description: 'Fast and reliable delivery', icon: '🚚' },
//           { title: '100% Organic', description: 'Fresh and organic products', icon: '🍃' },
//           { title: 'Special Offers', description: 'Exclusive discounts and deals', icon: '🎉' },
//           { title: 'Free Shipping', description: 'On orders above ₹499', icon: '🆓' },
//         ].map((item, index) => (
//           <ServiceCard key={index} {...item} />
//         ))}
//       </div>
//     </div>


//     {/* Best Selling Products */}
// <div className="container my-5">
//        <h2 className="text-center mb-4" style={{ fontWeight: 'bold', color: 'black' }}>Top Selling Products</h2>
//        <div className="row d-flex justify-content-evenly mt-5">
//         {[
//            { image: commonimage.Milk, title: 'Milk' },
//            { image: commonimage.Apple, title: 'Apple' },
//            { image: commonimage.Strawberry, title: 'Strawberry' },
//            { image: commonimage.Potato, title: 'Potato' },
//            { image: commonimage.Onion, title: 'Onion' },
//            { image: commonimage.Egg, title: 'Egg' },
           
//          ].map((item, index) => <ProductCard key={index} {...item} />)}
//        </div>
//      </div>

//     {/* Customer Reviews */}
//     <div className="container my-5">
//       <h2 className="text-center fw-bold text-dark mb-4">Customer Reviews</h2>
//       <div className="row">
//         {[{ image: commonimage.person1, name: 'John Doe', review: 'The organic dairy products are amazing! Fresh and tasty.', rating: 4 },
//           { image: commonimage.person2, name: 'Jane Smith', review: 'Handpicked organic vegetables are just top quality.', rating: 4 },
//           { image: commonimage.person3, name: 'Mark Johnson', review: 'Delicious and fresh organic fruits. Perfect for healthy eating!', rating: 5 },
//         ].map((item, index) => <ReviewCard key={index} {...item} />)}
//       </div>
//     </div>

//     {/* Brands Section */}
//     <div className="container my-5">
//       <h2 className="text-center fw-bold text-dark mb-4">Our Brands</h2>
//       <div className="row justify-content-center">
//         {[commonimage.brand1, commonimage.brand2, commonimage.brand3, commonimage.brand4].map((brand, index) => (
//           <div key={index} className="col-12 col-md-3 mb-4 d-flex justify-content-center">
//             <img src={brand} alt={`Brand ${index + 1}`} className="brand-img" />
//           </div>
//         ))}
//       </div>
//     </div>

//   </div>
// );

// export default Home;

import React from 'react';
import { Carousel } from 'react-bootstrap';
import ProductCard from '../CardsComponents/ProductCard';
import ReviewCard from '../CardsComponents/ReviewCard';
import ServiceCard from '../CardsComponents/ServiceCard';
import '../UserComponents/css/Home.css'; // Ensure your custom styles are imported

// Import assets
import commonimage from '../../shared/constant/constantimage';

const Home = () => (
  
  <div
    style={{
      background: 'silver',
      minHeight: '100vh',
      paddingBottom: '30px',
      color: '#333',
    }}
  >
    {/* Carousel Section */}
<Carousel className="custom-carousel" interval={1500} style={{height: '600px', 
  overflow: 'hidden' /* Ensure no overflow */}}>
  {[
    { image: commonimage.home},
    { image: commonimage.Fruit, title: 'Fresh Fruits', description: 'Handpicked fresh fruits from the farm.' },
    { image: commonimage.Vegetables, title: 'Healthy Vegetables', description: 'Fresh and nutritious vegetables for your health.' },
    { image: commonimage.Dairy, title: 'Dairy', description: 'Fresh and organic dairy products, straight from the farm to your table.' }
  ].map((item, index) => (
    <Carousel.Item key={index}>
      <div className="d-block w-100" style={{ height: '100%' }}>
        <img src={item.image} alt={`carousel-item-${index}`} className="d-block w-100" style={{height: '600px'}}/>
        <div className="carousel-caption d-none d-md-block">
          <h3>{item.title}</h3>
          <p>{item.description}</p>
        </div>
      </div>
    </Carousel.Item>
  ))}
</Carousel> 


    {/* Welcome Section */}
    <div className="container mt-3 text-center">
      <h3 className="fw-bold text-dark">Welcome To Freshio Store</h3>
      <p className="fw-medium text-secondary px-3">
        Freshio Organic Store offers a wide range of fresh, farm-to-table organic products, ensuring quality, sustainability, and healthy living.
      </p>
    </div>

    {/* Services Section */}
    <div className="container my-5">
      <h2 className="text-center fw-bold text-dark">Our Services</h2>
      <div className="row mt-4 service-container">
        {[ 
          { title: 'Delivery', description: 'Fast and reliable delivery', icon: '🚚' },
          { title: '100% Organic', description: 'Fresh and organic products', icon: '🍃' },
          { title: 'Special Offers', description: 'Exclusive discounts and deals', icon: '🎉' },
          { title: 'Free Shipping', description: 'On orders above ₹499', icon: '🆓' }
        ].map((item, index) => <ServiceCard key={index} {...item} />)}
      </div>
    </div>

    {/* Best Selling Products Section */}
    <div className="container my-5">
      <h2 className="text-center mb-4" style={{ fontWeight: 'bold', color: 'black' }}>Top Selling Products</h2>
      <div className="row d-flex justify-content-evenly mt-5">
        {[ 
          { image: commonimage.Milk, title: 'Milk' },
          { image: commonimage.Apple, title: 'Apple' },
          { image: commonimage.Strawberry, title: 'Strawberry' },
          { image: commonimage.Potato, title: 'Potato' },
          { image: commonimage.Onion, title: 'Onion' },
          { image: commonimage.Egg, title: 'Egg' }
        ].map((item, index) => <ProductCard key={index} {...item} />)}
      </div>
    </div>

    {/* Customer Reviews Section */}
<div className="container my-5">
  <h2 className="text-center fw-bold text-dark mb-4">Customer Reviews</h2>
  <div className="row">
    {[ 
      { image: commonimage.person1, name: 'John Doe', review: 'The organic dairy products are amazing! Fresh and tasty.', rating: 4 },
      { image: commonimage.person2, name: 'Jane Smith', review: 'Handpicked organic vegetables are just top quality.', rating: 4 },
      { image: commonimage.person3, name: 'Mark Johnson', review: 'Delicious and fresh organic fruits. Perfect for healthy eating!', rating: 5 }
    ].map((item, index) => (
      <ReviewCard key={index} {...item} />
    ))}
  </div>
</div>


    {/* Brands Section */}
    <div className="container my-5">
      <h2 className="text-center fw-bold text-dark mb-4">Our Brands</h2>
      <div className="row justify-content-center">
        {[commonimage.brand1, commonimage.brand2, commonimage.brand3, commonimage.brand4].map((brand, index) => (
          <div key={index} className="col-12 col-md-3 mb-4 d-flex justify-content-center">
            <img src={brand} alt={`Brand ${index + 1}`} className="brand-img" />
          </div>
        ))}
      </div>
    </div>

  </div>
);

export default Home;

