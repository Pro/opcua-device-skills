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
using Opc.Ua.Robotics;
using fortiss.Robotics;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss.Di;

namespace Kuka.iiwa
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
        /// The identifier for the IiwaMotionSystem_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_InitLock = 15015;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_RenewLock = 15018;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_ExitLock = 15020;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_BreakLock = 15022;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock = 15051;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock = 15054;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock = 15056;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock = 15058;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock = 15091;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock = 15094;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock = 15096;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock = 15098;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock = 15172;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = 15175;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = 15177;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = 15179;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = 15234;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = 15237;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = 15239;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = 15241;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock = 15270;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock = 15273;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock = 15275;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock = 15277;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock = 15309;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock = 15312;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock = 15314;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock = 15316;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock = 15345;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock = 15348;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock = 15350;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock = 15352;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock = 15381;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock = 15384;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock = 15386;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock = 15388;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock = 15453;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock = 15456;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock = 15458;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock = 15460;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock = 15500;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock = 15503;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock = 15505;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock = 15507;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock = 15540;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock = 15543;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock = 15545;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock = 15547;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock = 15621;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = 15624;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = 15626;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = 15628;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = 15683;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = 15686;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = 15688;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = 15690;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet = 15706;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolClear Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolClear = 15708;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock = 15741;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock = 15744;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock = 15746;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock = 15748;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock = 15822;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock = 15825;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock = 15827;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock = 15829;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock = 15903;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock = 15906;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock = 15908;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock = 15910;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock = 15984;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock = 15987;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock = 15989;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock = 15991;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock = 16065;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock = 16068;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock = 16070;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock = 16072;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock = 16146;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock = 16149;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock = 16151;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock = 16153;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock = 16227;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock = 16230;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock = 16232;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock = 16234;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock = 16322;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock = 16325;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock = 16327;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock = 16329;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock = 16357;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock = 16360;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock = 16362;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock = 16364;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock = 16398;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock = 16401;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock = 16403;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock = 16405;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock = 16440;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock = 16443;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock = 16445;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock = 16447;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock = 16479;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock = 16482;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock = 16484;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock = 16486;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock = 16515;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock = 16518;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock = 16520;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock = 16522;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock = 16551;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock = 16554;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock = 16556;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock = 16558;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halt Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halt = 16670;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Reset Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Reset = 16671;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Resume Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Resume = 16672;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspend Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspend = 16673;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Start Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Start = 16674;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halt Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halt = 16748;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Reset Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Reset = 16749;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Resume Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Resume = 16750;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspend Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspend = 16751;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Start Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Start = 16752;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halt Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halt = 16826;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Reset Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Reset = 16827;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Resume Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Resume = 16828;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspend Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspend = 16829;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Start Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Start = 16830;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halt Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halt = 16904;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Reset Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Reset = 16905;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Resume Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Resume = 16906;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspend Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspend = 16907;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Start Method.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Start = 16908;
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
        /// The identifier for the IiwaMotionSystem Object.
        /// </summary>
        public const uint IiwaMotionSystem = 15001;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices = 15038;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet = 15040;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes = 15078;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet = 15080;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains = 15159;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers = 15257;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser = 15293;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software = 15332;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls = 15368;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet = 15370;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates Object.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates = 15440;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet = 15442;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot = 15488;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet = 15489;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes = 15527;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet = 15529;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains = 15608;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad = 15644;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool = 15710;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1 = 15729;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet = 15730;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2 = 15810;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet = 15811;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3 = 15891;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet = 15892;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4 = 15972;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet = 15973;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5 = 16053;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet = 16054;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6 = 16134;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet = 16135;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7 Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7 = 16215;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet = 16216;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors = 16310;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor = 16345;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor Object.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor = 16386;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController = 16428;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_CurrentUser Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_CurrentUser = 16463;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software = 16502;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls = 16538;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet = 16540;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills = 16610;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill = 16611;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted = 16644;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady = 16646;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready = 16648;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted = 16650;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning = 16652;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running = 16654;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted = 16656;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady = 16658;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended = 16660;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended = 16662;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted = 16664;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady = 16666;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning = 16668;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet = 16675;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill = 16689;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted = 16722;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady = 16724;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready = 16726;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted = 16728;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning = 16730;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running = 16732;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted = 16734;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady = 16736;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended = 16738;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended = 16740;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted = 16742;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady = 16744;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning = 16746;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet = 16753;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill = 16767;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted = 16800;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady = 16802;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready = 16804;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted = 16806;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning = 16808;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running = 16810;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted = 16812;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady = 16814;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended = 16816;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended = 16818;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted = 16820;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady = 16822;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning = 16824;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet = 16831;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill = 16845;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted = 16878;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady = 16880;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready = 16882;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted = 16884;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning = 16886;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running = 16888;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted = 16890;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady = 16892;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended = 16894;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended = 16896;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted = 16898;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady = 16900;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning = 16902;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet = 16909;
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
        /// The identifier for the IiwaMotionSystem_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_Locked = 15011;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_LockingClient = 15012;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_LockingUser = 15013;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_RemainingLockTime = 15014;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_InitLock_InputArguments = 15016;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_InitLock_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_RenewLock_OutputArguments = 15019;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_ExitLock_OutputArguments = 15021;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Lock_BreakLock_OutputArguments = 15023;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked = 15047;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient = 15048;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser = 15049;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime = 15050;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments = 15052;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments = 15053;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments = 15055;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments = 15057;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments = 15059;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer = 15060;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Model = 15062;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode = 15066;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber = 15069;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory = 15074;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride = 15077;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked = 15087;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient = 15088;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser = 15089;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime = 15090;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments = 15092;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = 15093;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = 15095;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = 15097;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = 15099;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile = 15114;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass = 15116;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = 15121;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15123;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = 15125;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15130;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15131;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15132;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = 15133;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = 15134;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = 15135;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = 15138;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = 15139;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = 15140;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition = 15141;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = 15146;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = 15152;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = 15158;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked = 15168;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = 15169;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = 15170;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = 15171;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = 15173;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = 15174;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = 15176;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = 15178;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = 15180;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass = 15196;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits = 15201;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates = 15203;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation = 15205;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X = 15210;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = 15211;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = 15212;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A = 15213;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B = 15214;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C = 15215;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X = 15218;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y = 15219;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z = 15220;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = 15230;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = 15231;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = 15232;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = 15233;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = 15235;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = 15236;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = 15238;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = 15240;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = 15242;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_Locked = 15266;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient = 15267;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser = 15268;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime = 15269;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments = 15271;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments = 15272;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments = 15274;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments = 15276;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments = 15278;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Manufacturer = 15279;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Model = 15281;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ProductCode Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ProductCode = 15285;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_SerialNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_SerialNumber = 15288;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level = 15294;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked = 15305;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient = 15306;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser = 15307;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime = 15308;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments = 15310;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = 15311;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = 15313;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = 15315;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = 15317;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked = 15341;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient = 15342;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser = 15343;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime = 15344;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = 15346;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = 15347;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = 15349;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = 15351;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = 15353;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer = 15354;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model = 15356;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision = 15358;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked = 15377;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient = 15378;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser = 15379;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = 15380;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = 15382;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = 15383;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = 15385;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = 15387;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = 15389;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName = 15403;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = 15404;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = 15405;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits = 15415;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits = 15421;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits = 15427;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits = 15433;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits = 15439;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked = 15449;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient = 15450;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser = 15451;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime = 15452;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments = 15454;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments = 15455;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments = 15457;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments = 15459;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments = 15461;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name = 15478;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active = 15479;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name = 15482;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled = 15483;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active = 15484;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode = 15485;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop = 15486;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop Variable.
        /// </summary>
        public const uint IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop = 15487;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_Locked = 15496;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingClient = 15497;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingUser = 15498;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RemainingLockTime = 15499;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_InputArguments = 15501;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_OutputArguments = 15502;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock_OutputArguments = 15504;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock_OutputArguments = 15506;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock_OutputArguments = 15508;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Manufacturer = 15509;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Model = 15511;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ProductCode Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ProductCode = 15515;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_SerialNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_SerialNumber = 15518;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_MotionDeviceCategory Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_MotionDeviceCategory = 15523;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet_SpeedOverride = 15526;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_Locked = 15536;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingClient = 15537;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingUser = 15538;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RemainingLockTime = 15539;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments = 15541;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = 15542;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = 15544;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = 15546;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = 15548;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_MotionProfile = 15563;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass = 15565;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = 15570;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15572;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = 15574;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15579;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15580;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15581;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = 15582;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = 15583;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = 15584;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = 15587;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = 15588;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = 15589;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition = 15590;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = 15595;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = 15601;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = 15607;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked = 15617;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = 15618;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = 15619;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = 15620;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = 15622;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = 15623;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = 15625;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = 15627;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = 15629;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass = 15645;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass_EngineeringUnits = 15650;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates = 15652;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation = 15654;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X = 15659;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = 15660;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = 15661;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_A = 15662;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_B = 15663;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_C = 15664;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_X = 15667;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Y = 15668;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Z = 15669;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = 15679;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = 15680;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = 15681;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = 15682;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = 15684;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = 15685;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = 15687;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = 15689;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = 15691;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet_InputArguments = 15707;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_Name = 15711;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame = 15712;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates = 15713;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation = 15715;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X = 15720;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = 15721;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = 15722;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_A = 15723;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_B = 15724;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_C = 15725;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_Locked = 15737;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingClient = 15738;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingUser = 15739;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RemainingLockTime = 15740;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_InputArguments = 15742;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_OutputArguments = 15743;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments = 15745;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments = 15747;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments = 15749;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_MotionProfile = 15764;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass = 15766;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits = 15771;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15773;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation = 15775;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15780;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15781;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15782;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A = 15783;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B = 15784;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C = 15785;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_X = 15788;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y = 15789;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z = 15790;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition = 15791;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits = 15796;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed = 15797;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EngineeringUnits = 15802;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits = 15808;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_Locked = 15818;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingClient = 15819;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingUser = 15820;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RemainingLockTime = 15821;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_InputArguments = 15823;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_OutputArguments = 15824;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments = 15826;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments = 15828;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments = 15830;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_MotionProfile = 15845;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass = 15847;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits = 15852;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15854;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation = 15856;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15861;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15862;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15863;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A = 15864;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B = 15865;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C = 15866;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_X = 15869;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y = 15870;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z = 15871;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition = 15872;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits = 15877;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed = 15878;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits = 15883;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits = 15889;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_Locked = 15899;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingClient = 15900;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingUser = 15901;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RemainingLockTime = 15902;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_InputArguments = 15904;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_OutputArguments = 15905;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments = 15907;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments = 15909;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments = 15911;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_MotionProfile = 15926;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass = 15928;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits = 15933;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates = 15935;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation = 15937;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 15942;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 15943;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 15944;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A = 15945;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B = 15946;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C = 15947;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_X = 15950;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y = 15951;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z = 15952;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition = 15953;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits = 15958;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed = 15959;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits = 15964;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits = 15970;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_Locked = 15980;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingClient = 15981;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingUser = 15982;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RemainingLockTime = 15983;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_InputArguments = 15985;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_OutputArguments = 15986;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments = 15988;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments = 15990;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments = 15992;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_MotionProfile = 16007;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass = 16009;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits = 16014;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates = 16016;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation = 16018;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 16023;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 16024;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 16025;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A = 16026;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B = 16027;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C = 16028;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_X = 16031;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y = 16032;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z = 16033;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition = 16034;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits = 16039;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed = 16040;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits = 16045;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits = 16051;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_Locked = 16061;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingClient = 16062;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingUser = 16063;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RemainingLockTime = 16064;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_InputArguments = 16066;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_OutputArguments = 16067;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments = 16069;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments = 16071;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments = 16073;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_MotionProfile = 16088;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass = 16090;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits = 16095;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates = 16097;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation = 16099;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 16104;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 16105;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 16106;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A = 16107;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B = 16108;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C = 16109;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_X = 16112;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y = 16113;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z = 16114;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition = 16115;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits = 16120;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed = 16121;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits = 16126;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits = 16132;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_Locked = 16142;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingClient = 16143;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingUser = 16144;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RemainingLockTime = 16145;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_InputArguments = 16147;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_OutputArguments = 16148;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments = 16150;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments = 16152;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments = 16154;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_MotionProfile = 16169;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass = 16171;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits = 16176;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates = 16178;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation = 16180;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 16185;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 16186;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 16187;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A = 16188;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B = 16189;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C = 16190;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_X = 16193;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y = 16194;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z = 16195;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition = 16196;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits = 16201;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed = 16202;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits = 16207;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits = 16213;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_Locked = 16223;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingClient = 16224;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingUser = 16225;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RemainingLockTime = 16226;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_InputArguments = 16228;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_OutputArguments = 16229;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock_OutputArguments = 16231;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock_OutputArguments = 16233;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock_OutputArguments = 16235;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_MotionProfile Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_MotionProfile = 16250;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass = 16252;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass_EngineeringUnits = 16257;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates = 16259;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation = 16261;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 16266;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 16267;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 16268;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_A = 16269;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_B = 16270;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_C = 16271;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_X = 16274;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Y = 16275;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Z = 16276;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition = 16277;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition_EngineeringUnits = 16282;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed = 16283;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed_EngineeringUnits = 16288;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualAcceleration_EngineeringUnits = 16294;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position = 16296;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates = 16297;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation = 16299;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_X = 16304;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Y = 16305;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Z = 16306;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_A Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_A = 16307;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_B Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_B = 16308;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_C Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_C = 16309;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_Locked = 16318;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingClient = 16319;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingUser = 16320;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RemainingLockTime = 16321;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_InputArguments = 16323;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_OutputArguments = 16324;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock_OutputArguments = 16326;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock_OutputArguments = 16328;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock_OutputArguments = 16330;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_Locked = 16353;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingClient = 16354;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingUser = 16355;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RemainingLockTime = 16356;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_InputArguments = 16358;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_OutputArguments = 16359;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock_OutputArguments = 16361;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock_OutputArguments = 16363;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock_OutputArguments = 16365;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force = 16380;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force_EURange = 16384;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_Locked = 16394;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingClient = 16395;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingUser = 16396;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RemainingLockTime = 16397;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_InputArguments = 16399;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_OutputArguments = 16400;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock_OutputArguments = 16402;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock_OutputArguments = 16404;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock_OutputArguments = 16406;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque = 16421;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque_EURange = 16425;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Led Variable.
        /// </summary>
        public const uint IiwaMotionSystem_MotionDevices_IiwaRobot_Led = 16427;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_Locked = 16436;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_LockingClient = 16437;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_LockingUser = 16438;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_RemainingLockTime = 16439;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_InputArguments = 16441;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_OutputArguments = 16442;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock_OutputArguments = 16444;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock_OutputArguments = 16446;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock_OutputArguments = 16448;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Manufacturer = 16449;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Model = 16451;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ProductCode Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ProductCode = 16455;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_SerialNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_SerialNumber = 16458;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_CurrentUser_Level Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_CurrentUser_Level = 16464;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_Locked = 16475;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingClient = 16476;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingUser = 16477;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RemainingLockTime = 16478;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_InputArguments = 16480;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = 16481;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = 16483;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = 16485;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = 16487;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_Locked = 16511;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingClient = 16512;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingUser = 16513;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RemainingLockTime = 16514;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = 16516;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = 16517;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = 16519;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = 16521;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = 16523;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Manufacturer = 16524;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Model = 16526;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_SoftwareRevision = 16528;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_Locked = 16547;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingClient = 16548;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingUser = 16549;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = 16550;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = 16552;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = 16553;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = 16555;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = 16557;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = 16559;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ComponentName = 16573;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = 16574;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = 16575;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ParameterSet_TotalEnergyConsumption_EngineeringUnits = 16585;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CabinetFanSpeed_EngineeringUnits = 16591;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CPUFanSpeed_EngineeringUnits = 16597;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ParameterSet_InputVoltage_EngineeringUnits = 16603;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_ParameterSet_Temperature_EngineeringUnits = 16609;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState = 16612;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Id = 16613;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Number = 16615;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition = 16617;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Id = 16618;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Number = 16620;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime = 16621;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Deletable Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Deletable = 16625;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_AutoDelete = 16626;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RecycleCount = 16627;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId = 16629;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName = 16630;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = 16631;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = 16632;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall = 16633;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = 16634;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 16635;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 16636;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = 16637;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 16638;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = 16639;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 16640;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Name = 16642;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_MaxInstanceCount = 16643;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted_StateNumber = 16645;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady_TransitionNumber = 16647;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready_StateNumber = 16649;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted_TransitionNumber = 16651;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning_TransitionNumber = 16653;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running_StateNumber = 16655;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted_TransitionNumber = 16657;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady_TransitionNumber = 16659;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended_TransitionNumber = 16661;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended_StateNumber = 16663;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted_TransitionNumber = 16665;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady_TransitionNumber = 16667;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning_TransitionNumber = 16669;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame = 16676;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration = 16677;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EURange = 16681;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity = 16683;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EURange = 16687;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState = 16690;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Id = 16691;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Number = 16693;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition = 16695;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Id = 16696;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Number = 16698;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime = 16699;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Deletable Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Deletable = 16703;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_AutoDelete = 16704;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RecycleCount = 16705;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId = 16707;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName = 16708;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = 16709;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = 16710;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall = 16711;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = 16712;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 16713;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 16714;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = 16715;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 16716;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = 16717;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 16718;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Name = 16720;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_MaxInstanceCount = 16721;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted_StateNumber = 16723;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady_TransitionNumber = 16725;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready_StateNumber = 16727;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted_TransitionNumber = 16729;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning_TransitionNumber = 16731;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running_StateNumber = 16733;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted_TransitionNumber = 16735;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady_TransitionNumber = 16737;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended_TransitionNumber = 16739;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended_StateNumber = 16741;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted_TransitionNumber = 16743;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady_TransitionNumber = 16745;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning_TransitionNumber = 16747;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame = 16754;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration = 16755;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EURange = 16759;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity = 16761;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EURange = 16765;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState = 16768;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Id = 16769;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Number = 16771;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition = 16773;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Id = 16774;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Number = 16776;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime = 16777;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Deletable Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Deletable = 16781;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_AutoDelete = 16782;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RecycleCount = 16783;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId = 16785;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName = 16786;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = 16787;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = 16788;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall = 16789;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = 16790;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 16791;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 16792;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = 16793;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 16794;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = 16795;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 16796;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Name = 16798;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_MaxInstanceCount = 16799;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted_StateNumber = 16801;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady_TransitionNumber = 16803;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready_StateNumber = 16805;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted_TransitionNumber = 16807;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning_TransitionNumber = 16809;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running_StateNumber = 16811;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted_TransitionNumber = 16813;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady_TransitionNumber = 16815;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended_TransitionNumber = 16817;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended_StateNumber = 16819;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted_TransitionNumber = 16821;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady_TransitionNumber = 16823;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning_TransitionNumber = 16825;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame = 16832;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration = 16833;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EURange = 16837;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity = 16839;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EURange = 16843;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds = 16923;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState = 16846;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Id = 16847;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Number = 16849;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition = 16851;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Id = 16852;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Number = 16854;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime = 16855;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Deletable Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Deletable = 16859;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_AutoDelete = 16860;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RecycleCount = 16861;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId = 16863;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName = 16864;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = 16865;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = 16866;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall = 16867;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = 16868;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 16869;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 16870;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = 16871;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 16872;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = 16873;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 16874;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Name Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Name = 16876;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_MaxInstanceCount = 16877;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted_StateNumber = 16879;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady_TransitionNumber = 16881;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready_StateNumber = 16883;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted_TransitionNumber = 16885;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning_TransitionNumber = 16887;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running_StateNumber = 16889;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted_TransitionNumber = 16891;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady_TransitionNumber = 16893;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended_TransitionNumber = 16895;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended_StateNumber = 16897;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted_TransitionNumber = 16899;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady_TransitionNumber = 16901;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning_TransitionNumber = 16903;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame = 16910;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration = 16911;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EURange = 16915;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity = 16917;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EURange = 16921;

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public const uint IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds = 16924;
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
        /// The identifier for the IiwaMotionSystem_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolClear Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolClear = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolClear, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halt = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halt, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Reset = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Reset, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Resume = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Resume, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspend = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspend, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Start = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Start, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halt = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halt, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Reset = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Reset, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Resume = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Resume, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspend = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspend, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Start = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Start, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halt = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halt, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Reset = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Reset, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Resume = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Resume, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspend = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspend, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Start = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Start, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halt = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halt, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Reset = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Reset, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Resume = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Resume, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspend = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspend, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Start = new ExpandedNodeId(Kuka.iiwa.Methods.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Start, Kuka.iiwa.Namespaces.KukaIiwa);
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
        /// The identifier for the IiwaMotionSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_ControllerIdentifier_Software, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_SafetyStates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7 Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7 = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_CurrentUser Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_CurrentUser = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_CurrentUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Software, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_TaskControls, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet = new ExpandedNodeId(Kuka.iiwa.Objects.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet, Kuka.iiwa.Namespaces.KukaIiwa);
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
        /// The identifier for the IiwaMotionSystem_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ProductCode = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ProductCode, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_SerialNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_SerialNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ProductCode = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ProductCode, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_SerialNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_SerialNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_MotionDeviceCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_MotionDeviceCategory = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_MotionDeviceCategory, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet_SpeedOverride = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ParameterSet_SpeedOverride, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeToolSet_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_FlangeTool_ThreeDFrame_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_MotionProfile = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_MotionProfile, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Mass_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_CenterOfMass_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_AdditionalLoad_Inertia_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualPosition_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Axes_Axis_7_ParameterSet_ActualAcceleration_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_X = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_X, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Y = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Y, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Z = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_CartesianCoordinates_Z, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_A = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_A, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_B = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_B, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_C = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Position_Orientation_C, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_ForceSensor_Force_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_ForceTorqueSensors_TorqueSensor_Torque_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_MotionDevices_IiwaRobot_Led Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_MotionDevices_IiwaRobot_Led = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_MotionDevices_IiwaRobot_Led, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ProductCode = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ProductCode, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_SerialNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_SerialNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_CurrentUser_Level Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_CurrentUser_Level = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_CurrentUser_Level, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Manufacturer = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Manufacturer, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Model = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_Model, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_SoftwareRevision = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Software_SoftwareIdentifier_SoftwareRevision, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_Locked = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_Locked, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingClient = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingClient, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingUser = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_LockingUser, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ComponentName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ComponentName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ParameterSet_TotalEnergyConsumption_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ParameterSet_TotalEnergyConsumption_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CabinetFanSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CabinetFanSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CPUFanSpeed_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ParameterSet_CPUFanSpeed_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ParameterSet_InputVoltage_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ParameterSet_InputVoltage_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_ParameterSet_Temperature_EngineeringUnits = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_ParameterSet_Temperature_EngineeringUnits, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_CurrentState_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Deletable = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Deletable, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_AutoDelete = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_AutoDelete, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RecycleCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RecycleCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_MaxInstanceCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_MaxInstanceCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Halted_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_HaltedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Ready_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ReadyToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Running_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_RunningToSuspended_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_Suspended_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_SuspendedToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_CurrentState_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Deletable = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Deletable, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_AutoDelete = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_AutoDelete, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RecycleCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RecycleCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_MaxInstanceCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_MaxInstanceCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Halted_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_HaltedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Ready_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ReadyToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Running_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_RunningToSuspended_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_Suspended_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_SuspendedToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_CurrentState_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Deletable = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Deletable, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_AutoDelete = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_AutoDelete, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RecycleCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RecycleCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_MaxInstanceCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_MaxInstanceCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Halted_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_HaltedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Ready_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ReadyToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Running_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_RunningToSuspended_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_Suspended_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_SuspendedToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_CurrentState_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Id = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Id, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Number = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_Number, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Deletable = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Deletable, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_AutoDelete = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_AutoDelete, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RecycleCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RecycleCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Name = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Name, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_MaxInstanceCount = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_MaxInstanceCount, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Halted_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_HaltedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Ready_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ReadyToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Running_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_RunningToSuspended_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended_StateNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_Suspended_StateNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToHalted_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToReady_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_SuspendedToRunning_TransitionNumber, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EURange = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EURange, Kuka.iiwa.Namespaces.KukaIiwa);

        /// <summary>
        /// The identifier for the IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public static readonly ExpandedNodeId IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds = new ExpandedNodeId(Kuka.iiwa.Variables.IiwaMotionSystem_Controllers_IiwaController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds, Kuka.iiwa.Namespaces.KukaIiwa);
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
        /// The BrowseName for the IiwaMotionSystem component.
        /// </summary>
        public const string IiwaMotionSystem = "IiwaMotionSystem";
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
        /// The URI for the KukaIiwa namespace (.NET code namespace is 'Kuka.iiwa').
        /// </summary>
        public const string KukaIiwa = "https://fortiss.org/UA/kuka_iiwa/";

        /// <summary>
        /// The URI for the KukaIiwaXsd namespace (.NET code namespace is 'Kuka.iiwa').
        /// </summary>
        public const string KukaIiwaXsd = "https://fortiss.org/UA/kuka_iiwa/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaRobotics namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRobotics = "http://opcfoundation.org/UA/Robotics/";

        /// <summary>
        /// The URI for the OpcUaRoboticsXsd namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRoboticsXsd = "http://opcfoundation.org/UA/Robotics/Types.xsd";

        /// <summary>
        /// The URI for the fortissRobotics namespace (.NET code namespace is 'fortiss.Robotics').
        /// </summary>
        public const string fortissRobotics = "https://fortiss.org/UA/Robotics/";

        /// <summary>
        /// The URI for the fortissRoboticsXsd namespace (.NET code namespace is 'fortiss.Robotics').
        /// </summary>
        public const string fortissRoboticsXsd = "https://fortiss.org/UA/Robotics/Types.xsd";

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