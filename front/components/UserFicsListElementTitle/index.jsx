import Link from "next/link";
import styles from "./index.module.css";

export const UserFicsListElementTitle = ({
  fanficTitle,
  fanficComNum,
  fanficBookNum,
}) => {
  return (
    <div>
      <div className={styles.titleElements}>
        <span className={styles.titleElement}>
          <Link href="#">
            <i className="pi pi-book" />
            Посмотреть
          </Link>
        </span>

        <span className={styles.titleElement}>
          <i className="pi pi-comment" />
          {fanficComNum} отзывов
        </span>

        <span className={styles.titleElement}>
          <i className="pi pi-bookmark" />
          {fanficBookNum} коллекций
        </span>
      </div>
    </div>
  );
};
