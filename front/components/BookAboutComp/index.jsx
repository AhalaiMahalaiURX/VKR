//Компонент отображает краткое описание книги

import styles from "./index.module.css";

export const BookAboutComp = ({ description }) => {
  return (
    <div className={styles.descriptionContainer}>
      <h2 className={styles.header}>Краткое описание</h2>
      <p className={styles.description}>{description}</p>
    </div>
  );
};
