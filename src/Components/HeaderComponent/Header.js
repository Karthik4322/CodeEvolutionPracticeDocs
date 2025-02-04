import React, { useState } from 'react';
import { Link } from 'react-router-dom'; // Use Link for navigation
import { Navbar, Nav, DropdownButton, Dropdown } from 'react-bootstrap';
import { Person, Cart3 } from 'react-bootstrap-icons';
import { FaShieldAlt } from 'react-icons/fa';

const Header = () => {
  const [hoveredLink, setHoveredLink] = useState(null);

  const handleMouseEnter = (link) => {
    setHoveredLink(link);
  };

  const handleMouseLeave = () => {
    setHoveredLink(null);
  };

  return (
    <Navbar sticky="top" bg="dark" variant="dark" expand="lg" className="shadow-sm" style={{ height: '77px' }}>
      <div className="container">
        <Navbar.Brand
          href="/"
          style={{
            fontFamily: 'sans-serif',
            fontWeight: '700',
            fontSize: '30px',
            letterSpacing: '6px',
          }}
        >
          FRESHIO
        </Navbar.Brand>

        <Navbar.Toggle
          aria-controls="basic-navbar-nav"
          style={{
            borderBottom: hoveredLink === 'toggle' ? '1px solid #29f700' : '2px transparent',
            transition: 'border-bottom 0.3s ease',
          }}
          onMouseEnter={() => handleMouseEnter('toggle')}
          onMouseLeave={handleMouseLeave}
        />

        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="ms-auto">
            {/* Use Link components to navigate to different pages */}
            <Nav.Link
              as={Link}
              to="/"
              className="text-white"
              onMouseEnter={() => handleMouseEnter('home')}
              onMouseLeave={handleMouseLeave}
              style={{
                borderBottom: hoveredLink === 'home' ? '1px solid #29f700' : '2px transparent',
                transition: 'border-bottom 0.3s ease',
              }}
            >
              Home
            </Nav.Link>

            <Nav.Link
              as={Link}
              to="/about"
              className="text-white"
              onMouseEnter={() => handleMouseEnter('about')}
              onMouseLeave={handleMouseLeave}
              style={{
                borderBottom: hoveredLink === 'about' ? '1px solid #29f700' : '2px transparent',
                transition: 'border-bottom 0.3s ease',
              }}
            >
              About Us
            </Nav.Link>

            <Nav.Link
              as={Link}
              to="/products"
              className="text-white"
              onMouseEnter={() => handleMouseEnter('products')}
              onMouseLeave={handleMouseLeave}
              style={{
                borderBottom: hoveredLink === 'products' ? '1px solid #29f700' : '2px transparent',
                transition: 'border-bottom 0.3s ease',
              }}
            >
              All Products
            </Nav.Link>

            <Nav.Link
              as={Link}
              to="/contact"
              className="text-white"
              onMouseEnter={() => handleMouseEnter('contact')}
              onMouseLeave={handleMouseLeave}
              style={{
                borderBottom: hoveredLink === 'contact' ? '1px solid #29f700' : '2px transparent',
                transition: 'border-bottom 0.3s ease',
              }}
            >
              Contact Us
            </Nav.Link>

              {/* Cart Link */}
            <Nav.Link as={Link} to="/cart" className="text-white">
              <Cart3 /> Cart
            </Nav.Link>
            
            {/* My Account Dropdown */}
            <DropdownButton
              drop="down-centered"
              variant="link"
              id="dropdown-myaccount"
              title={<><Person /> My Account</>}
              className="text-white"
            >
              <Dropdown.Item className="text-dark">
                <Person style={{ marginRight: '8px' }} /> User
              </Dropdown.Item>
              <Dropdown.Item className="text-dark">
                <FaShieldAlt style={{ marginRight: '8px' }} /> Admin
              </Dropdown.Item>
            </DropdownButton>

            
            
          </Nav>
        </Navbar.Collapse>
      </div>
    </Navbar>
  );
};

export default Header;
