/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;

namespace fortiss.Di
{
    #region SkillState Class
    #if (!OPCUA_EXCLUDE_SkillState)
    /// <summary>
    /// Stores an instance of the SkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillState : ProgramStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.SkillType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FinalResultData != null)
            {
                FinalResultData.Initialize(context, FinalResultData_InitializationString);
            }
        }

        #region Initialization String
        private const string FinalResultData_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAoBAAAAAAAPAAAARmluYWxSZXN1bHREYXRhAQLcOgAvADrcOgAA/////wAA" +
           "AAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgARAAAAU2tpbGxUeXBlSW5zdGFuY2UBAro6AQK6Oro6AAD/////" +
           "GgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQK7OgAvAQDICrs6AAAAFf////8BAf////8CAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAECvDoALgBEvDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51" +
           "bWJlcgECvjoALgBEvjoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9u" +
           "AQLAOgAvAQDPCsA6AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAECwToALgBEwToAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgECwzoALgBEwzoAAAAH/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQLEOgAuAETEOgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABEZWxldGFibGUBAsk6AC4ARMk6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAoAAABBdXRvRGVsZXRlAQLKOgAuAETKOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVj" +
           "eWNsZUNvdW50AQLLOgAuAETLOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFu" +
           "Y2VDb3VudAECzToALgBEzToAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAAAEZpbmFsUmVzdWx0" +
           "RGF0YQEC3DoALwA63DoAAP////8AAAAABGCACgEAAAAAAAYAAABIYWx0ZWQBAt06AC8BAAMJ3ToAAAQA" +
           "AAAAMwEBAuU6ADQBAQLpOgA0AQEC8ToANAEBAvU6AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIB" +
           "At46AC4ARN46AAAHCwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABQAAAFJlYWR5AQLfOgAvAQAD" +
           "Cd86AAAFAAAAADQBAQLlOgAzAQEC5zoANAEBAus6ADQBAQLzOgAzAQEC9ToBAAAAFWCpCgIAAAAAAAsA" +
           "AABTdGF0ZU51bWJlcgEC4DoALgBE4DoAAAcMAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAHAAAA" +
           "UnVubmluZwEC4ToALwEAAwnhOgAABQAAAAA0AQEC5zoAMwEBAuk6ADMBAQLrOgAzAQEC7ToANAEBAu86" +
           "AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAuI6AC4AROI6AAAHDQAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAEC4zoALwEAAwnjOgAABAAAAAA0AQEC7ToAMwEBAu86ADMB" +
           "AQLxOgAzAQEC8zoBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEC5DoALgBE5DoAAAcOAAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFkeQEC5ToALwEABgnlOgAABAAAAAAz" +
           "AAEC3ToANAABAt86ADUAAQL7OgA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
           "AQLmOgAuAETmOgAABwEAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA4AAABSZWFkeVRvUnVubmlu" +
           "ZwEC5zoALwEABgnnOgAABAAAAAAzAAEC3zoANAABAuE6ADUAAQL3OgA2AAEASgkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQLoOgAuAEToOgAABwIAAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAAAAA8AAABSdW5uaW5nVG9IYWx0ZWQBAuk6AC8BAAYJ6ToAAAQAAAAAMwABAuE6ADQAAQLdOgA1AAEC" +
           "+joANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEC6joALgBE6joAAAcDAAAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmluZ1RvUmVhZHkBAus6AC8BAAYJ6zoAAAMA" +
           "AAAAMwABAuE6ADQAAQLfOgA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQLs" +
           "OgAuAETsOgAABwQAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABSdW5uaW5nVG9TdXNwZW5k" +
           "ZWQBAu06AC8BAAYJ7ToAAAQAAAAAMwABAuE6ADQAAQLjOgA1AAEC+DoANgABAEoJAQAAABVgqQoCAAAA" +
           "AAAQAAAAVHJhbnNpdGlvbk51bWJlcgEC7joALgBE7joAAAcFAAAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAAASAAAAU3VzcGVuZGVkVG9SdW5uaW5nAQLvOgAvAQAGCe86AAAEAAAAADMAAQLjOgA0AAEC4ToA" +
           "NQABAvk6ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAvA6AC4ARPA6AAAH" +
           "BgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEQAAAFN1c3BlbmRlZFRvSGFsdGVkAQLxOgAvAQAG" +
           "CfE6AAAEAAAAADMAAQLjOgA0AAEC3ToANQABAvo6ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAvI6AC4ARPI6AAAHBwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEAAAAFN1" +
           "c3BlbmRlZFRvUmVhZHkBAvM6AC8BAAYJ8zoAAAMAAAAAMwABAuM6ADQAAQLfOgA2AAEASgkBAAAAFWCp" +
           "CgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQL0OgAuAET0OgAABwgAAAAAB/////8BAf////8AAAAA" +
           "BGCACgEAAAAAAA0AAABSZWFkeVRvSGFsdGVkAQL1OgAvAQAGCfU6AAAEAAAAADMAAQLfOgA0AAEC3ToA" +
           "NQABAvo6ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAvY6AC4ARPY6AAAH" +
           "CQAAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQL3OgAvAQB6Cfc6AAABAQEAAAAA" +
           "NQEBAuc6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEC+DoALwEAewn4OgAAAQEBAAAAADUBAQLtOgAA" +
           "AAAEYYIKBAAAAAAABgAAAFJlc3VtZQEC+ToALwEAfAn5OgAAAQEBAAAAADUBAQLvOgAAAAAEYYIKBAAA" +
           "AAAABAAAAEhhbHQBAvo6AC8BAH0J+joAAAEBAwAAAAA1AQEC6ToANQEBAvE6ADUBAQL1OgAAAAAEYYIK" +
           "BAAAAAAABQAAAFJlc2V0AQL7OgAvAQB+Cfs6AAABAQEAAAAANQEBAuU6AAAAADVgiQoCAAAAAgAEAAAA" +
           "TmFtZQEC/DoDAAAAABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAET8OgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public MethodState Halt
        {
            get
            {
                return m_haltMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public MethodState Resume
        {
            get
            {
                return m_resumeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }

        /// <remarks />
        public MethodState Suspend
        {
            get
            {
                return m_suspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendMethod = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_haltMethod != null)
            {
                children.Add(m_haltMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            if (m_suspendMethod != null)
            {
                children.Add(m_suspendMethod);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case fortiss.Di.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Opc.Ua.BrowseNames.Halt:
                {
                    if (createOrReplace)
                    {
                        if (Halt == null)
                        {
                            if (replacement == null)
                            {
                                Halt = new MethodState(this);
                            }
                            else
                            {
                                Halt = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Halt;
                    break;
                }

                case Opc.Ua.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }

                case Opc.Ua.BrowseNames.Suspend:
                {
                    if (createOrReplace)
                    {
                        if (Suspend == null)
                        {
                            if (replacement == null)
                            {
                                Suspend = new MethodState(this);
                            }
                            else
                            {
                                Suspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Suspend;
                    break;
                }

                case Opc.Ua.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_name;
        private MethodState m_haltMethod;
        private MethodState m_resetMethod;
        private MethodState m_resumeMethod;
        private MethodState m_suspendMethod;
        private MethodState m_startMethod;
        #endregion
    }
    #endif
    #endregion

    #region GripperSkillState Class
    #if (!OPCUA_EXCLUDE_GripperSkillState)
    /// <summary>
    /// Stores an instance of the GripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripperSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.GripperSkillType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgAYAAAAR3JpcHBlclNraWxsVHlwZUluc3RhbmNlAQL9OgEC/Tr9" +
           "OgAA/////xkAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEC/joALwEAyAr+OgAAABX/////AQH/" +
           "////AgAAABVgiQoCAAAAAAACAAAASWQBAv86AC4ARP86AAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAYAAABOdW1iZXIBAgE7AC4ARAE7AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJh" +
           "bnNpdGlvbgECAzsALwEAzwoDOwAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAgQ7AC4A" +
           "RAQ7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAgY7AC4ARAY7AAAAB/////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQECBzsALgBEBzsAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQIMOwAuAEQMOwAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQECDTsALgBEDTsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAFJlY3ljbGVDb3VudAECDjsALgBEDjsAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1h" +
           "eEluc3RhbmNlQ291bnQBAhA7AC4ARBA7AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAYAAABIYWx0" +
           "ZWQBAiA7AC8BAAMJIDsAAAQAAAAAMwEBAig7ADQBAQIsOwA0AQECNDsANAEBAjg7AQAAABVgqQoCAAAA" +
           "AAALAAAAU3RhdGVOdW1iZXIBAiE7AC4ARCE7AAAHCwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAA" +
           "BQAAAFJlYWR5AQIiOwAvAQADCSI7AAAFAAAAADQBAQIoOwAzAQECKjsANAEBAi47ADQBAQI2OwAzAQEC" +
           "ODsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgECIzsALgBEIzsAAAcMAAAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAAAHAAAAUnVubmluZwECJDsALwEAAwkkOwAABQAAAAA0AQECKjsAMwEBAiw7ADMB" +
           "AQIuOwAzAQECMDsANAEBAjI7AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAiU7AC4ARCU7AAAH" +
           "DQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAECJjsALwEAAwkmOwAABAAA" +
           "AAA0AQECMDsAMwEBAjI7ADMBAQI0OwAzAQECNjsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEC" +
           "JzsALgBEJzsAAAcOAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFkeQEC" +
           "KDsALwEABgkoOwAABAAAAAAzAAECIDsANAABAiI7ADUAAQI+OwA2AAEASgkBAAAAFWCpCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQIpOwAuAEQpOwAABwEAAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA4AAABSZWFkeVRvUnVubmluZwECKjsALwEABgkqOwAABAAAAAAzAAECIjsANAABAiQ7ADUAAQI6OwA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQIrOwAuAEQrOwAABwIAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAAAAA8AAABSdW5uaW5nVG9IYWx0ZWQBAiw7AC8BAAYJLDsAAAQAAAAA" +
           "MwABAiQ7ADQAAQIgOwA1AAECPTsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgECLTsALgBELTsAAAcDAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmluZ1RvUmVh" +
           "ZHkBAi47AC8BAAYJLjsAAAMAAAAAMwABAiQ7ADQAAQIiOwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQIvOwAuAEQvOwAABwQAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIA" +
           "AABSdW5uaW5nVG9TdXNwZW5kZWQBAjA7AC8BAAYJMDsAAAQAAAAAMwABAiQ7ADQAAQImOwA1AAECOzsA" +
           "NgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgECMTsALgBEMTsAAAcFAAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAASAAAAU3VzcGVuZGVkVG9SdW5uaW5nAQIyOwAvAQAGCTI7AAAE" +
           "AAAAADMAAQImOwA0AAECJDsANQABAjw7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAjM7AC4ARDM7AAAHBgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEQAAAFN1c3BlbmRl" +
           "ZFRvSGFsdGVkAQI0OwAvAQAGCTQ7AAAEAAAAADMAAQImOwA0AAECIDsANQABAj07ADYAAQBKCQEAAAAV" +
           "YKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAjU7AC4ARDU7AAAHBwAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAjY7AC8BAAYJNjsAAAMAAAAAMwABAiY7ADQA" +
           "AQIiOwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQI3OwAuAEQ3OwAABwgA" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABSZWFkeVRvSGFsdGVkAQI4OwAvAQAGCTg7AAAE" +
           "AAAAADMAAQIiOwA0AAECIDsANQABAj07ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAjk7AC4ARDk7AAAHCQAAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQI6" +
           "OwAvAQB6CTo7AAABAQEAAAAANQEBAio7AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAECOzsALwEAewk7" +
           "OwAAAQEBAAAAADUBAQIwOwAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQECPDsALwEAfAk8OwAAAQEBAAAA" +
           "ADUBAQIyOwAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAj07AC8BAH0JPTsAAAEBAwAAAAA1AQECLDsANQEB" +
           "AjQ7ADUBAQI4OwAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQI+OwAvAQB+CT47AAABAQEAAAAANQEBAig7" +
           "AAAAADVgiQoCAAAAAgAEAAAATmFtZQECPzsDAAAAABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAEQ/OwAA" +
           "AAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region GraspGripperSkillState Class
    #if (!OPCUA_EXCLUDE_GraspGripperSkillState)
    /// <summary>
    /// Stores an instance of the GraspGripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GraspGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GraspGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.GraspGripperSkillType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQKDOwAvADqDOwAA/////wEAAAA1" +
           "YIkKAgAAAAIABQAAAEZvcmNlAQKEOwMAAAAAEQAAAFRoZSBncmlwcGVyIGZvcmNlAC8BAEAJhDsAAAAL" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAog7AC4ARIg7AAABAHQD/////wEB////" +
           "/wAAAAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgAdAAAAR3Jhc3BHcmlwcGVyU2tpbGxUeXBlSW5zdGFuY2UBAkA7" +
           "AQJAO0A7AAD/////GgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQJBOwAvAQDICkE7AAAAFf//" +
           "//8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAECQjsALgBEQjsAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAE51bWJlcgECRDsALgBERDsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExh" +
           "c3RUcmFuc2l0aW9uAQJGOwAvAQDPCkY7AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEC" +
           "RzsALgBERzsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgECSTsALgBESTsAAAAH" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQJKOwAuAERKOwAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAk87AC4ARE87AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQJQOwAuAERQOwAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAAUmVjeWNsZUNvdW50AQJROwAuAERROwAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAATWF4SW5zdGFuY2VDb3VudAECUzsALgBEUzsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABgAA" +
           "AEhhbHRlZAECYzsALwEAAwljOwAABAAAAAAzAQECazsANAEBAm87ADQBAQJ3OwA0AQECezsBAAAAFWCp" +
           "CgIAAAAAAAsAAABTdGF0ZU51bWJlcgECZDsALgBEZDsAAAcLAAAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAAAFAAAAUmVhZHkBAmU7AC8BAAMJZTsAAAUAAAAANAEBAms7ADMBAQJtOwA0AQECcTsANAEBAnk7" +
           "ADMBAQJ7OwEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQJmOwAuAERmOwAABwwAAAAAB/////8B" +
           "Af////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQJnOwAvAQADCWc7AAAFAAAAADQBAQJtOwAzAQEC" +
           "bzsAMwEBAnE7ADMBAQJzOwA0AQECdTsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgECaDsALgBE" +
           "aDsAAAcNAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAJAAAAU3VzcGVuZGVkAQJpOwAvAQADCWk7" +
           "AAAEAAAAADQBAQJzOwAzAQECdTsAMwEBAnc7ADMBAQJ5OwEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVt" +
           "YmVyAQJqOwAuAERqOwAABw4AAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABIYWx0ZWRUb1Jl" +
           "YWR5AQJrOwAvAQAGCWs7AAAEAAAAADMAAQJjOwA0AAECZTsANQABAoE7ADYAAQBKCQEAAAAVYKkKAgAA" +
           "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAmw7AC4ARGw7AAAHAQAAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQJtOwAvAQAGCW07AAAEAAAAADMAAQJlOwA0AAECZzsANQAB" +
           "An07ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAm47AC4ARG47AAAHAgAA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAAAFJ1bm5pbmdUb0hhbHRlZAECbzsALwEABglvOwAA" +
           "BAAAAAAzAAECZzsANAABAmM7ADUAAQKAOwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9u" +
           "TnVtYmVyAQJwOwAuAERwOwAABwMAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA4AAABSdW5uaW5n" +
           "VG9SZWFkeQECcTsALwEABglxOwAAAwAAAAAzAAECZzsANAABAmU7ADYAAQBKCQEAAAAVYKkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBAnI7AC4ARHI7AAAHBAAAAAAH/////wEB/////wAAAAAEYIAKAQAA" +
           "AAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAECczsALwEABglzOwAABAAAAAAzAAECZzsANAABAmk7ADUA" +
           "AQJ+OwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQJ0OwAuAER0OwAABwUA" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5kZWRUb1J1bm5pbmcBAnU7AC8BAAYJ" +
           "dTsAAAQAAAAAMwABAmk7ADQAAQJnOwA1AAECfzsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNp" +
           "dGlvbk51bWJlcgECdjsALgBEdjsAAAcGAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAARAAAAU3Vz" +
           "cGVuZGVkVG9IYWx0ZWQBAnc7AC8BAAYJdzsAAAQAAAAAMwABAmk7ADQAAQJjOwA1AAECgDsANgABAEoJ" +
           "AQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgECeDsALgBEeDsAAAcHAAAAAAf/////AQH/" +
           "////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVuZGVkVG9SZWFkeQECeTsALwEABgl5OwAAAwAAAAAzAAEC" +
           "aTsANAABAmU7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAno7AC4ARHo7" +
           "AAAHCAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAFJlYWR5VG9IYWx0ZWQBAns7AC8BAAYJ" +
           "ezsAAAQAAAAAMwABAmU7ADQAAQJjOwA1AAECgDsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNp" +
           "dGlvbk51bWJlcgECfDsALgBEfDsAAAcJAAAAAAf/////AQH/////AAAAAARhggoEAAAAAAAFAAAAU3Rh" +
           "cnQBAn07AC8BAHoJfTsAAAEBAQAAAAA1AQECbTsAAAAABGGCCgQAAAAAAAcAAABTdXNwZW5kAQJ+OwAv" +
           "AQB7CX47AAABAQEAAAAANQEBAnM7AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQJ/OwAvAQB8CX87AAAB" +
           "AQEAAAAANQEBAnU7AAAAAARhggoEAAAAAAAEAAAASGFsdAECgDsALwEAfQmAOwAAAQEDAAAAADUBAQJv" +
           "OwA1AQECdzsANQEBAns7AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAoE7AC8BAH4JgTsAAAEBAQAAAAA1" +
           "AQECazsAAAAANWCJCgIAAAACAAQAAABOYW1lAQKCOwMAAAAAEQAAAE5hbWUgb2YgdGhlIHNraWxsAC4A" +
           "RII7AAAADP////8BAf////8AAAAABGCACgEAAAABAAwAAABQYXJhbWV0ZXJTZXQBAoM7AC8AOoM7AAD/" +
           "////AQAAADVgiQoCAAAAAgAFAAAARm9yY2UBAoQ7AwAAAAARAAAAVGhlIGdyaXBwZXIgZm9yY2UALwEA" +
           "QAmEOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQECiDsALgBEiDsAAAEAdAP/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ReleaseGripperSkillState Class
    #if (!OPCUA_EXCLUDE_ReleaseGripperSkillState)
    /// <summary>
    /// Stores an instance of the ReleaseGripperSkill ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReleaseGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReleaseGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.ReleaseGripperSkill, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQLNOwAvADrNOwAA/////wEAAAA1" +
           "YIkKAgAAAAIABQAAAEZvcmNlAQLOOwMAAAAAEQAAAFRoZSBncmlwcGVyIGZvcmNlAC8BAEAJzjsAAAAL" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAtI7AC4ARNI7AAABAHQD/////wEB////" +
           "/wAAAAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgAbAAAAUmVsZWFzZUdyaXBwZXJTa2lsbEluc3RhbmNlAQKKOwEC" +
           "ijuKOwAA/////xoAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQECizsALwEAyAqLOwAAABX/////" +
           "AQH/////AgAAABVgiQoCAAAAAAACAAAASWQBAow7AC4ARIw7AAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAYAAABOdW1iZXIBAo47AC4ARI47AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0" +
           "VHJhbnNpdGlvbgECkDsALwEAzwqQOwAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBApE7" +
           "AC4ARJE7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBApM7AC4ARJM7AAAAB///" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEClDsALgBElDsAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQKZOwAuAESZOwAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQECmjsALgBEmjsAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAFJlY3ljbGVDb3VudAECmzsALgBEmzsAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AE1heEluc3RhbmNlQ291bnQBAp07AC4ARJ07AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAYAAABI" +
           "YWx0ZWQBAq07AC8BAAMJrTsAAAQAAAAAMwEBArU7ADQBAQK5OwA0AQECwTsANAEBAsU7AQAAABVgqQoC" +
           "AAAAAAALAAAAU3RhdGVOdW1iZXIBAq47AC4ARK47AAAHCwAAAAAH/////wEB/////wAAAAAEYIAKAQAA" +
           "AAAABQAAAFJlYWR5AQKvOwAvAQADCa87AAAFAAAAADQBAQK1OwAzAQECtzsANAEBArs7ADQBAQLDOwAz" +
           "AQECxTsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgECsDsALgBEsDsAAAcMAAAAAAf/////AQH/" +
           "////AAAAAARggAoBAAAAAAAHAAAAUnVubmluZwECsTsALwEAAwmxOwAABQAAAAA0AQECtzsAMwEBArk7" +
           "ADMBAQK7OwAzAQECvTsANAEBAr87AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBArI7AC4ARLI7" +
           "AAAHDQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAECszsALwEAAwmzOwAA" +
           "BAAAAAA0AQECvTsAMwEBAr87ADMBAQLBOwAzAQECwzsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgECtDsALgBEtDsAAAcOAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFk" +
           "eQECtTsALwEABgm1OwAABAAAAAAzAAECrTsANAABAq87ADUAAQLLOwA2AAEASgkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQK2OwAuAES2OwAABwEAAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAAAAA4AAABSZWFkeVRvUnVubmluZwECtzsALwEABgm3OwAABAAAAAAzAAECrzsANAABArE7ADUAAQLH" +
           "OwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQK4OwAuAES4OwAABwIAAAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAAAAA8AAABSdW5uaW5nVG9IYWx0ZWQBArk7AC8BAAYJuTsAAAQA" +
           "AAAAMwABArE7ADQAAQKtOwA1AAECyjsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
           "bWJlcgECujsALgBEujsAAAcDAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmluZ1Rv" +
           "UmVhZHkBArs7AC8BAAYJuzsAAAMAAAAAMwABArE7ADQAAQKvOwA2AAEASgkBAAAAFWCpCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQK8OwAuAES8OwAABwQAAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "ABIAAABSdW5uaW5nVG9TdXNwZW5kZWQBAr07AC8BAAYJvTsAAAQAAAAAMwABArE7ADQAAQKzOwA1AAEC" +
           "yDsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgECvjsALgBEvjsAAAcFAAAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAU3VzcGVuZGVkVG9SdW5uaW5nAQK/OwAvAQAGCb87" +
           "AAAEAAAAADMAAQKzOwA0AAECsTsANQABAsk7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRp" +
           "b25OdW1iZXIBAsA7AC4ARMA7AAAHBgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEQAAAFN1c3Bl" +
           "bmRlZFRvSGFsdGVkAQLBOwAvAQAGCcE7AAAEAAAAADMAAQKzOwA0AAECrTsANQABAso7ADYAAQBKCQEA" +
           "AAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAsI7AC4ARMI7AAAHBwAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAAAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAsM7AC8BAAYJwzsAAAMAAAAAMwABArM7" +
           "ADQAAQKvOwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQLEOwAuAETEOwAA" +
           "BwgAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABSZWFkeVRvSGFsdGVkAQLFOwAvAQAGCcU7" +
           "AAAEAAAAADMAAQKvOwA0AAECrTsANQABAso7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRp" +
           "b25OdW1iZXIBAsY7AC4ARMY7AAAHCQAAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0" +
           "AQLHOwAvAQB6Ccc7AAABAQEAAAAANQEBArc7AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAECyDsALwEA" +
           "ewnIOwAAAQEBAAAAADUBAQK9OwAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQECyTsALwEAfAnJOwAAAQEB" +
           "AAAAADUBAQK/OwAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAso7AC8BAH0JyjsAAAEBAwAAAAA1AQECuTsA" +
           "NQEBAsE7ADUBAQLFOwAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQLLOwAvAQB+Ccs7AAABAQEAAAAANQEB" +
           "ArU7AAAAADVgiQoCAAAAAgAEAAAATmFtZQECzDsDAAAAABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAETM" +
           "OwAAAAz/////AQH/////AAAAAARggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQLNOwAvADrNOwAA////" +
           "/wEAAAA1YIkKAgAAAAIABQAAAEZvcmNlAQLOOwMAAAAAEQAAAFRoZSBncmlwcGVyIGZvcmNlAC8BAEAJ" +
           "zjsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAtI7AC4ARNI7AAABAHQD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region MoveGripperSkillState Class
    #if (!OPCUA_EXCLUDE_MoveGripperSkillState)
    /// <summary>
    /// Stores an instance of the MoveGripperSkill ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.MoveGripperSkill, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgAYAAAATW92ZUdyaXBwZXJTa2lsbEluc3RhbmNlAQLUOwEC1DvU" +
           "OwAA/////xoAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEC1TsALwEAyArVOwAAABX/////AQH/" +
           "////AgAAABVgiQoCAAAAAAACAAAASWQBAtY7AC4ARNY7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAYAAABOdW1iZXIBAtg7AC4ARNg7AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJh" +
           "bnNpdGlvbgEC2jsALwEAzwraOwAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAts7AC4A" +
           "RNs7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAt07AC4ARN07AAAAB/////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEC3jsALgBE3jsAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQLjOwAuAETjOwAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQEC5DsALgBE5DsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAFJlY3ljbGVDb3VudAEC5TsALgBE5TsAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1h" +
           "eEluc3RhbmNlQ291bnQBAuc7AC4AROc7AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAYAAABIYWx0" +
           "ZWQBAvc7AC8BAAMJ9zsAAAQAAAAAMwEBAv87ADQBAQIDPAA0AQECCzwANAEBAg88AQAAABVgqQoCAAAA" +
           "AAALAAAAU3RhdGVOdW1iZXIBAvg7AC4ARPg7AAAHCwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAA" +
           "BQAAAFJlYWR5AQL5OwAvAQADCfk7AAAFAAAAADQBAQL/OwAzAQECATwANAEBAgU8ADQBAQINPAAzAQEC" +
           "DzwBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEC+jsALgBE+jsAAAcMAAAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAAAHAAAAUnVubmluZwEC+zsALwEAAwn7OwAABQAAAAA0AQECATwAMwEBAgM8ADMB" +
           "AQIFPAAzAQECBzwANAEBAgk8AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAvw7AC4ARPw7AAAH" +
           "DQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAEC/TsALwEAAwn9OwAABAAA" +
           "AAA0AQECBzwAMwEBAgk8ADMBAQILPAAzAQECDTwBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEC" +
           "/jsALgBE/jsAAAcOAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFkeQEC" +
           "/zsALwEABgn/OwAABAAAAAAzAAEC9zsANAABAvk7ADUAAQIVPAA2AAEASgkBAAAAFWCpCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQIAPAAuAEQAPAAABwEAAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA4AAABSZWFkeVRvUnVubmluZwECATwALwEABgkBPAAABAAAAAAzAAEC+TsANAABAvs7ADUAAQIRPAA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQICPAAuAEQCPAAABwIAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAAAAA8AAABSdW5uaW5nVG9IYWx0ZWQBAgM8AC8BAAYJAzwAAAQAAAAA" +
           "MwABAvs7ADQAAQL3OwA1AAECFDwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgECBDwALgBEBDwAAAcDAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmluZ1RvUmVh" +
           "ZHkBAgU8AC8BAAYJBTwAAAMAAAAAMwABAvs7ADQAAQL5OwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQIGPAAuAEQGPAAABwQAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIA" +
           "AABSdW5uaW5nVG9TdXNwZW5kZWQBAgc8AC8BAAYJBzwAAAQAAAAAMwABAvs7ADQAAQL9OwA1AAECEjwA" +
           "NgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgECCDwALgBECDwAAAcFAAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAASAAAAU3VzcGVuZGVkVG9SdW5uaW5nAQIJPAAvAQAGCQk8AAAE" +
           "AAAAADMAAQL9OwA0AAEC+zsANQABAhM8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAgo8AC4ARAo8AAAHBgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEQAAAFN1c3BlbmRl" +
           "ZFRvSGFsdGVkAQILPAAvAQAGCQs8AAAEAAAAADMAAQL9OwA0AAEC9zsANQABAhQ8ADYAAQBKCQEAAAAV" +
           "YKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAgw8AC4ARAw8AAAHBwAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAg08AC8BAAYJDTwAAAMAAAAAMwABAv07ADQA" +
           "AQL5OwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQIOPAAuAEQOPAAABwgA" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABSZWFkeVRvSGFsdGVkAQIPPAAvAQAGCQ88AAAE" +
           "AAAAADMAAQL5OwA0AAEC9zsANQABAhQ8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAhA8AC4ARBA8AAAHCQAAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQIR" +
           "PAAvAQB6CRE8AAABAQEAAAAANQEBAgE8AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAECEjwALwEAewkS" +
           "PAAAAQEBAAAAADUBAQIHPAAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQECEzwALwEAfAkTPAAAAQEBAAAA" +
           "ADUBAQIJPAAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAhQ8AC8BAH0JFDwAAAEBAwAAAAA1AQECAzwANQEB" +
           "Ags8ADUBAQIPPAAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQIVPAAvAQB+CRU8AAABAQEAAAAANQEBAv87" +
           "AAAAADVgiQoCAAAAAgAEAAAATmFtZQECFjwDAAAAABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAEQWPAAA" +
           "AAz/////AQH/////AAAAAARggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQIXPAAvADoXPAAA/////wIA" +
           "AAA1YIkKAgAAAAIABQAAAFdpZHRoAQIYPAMAAAAAEQAAAFRoZSBncmlwcGVyIHdpZHRoAC8BAEAJGDwA" +
           "AAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAhw8AC4ARBw8AAABAHQD/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIABQAAAEZvcmNlAQIePAMAAAAAEQAAAFRoZSBncmlwcGVyIGZvcmNlAC8B" +
           "AEAJHjwAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAiI8AC4ARCI8AAABAHQD" +
           "/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ISkillControllerState Class
    #if (!OPCUA_EXCLUDE_ISkillControllerState)
    /// <summary>
    /// Stores an instance of the ISkillControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISkillControllerState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISkillControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.ISkillControllerType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Name != null)
            {
                Name.Initialize(context, Name_InitializationString);
            }
        }

        #region Initialization String
        private const string Name_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////xVgiQoCAAAAAgAEAAAATmFtZQECJTwALgBEJTwAAAAV/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////4RggAIBAAAAAgAcAAAASVNraWxsQ29udHJvbGxlclR5cGVJbnN0YW5jZQECJDwB" +
           "AiQ8JDwAAAH/////AgAAABVgiQoCAAAAAgAEAAAATmFtZQECJTwALgBEJTwAAAAV/////wEB/////wAA" +
           "AAAkYIAKAQAAAAIABgAAAFNraWxscwECJjwDAAAAACQAAABDb250YWlucyB0aGUgc2tpbGxzIG9mIHRo" +
           "ZSBDb21wb25lbnQALwA6JjwAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<LocalizedText> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public BaseObjectState Skills
        {
            get
            {
                return m_skills;
            }

            set
            {
                if (!Object.ReferenceEquals(m_skills, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_skills = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_skills != null)
            {
                children.Add(m_skills);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case fortiss.Di.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Name = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case fortiss.Di.BrowseNames.Skills:
                {
                    if (createOrReplace)
                    {
                        if (Skills == null)
                        {
                            if (replacement == null)
                            {
                                Skills = new BaseObjectState(this);
                            }
                            else
                            {
                                Skills = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Skills;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocalizedText> m_name;
        private BaseObjectState m_skills;
        #endregion
    }
    #endif
    #endregion

    #region GripperDeviceControllerState Class
    #if (!OPCUA_EXCLUDE_GripperDeviceControllerState)
    /// <summary>
    /// Stores an instance of the GripperDeviceControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripperDeviceControllerState : ComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripperDeviceControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.GripperDeviceControllerType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////4RggAIBAAAAAgAjAAAAR3JpcHBlckRldmljZUNvbnRyb2xsZXJUeXBlSW5zdGFu" +
           "Y2UBAmc8AQJnPGc8AAABAQAAAAEAw0QAAQIkPAEAAAAkYIAKAQAAAAIABgAAAFNraWxscwECizwDAAAA" +
           "AC4AAABDb250YWlucyB0aGUgc2tpbGxzIG9mIHRoZSBncmlwcGVyIGNvbnRyb2xsZXIuAC8AOos8AAD/" +
           "////AwAAAARggAoBAAAAAgAQAAAATW92ZUdyaXBwZXJTa2lsbAECjDwALwECujqMPAAA/////xkAAAAV" +
           "YIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQECjTwALwEAyAqNPAAAABX/////AQH/////AgAAABVgiQoC" +
           "AAAAAAACAAAASWQBAo48AC4ARI48AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIB" +
           "ApA8AC4ARJA8AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlvbgECkjwA" +
           "LwEAzwqSPAAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBApM8AC4ARJM8AAAAEf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBApU8AC4ARJU8AAAAB/////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQECljwALgBEljwAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAJAAAARGVsZXRhYmxlAQKaPAAuAESaPAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAA" +
           "QXV0b0RlbGV0ZQECmzwALgBEmzwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJlY3ljbGVD" +
           "b3VudAECnDwALgBEnDwAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIABAAAAE5hbWUBAqs8AwAAAAAR" +
           "AAAATmFtZSBvZiB0aGUgc2tpbGwALgBEqzwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1h" +
           "eEluc3RhbmNlQ291bnQBAqw8AC4ARKw8AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAYAAABIYWx0" +
           "ZWQBAq08AC8BAAMJrTwAAP////8BAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgECrjwALgBErjwA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAEhhbHRlZFRvUmVhZHkBAq88AC8BAAYJrzwAAP//" +
           "//8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQKwPAAuAESwPAAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBArE8AC8BAAMJsTwAAP////8BAAAAFWCJCgIAAAAAAAsAAABT" +
           "dGF0ZU51bWJlcgECsjwALgBEsjwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAFJlYWR5VG9I" +
           "YWx0ZWQBArM8AC8BAAYJszwAAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQK0" +
           "PAAuAES0PAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUmVhZHlUb1J1bm5pbmcBArU8AC8B" +
           "AAYJtTwAAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQK2PAAuAES2PAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAAHAAAAUnVubmluZwECtzwALwEAAwm3PAAA/////wEAAAAVYIkK" +
           "AgAAAAAACwAAAFN0YXRlTnVtYmVyAQK4PAAuAES4PAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAP" +
           "AAAAUnVubmluZ1RvSGFsdGVkAQK5PAAvAQAGCbk8AAD/////AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNp" +
           "dGlvbk51bWJlcgECujwALgBEujwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADgAAAFJ1bm5pbmdU" +
           "b1JlYWR5AQK7PAAvAQAGCbs8AAD/////AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEC" +
           "vDwALgBEvDwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEC" +
           "vTwALwEABgm9PAAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAr48AC4ARL48" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAkAAABTdXNwZW5kZWQBAr88AC8BAAMJvzwAAP////8B" +
           "AAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgECwDwALgBEwDwAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAAAEQAAAFN1c3BlbmRlZFRvSGFsdGVkAQLBPAAvAQAGCcE8AAD/////AQAAABVgiQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgECwjwALgBEwjwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEAAA" +
           "AFN1c3BlbmRlZFRvUmVhZHkBAsM8AC8BAAYJwzwAAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0" +
           "aW9uTnVtYmVyAQLEPAAuAETEPAAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAU3VzcGVuZGVk" +
           "VG9SdW5uaW5nAQLFPAAvAQAGCcU8AAD/////AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgECxjwALgBExjwAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAsc8AC8BAvo6xzwA" +
           "AAEB/////wAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQLIPAAvAQL7Osg8AAABAf////8AAAAABGGCCgQA" +
           "AAAAAAYAAABSZXN1bWUBAsk8AC8BAvk6yTwAAAEB/////wAAAAAEYYIKBAAAAAAABwAAAFN1c3BlbmQB" +
           "Aso8AC8BAvg6yjwAAAEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQLLPAAvAQL3Oss8AAABAf//" +
           "//8AAAAABGCACgEAAAACABMAAABSZWxlYXNlR3JpcHBlclNraWxsAQLMPAAvAQK6Osw8AAD/////GQAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQLNPAAvAQDICs08AAAAFf////8BAf////8CAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAECzjwALgBEzjwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgEC0DwALgBE0DwAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQLS" +
           "PAAvAQDPCtI8AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEC0zwALgBE0zwAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEC1TwALgBE1TwAAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQLWPAAuAETWPAAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABEZWxldGFibGUBAto8AC4ARNo8AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoA" +
           "AABBdXRvRGVsZXRlAQLbPAAuAETbPAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNs" +
           "ZUNvdW50AQLcPAAuAETcPAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAEAAAATmFtZQEC6zwDAAAA" +
           "ABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAETrPAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "TWF4SW5zdGFuY2VDb3VudAEC7DwALgBE7DwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABgAAAEhh" +
           "bHRlZAEC7TwALwEAAwntPAAA/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQLuPAAuAETu" +
           "PAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFkeQEC7zwALwEABgnvPAAA" +
           "/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAvA8AC4ARPA8AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAAUAAABSZWFkeQEC8TwALwEAAwnxPAAA/////wEAAAAVYIkKAgAAAAAACwAA" +
           "AFN0YXRlTnVtYmVyAQLyPAAuAETyPAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAAUmVhZHlU" +
           "b0hhbHRlZAEC8zwALwEABgnzPAAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "AvQ8AC4ARPQ8AAAAB/////8BAf////8AAAAABGCACgEAAAAAAA4AAABSZWFkeVRvUnVubmluZwEC9TwA" +
           "LwEABgn1PAAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAvY8AC4ARPY8AAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQL3PAAvAQADCfc8AAD/////AQAAABVg" +
           "iQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAvg8AC4ARPg8AAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA8AAABSdW5uaW5nVG9IYWx0ZWQBAvk8AC8BAAYJ+TwAAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFu" +
           "c2l0aW9uTnVtYmVyAQL6PAAuAET6PAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmlu" +
           "Z1RvUmVhZHkBAvs8AC8BAAYJ+zwAAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
           "AQL8PAAuAET8PAAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAUnVubmluZ1RvU3VzcGVuZGVk" +
           "AQL9PAAvAQAGCf08AAD/////AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEC/jwALgBE" +
           "/jwAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAEC/zwALwEAAwn/PAAA////" +
           "/wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQIAPQAuAEQAPQAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAgE9AC8BAAYJAT0AAP////8BAAAAFWCJCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQICPQAuAEQCPQAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQ" +
           "AAAAU3VzcGVuZGVkVG9SZWFkeQECAz0ALwEABgkDPQAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAgQ9AC4ARAQ9AAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5k" +
           "ZWRUb1J1bm5pbmcBAgU9AC8BAAYJBT0AAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQIGPQAuAEQGPQAAAAf/////AQH/////AAAAAARhggoEAAAAAAAEAAAASGFsdAECBz0ALwEC+joH" +
           "PQAAAQH/////AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAgg9AC8BAvs6CD0AAAEB/////wAAAAAEYYIK" +
           "BAAAAAAABgAAAFJlc3VtZQECCT0ALwEC+ToJPQAAAQH/////AAAAAARhggoEAAAAAAAHAAAAU3VzcGVu" +
           "ZAECCj0ALwEC+DoKPQAAAQH/////AAAAAARhggoEAAAAAAAFAAAAU3RhcnQBAgs9AC8BAvc6Cz0AAAEB" +
           "/////wAAAAAEYIAKAQAAAAIAEQAAAEdyYXNwR3JpcHBlclNraWxsAQIMPQAvAQK6Ogw9AAD/////GQAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQINPQAvAQDICg09AAAAFf////8BAf////8CAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAECDj0ALgBEDj0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgECED0ALgBEED0AAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQIS" +
           "PQAvAQDPChI9AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAECEz0ALgBEEz0AAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgECFT0ALgBEFT0AAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQIWPQAuAEQWPQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABEZWxldGFibGUBAho9AC4ARBo9AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoA" +
           "AABBdXRvRGVsZXRlAQIbPQAuAEQbPQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNs" +
           "ZUNvdW50AQIcPQAuAEQcPQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAEAAAATmFtZQECKz0DAAAA" +
           "ABEAAABOYW1lIG9mIHRoZSBza2lsbAAuAEQrPQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "TWF4SW5zdGFuY2VDb3VudAECLD0ALgBELD0AAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABgAAAEhh" +
           "bHRlZAECLT0ALwEAAwktPQAA/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQIuPQAuAEQu" +
           "PQAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAASGFsdGVkVG9SZWFkeQECLz0ALwEABgkvPQAA" +
           "/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAjA9AC4ARDA9AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAAUAAABSZWFkeQECMT0ALwEAAwkxPQAA/////wEAAAAVYIkKAgAAAAAACwAA" +
           "AFN0YXRlTnVtYmVyAQIyPQAuAEQyPQAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAAUmVhZHlU" +
           "b0hhbHRlZAECMz0ALwEABgkzPQAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "AjQ9AC4ARDQ9AAAAB/////8BAf////8AAAAABGCACgEAAAAAAA4AAABSZWFkeVRvUnVubmluZwECNT0A" +
           "LwEABgk1PQAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAjY9AC4ARDY9AAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQI3PQAvAQADCTc9AAD/////AQAAABVg" +
           "iQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAjg9AC4ARDg9AAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA8AAABSdW5uaW5nVG9IYWx0ZWQBAjk9AC8BAAYJOT0AAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFu" +
           "c2l0aW9uTnVtYmVyAQI6PQAuAEQ6PQAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUnVubmlu" +
           "Z1RvUmVhZHkBAjs9AC8BAAYJOz0AAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
           "AQI8PQAuAEQ8PQAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAUnVubmluZ1RvU3VzcGVuZGVk" +
           "AQI9PQAvAQAGCT09AAD/////AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgECPj0ALgBE" +
           "Pj0AAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1c3BlbmRlZAECPz0ALwEAAwk/PQAA////" +
           "/wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQJAPQAuAERAPQAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAkE9AC8BAAYJQT0AAP////8BAAAAFWCJCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQJCPQAuAERCPQAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQ" +
           "AAAAU3VzcGVuZGVkVG9SZWFkeQECQz0ALwEABglDPQAA/////wEAAAAVYIkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAkQ9AC4AREQ9AAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5k" +
           "ZWRUb1J1bm5pbmcBAkU9AC8BAAYJRT0AAP////8BAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQJGPQAuAERGPQAAAAf/////AQH/////AAAAAARhggoEAAAAAAAEAAAASGFsdAECRz0ALwEC+jpH" +
           "PQAAAQH/////AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAkg9AC8BAvs6SD0AAAEB/////wAAAAAEYYIK" +
           "BAAAAAAABgAAAFJlc3VtZQECST0ALwEC+TpJPQAAAQH/////AAAAAARhggoEAAAAAAAHAAAAU3VzcGVu" +
           "ZAECSj0ALwEC+DpKPQAAAQH/////AAAAAARhggoEAAAAAAAFAAAAU3RhcnQBAks9AC8BAvc6Sz0AAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState Skills
        {
            get
            {
                return m_skills;
            }

            set
            {
                if (!Object.ReferenceEquals(m_skills, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_skills = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_skills != null)
            {
                children.Add(m_skills);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case fortiss.Di.BrowseNames.Skills:
                {
                    if (createOrReplace)
                    {
                        if (Skills == null)
                        {
                            if (replacement == null)
                            {
                                Skills = new BaseObjectState(this);
                            }
                            else
                            {
                                Skills = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Skills;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_skills;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <summary>
    /// Stores an instance of the SensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : ComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.SensorType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgASAAAAU2Vuc29yVHlwZUluc3RhbmNlAQJMPQECTD1MPQAA////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ForceTorqueSensorState Class
    #if (!OPCUA_EXCLUDE_ForceTorqueSensorState)
    /// <summary>
    /// Stores an instance of the ForceTorqueSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ForceTorqueSensorState : SensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ForceTorqueSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.ForceTorqueSensorType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////4RggAIBAAAAAgAdAAAARm9yY2VUb3JxdWVTZW5zb3JUeXBlSW5zdGFuY2UBAnA9" +
           "AQJwPXA9AAAB/////wIAAAAkYIAKAQAAAAIACwAAAEZvcmNlU2Vuc29yAQKUPQMAAAAANwAAAE9mZmVy" +
           "cyBpbmZvcm1hdGlvbiBhYm91dCBmb3JjZSBleHBlcmllbmNlZCBieSB0aGUgcm9ib3QALwECTD2UPQAA" +
           "/////wEAAAA3YIkKAgAAAAIABQAAAEZvcmNlAQK2PQMAAAAAJAAAAFRoZSBjdXJyZW50IGZvcmNlcyBp" +
           "biBYIFkgYW5kIFogaW4gTgAvAQBACbY9AAAACwEAAAABAAAAAAAAAAMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAro9AC4ARLo9AAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAIADAAAAFRvcnF1" +
           "ZVNlbnNvcgECvD0DAAAAADkAAABPZmZlcnMgaW5mb3JtYXRpb24gYWJvdXQgdG9ycXVlIGV4cGVyaWVu" +
           "Y2VkIGJ5IHRoZSBzZW5zb3IALwECTD28PQAA/////wEAAAA3YIkKAgAAAAIABgAAAFRvcnF1ZQEC3j0D" +
           "AAAAAB0AAABUaGUgdG9ycXVlIGluIFggWSBhbmQgWiBpbiBObQAvAQBACd49AAAACwEAAAABAAAAAAAA" +
           "AAMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAuI9AC4AROI9AAABAHQD/////wEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SensorState ForceSensor
        {
            get
            {
                return m_forceSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_forceSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_forceSensor = value;
            }
        }

        /// <remarks />
        public SensorState TorqueSensor
        {
            get
            {
                return m_torqueSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_torqueSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_torqueSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_forceSensor != null)
            {
                children.Add(m_forceSensor);
            }

            if (m_torqueSensor != null)
            {
                children.Add(m_torqueSensor);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case fortiss.Di.BrowseNames.ForceSensor:
                {
                    if (createOrReplace)
                    {
                        if (ForceSensor == null)
                        {
                            if (replacement == null)
                            {
                                ForceSensor = new SensorState(this);
                            }
                            else
                            {
                                ForceSensor = (SensorState)replacement;
                            }
                        }
                    }

                    instance = ForceSensor;
                    break;
                }

                case fortiss.Di.BrowseNames.TorqueSensor:
                {
                    if (createOrReplace)
                    {
                        if (TorqueSensor == null)
                        {
                            if (replacement == null)
                            {
                                TorqueSensor = new SensorState(this);
                            }
                            else
                            {
                                TorqueSensor = (SensorState)replacement;
                            }
                        }
                    }

                    instance = TorqueSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SensorState m_forceSensor;
        private SensorState m_torqueSensor;
        #endregion
    }
    #endif
    #endregion

    #region SkillTransitionEventState Class
    #if (!OPCUA_EXCLUDE_SkillTransitionEventState)
    /// <summary>
    /// Stores an instance of the SkillTransitionEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillTransitionEventState : ProgramTransitionEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillTransitionEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Di.ObjectTypes.SkillTransitionEventType, fortiss.Di.Namespaces.fortissDi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvGgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvREkv/////wRggAIBAAAAAgAgAAAAU2tpbGxUcmFuc2l0aW9uRXZlbnRUeXBlSW5zdGFuY2UB" +
           "AuQ9AQLkPeQ9AAD/////DAAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEC5T0ALgBE5T0AAAAP/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEC5j0ALgBE5j0AAAAR/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAuc9AC4AROc9AAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAoAAABTb3VyY2VOYW1lAQLoPQAuAEToPQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGlt" +
           "ZQEC6T0ALgBE6T0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAuo9" +
           "AC4AROo9AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAuw9AC4AROw9AAAA" +
           "Ff////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQEC7T0ALgBE7T0AAAAF/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACgAAAFRyYW5zaXRpb24BAu49AC8BAMoK7j0AAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQLvPQAuAETvPQAAABj/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARnJv" +
           "bVN0YXRlAQL0PQAvAQDDCvQ9AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEC9T0ALgBE" +
           "9T0AAAAY/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFRvU3RhdGUBAvk9AC8BAMMK+T0AAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQL6PQAuAET6PQAAABj/////AQH/////AAAAABVgiQoC" +
           "AAAAAAASAAAASW50ZXJtZWRpYXRlUmVzdWx0AQL+PQAvAD/+PQAAABj/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}