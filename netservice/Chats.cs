using System.ServiceModel;

namespace netservice
{
    class Chats
    {
        /// <summary>
        /// Идентификатор чата
        /// </summary>
        public int IDChat { get; set; }

        /// <summary>
        /// Название чата
        /// </summary>
        public string NameChat { get; set; }

        /// <summary>
        /// Предостовление доступа к классу
        /// </summary>
        public OperationContext OperationContext { get; set; }
    }
}
