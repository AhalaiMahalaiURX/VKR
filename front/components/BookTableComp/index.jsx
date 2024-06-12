//компонент отображает список глав
import styles from "./index.module.css";

export const BookTableComp = ({ chapters }) => {
  return (
    <div className={styles.tableContainer}>
      {chapters.map((chapter, index) => (
        <div key={chapter.id} className={styles.chapterRow}>
          <div className={styles.chapterNumber}>{index + 1}</div>
          <div className={styles.chapterTitle}>{chapter.title}</div>
        </div>
      ))}
    </div>
  );
};
