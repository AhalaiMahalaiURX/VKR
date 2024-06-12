import React, { createContext, useState } from "react";

export const FanficContext = createContext();

export const FanficProvider = ({ children }) => {
  const [fanficData, setFanficData] = useState({
    title: "",
    type: "",
    focus: "",
    ageRating: "",
    genre: ["", "", "", "", ""],
    summary: "",
    tags: ["", "", "", "", "", "", "", "", "", ""],
    fandom: ["", ""],
  });

  const updateFanficData = (key, value) => {
    setFanficData((prevData) => ({
      ...prevData,
      [key]: value,
    }));
  };

  return (
    <FanficContext.Provider value={{ fanficData, updateFanficData }}>
      {children}
    </FanficContext.Provider>
  );
};
