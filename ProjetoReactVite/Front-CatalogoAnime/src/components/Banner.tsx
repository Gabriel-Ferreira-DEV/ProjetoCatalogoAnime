interface BannerProps {
  imagem: string;
  alt?: string;
  titulo?: string;
  subtitulo?: string;
}

export function Banner({ imagem, alt = "Banner", titulo, subtitulo }: BannerProps) {
  return (
    <div className="relative w-full mb-8">
      {/* Imagem de fundo */}
      <img
        src={imagem}
        alt={alt}
        className="w-full h-[800px] object-cover rounded-lg shadow-md"
        onError={(e) => {
          const target = e.currentTarget as HTMLImageElement;
          target.src = "/Banner/placeholder.jpg";
        }}
      />

      {/* Overlay para escurecer e destacar texto */}
      <div className="absolute inset-0 bg-black/40 rounded-lg flex flex-col items-center justify-center text-center px-4">
        {titulo && (
          <h1 className="text-4xl md:text-6xl font-extrabold text-white drop-shadow-lg">
            {titulo}
          </h1>
        )}
        {subtitulo && (
          <p className="mt-4 text-lg md:text-2xl text-gray-200 max-w-2xl">
            {subtitulo}
          </p>
        )}
      </div>
    </div>
  );
}