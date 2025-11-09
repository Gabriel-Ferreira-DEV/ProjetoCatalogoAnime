import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import api from "../services/api";
import { Banner } from "../components/Banner";
import imageBanner from "/Anime/bannerAnimes.jpg";

interface Anime {
  id: number;
  titulo: string;
  descricao: string;
  imagemNome: string;
  plataformaNome: string;
  plataformaUrl: string;
}

export default function Home() {
  const [animes, setAnimes] = useState<Anime[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    async function carregarAnimes() {
      try {
        const response = await api.get<Anime[]>("/animes");
        setAnimes(response.data);
      } catch (error) {
        console.error("Erro ao carregar animes:", error);
      } finally {
        setLoading(false);
      }
    }

    carregarAnimes();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center h-screen bg-black">
        <div className="animate-spin rounded-full h-16 w-16 border-t-4 border-b-4 border-purple-400"></div>
      </div>
    );
  }

  return (
    <div className="w-full min-h-screen bg-black flex flex-col">
      <div className="relative w-full mb-10">
        <Banner imagem={imageBanner} alt="Banner Animes" />
        <div className="absolute inset-0 bg-gradient-to-t from-black/70 to-transparent flex items-center justify-center"></div>
        <img
          src="/Anime/Logo.png"
          alt="OtakuVerse Logo"
          className="absolute bottom-4 left-6 w-32 drop-shadow-[0_0_10px_rgba(168,85,247,0.8)]"
        />
      </div>

      <h1 className="text-4xl font-extrabold mb-8 text-center bg-gradient-to-r from-purple-400 to-pink-400 bg-clip-text text-transparent">
        Animes
      </h1>
      <div className="flex-1 px-6">
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-8">
          {animes.map((anime) => (
            <div
              key={anime.id}
              className="bg-gray-900/80 backdrop-blur-md rounded-xl shadow-lg hover:shadow-purple-500/40 hover:scale-105 transition-transform duration-300 border border-gray-700"
            >
              <Link to={`/anime/${anime.id}`} className="flex flex-col">
                <img
                  src={`/Anime/${anime.imagemNome}`}
                  alt={anime.titulo}
                  className="w-full h-64 object-cover rounded-t-xl"
                  onError={(e) => {
                    const target = e.currentTarget as HTMLImageElement;
                    target.src = "/Anime/placeholder.jpg";
                  }}
                />
                <div className="p-4">
                  <h3 className="text-lg font-bold mb-2 text-white">
                    {anime.titulo}
                  </h3>
                  <p className="text-sm text-gray-300 mb-2 line-clamp-3">
                    {anime.descricao}
                  </p>
                </div>
              </Link>
              <div className="px-4 pb-4">
                <a
                  href={anime.plataformaUrl}
                  target="_blank"
                  rel="noopener noreferrer"
                  className="block text-sm bg-gradient-to-r from-green-400 to-green-600 text-white text-center font-bold px-3 py-2 rounded-lg hover:scale-105 hover:opacity-90 transition"
                >
                  Assistir em {anime.plataformaNome}
                </a>
              </div>
            </div>
          ))}
        </div>
      </div>
      <footer className="mt-12 bg-gradient-to-r from-purple-900 to-black text-gray-300 py-6 text-center">
        <p className="text-sm">
          © {new Date().getFullYear()} Catálogo de Animes — Desenvolvido por Gabriel
        </p>
        <div className="flex justify-center gap-6 mt-3">
          <a
            href="https://wa.me/5511917715994"
            target="_blank"
            rel="noopener noreferrer"
            className="hover:text-purple-400 transition"
          >
            Contato (WhatsApp)
          </a>
          <a
            href="https://github.com/Gabriel-Ferreira-DEV/ProjetoCatalogoAnime"
            target="_blank"
            rel="noopener noreferrer"
            className="hover:text-purple-400 transition"
          >
            GitHub
          </a>
        </div>
      </footer>
    </div>
  );
}
