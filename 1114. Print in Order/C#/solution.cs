using System.Threading;

public class Foo {
    Semaphore SemA;
    Semaphore SemB;    
    
    public Foo() {
        // Initialize Semaphores as blocking by default.
        SemA = new Semaphore(0,1);
        SemB = new Semaphore(0,1);
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        
        // Unblock A
        SemA.Release();
    }

    public void Second(Action printSecond) {
        // Wait for A
        SemA.WaitOne();
        
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();

        // Unblock B
        SemB.Release();
    }

    public void Third(Action printThird) {       
        // Wait for B
        SemB.WaitOne();
        
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}