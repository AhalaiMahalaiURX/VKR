//компонент отображает информацию о bookmarks

import styles from "./index.module.css";

export const BookReviewsComp = ({ reviews }) => {
  return (
    <div className={styles.reviewsContainer}>
      <h3 className={styles.header}>Рецензии</h3>
      {reviews.map((review, index) => (
        <div key={index} className={styles.review}>
          <h3 className={styles.author}>{review.author}</h3>
          <p className={styles.summary}>{review.summary}</p>
        </div>
      ))}
    </div>
  );
};
