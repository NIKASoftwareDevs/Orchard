﻿/*
 * Licensed to Jasig under one or more contributor license
 * agreements. See the NOTICE file distributed with this work
 * for additional information regarding copyright ownership.
 * Jasig licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a
 * copy of the License at:
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using NGM.CasClient.Client.Validation.Schema.Saml20.Assertion;

#pragma warning disable 1591

namespace NGM.CasClient.Client.Validation.Schema.Saml20.Protocol.StatusResponse
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:protocol")]
    [XmlRoot("NameIDMappingResponse", Namespace="urn:oasis:names:tc:SAML:2.0:protocol", IsNullable=false)]
    public class NameIdMappingResponseType : StatusResponseType {
        [XmlElement("EncryptedID", typeof(EncryptedElementType), Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
        [XmlElement("NameID", typeof(NameIdType), Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
        public object Item
        {
            get;
            set;
        }
    }
}

#pragma warning restore 1591