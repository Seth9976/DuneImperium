using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x0200000D RID: 13
	public class InputDevices : Object
	{
		// Token: 0x06000099 RID: 153 RVA: 0x000044C4 File Offset: 0x000026C4
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevices()
		{
			Il2CppClassPointerStore<InputDevices>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputDevices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevices>.NativeClassPtr);
			InputDevices.NativeFieldInfoPtr_deviceConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceConnected");
			InputDevices.NativeFieldInfoPtr_deviceDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceDisconnected");
			InputDevices.NativeFieldInfoPtr_deviceConfigChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceConfigChanged");
			InputDevices.NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, 100663326);
			InputDevices.GetDevices_InternalDelegateField = IL2CPP.ResolveICall<InputDevices.GetDevices_InternalDelegate>("UnityEngine.XR.InputDevices::GetDevices_Internal");
			InputDevices.SendHapticImpulseDelegateField = IL2CPP.ResolveICall<InputDevices.SendHapticImpulseDelegate>("UnityEngine.XR.InputDevices::SendHapticImpulse");
			InputDevices.SendHapticBufferDelegateField = IL2CPP.ResolveICall<InputDevices.SendHapticBufferDelegate>("UnityEngine.XR.InputDevices::SendHapticBuffer");
			InputDevices.StopHapticsDelegateField = IL2CPP.ResolveICall<InputDevices.StopHapticsDelegate>("UnityEngine.XR.InputDevices::StopHaptics");
			InputDevices.TryGetFeatureUsagesDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureUsagesDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureUsages");
			InputDevices.TryGetFeatureValue_boolDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_boolDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_bool");
			InputDevices.TryGetFeatureValue_UInt32DelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_UInt32Delegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_UInt32");
			InputDevices.TryGetFeatureValue_floatDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_floatDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_float");
			InputDevices.TryGetFeatureValue_Vector2fDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_Vector2fDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector2f");
			InputDevices.TryGetFeatureValue_Vector3fDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_Vector3fDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector3f");
			InputDevices.TryGetFeatureValue_QuaternionfDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_QuaternionfDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Quaternionf");
			InputDevices.TryGetFeatureValue_CustomDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_CustomDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Custom");
			InputDevices.TryGetFeatureValueAtTime_boolDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_boolDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_bool");
			InputDevices.TryGetFeatureValueAtTime_UInt32DelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_UInt32Delegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_UInt32");
			InputDevices.TryGetFeatureValueAtTime_floatDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_floatDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_float");
			InputDevices.TryGetFeatureValueAtTime_Vector2fDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_Vector2fDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector2f");
			InputDevices.TryGetFeatureValueAtTime_Vector3fDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_Vector3fDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector3f");
			InputDevices.TryGetFeatureValueAtTime_QuaternionfDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValueAtTime_QuaternionfDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Quaternionf");
			InputDevices.TryGetFeatureValue_XRHandDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_XRHandDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XRHand");
			InputDevices.TryGetFeatureValue_XRBoneDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_XRBoneDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XRBone");
			InputDevices.TryGetFeatureValue_XREyesDelegateField = IL2CPP.ResolveICall<InputDevices.TryGetFeatureValue_XREyesDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XREyes");
			InputDevices.IsDeviceValidDelegateField = IL2CPP.ResolveICall<InputDevices.IsDeviceValidDelegate>("UnityEngine.XR.InputDevices::IsDeviceValid");
			InputDevices.GetDeviceNameDelegateField = IL2CPP.ResolveICall<InputDevices.GetDeviceNameDelegate>("UnityEngine.XR.InputDevices::GetDeviceName");
			InputDevices.GetDeviceManufacturerDelegateField = IL2CPP.ResolveICall<InputDevices.GetDeviceManufacturerDelegate>("UnityEngine.XR.InputDevices::GetDeviceManufacturer");
			InputDevices.GetDeviceSerialNumberDelegateField = IL2CPP.ResolveICall<InputDevices.GetDeviceSerialNumberDelegate>("UnityEngine.XR.InputDevices::GetDeviceSerialNumber");
			InputDevices.GetDeviceCharacteristicsDelegateField = IL2CPP.ResolveICall<InputDevices.GetDeviceCharacteristicsDelegate>("UnityEngine.XR.InputDevices::GetDeviceCharacteristics");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000046CC File Offset: 0x000028CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258718, XrefRangeEnd = 1258724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevices.NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000023E0 File Offset: 0x000005E0
		public InputDevices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000023E9 File Offset: 0x000005E9
		public unsafe static Action<InputDevice> deviceConnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputDevices.NativeFieldInfoPtr_deviceConnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevices.NativeFieldInfoPtr_deviceConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004734 File Offset: 0x00002934
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000023FB File Offset: 0x000005FB
		public unsafe static Action<InputDevice> deviceDisconnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputDevices.NativeFieldInfoPtr_deviceDisconnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevices.NativeFieldInfoPtr_deviceDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000475C File Offset: 0x0000295C
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe static Action<InputDevice> deviceConfigChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputDevices.NativeFieldInfoPtr_deviceConfigChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevices.NativeFieldInfoPtr_deviceConfigChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004784 File Offset: 0x00002984
		public static InputDevice GetDeviceAtXRNode(XRNode node)
		{
			ulong deviceIdAtXRNode = InputTracking.GetDeviceIdAtXRNode(node);
			return new InputDevice(deviceIdAtXRNode);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000047A4 File Offset: 0x000029A4
		public static void GetDevicesAtXRNode(XRNode node, List<InputDevice> inputDevices)
		{
			bool flag = inputDevices == null;
			if (flag)
			{
				throw new ArgumentNullException("inputDevices");
			}
			List<ulong> list = new List<ulong>();
			InputTracking.GetDeviceIdsAtXRNode_Internal(node, list);
			inputDevices.Clear();
			List<ulong>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong num = enumerator.Current;
					InputDevice inputDevice = new InputDevice(num);
					bool isValid = inputDevice.isValid;
					if (isValid)
					{
						inputDevices.Add(inputDevice);
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004838 File Offset: 0x00002A38
		public static void GetDevices(List<InputDevice> inputDevices)
		{
			bool flag = inputDevices == null;
			if (flag)
			{
				throw new ArgumentNullException("inputDevices");
			}
			inputDevices.Clear();
			InputDevices.GetDevices_Internal(inputDevices);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000241F File Offset: 0x0000061F
		public static void GetDevicesWithRole(InputDeviceRole role, List<InputDevice> inputDevices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000242C File Offset: 0x0000062C
		public static void GetDevicesWithCharacteristics(InputDeviceCharacteristics desiredCharacteristics, List<InputDevice> inputDevices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002439 File Offset: 0x00000639
		public static void add_deviceConnected(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002446 File Offset: 0x00000646
		public static void remove_deviceConnected(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002453 File Offset: 0x00000653
		public static void add_deviceDisconnected(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002460 File Offset: 0x00000660
		public static void remove_deviceDisconnected(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000246D File Offset: 0x0000066D
		public static void add_deviceConfigChanged(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000247A File Offset: 0x0000067A
		public static void remove_deviceConfigChanged(Action<InputDevice> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002487 File Offset: 0x00000687
		public static void GetDevices_Internal(List<InputDevice> inputDevices)
		{
			InputDevices.GetDevices_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(inputDevices));
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002499 File Offset: 0x00000699
		public static bool SendHapticImpulse(ulong deviceId, uint channel, float amplitude, float duration)
		{
			return InputDevices.SendHapticImpulseDelegateField(deviceId, channel, amplitude, duration);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000024A9 File Offset: 0x000006A9
		public static bool SendHapticBuffer(ulong deviceId, uint channel, Il2CppStructArray<byte> buffer)
		{
			return InputDevices.SendHapticBufferDelegateField(deviceId, channel, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000024BD File Offset: 0x000006BD
		public static void StopHaptics(ulong deviceId)
		{
			InputDevices.StopHapticsDelegateField(deviceId);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000024CA File Offset: 0x000006CA
		public static bool TryGetFeatureUsages(ulong deviceId, List<InputFeatureUsage> featureUsages)
		{
			return InputDevices.TryGetFeatureUsagesDelegateField(deviceId, IL2CPP.Il2CppObjectBaseToPtr(featureUsages));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000024DD File Offset: 0x000006DD
		public static bool TryGetFeatureValue_bool(ulong deviceId, string usage, out bool value)
		{
			return InputDevices.TryGetFeatureValue_boolDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000024F1 File Offset: 0x000006F1
		public static bool TryGetFeatureValue_UInt32(ulong deviceId, string usage, out uint value)
		{
			return InputDevices.TryGetFeatureValue_UInt32DelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002505 File Offset: 0x00000705
		public static bool TryGetFeatureValue_float(ulong deviceId, string usage, out float value)
		{
			return InputDevices.TryGetFeatureValue_floatDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002519 File Offset: 0x00000719
		public static bool TryGetFeatureValue_Vector2f(ulong deviceId, string usage, out Vector2 value)
		{
			return InputDevices.TryGetFeatureValue_Vector2fDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000252D File Offset: 0x0000072D
		public static bool TryGetFeatureValue_Vector3f(ulong deviceId, string usage, out Vector3 value)
		{
			return InputDevices.TryGetFeatureValue_Vector3fDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002541 File Offset: 0x00000741
		public static bool TryGetFeatureValue_Quaternionf(ulong deviceId, string usage, out Quaternion value)
		{
			return InputDevices.TryGetFeatureValue_QuaternionfDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002555 File Offset: 0x00000755
		public static bool TryGetFeatureValue_Custom(ulong deviceId, string usage, [Out] Il2CppStructArray<byte> value)
		{
			return InputDevices.TryGetFeatureValue_CustomDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000256E File Offset: 0x0000076E
		public static bool TryGetFeatureValueAtTime_bool(ulong deviceId, string usage, long time, out bool value)
		{
			return InputDevices.TryGetFeatureValueAtTime_boolDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002583 File Offset: 0x00000783
		public static bool TryGetFeatureValueAtTime_UInt32(ulong deviceId, string usage, long time, out uint value)
		{
			return InputDevices.TryGetFeatureValueAtTime_UInt32DelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002598 File Offset: 0x00000798
		public static bool TryGetFeatureValueAtTime_float(ulong deviceId, string usage, long time, out float value)
		{
			return InputDevices.TryGetFeatureValueAtTime_floatDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000025AD File Offset: 0x000007AD
		public static bool TryGetFeatureValueAtTime_Vector2f(ulong deviceId, string usage, long time, out Vector2 value)
		{
			return InputDevices.TryGetFeatureValueAtTime_Vector2fDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000025C2 File Offset: 0x000007C2
		public static bool TryGetFeatureValueAtTime_Vector3f(ulong deviceId, string usage, long time, out Vector3 value)
		{
			return InputDevices.TryGetFeatureValueAtTime_Vector3fDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000025D7 File Offset: 0x000007D7
		public static bool TryGetFeatureValueAtTime_Quaternionf(ulong deviceId, string usage, long time, out Quaternion value)
		{
			return InputDevices.TryGetFeatureValueAtTime_QuaternionfDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), time, out value);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000025EC File Offset: 0x000007EC
		public static bool TryGetFeatureValue_XRHand(ulong deviceId, string usage, out Hand value)
		{
			return InputDevices.TryGetFeatureValue_XRHandDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002600 File Offset: 0x00000800
		public static bool TryGetFeatureValue_XRBone(ulong deviceId, string usage, out Bone value)
		{
			return InputDevices.TryGetFeatureValue_XRBoneDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002614 File Offset: 0x00000814
		public static bool TryGetFeatureValue_XREyes(ulong deviceId, string usage, out Eyes value)
		{
			return InputDevices.TryGetFeatureValue_XREyesDelegateField(deviceId, IL2CPP.ManagedStringToIl2Cpp(usage), out value);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002628 File Offset: 0x00000828
		public static bool IsDeviceValid(ulong deviceId)
		{
			return InputDevices.IsDeviceValidDelegateField(deviceId);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004868 File Offset: 0x00002A68
		public static string GetDeviceName(ulong deviceId)
		{
			IntPtr intPtr = InputDevices.GetDeviceNameDelegateField(deviceId);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004888 File Offset: 0x00002A88
		public static string GetDeviceManufacturer(ulong deviceId)
		{
			IntPtr intPtr = InputDevices.GetDeviceManufacturerDelegateField(deviceId);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000048A8 File Offset: 0x00002AA8
		public static string GetDeviceSerialNumber(ulong deviceId)
		{
			IntPtr intPtr = InputDevices.GetDeviceSerialNumberDelegateField(deviceId);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002635 File Offset: 0x00000835
		public static InputDeviceCharacteristics GetDeviceCharacteristics(ulong deviceId)
		{
			return InputDevices.GetDeviceCharacteristicsDelegateField(deviceId);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000048C8 File Offset: 0x00002AC8
		public static InputDeviceRole GetDeviceRole(ulong deviceId)
		{
			InputDeviceCharacteristics deviceCharacteristics = InputDevices.GetDeviceCharacteristics(deviceId);
			bool flag = (deviceCharacteristics & (InputDeviceCharacteristics)33U) == (InputDeviceCharacteristics)33U;
			InputDeviceRole inputDeviceRole;
			if (flag)
			{
				inputDeviceRole = InputDeviceRole.Generic;
			}
			else
			{
				bool flag2 = (deviceCharacteristics & (InputDeviceCharacteristics)292U) == (InputDeviceCharacteristics)292U;
				if (flag2)
				{
					inputDeviceRole = InputDeviceRole.LeftHanded;
				}
				else
				{
					bool flag3 = (deviceCharacteristics & (InputDeviceCharacteristics)548U) == (InputDeviceCharacteristics)548U;
					if (flag3)
					{
						inputDeviceRole = InputDeviceRole.RightHanded;
					}
					else
					{
						bool flag4 = (deviceCharacteristics & InputDeviceCharacteristics.Controller) == InputDeviceCharacteristics.Controller;
						if (flag4)
						{
							inputDeviceRole = InputDeviceRole.GameController;
						}
						else
						{
							bool flag5 = (deviceCharacteristics & (InputDeviceCharacteristics)160U) == (InputDeviceCharacteristics)160U;
							if (flag5)
							{
								inputDeviceRole = InputDeviceRole.TrackingReference;
							}
							else
							{
								bool flag6 = (deviceCharacteristics & InputDeviceCharacteristics.TrackedDevice) == InputDeviceCharacteristics.TrackedDevice;
								if (flag6)
								{
									inputDeviceRole = InputDeviceRole.HardwareTracker;
								}
								else
								{
									inputDeviceRole = InputDeviceRole.Unknown;
								}
							}
						}
					}
				}
			}
			return inputDeviceRole;
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_deviceConnected;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_deviceDisconnected;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_deviceConfigChanged;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0;

		// Token: 0x04000081 RID: 129
		private static readonly InputDevices.GetDevices_InternalDelegate GetDevices_InternalDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly InputDevices.SendHapticImpulseDelegate SendHapticImpulseDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly InputDevices.SendHapticBufferDelegate SendHapticBufferDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly InputDevices.StopHapticsDelegate StopHapticsDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly InputDevices.TryGetFeatureUsagesDelegate TryGetFeatureUsagesDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly InputDevices.TryGetFeatureValue_boolDelegate TryGetFeatureValue_boolDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly InputDevices.TryGetFeatureValue_UInt32Delegate TryGetFeatureValue_UInt32DelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly InputDevices.TryGetFeatureValue_floatDelegate TryGetFeatureValue_floatDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly InputDevices.TryGetFeatureValue_Vector2fDelegate TryGetFeatureValue_Vector2fDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly InputDevices.TryGetFeatureValue_Vector3fDelegate TryGetFeatureValue_Vector3fDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly InputDevices.TryGetFeatureValue_QuaternionfDelegate TryGetFeatureValue_QuaternionfDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly InputDevices.TryGetFeatureValue_CustomDelegate TryGetFeatureValue_CustomDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly InputDevices.TryGetFeatureValueAtTime_boolDelegate TryGetFeatureValueAtTime_boolDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly InputDevices.TryGetFeatureValueAtTime_UInt32Delegate TryGetFeatureValueAtTime_UInt32DelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly InputDevices.TryGetFeatureValueAtTime_floatDelegate TryGetFeatureValueAtTime_floatDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly InputDevices.TryGetFeatureValueAtTime_Vector2fDelegate TryGetFeatureValueAtTime_Vector2fDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly InputDevices.TryGetFeatureValueAtTime_Vector3fDelegate TryGetFeatureValueAtTime_Vector3fDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly InputDevices.TryGetFeatureValueAtTime_QuaternionfDelegate TryGetFeatureValueAtTime_QuaternionfDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly InputDevices.TryGetFeatureValue_XRHandDelegate TryGetFeatureValue_XRHandDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly InputDevices.TryGetFeatureValue_XRBoneDelegate TryGetFeatureValue_XRBoneDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly InputDevices.TryGetFeatureValue_XREyesDelegate TryGetFeatureValue_XREyesDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly InputDevices.IsDeviceValidDelegate IsDeviceValidDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly InputDevices.GetDeviceNameDelegate GetDeviceNameDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly InputDevices.GetDeviceManufacturerDelegate GetDeviceManufacturerDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly InputDevices.GetDeviceSerialNumberDelegate GetDeviceSerialNumberDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly InputDevices.GetDeviceCharacteristicsDelegate GetDeviceCharacteristicsDelegateField;

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate void GetDevices_InternalDelegate(IntPtr inputDevices);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate bool SendHapticImpulseDelegate(ulong deviceId, uint channel, float amplitude, float duration);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate bool SendHapticBufferDelegate(ulong deviceId, uint channel, IntPtr buffer);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate void StopHapticsDelegate(ulong deviceId);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate bool TryGetFeatureUsagesDelegate(ulong deviceId, IntPtr featureUsages);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate bool TryGetFeatureValue_boolDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate bool TryGetFeatureValue_UInt32Delegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate bool TryGetFeatureValue_floatDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate bool TryGetFeatureValue_Vector2fDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate bool TryGetFeatureValue_Vector3fDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate bool TryGetFeatureValue_QuaternionfDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate bool TryGetFeatureValue_CustomDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate bool TryGetFeatureValueAtTime_boolDelegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate bool TryGetFeatureValueAtTime_UInt32Delegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate bool TryGetFeatureValueAtTime_floatDelegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate bool TryGetFeatureValueAtTime_Vector2fDelegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate bool TryGetFeatureValueAtTime_Vector3fDelegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate bool TryGetFeatureValueAtTime_QuaternionfDelegate(ulong deviceId, IntPtr usage, long time, [Out] IntPtr value);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate bool TryGetFeatureValue_XRHandDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate bool TryGetFeatureValue_XRBoneDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate bool TryGetFeatureValue_XREyesDelegate(ulong deviceId, IntPtr usage, [Out] IntPtr value);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate bool IsDeviceValidDelegate(ulong deviceId);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate IntPtr GetDeviceNameDelegate(ulong deviceId);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate IntPtr GetDeviceManufacturerDelegate(ulong deviceId);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate IntPtr GetDeviceSerialNumberDelegate(ulong deviceId);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate InputDeviceCharacteristics GetDeviceCharacteristicsDelegate(ulong deviceId);
	}
}
