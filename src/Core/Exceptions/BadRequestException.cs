using System.Runtime.Serialization;

namespace Volvo.Esw.Crisp.BuildDeliveryGateway.Application.Exceptions
{
    [Serializable]
    public class BadRequestException : Exception
    {
        public BadRequestException() { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, Exception inner) : base(message, inner) { }
        protected BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
