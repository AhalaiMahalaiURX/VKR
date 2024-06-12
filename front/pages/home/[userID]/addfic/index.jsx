import { RatingType } from "@/components/RatingType";
import { LimitedInputField } from "@/components/LimitedInputField";
import { RuleNotice } from "@/components/RuleNotice";
import { Focus } from "@/components/Focus";
import { Type } from "@/components/Type";
import { Fandom } from "@/components/Fandoms";
import { Genre } from "@/components/Genres";
import { useState, useContext } from "react";
import { InputTags } from "@/components/Tags";
import Link from "next/link";
import { FanficContext } from "@/components/contexts/FanficContext";

function Addfic() {
  const { updateFanficData } = useContext(FanficContext);
  const [title, setTitle] = useState("");

  const handleTitleChange = (e) => {
    setTitle(e.target.value);
    updateFanficData("title", e.target.value);
  };
  return (
    <div className={styles.addficContainer}>
      <h1>Добавить новый фанфик</h1>
      <RuleNotice />
      <div className={styles.inputGroup}>
        <strong className={styles.title}>Название</strong>
        <input
          type="text"
          className={styles.inputField}
          value={title}
          onChange={handleTitleChange}
        />
      </div>
      <Type />
      <Focus />
      <Fandom />
      <RatingType />
      <Genre />
      <InputTags />
      <LimitedInputField
        length={500}
        inputText="Введите краткое описание"
        inputTitle="Добавьте описание"
      />

      <button className={styles.btn}>Опубликовать работу</button>
    </div>
  );
}

export default Addfic;
