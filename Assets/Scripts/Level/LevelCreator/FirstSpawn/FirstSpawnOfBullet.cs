namespace FirstSpawn
{
    public class FirstSpawnOfBullet: IFirstSpawnForPool
    {
        public void FirstCreationOfObjects()
        {
            PoolObjectCreator poolObjectCreator = new PoolObjectCreator();
            ObjectStorage objectStorage = ObjectStorage.instance;

            for (int i = 0; i < objectStorage.NumberOfFirstBullets; i++)
            {
                poolObjectCreator.CreateObjectForPool(PrefabStorage.instance.Bullet, ObjectStorage.instance.PoolOfBullets);
            }
        }
    }
}
