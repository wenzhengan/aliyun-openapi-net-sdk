/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UpdateWorkFlowRequest : RpcAcsRequest<UpdateWorkFlowResponse>
    {
        public UpdateWorkFlowRequest()
            : base("vod", "2017-03-21", "UpdateWorkFlow")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string name;

		private string actionList;

		private string action;

		private long? ownerId;

		private string workFlowId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string ActionList
		{
			get
			{
				return actionList;
			}
			set	
			{
				actionList = value;
				DictionaryUtil.Add(QueryParameters, "ActionList", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string WorkFlowId
		{
			get
			{
				return workFlowId;
			}
			set	
			{
				workFlowId = value;
				DictionaryUtil.Add(QueryParameters, "WorkFlowId", value);
			}
		}

        public override UpdateWorkFlowResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateWorkFlowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}