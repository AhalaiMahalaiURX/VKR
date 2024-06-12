import { useState, useContext } from "react";
import { Dropdown } from "primereact/dropdown";
import "primereact/resources/themes/saga-blue/theme.css";
import "primereact/resources/primereact.min.css";
import "primeicons/primeicons.css";
import styles from "./index.module.css";
import { FanficContext } from "../contexts/FanficContext";

export const Focus = () => {
  const [selectedFocus, setSelectedFocus] = useState(null);
  const { updateFanficData } = useContext(FanficContext);

  const focusOptions = [
    { label: "Аниме & Манга", value: "anime" },
    { label: "Видеоигры", value: "games" },
    { label: "Фильмы", value: "movies" },
    { label: "Сериалы", value: "series" },
    { label: "Книги", value: "books" },
  ];

  const handleOnChange = (e) => {
    setSelectedFocus(e.value);
    updateFanficData("focus", e.target.value);
  };

  return (
    <Dropdown
      value={selectedFocus}
      options={focusOptions}
      onChange={handleOnChange}
      placeholder="Выберите направленность"
      className={styles.dropdown}
      panelClassName={styles.panel}
      icon={selectedFocus ? "pi pi-angle-up" : "pi pi-angle-down"}
    />
  );
};
