import Link from "next/link";
import styles from "./index.module.css";

export const UserFicsListElementAddButton = () => {
  return (
    <button className={styles.btn}>
      <Link
        href="/home/{userID}/myfics/{ficID}/addpart"
        className={styles.link}
      >
        <span>📕</span>Добавить часть
      </Link>
    </button>
  );
};
