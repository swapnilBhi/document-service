using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Kmd.Logic.DocumentService.Client
{
    [System.Serializable]
    public class DocumentsException : Exception
    {
        public string InnerMessage { get; }

        public DocumentsException()
        {
        }

        public DocumentsException(string message, string innerMessage)
           : base(message)
        {
            this.InnerMessage = innerMessage;
        }

        public DocumentsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DocumentsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public DocumentsException(string message)
            : base(message)
        {
        }

        public static string BadRequestMessage(IDictionary<string, IList<string>> badRequestMessages)
        {
            if (badRequestMessages == null)
            {
                return string.Empty;
            }

            StringBuilder messages = new StringBuilder();
            foreach (KeyValuePair<string, IList<string>> message in badRequestMessages)
            {
                messages.Append(message.Key).Append(" : ");
                var value = message.Value as List<string>;
                value.ForEach(a => messages.Append(a).AppendLine());
                messages.AppendLine();
            }

            return messages.ToString();
        }
    }
}