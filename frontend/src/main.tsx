import "./styles.css";
import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import { BrowserRouter, Route, Routes } from "react-router";
import { LandingPage } from "./pages/LandingPage.tsx";
import { LoginSignUpPage } from "./pages/LoginSignUpPage.tsx";

createRoot(document.getElementById("root")!).render(
    <StrictMode>
        <BrowserRouter>
            <Routes>
                <Route index element={<LandingPage />} />
                <Route path="login-signup" element={<LoginSignUpPage />} />
            </Routes>
        </BrowserRouter>
    </StrictMode>,
);
