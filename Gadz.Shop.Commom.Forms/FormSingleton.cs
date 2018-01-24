namespace Gadz.Shop.Commom.Forms {
    public class FormSingleton<T> where T: class, new() {

        static T _instance;

        public static T Instance => _instance = _instance ?? new T();
    }
}
