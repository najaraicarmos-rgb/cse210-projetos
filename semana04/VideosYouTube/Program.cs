
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Receita de Lasanha", "Najara", 600);
        video1.AdicionarComentario(new Comentario("Maria", "Adorei a receita!"));
        video1.AdicionarComentario(new Comentario("João", "Vou fazer em casa."));
        video1.AdicionarComentario(new Comentario("Ana", "Ficou muito bem explicado."));

        Video video2 = new Video("Passeio em Campinas", "Daniel", 480);
        video2.AdicionarComentario(new Comentario("Carlos", "Que lugar bonito!"));
        video2.AdicionarComentario(new Comentario("Juliana", "Gostei muito do passeio."));
        video2.AdicionarComentario(new Comentario("Pedro", "Preciso conhecer Campinas."));

        Video video3 = new Video("Como Organizar os Estudos", "Najara", 720);
        video3.AdicionarComentario(new Comentario("Lucas", "Essas dicas ajudaram bastante."));
        video3.AdicionarComentario(new Comentario("Mariana", "Vou começar a organizar minha rotina."));
        video3.AdicionarComentario(new Comentario("Rafael", "Muito bom!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine($"Número de comentários: {video.ObterNumeroDeComentarios()}");

            foreach (Comentario comentario in video.Comentarios)
            {
                Console.WriteLine($"Comentário de {comentario.Nome}: {comentario.Texto}");
            }

            Console.WriteLine();
        }
    }
}

