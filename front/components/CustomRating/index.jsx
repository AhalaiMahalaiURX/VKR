import { Rating } from "primereact/rating";

export const CustomRating = ({ ratingValue }) => {
  // Округляем значение рейтинга до ближайшего целого числа
  const roundedRating = Math.round(ratingValue);

  return (
    <div className="card flex justify-content-center">
      <Rating value={roundedRating} readOnly cancel={false} />
    </div>
  );
};
