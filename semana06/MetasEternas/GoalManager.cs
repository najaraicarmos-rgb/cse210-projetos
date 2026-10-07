using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("  1. Criar Nova Meta");
            Console.WriteLine("  2. Listar Metas");
            Console.WriteLine("  3. Salvar Metas");
            Console.WriteLine("  4. Carregar Metas");
            Console.WriteLine("  5. Registrar Evento");
            Console.WriteLine("  6. Sair");
            Console.Write("Selecione uma opção da escolha: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Você tem {_score} pontos.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("As metas são:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("As metas são:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Os tipos de metas são:");
        Console.WriteLine("  1. Meta Simples");
        Console.WriteLine("  2. Meta Eterna");
        Console.WriteLine("  3. Meta de Lista de Tarefas (Checklist)");
        Console.Write("Qual tipo de meta você gostaria de criar? ");
        string typeChoice = Console.ReadLine();

        Console.Write("Qual é o nome da sua meta? ");
        string name = Console.ReadLine();
        Console.Write("Escreva uma breve descrição dela: ");
        string description = Console.ReadLine();
        Console.Write("Quantos pontos estão associados a esta meta? ");
        string points = Console.ReadLine();

        if (typeChoice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (typeChoice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (typeChoice == "3")
        {
            Console.Write("Quantas vezes essa meta precisa ser realizada para um bônus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Qual é o bônus para realizá-la tantas vezes? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Qual meta você realizou? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();

            int pointsEarned = int.Parse(goal.GetPoints());
            _score += pointsEarned;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                // Se completou a meta de checklist, podemos adicionar um comportamento extra se necessário
            }

            Console.WriteLine($"Parabéns! Você ganhou {pointsEarned} pontos!");
            Console.WriteLine($"Você agora tem {_score} pontos.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Qual é o nome do arquivo para o arquivo de metas? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Metas salvas com sucesso!");
    }

    public void LoadGoals()
    {
        Console.Write("Qual é o nome do arquivo para o arquivo de metas? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(":");
                string goalType = parts[0];
                string details = parts[1];

                string[] values = details.Split(",");

                if (goalType == "SimpleGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    string points = values[2];
                    bool isComplete = bool.Parse(values[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    string points = values[2];

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    string points = values[2];
                    int bonus = int.Parse(values[3]);
                    int target = int.Parse(values[4]);
                    int amountCompleted = int.Parse(values[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Metas carregadas com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}