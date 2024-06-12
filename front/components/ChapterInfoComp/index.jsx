import { MakeComent } from "../MakeComment";
import styles from "./index.module.css";

export const ChapterInfoComp = ({ curChapter }) => {
  return (
    <div className={styles.container}>
      <h2>{curChapter.title}</h2>
      <div className={styles.chapter}>
        <p>{curChapter.summary}</p>

        <div className={styles.ftrPanel}>
          <button>
            <i className="pi pi-arrow-left" />
            Назад
          </button>
          <button>
            <i className="pi pi-list" />
            Содержание
          </button>
          <button>
            <i className="pi pi-arrow-right" />
            Вперед
          </button>
        </div>
      </div>
      <MakeComent
        comentLength={1500}
        comentText="Введите текст"
        comentTitle="Оставьте свой отзыв"
      />
    </div>
  );
};
