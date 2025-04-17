using System.Collections.Generic;
using System.Linq;

public class InMemoryRepository<T> : IRepository<T> where T : Student
{
    private List<T> Students = new List<T>();

    public void Add(T item)
    {
        Students.Add(item);
    }

    public T Get(int id)
    {
        return Students.FirstOrDefault(i => i.Id == id);
    }

    public void Update(T item)
    {
        var index = Students.FindIndex(i => i.Id == item.Id);
        if (index != -1)
        {
            Students[index] = item;
        }
    }

    public void Delete(int id)
    {
        var item = Students.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            Students.Remove(item);
        }
    }

    public List<T> GetAll()
    {
        return Students;
    }
}