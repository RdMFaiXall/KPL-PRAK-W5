// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class SimpleDataBase<T, Date>
{
    List<T> storedData;
    List<DateTime> inputDates;
    
    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T iniData)
    {
        this.storedData .Add(iniData);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi : " + storedData + ", yang disimpan pada waktu UTC: " + inputDates);
        }
    }
}