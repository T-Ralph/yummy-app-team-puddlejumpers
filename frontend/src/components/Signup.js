// Import Resources
import React, { useState } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

// Import Media
import Plate from '../assets/plate.svg';

// Import Authentication
import { UserContext } from './Authentication/UserAuthentication';

// Signup Component
const Signup = () => {

  // Set Up States
  const [email, setEmail] = useState("");
  const [name, setName] = useState("");
  const [password, setPassword] = useState("");
  const [password2, setPassword2] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(false);
  const [errorMessage, setErrorMessage] = useState("");
  const [success, setSuccess] = useState(false);
  const [successMessage, setSuccessMessage] = useState("");

  // Function to Handle Submit of the Signup Form
  const SignupSubmit = async(event) => {

    // Prevent Form Refresh
    event.preventDefault();

    // Set Loading
    setLoading(true);

    // Check If Passwords Match
    if (password != password2) {
      // Set Loading
      setLoading(false);

      // Set Errors
      setError(true);
      // Set Error Message
      setErrorMessage("Passwords do not match");

      // Break Function
      return false;
    }
    else {
      // Reset Errors
      setError(false);
      setErrorMessage("");
    }

    // Axios Request
    axios
    .post(
      'api/authenticate/register',
      {
        Name: name,
        Email: email,
        Username: email,
        Password: password
      }
    )
    .then(response => {
      if (response.data.status == "Success") {
        // Reset Errors
        setError(false);
        setErrorMessage("");

        // Set Loading
        setLoading(false);

        // Set Success
        setSuccess(true);
        // Set Success Message
        setSuccessMessage(response.data.message);

        // Reset Form Fields
        setName("");
        setEmail("");
        setPassword("");
        setPassword2("");
      }
    })
    .catch(error => {
      if (error.response.data.status == "Error") {
        // Set Errors
        setError(true);

        // Set Loading
        setLoading(false);
  
        // Set Error Message
        let errorMessageString = error.response.data.message;
        // Check If Error List Contains Error Messages
        if (error.response.data.errorList) {
          error.response.data.errorList.forEach(element => {
            errorMessageString += ` ${element} `;
          });
        }
        setErrorMessage(errorMessageString);
  
        // Break Function
        return false;
      }
    });

  }

  // Function to Display Error Message
  const DisplayErrorMessage = (message) => {
    return(
      <div className="flex justify-center items-center m-1 font-medium py-1 px-2 bg-white rounded-md text-red-100 bg-red-700 border border-red-700">
        <div className="text-xl font-normal max-w-full flex-initial">
          <i className="fas fa-exclamation-circle mr-4"></i>
          {message}
        </div>
      </div>
    );
  }

  // Function to Display Error Message
  const DisplaySuccessMessage = (message) => {
    return(
      <div className="flex justify-center items-center m-1 font-medium py-1 px-2 bg-white rounded-md text-green-100 bg-green-700 border border-green-700">
        <div className="text-xl font-normal max-w-full flex-initial">
          <i className="fas fa-exclamation-circle mr-4"></i>
          {message}
        </div>
      </div>
    );
  }

  return (
    <>
      <div className="container">
        <div className="block text-center my-4">
          <h1 className="font-bold">Signup</h1>
        </div>

        <div className="md:grid md:grid-cols-2 md:gap-6 place-items-center">

          <div className="md:col-span-1 md:inline-block">
            <img src={Plate} alt="Drawing of a plate" className="object-contain h-64 w-full" />
          </div>

          <div className="md:col-span-1 w-full">
            <form className="bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4" onSubmit={SignupSubmit}>
              <div>
                <label htmlFor="email" className="block text-gray-700 text-sm font-bold mb-2">Email:</label>
                <input
                  className="input-field w-full focus:outline-none focus:shadow-outline"
                  type="text"
                  id="email"
                  value={email}
                  onChange={event => setEmail( event.target.value )}
                  required
                />
              </div>
              <div>
                <label htmlFor="name" className="block text-gray-700 text-sm font-bold mb-2">Name:</label>
                <input
                  className="input-field w-full focus:outline-none focus:shadow-outline"
                  type="text"
                  id="name"
                  value={name}
                  onChange={event => setName( event.target.value )}
                  required
                />
              </div>
              <div>
                <label htmlFor="password" className="block text-gray-700 text-sm font-bold mb-2">Password:</label>
                <input
                  className="input-field w-full focus:outline-none focus:shadow-outline"
                  type="password"
                  id="password"
                  value={password}
                  onChange={event => setPassword( event.target.value )}
                  required
                />
              </div>
              <div className="mb-6">
                <label htmlFor="password2" className="block text-gray-700 text-sm font-bold mb-2">Re-enter Password:</label>
                <input
                  className="input-field w-full focus:outline-none focus:shadow-outline"
                  type="password"
                  id="password2"
                  value={password2}
                  onChange={event => setPassword2( event.target.value )}
                  required
                  />
              </div>
              <div className="flex items-center justify-between">
                <button
                  className="purple-button hover:bg-purple-700 focus:outline-none focus:shadow-outline"
                  type="submit">
                  Submit
                </button>
                
                <Link className="purple-link hover:text-purple-600" to="/login">
                  Have an account? Log in
                </Link>
              </div>

              {loading ? <i className="fas fa-spinner fa-spin"></i> : null}
              {error ? DisplayErrorMessage(errorMessage) : null}
              {success ? DisplaySuccessMessage(successMessage) : null}

            </form>
          </div>
        </div>
      </div>
    </>
  );
}

export default Signup;