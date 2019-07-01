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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using fortiss.Di;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Robotics;

namespace fortiss.Robotics
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Open = 15015;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Close = 15018;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Read = 15020;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Write = 15023;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition = 15025;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition = 15028;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_InitLock = 15782;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_RenewLock = 15785;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_ExitLock = 15787;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_BreakLock = 15789;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock = 15822;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock = 15825;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock = 15827;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock = 15829;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock = 15903;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = 15906;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = 15908;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = 15910;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = 15965;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = 15968;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = 15970;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = 15972;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolSet Method.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeToolSet = 15988;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolClear Method.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeToolClear = 15990;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata Object.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata = 15001;

        /// <summary>
        /// The identifier for the MoveSkillType_ParameterSet Object.
        /// </summary>
        public const uint MoveSkillType_ParameterSet = 15101;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet Object.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet = 15170;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet Object.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet = 15251;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet Object.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet = 15266;

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet Object.
        /// </summary>
        public const uint IJointMoveSkillParameterType_ParameterSet = 15288;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet Object.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet = 15753;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet Object.
        /// </summary>
        public const uint FortissMotionDeviceType_ParameterSet = 15769;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet = 15811;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad Object.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad = 15926;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool Object.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool = 15992;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the MoveSkillType ObjectType.
        /// </summary>
        public const uint MoveSkillType = 15034;

        /// <summary>
        /// The identifier for the LinearMoveSkillType ObjectType.
        /// </summary>
        public const uint LinearMoveSkillType = 15103;

        /// <summary>
        /// The identifier for the PtpMoveSkillType ObjectType.
        /// </summary>
        public const uint PtpMoveSkillType = 15184;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType ObjectType.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType = 15265;

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType ObjectType.
        /// </summary>
        public const uint IJointMoveSkillParameterType = 15287;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType ObjectType.
        /// </summary>
        public const uint CartesianLinearMoveSkillType = 15295;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType ObjectType.
        /// </summary>
        public const uint JointLinearMoveSkillType = 15376;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType ObjectType.
        /// </summary>
        public const uint CartesianPtpMoveSkillType = 15457;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType ObjectType.
        /// </summary>
        public const uint JointPtpMoveSkillType = 15538;

        /// <summary>
        /// The identifier for the StreamSkillType ObjectType.
        /// </summary>
        public const uint StreamSkillType = 15619;

        /// <summary>
        /// The identifier for the PositionStreamSkillType ObjectType.
        /// </summary>
        public const uint PositionStreamSkillType = 15686;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType ObjectType.
        /// </summary>
        public const uint FortissMotionDeviceType = 15768;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceUri = 15002;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceVersion = 15003;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespacePublicationDate = 15004;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_IsNamespaceSubset = 15005;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Size = 15010;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Writable = 15011;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_UserWritable = 15012;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_OpenCount = 15013;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Open_InputArguments = 15016;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Close_InputArguments = 15019;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Read_InputArguments = 15021;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15022;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_Write_InputArguments = 15024;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15026;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15027;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15029;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_DefaultRolePermissions = 15031;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_DefaultUserRolePermissions = 15032;

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint FortissRoboticsNamespaceMetadata_DefaultAccessRestrictions = 15033;

        /// <summary>
        /// The identifier for the MoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint MoveSkillType_CurrentState_Id = 15036;

        /// <summary>
        /// The identifier for the MoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint MoveSkillType_CurrentState_Number = 15038;

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint MoveSkillType_LastTransition_Id = 15041;

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint MoveSkillType_LastTransition_Number = 15043;

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MoveSkillType_LastTransition_TransitionTime = 15044;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_CreateSessionId = 15056;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_CreateClientName = 15057;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15058;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastTransitionTime = 15059;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodCall = 15060;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15061;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15062;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15063;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15064;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15065;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15066;

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint MoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15067;

        /// <summary>
        /// The identifier for the MoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint MoveSkillType_Halted_StateNumber = 15070;

        /// <summary>
        /// The identifier for the MoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint MoveSkillType_Ready_StateNumber = 15072;

        /// <summary>
        /// The identifier for the MoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint MoveSkillType_Running_StateNumber = 15074;

        /// <summary>
        /// The identifier for the MoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MoveSkillType_Suspended_StateNumber = 15076;

        /// <summary>
        /// The identifier for the MoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_HaltedToReady_TransitionNumber = 15078;

        /// <summary>
        /// The identifier for the MoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_ReadyToRunning_TransitionNumber = 15080;

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_RunningToHalted_TransitionNumber = 15082;

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_RunningToReady_TransitionNumber = 15084;

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_RunningToSuspended_TransitionNumber = 15086;

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_SuspendedToRunning_TransitionNumber = 15088;

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_SuspendedToHalted_TransitionNumber = 15090;

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_SuspendedToReady_TransitionNumber = 15092;

        /// <summary>
        /// The identifier for the MoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveSkillType_ReadyToHalted_TransitionNumber = 15094;

        /// <summary>
        /// The identifier for the MoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint MoveSkillType_ParameterSet_ToolFrame = 15102;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint LinearMoveSkillType_CurrentState_Id = 15105;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint LinearMoveSkillType_CurrentState_Number = 15107;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint LinearMoveSkillType_LastTransition_Id = 15110;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint LinearMoveSkillType_LastTransition_Number = 15112;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LinearMoveSkillType_LastTransition_TransitionTime = 15113;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_CreateSessionId = 15125;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_CreateClientName = 15126;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15127;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15128;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodCall = 15129;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15130;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15131;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15132;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15133;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15134;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15135;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15136;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_Halted_StateNumber = 15139;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_Ready_StateNumber = 15141;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_Running_StateNumber = 15143;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_Suspended_StateNumber = 15145;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_HaltedToReady_TransitionNumber = 15147;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ReadyToRunning_TransitionNumber = 15149;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_RunningToHalted_TransitionNumber = 15151;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_RunningToReady_TransitionNumber = 15153;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_RunningToSuspended_TransitionNumber = 15155;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_SuspendedToRunning_TransitionNumber = 15157;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_SuspendedToHalted_TransitionNumber = 15159;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_SuspendedToReady_TransitionNumber = 15161;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ReadyToHalted_TransitionNumber = 15163;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet_ToolFrame = 15171;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet_MaxAcceleration = 15172;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15176;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet_MaxVelocity = 15178;

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint LinearMoveSkillType_ParameterSet_MaxVelocity_EURange = 15182;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint PtpMoveSkillType_CurrentState_Id = 15186;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint PtpMoveSkillType_CurrentState_Number = 15188;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint PtpMoveSkillType_LastTransition_Id = 15191;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint PtpMoveSkillType_LastTransition_Number = 15193;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint PtpMoveSkillType_LastTransition_TransitionTime = 15194;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_CreateSessionId = 15206;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_CreateClientName = 15207;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15208;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15209;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodCall = 15210;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15211;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15212;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15213;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15214;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15215;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15216;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15217;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_Halted_StateNumber = 15220;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_Ready_StateNumber = 15222;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_Running_StateNumber = 15224;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_Suspended_StateNumber = 15226;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_HaltedToReady_TransitionNumber = 15228;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ReadyToRunning_TransitionNumber = 15230;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_RunningToHalted_TransitionNumber = 15232;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_RunningToReady_TransitionNumber = 15234;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_RunningToSuspended_TransitionNumber = 15236;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_SuspendedToRunning_TransitionNumber = 15238;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_SuspendedToHalted_TransitionNumber = 15240;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_SuspendedToReady_TransitionNumber = 15242;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ReadyToHalted_TransitionNumber = 15244;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet_ToolFrame = 15252;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet_MaxAcceleration = 15253;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15257;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet_MaxVelocity = 15259;

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint PtpMoveSkillType_ParameterSet_MaxVelocity_EURange = 15263;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition = 15267;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates = 15268;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation = 15270;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_X = 15275;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Y = 15276;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Z = 15277;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_A Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_A = 15278;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_B Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_B = 15279;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_C Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_C = 15280;

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_AxisBounds Variable.
        /// </summary>
        public const uint ICartesianMoveSkillParameterType_ParameterSet_AxisBounds = 15281;

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet_TargetJointPosition Variable.
        /// </summary>
        public const uint IJointMoveSkillParameterType_ParameterSet_TargetJointPosition = 15289;

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet_TargetJointPosition_EURange Variable.
        /// </summary>
        public const uint IJointMoveSkillParameterType_ParameterSet_TargetJointPosition_EURange = 15293;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_CurrentState_Id = 15297;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_CurrentState_Number = 15299;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_LastTransition_Id = 15302;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_LastTransition_Number = 15304;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_LastTransition_TransitionTime = 15305;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_CreateSessionId = 15317;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_CreateClientName = 15318;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15319;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15320;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCall = 15321;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15322;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15323;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15324;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15325;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15326;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15327;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15328;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_Halted_StateNumber = 15331;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_Ready_StateNumber = 15333;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_Running_StateNumber = 15335;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_Suspended_StateNumber = 15337;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_HaltedToReady_TransitionNumber = 15339;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ReadyToRunning_TransitionNumber = 15341;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_RunningToHalted_TransitionNumber = 15343;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_RunningToReady_TransitionNumber = 15345;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_RunningToSuspended_TransitionNumber = 15347;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_SuspendedToRunning_TransitionNumber = 15349;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_SuspendedToHalted_TransitionNumber = 15351;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_SuspendedToReady_TransitionNumber = 15353;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ReadyToHalted_TransitionNumber = 15355;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ParameterSet_ToolFrame = 15363;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration = 15364;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15368;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ParameterSet_MaxVelocity = 15370;

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint CartesianLinearMoveSkillType_ParameterSet_MaxVelocity_EURange = 15374;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_CurrentState_Id = 15378;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_CurrentState_Number = 15380;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_LastTransition_Id = 15383;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_LastTransition_Number = 15385;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_LastTransition_TransitionTime = 15386;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_CreateSessionId = 15398;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_CreateClientName = 15399;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15400;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15401;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCall = 15402;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15403;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15404;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15405;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15406;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15407;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15408;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15409;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_Halted_StateNumber = 15412;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_Ready_StateNumber = 15414;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_Running_StateNumber = 15416;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_Suspended_StateNumber = 15418;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_HaltedToReady_TransitionNumber = 15420;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ReadyToRunning_TransitionNumber = 15422;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_RunningToHalted_TransitionNumber = 15424;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_RunningToReady_TransitionNumber = 15426;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_RunningToSuspended_TransitionNumber = 15428;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_SuspendedToRunning_TransitionNumber = 15430;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_SuspendedToHalted_TransitionNumber = 15432;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_SuspendedToReady_TransitionNumber = 15434;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ReadyToHalted_TransitionNumber = 15436;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ParameterSet_ToolFrame = 15444;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ParameterSet_MaxAcceleration = 15445;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15449;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ParameterSet_MaxVelocity = 15451;

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint JointLinearMoveSkillType_ParameterSet_MaxVelocity_EURange = 15455;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_CurrentState_Id = 15459;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_CurrentState_Number = 15461;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_LastTransition_Id = 15464;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_LastTransition_Number = 15466;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_LastTransition_TransitionTime = 15467;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_CreateSessionId = 15479;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_CreateClientName = 15480;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15481;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15482;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCall = 15483;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15484;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15485;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15486;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15487;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15488;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15489;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15490;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_Halted_StateNumber = 15493;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_Ready_StateNumber = 15495;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_Running_StateNumber = 15497;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_Suspended_StateNumber = 15499;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_HaltedToReady_TransitionNumber = 15501;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ReadyToRunning_TransitionNumber = 15503;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_RunningToHalted_TransitionNumber = 15505;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_RunningToReady_TransitionNumber = 15507;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_RunningToSuspended_TransitionNumber = 15509;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_SuspendedToRunning_TransitionNumber = 15511;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_SuspendedToHalted_TransitionNumber = 15513;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_SuspendedToReady_TransitionNumber = 15515;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ReadyToHalted_TransitionNumber = 15517;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ParameterSet_ToolFrame = 15525;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration = 15526;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15530;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ParameterSet_MaxVelocity = 15532;

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint CartesianPtpMoveSkillType_ParameterSet_MaxVelocity_EURange = 15536;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_CurrentState_Id = 15540;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_CurrentState_Number = 15542;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_LastTransition_Id = 15545;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_LastTransition_Number = 15547;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_LastTransition_TransitionTime = 15548;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_CreateSessionId = 15560;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_CreateClientName = 15561;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = 15562;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = 15563;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCall = 15564;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = 15565;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = 15566;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15567;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = 15568;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = 15569;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = 15570;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15571;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_Halted_StateNumber = 15574;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_Ready_StateNumber = 15576;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_Running_StateNumber = 15578;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_Suspended_StateNumber = 15580;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_HaltedToReady_TransitionNumber = 15582;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ReadyToRunning_TransitionNumber = 15584;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_RunningToHalted_TransitionNumber = 15586;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_RunningToReady_TransitionNumber = 15588;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_RunningToSuspended_TransitionNumber = 15590;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_SuspendedToRunning_TransitionNumber = 15592;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_SuspendedToHalted_TransitionNumber = 15594;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_SuspendedToReady_TransitionNumber = 15596;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ReadyToHalted_TransitionNumber = 15598;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ParameterSet_ToolFrame = 15606;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ParameterSet_MaxAcceleration = 15607;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = 15611;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ParameterSet_MaxVelocity = 15613;

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint JointPtpMoveSkillType_ParameterSet_MaxVelocity_EURange = 15617;

        /// <summary>
        /// The identifier for the StreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint StreamSkillType_CurrentState_Id = 15621;

        /// <summary>
        /// The identifier for the StreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint StreamSkillType_CurrentState_Number = 15623;

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint StreamSkillType_LastTransition_Id = 15626;

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint StreamSkillType_LastTransition_Number = 15628;

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint StreamSkillType_LastTransition_TransitionTime = 15629;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_CreateSessionId = 15641;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_CreateClientName = 15642;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_InvocationCreationTime = 15643;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastTransitionTime = 15644;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodCall = 15645;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodSessionId = 15646;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodInputArguments = 15647;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15648;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodInputValues = 15649;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodOutputValues = 15650;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodCallTime = 15651;

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint StreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15652;

        /// <summary>
        /// The identifier for the StreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint StreamSkillType_Halted_StateNumber = 15655;

        /// <summary>
        /// The identifier for the StreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint StreamSkillType_Ready_StateNumber = 15657;

        /// <summary>
        /// The identifier for the StreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint StreamSkillType_Running_StateNumber = 15659;

        /// <summary>
        /// The identifier for the StreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint StreamSkillType_Suspended_StateNumber = 15661;

        /// <summary>
        /// The identifier for the StreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_HaltedToReady_TransitionNumber = 15663;

        /// <summary>
        /// The identifier for the StreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_ReadyToRunning_TransitionNumber = 15665;

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_RunningToHalted_TransitionNumber = 15667;

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_RunningToReady_TransitionNumber = 15669;

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_RunningToSuspended_TransitionNumber = 15671;

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_SuspendedToRunning_TransitionNumber = 15673;

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_SuspendedToHalted_TransitionNumber = 15675;

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_SuspendedToReady_TransitionNumber = 15677;

        /// <summary>
        /// The identifier for the StreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint StreamSkillType_ReadyToHalted_TransitionNumber = 15679;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint PositionStreamSkillType_CurrentState_Id = 15688;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint PositionStreamSkillType_CurrentState_Number = 15690;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint PositionStreamSkillType_LastTransition_Id = 15693;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint PositionStreamSkillType_LastTransition_Number = 15695;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint PositionStreamSkillType_LastTransition_TransitionTime = 15696;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_CreateSessionId = 15708;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_CreateClientName = 15709;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_InvocationCreationTime = 15710;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastTransitionTime = 15711;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodCall = 15712;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodSessionId = 15713;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodInputArguments = 15714;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15715;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodInputValues = 15716;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputValues = 15717;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodCallTime = 15718;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15719;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_Halted_StateNumber = 15722;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_Ready_StateNumber = 15724;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_Running_StateNumber = 15726;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_Suspended_StateNumber = 15728;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_HaltedToReady_TransitionNumber = 15730;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ReadyToRunning_TransitionNumber = 15732;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_RunningToHalted_TransitionNumber = 15734;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_RunningToReady_TransitionNumber = 15736;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_RunningToSuspended_TransitionNumber = 15738;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_SuspendedToRunning_TransitionNumber = 15740;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_SuspendedToHalted_TransitionNumber = 15742;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_SuspendedToReady_TransitionNumber = 15744;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ReadyToHalted_TransitionNumber = 15746;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition = 15754;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates = 15755;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_Orientation = 15757;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_X = 15762;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Y = 15763;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Z = 15764;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_A Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_A = 15765;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_B Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_B = 15766;

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_C Variable.
        /// </summary>
        public const uint PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_C = 15767;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_Locked = 15778;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_LockingClient = 15779;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_LockingUser = 15780;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_RemainingLockTime = 15781;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_InitLock_InputArguments = 15783;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_InitLock_OutputArguments = 15784;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_RenewLock_OutputArguments = 15786;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_ExitLock_OutputArguments = 15788;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Lock_BreakLock_OutputArguments = 15790;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_ParameterSet_SpeedOverride = 15808;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_Locked = 15818;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingClient = 15819;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingUser = 15820;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RemainingLockTime = 15821;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_InputArguments = 15823;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = 15824;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = 15826;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = 15828;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = 15830;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_MotionProfile = 15845;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass = 15847;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = 15852;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15854;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = 15856;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15861;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15862;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15863;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = 15864;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = 15865;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = 15866;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = 15869;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = 15870;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = 15871;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition = 15872;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = 15877;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = 15883;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = 15889;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_Locked = 15899;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = 15900;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = 15901;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = 15902;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = 15904;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = 15905;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = 15907;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = 15909;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = 15911;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Mass Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Mass = 15927;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Mass_EngineeringUnits = 15932;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass = 15933;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates = 15934;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation = 15936;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_X = 15941;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = 15942;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = 15943;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_A = 15944;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_B = 15945;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_C = 15946;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Inertia = 15947;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Inertia_X = 15949;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Inertia_Y = 15950;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeLoad_Inertia_Z = 15951;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = 15961;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = 15962;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = 15963;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = 15964;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = 15966;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = 15967;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = 15969;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = 15971;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = 15973;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeToolSet_InputArguments = 15989;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolClear_InputArguments Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeToolClear_InputArguments = 15991;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_Name Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_Name = 15993;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame = 15994;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates = 15995;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation = 15997;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_X = 16002;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = 16003;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = 16004;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_A = 16005;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_B = 16006;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_C = 16007;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_DeviceOnPath Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_ParameterSet_DeviceOnPath = 16008;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_ProgrammedDeviceSpeed Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_ParameterSet_ProgrammedDeviceSpeed = 16009;

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_UnderControl Variable.
        /// </summary>
        public const uint FortissMotionDeviceType_ParameterSet_UnderControl = 16010;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_Open, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_Close, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_Read, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_Write, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(fortiss.Robotics.Methods.FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_InitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Lock_InitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_RenewLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Lock_RenewLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_ExitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Lock_ExitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_BreakLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Lock_BreakLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolSet Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeToolSet = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_FlangeToolSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolClear Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeToolClear = new ExpandedNodeId(fortiss.Robotics.Methods.FortissMotionDeviceType_FlangeToolClear, fortiss.Robotics.Namespaces.fortissRobotics);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata = new ExpandedNodeId(fortiss.Robotics.Objects.FortissRoboticsNamespaceMetadata, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.MoveSkillType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.LinearMoveSkillType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.PtpMoveSkillType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.ICartesianMoveSkillParameterType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IJointMoveSkillParameterType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.IJointMoveSkillParameterType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.PositionStreamSkillType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.FortissMotionDeviceType_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet = new ExpandedNodeId(fortiss.Robotics.Objects.FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad = new ExpandedNodeId(fortiss.Robotics.Objects.FortissMotionDeviceType_FlangeLoad, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool = new ExpandedNodeId(fortiss.Robotics.Objects.FortissMotionDeviceType_FlangeTool, fortiss.Robotics.Namespaces.fortissRobotics);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the MoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.MoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.LinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.PtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.ICartesianMoveSkillParameterType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IJointMoveSkillParameterType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.IJointMoveSkillParameterType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.CartesianLinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.JointLinearMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.CartesianPtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.JointPtpMoveSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.StreamSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.PositionStreamSkillType, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType = new ExpandedNodeId(fortiss.Robotics.ObjectTypes.FortissMotionDeviceType, fortiss.Robotics.Namespaces.fortissRobotics);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceUri = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceUri, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceVersion, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespacePublicationDate, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_IsNamespaceSubset, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_StaticNodeIdTypes, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_StaticNumericNodeIdRange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_StaticStringNodeIdPattern, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Size, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Writable, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_UserWritable, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_OpenCount, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Open_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Open_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Close_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Read_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Read_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_Write_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_DefaultRolePermissions, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_DefaultUserRolePermissions, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissRoboticsNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissRoboticsNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(fortiss.Robotics.Variables.FortissRoboticsNamespaceMetadata_DefaultAccessRestrictions, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the MoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.MoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the LinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinearMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.LinearMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PtpMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.PtpMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_X = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Y = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Z = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_CartesianCoordinates_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_A = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_A, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_B = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_B, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_C = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_TargetPosition_Orientation_C, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the ICartesianMoveSkillParameterType_ParameterSet_AxisBounds Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICartesianMoveSkillParameterType_ParameterSet_AxisBounds = new ExpandedNodeId(fortiss.Robotics.Variables.ICartesianMoveSkillParameterType_ParameterSet_AxisBounds, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet_TargetJointPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IJointMoveSkillParameterType_ParameterSet_TargetJointPosition = new ExpandedNodeId(fortiss.Robotics.Variables.IJointMoveSkillParameterType_ParameterSet_TargetJointPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the IJointMoveSkillParameterType_ParameterSet_TargetJointPosition_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IJointMoveSkillParameterType_ParameterSet_TargetJointPosition_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.IJointMoveSkillParameterType_ParameterSet_TargetJointPosition_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianLinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianLinearMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianLinearMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointLinearMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointLinearMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.JointLinearMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the CartesianPtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CartesianPtpMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.CartesianPtpMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ParameterSet_ToolFrame = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ParameterSet_ToolFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ParameterSet_MaxAcceleration = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ParameterSet_MaxAcceleration, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ParameterSet_MaxAcceleration_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ParameterSet_MaxVelocity = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ParameterSet_MaxVelocity, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the JointPtpMoveSkillType_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId JointPtpMoveSkillType_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(fortiss.Robotics.Variables.JointPtpMoveSkillType_ParameterSet_MaxVelocity_EURange, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the StreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.StreamSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_CurrentState_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_CurrentState_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_LastTransition_Id, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_LastTransition_Number, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_LastTransition_TransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_CreateClientName, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_Halted_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_Ready_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_Running_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_Suspended_StateNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_HaltedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ReadyToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_RunningToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_RunningToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_RunningToSuspended_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_SuspendedToRunning_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_SuspendedToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_SuspendedToReady_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ReadyToHalted_TransitionNumber, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_Orientation = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_Orientation, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_X = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Y = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Z = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_CartesianCoordinates_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_A = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_A, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_B = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_B, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_C = new ExpandedNodeId(fortiss.Robotics.Variables.PositionStreamSkillType_ParameterSet_TargetPosition_Orientation_C, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_Locked = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_Locked, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_LockingClient = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_LockingClient, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_LockingUser = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_LockingUser, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_RemainingLockTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_InitLock_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_InitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_RenewLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_ExitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Lock_BreakLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_ParameterSet_SpeedOverride = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_ParameterSet_SpeedOverride, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_Locked = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_Locked, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingClient = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingClient, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingUser = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_LockingUser, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RemainingLockTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_InitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_MotionProfile = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_MotionProfile, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_Locked = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_Locked, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingClient, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_LockingUser, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Mass = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Mass, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Mass_EngineeringUnits = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Mass_EngineeringUnits, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_CartesianCoordinates_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_A, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_B, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_CenterOfMass_Orientation_C, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Inertia = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Inertia, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Inertia_X = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Inertia_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Inertia_Y = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Inertia_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeLoad_Inertia_Z = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeLoad_Inertia_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeToolSet_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeToolSet_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeToolClear_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeToolClear_InputArguments = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeToolClear_InputArguments, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_Name = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_Name, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_X = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_X, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Y, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_CartesianCoordinates_Z, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_A = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_A, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_B = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_B, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_C = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_FlangeTool_ThreeDFrame_Orientation_C, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_DeviceOnPath Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_ParameterSet_DeviceOnPath = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_ParameterSet_DeviceOnPath, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_ProgrammedDeviceSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_ParameterSet_ProgrammedDeviceSpeed = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_ParameterSet_ProgrammedDeviceSpeed, fortiss.Robotics.Namespaces.fortissRobotics);

        /// <summary>
        /// The identifier for the FortissMotionDeviceType_ParameterSet_UnderControl Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissMotionDeviceType_ParameterSet_UnderControl = new ExpandedNodeId(fortiss.Robotics.Variables.FortissMotionDeviceType_ParameterSet_UnderControl, fortiss.Robotics.Namespaces.fortissRobotics);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CartesianLinearMoveSkillType component.
        /// </summary>
        public const string CartesianLinearMoveSkillType = "CartesianLinearMoveSkillType";

        /// <summary>
        /// The BrowseName for the CartesianPtpMoveSkillType component.
        /// </summary>
        public const string CartesianPtpMoveSkillType = "CartesianPtpMoveSkillType";

        /// <summary>
        /// The BrowseName for the FlangeLoad component.
        /// </summary>
        public const string FlangeLoad = "FlangeLoad";

        /// <summary>
        /// The BrowseName for the FlangeTool component.
        /// </summary>
        public const string FlangeTool = "FlangeTool";

        /// <summary>
        /// The BrowseName for the FlangeToolClear component.
        /// </summary>
        public const string FlangeToolClear = "FlangeToolClear";

        /// <summary>
        /// The BrowseName for the FlangeToolSet component.
        /// </summary>
        public const string FlangeToolSet = "FlangeToolSet";

        /// <summary>
        /// The BrowseName for the FortissMotionDeviceType component.
        /// </summary>
        public const string FortissMotionDeviceType = "FortissMotionDeviceType";

        /// <summary>
        /// The BrowseName for the FortissRoboticsNamespaceMetadata component.
        /// </summary>
        public const string FortissRoboticsNamespaceMetadata = "https://fortiss.org/UA/Robotics/";

        /// <summary>
        /// The BrowseName for the ICartesianMoveSkillParameterType component.
        /// </summary>
        public const string ICartesianMoveSkillParameterType = "ICartesianMoveSkillParameterType";

        /// <summary>
        /// The BrowseName for the IJointMoveSkillParameterType component.
        /// </summary>
        public const string IJointMoveSkillParameterType = "IJointMoveSkillParameterType";

        /// <summary>
        /// The BrowseName for the JointLinearMoveSkillType component.
        /// </summary>
        public const string JointLinearMoveSkillType = "JointLinearMoveSkillType";

        /// <summary>
        /// The BrowseName for the JointPtpMoveSkillType component.
        /// </summary>
        public const string JointPtpMoveSkillType = "JointPtpMoveSkillType";

        /// <summary>
        /// The BrowseName for the LinearMoveSkillType component.
        /// </summary>
        public const string LinearMoveSkillType = "LinearMoveSkillType";

        /// <summary>
        /// The BrowseName for the MoveSkillType component.
        /// </summary>
        public const string MoveSkillType = "MoveSkillType";

        /// <summary>
        /// The BrowseName for the PositionStreamSkillType component.
        /// </summary>
        public const string PositionStreamSkillType = "PositionStreamSkillType";

        /// <summary>
        /// The BrowseName for the PtpMoveSkillType component.
        /// </summary>
        public const string PtpMoveSkillType = "PtpMoveSkillType";

        /// <summary>
        /// The BrowseName for the StreamSkillType component.
        /// </summary>
        public const string StreamSkillType = "StreamSkillType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the fortissRobotics namespace (.NET code namespace is 'fortiss.Robotics').
        /// </summary>
        public const string fortissRobotics = "https://fortiss.org/UA/Robotics/";

        /// <summary>
        /// The URI for the fortissRoboticsXsd namespace (.NET code namespace is 'fortiss.Robotics').
        /// </summary>
        public const string fortissRoboticsXsd = "https://fortiss.org/UA/Robotics/Types.xsd";

        /// <summary>
        /// The URI for the fortissDi namespace (.NET code namespace is 'fortiss.Di').
        /// </summary>
        public const string fortissDi = "https://fortiss.org/UA/DI/";

        /// <summary>
        /// The URI for the fortissDiXsd namespace (.NET code namespace is 'fortiss.Di').
        /// </summary>
        public const string fortissDiXsd = "https://fortiss.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaRobotics namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRobotics = "http://opcfoundation.org/UA/Robotics/";

        /// <summary>
        /// The URI for the OpcUaRoboticsXsd namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRoboticsXsd = "http://opcfoundation.org/UA/Robotics/Types.xsd";
    }
    #endregion
}