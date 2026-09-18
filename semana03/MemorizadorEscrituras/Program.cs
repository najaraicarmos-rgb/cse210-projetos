using MemorizadorEscrituras;

Referencia ref1 = new Referencia("Proverbios", 3, 5, 6);
Escritura esc1 = new Escritura(ref1, "Confia no Senhor de todo o teu coracao");

Console.WriteLine(esc1.ObterTexto());