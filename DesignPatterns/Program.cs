using DesignPatterns.Observer;
using DesignPatterns;
using Gym.Common;
using Gym.Decorator;
using Gym.Strategy;
using Gym.Strategy.Payments;
using Gym.Common.Additions;
using DesignPatterns.Singleton;



public class Program
{
    public static void Main(string[] args)
    {
        // Creating a gym (Singleton)
        Gym1 gym = Gym1.Instance("New Life", "Brussels", "06:00 - 23:00");

        // Displaying gym information
        Console.WriteLine($"Gym: {gym.Name}");
        Console.WriteLine($"Location: {gym.Location}");
        Console.WriteLine($"Working Hours: {gym.WorkingHours}");

        // Updating working hours
        gym.UpdateWorkingHours("07:00 - 22:00");
        Console.WriteLine($"Updated Working Hours: {gym.WorkingHours}");

        // Creating specializations

        Specialization spec1 = new Specialization("Conditioning Training", "National Academy of Sports Medicine", new DateTime(2020, 5, 10));
        Specialization spec2 = new Specialization("Strength Training", "International Sports Sciences Association", new DateTime(2019, 8, 15));

        // Creating an instructors
        Instructor instructor = new Instructor("Peter", "Certified Fitness Instructor", 2, new List<Specialization> { spec1,spec2}, "peter@example.com", "123456789");
        Instructor instructor1 = new Instructor("Antonio", "Certified Weight Loss Instructor", 1, new List<Specialization> { spec2}, "peter@example.com", "123456789");


        // Creating trainees with different payment methods
        Trainee trainee1 = new Trainee("Ivan", 25, "ivan@gmail.com", "123456789", " Street 1", new DateTime(2024, 12, 31), new DateTime(2025, 01, 31));
        Trainee trainee2 = new Trainee("Maria", 30, "maria@gmail.com", "987654321", "Street 2", new DateTime(2024, 6, 30), new DateTime(2024, 7, 30));
        Trainee trainee3 = new Trainee("Peter", 28, "petar@gmail.com", "654321987", "Street 3", new DateTime(2023, 11, 30), new DateTime(2023, 12, 30));
        Trainee trainee4 = new Trainee("George", 32, "georgi@gmail.com", "789456123", "Street 4", new DateTime(2024, 5, 30), new DateTime(2024, 6, 30));

        // Creating different payment methods (Strategy)
        IPayment paymentMethod1 = new CreditCard("1234567890123456", "Ivan Ivanov", "12/24", "779");
        IPayment paymentMethod2 = new PayPal("maria@example.com");

        BasicProgram program = new BasicProgram(60);

        //Adding additional services(Decorator)
        MuscleGainDiet muslceGainDiet = new MuscleGainDiet(30, "Muscle Gain Diet");
        MuscleSupplements muscleSupplements = new MuscleSupplements(70, "Muscle Suplements");
        Spa spa = new Spa(50, "Spa");
        WeightLossSupplements weightLossSupl = new WeightLossSupplements(90, "Weight Loss Supplements");
        WeightLossDiet weightLossDiet = new WeightLossDiet(40, "Weight Loss Diet");

        trainee1.AddAddition(muscleSupplements);
        trainee1.AddAddition(muslceGainDiet);
        trainee2.AddAddition(spa);
        trainee2.AddAddition(weightLossDiet);
        trainee3.AddAddition(weightLossDiet);
        trainee4.AddAddition(weightLossSupl);

        if (paymentMethod1.IsPaymentMethodInfoValid())
        {
            trainee1.PaymentMethod = paymentMethod1;
            decimal sum = 0;
            foreach (var addition in trainee1.additions)
            {
                sum += addition.Price;
            }
            decimal amount = trainee1.CalculateAmountToPay(program.Price, sum);
            trainee1.MakePayment(amount);
            instructor.AddTrainee(trainee1);
        }


        if (paymentMethod2.IsPaymentMethodInfoValid())
        {
            trainee1.PaymentMethod = paymentMethod2;
            decimal sum = 0;
            foreach (var addition in trainee2.additions)
            {
                sum += addition.Price;
            }
            decimal amount = trainee1.CalculateAmountToPay(program.Price, sum);
            trainee1.MakePayment(amount);
            instructor.AddTrainee(trainee2);
        }


        // Updating instructor's contact information
        instructor.UpdateContactInfoEmail("new_peter@example.com");

        // Renewing memberships and updating contact information for trainees
        trainee1.RenewMembership(new DateTime(2025, 12, 31));
        trainee2.UpdatePhoneNumber( "555555555");

        // Customizing the training program (Decorator)
        ITrainingProgram basic1 = new BasicProgram(60);

        // Instructor updates the basic program
        List<TrainingDecorator> newExercises = new List<TrainingDecorator> 
        {
            new ConditionalDecorator(basic1, "high jumps"),
            new StrengthDecorator(basic1, "push ups")
        };
        instructor.UpdateProgram(basic1, newExercises);


        // Displaying instructor's specializations
        Console.WriteLine($"{instructor.Name}'s specializations:");
        foreach (var specialization in instructor.Specializations)
        {
            Console.WriteLine(specialization.ToString());
        }

        // Displaying additional services for trainees
        Console.WriteLine($"Additional services for {trainee1.Name}:");
        foreach (var addition in trainee1.additions)
        {
            Console.WriteLine(addition.Description);
        }
    }
}