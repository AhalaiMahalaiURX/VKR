import styles from "./index.module.css";
import Image from "next/image";
import "primeicons/primeicons.css";
import { useState } from "react";
import { CustomRating } from "../CustomRating";
import { MakeReport } from "../MakeReport";

export const BookInfoComp = ({ book }) => {
  const numberOfChapters = book.chapters.length;

  const [showReport, setShowReport] = useState(false);
  const handleReportClick = () => {
    setShowReport(true);
  };

  return (
    <div className={styles.container}>
      <Image
        className={styles.img}
        src={book.image}
        alt={book.title}
        height={220}
        width={120}
      />
      <div>
        <h3>{book.title}</h3>
        <div className={styles.spns}>
          <span>
            <i className="pi pi-receipt" />
            {book.focus}
          </span>
          <span>
            <i className="pi pi-pen-to-square" />
            {book.status}
          </span>
          <span>
            <i className="pi pi-file-edit" />
            {book.nubmerOfChapters} Глав
          </span>
          <span>
            <i className="pi pi-eye" />
            {book.views} Просмотров
          </span>
        </div>
        <p>
          Автор: <span>{book.author}</span>
        </p>
        <div className={styles.ratingStyle}>
          <CustomRating ratingValue={book.rating} />
          <span>{book.rating}</span>
        </div>
        <div className={styles.btns}>
          <button className={styles.btn}>ЧИТАТЬ</button>
          <button className={styles.btn}>ДОБАВИТЬ В КОЛЛЕКЦИЮ</button>
        </div>
        <p onClick={handleReportClick} className={styles.report}>
          <i className="pi pi-flag-fill" />
          Пожаловаться на историю
        </p>
      </div>
      {showReport && <MakeReport />}
    </div>
  );
};
