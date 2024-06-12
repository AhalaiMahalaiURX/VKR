import styles from "./index.module.css";
import { LimitedInputField } from "../LimitedInputField";
import { useState } from "react";
import { Dropdown } from "primereact/dropdown";
export const MakeReport = () => {
  const [selectedRule, setSelectedRule] = useState(null);

  const rules = [
    {
      label: "Работа была скопирована без разрешения оригинального автора",
      value: "stealed",
    },
    {
      label:
        "Флуд, спам и тексты оскорбительного и/или провокационного характера",
      value: "spam",
    },
    {
      label:
        "Работа затрагивает недавние мировые трагедии и политические конфликты",
      value: "irlTrouble",
    },
    {
      label: "Неполныая работа со ссылкой на продолжение на стороннем ресурсе",
      value: "incompleteWork",
    },
    {
      label:
        "Участие в спорах, разобрках и выяснение отношений прямо в тексте работы",
      value: "conflictText",
    },
  ];
  const submitReport = (e) => {
    const bookId = bookId;
    const newReport = {
      chapterId,
      rule: e.target.value,
    };

    fetch(`https://localhost:7006/api/Fanfics/${bookID}`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(newReport),
    })
      .then((response) => response.json())
      .then((data) => {
        console.log("Жалоба добавлена:", data);
      })
      .catch((error) => {
        console.error("Ошибка при отправке жалобы:", error);
      });
  };

  return (
    <div className={styles.container}>
      <Dropdown
        value={selectedRule}
        options={rules}
        onChange={(e) => setSelectedRule(e.value)}
        placeholder="Выберите нарушенное правило"
        icon={selectedRule ? "pi pi-angle-up" : "pi pi-angle-down"}
        className={styles.dropdown}
      />
      <LimitedInputField
        length={1000}
        inputText="Введите текст"
        inputTitle="Опишите свою жалобу"
      />
      <button className={styles.btn}>Отправить</button>
    </div>
  );
};
