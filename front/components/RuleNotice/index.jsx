import Link from "next/link";
import styles from "./index.module.css";

export const RuleNotice = () => {
  return (
    <div className={styles.ruleNotice}>
      <p>
        <strong>Ознакомьтесь с правилами публикации</strong>
      </p>
      <span>
        Прочитайте несложные <Link href="#">правила</Link>, которые объясняют
        особенности публикации работы на сайте
      </span>
    </div>
  );
};
