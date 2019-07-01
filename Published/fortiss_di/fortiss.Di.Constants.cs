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
using Opc.Ua;
using Opc.Ua.Di;

namespace fortiss.Di
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
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Open = 15890;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Close = 15893;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Read = 15895;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Write = 15898;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_GetPosition = 15900;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_SetPosition = 15903;

        /// <summary>
        /// The identifier for the SkillType_Start Method.
        /// </summary>
        public const uint SkillType_Start = 15095;

        /// <summary>
        /// The identifier for the SkillType_Suspend Method.
        /// </summary>
        public const uint SkillType_Suspend = 15096;

        /// <summary>
        /// The identifier for the SkillType_Resume Method.
        /// </summary>
        public const uint SkillType_Resume = 15097;

        /// <summary>
        /// The identifier for the SkillType_Halt Method.
        /// </summary>
        public const uint SkillType_Halt = 15098;

        /// <summary>
        /// The identifier for the SkillType_Reset Method.
        /// </summary>
        public const uint SkillType_Reset = 15099;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halt Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Halt = 15458;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Reset Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Reset = 15459;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Resume Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Resume = 15460;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspend Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Suspend = 15461;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Start Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Start = 15462;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_InitLock = 15477;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RenewLock Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_RenewLock = 15480;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_ExitLock Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_ExitLock = 15482;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_BreakLock Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_BreakLock = 15484;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halt Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Halt = 15559;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Reset Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Reset = 15560;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Resume Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Resume = 15561;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspend Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Suspend = 15562;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Start Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Start = 15563;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halt = 15623;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Reset = 15624;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Resume = 15625;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspend = 15626;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Start = 15627;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Halt = 15687;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Reset = 15688;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Resume = 15689;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Suspend = 15690;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Start = 15691;

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock Method.
        /// </summary>
        public const uint SensorType_Lock_InitLock = 15706;

        /// <summary>
        /// The identifier for the SensorType_Lock_RenewLock Method.
        /// </summary>
        public const uint SensorType_Lock_RenewLock = 15709;

        /// <summary>
        /// The identifier for the SensorType_Lock_ExitLock Method.
        /// </summary>
        public const uint SensorType_Lock_ExitLock = 15711;

        /// <summary>
        /// The identifier for the SensorType_Lock_BreakLock Method.
        /// </summary>
        public const uint SensorType_Lock_BreakLock = 15713;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_InitLock = 15742;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RenewLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_RenewLock = 15745;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_ExitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_ExitLock = 15747;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_BreakLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_BreakLock = 15749;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_InitLock = 15776;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RenewLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_RenewLock = 15779;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_ExitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_ExitLock = 15781;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_BreakLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_BreakLock = 15783;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_InitLock = 15816;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RenewLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_RenewLock = 15819;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_ExitLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_ExitLock = 15821;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_BreakLock Method.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_BreakLock = 15823;
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
        /// The identifier for the FortissDiNamespaceMetadata Object.
        /// </summary>
        public const uint FortissDiNamespaceMetadata = 15473;

        /// <summary>
        /// The identifier for the SkillType_FinalResultData Object.
        /// </summary>
        public const uint SkillType_FinalResultData = 15068;

        /// <summary>
        /// The identifier for the SkillType_Halted Object.
        /// </summary>
        public const uint SkillType_Halted = 15069;

        /// <summary>
        /// The identifier for the SkillType_Ready Object.
        /// </summary>
        public const uint SkillType_Ready = 15071;

        /// <summary>
        /// The identifier for the SkillType_Running Object.
        /// </summary>
        public const uint SkillType_Running = 15073;

        /// <summary>
        /// The identifier for the SkillType_Suspended Object.
        /// </summary>
        public const uint SkillType_Suspended = 15075;

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady Object.
        /// </summary>
        public const uint SkillType_HaltedToReady = 15077;

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning Object.
        /// </summary>
        public const uint SkillType_ReadyToRunning = 15079;

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted Object.
        /// </summary>
        public const uint SkillType_RunningToHalted = 15081;

        /// <summary>
        /// The identifier for the SkillType_RunningToReady Object.
        /// </summary>
        public const uint SkillType_RunningToReady = 15083;

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended Object.
        /// </summary>
        public const uint SkillType_RunningToSuspended = 15085;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning Object.
        /// </summary>
        public const uint SkillType_SuspendedToRunning = 15087;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted Object.
        /// </summary>
        public const uint SkillType_SuspendedToHalted = 15089;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady Object.
        /// </summary>
        public const uint SkillType_SuspendedToReady = 15091;

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted Object.
        /// </summary>
        public const uint SkillType_ReadyToHalted = 15093;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet Object.
        /// </summary>
        public const uint GraspGripperSkillType_ParameterSet = 15235;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet Object.
        /// </summary>
        public const uint ReleaseGripperSkill_ParameterSet = 15309;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet Object.
        /// </summary>
        public const uint MoveGripperSkill_ParameterSet = 15383;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills Object.
        /// </summary>
        public const uint ISkillControllerType_Skills = 15398;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No_ Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No_ = 15399;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halted Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Halted = 15432;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__HaltedToReady Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__HaltedToReady = 15434;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Ready Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Ready = 15436;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToHalted Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ReadyToHalted = 15438;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToRunning Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ReadyToRunning = 15440;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Running Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Running = 15442;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToHalted Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToHalted = 15444;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToReady Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToReady = 15446;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToSuspended Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToSuspended = 15448;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspended Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Suspended = 15450;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToHalted Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToHalted = 15452;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToReady Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToReady = 15454;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToRunning Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToRunning = 15456;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills = 15499;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill = 15500;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Halted = 15533;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady = 15535;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Ready Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Ready = 15537;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted = 15539;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning = 15541;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Running Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Running = 15543;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted = 15545;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady = 15547;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended = 15549;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended = 15551;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted = 15553;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady = 15555;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning = 15557;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill = 15564;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted = 15597;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady = 15599;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready = 15601;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted = 15603;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning = 15605;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running = 15607;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted = 15609;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady = 15611;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended = 15613;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended = 15615;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted = 15617;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady = 15619;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning = 15621;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill = 15628;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Halted = 15661;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady = 15663;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Ready Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Ready = 15665;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted = 15667;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning = 15669;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Running Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Running = 15671;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted = 15673;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady = 15675;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended = 15677;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended = 15679;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted = 15681;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady = 15683;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning = 15685;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor Object.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor = 15764;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor Object.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor = 15804;
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
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public const uint SkillType = 15034;

        /// <summary>
        /// The identifier for the GripperSkillType ObjectType.
        /// </summary>
        public const uint GripperSkillType = 15101;

        /// <summary>
        /// The identifier for the GraspGripperSkillType ObjectType.
        /// </summary>
        public const uint GraspGripperSkillType = 15168;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill ObjectType.
        /// </summary>
        public const uint ReleaseGripperSkill = 15242;

        /// <summary>
        /// The identifier for the MoveGripperSkill ObjectType.
        /// </summary>
        public const uint MoveGripperSkill = 15316;

        /// <summary>
        /// The identifier for the ISkillControllerType ObjectType.
        /// </summary>
        public const uint ISkillControllerType = 15396;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType ObjectType.
        /// </summary>
        public const uint GripperDeviceControllerType = 15463;

        /// <summary>
        /// The identifier for the SensorType ObjectType.
        /// </summary>
        public const uint SensorType = 15692;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType ObjectType.
        /// </summary>
        public const uint ForceTorqueSensorType = 15728;

        /// <summary>
        /// The identifier for the SkillTransitionEventType ObjectType.
        /// </summary>
        public const uint SkillTransitionEventType = 15844;
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
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceUri = 15702;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceVersion = 15738;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespacePublicationDate = 15772;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_IsNamespaceSubset = 15812;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_StaticNodeIdTypes = 15881;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_StaticNumericNodeIdRange = 15882;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_StaticStringNodeIdPattern = 15883;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Size = 15885;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Writable = 15886;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_UserWritable = 15887;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_OpenCount = 15888;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Open_InputArguments = 15891;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15892;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Close_InputArguments = 15894;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Read_InputArguments = 15896;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15897;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_Write_InputArguments = 15899;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15901;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15902;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15904;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_DefaultRolePermissions = 15906;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_DefaultUserRolePermissions = 15907;

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint FortissDiNamespaceMetadata_DefaultAccessRestrictions = 15908;

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint SkillType_CurrentState_Id = 15036;

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint SkillType_CurrentState_Number = 15038;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint SkillType_LastTransition_Id = 15041;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint SkillType_LastTransition_Number = 15043;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SkillType_LastTransition_TransitionTime = 15044;

        /// <summary>
        /// The identifier for the SkillType_MaxInstanceCount Variable.
        /// </summary>
        public const uint SkillType_MaxInstanceCount = 15053;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_CreateSessionId = 15056;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_CreateClientName = 15057;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_InvocationCreationTime = 15058;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastTransitionTime = 15059;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodCall = 15060;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodSessionId = 15061;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodInputArguments = 15062;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodOutputArguments = 15063;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodInputValues = 15064;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodOutputValues = 15065;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodCallTime = 15066;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodReturnStatus = 15067;

        /// <summary>
        /// The identifier for the SkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Halted_StateNumber = 15070;

        /// <summary>
        /// The identifier for the SkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Ready_StateNumber = 15072;

        /// <summary>
        /// The identifier for the SkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Running_StateNumber = 15074;

        /// <summary>
        /// The identifier for the SkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Suspended_StateNumber = 15076;

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_HaltedToReady_TransitionNumber = 15078;

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_ReadyToRunning_TransitionNumber = 15080;

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToHalted_TransitionNumber = 15082;

        /// <summary>
        /// The identifier for the SkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToReady_TransitionNumber = 15084;

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToSuspended_TransitionNumber = 15086;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToRunning_TransitionNumber = 15088;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToHalted_TransitionNumber = 15090;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToReady_TransitionNumber = 15092;

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_ReadyToHalted_TransitionNumber = 15094;

        /// <summary>
        /// The identifier for the SkillType_Name Variable.
        /// </summary>
        public const uint SkillType_Name = 15100;

        /// <summary>
        /// The identifier for the GripperSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint GripperSkillType_CurrentState_Id = 15103;

        /// <summary>
        /// The identifier for the GripperSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint GripperSkillType_CurrentState_Number = 15105;

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint GripperSkillType_LastTransition_Id = 15108;

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint GripperSkillType_LastTransition_Number = 15110;

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GripperSkillType_LastTransition_TransitionTime = 15111;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_CreateSessionId = 15123;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_CreateClientName = 15124;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_InvocationCreationTime = 15125;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastTransitionTime = 15126;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodCall = 15127;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodSessionId = 15128;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodInputArguments = 15129;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15130;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodInputValues = 15131;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodOutputValues = 15132;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodCallTime = 15133;

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GripperSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15134;

        /// <summary>
        /// The identifier for the GripperSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint GripperSkillType_Halted_StateNumber = 15137;

        /// <summary>
        /// The identifier for the GripperSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint GripperSkillType_Ready_StateNumber = 15139;

        /// <summary>
        /// The identifier for the GripperSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint GripperSkillType_Running_StateNumber = 15141;

        /// <summary>
        /// The identifier for the GripperSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GripperSkillType_Suspended_StateNumber = 15143;

        /// <summary>
        /// The identifier for the GripperSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_HaltedToReady_TransitionNumber = 15145;

        /// <summary>
        /// The identifier for the GripperSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_ReadyToRunning_TransitionNumber = 15147;

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_RunningToHalted_TransitionNumber = 15149;

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_RunningToReady_TransitionNumber = 15151;

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_RunningToSuspended_TransitionNumber = 15153;

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_SuspendedToRunning_TransitionNumber = 15155;

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_SuspendedToHalted_TransitionNumber = 15157;

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_SuspendedToReady_TransitionNumber = 15159;

        /// <summary>
        /// The identifier for the GripperSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperSkillType_ReadyToHalted_TransitionNumber = 15161;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint GraspGripperSkillType_CurrentState_Id = 15170;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint GraspGripperSkillType_CurrentState_Number = 15172;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint GraspGripperSkillType_LastTransition_Id = 15175;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint GraspGripperSkillType_LastTransition_Number = 15177;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GraspGripperSkillType_LastTransition_TransitionTime = 15178;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_CreateSessionId = 15190;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_CreateClientName = 15191;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_InvocationCreationTime = 15192;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastTransitionTime = 15193;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodCall = 15194;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodSessionId = 15195;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodInputArguments = 15196;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15197;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodInputValues = 15198;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputValues = 15199;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodCallTime = 15200;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15201;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_Halted_StateNumber = 15204;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_Ready_StateNumber = 15206;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_Running_StateNumber = 15208;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_Suspended_StateNumber = 15210;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_HaltedToReady_TransitionNumber = 15212;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ReadyToRunning_TransitionNumber = 15214;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_RunningToHalted_TransitionNumber = 15216;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_RunningToReady_TransitionNumber = 15218;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_RunningToSuspended_TransitionNumber = 15220;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_SuspendedToRunning_TransitionNumber = 15222;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_SuspendedToHalted_TransitionNumber = 15224;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_SuspendedToReady_TransitionNumber = 15226;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ReadyToHalted_TransitionNumber = 15228;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet_Force Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ParameterSet_Force = 15236;

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint GraspGripperSkillType_ParameterSet_Force_EURange = 15240;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_CurrentState_Id = 15244;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_CurrentState_Number = 15246;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_LastTransition_Id = 15249;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_LastTransition_Number = 15251;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_LastTransition_TransitionTime = 15252;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = 15264;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = 15265;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15266;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = 15267;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = 15268;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15269;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15270;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15271;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15272;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15273;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15274;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15275;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_Halted_StateNumber = 15278;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_Ready_StateNumber = 15280;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_Running_StateNumber = 15282;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_Suspended_StateNumber = 15284;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_HaltedToReady_TransitionNumber = 15286;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ReadyToRunning_TransitionNumber = 15288;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_RunningToHalted_TransitionNumber = 15290;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_RunningToReady_TransitionNumber = 15292;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_RunningToSuspended_TransitionNumber = 15294;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_SuspendedToRunning_TransitionNumber = 15296;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_SuspendedToHalted_TransitionNumber = 15298;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_SuspendedToReady_TransitionNumber = 15300;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ReadyToHalted_TransitionNumber = 15302;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet_Force Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ParameterSet_Force = 15310;

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint ReleaseGripperSkill_ParameterSet_Force_EURange = 15314;

        /// <summary>
        /// The identifier for the MoveGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint MoveGripperSkill_CurrentState_Id = 15318;

        /// <summary>
        /// The identifier for the MoveGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint MoveGripperSkill_CurrentState_Number = 15320;

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint MoveGripperSkill_LastTransition_Id = 15323;

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint MoveGripperSkill_LastTransition_Number = 15325;

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MoveGripperSkill_LastTransition_TransitionTime = 15326;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_CreateSessionId = 15338;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_CreateClientName = 15339;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15340;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastTransitionTime = 15341;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodCall = 15342;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15343;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15344;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15345;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15346;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15347;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15348;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15349;

        /// <summary>
        /// The identifier for the MoveGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_Halted_StateNumber = 15352;

        /// <summary>
        /// The identifier for the MoveGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_Ready_StateNumber = 15354;

        /// <summary>
        /// The identifier for the MoveGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_Running_StateNumber = 15356;

        /// <summary>
        /// The identifier for the MoveGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_Suspended_StateNumber = 15358;

        /// <summary>
        /// The identifier for the MoveGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_HaltedToReady_TransitionNumber = 15360;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_ReadyToRunning_TransitionNumber = 15362;

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_RunningToHalted_TransitionNumber = 15364;

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_RunningToReady_TransitionNumber = 15366;

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_RunningToSuspended_TransitionNumber = 15368;

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_SuspendedToRunning_TransitionNumber = 15370;

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_SuspendedToHalted_TransitionNumber = 15372;

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_SuspendedToReady_TransitionNumber = 15374;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveGripperSkill_ReadyToHalted_TransitionNumber = 15376;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Width Variable.
        /// </summary>
        public const uint MoveGripperSkill_ParameterSet_Width = 15384;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Width_EURange Variable.
        /// </summary>
        public const uint MoveGripperSkill_ParameterSet_Width_EURange = 15388;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Force Variable.
        /// </summary>
        public const uint MoveGripperSkill_ParameterSet_Force = 15390;

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint MoveGripperSkill_ParameterSet_Force_EURange = 15394;

        /// <summary>
        /// The identifier for the ISkillControllerType_Name Variable.
        /// </summary>
        public const uint ISkillControllerType_Name = 15397;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState = 15400;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Id Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState_Id = 15401;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Number Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState_Number = 15403;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition = 15405;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Id Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_Id = 15406;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Number Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_Number = 15408;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime = 15409;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Deletable Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Deletable = 15413;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__AutoDelete Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__AutoDelete = 15414;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RecycleCount Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RecycleCount = 15415;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId = 15417;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName = 15418;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime = 15419;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime = 15420;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall = 15421;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId = 15422;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments = 15423;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments = 15424;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues = 15425;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues = 15426;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime = 15427;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus = 15428;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Name Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Name = 15430;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__MaxInstanceCount Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__MaxInstanceCount = 15431;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halted_StateNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Halted_StateNumber = 15433;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__HaltedToReady_TransitionNumber = 15435;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Ready_StateNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Ready_StateNumber = 15437;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ReadyToHalted_TransitionNumber = 15439;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ReadyToRunning_TransitionNumber = 15441;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Running_StateNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Running_StateNumber = 15443;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToHalted_TransitionNumber = 15445;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToReady_TransitionNumber = 15447;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RunningToSuspended_TransitionNumber = 15449;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspended_StateNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Suspended_StateNumber = 15451;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToHalted_TransitionNumber = 15453;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToReady_TransitionNumber = 15455;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__SuspendedToRunning_TransitionNumber = 15457;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_Locked Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_Locked = 15871;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_LockingClient Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_LockingClient = 15474;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_LockingUser Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_LockingUser = 15475;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_RemainingLockTime = 15476;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_InitLock_InputArguments = 15478;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_InitLock_OutputArguments = 15479;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_RenewLock_OutputArguments = 15481;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_ExitLock_OutputArguments = 15483;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Lock_BreakLock_OutputArguments = 15485;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState = 15501;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Id = 15502;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Number = 15504;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition = 15506;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Id = 15507;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Number = 15509;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_TransitionTime = 15510;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Deletable Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Deletable = 15514;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_AutoDelete = 15515;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RecycleCount = 15516;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateSessionId = 15518;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateClientName = 15519;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15520;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastTransitionTime = 15521;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCall = 15522;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15523;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15524;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15525;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15526;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15527;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15528;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15529;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Name Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Name = 15531;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_MaxInstanceCount = 15532;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Halted_StateNumber = 15534;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady_TransitionNumber = 15536;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Ready_StateNumber = 15538;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted_TransitionNumber = 15540;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning_TransitionNumber = 15542;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Running_StateNumber = 15544;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted_TransitionNumber = 15546;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady_TransitionNumber = 15548;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended_TransitionNumber = 15550;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended_StateNumber = 15552;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted_TransitionNumber = 15554;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady_TransitionNumber = 15556;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning_TransitionNumber = 15558;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState = 15565;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Id = 15566;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Number = 15568;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition = 15570;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Id = 15571;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Number = 15573;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = 15574;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Deletable = 15578;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_AutoDelete = 15579;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RecycleCount = 15580;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = 15582;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = 15583;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15584;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = 15585;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = 15586;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15587;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15588;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15589;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15590;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15591;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15592;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15593;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Name Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Name = 15595;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_MaxInstanceCount = 15596;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted_StateNumber = 15598;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady_TransitionNumber = 15600;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready_StateNumber = 15602;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted_TransitionNumber = 15604;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning_TransitionNumber = 15606;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running_StateNumber = 15608;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted_TransitionNumber = 15610;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady_TransitionNumber = 15612;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended_TransitionNumber = 15614;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended_StateNumber = 15616;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted_TransitionNumber = 15618;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady_TransitionNumber = 15620;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning_TransitionNumber = 15622;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState = 15629;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Id = 15630;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Number = 15632;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition = 15634;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Id = 15635;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Number = 15637;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_TransitionTime = 15638;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Deletable = 15642;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_AutoDelete = 15643;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RecycleCount = 15644;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = 15646;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = 15647;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15648;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = 15649;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = 15650;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15651;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15652;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15653;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15654;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15655;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15656;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15657;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Name Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Name = 15659;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_MaxInstanceCount = 15660;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Halted_StateNumber = 15662;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady_TransitionNumber = 15664;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Ready_StateNumber = 15666;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted_TransitionNumber = 15668;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning_TransitionNumber = 15670;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Running_StateNumber = 15672;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted_TransitionNumber = 15674;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady_TransitionNumber = 15676;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended_TransitionNumber = 15678;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended_StateNumber = 15680;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted_TransitionNumber = 15682;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady_TransitionNumber = 15684;

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning_TransitionNumber = 15686;

        /// <summary>
        /// The identifier for the SensorType_Lock_Locked Variable.
        /// </summary>
        public const uint SensorType_Lock_Locked = 15873;

        /// <summary>
        /// The identifier for the SensorType_Lock_LockingClient Variable.
        /// </summary>
        public const uint SensorType_Lock_LockingClient = 15703;

        /// <summary>
        /// The identifier for the SensorType_Lock_LockingUser Variable.
        /// </summary>
        public const uint SensorType_Lock_LockingUser = 15704;

        /// <summary>
        /// The identifier for the SensorType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SensorType_Lock_RemainingLockTime = 15705;

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SensorType_Lock_InitLock_InputArguments = 15707;

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SensorType_Lock_InitLock_OutputArguments = 15708;

        /// <summary>
        /// The identifier for the SensorType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SensorType_Lock_RenewLock_OutputArguments = 15710;

        /// <summary>
        /// The identifier for the SensorType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SensorType_Lock_ExitLock_OutputArguments = 15712;

        /// <summary>
        /// The identifier for the SensorType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SensorType_Lock_BreakLock_OutputArguments = 15714;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_Locked Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_Locked = 15875;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_LockingClient = 15739;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_LockingUser = 15740;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_RemainingLockTime = 15741;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_InitLock_InputArguments = 15743;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_InitLock_OutputArguments = 15744;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_RenewLock_OutputArguments = 15746;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_ExitLock_OutputArguments = 15748;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_Lock_BreakLock_OutputArguments = 15750;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_Locked Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_Locked = 15877;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_LockingClient Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_LockingClient = 15773;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_LockingUser Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_LockingUser = 15774;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_RemainingLockTime = 15775;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_InitLock_InputArguments = 15777;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_InitLock_OutputArguments = 15778;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_RenewLock_OutputArguments = 15780;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_ExitLock_OutputArguments = 15782;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Lock_BreakLock_OutputArguments = 15784;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Force Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Force = 15798;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Force_EURange Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_ForceSensor_Force_EURange = 15802;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_Locked Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_Locked = 15879;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_LockingClient Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_LockingClient = 15813;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_LockingUser Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_LockingUser = 15814;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_RemainingLockTime = 15815;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_InitLock_InputArguments = 15817;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_InitLock_OutputArguments = 15818;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_RenewLock_OutputArguments = 15820;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_ExitLock_OutputArguments = 15822;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Lock_BreakLock_OutputArguments = 15824;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Torque Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Torque = 15838;

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Torque_EURange Variable.
        /// </summary>
        public const uint ForceTorqueSensorType_TorqueSensor_Torque_EURange = 15842;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_Transition_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_Transition_Id = 15855;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_FromState_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_FromState_Id = 15861;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_ToState_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_ToState_Id = 15866;
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
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_Open, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_Close, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_Read, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_Write, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_GetPosition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(fortiss.Di.Methods.FortissDiNamespaceMetadata_NamespaceFile_SetPosition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Start = new ExpandedNodeId(fortiss.Di.Methods.SkillType_Start, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Suspend = new ExpandedNodeId(fortiss.Di.Methods.SkillType_Suspend, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Resume = new ExpandedNodeId(fortiss.Di.Methods.SkillType_Resume, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Halt = new ExpandedNodeId(fortiss.Di.Methods.SkillType_Halt, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Reset = new ExpandedNodeId(fortiss.Di.Methods.SkillType_Reset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Halt = new ExpandedNodeId(fortiss.Di.Methods.ISkillControllerType_Skills_Skill__No__Halt, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Reset = new ExpandedNodeId(fortiss.Di.Methods.ISkillControllerType_Skills_Skill__No__Reset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Resume = new ExpandedNodeId(fortiss.Di.Methods.ISkillControllerType_Skills_Skill__No__Resume, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Suspend = new ExpandedNodeId(fortiss.Di.Methods.ISkillControllerType_Skills_Skill__No__Suspend, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Start = new ExpandedNodeId(fortiss.Di.Methods.ISkillControllerType_Skills_Skill__No__Start, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_InitLock = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Lock_InitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_RenewLock = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Lock_RenewLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_ExitLock = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Lock_ExitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_BreakLock = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Lock_BreakLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Halt = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_MoveGripperSkill_Halt, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Reset = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_MoveGripperSkill_Reset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Resume = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_MoveGripperSkill_Resume, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Suspend = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_MoveGripperSkill_Suspend, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Start = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_MoveGripperSkill_Start, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halt = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halt, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Reset = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Reset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Resume = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Resume, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspend = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspend, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Start = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Start, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Halt = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_GraspGripperSkill_Halt, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Reset = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_GraspGripperSkill_Reset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Resume = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_GraspGripperSkill_Resume, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Suspend = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_GraspGripperSkill_Suspend, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Start = new ExpandedNodeId(fortiss.Di.Methods.GripperDeviceControllerType_Skills_GraspGripperSkill_Start, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_InitLock = new ExpandedNodeId(fortiss.Di.Methods.SensorType_Lock_InitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_RenewLock = new ExpandedNodeId(fortiss.Di.Methods.SensorType_Lock_RenewLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_ExitLock = new ExpandedNodeId(fortiss.Di.Methods.SensorType_Lock_ExitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_BreakLock = new ExpandedNodeId(fortiss.Di.Methods.SensorType_Lock_BreakLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_InitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_Lock_InitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_RenewLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_Lock_RenewLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_ExitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_Lock_ExitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_BreakLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_Lock_BreakLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_InitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_ForceSensor_Lock_InitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_RenewLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_ForceSensor_Lock_RenewLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_ExitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_ForceSensor_Lock_ExitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_BreakLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_ForceSensor_Lock_BreakLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_InitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_TorqueSensor_Lock_InitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_RenewLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_TorqueSensor_Lock_RenewLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_ExitLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_TorqueSensor_Lock_ExitLock, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_BreakLock = new ExpandedNodeId(fortiss.Di.Methods.ForceTorqueSensorType_TorqueSensor_Lock_BreakLock, fortiss.Di.Namespaces.fortissDi);
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
        /// The identifier for the FortissDiNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata = new ExpandedNodeId(fortiss.Di.Objects.FortissDiNamespaceMetadata, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_FinalResultData Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_FinalResultData = new ExpandedNodeId(fortiss.Di.Objects.SkillType_FinalResultData, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Halted = new ExpandedNodeId(fortiss.Di.Objects.SkillType_Halted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Ready = new ExpandedNodeId(fortiss.Di.Objects.SkillType_Ready, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Running = new ExpandedNodeId(fortiss.Di.Objects.SkillType_Running, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Suspended = new ExpandedNodeId(fortiss.Di.Objects.SkillType_Suspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_HaltedToReady = new ExpandedNodeId(fortiss.Di.Objects.SkillType_HaltedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToRunning = new ExpandedNodeId(fortiss.Di.Objects.SkillType_ReadyToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToHalted = new ExpandedNodeId(fortiss.Di.Objects.SkillType_RunningToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToReady = new ExpandedNodeId(fortiss.Di.Objects.SkillType_RunningToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToSuspended = new ExpandedNodeId(fortiss.Di.Objects.SkillType_RunningToSuspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToRunning = new ExpandedNodeId(fortiss.Di.Objects.SkillType_SuspendedToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToHalted = new ExpandedNodeId(fortiss.Di.Objects.SkillType_SuspendedToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToReady = new ExpandedNodeId(fortiss.Di.Objects.SkillType_SuspendedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToHalted = new ExpandedNodeId(fortiss.Di.Objects.SkillType_ReadyToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ParameterSet = new ExpandedNodeId(fortiss.Di.Objects.GraspGripperSkillType_ParameterSet, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ParameterSet = new ExpandedNodeId(fortiss.Di.Objects.ReleaseGripperSkill_ParameterSet, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ParameterSet = new ExpandedNodeId(fortiss.Di.Objects.MoveGripperSkill_ParameterSet, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No_ Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No_ = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No_, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Halted = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__Halted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__HaltedToReady = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__HaltedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Ready = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__Ready, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ReadyToHalted = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__ReadyToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ReadyToRunning = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__ReadyToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Running Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Running = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__Running, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToHalted = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__RunningToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToReady = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__RunningToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToSuspended = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__RunningToSuspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Suspended = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__Suspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToHalted = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__SuspendedToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToReady = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__SuspendedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToRunning = new ExpandedNodeId(fortiss.Di.Objects.ISkillControllerType_Skills_Skill__No__SuspendedToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Halted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_Halted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Ready = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_Ready, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Running = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_Running, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Halted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_Halted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Ready = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_Ready, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Running = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_Running, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning = new ExpandedNodeId(fortiss.Di.Objects.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor = new ExpandedNodeId(fortiss.Di.Objects.ForceTorqueSensorType_ForceSensor, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor = new ExpandedNodeId(fortiss.Di.Objects.ForceTorqueSensorType_TorqueSensor, fortiss.Di.Namespaces.fortissDi);
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
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillType = new ExpandedNodeId(fortiss.Di.ObjectTypes.SkillType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType = new ExpandedNodeId(fortiss.Di.ObjectTypes.GripperSkillType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType = new ExpandedNodeId(fortiss.Di.ObjectTypes.GraspGripperSkillType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill = new ExpandedNodeId(fortiss.Di.ObjectTypes.ReleaseGripperSkill, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill = new ExpandedNodeId(fortiss.Di.ObjectTypes.MoveGripperSkill, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType = new ExpandedNodeId(fortiss.Di.ObjectTypes.ISkillControllerType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType = new ExpandedNodeId(fortiss.Di.ObjectTypes.GripperDeviceControllerType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(fortiss.Di.ObjectTypes.SensorType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType = new ExpandedNodeId(fortiss.Di.ObjectTypes.ForceTorqueSensorType, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillTransitionEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType = new ExpandedNodeId(fortiss.Di.ObjectTypes.SkillTransitionEventType, fortiss.Di.Namespaces.fortissDi);
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
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceUri = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceUri, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceVersion, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespacePublicationDate, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_IsNamespaceSubset, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_StaticNodeIdTypes, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_StaticNumericNodeIdRange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_StaticStringNodeIdPattern, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Size, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Writable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_UserWritable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_OpenCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Open_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Open_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Close_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Read_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Read_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_Write_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_DefaultRolePermissions, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_DefaultUserRolePermissions, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the FortissDiNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDiNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(fortiss.Di.Variables.FortissDiNamespaceMetadata_DefaultAccessRestrictions, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.SkillType_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.SkillType_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.SkillType_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.SkillType_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.SkillType_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_MaxInstanceCount = new ExpandedNodeId(fortiss.Di.Variables.SkillType_MaxInstanceCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.SkillType_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Name = new ExpandedNodeId(fortiss.Di.Variables.SkillType_Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperSkillType_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet_Force Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ParameterSet_Force = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ParameterSet_Force, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GraspGripperSkillType_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspGripperSkillType_ParameterSet_Force_EURange = new ExpandedNodeId(fortiss.Di.Variables.GraspGripperSkillType_ParameterSet_Force_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet_Force Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ParameterSet_Force = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ParameterSet_Force, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(fortiss.Di.Variables.ReleaseGripperSkill_ParameterSet_Force_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Width Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ParameterSet_Width = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ParameterSet_Width, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Width_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ParameterSet_Width_EURange = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ParameterSet_Width_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Force Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ParameterSet_Force = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ParameterSet_Force, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the MoveGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(fortiss.Di.Variables.MoveGripperSkill_ParameterSet_Force_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Name = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__CurrentState, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__LastTransition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Deletable = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Deletable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__AutoDelete = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__AutoDelete, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RecycleCount = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__RecycleCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Name = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__MaxInstanceCount = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__MaxInstanceCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.ISkillControllerType_Skills_Skill__No__SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_Locked = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_Locked, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_LockingClient = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_LockingClient, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_LockingUser = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_LockingUser, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_RemainingLockTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_InitLock_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_InitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_RenewLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_ExitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Lock_BreakLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Deletable = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Deletable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_AutoDelete = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_AutoDelete, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RecycleCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_RecycleCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Name = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_MaxInstanceCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_MaxInstanceCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_MoveGripperSkill_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Deletable = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Deletable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_AutoDelete = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_AutoDelete, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RecycleCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RecycleCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Name = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_MaxInstanceCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_MaxInstanceCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_ReleaseGripperSkill_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_CurrentState_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Id = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Number = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_Number, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_LastTransition_TransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Deletable = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Deletable, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_AutoDelete = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_AutoDelete, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RecycleCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_RecycleCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Name = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Name, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_MaxInstanceCount = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_MaxInstanceCount, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Halted_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Halted_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_HaltedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Ready_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Ready_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_ReadyToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Running_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Running_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_RunningToSuspended_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended_StateNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_Suspended_StateNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToHalted_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToReady_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss.Di.Variables.GripperDeviceControllerType_Skills_GraspGripperSkill_SuspendedToRunning_TransitionNumber, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_Locked = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_Locked, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_LockingClient = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_LockingClient, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_LockingUser = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_LockingUser, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_RemainingLockTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_InitLock_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_InitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_RenewLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_ExitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SensorType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SensorType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.SensorType_Lock_BreakLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_Locked = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_Locked, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_LockingClient = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_LockingClient, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_LockingUser = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_LockingUser, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_RemainingLockTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_InitLock_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_InitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_RenewLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_ExitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_Lock_BreakLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_Locked = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_Locked, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_LockingClient = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_LockingClient, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_LockingUser = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_LockingUser, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_RemainingLockTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_InitLock_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_InitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_RenewLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_ExitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Lock_BreakLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Force Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Force = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Force, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_ForceSensor_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_ForceSensor_Force_EURange = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_ForceSensor_Force_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_Locked = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_Locked, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_LockingClient = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_LockingClient, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_LockingUser = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_LockingUser, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_RemainingLockTime = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_RemainingLockTime, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_InitLock_InputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_InitLock_InputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_InitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_InitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_RenewLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_RenewLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_ExitLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_ExitLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Lock_BreakLock_OutputArguments = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Lock_BreakLock_OutputArguments, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Torque Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Torque = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Torque, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the ForceTorqueSensorType_TorqueSensor_Torque_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ForceTorqueSensorType_TorqueSensor_Torque_EURange = new ExpandedNodeId(fortiss.Di.Variables.ForceTorqueSensorType_TorqueSensor_Torque_EURange, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_Transition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_Transition_Id = new ExpandedNodeId(fortiss.Di.Variables.SkillTransitionEventType_Transition_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_FromState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_FromState_Id = new ExpandedNodeId(fortiss.Di.Variables.SkillTransitionEventType_FromState_Id, fortiss.Di.Namespaces.fortissDi);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_ToState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_ToState_Id = new ExpandedNodeId(fortiss.Di.Variables.SkillTransitionEventType_ToState_Id, fortiss.Di.Namespaces.fortissDi);
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
        /// The BrowseName for the ForceSensor component.
        /// </summary>
        public const string ForceSensor = "ForceSensor";

        /// <summary>
        /// The BrowseName for the ForceTorqueSensorType component.
        /// </summary>
        public const string ForceTorqueSensorType = "ForceTorqueSensorType";

        /// <summary>
        /// The BrowseName for the FortissDiNamespaceMetadata component.
        /// </summary>
        public const string FortissDiNamespaceMetadata = "https://fortiss.org/UA/DI/";

        /// <summary>
        /// The BrowseName for the GraspGripperSkillType component.
        /// </summary>
        public const string GraspGripperSkillType = "GraspGripperSkill";

        /// <summary>
        /// The BrowseName for the GripperDeviceControllerType component.
        /// </summary>
        public const string GripperDeviceControllerType = "GripperDeviceControllerType";

        /// <summary>
        /// The BrowseName for the GripperSkillType component.
        /// </summary>
        public const string GripperSkillType = "GripperSkillType";

        /// <summary>
        /// The BrowseName for the ISkillControllerType component.
        /// </summary>
        public const string ISkillControllerType = "ISkillControllerType";

        /// <summary>
        /// The BrowseName for the MoveGripperSkill component.
        /// </summary>
        public const string MoveGripperSkill = "MoveGripperSkill";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the ReleaseGripperSkill component.
        /// </summary>
        public const string ReleaseGripperSkill = "ReleaseGripperSkill";

        /// <summary>
        /// The BrowseName for the SensorType component.
        /// </summary>
        public const string SensorType = "SensorType";

        /// <summary>
        /// The BrowseName for the Skills component.
        /// </summary>
        public const string Skills = "Skills";

        /// <summary>
        /// The BrowseName for the SkillTransitionEventType component.
        /// </summary>
        public const string SkillTransitionEventType = "SkillTransitionEventType";

        /// <summary>
        /// The BrowseName for the SkillType component.
        /// </summary>
        public const string SkillType = "SkillType";

        /// <summary>
        /// The BrowseName for the TorqueSensor component.
        /// </summary>
        public const string TorqueSensor = "TorqueSensor";
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
        /// The URI for the fortissDi namespace (.NET code namespace is 'fortiss.Di').
        /// </summary>
        public const string fortissDi = "https://fortiss.org/UA/DI/";

        /// <summary>
        /// The URI for the fortissDiXsd namespace (.NET code namespace is 'fortiss.Di').
        /// </summary>
        public const string fortissDiXsd = "https://fortiss.org/UA/DI/Types.xsd";
    }
    #endregion
}