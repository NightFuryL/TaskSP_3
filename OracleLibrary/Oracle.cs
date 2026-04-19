namespace OracleLibrary;

public class Oracle
{
    private string[] _answers =
    {
        "Безсумнівно!",
        "Шанси дуже хороші.",
        "Зірки кажуть 'Так'.",
        "Спитайте пізніше, зараз не ясно.",
        "Краще вам цього не знати.",
        "Зовсім ні.",
        "Дуже сумнівно.",
        "Навіть не сподівайся"
    };
    private Random _randomizer = new Random();
    public string GetAnswer()
    {
        int index = _randomizer.Next(0, _answers.Length);
        return _answers[index];
    }
}
