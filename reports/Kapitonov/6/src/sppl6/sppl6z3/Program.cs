using sppl6z3;

Worker worker1 = new Worker("Bob", "IT", "o1", 100);
Worker worker2 = new Worker("Joe", "IT", "o2", 100);
Worker worker3 = new Worker("Mac", "IT", "o2", 100);
Worker.AddWorker(Worker.Director, worker1);
Worker.AddWorker(worker1,worker2);
Worker.AddWorker(worker1,worker3);
Worker.CalculateSalary(Worker.Director);