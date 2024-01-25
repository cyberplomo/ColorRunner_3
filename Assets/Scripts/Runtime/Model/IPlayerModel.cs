using Runtime.Data.ValueObject;


namespace Runtime.Model
{
    public interface IPlayerModel
    {
        int KilledEnemyCount { get; set; }
        PlayerVO PlayerVo { get; set; }

       
    }
}