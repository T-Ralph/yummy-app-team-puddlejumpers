import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import {useParams} from "react-router";

function Recipe(){

  const [myRecipe, setMyRecipe] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(false);
  const {recipes} = useParams();

  useEffect(() => {
    fetchRecipe();
  }, []); // eslint-disable-line react-hooks/exhaustive-deps


  async function fetchRecipe() {
    try {
      const response = await axios.get(`api/recipes/${recipes}`)
      setMyRecipe(response.data);
      setLoading(false);
      setError(false);
    } catch (err) {
      setError(true)
      setLoading(false)
    }
  }

  // If page is loading, render below...
  {/* TODO: Design better loading display. Perhaps a loading gif of some sort? */}
  if (loading){
    return(
      <>
        {/* TODO: Remove center tags and apply centering via CSS */}
        <center>
        <p><i className="fas fa-spinner fa-spin fa-4x"></i></p>
          <p>Loading your recipe...</p></center>
      </>
    )
  }

  // If Axios request has an error, display error message...
  // TODO: Design better Error page?
  if (error){
    return(
      <>
        <p>There was an error loading your Recipe. Please try again.</p>
        <p><button className="bg-purple-500 hover:bg-purple-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline shadow" type="submit" onClick={fetchRecipe}>
          Retry
        </button></p>
      </>
    )
  }

  // Assigning Ingredients to an array. Array is called in JSX below
  let ingredientsArray = [];
  for(let i in myRecipe.ingredients){
    ingredientsArray.push(<p key={i}>{`${parseInt(i) + 1}. ${myRecipe.ingredients[i].name}` + ' - ' + `${myRecipe.ingredients[i].quantity} ${myRecipe.ingredients[i].uom}`}</p>)
  }

  // TODO: Remove this and apply style via CSS/Tailwind
  var divStyle = {
    display: 'flex',
    justifyContent: 'space-around'
  }

  // If no axios Errors, and data is returned, render page...
  return(
    <div className="mx-2">
      {/* TODO: change to myRecipe.image once images are stored in DB. Placeholder image used for now for styling */}
      <div className="flex justify-center my-4">
        <img className="p-2 w-1/2 border rounded" src={"https://designshack.net/wp-content/uploads/placehold.jpg"} alt={myRecipe.name} />
      </div>
      <h1 className="text-xl text-bold my-2">{myRecipe.name}</h1>
      <p className="text-md text-bold">Servings: {myRecipe.servings}</p>
      <p className="text-md text-bold">Prep Time: {myRecipe.prepTime}</p>

      {/* TODO: Remove style= after CSS/Tailwind style finished */}
      <section className={"ingredientsMacrosContainer"} style={divStyle}>
        <div className="flex flex-col md:flex-row">
          <section className={"ingredients"}>
            <h2 className="text-lg text-bold my-2">Ingredients:</h2>
            <p className="text-md">{ingredientsArray}</p>
          </section>

          <section className={"macros"}>
            <h2 className="text-lg text-bold my-2">Macros:</h2>
            <p className="text-md">Calories: {(parseInt(myRecipe.fat) * 9) + (parseInt(myRecipe.protein) * 4) +(parseInt(myRecipe.carbohydrates) * 4)}</p>
            <p className="text-md">Fat: {myRecipe.fat}g</p>
            <p className="text-md">Protein: {myRecipe.protein}g</p>
            <p className="text-md">Carbs: {myRecipe.carbohydrates}g</p>
            </section>
          </div>
      </section>

      <section>
        <h2 className="text-lg text-bold my-2">Instructions</h2>
        <p className="text-md">{myRecipe.instructions}</p>
      </section>
      <section>
        <h2 className="text-lg text-bold my-2">Notes:</h2>
        <p className="text-md">{myRecipe.notes}</p>
      </section>

      {/* TODO: Consult; perhaps this could link to a page identical to "Create" but with all the fields filled in and ready to edit? Potential better ways to handle edit page? */}
      {/* TODO: Button Functionality */}
      <section className="flex justify-around my-4">
        <button className="bg-purple-500 hover:bg-purple-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline shadow" type="submit">
          Edit Recipe
        </button>
        <Link to={"/recipes/"}><button className="bg-purple-500 hover:bg-purple-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline shadow" type="submit">
            Return to Recipe List
        </button></Link>
      </section>
    </div>
  );
}

export default Recipe;
