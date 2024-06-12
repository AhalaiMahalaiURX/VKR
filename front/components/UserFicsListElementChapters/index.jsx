import styles from "./index.module.css";
import Link from "next/link";

export const UserFicsListElementChapters = ({ chaptersList }) => {
  return (
    <div>
      {chaptersList.map((chapter) => (
        <p className={styles.element} key={chapter.id}>
          <Link
            href="home/book/${userID}/chapter/${chapter.id}"
            className={styles.link}
          >
            {chapter.chapterTitle}
          </Link>
        </p>
      ))}
    </div>
  );
};
