
List<Word> words = new WordLoader().Create();

DifficultyConfiguration difficulty = new GameDifficultyFactory().Create(new DifficultyReader().Choice());

