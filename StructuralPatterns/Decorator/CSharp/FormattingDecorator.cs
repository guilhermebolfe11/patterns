namespace Decorator {
    public class FormattingDecorator : NotifierDecorator {
        public FormattingDecorator(INotifier wrapper) : base(wrapper) {}
        public override void Send(string message) {
            var formatted = $"*** {message.ToUpper()} ***";
            base.Send(formatted);
        }
    }
}

