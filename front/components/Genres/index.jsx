import { useState, useContext } from "react";
import styles from "./index.module.css";
import { FanficContext } from "../contexts/FanficContext";

export const Genre = () => {
  const [selectedGenres, setSelectedGenres] = useState([]);
  const { updateFanficData } = useContext(FanficContext);
  const handleGenreChange = (genre) => {
    const updatedGenres = selectedGenres.includes(genre)
      ? selectedGenres.filter((g) => g !== genre)
      : [...selectedGenres, genre].slice(0, 5);
    setSelectedGenres(updatedGenres);
    updateFanficData("genres", updatedGenres);
  };
  //здесь тоже нужен запрос к жанрам
  return (
    <div className={styles.genreContainer}>
      <span>Выберите жанры</span>
      {[
        "Приключения",
        "Ангст",
        "Драма",
        "Фентези",
        "Ужасы",
        "Пародия",
        "Мистика",
        "Детектив",
        "Романтика",
        "Sci-Fi",
      ].map((genre) => (
        <label key={genre} className={styles.label}>
          <input
            type="checkbox"
            value={genre}
            checked={selectedGenres.includes(genre)}
            onChange={() => handleGenreChange(genre)}
            className={styles.checkbox}
          />
          {genre}
        </label>
      ))}
    </div>
  );
};
