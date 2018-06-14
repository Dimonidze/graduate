using System.ServiceModel;

namespace netservice
{
    class Users
    {
        /// <summary>
        /// Логин, он же имя пользователя, он же идентификатор
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Предостовление доступа к классу
        /// </summary>
        public OperationContext OperationContext { get; set; }
    }
}
