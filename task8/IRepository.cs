using System;
using System.Collections.Generic;

public interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
    void Update(T item);
    void Delete(int id);
    List<T> GetAll();
}