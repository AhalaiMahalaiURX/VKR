import { useState } from "react";
import styles from "./index.module.css";

export const PublicationParams = () => {
  const [selectedStatus, setSelectedStatus] = useState(null);
  const [selectedWorkStatus, setSelectedWorkStatus] = useState(null);

  const handleStatusSelect = (status) => {
    setSelectedStatus(status);
  };

  const handleWorkStatusSelect = (status) => {
    setSelectedWorkStatus(status);
  };

  return (
    <div className={styles.container}>
      <div className={styles.params}>
        <h3>Статус части</h3>
        <div
          className={`${styles.param} ${
            selectedStatus === "draft" ? styles.selected : ""
          }`}
          onClick={() => handleStatusSelect("draft")}
        >
          Черновик
        </div>
        <div
          className={`${styles.param} ${
            selectedStatus === "published" ? styles.selected : ""
          }`}
          onClick={() => handleStatusSelect("published")}
        >
          Опубликовано
        </div>
      </div>
      <div className={styles.params}>
        <h3>Статус работы</h3>
        <div
          className={`${styles.param} ${
            selectedWorkStatus === "inProcess" ? styles.selected : ""
          }`}
          onClick={() => handleWorkStatusSelect("inProcess")}
        >
          В процессе
        </div>
        <div
          className={`${styles.param} ${
            selectedWorkStatus === "completed" ? styles.selected : ""
          }`}
          onClick={() => handleWorkStatusSelect("completed")}
        >
          Завершён
        </div>
        <div
          className={`${styles.param} ${
            selectedWorkStatus === "frozen" ? styles.selected : ""
          }`}
          onClick={() => handleWorkStatusSelect("frozen")}
        >
          Заморожен
        </div>
      </div>
    </div>
  );
};
