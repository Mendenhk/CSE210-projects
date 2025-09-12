public class MotivationGenerator
{
    public List<string> _motivations = new List<string>()
    {
        "Your Journal Is Your Safe Space, Not a Performance.  You do not need to write perfectly or produce a masterpiece. Your journal is a private haven where you can express yourself without judgment. Misspellings, messy thoughts, or incomplete sentences are okay—authenticity matters more than polish. Let your words flow naturally; they are for you, not an audience.",
        "Small Moments Matter More Than Grand Details. You do not need to document every detail of your day to make your journal meaningful. Capture a single thought, feeling, or moment that stands out—like a kind word from a friend or a quiet moment of gratitude. These small entries can be just as powerful as lengthy ones and make journaling feel less overwhelming.",
        "Progress, Not Perfection, Fuels Growth. Journaling is not about crafting a flawless record of your life; it is about exploring your thoughts and emotions to learn and grow. Each entry, no matter how short or simple, is a step toward understanding yourself better. Embrace the messiness—it is part of the journey.",
        "Your Words Have Power, Even If They are Brief. You do not need to write pages to make an impact. A single sentence about what inspired you today or a quick note about a challenge you faced can be enough. The act of writing helps you process and reflect, and even brief entries can spark meaningful insights over time.",
        "Journaling Is a Gift to Your Future Self. Every entry, no matter how imperfect, is a snapshot of who you are right now. Months or years from now, you will look back and appreciate the honesty and courage it took to write. Journaling lets you celebrate your growth, rediscover forgotten joys, and see how far you have come—without needing to be perfect."
    };
    

    public string GetMotivation()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        string randomMotivation = _motivations[number];
        return randomMotivation;
    }
}

