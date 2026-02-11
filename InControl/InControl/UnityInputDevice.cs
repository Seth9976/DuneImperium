using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace InControl
{
	// Token: 0x0200005E RID: 94
	public class UnityInputDevice : InputDevice
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00027EE4 File Offset: 0x000260E4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputDevice()
		{
			Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr);
			UnityInputDevice.NativeFieldInfoPtr_analogQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "analogQueries");
			UnityInputDevice.NativeFieldInfoPtr_buttonQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "buttonQueries");
			UnityInputDevice.NativeFieldInfoPtr_MaxDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "MaxDevices");
			UnityInputDevice.NativeFieldInfoPtr_MaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "MaxButtons");
			UnityInputDevice.NativeFieldInfoPtr_MaxAnalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "MaxAnalogs");
			UnityInputDevice.NativeFieldInfoPtr__JoystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "<JoystickId>k__BackingField");
			UnityInputDevice.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, "profile");
			UnityInputDevice.NativeMethodInfoPtr_get_JoystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664473);
			UnityInputDevice.NativeMethodInfoPtr_set_JoystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664474);
			UnityInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664475);
			UnityInputDevice.NativeMethodInfoPtr__ctor_Public_Void_InputDeviceProfile_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664476);
			UnityInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664477);
			UnityInputDevice.NativeMethodInfoPtr_SetupAnalogQueries_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664478);
			UnityInputDevice.NativeMethodInfoPtr_SetupButtonQueries_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664479);
			UnityInputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664480);
			UnityInputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664481);
			UnityInputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664482);
			UnityInputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664483);
			UnityInputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664484);
			UnityInputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr, 100664485);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x000280A4 File Offset: 0x000262A4
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000280E0 File Offset: 0x000262E0
		public unsafe int JoystickId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr_get_JoystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr_set_JoystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00028120 File Offset: 0x00026320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786353, XrefRangeEnd = 786354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDevice(int joystickId, string joystickName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(joystickName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002817C File Offset: 0x0002637C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 786496, RefRangeEnd = 786498, XrefRangeStart = 786354, XrefRangeEnd = 786496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDevice(InputDeviceProfile deviceProfile, int joystickId, string joystickName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deviceProfile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joystickId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(joystickName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr__ctor_Public_Void_InputDeviceProfile_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000281E8 File Offset: 0x000263E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786498, XrefRangeEnd = 786514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00028240 File Offset: 0x00026440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786514, XrefRangeEnd = 786531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupAnalogQueries()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr_SetupAnalogQueries_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00028268 File Offset: 0x00026468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786531, XrefRangeEnd = 786548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupButtonQueries()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDevice.NativeMethodInfoPtr_SetupButtonQueries_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00028290 File Offset: 0x00026490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786548, XrefRangeEnd = 786549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadRawButtonState(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000282E4 File Offset: 0x000264E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786549, XrefRangeEnd = 786550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ReadRawAnalogValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00028338 File Offset: 0x00026538
		public unsafe override bool IsSupportedOnThisPlatform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00028380 File Offset: 0x00026580
		public unsafe override bool IsKnown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x000283C8 File Offset: 0x000265C8
		public unsafe override int NumUnknownButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00028410 File Offset: 0x00026610
		public unsafe override int NumUnknownAnalogs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityInputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00005A77 File Offset: 0x00003C77
		public UnityInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00028458 File Offset: 0x00026658
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00005A80 File Offset: 0x00003C80
		public unsafe static Il2CppObjectBase analogQueries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDevice.NativeFieldInfoPtr_analogQueries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDevice.NativeFieldInfoPtr_analogQueries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00028480 File Offset: 0x00026680
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00005A92 File Offset: 0x00003C92
		public unsafe static Il2CppObjectBase buttonQueries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDevice.NativeFieldInfoPtr_buttonQueries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDevice.NativeFieldInfoPtr_buttonQueries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000284A8 File Offset: 0x000266A8
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public unsafe static int MaxDevices
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDevice.NativeFieldInfoPtr_MaxDevices, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDevice.NativeFieldInfoPtr_MaxDevices, (void*)(&value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000284C4 File Offset: 0x000266C4
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00005AB2 File Offset: 0x00003CB2
		public unsafe static int MaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDevice.NativeFieldInfoPtr_MaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDevice.NativeFieldInfoPtr_MaxButtons, (void*)(&value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000284E0 File Offset: 0x000266E0
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public unsafe static int MaxAnalogs
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDevice.NativeFieldInfoPtr_MaxAnalogs, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDevice.NativeFieldInfoPtr_MaxAnalogs, (void*)(&value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000284FC File Offset: 0x000266FC
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00005ACE File Offset: 0x00003CCE
		public unsafe int _JoystickId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDevice.NativeFieldInfoPtr__JoystickId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDevice.NativeFieldInfoPtr__JoystickId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00028524 File Offset: 0x00026724
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public unsafe InputDeviceProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDevice.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDeviceProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDevice.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_analogQueries;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_buttonQueries;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_MaxDevices;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_MaxButtons;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_MaxAnalogs;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr__JoystickId_k__BackingField;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_get_JoystickId_Public_get_Int32_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_set_JoystickId_Private_set_Void_Int32_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputDeviceProfile_Int32_String_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_SetupAnalogQueries_Private_Static_Void_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_SetupButtonQueries_Private_Static_Void_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0;
	}
}
