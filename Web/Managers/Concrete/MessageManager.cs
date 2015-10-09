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
                var response = client.GetAsync(string.Format("Message/RecievedMessages/?username={0}", username)).Result;
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
                throw;
            }
        }

        public IEnumerable<GetSentMessages_SP_Result> SentMessages(string username)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/SentMessages/?username={0}", username)).Result;
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
                throw;
            }
        }

        public IEnumerable<GetDeletedMessages_SP_Result> DeletedMessages(string username)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/DeletedMessages/?username={0}", username)).Result;
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
                throw;
            }
        }

        public User_Message GetUserMessageByMessageId(int id)
        {
            try
            {
                var response = client.GetAsync(string.Format("Message/GetMessage/{0}", id)).Result;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var json = response.Content.ReadAsStringAsync().Result;
                        var userMessage = JsonConvert.DeserializeObject<User_Message>(json);
                        return userMessage;
                    case HttpStatusCode.NotFound:
                        throw new MissingMethodException();
                    default:
                        throw new HttpException();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool SendMessage(User_Message userMessage)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(userMessage));
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
                throw;
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
                throw;
            }
        }
    }
}