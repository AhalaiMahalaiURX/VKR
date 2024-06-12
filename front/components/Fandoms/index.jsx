import { useState } from "react";
import { Dropdown } from "primereact/dropdown";
import "primereact/resources/themes/saga-blue/theme.css";
import "primereact/resources/primereact.min.css";
import "primeicons/primeicons.css";
import styles from "./index.module.css";
import { FanficContext } from "../contexts/FanficContext";
import { useContext } from "react";

export const Fandom = () => {
  //сделать запрос к Fandoms
  const [selectedFocus1, setSelectedFocus1] = useState(null);
  const [selectedFocus2, setSelectedFocus2] = useState(null);
  const { updateFanficData } = useContext(FanficContext);

  const handleOnChange1 = (e) => {
    setSelectedFocus1(e.value);
    updateFanficData("fandom", e.target.value);
  };

  const handleOnChange2 = (e) => {
    setSelectedFocus2(e.value);
    updateFanficData("fandom", e.target.value);
  };

  return (
    <>
      <p>Выберите фандом</p>
      <Dropdown
        value={selectedFocus1}
        options={focusOptions}
        onChange={handleOnChange1}
        placeholder="Выберите фандом"
        className={styles.dropdown}
        panelClassName={styles.panel}
        icon={selectedFocus1 ? "pi pi-angle-up" : "pi pi-angle-down"}
      />
      <Dropdown
        value={selectedFocus2}
        options={focusOptions}
        onChange={handleOnChange2}
        placeholder="Выберите ещё один фандом, если у вас X-over"
        className={styles.dropdown}
        panelClassName={styles.panel}
        icon={selectedFocus2 ? "pi pi-angle-up" : "pi pi-angle-down"}
      />
    </>
  );
};
