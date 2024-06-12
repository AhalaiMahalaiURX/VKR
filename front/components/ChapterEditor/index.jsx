import { useState, useEffect } from "react";
import styles from "./index.module.css";

export const ChapterEditor = ({ ficId }) => {
  const [chapterTitle, setChapterTitle] = useState("");
  const [content, setContent] = useState("");
  const textAreaRef = useRef(null);

  useEffect(() => {
    if (userID) {
      fetch(`https://localhost:7006/api/Fanfics/${chapterID}`)
        .then((response) => response.json())
        .then((data) => {
          setContent(data.summary);
          setChapterTitle(data.title);
        })
        .catch((error) => console.error("Ошибка:", error));
    }
  }, []);

  const handleTitleChange = (e) => {
    setChapterTitle(e.target.value);
  };

  const handleContentChange = (e) => {
    setContent(e.target.value);
  };
  //потом поменять название контроллера
  const handleSave = () => {
    const chapterData = {
      title: chapterTitle,
      summary: content,
    };
    fetch(`https://localhost:7006/api/Fanfics/${chapterID}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(chapterData),
    })
      .then((response) => {
        if (response.ok) {
          return response.json();
        }
        throw new Error("Ошибка при сохранении главы");
      })
      .then((data) => {
        alert("Глава успешно сохранена!");
      })
      .catch((error) => {
        console.error("Ошибка:", error);
      });
  };

  const applyFormatting = (formatType) => {
    const start = textAreaRef.current && textAreaRef.current.selectionStart;
    const end = textAreaRef.current && textAreaRef.current.selectionEnd;
    const selectedText = content.substring(start, end); // Проверка выделенного текста

    if (start !== end) {
      let formattedText = "";

      switch (formatType) {
        case "bold":
          formattedText = `<b>${selectedText}</b>`;
          break;
        case "italic":
          formattedText = `<i>${selectedText}</i>`;
          break;
        case "tab":
          formattedText = `\t${selectedText}`;
          break;

        default:
          break;
      }

      setContent(
        (prevContent) =>
          prevContent.substring(0, start) +
          formattedText +
          prevContent.substring(end)
      );
    } else {
      alert("Выделите текст для форматирования!");
    }
  };

  useEffect(() => {
    if (textAreaRef.current) {
      textAreaRef.current.focus();
    }
  }, []);

  return (
    <div className={styles.chapterEditor}>
      <h3>Название главы</h3>
      <input
        type="text"
        placeholder="Введите название"
        value={chapterTitle}
        onChange={handleTitleChange}
      />
      <div className={styles.toolbar}>
        <button onClick={() => applyFormatting("bold")}>B</button>
        <button onClick={() => applyFormatting("italic")}>I</button>
        <button onClick={() => applyFormatting("tab")}>Tab</button>
      </div>

      <textarea
        value={content}
        onChange={handleContentChange}
        cols="30"
        rows="20"
        ref={textAreaRef}
      ></textarea>
      <div className={styles.btns}>
        <button onClick={handleSave}>Сохранить изменения</button>
      </div>
    </div>
  );
};
