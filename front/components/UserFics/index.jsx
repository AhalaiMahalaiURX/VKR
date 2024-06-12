//Это компонент, который представляет из себя 3 списка с разными
//состоянми фиков: "Закончено", "Завершено" и ТД
//По-хорошему надо смотреть на Статус, то сейчас пока похуй
//здесь надо сделать запрос в БД и рассортировать фанфики
//после этого отсортированные запихать в нужные таблицы отображения
//массив "Processed Fics"
//Массив "Completed Fics"
//Массив "Frozen fics"
//Пока что можно забить и просто послать запрос получить Fic и зсунуть их UserFicList, который этого ожидает
/*
export const UserFics = ({ userID }) => {
  const [author, setAuthor] = useState(null); // Состояние для хранения данных автора
  useEffect(() => {
    if (userID) {
      fetch(`https://localhost:7006/api/Authors/${userID}`)
        .then((response) => response.json())
        .then((data) => {
          console.log(data); // Вывод данных в консоль
          setAuthor(data);
        })
        .catch((error) => console.error("Error:", error));
    }
  }, [userID]);
  return <h1>{author.description}</h1>;
};





import { Accordion, AccordionTab } from "primereact/accordion";
import styles from "./index.module.css";
import { UserFicList } from "../UserFicList";
import { useState, useEffect } from "react";

export const UserFics = ({ userID }) => {
  const [userFics, setUserFics] = useState(null); // Состояние для хранения данных о фиках

  //данные успешно получил
  useEffect(() => {
    if (userID) {
      fetch(`https://localhost:7006/api/Fanfics/${userID}`) //поменять контроллер
        .then((response) => response.json())
        .then((data) => {
          console.log(data); // Вывод данных в консоль
          setUserFics(data); //setAuthor(data), здесь должен получить массив фиков
        })
        .catch((error) => console.error("Error:", error));
    }
  }, [userID]);

  return (
    <Accordion multiple activeIndex={[0]} className={styles.acc}>
      <AccordionTab header="В процессе">
        <UserFicList fics={userFics} />
      </AccordionTab>
      <AccordionTab header="Завершены">
        <UserFicList fics={userFics} />
      </AccordionTab>
      <AccordionTab header="Заморожены">
        <UserFicList fics={userFics} />
      </AccordionTab>
    </Accordion>
  );
};


*/

import { Accordion, AccordionTab } from "primereact/accordion";
import styles from "./index.module.css";
import { UserFicsList } from "../UserFicsList";
import { useState, useEffect } from "react";

export const UserFics = ({ userID }) => {
  const [userCompletedFics, setUserCompletedFics] = useState(null);
  const [userHiatusFics, setUserHiatusFics] = useState(null);
  const [userInProcessFics, setUserInProcessFics] = useState(null);

  useEffect(() => {
    if (userID) {
      fetch(`https://localhost:7006/api/Fanfics/${userID}`)
        .then((response) => response.json())
        .then((data) => {
          // Фильтрация
          setUserCompletedFics(
            data.filter((fic) => fic.status === "Завершено")
          );
          setUserHiatusFics(data.filter((fic) => fic.status === "Заморожен"));
          setUserInProcessFics(
            data.filter((fic) => fic.status === "В процессе")
          );
        })
        .catch((error) => console.error("Ошибка:", error));
    }
  }, [userID]);

  return (
    <Accordion multiple activeIndex={[0]} className={styles.acc}>
      <AccordionTab header="В процессе">
        <UserFicsList fics={userInProcessFics} />
      </AccordionTab>
      <AccordionTab header="Завершены">
        <UserFicsList fics={userCompletedFics} />
      </AccordionTab>
      <AccordionTab header="Заморожены">
        <UserFicsList fics={userHiatusFics} />
      </AccordionTab>
    </Accordion>
  );
};
