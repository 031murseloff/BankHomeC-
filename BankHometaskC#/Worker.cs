using CostomerException;

namespace BankHometaskC_;

public class Worker : BankWorker
{

    private DateTime? startDate;
    public DateTime? StartDate
    {
        get { return startDate; }
        set
        {
            if (value.HasValue && value.Value > DateTime.Now)
                throw new DateTimeException("StartDate cannot be in the future.");
            startDate = value;
        }
    }

    private DateTime? endDate;
    public DateTime? EndDate
    {
        get => endDate;
        set
        {
            if (value.HasValue && value < StartDate)
                throw new DateTimeException("EndDate cannot be earlier than StartDate.");
            endDate = value;
        }
    }

    public Worker(Guid guid, string name, string surname, int age, string position, double salary,DateTime startDate,DateTime endDate) : base(guid, name, surname, age, position, salary)
    {
        this.startDate = startDate;
        this.endDate = endDate;
        
    }


}
