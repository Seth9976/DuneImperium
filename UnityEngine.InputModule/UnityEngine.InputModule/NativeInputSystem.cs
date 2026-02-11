using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000005 RID: 5
	public class NativeInputSystem : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000022E4 File Offset: 0x000004E4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputSystem()
		{
			Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputSystem");
			NativeInputSystem.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onUpdate");
			NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onBeforeUpdate");
			NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onShouldRunUpdate");
			NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "s_OnDeviceDiscoveredCallback");
			NativeInputSystem.NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663300);
			NativeInputSystem.NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663301);
			NativeInputSystem.NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663302);
			NativeInputSystem.NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663303);
			NativeInputSystem.NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663304);
			NativeInputSystem.get_currentTimeDelegateField = IL2CPP.ResolveICall<NativeInputSystem.get_currentTimeDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_currentTime");
			NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegateField = IL2CPP.ResolveICall<NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_currentTimeOffsetToRealtimeSinceStartup");
			NativeInputSystem.AllocateDeviceIdDelegateField = IL2CPP.ResolveICall<NativeInputSystem.AllocateDeviceIdDelegate>("UnityEngineInternal.Input.NativeInputSystem::AllocateDeviceId");
			NativeInputSystem.QueueInputEventDelegateField = IL2CPP.ResolveICall<NativeInputSystem.QueueInputEventDelegate>("UnityEngineInternal.Input.NativeInputSystem::QueueInputEvent");
			NativeInputSystem.IOCTLDelegateField = IL2CPP.ResolveICall<NativeInputSystem.IOCTLDelegate>("UnityEngineInternal.Input.NativeInputSystem::IOCTL");
			NativeInputSystem.SetPollingFrequencyDelegateField = IL2CPP.ResolveICall<NativeInputSystem.SetPollingFrequencyDelegate>("UnityEngineInternal.Input.NativeInputSystem::SetPollingFrequency");
			NativeInputSystem.UpdateDelegateField = IL2CPP.ResolveICall<NativeInputSystem.UpdateDelegate>("UnityEngineInternal.Input.NativeInputSystem::Update");
			NativeInputSystem.GetBackgroundEventBufferSizeDelegateField = IL2CPP.ResolveICall<NativeInputSystem.GetBackgroundEventBufferSizeDelegate>("UnityEngineInternal.Input.NativeInputSystem::GetBackgroundEventBufferSize");
			NativeInputSystem.get_allowInputDeviceCreationFromEventsDelegateField = IL2CPP.ResolveICall<NativeInputSystem.get_allowInputDeviceCreationFromEventsDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_allowInputDeviceCreationFromEvents");
			NativeInputSystem.set_allowInputDeviceCreationFromEventsDelegateField = IL2CPP.ResolveICall<NativeInputSystem.set_allowInputDeviceCreationFromEventsDelegate>("UnityEngineInternal.Input.NativeInputSystem::set_allowInputDeviceCreationFromEvents");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002454 File Offset: 0x00000654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272843, XrefRangeEnd = 1272847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002488 File Offset: 0x00000688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272847, XrefRangeEnd = 1272851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024C8 File Offset: 0x000006C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272851, XrefRangeEnd = 1272855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deviceDescriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000250C File Offset: 0x0000070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272855, XrefRangeEnd = 1272859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &retval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000254C File Offset: 0x0000074C
		public unsafe static bool hasDeviceDiscoveredCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272859, XrefRangeEnd = 1272861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206B File Offset: 0x0000026B
		public NativeInputSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe static NativeUpdateCallback onUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeUpdateCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000025A8 File Offset: 0x000007A8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe static Action<NativeInputUpdateType> onBeforeUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NativeInputUpdateType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000025D0 File Offset: 0x000007D0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe static Func<NativeInputUpdateType, bool> onShouldRunUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NativeInputUpdateType, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020AA File Offset: 0x000002AA
		public unsafe static Action<int, string> s_OnDeviceDiscoveredCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002620 File Offset: 0x00000820
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020BC File Offset: 0x000002BC
		public static Action<int, string> onDeviceDiscovered
		{
			get
			{
				return NativeInputSystem.s_OnDeviceDiscoveredCallback;
			}
			set
			{
				NativeInputSystem.s_OnDeviceDiscoveredCallback = value;
				NativeInputSystem.hasDeviceDiscoveredCallback = NativeInputSystem.s_OnDeviceDiscoveredCallback != null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020D3 File Offset: 0x000002D3
		public static double currentTime
		{
			get
			{
				return NativeInputSystem.get_currentTimeDelegateField();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000020DF File Offset: 0x000002DF
		public static double currentTimeOffsetToRealtimeSinceStartup
		{
			get
			{
				return NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegateField();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020EB File Offset: 0x000002EB
		public static int AllocateDeviceId()
		{
			return NativeInputSystem.AllocateDeviceIdDelegateField();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020F7 File Offset: 0x000002F7
		public static void QueueInputEvent<TInputEvent>(ref TInputEvent inputEvent) where TInputEvent : struct
		{
			NativeInputSystem.QueueInputEvent((IntPtr)UnsafeUtility.AddressOf<TInputEvent>(ref inputEvent));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000210B File Offset: 0x0000030B
		public static void QueueInputEvent(IntPtr inputEvent)
		{
			NativeInputSystem.QueueInputEventDelegateField(inputEvent);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002118 File Offset: 0x00000318
		public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes)
		{
			return NativeInputSystem.IOCTLDelegateField(deviceId, code, data, sizeInBytes);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002128 File Offset: 0x00000328
		public static void SetPollingFrequency(float hertz)
		{
			NativeInputSystem.SetPollingFrequencyDelegateField(hertz);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002135 File Offset: 0x00000335
		public static void Update(NativeInputUpdateType updateType)
		{
			NativeInputSystem.UpdateDelegateField(updateType);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002142 File Offset: 0x00000342
		public static ulong GetBackgroundEventBufferSize()
		{
			return NativeInputSystem.GetBackgroundEventBufferSizeDelegateField();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000214E File Offset: 0x0000034E
		public static void SetUpdateMask(NativeInputUpdateType mask)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002151 File Offset: 0x00000351
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000215D File Offset: 0x0000035D
		public static bool allowInputDeviceCreationFromEvents
		{
			get
			{
				return NativeInputSystem.get_allowInputDeviceCreationFromEventsDelegateField();
			}
			set
			{
				NativeInputSystem.set_allowInputDeviceCreationFromEventsDelegateField(value);
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_onBeforeUpdate;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_onShouldRunUpdate;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0;

		// Token: 0x0400001B RID: 27
		private static readonly NativeInputSystem.get_currentTimeDelegate get_currentTimeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegate get_currentTimeOffsetToRealtimeSinceStartupDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly NativeInputSystem.AllocateDeviceIdDelegate AllocateDeviceIdDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly NativeInputSystem.QueueInputEventDelegate QueueInputEventDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly NativeInputSystem.IOCTLDelegate IOCTLDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly NativeInputSystem.SetPollingFrequencyDelegate SetPollingFrequencyDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly NativeInputSystem.UpdateDelegate UpdateDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly NativeInputSystem.GetBackgroundEventBufferSizeDelegate GetBackgroundEventBufferSizeDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly NativeInputSystem.get_allowInputDeviceCreationFromEventsDelegate get_allowInputDeviceCreationFromEventsDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly NativeInputSystem.set_allowInputDeviceCreationFromEventsDelegate set_allowInputDeviceCreationFromEventsDelegateField;

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate double get_currentTimeDelegate();

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000027 RID: 39
		private delegate double get_currentTimeOffsetToRealtimeSinceStartupDelegate();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000029 RID: 41
		private delegate int AllocateDeviceIdDelegate();

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600002B RID: 43
		private delegate void QueueInputEventDelegate(IntPtr inputEvent);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate long IOCTLDelegate(int deviceId, int code, IntPtr data, int sizeInBytes);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002F RID: 47
		private delegate void SetPollingFrequencyDelegate(float hertz);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate void UpdateDelegate(NativeInputUpdateType updateType);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000033 RID: 51
		private delegate ulong GetBackgroundEventBufferSizeDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate bool get_allowInputDeviceCreationFromEventsDelegate();

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate void set_allowInputDeviceCreationFromEventsDelegate(bool value);
	}
}
