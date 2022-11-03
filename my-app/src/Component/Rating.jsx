import React, { useState } from "react";
import './styles.css'


const Rating = () => {
  const [rating, setRating] = useState(0);


  const incrementRating = () => {
    if (rating < 5) {
      setRating(rating + 1);
    }

    console.log("clicked");
  };

  const decrementRating = () => {
    if (rating > 0) {
      setRating(rating - 1);
    }
  };

  return (
    <div className="body">
    <div>
      <div className="container">
        <div>
          <button
            className="buttonLogin btn btn-success"
            onClick={incrementRating}
          >
            +
          </button>

        </div>

        <span>
          {[...Array(rating)].map((item, index) => {
            return (
              <img
                className="ratingStar"
                src={require('../images/sag.jpeg.webp')}
                alt=""
              />
            );
          })}
        </span>
        <div>
        <button
            className="buttonLogin btn btn-danger"
            onClick={decrementRating}
          >
            -
          </button>
        </div>
      </div>
    </div>
    </div>
  );
};

export default Rating;
