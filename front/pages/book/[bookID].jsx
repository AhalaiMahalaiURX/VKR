import { useRouter } from "next/router";
import { BookAboutComp } from "@/components/BookAboutComp";
import { BookInfoComp } from "@/components/BookInfoComp";
import { BookReviewsComp } from "@/components/BookReviewsComp";
import { BookTableComp } from "@/components/BookTableComp";
import { useState } from "react";

const BookPage = () => {
  const router = useRouter();
  const { bookID } = router.query;
  const [book, setBook] = useState(null);

  //bookInfo - передаем сам фанфик
  //about - краткое содержание
  //table - массив глав
  useEffect(() => {
    if (userID) {
      fetch(`https://localhost:7006/api/BookInfo/${bookID}`)
        .then((response) => response.json())
        .then((data) => {
          setBook(data);
        })
        .catch((error) => console.error("Ошибка:", error));
    }
  }, [bookID]);
  return (
    <>
      <BookInfoComp book={book} />
      <BookAboutComp description={book.description} />
      <BookTableComp chapters={book.chapters} />
      <BookReviewsComp reviews={book.reviews} />
    </>
  );
};

export default BookPage;
