import { useState, useContext } from "react";
import styles from "./index.module.css";
import { FanficContext } from "../contexts/FanficContext";

export const Type = () => {
  const [selectedType, setSelectedType] = useState("");
  const { updateFanficData } = useContext(FanficContext);
  const handleTypeChange = (e) => {
    setSelectedType(e.target.value);
    updateFanficData("type", e.target.value);
  };

  return (
    <div className={styles.ratingTypeContainer}>
      <span>Тип</span>
      {["Ориджинал", "Фанфик по фэндому"].map((type) => (
        <label key={type} className={styles.label}>
          <input
            type="radio"
            name="type"
            value={type}
            checked={selectedType === type}
            onChange={handleTypeChange}
            className={styles.radio}
          />
          {type}
        </label>
      ))}
    </div>
  );
};
