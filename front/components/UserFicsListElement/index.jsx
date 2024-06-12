import styles from "./index.module.css";
import { UserFicsListElementTitle } from "../UserFicsListElementTitle";
import { UserFicsListElementChapters } from "../UserFicsListElementChapters";
import { UserFicsListElementAddButton } from "../UserFicsListElementAddButton";

export const UserFicsListElement = ({ fanfic }) => {
  return (
    <div>
      <UserFicsListElementTitle
        fanficTitle={fanfic.title}
        fanficComNum={fanfic.commentsNumber}
        fanficBookNum={fanfic.bookmarksNumber}
      />
      <UserFicsListElementChapters chaptersList={fanfic.chapters} />
      <UserFicsListElementAddButton />
    </div>
  );
};
