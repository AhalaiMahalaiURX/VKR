import { InfoPanel } from "@/components/InfoPanel";
import { PublicationParams } from "@/components/PublicationParams";
import { ChapterEditor } from "@/components/ChapterEditor";
import styles from "./index.module.css";
import { useRouter } from "next/router";

const AddPart = () => {
  const router = useRouter();
  const { ficID } = router.query;
  return (
    <div className={styles.elements}>
      <InfoPanel />
      <ChapterEditor ficId={ficID} />
      <PublicationParams />
    </div>
  );
};
