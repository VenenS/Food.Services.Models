namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class RatingModel
    {
        public long Id { get; set; }
        
        public int Value { get; set; }
        
        public long UserId { get; set; }
        
        public ObjectTypesEnum TypeOfObject { get; set; }
        
        public long ObjectId { get; set; }
    }
}
