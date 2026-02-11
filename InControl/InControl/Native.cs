using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace InControl
{
	// Token: 0x02000046 RID: 70
	public static class Native : Object
	{
		// Token: 0x060006A2 RID: 1698 RVA: 0x0001F81C File Offset: 0x0001DA1C
		// Note: this type is marked as 'beforefieldinit'.
		static Native()
		{
			Il2CppClassPointerStore<Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Native>.NativeClassPtr);
			Native.NativeFieldInfoPtr_libraryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Native>.NativeClassPtr, "libraryName");
			Native.NativeFieldInfoPtr_callingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Native>.NativeClassPtr, "callingConvention");
			Native.NativeMethodInfoPtr_Init_Public_Static_Void_NativeInputOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664197);
			Native.NativeMethodInfoPtr_Stop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664198);
			Native.NativeMethodInfoPtr_GetVersionInfo_Public_Static_Void_byref_NativeVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664199);
			Native.NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_UInt32_byref_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664200);
			Native.NativeMethodInfoPtr_GetDeviceState_Public_Static_Boolean_UInt32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664201);
			Native.NativeMethodInfoPtr_GetDeviceEvents_Public_Static_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664202);
			Native.NativeMethodInfoPtr_SetHapticState_Public_Static_Void_UInt32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664203);
			Native.NativeMethodInfoPtr_SetTriggersHapticState_Public_Static_Void_UInt32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664204);
			Native.NativeMethodInfoPtr_SetLightColor_Public_Static_Void_UInt32_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664205);
			Native.NativeMethodInfoPtr_SetLightFlash_Public_Static_Void_UInt32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664206);
			Native.NativeMethodInfoPtr_GetAnalogGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664207);
			Native.NativeMethodInfoPtr_GetButtonGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100664208);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001F964 File Offset: 0x0001DB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784051, XrefRangeEnd = 784053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init(NativeInputOptions options)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_Init_Public_Static_Void_NativeInputOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001F998 File Offset: 0x0001DB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784053, XrefRangeEnd = 784055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_Stop_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784055, XrefRangeEnd = 784057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVersionInfo(out NativeVersionInfo versionInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &versionInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetVersionInfo_Public_Static_Void_byref_NativeVersionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784057, XrefRangeEnd = 784063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDeviceInfo(uint handle, out InputDeviceInfo deviceInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_UInt32_byref_InputDeviceInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			deviceInfo = ((intPtr4 == 0) ? null : new InputDeviceInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001FA54 File Offset: 0x0001DC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784063, XrefRangeEnd = 784065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDeviceState(uint handle, out IntPtr deviceState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &deviceState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetDeviceState_Public_Static_Boolean_UInt32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784065, XrefRangeEnd = 784067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDeviceEvents(out IntPtr deviceEvents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &deviceEvents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetDeviceEvents_Public_Static_Int32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784067, XrefRangeEnd = 784069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHapticState(uint handle, byte lowFrequency, byte highFrequency)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowFrequency;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highFrequency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetHapticState_Public_Static_Void_UInt32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784069, XrefRangeEnd = 784071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTriggersHapticState(uint handle, byte leftTrigger, byte rightTrigger)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftTrigger;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightTrigger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetTriggersHapticState_Public_Static_Void_UInt32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001FB80 File Offset: 0x0001DD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784071, XrefRangeEnd = 784073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightColor(uint handle, byte red, byte green, byte blue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetLightColor_Public_Static_Void_UInt32_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784073, XrefRangeEnd = 784075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flashOnDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flashOffDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetLightFlash_Public_Static_Void_UInt32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784075, XrefRangeEnd = 784077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetAnalogGlyphName(uint handle, uint index, out IntPtr glyphName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetAnalogGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001FC88 File Offset: 0x0001DE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784077, XrefRangeEnd = 784079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetButtonGlyphName(uint handle, uint index, out IntPtr glyphName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_GetButtonGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000475D File Offset: 0x0000295D
		public Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00004766 File Offset: 0x00002966
		public unsafe static string libraryName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Native.NativeFieldInfoPtr_libraryName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Native.NativeFieldInfoPtr_libraryName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001FD04 File Offset: 0x0001DF04
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00004778 File Offset: 0x00002978
		public unsafe static CallingConvention callingConvention
		{
			get
			{
				CallingConvention callingConvention;
				IL2CPP.il2cpp_field_static_get_value(Native.NativeFieldInfoPtr_callingConvention, (void*)(&callingConvention));
				return callingConvention;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Native.NativeFieldInfoPtr_callingConvention, (void*)(&value));
			}
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_libraryName;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_callingConvention;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_NativeInputOptions_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionInfo_Public_Static_Void_byref_NativeVersionInfo_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_UInt32_byref_InputDeviceInfo_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceState_Public_Static_Boolean_UInt32_byref_IntPtr_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceEvents_Public_Static_Int32_byref_IntPtr_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_SetHapticState_Public_Static_Void_UInt32_Byte_Byte_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggersHapticState_Public_Static_Void_UInt32_Byte_Byte_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Static_Void_UInt32_Byte_Byte_Byte_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_SetLightFlash_Public_Static_Void_UInt32_Byte_Byte_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonGlyphName_Public_Static_UInt32_UInt32_UInt32_byref_IntPtr_0;
	}
}
