import { ChapterInfoComp } from "../ChapterInfoComp";
export const ChapterWrapper = ({ bookId, chapterId }) => {
  //запрос на получение информациюю о главе по её idшнику

  // Найти главу по chapterId
  const curChapter = book?.chapters.find((chap) => chap.id === chapterId);

  if (!curChapter) {
    return <p>Глава не найдена!</p>;
  }

  return (
    <>
      <ChapterInfoComp curChapter={curChapter} />
    </>
  );
};
