import { PrimeReactProvider } from "primereact/api";
import "primereact/resources/themes/saga-blue/theme.css";
import HeaderLayout from "@/components/layouts/NavigationMenuLayout";
import { FanficProvider } from "@/components/contexts/FanficContext";

const MyApp = ({ Component, pageProps }) => {
  return (
    <PrimeReactProvider>
      <HeaderLayout>
        <FanficProvider>
          <Component {...pageProps} />
        </FanficProvider>
      </HeaderLayout>
    </PrimeReactProvider>
  );
};

export default MyApp;
