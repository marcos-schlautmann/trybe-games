namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        return (
                    from game in this.Games
                    where game.DeveloperStudio == gameStudio.Id
                    select game

                ).ToList();
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        return (
                    from playerFound in this.Players
                    where player.Id == playerFound.Id
                    from game in this.Games
                    where playerFound.GamesOwned.Contains(game.Id)
                    select game

                ).ToList();
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        return (
                    from player in this.Players
                    where playerEntry.Id == player.Id
                    from game in this.Games
                    where player.GamesOwned.Contains(game.Id)
                    select game

                ).ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {

        var gameWithStudio = from game in this.Games
                             from gameStudio in GameStudios
                             where game.DeveloperStudio == gameStudio.Id
                             select new GameWithStudio
                             {
                                GameName = game.Name,
                                StudioName = gameStudio.Name,
                                NumberOfPlayers = game.Players.Count
                             };

        return gameWithStudio.ToList();

                                 
    }
    
    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
