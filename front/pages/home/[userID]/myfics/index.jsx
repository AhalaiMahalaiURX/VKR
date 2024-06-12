//здесь посылаю запрос к БД чтобы отобразить работы пользователя
//черещ router вытаскиваю userID для осуществления этого запроса
import { UserFics } from "@/components/UserFics";
import { useRouter } from "next/router";

const MyFics = () => {
  const router = useRouter();
  const { userID } = router.query;

  return (
    <>
      <h1>Мои работы</h1>
      <UserFics userID={userID} />
    </>
  );
};

export default MyFics;
