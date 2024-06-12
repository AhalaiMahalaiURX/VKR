import { useState } from "react";
import { useRouter } from "next/router";
import { LimitedInputField } from "../LimitedInputField";
import styles from "./index.module.css";
import { Rating } from "primereact/rating";
export const MakeComent = ({ comentLength, comentText, comentTitle }) => {
  const [value, setValue] = useState(null);
  const { chapterId } = router.query;

  const submitComment = () => {
    const chapterId = chapterId;
    const newComment = {
      chapterId,
      rating: value,
      summary: comment,
    };

    fetch(`https://localhost:7006/api/Fanfics/${userID}`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(newComment),
    })
      .then((response) => response.json())
      .then((data) => {
        // Обработка ответа от сервера
        console.log("Комментарий добавлен:", data);
      })
      .catch((error) => {
        console.error("Ошибка при отправке комментария:", error);
      });
  };

  return (
    <div className={styles.container}>
      <div className={styles.rate}>
        <p>Оцените работу:</p>
        <Rating
          value={value}
          onChange={(e) => setValue(e.value)}
          cancel={false}
        />
      </div>
      <LimitedInputField
        length={comentLength}
        inputText={comentText}
        inputTitle={comentTitle}
      />

      <div className={styles.btnProp}>
        <button className={styles.btn} onClick={submitComment}>
          Отправить
        </button>
      </div>
    </div>
  );
};
