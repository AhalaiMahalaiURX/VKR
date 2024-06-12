import styles from "./index.module.css";
import "primeicons/primeicons.css";

export const InfoPanel = () => {
  return (
    <div className={styles.infoPanel}>
      <h2>Параметры работы</h2>
      <p>
        <i className="pi pi-list" />
        <span className={styles.ptg}>Части</span>
      </p>
      <p>
        <i className="pi pi-comments" />
        <span className={styles.ptg}>Отзывы</span>
      </p>
      <p>
        <i className="pi pi-bookmark" />
        <span className={styles.ptg}>Сборники</span>
      </p>
      <p>
        <i className="pi pi-building-columns" />
        <span className={styles.ptg}>Страница работы</span>
      </p>
      <p>
        <i className="pi pi-book" />
        <span className={styles.ptg}>Мои фанфики</span>
      </p>
    </div>
  );
};
