namespace Mango.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMesage(BaseMessage message, string topicName);
    }
}