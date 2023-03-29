using FirstSpawn;

public class LevelCreator
{
    private IFirstSpawnForPool[] _firstSpawnForPool = 
    {
        new FirstSpawnOfBullet() 
    };
    public void CreateScene()
    {
        foreach(IFirstSpawnForPool pool in _firstSpawnForPool)
        {
            pool.FirstCreationOfObjects();
        }
    }
}
