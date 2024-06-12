import styles from "./index.module.css";
import Link from "next/link";

export const NavBar = () => {
  return (
    <div className={styles.body}>
      <Link href="/" className={styles.navLink}>
        <p>Главная</p>
      </Link>
      <Link href="/" className={styles.navLink}>
        <p>Читать</p>
      </Link>
      <Link href="/" className={styles.navLink}>
        <p>ТОП</p>
      </Link>
      <Link href="/" className={styles.navLink}>
        <p>FAQ</p>
      </Link>
      <Link href="/" className={styles.navLink}>
        <p>Правила</p>
      </Link>
    </div>
  );
};
