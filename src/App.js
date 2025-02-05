// import logo from './logo.svg';
// import './App.css';

// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }
// import React from 'react';
// import LandingPage from './LandingPage';

// const App = () => {
//   return <LandingPage />;
// };

// export default App;


// export dfault App;
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Header from './Components/HeaderComponent/Header';
import Home from './Components/UserComponents/Home';
import Footer from './Components/FooterComponent/Footer';
import AboutUs from './Components/UserComponents/AboutUs';
import AllProducts from './Components/UserComponents/AllProducts';
import ContactUs from './Components/UserComponents/ContactUs';
import { Cart } from 'react-bootstrap-icons';
import ProductPage from './Components/UserComponents/ProductPage'
import ProductDetail from './Components/ProductComponents/ProductDetail'
import ProductForm from './Components/ProductComponents/ProductForm'
import ProductList from './Components/ProductComponents/ProductList'
const App = () => {
  return (
    <Router>
      <Header />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/" element={<AboutUs />} />
        <Route path="products" element={<ProductPage/>} />
        <Route path="/" element={<ContactUs />} />
        <Route path="/" element={<Cart />} />
        <Route path="/" element={<ProductPage/>} />
        <Route path="/" element={<ProductList/>}/>
        <Route path="/" element={<ProductDetail/>}/>
        <Route path="/" element={<ProductForm/>}/>
      </Routes>
      <Footer/>
    </Router>
  );
};

export default App;
