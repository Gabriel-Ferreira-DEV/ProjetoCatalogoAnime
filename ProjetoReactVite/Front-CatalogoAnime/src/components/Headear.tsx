
interface HeaderProps {
  titulo: string;
}

export function Header({ titulo }: HeaderProps) {
  return (
    <header className="w-full shadow-md py-6">
      <h1 className="text-center text-black text-4xl md:text-5xl font-extrabold tracking-wide select-none">
        {titulo}
      </h1>
    </header>
  );
}
