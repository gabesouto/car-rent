using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        this.Vehicle = vehicle;
        this.Person = person;
        this.DaysRented = daysRented;
        this.Price = this.Person is LegalPerson ? this.Vehicle.PricePerDay * this.DaysRented * 0.9 : this.Vehicle.PricePerDay * this.DaysRented;
        this.Status = RentStatus.Confirmed;
        this.Vehicle.IsRented = true;
        this.Person.Debit = this.Price;

    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        throw new NotImplementedException();
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        throw new NotImplementedException();
    }
}