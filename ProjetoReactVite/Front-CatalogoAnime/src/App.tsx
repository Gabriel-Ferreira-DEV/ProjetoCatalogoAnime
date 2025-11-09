
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Home from "./pages/Home";import AnimeDetails from "./pages/AnimeDetails";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/anime/:id" element={<AnimeDetails />} />
      </Routes>
    </Router>
  );
}

export default App;
