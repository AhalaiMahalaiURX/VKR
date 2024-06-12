import React, { useContext } from "react";
import { Rating } from "primereact/rating";

import styles from "./index.module.css";

export const CommentsComp = () => {
  return (
    <div className={styles.commentsContainer}>
      {fics.map((fic) =>
        fic.comments.map((comment, index) => (
          <div key={index} className={styles.commentBlock}>
            <div className={styles.commentAuthor}>{comment.commentAuthor}</div>
            <Rating
              value={parseInt(comment.commentRate)}
              readOnly
              stars={5}
              cancel={false}
            />
            <div className={styles.commentContent}>
              {comment.commentSummary}
            </div>
          </div>
        ))
      )}
    </div>
  );
};
