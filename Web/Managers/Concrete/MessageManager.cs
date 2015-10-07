using Entity;
using System;
using System.Collections.Generic;
using System.Net;

using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;

namespace Web.Managers
{
    public class MessageManager : BaseManager, IMessageManager
    {
        public IEnumerable<GetRecievedMessages_SP_Result> RecievedMessages(string username)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/RecievedMessages/{0}", username)).Result;
                switch(response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var json = response.Content.ReadAsStringAsync().Result;
                        var messages = JsonConvert.DeserializeObject<List<GetRecievedMessages_SP_Result>>(json);
                        return messages;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        throw new HttpException();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }

        public IEnumerable<GetSentMessages_SP_Result> SentMessages(string username)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/SentMessages/{0}", username)).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var json = response.Content.ReadAsStringAsync().Result;
                        var messages = JsonConvert.DeserializeObject<List<GetSentMessages_SP_Result>>(json);
                        return messages;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        throw new HttpException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }

        public IEnumerable<GetDeletedMessages_SP_Result> DeletedMessages(string username)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/DeletedMessages/{0}", username)).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var json = response.Content.ReadAsStringAsync().Result;
                        var messages = JsonConvert.DeserializeObject<List<GetDeletedMessages_SP_Result>>(json);
                        return messages;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        throw new HttpException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }

        public Message GetMessage(int id)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/GetMessage/{0}", id)).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var json = response.Content.ReadAsStringAsync().Result;
                        var message = JsonConvert.DeserializeObject<Message>(json);
                        return message;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        throw new HttpException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }

        public bool SendMessage(Message message)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(message));
                var response = client.PostAsync("Message/SendMessage", content).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        return true;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }

        public bool DeleteMessage(int id)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/DeleteMessage/{0}", id)).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        return true;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get messages from API");
            }
        }
    }
}