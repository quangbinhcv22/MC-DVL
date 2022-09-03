namespace JSON.Entity.Component
{
    /// <summary>
    ///  Lifecycle of attached game object.
    /// </summary>
    public interface ILc
    {
        public interface Create
        {
            void OnCreate();
        }

        public interface Enable
        {
            void OnEnable();
        }

        public interface Disable
        {
            void OnDisable();
        }

        public interface OnDestroy
        {
            void OnDestroy();
        }

        public interface Update
        {
            void OnUpdate();
        }

        public interface LateUpdate
        {
            void OnLateUpdate();
        }

        public interface FixedUpdate
        {
            void OnFixedUpdate();
        }
    }
}