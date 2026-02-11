using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace InControl
{
	// Token: 0x0200005F RID: 95
	public class UnityInputDeviceManager : InputDeviceManager
	{
		// Token: 0x0600093F RID: 2367 RVA: 0x00028554 File Offset: 0x00026754
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputDeviceManager()
		{
			Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityInputDeviceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr);
			UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "deviceRefreshInterval");
			UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "deviceRefreshTimer");
			UnityInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "systemDeviceProfiles");
			UnityInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "customDeviceProfiles");
			UnityInputDeviceManager.NativeFieldInfoPtr_joystickNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "joystickNames");
			UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "lastJoystickCount");
			UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "lastJoystickHash");
			UnityInputDeviceManager.NativeFieldInfoPtr_joystickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "joystickCount");
			UnityInputDeviceManager.NativeFieldInfoPtr_joystickHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "joystickHash");
			UnityInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664486);
			UnityInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664487);
			UnityInputDeviceManager.NativeMethodInfoPtr_QueryJoystickInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664488);
			UnityInputDeviceManager.NativeMethodInfoPtr_get_JoystickInfoHasChanged_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664489);
			UnityInputDeviceManager.NativeMethodInfoPtr_AttachDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664490);
			UnityInputDeviceManager.NativeMethodInfoPtr_DetachDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664491);
			UnityInputDeviceManager.NativeMethodInfoPtr_ReloadDevices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664492);
			UnityInputDeviceManager.NativeMethodInfoPtr_AttachDevice_Private_Void_UnityInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664493);
			UnityInputDeviceManager.NativeMethodInfoPtr_HasAttachedDeviceWithJoystickId_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664494);
			UnityInputDeviceManager.NativeMethodInfoPtr_DetectJoystickDevice_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664495);
			UnityInputDeviceManager.NativeMethodInfoPtr_DetectDevice_Private_InputDeviceProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664496);
			UnityInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664497);
			UnityInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, 100664498);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002873C File Offset: 0x0002693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786550, XrefRangeEnd = 786589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDeviceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00028778 File Offset: 0x00026978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786589, XrefRangeEnd = 786595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000287D0 File Offset: 0x000269D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 786597, RefRangeEnd = 786600, XrefRangeStart = 786595, XrefRangeEnd = 786597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueryJoystickInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_QueryJoystickInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00028804 File Offset: 0x00026A04
		public unsafe bool JoystickInfoHasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_get_JoystickInfoHasChanged_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00028840 File Offset: 0x00026A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 786605, RefRangeEnd = 786608, XrefRangeStart = 786600, XrefRangeEnd = 786605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDevices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_AttachDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00028874 File Offset: 0x00026A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 786618, RefRangeEnd = 786620, XrefRangeStart = 786608, XrefRangeEnd = 786618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachDevices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_DetachDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000288A8 File Offset: 0x00026AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786620, XrefRangeEnd = 786623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadDevices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_ReloadDevices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000288DC File Offset: 0x00026ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786634, RefRangeEnd = 786635, XrefRangeStart = 786623, XrefRangeEnd = 786634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDevice(UnityInputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_AttachDevice_Private_Void_UnityInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00028920 File Offset: 0x00026B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786635, XrefRangeEnd = 786642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_HasAttachedDeviceWithJoystickId_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002896C File Offset: 0x00026B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786724, RefRangeEnd = 786725, XrefRangeStart = 786642, XrefRangeEnd = 786724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(unityJoystickName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_DetectJoystickDevice_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000289BC File Offset: 0x00026BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786761, RefRangeEnd = 786762, XrefRangeStart = 786725, XrefRangeEnd = 786761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceProfile DetectDevice(string unityJoystickName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unityJoystickName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_DetectDevice_Private_InputDeviceProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00028A0C File Offset: 0x00026C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786762, XrefRangeEnd = 786766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deviceProfile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00028A50 File Offset: 0x00026C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786766, XrefRangeEnd = 786783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSystemDeviceProfiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00005B08 File Offset: 0x00003D08
		public UnityInputDeviceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00028A84 File Offset: 0x00026C84
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00005B11 File Offset: 0x00003D11
		public unsafe static float deviceRefreshInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshInterval, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00028AA0 File Offset: 0x00026CA0
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00005B1F File Offset: 0x00003D1F
		public unsafe float deviceRefreshTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_deviceRefreshTimer)) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00028AC8 File Offset: 0x00026CC8
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00005B3A File Offset: 0x00003D3A
		public unsafe List<InputDeviceProfile> systemDeviceProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDeviceProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00028AF8 File Offset: 0x00026CF8
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00005B59 File Offset: 0x00003D59
		public unsafe List<InputDeviceProfile> customDeviceProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDeviceProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00028B28 File Offset: 0x00026D28
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005B78 File Offset: 0x00003D78
		public unsafe Il2CppStringArray joystickNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00028B58 File Offset: 0x00026D58
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00005B97 File Offset: 0x00003D97
		public unsafe int lastJoystickCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickCount)) = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00028B80 File Offset: 0x00026D80
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00005BB2 File Offset: 0x00003DB2
		public unsafe int lastJoystickHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_lastJoystickHash)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00028BA8 File Offset: 0x00026DA8
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00005BCD File Offset: 0x00003DCD
		public unsafe int joystickCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickCount)) = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00028BD0 File Offset: 0x00026DD0
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public unsafe int joystickHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.NativeFieldInfoPtr_joystickHash)) = value;
			}
		}

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_deviceRefreshInterval;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_deviceRefreshTimer;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_systemDeviceProfiles;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_customDeviceProfiles;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_joystickNames;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_lastJoystickCount;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_lastJoystickHash;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_joystickCount;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_joystickHash;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_QueryJoystickInfo_Private_Void_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_JoystickInfoHasChanged_Private_get_Boolean_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_AttachDevices_Private_Void_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_DetachDevices_Private_Void_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_ReloadDevices_Public_Void_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_AttachDevice_Private_Void_UnityInputDevice_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_HasAttachedDeviceWithJoystickId_Private_Boolean_Int32_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_DetectJoystickDevice_Private_Void_Int32_String_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_DetectDevice_Private_InputDeviceProfile_String_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0;

		// Token: 0x0200021E RID: 542
		[ObfuscatedName("InControl.UnityInputDeviceManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x060011B5 RID: 4533 RVA: 0x00045854 File Offset: 0x00043A54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityInputDeviceManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr);
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeFieldInfoPtr_deviceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, "deviceInfo");
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, 100664499);
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, 100664500);
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, 100664501);
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, 100664502);
				UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr, 100664503);
			}

			// Token: 0x060011B6 RID: 4534 RVA: 0x000458F8 File Offset: 0x00043AF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDeviceManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011B7 RID: 4535 RVA: 0x00045934 File Offset: 0x00043B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__0(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x00045984 File Offset: 0x00043B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__1(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011B9 RID: 4537 RVA: 0x000459D4 File Offset: 0x00043BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__2(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011BA RID: 4538 RVA: 0x00045A24 File Offset: 0x00043C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__3(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceManager.__c__DisplayClass20_0.NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011BB RID: 4539 RVA: 0x000071FE File Offset: 0x000053FE
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x060011BC RID: 4540 RVA: 0x00045A74 File Offset: 0x00043C74
			// (set) Token: 0x060011BD RID: 4541 RVA: 0x00007207 File Offset: 0x00005407
			public InputDeviceInfo deviceInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.__c__DisplayClass20_0.NativeFieldInfoPtr_deviceInfo);
					return new InputDeviceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDeviceManager.__c__DisplayClass20_0.NativeFieldInfoPtr_deviceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000DEF RID: 3567
			private static readonly IntPtr NativeFieldInfoPtr_deviceInfo;

			// Token: 0x04000DF0 RID: 3568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DF1 RID: 3569
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DF2 RID: 3570
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DF3 RID: 3571
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DF4 RID: 3572
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0;
		}
	}
}
