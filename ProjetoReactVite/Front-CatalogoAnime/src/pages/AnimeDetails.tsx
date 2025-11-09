import { useEffect, useState } from "react";
import { useParams, Link } from "react-router-dom";
import api from "../services/api";

interface Anime {
  id: number;
  titulo: string;
  descricao: string;
  imagemNome: string;
  plataformaNome: string;
  plataformaUrl: string;
}

export default function AnimeDetails() {
  const { id } = useParams<{ id: string }>();
  const [anime, setAnime] = useState<Anime | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    async function carregarAnime() {
      try {
        const response = await api.get<Anime>(`/animes/${id}`);
        setAnime(response.data);
      } catch (error) {
        console.error("Erro ao carregar anime:", error);
      } finally {
        setLoading(false);
      }
    }

    carregarAnime();
  }, [id]);

  if (loading) {
    return (
      <div className="flex justify-center items-center h-screen bg-black">
        <div className="animate-spin rounded-full h-16 w-16 border-t-4 border-b-4 border-purple-400"></div>
      </div>
    );
  }

  if (!anime) {
    return (
      <div className="flex justify-center items-center h-screen bg-black text-white">
        <p>Anime não encontrado.</p>
      </div>
    );
  }

  return (
    <div className="w-full min-h-screen bg-black text-white px-6 py-12 flex flex-col items-center">
      {/* Título com gradiente */}
      <h1 className="text-5xl md:text-6xl font-extrabold mb-12 text-center bg-gradient-to-r from-purple-400 to-pink-400 bg-clip-text text-transparent drop-shadow-lg">
        {anime.titulo}
      </h1>

      {/* Card grande com imagem + descrição */}
      <div className="flex flex-col md:flex-row gap-12 max-w-7xl w-full bg-gray-900/80 backdrop-blur-md rounded-2xl shadow-2xl border border-gray-700 p-8">
        {/* Imagem */}
        <img
          src={`/Anime/${anime.imagemNome}`}
          alt={anime.titulo}
          className="w-full md:w-1/3 h-[600px] object-cover rounded-xl shadow-lg"
          onError={(e) => {
            const target = e.currentTarget as HTMLImageElement;
            target.src = "/Anime/placeholder.jpg";
          }}
        />

        {/* Texto */}
        <div className="flex-1 flex flex-col justify-between">
          <p className="text-lg md:text-xl text-gray-300 mb-8 whitespace-pre-line leading-relaxed">
            {anime.descricao}
          </p>

          <div className="flex flex-col gap-4">
            <a
              href={anime.plataformaUrl}
              target="_blank"
              rel="noopener noreferrer"
              className="inline-block text-lg bg-gradient-to-r from-green-400 to-green-600 text-white text-center font-bold px-6 py-3 rounded-lg hover:scale-105 hover:opacity-90 transition"
            >
              Assistir em {anime.plataformaNome}
            </a>

            <Link
              to="/"
              className="inline-block text-lg text-purple-400 hover:text-pink-400 transition"
            >
              ← Voltar para o catálogo
            </Link>
          </div>
        </div>
      </div>
    </div>
  );
}