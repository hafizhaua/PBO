namespace PetCare
{
    public interface IPetModel
    {
        double Weight { get; set; }
        string Animal { get; set; }
        string Name { get; set; }
        string Sex { get; set; }
        IRegisteringPet Generator { get; set; }
    }
}