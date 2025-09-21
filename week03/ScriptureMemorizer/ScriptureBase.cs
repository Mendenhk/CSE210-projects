public class ScriptureBase
{
    //ATTRIBUTES
    private List<string> _scriptures = [
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.",
        "And he gave some, apostles; and some, prophets; and some, evangelists; and some, pastors and teachers; For the perfecting of the saints, for the work of the ministry, for the edifying of the body of Christ: Till we all come in the unity of the faith, and of the knowledge of the Son of God, unto a perfect man, unto the measure of the stature of the fulness of Christ: That we henceforth be no more children, tossed to and fro, and carried about with every wind of doctrine, by the sleight of men, and cunning craftiness, whereby they lie in wait to deceive;",
        "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."
    ];
    private List<string> _books = [
        "Proverbs",
        "Ephesians",
        "Moroni"
    ];
    private List<string> _chapters = ["3", "4", "10"];
    private List<string> _verses = ["5", "11", "4"];
    private List<string> _endVerses = ["6", "14", "5"];

    //METHODS
    public List<string> ChooseRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(0, _scriptures.Count);
        List<string> completeScripture = [_scriptures[index], _books[index], _chapters[index], _verses[index], _endVerses[index]];
        return completeScripture;
    }
}