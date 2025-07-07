namespace Decorator {
    public class NotifierDecorator : INotifier {
        protected INotifier wrapper;
        public NotifierDecorator(INotifier wrapper) {
            this.wrapper = wrapper;
        }
        public virtual void Send(string message) {
            wrapper.Send(message);
        }
    }
}

