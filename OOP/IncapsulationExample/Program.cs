using IncapsulationExample;

//Инкапсуляция необходимых данных и методов о пользователе в классе User
User user = new User("Nilov Pavel");

//Доступ к интерфейсу класса - в частности к публичному методу
string nameOfUser = user.GetName();

//Инкапсуляция в статичном классе
double result = Math.Sqrt(4);
