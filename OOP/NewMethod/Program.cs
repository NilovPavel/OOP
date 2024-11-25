using NewMethod;

/************************* Первый пример *************************/
Base b = new Base();
// Вызов реализации Dispose в типе b: "Dispose класса Base"
b.Dispose();
// Вызов реализации Dispose в типе объекта b: "Dispose класса Base"
((IDisposable)b).Dispose();
/************************* Второй пример ************************/
Derived d = new Derived();
// Вызов реализации Dispose в типе d: "Dispose класса Derived"
d.Dispose();
// Вызов реализации Dispose в типе объекта d: "Dispose класса Derived"
((IDisposable)d).Dispose();
/************************* Третий пример *************************/
b = new Derived();
// Вызов реализации Dispose в типе b: "Dispose класса Base"
b.Dispose();
// Вызов реализации Dispose в типе объекта b: "Dispose класса Derived"
((IDisposable)b).Dispose();



/************************* Третий пример *************************/
IDisposable a = new DevDerived();
// Вызов реализации Dispose в типе b: "Dispose класса Base"
a.Dispose();

/************************* Третий пример *************************/
Derived c = new DevDerived();
// Вызов реализации Dispose в типе b: "Dispose класса Base"
c.Dispose();
