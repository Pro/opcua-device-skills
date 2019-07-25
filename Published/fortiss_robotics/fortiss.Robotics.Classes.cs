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
using fortiss.Di;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Robotics;

namespace fortiss.Robotics
{
    #region MoveSkillState Class
    #if (!OPCUA_EXCLUDE_MoveSkillState)
    /// <summary>
    /// Stores an instance of the MoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.MoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABABUAAABNb3ZlU2tpbGxUeXBlSW5z" +
           "dGFuY2UBAbo6AQG6Oro6AAD/////GgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQG7OgAvAQDI" +
           "Crs6AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBvDoALgBEvDoAAAAR/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBvjoALgBEvjoAAAAH/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADgAAAExhc3RUcmFuc2l0aW9uAQHAOgAvAQDPCsA6AAAAFf////8BAf////8DAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBwToALgBEwToAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBwzoA" +
           "LgBEwzoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQHEOgAuAETE" +
           "OgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAck6AC4ARMk6AAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQHKOgAuAETKOgAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQHLOgAuAETLOgAAAAb/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBzToALgBEzToAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAAABgAAAEhhbHRlZAEB3ToALwEAAwndOgAABAAAAAAzAQEB5ToANAEBAek6ADQBAQHxOgA0AQEB" +
           "9ToBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB3joALgBE3joAAAcLAAAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBAd86AC8BAAMJ3zoAAAUAAAAANAEBAeU6ADMBAQHnOgA0AQEB" +
           "6zoANAEBAfM6ADMBAQH1OgEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHgOgAuAETgOgAABwwA" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQHhOgAvAQADCeE6AAAFAAAAADQB" +
           "AQHnOgAzAQEB6ToAMwEBAes6ADMBAQHtOgA0AQEB7zoBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgEB4joALgBE4joAAAcNAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAJAAAAU3VzcGVuZGVkAQHj" +
           "OgAvAQADCeM6AAAEAAAAADQBAQHtOgAzAQEB7zoAMwEBAfE6ADMBAQHzOgEAAAAVYKkKAgAAAAAACwAA" +
           "AFN0YXRlTnVtYmVyAQHkOgAuAETkOgAABw4AAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABI" +
           "YWx0ZWRUb1JlYWR5AQHlOgAvAQAGCeU6AAAEAAAAADMAAQHdOgA0AAEB3zoANQABAfs6ADYAAQBKCQEA" +
           "AAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAeY6AC4AROY6AAAHAQAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQHnOgAvAQAGCec6AAAEAAAAADMAAQHfOgA0" +
           "AAEB4ToANQABAfc6ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAeg6AC4A" +
           "ROg6AAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAAAFJ1bm5pbmdUb0hhbHRlZAEB6ToA" +
           "LwEABgnpOgAABAAAAAAzAAEB4ToANAABAd06ADUAAQH6OgA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQHqOgAuAETqOgAABwMAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA4A" +
           "AABSdW5uaW5nVG9SZWFkeQEB6zoALwEABgnrOgAAAwAAAAAzAAEB4ToANAABAd86ADYAAQBKCQEAAAAV" +
           "YKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAew6AC4AROw6AAAHBAAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEB7ToALwEABgntOgAABAAAAAAzAAEB4ToA" +
           "NAABAeM6ADUAAQH4OgA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHuOgAu" +
           "AETuOgAABwUAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5kZWRUb1J1bm5pbmcB" +
           "Ae86AC8BAAYJ7zoAAAQAAAAAMwABAeM6ADQAAQHhOgA1AAEB+ToANgABAEoJAQAAABVgqQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgEB8DoALgBE8DoAAAcGAAAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAfE6AC8BAAYJ8ToAAAQAAAAAMwABAeM6ADQAAQHdOgA1AAEB" +
           "+joANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB8joALgBE8joAAAcHAAAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVuZGVkVG9SZWFkeQEB8zoALwEABgnzOgAA" +
           "AwAAAAAzAAEB4zoANAABAd86ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "AfQ6AC4ARPQ6AAAHCAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAFJlYWR5VG9IYWx0ZWQB" +
           "AfU6AC8BAAYJ9ToAAAQAAAAAMwABAd86ADQAAQHdOgA1AAEB+joANgABAEoJAQAAABVgqQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgEB9joALgBE9joAAAcJAAAAAAf/////AQH/////AAAAAARhggoEAAAA" +
           "AAAFAAAAU3RhcnQBAfc6AC8BAHoJ9zoAAAEBAQAAAAA1AQEB5zoAAAAABGGCCgQAAAAAAAcAAABTdXNw" +
           "ZW5kAQH4OgAvAQB7Cfg6AAABAQEAAAAANQEBAe06AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQH5OgAv" +
           "AQB8Cfk6AAABAQEAAAAANQEBAe86AAAAAARhggoEAAAAAAAEAAAASGFsdAEB+joALwEAfQn6OgAAAQED" +
           "AAAAADUBAQHpOgA1AQEB8ToANQEBAfU6AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAfs6AC8BAH4J+zoA" +
           "AAEBAQAAAAA1AQEB5ToAAAAANWCJCgIAAAACAAQAAABOYW1lAQH8OgMAAAAAEQAAAE5hbWUgb2YgdGhl" +
           "IHNraWxsAC4ARPw6AAAADP////8BAf////8AAAAABGCACgEAAAADAAwAAABQYXJhbWV0ZXJTZXQBAf06" +
           "AC8AOv06AAD/////AQAAADVgiQoCAAAAAQAJAAAAVG9vbEZyYW1lAQH+OgMAAAAANAAAAFRoZSBuYW1l" +
           "IG9mIHRoZSB0b29sIGZyYW1lIHRvIGJlIHVzZWQgZm9yIHRoZSBtb3Rpb24ALwA//joAAAAM/////wMD" +
           "/////wAAAAA=";
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

    #region LinearMoveSkillState Class
    #if (!OPCUA_EXCLUDE_LinearMoveSkillState)
    /// <summary>
    /// Stores an instance of the LinearMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LinearMoveSkillState : MoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LinearMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.LinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABABsAAABMaW5lYXJNb3ZlU2tpbGxU" +
           "eXBlSW5zdGFuY2UBAf86AQH/Ov86AAD/////GgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEA" +
           "OwAvAQDICgA7AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBATsALgBEATsAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBAzsALgBEAzsAAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQEFOwAvAQDPCgU7AAAAFf////8BAf////8DAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBBjsALgBEBjsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgEBCDsALgBECDsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQEJ" +
           "OwAuAEQJOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAQ47AC4ARA47" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQEPOwAuAEQPOwAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQEQOwAuAEQQOwAAAAb/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBEjsALgBEEjsAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAABgAAAEhhbHRlZAEBIjsALwEAAwkiOwAABAAAAAAzAQEBKjsANAEBAS47ADQBAQE2" +
           "OwA0AQEBOjsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBIzsALgBEIzsAAAcLAAAAAAf/////" +
           "AQH/////AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBASQ7AC8BAAMJJDsAAAUAAAAANAEBASo7ADMBAQEs" +
           "OwA0AQEBMDsANAEBATg7ADMBAQE6OwEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQElOwAuAEQl" +
           "OwAABwwAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQEmOwAvAQADCSY7AAAF" +
           "AAAAADQBAQEsOwAzAQEBLjsAMwEBATA7ADMBAQEyOwA0AQEBNDsBAAAAFWCpCgIAAAAAAAsAAABTdGF0" +
           "ZU51bWJlcgEBJzsALgBEJzsAAAcNAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAJAAAAU3VzcGVu" +
           "ZGVkAQEoOwAvAQADCSg7AAAEAAAAADQBAQEyOwAzAQEBNDsAMwEBATY7ADMBAQE4OwEAAAAVYKkKAgAA" +
           "AAAACwAAAFN0YXRlTnVtYmVyAQEpOwAuAEQpOwAABw4AAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA0AAABIYWx0ZWRUb1JlYWR5AQEqOwAvAQAGCSo7AAAEAAAAADMAAQEiOwA0AAEBJDsANQABAUA7ADYA" +
           "AQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBASs7AC4ARCs7AAAHAQAAAAAH////" +
           "/wEB/////wAAAAAEYIAKAQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQEsOwAvAQAGCSw7AAAEAAAAADMA" +
           "AQEkOwA0AAEBJjsANQABATw7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "AS07AC4ARC07AAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAAAFJ1bm5pbmdUb0hhbHRl" +
           "ZAEBLjsALwEABgkuOwAABAAAAAAzAAEBJjsANAABASI7ADUAAQE/OwA2AAEASgkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQEvOwAuAEQvOwAABwMAAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAAAAA4AAABSdW5uaW5nVG9SZWFkeQEBMDsALwEABgkwOwAAAwAAAAAzAAEBJjsANAABASQ7ADYAAQBK" +
           "CQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBATE7AC4ARDE7AAAHBAAAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBMjsALwEABgkyOwAABAAAAAAz" +
           "AAEBJjsANAABASg7ADUAAQE9OwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
           "AQEzOwAuAEQzOwAABwUAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5kZWRUb1J1" +
           "bm5pbmcBATQ7AC8BAAYJNDsAAAQAAAAAMwABASg7ADQAAQEmOwA1AAEBPjsANgABAEoJAQAAABVgqQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBNTsALgBENTsAAAcGAAAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBATY7AC8BAAYJNjsAAAQAAAAAMwABASg7ADQAAQEi" +
           "OwA1AAEBPzsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBNzsALgBENzsA" +
           "AAcHAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVuZGVkVG9SZWFkeQEBODsALwEA" +
           "Bgk4OwAAAwAAAAAzAAEBKDsANAABASQ7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBATk7AC4ARDk7AAAHCAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAFJlYWR5VG9I" +
           "YWx0ZWQBATo7AC8BAAYJOjsAAAQAAAAAMwABASQ7ADQAAQEiOwA1AAEBPzsANgABAEoJAQAAABVgqQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBOzsALgBEOzsAAAcJAAAAAAf/////AQH/////AAAAAARh" +
           "ggoEAAAAAAAFAAAAU3RhcnQBATw7AC8BAHoJPDsAAAEBAQAAAAA1AQEBLDsAAAAABGGCCgQAAAAAAAcA" +
           "AABTdXNwZW5kAQE9OwAvAQB7CT07AAABAQEAAAAANQEBATI7AAAAAARhggoEAAAAAAAGAAAAUmVzdW1l" +
           "AQE+OwAvAQB8CT47AAABAQEAAAAANQEBATQ7AAAAAARhggoEAAAAAAAEAAAASGFsdAEBPzsALwEAfQk/" +
           "OwAAAQEDAAAAADUBAQEuOwA1AQEBNjsANQEBATo7AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAUA7AC8B" +
           "AH4JQDsAAAEBAQAAAAA1AQEBKjsAAAAANWCJCgIAAAACAAQAAABOYW1lAQFBOwMAAAAAEQAAAE5hbWUg" +
           "b2YgdGhlIHNraWxsAC4AREE7AAAADP////8BAf////8AAAAABGCACgEAAAADAAwAAABQYXJhbWV0ZXJT" +
           "ZXQBAUI7AC8AOkI7AAD/////AwAAADVgiQoCAAAAAQAJAAAAVG9vbEZyYW1lAQFDOwMAAAAANAAAAFRo" +
           "ZSBuYW1lIG9mIHRoZSB0b29sIGZyYW1lIHRvIGJlIHVzZWQgZm9yIHRoZSBtb3Rpb24ALwA/QzsAAAAM" +
           "/////wMD/////wAAAAA3YIkKAgAAAAEADwAAAE1heEFjY2VsZXJhdGlvbgEBRDsDAAAAAIcAAABNYXhp" +
           "bXVtIGFjY2VsZXJhdGlvbiBvZiB0aGUgcm9ib3Qgc2hvdWxkIG1vdmUuIEZpcnN0IHRocmVlIHBhcmFt" +
           "ZXRlcnMgYXJlIGZvciB4LHkseiBpbiBtL3NeMi4gVGhlIG5leHQgdGhyZWUgZm9yIG9yaWVudGF0aW9u" +
           "IGluIHJhZC9zXjIALwEAQAlEOwAAAAsBAAAAAQAAAAYAAAADA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQFIOwAuAERIOwAAAQB0A/////8BAf////8AAAAAN2CJCgIAAAABAAsAAABNYXhWZWxvY2l0" +
           "eQEBSjsDAAAAAH8AAABNYXhpbXVtIHZlbG9jaXR5IG9mIHRoZSByb2JvdCBzaG91bGQgbW92ZS4gRmly" +
           "c3QgdGhyZWUgcGFyYW1ldGVycyBhcmUgZm9yIHgseSx6IGluIG0vcy4gVGhlIG5leHQgdGhyZWUgZm9y" +
           "IG9yaWVudGF0aW9uIGluIHJhZC9zAC8BAEAJSjsAAAALAQAAAAEAAAAGAAAAAwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBTjsALgBETjsAAAEAdAP/////AQH/////AAAAAA==";
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

    #region PtpMoveSkillState Class
    #if (!OPCUA_EXCLUDE_PtpMoveSkillState)
    /// <summary>
    /// Stores an instance of the PtpMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PtpMoveSkillState : MoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PtpMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.PtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABABgAAABQdHBNb3ZlU2tpbGxUeXBl" +
           "SW5zdGFuY2UBAVA7AQFQO1A7AAD/////GgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQFROwAv" +
           "AQDIClE7AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBUjsALgBEUjsAAAAR/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBVDsALgBEVDsAAAAH/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQFWOwAvAQDPClY7AAAAFf////8BAf////8DAAAAFWCJCgIA" +
           "AAAAAAIAAABJZAEBVzsALgBEVzsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEB" +
           "WTsALgBEWTsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQFaOwAu" +
           "AERaOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAV87AC4ARF87AAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQFgOwAuAERgOwAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQFhOwAuAERhOwAAAAb/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBYzsALgBEYzsAAAAH/////wEB/////wAAAAAE" +
           "YIAKAQAAAAAABgAAAEhhbHRlZAEBczsALwEAAwlzOwAABAAAAAAzAQEBezsANAEBAX87ADQBAQGHOwA0" +
           "AQEBizsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBdDsALgBEdDsAAAcLAAAAAAf/////AQH/" +
           "////AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBAXU7AC8BAAMJdTsAAAUAAAAANAEBAXs7ADMBAQF9OwA0" +
           "AQEBgTsANAEBAYk7ADMBAQGLOwEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQF2OwAuAER2OwAA" +
           "BwwAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5nAQF3OwAvAQADCXc7AAAFAAAA" +
           "ADQBAQF9OwAzAQEBfzsAMwEBAYE7ADMBAQGDOwA0AQEBhTsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51" +
           "bWJlcgEBeDsALgBEeDsAAAcNAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAJAAAAU3VzcGVuZGVk" +
           "AQF5OwAvAQADCXk7AAAEAAAAADQBAQGDOwAzAQEBhTsAMwEBAYc7ADMBAQGJOwEAAAAVYKkKAgAAAAAA" +
           "CwAAAFN0YXRlTnVtYmVyAQF6OwAuAER6OwAABw4AAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0A" +
           "AABIYWx0ZWRUb1JlYWR5AQF7OwAvAQAGCXs7AAAEAAAAADMAAQFzOwA0AAEBdTsANQABAZE7ADYAAQBK" +
           "CQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAXw7AC4ARHw7AAAHAQAAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQF9OwAvAQAGCX07AAAEAAAAADMAAQF1" +
           "OwA0AAEBdzsANQABAY07ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAX47" +
           "AC4ARH47AAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAAAFJ1bm5pbmdUb0hhbHRlZAEB" +
           "fzsALwEABgl/OwAABAAAAAAzAAEBdzsANAABAXM7ADUAAQGQOwA2AAEASgkBAAAAFWCpCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQGAOwAuAESAOwAABwMAAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AA4AAABSdW5uaW5nVG9SZWFkeQEBgTsALwEABgmBOwAAAwAAAAAzAAEBdzsANAABAXU7ADYAAQBKCQEA" +
           "AAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAYI7AC4ARII7AAAHBAAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBgzsALwEABgmDOwAABAAAAAAzAAEB" +
           "dzsANAABAXk7ADUAAQGOOwA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGE" +
           "OwAuAESEOwAABwUAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIAAABTdXNwZW5kZWRUb1J1bm5p" +
           "bmcBAYU7AC8BAAYJhTsAAAQAAAAAMwABAXk7ADQAAQF3OwA1AAEBjzsANgABAEoJAQAAABVgqQoCAAAA" +
           "AAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBhjsALgBEhjsAAAcGAAAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAYc7AC8BAAYJhzsAAAQAAAAAMwABAXk7ADQAAQFzOwA1" +
           "AAEBkDsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBiDsALgBEiDsAAAcH" +
           "AAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVuZGVkVG9SZWFkeQEBiTsALwEABgmJ" +
           "OwAAAwAAAAAzAAEBeTsANAABAXU7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1i" +
           "ZXIBAYo7AC4ARIo7AAAHCAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAAAFJlYWR5VG9IYWx0" +
           "ZWQBAYs7AC8BAAYJizsAAAQAAAAAMwABAXU7ADQAAQFzOwA1AAEBkDsANgABAEoJAQAAABVgqQoCAAAA" +
           "AAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBjDsALgBEjDsAAAcJAAAAAAf/////AQH/////AAAAAARhggoE" +
           "AAAAAAAFAAAAU3RhcnQBAY07AC8BAHoJjTsAAAEBAQAAAAA1AQEBfTsAAAAABGGCCgQAAAAAAAcAAABT" +
           "dXNwZW5kAQGOOwAvAQB7CY47AAABAQEAAAAANQEBAYM7AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQGP" +
           "OwAvAQB8CY87AAABAQEAAAAANQEBAYU7AAAAAARhggoEAAAAAAAEAAAASGFsdAEBkDsALwEAfQmQOwAA" +
           "AQEDAAAAADUBAQF/OwA1AQEBhzsANQEBAYs7AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAZE7AC8BAH4J" +
           "kTsAAAEBAQAAAAA1AQEBezsAAAAANWCJCgIAAAACAAQAAABOYW1lAQGSOwMAAAAAEQAAAE5hbWUgb2Yg" +
           "dGhlIHNraWxsAC4ARJI7AAAADP////8BAf////8AAAAABGCACgEAAAADAAwAAABQYXJhbWV0ZXJTZXQB" +
           "AZM7AC8AOpM7AAD/////AwAAADVgiQoCAAAAAQAJAAAAVG9vbEZyYW1lAQGUOwMAAAAANAAAAFRoZSBu" +
           "YW1lIG9mIHRoZSB0b29sIGZyYW1lIHRvIGJlIHVzZWQgZm9yIHRoZSBtb3Rpb24ALwA/lDsAAAAM////" +
           "/wMD/////wAAAAA3YIkKAgAAAAEADwAAAE1heEFjY2VsZXJhdGlvbgEBlTsDAAAAAEQAAABNYXhpbXVt" +
           "IGFjY2VsZXJhdGlvbiB0aGUgcm9ib3Qgc2hvdWxkIG1vdmUgaW4gcmFkL3NeMiBmb3IgZXZlcnkgYXhp" +
           "cwAvAQBACZU7AAAACwEAAAABAAAAAAAAAAMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZk7" +
           "AC4ARJk7AAABAHQD/////wEB/////wAAAAA3YIkKAgAAAAEACwAAAE1heFZlbG9jaXR5AQGbOwMAAAAA" +
           "PgAAAE1heGltdW0gdmVsb2NpdHkgdGhlIHJvYm90IHNob3VsZCBtb3ZlIGluIHJhZC9zIGZvciBldmVy" +
           "eSBheGlzAC8BAEAJmzsAAAALAQAAAAEAAAAAAAAAAwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBnzsALgBEnzsAAAEAdAP/////AQH/////AAAAAA==";
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

    #region ICartesianMoveSkillParameterState Class
    #if (!OPCUA_EXCLUDE_ICartesianMoveSkillParameterState)
    /// <summary>
    /// Stores an instance of the ICartesianMoveSkillParameterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ICartesianMoveSkillParameterState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ICartesianMoveSkillParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.ICartesianMoveSkillParameterType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////hGCAAgEAAAABACgAAABJQ2FydGVzaWFuTW92ZVNr" +
           "aWxsUGFyYW1ldGVyVHlwZUluc3RhbmNlAQGhOwEBoTuhOwAAAf////8BAAAABGCACgEAAAADAAwAAABQ" +
           "YXJhbWV0ZXJTZXQBAaI7AC8AOqI7AAD/////AgAAADVgiQoCAAAAAQAOAAAAVGFyZ2V0UG9zaXRpb24B" +
           "AaM7AwAAAAApAAAAQWJzb2x1dGUgZ29hbCBwb3NpdGlvbiBpbiBjYXJ0ZXNpYW4gc3BhY2UALwEAZ0mj" +
           "OwAAAQB+Sf////8DA/////8CAAAAFWCJCgIAAAAAABQAAABDYXJ0ZXNpYW5Db29yZGluYXRlcwEBpDsA" +
           "LwEAVkmkOwAAAQB6Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABYAQGrOwAvAD+rOwAAAAv/////" +
           "AQH/////AAAAABVgiQoCAAAAAAABAAAAWQEBrDsALwA/rDsAAAAL/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAAQAAAFoBAa07AC8AP607AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABPcmllbnRhdGlv" +
           "bgEBpjsALwEAXUmmOwAAAQB8Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABBAQGuOwAvAD+uOwAA" +
           "AAv/////AQH/////AAAAABVgiQoCAAAAAAABAAAAQgEBrzsALwA/rzsAAAAL/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAAQAAAEMBAbA7AC8AP7A7AAAAC/////8BAf////8AAAAAN2CJCgIAAAABAAoAAABBeGlz" +
           "Qm91bmRzAQGxOwMAAAAAigAAAERlZmluZSBhIHJhbmdlIHdpdGhpbiB3aGljaCB0aGUgam9pbnRzIHNo" +
           "b3VsZCBlbmQgdXAgaW4uIFVzZWQgdG8gbGltaXQgdGhlIHNvbHV0aW9ucyBmb3IgdGhlCiAgICAgICAg" +
           "ICAgICAgaW52ZXJzZSBraW5lbWF0aWNzIGNhbGN1bGF0aW9uLgAvAD+xOwAAAQB0AwEAAAABAAAAAAAA" +
           "AAMD/////wAAAAA=";
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

    #region IJointMoveSkillParameterState Class
    #if (!OPCUA_EXCLUDE_IJointMoveSkillParameterState)
    /// <summary>
    /// Stores an instance of the IJointMoveSkillParameterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IJointMoveSkillParameterState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IJointMoveSkillParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.IJointMoveSkillParameterType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////hGCAAgEAAAABACQAAABJSm9pbnRNb3ZlU2tpbGxQ" +
           "YXJhbWV0ZXJUeXBlSW5zdGFuY2UBAbc7AQG3O7c7AAAB/////wEAAAAEYIAKAQAAAAMADAAAAFBhcmFt" +
           "ZXRlclNldAEBuDsALwA6uDsAAP////8BAAAAN2CJCgIAAAABABMAAABUYXJnZXRKb2ludFBvc2l0aW9u" +
           "AQG5OwMAAAAAOwAAAFRoZSBuZXcgYXhpcyBwb3NpdGlvbiBhcnJheSB3aGVyZSB0aGUgZGV2aWNlIHNo" +
           "b3VsZCBtb3ZlIHRvAC8BAEAJuTsAAAALAQAAAAEAAAAAAAAAAwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBvTsALgBEvTsAAAEAdAP/////AQH/////AAAAAA==";
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

    #region CartesianLinearMoveSkillState Class
    #if (!OPCUA_EXCLUDE_CartesianLinearMoveSkillState)
    /// <summary>
    /// Stores an instance of the CartesianLinearMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CartesianLinearMoveSkillState : LinearMoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CartesianLinearMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.CartesianLinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABACQAAABDYXJ0ZXNpYW5MaW5lYXJN" +
           "b3ZlU2tpbGxUeXBlSW5zdGFuY2UBAb87AQG/O787AAABAAAAAQDDRAABAaE7GgAAABVgiQoCAAAAAAAM" +
           "AAAAQ3VycmVudFN0YXRlAQHAOwAvAQDICsA7AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBwTsALgBEwTsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBwzsALgBEwzsA" +
           "AAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQHFOwAvAQDPCsU7AAAA" +
           "Ff////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBxjsALgBExjsAAAAR/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABgAAAE51bWJlcgEByDsALgBEyDsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAA" +
           "AFRyYW5zaXRpb25UaW1lAQHJOwAuAETJOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABE" +
           "ZWxldGFibGUBAc47AC4ARM47AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRl" +
           "AQHPOwAuAETPOwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQHQOwAu" +
           "AETQOwAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEB0jsALgBE" +
           "0jsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABgAAAEhhbHRlZAEB4jsALwEAAwniOwAABAAAAAAz" +
           "AQEB6jsANAEBAe47ADQBAQH2OwA0AQEB+jsBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB4zsA" +
           "LgBE4zsAAAcLAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBAeQ7AC8BAAMJ5DsA" +
           "AAUAAAAANAEBAeo7ADMBAQHsOwA0AQEB8DsANAEBAfg7ADMBAQH6OwEAAAAVYKkKAgAAAAAACwAAAFN0" +
           "YXRlTnVtYmVyAQHlOwAuAETlOwAABwwAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5u" +
           "aW5nAQHmOwAvAQADCeY7AAAFAAAAADQBAQHsOwAzAQEB7jsAMwEBAfA7ADMBAQHyOwA0AQEB9DsBAAAA" +
           "FWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB5zsALgBE5zsAAAcNAAAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAAJAAAAU3VzcGVuZGVkAQHoOwAvAQADCeg7AAAEAAAAADQBAQHyOwAzAQEB9DsAMwEBAfY7" +
           "ADMBAQH4OwEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHpOwAuAETpOwAABw4AAAAAB/////8B" +
           "Af////8AAAAABGCACgEAAAAAAA0AAABIYWx0ZWRUb1JlYWR5AQHqOwAvAQAGCeo7AAAEAAAAADMAAQHi" +
           "OwA0AAEB5DsANQABAQA8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAes7" +
           "AC4AROs7AAAHAQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQHs" +
           "OwAvAQAGCew7AAAEAAAAADMAAQHkOwA0AAEB5jsANQABAfw7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAA" +
           "AFRyYW5zaXRpb25OdW1iZXIBAe07AC4ARO07AAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAA" +
           "DwAAAFJ1bm5pbmdUb0hhbHRlZAEB7jsALwEABgnuOwAABAAAAAAzAAEB5jsANAABAeI7ADUAAQH/OwA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHvOwAuAETvOwAABwMAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAAAAA4AAABSdW5uaW5nVG9SZWFkeQEB8DsALwEABgnwOwAAAwAAAAAz" +
           "AAEB5jsANAABAeQ7ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfE7AC4A" +
           "RPE7AAAHBAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEB" +
           "8jsALwEABgnyOwAABAAAAAAzAAEB5jsANAABAeg7ADUAAQH9OwA2AAEASgkBAAAAFWCpCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQHzOwAuAETzOwAABwUAAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "ABIAAABTdXNwZW5kZWRUb1J1bm5pbmcBAfQ7AC8BAAYJ9DsAAAQAAAAAMwABAeg7ADQAAQHmOwA1AAEB" +
           "/jsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB9TsALgBE9TsAAAcGAAAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAfY7AC8BAAYJ9jsA" +
           "AAQAAAAAMwABAeg7ADQAAQHiOwA1AAEB/zsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlv" +
           "bk51bWJlcgEB9zsALgBE9zsAAAcHAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVu" +
           "ZGVkVG9SZWFkeQEB+DsALwEABgn4OwAAAwAAAAAzAAEB6DsANAABAeQ7ADYAAQBKCQEAAAAVYKkKAgAA" +
           "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfk7AC4ARPk7AAAHCAAAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAAADQAAAFJlYWR5VG9IYWx0ZWQBAfo7AC8BAAYJ+jsAAAQAAAAAMwABAeQ7ADQAAQHiOwA1AAEB" +
           "/zsANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB+zsALgBE+zsAAAcJAAAA" +
           "AAf/////AQH/////AAAAAARhggoEAAAAAAAFAAAAU3RhcnQBAfw7AC8BAHoJ/DsAAAEBAQAAAAA1AQEB" +
           "7DsAAAAABGGCCgQAAAAAAAcAAABTdXNwZW5kAQH9OwAvAQB7Cf07AAABAQEAAAAANQEBAfI7AAAAAARh" +
           "ggoEAAAAAAAGAAAAUmVzdW1lAQH+OwAvAQB8Cf47AAABAQEAAAAANQEBAfQ7AAAAAARhggoEAAAAAAAE" +
           "AAAASGFsdAEB/zsALwEAfQn/OwAAAQEDAAAAADUBAQHuOwA1AQEB9jsANQEBAfo7AAAAAARhggoEAAAA" +
           "AAAFAAAAUmVzZXQBAQA8AC8BAH4JADwAAAEBAQAAAAA1AQEB6jsAAAAANWCJCgIAAAACAAQAAABOYW1l" +
           "AQEBPAMAAAAAEQAAAE5hbWUgb2YgdGhlIHNraWxsAC4ARAE8AAAADP////8BAf////8AAAAABGCACgEA" +
           "AAADAAwAAABQYXJhbWV0ZXJTZXQBAQI8AC8AOgI8AAD/////AwAAADVgiQoCAAAAAQAJAAAAVG9vbEZy" +
           "YW1lAQEDPAMAAAAANAAAAFRoZSBuYW1lIG9mIHRoZSB0b29sIGZyYW1lIHRvIGJlIHVzZWQgZm9yIHRo" +
           "ZSBtb3Rpb24ALwA/AzwAAAAM/////wMD/////wAAAAA3YIkKAgAAAAEADwAAAE1heEFjY2VsZXJhdGlv" +
           "bgEBBDwDAAAAAIcAAABNYXhpbXVtIGFjY2VsZXJhdGlvbiBvZiB0aGUgcm9ib3Qgc2hvdWxkIG1vdmUu" +
           "IEZpcnN0IHRocmVlIHBhcmFtZXRlcnMgYXJlIGZvciB4LHkseiBpbiBtL3NeMi4gVGhlIG5leHQgdGhy" +
           "ZWUgZm9yIG9yaWVudGF0aW9uIGluIHJhZC9zXjIALwEAQAkEPAAAAAsBAAAAAQAAAAYAAAADA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEIPAAuAEQIPAAAAQB0A/////8BAf////8AAAAAN2CJCgIA" +
           "AAABAAsAAABNYXhWZWxvY2l0eQEBCjwDAAAAAH8AAABNYXhpbXVtIHZlbG9jaXR5IG9mIHRoZSByb2Jv" +
           "dCBzaG91bGQgbW92ZS4gRmlyc3QgdGhyZWUgcGFyYW1ldGVycyBhcmUgZm9yIHgseSx6IGluIG0vcy4g" +
           "VGhlIG5leHQgdGhyZWUgZm9yIG9yaWVudGF0aW9uIGluIHJhZC9zAC8BAEAJCjwAAAALAQAAAAEAAAAG" +
           "AAAAAwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBDjwALgBEDjwAAAEAdAP/////AQH/////" +
           "AAAAAA==";
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

    #region JointLinearMoveSkillState Class
    #if (!OPCUA_EXCLUDE_JointLinearMoveSkillState)
    /// <summary>
    /// Stores an instance of the JointLinearMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JointLinearMoveSkillState : LinearMoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public JointLinearMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.JointLinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABACAAAABKb2ludExpbmVhck1vdmVT" +
           "a2lsbFR5cGVJbnN0YW5jZQEBEDwBARA8EDwAAAEAAAABAMNEAAEBtzsaAAAAFWCJCgIAAAAAAAwAAABD" +
           "dXJyZW50U3RhdGUBARE8AC8BAMgKETwAAAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQES" +
           "PAAuAEQSPAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQEUPAAuAEQUPAAAAAf/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5zaXRpb24BARY8AC8BAM8KFjwAAAAV////" +
           "/wEB/////wMAAAAVYIkKAgAAAAAAAgAAAElkAQEXPAAuAEQXPAAAABH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAGAAAATnVtYmVyAQEZPAAuAEQZPAAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJh" +
           "bnNpdGlvblRpbWUBARo8AC4ARBo8AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAERlbGV0" +
           "YWJsZQEBHzwALgBEHzwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAEF1dG9EZWxldGUBASA8" +
           "AC4ARCA8AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABSZWN5Y2xlQ291bnQBASE8AC4ARCE8" +
           "AAAABv////8BAf////8AAAAAFWCJCgIAAAAAABAAAABNYXhJbnN0YW5jZUNvdW50AQEjPAAuAEQjPAAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAAAGAAAASGFsdGVkAQEzPAAvAQADCTM8AAAEAAAAADMBAQE7" +
           "PAA0AQEBPzwANAEBAUc8ADQBAQFLPAEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQE0PAAuAEQ0" +
           "PAAABwsAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAUAAABSZWFkeQEBNTwALwEAAwk1PAAABQAA" +
           "AAA0AQEBOzwAMwEBAT08ADQBAQFBPAA0AQEBSTwAMwEBAUs8AQAAABVgqQoCAAAAAAALAAAAU3RhdGVO" +
           "dW1iZXIBATY8AC4ARDY8AAAHDAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABwAAAFJ1bm5pbmcB" +
           "ATc8AC8BAAMJNzwAAAUAAAAANAEBAT08ADMBAQE/PAAzAQEBQTwAMwEBAUM8ADQBAQFFPAEAAAAVYKkK" +
           "AgAAAAAACwAAAFN0YXRlTnVtYmVyAQE4PAAuAEQ4PAAABw0AAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAAAAAkAAABTdXNwZW5kZWQBATk8AC8BAAMJOTwAAAQAAAAANAEBAUM8ADMBAQFFPAAzAQEBRzwAMwEB" +
           "AUk8AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBATo8AC4ARDo8AAAHDgAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAAADQAAAEhhbHRlZFRvUmVhZHkBATs8AC8BAAYJOzwAAAQAAAAAMwABATM8ADQA" +
           "AQE1PAA1AAEBUTwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBPDwALgBE" +
           "PDwAAAcBAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUmVhZHlUb1J1bm5pbmcBAT08AC8B" +
           "AAYJPTwAAAQAAAAAMwABATU8ADQAAQE3PAA1AAEBTTwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJh" +
           "bnNpdGlvbk51bWJlcgEBPjwALgBEPjwAAAcCAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAPAAAA" +
           "UnVubmluZ1RvSGFsdGVkAQE/PAAvAQAGCT88AAAEAAAAADMAAQE3PAA0AAEBMzwANQABAVA8ADYAAQBK" +
           "CQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUA8AC4AREA8AAAHAwAAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAAADgAAAFJ1bm5pbmdUb1JlYWR5AQFBPAAvAQAGCUE8AAADAAAAADMAAQE3" +
           "PAA0AAEBNTwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBQjwALgBEQjwA" +
           "AAcEAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQFDPAAv" +
           "AQAGCUM8AAAEAAAAADMAAQE3PAA0AAEBOTwANQABAU48ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRy" +
           "YW5zaXRpb25OdW1iZXIBAUQ8AC4AREQ8AAAHBQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAA" +
           "AFN1c3BlbmRlZFRvUnVubmluZwEBRTwALwEABglFPAAABAAAAAAzAAEBOTwANAABATc8ADUAAQFPPAA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFGPAAuAERGPAAABwYAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAAAABEAAABTdXNwZW5kZWRUb0hhbHRlZAEBRzwALwEABglHPAAABAAA" +
           "AAAzAAEBOTwANAABATM8ADUAAQFQPAA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQFIPAAuAERIPAAABwcAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABAAAABTdXNwZW5kZWRU" +
           "b1JlYWR5AQFJPAAvAQAGCUk8AAADAAAAADMAAQE5PAA0AAEBNTwANgABAEoJAQAAABVgqQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgEBSjwALgBESjwAAAcIAAAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AAANAAAAUmVhZHlUb0hhbHRlZAEBSzwALwEABglLPAAABAAAAAAzAAEBNTwANAABATM8ADUAAQFQPAA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFMPAAuAERMPAAABwkAAAAAB///" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEBTTwALwEAeglNPAAAAQEBAAAAADUBAQE9PAAA" +
           "AAAEYYIKBAAAAAAABwAAAFN1c3BlbmQBAU48AC8BAHsJTjwAAAEBAQAAAAA1AQEBQzwAAAAABGGCCgQA" +
           "AAAAAAYAAABSZXN1bWUBAU88AC8BAHwJTzwAAAEBAQAAAAA1AQEBRTwAAAAABGGCCgQAAAAAAAQAAABI" +
           "YWx0AQFQPAAvAQB9CVA8AAABAQMAAAAANQEBAT88ADUBAQFHPAA1AQEBSzwAAAAABGGCCgQAAAAAAAUA" +
           "AABSZXNldAEBUTwALwEAfglRPAAAAQEBAAAAADUBAQE7PAAAAAA1YIkKAgAAAAIABAAAAE5hbWUBAVI8" +
           "AwAAAAARAAAATmFtZSBvZiB0aGUgc2tpbGwALgBEUjwAAAAM/////wEB/////wAAAAAEYIAKAQAAAAMA" +
           "DAAAAFBhcmFtZXRlclNldAEBUzwALwA6UzwAAP////8DAAAANWCJCgIAAAABAAkAAABUb29sRnJhbWUB" +
           "AVQ8AwAAAAA0AAAAVGhlIG5hbWUgb2YgdGhlIHRvb2wgZnJhbWUgdG8gYmUgdXNlZCBmb3IgdGhlIG1v" +
           "dGlvbgAvAD9UPAAAAAz/////AwP/////AAAAADdgiQoCAAAAAQAPAAAATWF4QWNjZWxlcmF0aW9uAQFV" +
           "PAMAAAAAhwAAAE1heGltdW0gYWNjZWxlcmF0aW9uIG9mIHRoZSByb2JvdCBzaG91bGQgbW92ZS4gRmly" +
           "c3QgdGhyZWUgcGFyYW1ldGVycyBhcmUgZm9yIHgseSx6IGluIG0vc14yLiBUaGUgbmV4dCB0aHJlZSBm" +
           "b3Igb3JpZW50YXRpb24gaW4gcmFkL3NeMgAvAQBACVU8AAAACwEAAAABAAAABgAAAAMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAVk8AC4ARFk8AAABAHQD/////wEB/////wAAAAA3YIkKAgAAAAEA" +
           "CwAAAE1heFZlbG9jaXR5AQFbPAMAAAAAfwAAAE1heGltdW0gdmVsb2NpdHkgb2YgdGhlIHJvYm90IHNo" +
           "b3VsZCBtb3ZlLiBGaXJzdCB0aHJlZSBwYXJhbWV0ZXJzIGFyZSBmb3IgeCx5LHogaW4gbS9zLiBUaGUg" +
           "bmV4dCB0aHJlZSBmb3Igb3JpZW50YXRpb24gaW4gcmFkL3MALwEAQAlbPAAAAAsBAAAAAQAAAAYAAAAD" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFfPAAuAERfPAAAAQB0A/////8BAf////8AAAAA";
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

    #region CartesianPtpMoveSkillState Class
    #if (!OPCUA_EXCLUDE_CartesianPtpMoveSkillState)
    /// <summary>
    /// Stores an instance of the CartesianPtpMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CartesianPtpMoveSkillState : PtpMoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CartesianPtpMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.CartesianPtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABACEAAABDYXJ0ZXNpYW5QdHBNb3Zl" +
           "U2tpbGxUeXBlSW5zdGFuY2UBAWE8AQFhPGE8AAABAAAAAQDDRAABAaE7GgAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQFiPAAvAQDICmI8AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "YzwALgBEYzwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBZTwALgBEZTwAAAAH" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQFnPAAvAQDPCmc8AAAAFf//" +
           "//8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBaDwALgBEaDwAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAE51bWJlcgEBajwALgBEajwAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRy" +
           "YW5zaXRpb25UaW1lAQFrPAAuAERrPAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxl" +
           "dGFibGUBAXA8AC4ARHA8AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQFx" +
           "PAAuAERxPAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQFyPAAuAERy" +
           "PAAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBdDwALgBEdDwA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAAABgAAAEhhbHRlZAEBhDwALwEAAwmEPAAABAAAAAAzAQEB" +
           "jDwANAEBAZA8ADQBAQGYPAA0AQEBnDwBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBhTwALgBE" +
           "hTwAAAcLAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAFAAAAUmVhZHkBAYY8AC8BAAMJhjwAAAUA" +
           "AAAANAEBAYw8ADMBAQGOPAA0AQEBkjwANAEBAZo8ADMBAQGcPAEAAAAVYKkKAgAAAAAACwAAAFN0YXRl" +
           "TnVtYmVyAQGHPAAuAESHPAAABwwAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAcAAABSdW5uaW5n" +
           "AQGIPAAvAQADCYg8AAAFAAAAADQBAQGOPAAzAQEBkDwAMwEBAZI8ADMBAQGUPAA0AQEBljwBAAAAFWCp" +
           "CgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBiTwALgBEiTwAAAcNAAAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAAAJAAAAU3VzcGVuZGVkAQGKPAAvAQADCYo8AAAEAAAAADQBAQGUPAAzAQEBljwAMwEBAZg8ADMB" +
           "AQGaPAEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQGLPAAuAESLPAAABw4AAAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAA0AAABIYWx0ZWRUb1JlYWR5AQGMPAAvAQAGCYw8AAAEAAAAADMAAQGEPAA0" +
           "AAEBhjwANQABAaI8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAY08AC4A" +
           "RI08AAAHAQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADgAAAFJlYWR5VG9SdW5uaW5nAQGOPAAv" +
           "AQAGCY48AAAEAAAAADMAAQGGPAA0AAEBiDwANQABAZ48ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRy" +
           "YW5zaXRpb25OdW1iZXIBAY88AC4ARI88AAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADwAA" +
           "AFJ1bm5pbmdUb0hhbHRlZAEBkDwALwEABgmQPAAABAAAAAAzAAEBiDwANAABAYQ8ADUAAQGhPAA2AAEA" +
           "SgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGRPAAuAESRPAAABwMAAAAAB/////8B" +
           "Af////8AAAAABGCACgEAAAAAAA4AAABSdW5uaW5nVG9SZWFkeQEBkjwALwEABgmSPAAAAwAAAAAzAAEB" +
           "iDwANAABAYY8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZM8AC4ARJM8" +
           "AAAHBAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBlDwA" +
           "LwEABgmUPAAABAAAAAAzAAEBiDwANAABAYo8ADUAAQGfPAA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQGVPAAuAESVPAAABwUAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABIA" +
           "AABTdXNwZW5kZWRUb1J1bm5pbmcBAZY8AC8BAAYJljwAAAQAAAAAMwABAYo8ADQAAQGIPAA1AAEBoDwA" +
           "NgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBlzwALgBElzwAAAcGAAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAZg8AC8BAAYJmDwAAAQA" +
           "AAAAMwABAYo8ADQAAQGEPAA1AAEBoTwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
           "bWJlcgEBmTwALgBEmTwAAAcHAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAQAAAAU3VzcGVuZGVk" +
           "VG9SZWFkeQEBmjwALwEABgmaPAAAAwAAAAAzAAEBijwANAABAYY8ADYAAQBKCQEAAAAVYKkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBAZs8AC4ARJs8AAAHCAAAAAAH/////wEB/////wAAAAAEYIAKAQAA" +
           "AAAADQAAAFJlYWR5VG9IYWx0ZWQBAZw8AC8BAAYJnDwAAAQAAAAAMwABAYY8ADQAAQGEPAA1AAEBoTwA" +
           "NgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBnTwALgBEnTwAAAcJAAAAAAf/" +
           "////AQH/////AAAAAARhggoEAAAAAAAFAAAAU3RhcnQBAZ48AC8BAHoJnjwAAAEBAQAAAAA1AQEBjjwA" +
           "AAAABGGCCgQAAAAAAAcAAABTdXNwZW5kAQGfPAAvAQB7CZ88AAABAQEAAAAANQEBAZQ8AAAAAARhggoE" +
           "AAAAAAAGAAAAUmVzdW1lAQGgPAAvAQB8CaA8AAABAQEAAAAANQEBAZY8AAAAAARhggoEAAAAAAAEAAAA" +
           "SGFsdAEBoTwALwEAfQmhPAAAAQEDAAAAADUBAQGQPAA1AQEBmDwANQEBAZw8AAAAAARhggoEAAAAAAAF" +
           "AAAAUmVzZXQBAaI8AC8BAH4JojwAAAEBAQAAAAA1AQEBjDwAAAAANWCJCgIAAAACAAQAAABOYW1lAQGj" +
           "PAMAAAAAEQAAAE5hbWUgb2YgdGhlIHNraWxsAC4ARKM8AAAADP////8BAf////8AAAAABGCACgEAAAAD" +
           "AAwAAABQYXJhbWV0ZXJTZXQBAaQ8AC8AOqQ8AAD/////AwAAADVgiQoCAAAAAQAJAAAAVG9vbEZyYW1l" +
           "AQGlPAMAAAAANAAAAFRoZSBuYW1lIG9mIHRoZSB0b29sIGZyYW1lIHRvIGJlIHVzZWQgZm9yIHRoZSBt" +
           "b3Rpb24ALwA/pTwAAAAM/////wMD/////wAAAAA3YIkKAgAAAAEADwAAAE1heEFjY2VsZXJhdGlvbgEB" +
           "pjwDAAAAAEQAAABNYXhpbXVtIGFjY2VsZXJhdGlvbiB0aGUgcm9ib3Qgc2hvdWxkIG1vdmUgaW4gcmFk" +
           "L3NeMiBmb3IgZXZlcnkgYXhpcwAvAQBACaY8AAAACwEAAAABAAAAAAAAAAMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAao8AC4ARKo8AAABAHQD/////wEB/////wAAAAA3YIkKAgAAAAEACwAAAE1h" +
           "eFZlbG9jaXR5AQGsPAMAAAAAPgAAAE1heGltdW0gdmVsb2NpdHkgdGhlIHJvYm90IHNob3VsZCBtb3Zl" +
           "IGluIHJhZC9zIGZvciBldmVyeSBheGlzAC8BAEAJrDwAAAALAQAAAAEAAAAAAAAAAwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBsDwALgBEsDwAAAEAdAP/////AQH/////AAAAAA==";
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

    #region JointPtpMoveSkillState Class
    #if (!OPCUA_EXCLUDE_JointPtpMoveSkillState)
    /// <summary>
    /// Stores an instance of the JointPtpMoveSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JointPtpMoveSkillState : PtpMoveSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public JointPtpMoveSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.JointPtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABAB0AAABKb2ludFB0cE1vdmVTa2ls" +
           "bFR5cGVJbnN0YW5jZQEBsjwBAbI8sjwAAAEAAAABAMNEAAEBtzsaAAAAFWCJCgIAAAAAAAwAAABDdXJy" +
           "ZW50U3RhdGUBAbM8AC8BAMgKszwAAAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQG0PAAu" +
           "AES0PAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQG2PAAuAES2PAAAAAf/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5zaXRpb24BAbg8AC8BAM8KuDwAAAAV/////wEB" +
           "/////wMAAAAVYIkKAgAAAAAAAgAAAElkAQG5PAAuAES5PAAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAGAAAATnVtYmVyAQG7PAAuAES7PAAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNp" +
           "dGlvblRpbWUBAbw8AC4ARLw8AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAERlbGV0YWJs" +
           "ZQEBwTwALgBEwTwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAEF1dG9EZWxldGUBAcI8AC4A" +
           "RMI8AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABSZWN5Y2xlQ291bnQBAcM8AC4ARMM8AAAA" +
           "Bv////8BAf////8AAAAAFWCJCgIAAAAAABAAAABNYXhJbnN0YW5jZUNvdW50AQHFPAAuAETFPAAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAAAGAAAASGFsdGVkAQHVPAAvAQADCdU8AAAEAAAAADMBAQHdPAA0" +
           "AQEB4TwANAEBAek8ADQBAQHtPAEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHWPAAuAETWPAAA" +
           "BwsAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAUAAABSZWFkeQEB1zwALwEAAwnXPAAABQAAAAA0" +
           "AQEB3TwAMwEBAd88ADQBAQHjPAA0AQEB6zwAMwEBAe08AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1i" +
           "ZXIBAdg8AC4ARNg8AAAHDAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABwAAAFJ1bm5pbmcBAdk8" +
           "AC8BAAMJ2TwAAAUAAAAANAEBAd88ADMBAQHhPAAzAQEB4zwAMwEBAeU8ADQBAQHnPAEAAAAVYKkKAgAA" +
           "AAAACwAAAFN0YXRlTnVtYmVyAQHaPAAuAETaPAAABw0AAAAAB/////8BAf////8AAAAABGCACgEAAAAA" +
           "AAkAAABTdXNwZW5kZWQBAds8AC8BAAMJ2zwAAAQAAAAANAEBAeU8ADMBAQHnPAAzAQEB6TwAMwEBAes8" +
           "AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAdw8AC4ARNw8AAAHDgAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAADQAAAEhhbHRlZFRvUmVhZHkBAd08AC8BAAYJ3TwAAAQAAAAAMwABAdU8ADQAAQHX" +
           "PAA1AAEB8zwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB3jwALgBE3jwA" +
           "AAcBAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAOAAAAUmVhZHlUb1J1bm5pbmcBAd88AC8BAAYJ" +
           "3zwAAAQAAAAAMwABAdc8ADQAAQHZPAA1AAEB7zwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNp" +
           "dGlvbk51bWJlcgEB4DwALgBE4DwAAAcCAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAPAAAAUnVu" +
           "bmluZ1RvSGFsdGVkAQHhPAAvAQAGCeE8AAAEAAAAADMAAQHZPAA0AAEB1TwANQABAfI8ADYAAQBKCQEA" +
           "AAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAeI8AC4AROI8AAAHAwAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAAADgAAAFJ1bm5pbmdUb1JlYWR5AQHjPAAvAQAGCeM8AAADAAAAADMAAQHZPAA0" +
           "AAEB1zwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB5DwALgBE5DwAAAcE" +
           "AAAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQHlPAAvAQAG" +
           "CeU8AAAEAAAAADMAAQHZPAA0AAEB2zwANQABAfA8ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAeY8AC4AROY8AAAHBQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAAAFN1" +
           "c3BlbmRlZFRvUnVubmluZwEB5zwALwEABgnnPAAABAAAAAAzAAEB2zwANAABAdk8ADUAAQHxPAA2AAEA" +
           "SgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHoPAAuAEToPAAABwYAAAAAB/////8B" +
           "Af////8AAAAABGCACgEAAAAAABEAAABTdXNwZW5kZWRUb0hhbHRlZAEB6TwALwEABgnpPAAABAAAAAAz" +
           "AAEB2zwANAABAdU8ADUAAQHyPAA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
           "AQHqPAAuAETqPAAABwcAAAAAB/////8BAf////8AAAAABGCACgEAAAAAABAAAABTdXNwZW5kZWRUb1Jl" +
           "YWR5AQHrPAAvAQAGCes8AAADAAAAADMAAQHbPAA0AAEB1zwANgABAEoJAQAAABVgqQoCAAAAAAAQAAAA" +
           "VHJhbnNpdGlvbk51bWJlcgEB7DwALgBE7DwAAAcIAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAN" +
           "AAAAUmVhZHlUb0hhbHRlZAEB7TwALwEABgntPAAABAAAAAAzAAEB1zwANAABAdU8ADUAAQHyPAA2AAEA" +
           "SgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHuPAAuAETuPAAABwkAAAAAB/////8B" +
           "Af////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEB7zwALwEAegnvPAAAAQEBAAAAADUBAQHfPAAAAAAE" +
           "YYIKBAAAAAAABwAAAFN1c3BlbmQBAfA8AC8BAHsJ8DwAAAEBAQAAAAA1AQEB5TwAAAAABGGCCgQAAAAA" +
           "AAYAAABSZXN1bWUBAfE8AC8BAHwJ8TwAAAEBAQAAAAA1AQEB5zwAAAAABGGCCgQAAAAAAAQAAABIYWx0" +
           "AQHyPAAvAQB9CfI8AAABAQMAAAAANQEBAeE8ADUBAQHpPAA1AQEB7TwAAAAABGGCCgQAAAAAAAUAAABS" +
           "ZXNldAEB8zwALwEAfgnzPAAAAQEBAAAAADUBAQHdPAAAAAA1YIkKAgAAAAIABAAAAE5hbWUBAfQ8AwAA" +
           "AAARAAAATmFtZSBvZiB0aGUgc2tpbGwALgBE9DwAAAAM/////wEB/////wAAAAAEYIAKAQAAAAMADAAA" +
           "AFBhcmFtZXRlclNldAEB9TwALwA69TwAAP////8DAAAANWCJCgIAAAABAAkAAABUb29sRnJhbWUBAfY8" +
           "AwAAAAA0AAAAVGhlIG5hbWUgb2YgdGhlIHRvb2wgZnJhbWUgdG8gYmUgdXNlZCBmb3IgdGhlIG1vdGlv" +
           "bgAvAD/2PAAAAAz/////AwP/////AAAAADdgiQoCAAAAAQAPAAAATWF4QWNjZWxlcmF0aW9uAQH3PAMA" +
           "AAAARAAAAE1heGltdW0gYWNjZWxlcmF0aW9uIHRoZSByb2JvdCBzaG91bGQgbW92ZSBpbiByYWQvc14y" +
           "IGZvciBldmVyeSBheGlzAC8BAEAJ9zwAAAALAQAAAAEAAAAAAAAAAwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEB+zwALgBE+zwAAAEAdAP/////AQH/////AAAAADdgiQoCAAAAAQALAAAATWF4VmVs" +
           "b2NpdHkBAf08AwAAAAA+AAAATWF4aW11bSB2ZWxvY2l0eSB0aGUgcm9ib3Qgc2hvdWxkIG1vdmUgaW4g" +
           "cmFkL3MgZm9yIGV2ZXJ5IGF4aXMALwEAQAn9PAAAAAsBAAAAAQAAAAAAAAADA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEBPQAuAEQBPQAAAQB0A/////8BAf////8AAAAA";
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

    #region StreamSkillState Class
    #if (!OPCUA_EXCLUDE_StreamSkillState)
    /// <summary>
    /// Stores an instance of the StreamSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StreamSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StreamSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.StreamSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABABcAAABTdHJlYW1Ta2lsbFR5cGVJ" +
           "bnN0YW5jZQEBAz0BAQM9Az0AAP////8ZAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQQ9AC8B" +
           "AMgKBD0AAAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQEFPQAuAEQFPQAAABH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQEHPQAuAEQHPQAAAAf/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAOAAAATGFzdFRyYW5zaXRpb24BAQk9AC8BAM8KCT0AAAAV/////wEB/////wMAAAAVYIkKAgAA" +
           "AAAAAgAAAElkAQEKPQAuAEQKPQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQEM" +
           "PQAuAEQMPQAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAQ09AC4A" +
           "RA09AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAERlbGV0YWJsZQEBEj0ALgBEEj0AAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAEF1dG9EZWxldGUBARM9AC4ARBM9AAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABSZWN5Y2xlQ291bnQBARQ9AC4ARBQ9AAAABv////8BAf////8AAAAA" +
           "FWCJCgIAAAAAABAAAABNYXhJbnN0YW5jZUNvdW50AQEWPQAuAEQWPQAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAAGAAAASGFsdGVkAQEmPQAvAQADCSY9AAAEAAAAADMBAQEuPQA0AQEBMj0ANAEBATo9ADQB" +
           "AQE+PQEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQEnPQAuAEQnPQAABwsAAAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAAUAAABSZWFkeQEBKD0ALwEAAwkoPQAABQAAAAA0AQEBLj0AMwEBATA9ADQB" +
           "AQE0PQA0AQEBPD0AMwEBAT49AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBASk9AC4ARCk9AAAH" +
           "DAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAABwAAAFJ1bm5pbmcBASo9AC8BAAMJKj0AAAUAAAAA" +
           "NAEBATA9ADMBAQEyPQAzAQEBND0AMwEBATY9ADQBAQE4PQEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVt" +
           "YmVyAQErPQAuAEQrPQAABw0AAAAAB/////8BAf////8AAAAABGCACgEAAAAAAAkAAABTdXNwZW5kZWQB" +
           "ASw9AC8BAAMJLD0AAAQAAAAANAEBATY9ADMBAQE4PQAzAQEBOj0AMwEBATw9AQAAABVgqQoCAAAAAAAL" +
           "AAAAU3RhdGVOdW1iZXIBAS09AC4ARC09AAAHDgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAADQAA" +
           "AEhhbHRlZFRvUmVhZHkBAS49AC8BAAYJLj0AAAQAAAAAMwABASY9ADQAAQEoPQA1AAEBRD0ANgABAEoJ" +
           "AQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBLz0ALgBELz0AAAcBAAAAAAf/////AQH/" +
           "////AAAAAARggAoBAAAAAAAOAAAAUmVhZHlUb1J1bm5pbmcBATA9AC8BAAYJMD0AAAQAAAAAMwABASg9" +
           "ADQAAQEqPQA1AAEBQD0ANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBMT0A" +
           "LgBEMT0AAAcCAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAPAAAAUnVubmluZ1RvSGFsdGVkAQEy" +
           "PQAvAQAGCTI9AAAEAAAAADMAAQEqPQA0AAEBJj0ANQABAUM9ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAA" +
           "AFRyYW5zaXRpb25OdW1iZXIBATM9AC4ARDM9AAAHAwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAA" +
           "DgAAAFJ1bm5pbmdUb1JlYWR5AQE0PQAvAQAGCTQ9AAADAAAAADMAAQEqPQA0AAEBKD0ANgABAEoJAQAA" +
           "ABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBNT0ALgBENT0AAAcEAAAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAAASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQE2PQAvAQAGCTY9AAAEAAAAADMAAQEq" +
           "PQA0AAEBLD0ANQABAUE9ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBATc9" +
           "AC4ARDc9AAAHBQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEgAAAFN1c3BlbmRlZFRvUnVubmlu" +
           "ZwEBOD0ALwEABgk4PQAABAAAAAAzAAEBLD0ANAABASo9ADUAAQFCPQA2AAEASgkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQE5PQAuAEQ5PQAABwYAAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAAAABEAAABTdXNwZW5kZWRUb0hhbHRlZAEBOj0ALwEABgk6PQAABAAAAAAzAAEBLD0ANAABASY9ADUA" +
           "AQFDPQA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQE7PQAuAEQ7PQAABwcA" +
           "AAAAB/////8BAf////8AAAAABGCACgEAAAAAABAAAABTdXNwZW5kZWRUb1JlYWR5AQE8PQAvAQAGCTw9" +
           "AAADAAAAADMAAQEsPQA0AAEBKD0ANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgEBPT0ALgBEPT0AAAcIAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAANAAAAUmVhZHlUb0hhbHRl" +
           "ZAEBPj0ALwEABgk+PQAABAAAAAAzAAEBKD0ANAABASY9ADUAAQFDPQA2AAEASgkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQE/PQAuAEQ/PQAABwkAAAAAB/////8BAf////8AAAAABGGCCgQA" +
           "AAAAAAUAAABTdGFydAEBQD0ALwEAeglAPQAAAQEBAAAAADUBAQEwPQAAAAAEYYIKBAAAAAAABwAAAFN1" +
           "c3BlbmQBAUE9AC8BAHsJQT0AAAEBAQAAAAA1AQEBNj0AAAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAUI9" +
           "AC8BAHwJQj0AAAEBAQAAAAA1AQEBOD0AAAAABGGCCgQAAAAAAAQAAABIYWx0AQFDPQAvAQB9CUM9AAAB" +
           "AQMAAAAANQEBATI9ADUBAQE6PQA1AQEBPj0AAAAABGGCCgQAAAAAAAUAAABSZXNldAEBRD0ALwEAfglE" +
           "PQAAAQEBAAAAADUBAQEuPQAAAAA1YIkKAgAAAAIABAAAAE5hbWUBAUU9AwAAAAARAAAATmFtZSBvZiB0" +
           "aGUgc2tpbGwALgBERT0AAAAM/////wEB/////wAAAAA=";
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

    #region PositionStreamSkillState Class
    #if (!OPCUA_EXCLUDE_PositionStreamSkillState)
    /// <summary>
    /// Stores an instance of the PositionStreamSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionStreamSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PositionStreamSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.PositionStreamSkillType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABAB8AAABQb3NpdGlvblN0cmVhbVNr" +
           "aWxsVHlwZUluc3RhbmNlAQFGPQEBRj1GPQAA/////xoAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0" +
           "ZQEBRz0ALwEAyApHPQAAABX/////AQH/////AgAAABVgiQoCAAAAAAACAAAASWQBAUg9AC4AREg9AAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAUo9AC4AREo9AAAAB/////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlvbgEBTD0ALwEAzwpMPQAAABX/////AQH/////AwAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAU09AC4ARE09AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABO" +
           "dW1iZXIBAU89AC4ARE89AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGlt" +
           "ZQEBUD0ALgBEUD0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQFVPQAu" +
           "AERVPQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQEBVj0ALgBEVj0AAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJlY3ljbGVDb3VudAEBVz0ALgBEVz0AAAAG/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAAEAAAAE1heEluc3RhbmNlQ291bnQBAVk9AC4ARFk9AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAAYAAABIYWx0ZWQBAWk9AC8BAAMJaT0AAAQAAAAAMwEBAXE9ADQBAQF1PQA0" +
           "AQEBfT0ANAEBAYE9AQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAWo9AC4ARGo9AAAHCwAAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAAABQAAAFJlYWR5AQFrPQAvAQADCWs9AAAFAAAAADQBAQFxPQAz" +
           "AQEBcz0ANAEBAXc9ADQBAQF/PQAzAQEBgT0BAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBbD0A" +
           "LgBEbD0AAAcMAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAAHAAAAUnVubmluZwEBbT0ALwEAAwlt" +
           "PQAABQAAAAA0AQEBcz0AMwEBAXU9ADMBAQF3PQAzAQEBeT0ANAEBAXs9AQAAABVgqQoCAAAAAAALAAAA" +
           "U3RhdGVOdW1iZXIBAW49AC4ARG49AAAHDQAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAACQAAAFN1" +
           "c3BlbmRlZAEBbz0ALwEAAwlvPQAABAAAAAA0AQEBeT0AMwEBAXs9ADMBAQF9PQAzAQEBfz0BAAAAFWCp" +
           "CgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBcD0ALgBEcD0AAAcOAAAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAAANAAAASGFsdGVkVG9SZWFkeQEBcT0ALwEABglxPQAABAAAAAAzAAEBaT0ANAABAWs9ADUAAQGH" +
           "PQA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFyPQAuAERyPQAABwEAAAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAAAAA4AAABSZWFkeVRvUnVubmluZwEBcz0ALwEABglzPQAABAAA" +
           "AAAzAAEBaz0ANAABAW09ADUAAQGDPQA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQF0PQAuAER0PQAABwIAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA8AAABSdW5uaW5nVG9I" +
           "YWx0ZWQBAXU9AC8BAAYJdT0AAAQAAAAAMwABAW09ADQAAQFpPQA1AAEBhj0ANgABAEoJAQAAABVgqQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBdj0ALgBEdj0AAAcDAAAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAAAOAAAAUnVubmluZ1RvUmVhZHkBAXc9AC8BAAYJdz0AAAMAAAAAMwABAW09ADQAAQFrPQA2" +
           "AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQF4PQAuAER4PQAABwQAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAAAABIAAABSdW5uaW5nVG9TdXNwZW5kZWQBAXk9AC8BAAYJeT0AAAQA" +
           "AAAAMwABAW09ADQAAQFvPQA1AAEBhD0ANgABAEoJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
           "bWJlcgEBej0ALgBEej0AAAcFAAAAAAf/////AQH/////AAAAAARggAoBAAAAAAASAAAAU3VzcGVuZGVk" +
           "VG9SdW5uaW5nAQF7PQAvAQAGCXs9AAAEAAAAADMAAQFvPQA0AAEBbT0ANQABAYU9ADYAAQBKCQEAAAAV" +
           "YKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAXw9AC4ARHw9AAAHBgAAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAAAEQAAAFN1c3BlbmRlZFRvSGFsdGVkAQF9PQAvAQAGCX09AAAEAAAAADMAAQFvPQA0" +
           "AAEBaT0ANQABAYY9ADYAAQBKCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAX49AC4A" +
           "RH49AAAHBwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAAAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAX89" +
           "AC8BAAYJfz0AAAMAAAAAMwABAW89ADQAAQFrPQA2AAEASgkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0" +
           "aW9uTnVtYmVyAQGAPQAuAESAPQAABwgAAAAAB/////8BAf////8AAAAABGCACgEAAAAAAA0AAABSZWFk" +
           "eVRvSGFsdGVkAQGBPQAvAQAGCYE9AAAEAAAAADMAAQFrPQA0AAEBaT0ANQABAYY9ADYAAQBKCQEAAAAV" +
           "YKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAYI9AC4ARII9AAAHCQAAAAAH/////wEB/////wAA" +
           "AAAEYYIKBAAAAAAABQAAAFN0YXJ0AQGDPQAvAQB6CYM9AAABAQEAAAAANQEBAXM9AAAAAARhggoEAAAA" +
           "AAAHAAAAU3VzcGVuZAEBhD0ALwEAewmEPQAAAQEBAAAAADUBAQF5PQAAAAAEYYIKBAAAAAAABgAAAFJl" +
           "c3VtZQEBhT0ALwEAfAmFPQAAAQEBAAAAADUBAQF7PQAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAYY9AC8B" +
           "AH0Jhj0AAAEBAwAAAAA1AQEBdT0ANQEBAX09ADUBAQGBPQAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQGH" +
           "PQAvAQB+CYc9AAABAQEAAAAANQEBAXE9AAAAADVgiQoCAAAAAgAEAAAATmFtZQEBiD0DAAAAABEAAABO" +
           "YW1lIG9mIHRoZSBza2lsbAAuAESIPQAAAAz/////AQH/////AAAAAARggAoBAAAAAwAMAAAAUGFyYW1l" +
           "dGVyU2V0AQGJPQAvADqJPQAA/////wEAAAA1YIkKAgAAAAEADgAAAFRhcmdldFBvc2l0aW9uAQGKPQMA" +
           "AAAA4QAAAEFic29sdXRlIHBvc2l0aW9uIGluIGNhcnRlc2lhbiBzcGFjZSB3aGVyZSB0aGUgcm9ib3Qg" +
           "c2hvdWxkIG1vdmUgdG8uCiAgICAgICAgICAgICAgQXMgc29vbiBhcyB0aGVyZSBpcyBhIG5ldyB2YWx1" +
           "ZSB3cml0dGVuIHRvIHRoaXMgdmFyaWFibGUsIHRoZSByb2JvdCB3aWxsIG1vdmUgdG8gdGhhdCBwb3Np" +
           "dGlvbiBpZiB0aGUKICAgICAgICAgICAgICBza2lsbCBpcyBpbiBydW5uaW5nIHN0YXRlLgAvAQBnSYo9" +
           "AAABAH5J/////wMD/////wIAAAAVYIkKAgAAAAAAFAAAAENhcnRlc2lhbkNvb3JkaW5hdGVzAQGLPQAv" +
           "AQBWSYs9AAABAHpJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAFgBAZI9AC8AP5I9AAAAC/////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAEAAABZAQGTPQAvAD+TPQAAAAv/////AQH/////AAAAABVgiQoCAAAA" +
           "AAABAAAAWgEBlD0ALwA/lD0AAAAL/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAE9yaWVudGF0aW9u" +
           "AQGNPQAvAQBdSY09AAABAHxJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAEEBAZU9AC8AP5U9AAAA" +
           "C/////8BAf////8AAAAAFWCJCgIAAAAAAAEAAABCAQGWPQAvAD+WPQAAAAv/////AQH/////AAAAABVg" +
           "iQoCAAAAAAABAAAAQwEBlz0ALwA/lz0AAAAL/////wEB/////wAAAAA=";
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

    #region FortissMotionDeviceState Class
    #if (!OPCUA_EXCLUDE_FortissMotionDeviceState)
    /// <summary>
    /// Stores an instance of the FortissMotionDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FortissMotionDeviceState : MotionDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FortissMotionDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss.Robotics.ObjectTypes.FortissMotionDeviceType, fortiss.Robotics.Namespaces.fortissRobotics, namespaceUris);
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
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGCAAgEAAAABAB8AAABGb3J0aXNzTW90aW9uRGV2" +
           "aWNlVHlwZUluc3RhbmNlAQGYPQEBmD2YPQAA/////wwAAAAkYIAKAQAAAAMADAAAAFBhcmFtZXRlclNl" +
           "dAEBmT0DAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADqZPQAA/////wQAAAA1YIkKAgAA" +
           "AAQADQAAAFNwZWVkT3ZlcnJpZGUBAcA9AwAAAABbAAAAU3BlZWRPdmVycmlkZSBwcm92aWRlcyB0aGUg" +
           "Y3VycmVudCBzcGVlZCBzZXR0aW5nIGluIHBlcmNlbnQgb2YgcHJvZ3JhbW1lZCBzcGVlZCAoMCAtIDEw" +
           "MCUpLgAvAD/APQAAAAv/////AQH/////AAAAADVgiQoCAAAABAAMAAAARGV2aWNlT25QYXRoAQGIPgMA" +
           "AAAA4QAAAFRoZSBEZXZpY2VPblBhdGggaW5kaWNhdGVzIHdoZXRoZXIgdGhlIG1vdGlvbiBkZXZpY2Ug" +
           "aXMgb24gdGhlIHBsYW5uZWQgcHJvZ3JhbQogICAgICAgICAgICAgIHBhdGg6InRydWUiLlxuSWYgdGhl" +
           "IE1vdGlvbkRldmljZSBsZWF2ZXMgdGhpcyBwYXRoIGluIHRoZSBmYWlsdXJlIGNhc2Ugb3IgaW4gYW4g" +
           "ZW1lcmdlbmN5CiAgICAgICAgICAgICAgc3RvcCwgdGhpcyB2YWx1ZSBpcyAiZmFsc2UiLgAvAD+IPgAA" +
           "AAH/////AQH/////AAAAADVgiQoCAAAABAAVAAAAUHJvZ3JhbW1lZERldmljZVNwZWVkAQGJPgMAAAAA" +
           "RQAAAFByb2dyYW1tZWREZXZpY2VTcGVlZCBpcyB0aGUgcHJvZ3JhbW1lZCBtb3Rpb24gZGV2aWNlIHNw" +
           "ZWVkICgwLTEwMCUpLgAvAD+JPgAAAAb/////AQH/////AAAAADVgiQoCAAAABAAMAAAAVW5kZXJDb250" +
           "cm9sAQGKPgMAAAAApgAAAEF4aXNVbmRlckNvbnRyb2wgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIGFjdHVh" +
           "dG9ycyBvZiB0aGUgTW90aW9uRGV2aWNlIGFyZSB1bmRlcgogICAgICAgICAgICAgIHBvd2VyIGFuZCBj" +
           "b250cm9sOiJ0cnVlIi5cblRoZSBNb3Rpb25EZXZpY2UgY2FuIGhvd2V2ZXIgYmUgYXQgc3RhbmRzdGls" +
           "bC4ALwA/ij4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAMADAAAAE1hbnVmYWN0dXJlcgEBrz0ALgBE" +
           "rz0AAAAV/////wEB/////wAAAAAVYIkKAgAAAAMABQAAAE1vZGVsAQGxPQAuAESxPQAAABX/////AQH/" +
           "////AAAAABVgiQoCAAAAAwALAAAAUHJvZHVjdENvZGUBAbU9AC4ARLU9AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAADAAwAAABTZXJpYWxOdW1iZXIBAbg9AC4ARLg9AAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAAEABQAAABNb3Rpb25EZXZpY2VDYXRlZ29yeQEBvT0DAAAAAIIAAABUaGUgdmFyaWFibGUgTW90aW9u" +
           "RGV2aWNlQ2F0ZWdvcnkgcHJvdmlkZXMgdGhlIGtpbmQgb2YgbW90aW9uIGRldmljZSBkZWZpbmVkIGJ5" +
           "IE1vdGlvbkRldmljZUNhdGVnb3J5RW51bWVyYXRpb24gYmFzZWQgb24gSVNPIDgzNzMuAC4ARL09AAAB" +
           "BBFH/////wEB/////wAAAAAkYIAKAQAAAAQABAAAAEF4ZXMBAcE9AwAAAAA+AAAAQXhlcyBpcyBhIGNv" +
           "bnRhaW5lciBmb3Igb25lIG9yIG1vcmUgaW5zdGFuY2VzIG9mIHRoZSBBeGlzVHlwZS4ALwA9wT0AAP//" +
           "//8AAAAAJGCACgEAAAAEAAsAAABQb3dlclRyYWlucwEBEj4DAAAAAEsAAABQb3dlclRyYWlucyBpcyBh" +
           "IGNvbnRhaW5lciBmb3Igb25lIG9yIG1vcmUgaW5zdGFuY2VzIG9mIHRoZSBQb3dlclRyYWluVHlwZS4A" +
           "LwA9Ej4AAP////8AAAAAJGCACgEAAAAEAAoAAABGbGFuZ2VMb2FkAQE2PgMAAAAAkwAAAFRoZSBGbGFu" +
           "Z2VMb2FkIGlzIHRoZSBsb2FkIG9uIHRoZSBmbGFuZ2Ugb3IgYXQgdGhlIG1vdW50aW5nIHBvaW50IG9m" +
           "IHRoZQogICAgICAgICAgTW90aW9uRGV2aWNlLlxuVGhpcyBjYW4gYmUgdGhlIG1heGltdW0gbG9hZCBv" +
           "ZiB0aGUgTW90aW9uRGV2aWNlLgAvAQT6AzY+AAD/////AwAAADVgiQoCAAAABAAEAAAATWFzcwEBNz4D" +
           "AAAAADUAAABUaGUgd2VpZ2h0IG9mIHRoZSBsb2FkIG1vdW50ZWQgb24gb25lIG1vdW50aW5nIHBvaW50" +
           "LgAvAQBZRDc+AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQE8" +
           "PgAuAEQ8PgAAAQB3A/////8BAf////8AAAAANWCJCgIAAAAEAAwAAABDZW50ZXJPZk1hc3MBAT0+AwAA" +
           "AACMAQAAVGhlIHBvc2l0aW9uIGFuZCBvcmllbnRhdGlvbiBvZiB0aGUgY2VudGVyIG9mIHRoZSBtYXNz" +
           "IHJlbGF0ZWQgdG8gdGhlIG1vdW50aW5nIHBvaW50IHVzaW5nIGEgRnJhbWVUeXBlLiBYLCBZLCBaIGRl" +
           "ZmluZSB0aGUgcG9zaXRpb24gb2YgdGhlIGNlbnRlciBvZiBncmF2aXR5IHJlbGF0aXZlIHRvIHRoZSBt" +
           "b3VudGluZyBwb2ludCBjb29yZGluYXRlIHN5c3RlbS4gQSwgQiwgQyBkZWZpbmUgdGhlIG9yaWVudGF0" +
           "aW9uIG9mIHRoZSBwcmluY2lwYWwgYXhlcyBvZiBpbmVydGlhIHJlbGF0aXZlIHRvIHRoZSBtb3VudGlu" +
           "ZyBwb2ludCBjb29yZGluYXRlIHN5c3RlbS4gT3JpZW50YXRpb24gQSwgQiwgQyBjYW4gYmUgIjAiIGZv" +
           "ciBzeXN0ZW1zIHdoaWNoIGRvIG5vdCBuZWVkIHRoZXNlICB2YWx1ZXMuAC8BAGdJPT4AAAEAfkn/////" +
           "AQH/////AgAAABVgiQoCAAAAAAAUAAAAQ2FydGVzaWFuQ29vcmRpbmF0ZXMBAT4+AC8BAFZJPj4AAAEA" +
           "ekn/////AQH/////AwAAABVgiQoCAAAAAAABAAAAWAEBRT4ALwA/RT4AAAAL/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAAQAAAFkBAUY+AC8AP0Y+AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAEAAABaAQFH" +
           "PgAvAD9HPgAAAAv/////AQH/////AAAAABVgiQoCAAAAAAALAAAAT3JpZW50YXRpb24BAUA+AC8BAF1J" +
           "QD4AAAEAfEn/////AQH/////AwAAABVgiQoCAAAAAAABAAAAQQEBSD4ALwA/SD4AAAAL/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAAAQAAAEIBAUk+AC8AP0k+AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAEA" +
           "AABDAQFKPgAvAD9KPgAAAAv/////AQH/////AAAAADVgiQoCAAAABAAHAAAASW5lcnRpYQEBSz4DAAAA" +
           "APoAAABUaGUgSW5lcnRpYSB1c2VzIHRoZSBWZWN0b3JUeXBlIHRvIGRlc2NyaWJlIHRoZSB0aHJlZSB2" +
           "YWx1ZXMgb2YgdGhlIHByaW5jaXBhbCBtb21lbnRzIG9mIGluZXJ0aWEgd2l0aCByZXNwZWN0IHRvIHRo" +
           "ZSBtb3VudGluZyBwb2ludCBjb29yZGluYXRlIHN5c3RlbS4gSWYgaW5lcnRpYSB2YWx1ZXMgYXJlIHBy" +
           "b3ZpZGVkIGZvciByb3RhcnkgYXhpcyB0aGUgQ2VudGVyT2ZNYXNzIHNoYWxsIGJlIGNvbXBsZXRlbHkg" +
           "ZmlsbGVkIGFzIHdlbGwuAC8BADRFSz4AAAEAeEn/////AQH/////AwAAABVgiQoCAAAAAAABAAAAWAEB" +
           "TT4ALwA/TT4AAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAFkBAU4+AC8AP04+AAAAC/////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAEAAABaAQFPPgAvAD9PPgAAAAv/////AQH/////AAAAAARhggoEAAAA" +
           "AQANAAAARmxhbmdlVG9vbFNldAEBdD4ALwEBdD50PgAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAXU+AC4ARHU+AACWBQAAAAEAKgEBEwAAAAQAAABOYW1lAAz/////AAAAAAABACoB" +
           "ARYAAAAFAAAARnJhbWUBAH5J/////wAAAAAAAQAqAQETAAAABAAAAE1hc3MAC/////8AAAAAAAEAKgEB" +
           "HQAAAAwAAABDZW50ZXJPZk1hc3MBAH5J/////wAAAAAAAQAqAQEYAAAABwAAAEluZXJ0aWEBAHhJ////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEADwAAAEZsYW5nZVRvb2xDbGVh" +
           "cgEBdj4ALwEBdj52PgAAAQH/////AAAAAARggAoBAAAAAQAKAAAARmxhbmdlVG9vbAEBeD4ALwA6eD4A" +
           "AP////8CAAAAFWCJCgIAAAAEAAQAAABOYW1lAQF5PgAuAER5PgAAAAz/////AQH/////AAAAABVgyQoC" +
           "AAAACwAAAFRocmVlREZyYW1lAAAHAAAAM0RGcmFtZQEBej4ALwEAZ0l6PgAAAQB+Sf////8BAf////8C" +
           "AAAAFWCJCgIAAAAAABQAAABDYXJ0ZXNpYW5Db29yZGluYXRlcwEBez4ALwEAVkl7PgAAAQB6Sf////8B" +
           "Af////8DAAAAFWCJCgIAAAAAAAEAAABYAQGCPgAvAD+CPgAAAAv/////AQH/////AAAAABVgiQoCAAAA" +
           "AAABAAAAWQEBgz4ALwA/gz4AAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAFoBAYQ+AC8AP4Q+" +
           "AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABPcmllbnRhdGlvbgEBfT4ALwEAXUl9PgAAAQB8" +
           "Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABBAQGFPgAvAD+FPgAAAAv/////AQH/////AAAAABVg" +
           "iQoCAAAAAAABAAAAQgEBhj4ALwA/hj4AAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAEMBAYc+" +
           "AC8AP4c+AAAAC/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FlangeToolSetMethodState FlangeToolSet
        {
            get
            {
                return m_flangeToolSetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_flangeToolSetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_flangeToolSetMethod = value;
            }
        }

        /// <remarks />
        public MethodState FlangeToolClear
        {
            get
            {
                return m_flangeToolClearMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_flangeToolClearMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_flangeToolClearMethod = value;
            }
        }

        /// <remarks />
        public BaseObjectState FlangeTool
        {
            get
            {
                return m_flangeTool;
            }

            set
            {
                if (!Object.ReferenceEquals(m_flangeTool, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_flangeTool = value;
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
            if (m_flangeToolSetMethod != null)
            {
                children.Add(m_flangeToolSetMethod);
            }

            if (m_flangeToolClearMethod != null)
            {
                children.Add(m_flangeToolClearMethod);
            }

            if (m_flangeTool != null)
            {
                children.Add(m_flangeTool);
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
                case fortiss.Robotics.BrowseNames.FlangeToolSet:
                {
                    if (createOrReplace)
                    {
                        if (FlangeToolSet == null)
                        {
                            if (replacement == null)
                            {
                                FlangeToolSet = new FlangeToolSetMethodState(this);
                            }
                            else
                            {
                                FlangeToolSet = (FlangeToolSetMethodState)replacement;
                            }
                        }
                    }

                    instance = FlangeToolSet;
                    break;
                }

                case fortiss.Robotics.BrowseNames.FlangeToolClear:
                {
                    if (createOrReplace)
                    {
                        if (FlangeToolClear == null)
                        {
                            if (replacement == null)
                            {
                                FlangeToolClear = new MethodState(this);
                            }
                            else
                            {
                                FlangeToolClear = (MethodState)replacement;
                            }
                        }
                    }

                    instance = FlangeToolClear;
                    break;
                }

                case fortiss.Robotics.BrowseNames.FlangeTool:
                {
                    if (createOrReplace)
                    {
                        if (FlangeTool == null)
                        {
                            if (replacement == null)
                            {
                                FlangeTool = new BaseObjectState(this);
                            }
                            else
                            {
                                FlangeTool = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = FlangeTool;
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
        private FlangeToolSetMethodState m_flangeToolSetMethod;
        private MethodState m_flangeToolClearMethod;
        private BaseObjectState m_flangeTool;
        #endregion
    }
    #endif
    #endregion

    #region FlangeToolSetMethodState Class
    #if (!OPCUA_EXCLUDE_FlangeToolSetMethodState)
    /// <summary>
    /// Stores an instance of the FlangeToolSetMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlangeToolSetMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlangeToolSetMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new FlangeToolSetMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "BAAAACAAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1JvYm90aWNzLxoAAABodHRwczovL2ZvcnRpc3Mu" +
           "b3JnL1VBL0RJLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJQAAAGh0dHA6Ly9vcGNm" +
           "b3VuZGF0aW9uLm9yZy9VQS9Sb2JvdGljcy//////BGGCCgQAAAABABcAAABGbGFuZ2VUb29sU2V0TWV0" +
           "aG9kVHlwZQEBiz4ALwEBiz6LPgAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AYw+AC4ARIw+AACWBQAAAAEAKgEBEwAAAAQAAABOYW1lAAz/////AAAAAAABACoBARYAAAAFAAAARnJh" +
           "bWUBAH5J/////wAAAAAAAQAqAQETAAAABAAAAE1hc3MAC/////8AAAAAAAEAKgEBHQAAAAwAAABDZW50" +
           "ZXJPZk1hc3MBAH5J/////wAAAAAAAQAqAQEYAAAABwAAAEluZXJ0aWEBAHhJ/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public FlangeToolSetMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string name = (string)_inputArguments[0];
            ThreeDFrame frame = (ThreeDFrame)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[1]);
            double mass = (double)_inputArguments[2];
            ThreeDFrame centerOfMass = (ThreeDFrame)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[3]);
            ThreeDVector inertia = (ThreeDVector)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[4]);

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    name,
                    frame,
                    mass,
                    centerOfMass,
                    inertia);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult FlangeToolSetMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string name,
        ThreeDFrame frame,
        double mass,
        ThreeDFrame centerOfMass,
        ThreeDVector inertia);
    #endif
    #endregion
}