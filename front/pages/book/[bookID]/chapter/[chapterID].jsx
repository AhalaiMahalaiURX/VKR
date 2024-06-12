import { useRouter } from "next/router";
import { ChapterWrapper } from "@/components/ChapterWrapper";

const ChapterPage = () => {
  const router = useRouter();
  const { bookId, chapterId } = router.query;

  return (
    <>
      <ChapterWrapper bookId={bookId} chapterId={chapterId} />
    </>
  );
};
