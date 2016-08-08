﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class userInfo_response
    {
        public UserInfo data;
        public List<object> notifications;
    }
}
