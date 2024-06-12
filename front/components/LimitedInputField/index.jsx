import styles from "./index.module.css";
import { useState, useContext } from "react";
import { FanficContext } from "../contexts/FanficContext";

export const LimitedInputField = ({ length, inputText, inputTitle }) => {
  const [description, setDescription] = useState("");
  const maxLength = length;
  const { updateFanficData } = useContext(FanficContext);

  const handleInputChange = (e) => {
    if (e.target.value.length <= maxLength) {
      setDescription(e.target.value);
      updateFanficData("summary", e.target.value);
    }
  };

  return (
    <div className={styles.shortDescriptionContainer}>
      <label htmlFor="shortDescription" className={styles.label}>
        {inputTitle}
      </label>
      <textarea
        id="shortDescription"
        className={styles.textarea}
        value={description}
        onChange={handleInputChange}
        placeholder={inputText}
      />
      <div className={styles.wordCount}>
        Осталось символов: {maxLength - description.length}
      </div>
    </div>
  );
};
