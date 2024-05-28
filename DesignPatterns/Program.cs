using DesignPatterns.Observer;
using DesignPatterns;
using Gym.Common;
using Gym.Decorator;
using Gym.Strategy;
using Gym.Strategy.Payments;



public class Program
{
    public static void Main(string[] args)
    {
        // Creating a gym (Singleton)
        Gym gym = Gym.Instance("FitLife Gym", "Downtown", "06:00 - 23:00");

        // Displaying gym information
        Console.WriteLine($"Gym: {gym.Name}");
        Console.WriteLine($"Location: {gym.Location}");
        Console.WriteLine($"Working Hours: {gym.WorkingHours}");
        Console.WriteLine($"Basic Program: {gym.BasicTrainingProgram.Execute()}");

        // Updating working hours
        gym.UpdateWorkingHours("07:00 - 22:00");
        Console.WriteLine($"Updated Working Hours: {gym.WorkingHours}");

        // Creating specializations
        var specializations = new List<Specialization>
        {
            new Specialization("Conditioning Training", "National Academy of Sports Medicine", new DateTime(2020, 5, 10)),
            new Specialization("Strength Training", "International Sports Sciences Association", new DateTime(2019, 8, 15))
        };

        // Creating an instructor and trainees (Observer)
        Instructor instructor = new Instructor("Peter", "Certified Fitness Instructor", 10, specializations, "peter@example.com", "123456789");

        // Creating trainees with different payment methods
        Trainee trainee1 = new Trainee("Ivan", 25, "ivan@gmail.com", "123456789", " Street 1", new DateTime(2024, 12, 31), new DateTime(2025, 01, 31));
        Trainee trainee2 = new Trainee("Maria", 30, "maria@gmail.com", "987654321", "Street 2", new DateTime(2024, 6, 30), new DateTime(2024, 7, 30));
        Trainee trainee3 = new Trainee("Peter", 28, "petar@gmail.com", "654321987", "Street 3", new DateTime(2023, 11, 30), new DateTime(2023, 12, 30));
        Trainee trainee4 = new Trainee("George", 32, "georgi@gmail.com", "789456123", "Street 4", new DateTime(2024, 5, 30), new DateTime(2024, 6, 30);

        // Creating different payment methods (Strategy)
        IPayment paymentMethod1 = new CreditCard("1234567890123456", "Ivan Ivanov", "12/24", "779");
        IPayment paymentMethod2 = new PayPal("maria@example.com");
        IPayment paymentMethod3 = new GooglePay("ivan.googlepay@example.com");
        IPayment paymentMethod4 = new Skrill("petar.skrill@example.com");

        if (paymentMethod1.IsPaymentMethodInfoValid())
        {
            trainee1.PaymentMethod = paymentMethod1;
            decimal amount = trainee1.CalculateAmountToPay();
            trainee1.MakePayment()
             instructor.AddTrainee(trainee1);
        }

        trainee1.PaymentMethod = paymentMethod1;
        trainee2.PaymentMethod = paymentMethod2;
        trainee3.PaymentMethod = paymentMethod3;
        trainee4.PaymentMethod = paymentMethod4;



        // Adding trainees to the instructor
        instructor.AddTrainee(trainee1);
        instructor.AddTrainee(trainee2);
        instructor.AddTrainee(trainee3);
        instructor.AddTrainee(trainee4);

        // Adding additional services (Decorator)
        //IAddition supplements = new Supplements(30, "Supplements");
        //IAddition consultation = new Consultation(50, "Consultation with Trainer");
        //IAddition personalTraining = new PersonalTraining(100, "Personal Training");
        //IAddition nutritionPlan = new NutritionPlan(40, "Nutrition Plan");

        //trainee1.AddAddition(supplements);
        //trainee1.AddAddition(personalTraining);
        //trainee2.AddAddition(consultation);
        //trainee2.AddAddition(nutritionPlan);
        //trainee3.AddAddition(consultation);
        //trainee4.AddAddition(personalTraining);

        // Instructor notifies trainees about program changes
        gym.NotifyTraineesAboutProgramChange(instructor);

        // Updating instructor's contact information
        instructor.UpdateContactInfoEmail("new_peter@example.com");

        // Renewing memberships and updating contact information for trainees
        trainee1.RenewMembership(new DateTime(2025, 12, 31));
        trainee2.UpdatePhoneNumber( "555555555");

        // Trainees making payments
        decimal amount1 = trainee1.CalculateAmountToPay(100);
        trainee1.MakePayment(amount1);

        decimal amount2 = trainee2.CalculateAmountToPay(50);
        trainee2.MakePayment(amount2);

        decimal amount3 = trainee3.CalculateAmountToPay(70);
        trainee3.MakePayment(amount3);

        decimal amount4 = trainee4.CalculateAmountToPay(150);
        trainee4.MakePayment(amount4);

        // Customizing the training program (Decorator)
        ITrainingProgram personalizedProgram1 = new StretchingDecorator(gym.BasicTrainingProgram);
        ITrainingProgram personalizedProgram2 = new HIITDecorator(new CardioProgram());

        TraineeWithProgram traineeWithProgram1 = new TraineeWithProgram("Ivan", personalizedProgram1, "Increase Flexibility", 12);
        TraineeWithProgram traineeWithProgram2 = new TraineeWithProgram("Maria", personalizedProgram2, "Burn Fat", 8);

        Console.WriteLine(traineeWithProgram1.PerformTraining());
        Console.WriteLine(traineeWithProgram2.PerformTraining());

        // Displaying instructor's specializations
        Console.WriteLine($"{instructor.Name}'s specializations:");
        foreach (var specialization in instructor.Specializations)
        {
            Console.WriteLine(specialization.ToString());
        }

        // Displaying additional services for trainees
        Console.WriteLine("Additional services for Ivan:");
        trainee1.ListAdditions();

        Console.WriteLine("Additional services for Maria:");
        trainee2.ListAdditions();
    }
}