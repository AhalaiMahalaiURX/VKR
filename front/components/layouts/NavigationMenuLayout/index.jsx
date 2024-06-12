import styles from "./index.module.css";
import Link from "next/link";
import Image from "next/image";
import { NavBar } from "../../NavBar";

export default function HeaderLayout({ children }) {
  return (
    <div className={styles.body}>
      <header className={styles.header}>
        <NavBar />
      </header>
      <main className={styles.main}>{children}</main>

      <footer className={styles.footer}>
        <p>&copy; 2024 NovelCreation</p>
      </footer>
    </div>
  );
}
