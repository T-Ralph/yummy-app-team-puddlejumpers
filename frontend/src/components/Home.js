import React from 'react';
import { Link } from 'react-router-dom';

const Home = () => {
  return (
    <>
      <section className="text-gray-700 body-font">
        <div className="container px-5 py-24 mx-auto">
          <div className="text-center mb-20">
            <p className="text-3xl text-purple-500 tracking-widest font-medium title-font mb-1">Welcome to...</p>
            <h1 className="sm:text-3xl text-2xl font-medium title-font text-gray-900 mb-4">Yummy</h1>
            <p className="text-base leading-relaxed xl:w-2/4 lg:w-3/4 mx-auto">The FREE meal planning app for the person who just wants to keep it simple!</p>
            <div className="flex mt-6 justify-center">
              <div className="w-16 h-1 rounded-full bg-purple-500 inline-flex"></div>
            </div>
          </div>
          <div className="flex flex-wrap mb-10 mt-4">
            <div className="p-4 md:w-1/3 md:mb-0 mb-6 flex flex-col text-center items-center">
              <div className="w-20 h-20 inline-flex items-center justify-center rounded-full bg-purple-100 text-purple-500 mb-5 flex-shrink-0">
                <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                     className="w-10 h-10" viewBox="0 0 24 24">
                  <circle cx="6" cy="6" r="3"></circle>
                  <circle cx="6" cy="18" r="3"></circle>
                  <path d="M20 4L8.12 15.88M14.47 14.48L20 20M8.12 8.12L12 12"></path>
                </svg>
              </div>
              <div className="flex-grow">
                <h2 className="text-gray-900 text-lg title-font font-medium mb-3">Create/Edit Your Own Recipes</h2>
                <p className="leading-relaxed text-base">Create and save the recipes you like, and save them to a meal plan, then access them any time from any device!</p><p>Our convenient, easy to learn, and simple to use app will have you meal planning in minutes!</p>
                <Link className="mt-3 text-purple-500 inline-flex items-center" to="/signup">
                  Join Now
                  <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                       className="w-4 h-4 ml-2" viewBox="0 0 24 24">
                    <path d="M5 12h14M12 5l7 7-7 7"></path>
                  </svg>
                </Link>
              </div>
            </div>
            <div className="p-4 md:w-1/3 md:mb-0 mb-6 flex flex-col text-center items-center">
              <div
                className="w-20 h-20 inline-flex items-center justify-center rounded-full bg-purple-100 text-purple-500 mb-5 flex-shrink-0">
                <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                     className="w-10 h-10" viewBox="0 0 24 24">
                  <path d="M22 12h-4l-3 9L9 3l-3 9H2"></path>
                </svg>
              </div>
              <div className="flex-grow">
                <h2 className="text-gray-900 text-lg title-font font-medium mb-3">Macronutrient Tracking</h2>
                <p className="leading-relaxed text-base">Because we understand not everyone has the same diet, our app tracks the Calories and Macronutrients of each recipe so you can use that information to help plan your mealplan for each day.</p>
                <Link className="mt-3 text-purple-500 inline-flex items-center" to="/signup">
                  Join Now
                  <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                       className="w-4 h-4 ml-2" viewBox="0 0 24 24">
                    <path d="M5 12h14M12 5l7 7-7 7"></path>
                  </svg>
                </Link>
              </div>
            </div>
            <div className="p-4 md:w-1/3 md:mb-0 mb-6 flex flex-col text-center items-center">
              <div
                className="w-20 h-20 inline-flex items-center justify-center rounded-full bg-purple-100 text-purple-500 mb-5 flex-shrink-0">
                <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                     className="w-10 h-10" viewBox="0 0 24 24">
                  <path d="M20 21v-2a4 4 0 00-4-4H8a4 4 0 00-4 4v2"></path>
                  <circle cx="12" cy="7" r="4"></circle>
                </svg>
              </div>
              <div className="flex-grow">
                <h2 className="text-gray-900 text-lg title-font font-medium mb-3">User Profiles</h2>
                <p className="leading-relaxed text-base">All recipes you create are saved to your account and only visible to you, because of this feature you do not have to worry about your recipe lists and meal plans getting cluttered and lost in a sea of other peoples information. This also allows you to keep your information private to yourself.</p>
                <Link className="mt-3 text-purple-500 inline-flex items-center" to="/signup">
                  Join Now
                  <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                       className="w-4 h-4 ml-2" viewBox="0 0 24 24">
                    <path d="M5 12h14M12 5l7 7-7 7"></path>
                  </svg>
                </Link>
              </div>
            </div>
          </div>
          <Link
            className="block mx-auto w-48 text-center py-2 px-8 text-white text-lg bg-purple-500 border-0 rounded focus:outline-none hover:bg-purple-600"
            to="/signup"
          >
              Sign Up FREE
          </Link>
        </div>
      </section>
      <section className="text-gray-700 body-font">
        <div className="container flex flex-wrap px-5 py-24 mx-auto items-center">
          <div
            className="md:w-1/2 md:pr-12 md:py-8 md:border-r md:border-b-0 mb-10 md:mb-0 pb-10 border-b border-gray-300">
            <h2 className="text-3xl font-medium title-font mb-2 text-gray-900">About the Project</h2>
            <p className="leading-relaxed text-base">This app was developed by Team PuddleJumpers over a period of 3.5 weeks as the capstone project for <a href={"http://www.techcareers.ca/"}>TECHCareers</a> Cohort 4.2.</p>
            <Link className="text-purple-500 inline-flex items-center mt-4" to="/about-us">
              Learn More
              <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                    className="w-4 h-4 ml-2" viewBox="0 0 24 24">
                <path d="M5 12h14M12 5l7 7-7 7"></path>
              </svg>
            </Link>
          </div>
          <div className="flex flex-col md:w-1/2 md:pl-12">
            <h2 className="title-font font-medium text-gray-800 tracking-widest text-sm mb-3">DEVELOPERS</h2>
            <nav className="flex flex-wrap list-none -mb-1">
              <li className="lg:w-1/3 mb-1 w-1/2">
                <a className="text-gray-600 hover:text-gray-800" href={"https://github.com/abrthel"} target={"_blank"} rel={"noopener noreferrer"}>Aaron Barthel</a>
              </li>
              <li className="lg:w-1/3 mb-1 w-1/2">
                <a className="text-gray-600 hover:text-gray-800" href={"https://github.com/KenjiAu-Creator"} target={"_blank"} rel={"noopener noreferrer"}>Kenji Au</a>
              </li>
              <li className="lg:w-1/3 mb-1 w-1/2">
                <a className="text-gray-600 hover:text-gray-800" href={"https://github.com/KrisztinaPap"} target={"_blank"} rel={"noopener noreferrer"}>Krisztina Pap</a>
              </li>
              <li className="lg:w-1/3 mb-1 w-1/2">
                <a className="text-gray-600 hover:text-gray-800" href={"https://github.com/ldgraham92"} target={"_blank"} rel={"noopener noreferrer"}>Lindsey Graham</a>
              </li>
              <li className="lg:w-1/3 mb-1 w-1/2">
                <a className="text-gray-600 hover:text-gray-800" href={"https://github.com/T-Ralph"} target={"_blank"} rel={"noopener noreferrer"}>Tosin Olaniyi</a>
              </li>
            </nav>
          </div>
        </div>
      </section>
    </>
  );
}

export default Home;
