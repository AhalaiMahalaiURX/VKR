import { useState, useContext } from "react";
import styles from "./index.module.css";
import { Tag } from "primereact/tag";
import { FanficContext } from "../contexts/FanficContext";

export const InputTags = () => {
  const { updateFanficData } = useContext(FanficContext);
  //также запрос к тегам
  const [availableTags, setAvailableTags] = useState([
    "Нецензурная лексика 18+",
    "Пародия",
    "Стеб",
    "ГГ мужчина",
    "ГГ женщина",
    "Система",
    "Герой силен с самого начала",
    "ГГ имба",
    "ЛитРПГ",
    "Прокачка уровня",
    "Умный ГГ",
    "Отсылки",
    "Авторский юмор",
  ]);
  const [selectedTags, setSelectedTags] = useState([]);

  const handleTagSelect = (tag) => {
    setSelectedTags([...selectedTags, tag]);
    setAvailableTags(availableTags.filter((t) => t !== tag));
    updateFanficData("tags", setSelectedTags());
  };

  const handleTagRemove = (tag) => {
    setAvailableTags([...availableTags, tag]);
    setSelectedTags(selectedTags.filter((t) => t !== tag));
    updateFanficData("tags", setSelectedTags());
  };

  return (
    <div className={styles.tagsContainer}>
      <p>Выберите теги</p>
      <div className={styles.selectedTags}>
        {selectedTags.map((tag, index) => (
          <Tag
            key={index}
            value={tag}
            icon="pi pi-times"
            onClick={() => handleTagRemove(tag)}
          />
        ))}
      </div>
      <div className={styles.availableTags}>
        {availableTags.map((tag, index) => (
          <div
            key={index}
            className={styles.tagItem}
            onClick={() => handleTagSelect(tag)}
          >
            {tag}
          </div>
        ))}
      </div>
    </div>
  );
};
