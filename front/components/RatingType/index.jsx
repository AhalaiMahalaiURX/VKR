import { useState, useContext } from "react";
import styles from "./index.module.css";
import { FanficContext } from "../contexts/FanficContext";

export const RatingType = () => {
  const [selectedRating, setSelectedRating] = useState("");
  const { updateFanficData } = useContext(FanficContext);
  const handleRatingChange = (e) => {
    setSelectedRating(e.target.value);
    updateFanficData("ageRating", e.target.value);
  };

  return (
    <div className={styles.ratingTypeContainer}>
      <span>Рейтинг</span>
      {["G", "PG-13", "R", "NC-17", "NC-21"].map((rating) => (
        <label key={rating} className={styles.label}>
          <input
            type="radio"
            name="rating"
            value={rating}
            checked={selectedRating === rating}
            onChange={handleRatingChange}
            className={styles.radio}
          />
          {rating}
        </label>
      ))}
    </div>
  );
};
