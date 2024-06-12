import { UserFicsListElement } from "../UserFicsListElement";

export const UserFicsList = ({ fics }) => {
  return (
    <div>
      {fics.map((fic) => (
        <UserFicsListElement key={fic.id} fanfic={fic} />
      ))}
    </div>
  );
};
