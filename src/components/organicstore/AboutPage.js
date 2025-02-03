import React from "react";
import "font-awesome/css/font-awesome.min.css";
import AboutUsBannerImg from "../../assets/AboutUsBanner.png";
import aboutusImg from "../../assets/AboutUs.png";
import AboutUsAboutImg from "../../assets/AboutUsAbout.png";
import AboutUsFirstIconImg from "../../assets/AboutUsFirstIcon.svg";
import AboutUsSecondIconImg from "../../assets/AboutUsSecondIcon.svg";
import WhyChooseUsImg from "../../assets/WhyChooseUs.png";
import WhyChooseUsWordImg from "../../assets/WhyChooseUsWord.png";
import RingIconImg from "../../assets/RingIcon.png";
import WeOfferFruitsImg from "../../assets/WeOfferFruits.png";
import WeOfferNutsImg from "../../assets/WeOfferNuts.png";
import WeOfferSpicyImg from "../../assets/WeOfferSpicy.png";
import WeOfferVegetableImg from "../../assets/WeOfferVegetable.png";
import Logo from "../../assets/Logo.svg";
import { FaMapMarkerAlt, FaEnvelope, FaPhoneAlt } from 'react-icons/fa';
import { FaTwitter, FaFacebook, FaInstagram } from 'react-icons/fa';
import { faEnvelope, faPhoneAlt } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faFacebook,
  faInstagram,
  faTwitter
} from "@fortawesome/free-brands-svg-icons";
import classes from "./AboutPage.module.css";

const AboutPage = () => {
  // Data for AboutUsAbout section
  const aboutData = [
    {
      image: AboutUsFirstIconImg,
      text: "Modern Agriculture Equipment",
      dummyContent:
        "At GreenHarvest, we go beyond organic food we provide **cutting-edge agricultural equipment**,ensuring that farmers have access to the best tools to **maximize yield naturally",
    },
    {
      image: AboutUsSecondIconImg,
      text: "No growth hormones are used",
      dummyContent:
        "We **never use growth hormones**, staying true to the purity of organic farming. Join us in cultivating a **healthier, more sustainable future!**",
    },
  ];

  // Data for AboutWhyChooseUs section
  const whyChooseUsData = [
    {
      title: "100% Natural Product",
      content:
        "Our products are grown with 100% natural methods, free from synthetic additives and harmful chemicals.",
    },
    {
      title: "Increases resistance",
      content:
        "Through careful cultivation and continuous monitoring, we enhance the natural resistance of crops, ensuring they are healthier, stronger, and packed with nutrients—just as nature intended.",
    },
  ];

  // Data for AboutOfferProduct section
  const productArray = [0, 1, 2, 3];
  const imagesArray = [
    WeOfferFruitsImg,
    WeOfferNutsImg,
    WeOfferSpicyImg,
    WeOfferVegetableImg,
  ];
  const titleArray = ["Fruits", "Nuts & Seeds", "Spicy", "Vegetables"];

  return (
    <div>
      {/* Main Banner Section */}
      <div className={classes["Banner_container"]}>
        <img
          src={AboutUsBannerImg}
          className={`img-fluid ${classes["banner_img"]}`}
          alt="About Us Banner"
        />
        
        <div className={`col-6 ${classes["banner_slogan"]}`}>
        <h1 style={{"color":"#274c5b"}}>About Us</h1>
        </div>
      </div>

      {/* AboutUsAbout Section */}
      <div className={classes["about_container"]}>
        <div className={classes["img-container"]}>
          <img
            src={AboutUsAboutImg}
            width={700}
            className={`img-fluid me-5`}
            alt="About Us"
          />
        </div>
        <div className={classes["text-container"]}>
          <img
            src={aboutusImg}
            height={20}
            width={80}
            className={`mb-3 ${classes["About-image"]}`}
            alt="About Us Icon"
          />
          <h3>We do Creative <br /> Things for Success</h3>
          <p className="p-0 m-0 mt-3 mb-4">{aboutData[0].dummyContent}</p>
          <p className="p-0 m-0 mb-4">{aboutData[1].dummyContent}</p>
          <div className="d-inline-flex p-2">
            {aboutData.map((item, index) => (
              <div key={index} className={`d-flex ${classes["about-tag"]}`}>
                <img src={item.image} className="me-3" width={50} alt="Icon" />
                <div>
                  <h5 className="p-0 m-0">{item.text}</h5>
                </div>
              </div>
            ))}
          </div>
        </div>
      </div>

      {/* AboutWhyChooseUs Section */}
      <div className={`${classes["section"]}`}>
        <div className={`container d-flex flex-row ${classes["about_container"]}`}>
          <div className={classes["text-container"]}>
            <img
              src={WhyChooseUsWordImg}
              height={30}
              width={145}
              className={`mb-3 ${classes["About-image"]}`}
              alt="Why Choose Us"
            />
            <h3>We do not buy from the <br /> open market & traders.</h3>
            <p className="p-0 m-0 mt-3 mb-4">
              "We cultivate our products under our own strict guidance and continuous monitoring, ensuring a 100% natural and pure farming process. Every step, from seeding to harvesting, follows our commitment to sustainability, free from artificial enhancers or harmful chemicals. Our mission is to deliver nature’s best, just the way it’s meant to be."
            </p>
            <div className="d-flex flex-column">
  {whyChooseUsData.map((item, index) => (
    <div key={index}>
      <div className={`${classes["about-tag"]}`}>
        <div className={`d-flex ${classes["heading"]}`}>
          <img
            src={RingIconImg}
            width={14}
            className="img-fluid my-auto me-2 h-auto"
            alt="Ring Icon"
          />
          <h5 className="p-0 m-0">{item.title}</h5>
        </div>
      </div>
      <p className="p-0 m-0 mt-2 mb-4">{item.content}</p>
    </div>
  ))}
</div>
          </div>
          <div className={classes["img-container"]}>
            <img
              src={WhyChooseUsImg}
              className={`${classes["about-img"]} img-fluid`}
              alt="Why Choose Us"
            />
          </div>
        </div>
      </div>

      {/* AboutOfferProduct Section */}
      <div className={classes["offer-section"]}>
        <div className="container py-5">
          <div className={`${classes["testimonial-counter"]} d-flex flex-column justify-content-center align-items-center mt-5`}>
            <div className={`${classes["testimonial"]} d-flex flex-column justify-content-center align-items-center`}>
              <img src={aboutusImg} className={classes["testimonial-img"]} width={100} alt="About Us" />
              <h2 className={`mb-4 mt-2 text-white ${classes["testimonial-heading"]}`}>
                What We Offer for You
              </h2>
            </div>
          </div>
          <div className="row d-flex justify-content-center align-items-center">
            {productArray.map((index) => (
              <div key={index} className={`${classes["card"]} col-sm-6 col-md-4 col-lg-2 mb-3 d-flex flex-column justify-content-center align-items-center`}>
                <div className={`card d-flex justify-content-center align-items-center ${classes["product-item"]}`} style={{ width: "13rem", height: "14rem" }}>
                  <img src={imagesArray[index]} className={`card-img-top p-0 m-0 ${classes["product-image"]}`} style={{ height: "12rem", width: "auto" }} alt={titleArray[index]} />
                </div>
                <div className="card-body pb-0">
                  <h5 className={`card-title p-0 pb-2 m-0 mt-3 ${classes["product-title"]}`}>
                    {titleArray[index]}
                  </h5>
                </div>
              </div>
            ))}
          </div>
        </div>
      </div>

      {/* Footer Section */}
      <footer class="footer bg-success">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <h2>GeeksforGeeks</h2>
                </div>
                <div class="col-md-3">
                    <h5>About Us</h5>
                    <p>
                        GeeksforGeeks is a leading platform
                        that provides computer science resources and
                        coding challenges for programmers and technology
                        enthusiasts, along with interview and exam
                        preparations for upcoming aspirants.
                   </p>
                </div>
                <div class="col-md-3">
                    <h5>Contact Us</h5>
                    <ul class="list-unstyled">
                        <li>Email: info@example.com</li>
                        <li>Phone: +1233567890</li>
                        <li>Address: 123 Street, City, Country</li>
                    </ul>
                </div>
                <div class="col-md-3">
                    <h5>Follow Us</h5>
                    <ul class="list-inline footer-links">
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-facebook"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-instagram"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-linkedin"></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <hr/>
            <div class="row">
                <div class="col-md-6">
                    <p>&copy; 2024 Your Website. All rights reserved.</p>
                </div>
                <div class="col-md-6 text-end">
                    <ul class="list-inline footer-links">
                        <li class="list-inline-item">
                            <a href="#">Privacy Policy</a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">Terms of Service</a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">Sitemap</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    
    </div>
  );
};

export default AboutPage;