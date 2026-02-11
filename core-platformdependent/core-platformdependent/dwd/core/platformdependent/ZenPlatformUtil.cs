using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x0200002B RID: 43
	public class ZenPlatformUtil : Object
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0000738C File Offset: 0x0000558C
		// Note: this type is marked as 'beforefieldinit'.
		static ZenPlatformUtil()
		{
			Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "ZenPlatformUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr);
			ZenPlatformUtil.NativeFieldInfoPtr_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "DEFAULT");
			ZenPlatformUtil.NativeFieldInfoPtr_TABLET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "TABLET");
			ZenPlatformUtil.NativeFieldInfoPtr_PHONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "PHONE");
			ZenPlatformUtil.NativeFieldInfoPtr_DESKTOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "DESKTOP");
			ZenPlatformUtil.NativeFieldInfoPtr_SWITCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "SWITCH");
			ZenPlatformUtil.NativeFieldInfoPtr_STEAMDECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "STEAMDECK");
			ZenPlatformUtil.NativeFieldInfoPtr_XBOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "XBOX");
			ZenPlatformUtil.NativeFieldInfoPtr_currentPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, "currentPlatform");
			ZenPlatformUtil.NativeMethodInfoPtr_get_UNINITIALIZED_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663459);
			ZenPlatformUtil.NativeMethodInfoPtr_get_platforms_Protected_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663460);
			ZenPlatformUtil.NativeMethodInfoPtr_get_platformMap_Protected_Virtual_New_get_Dictionary_2_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663461);
			ZenPlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663462);
			ZenPlatformUtil.NativeMethodInfoPtr_get_PlatformMap_Public_Virtual_Final_New_get_Dictionary_2_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663463);
			ZenPlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663464);
			ZenPlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663465);
			ZenPlatformUtil.NativeMethodInfoPtr_getCurrentPlatform_Protected_Virtual_New_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663466);
			ZenPlatformUtil.NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663467);
			ZenPlatformUtil.NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663468);
			ZenPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663469);
			ZenPlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663470);
			ZenPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663471);
			ZenPlatformUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr, 100663472);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00007574 File Offset: 0x00005774
		public unsafe static uint UNINITIALIZED
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_UNINITIALIZED_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000075A4 File Offset: 0x000057A4
		public unsafe virtual Il2CppStringArray platforms
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239898, XrefRangeEnd = 1239922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZenPlatformUtil.NativeMethodInfoPtr_get_platforms_Protected_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000075F0 File Offset: 0x000057F0
		public unsafe virtual Dictionary<uint, string> platformMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239922, XrefRangeEnd = 1239953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZenPlatformUtil.NativeMethodInfoPtr_get_platformMap_Protected_Virtual_New_get_Dictionary_2_UInt32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000763C File Offset: 0x0000583C
		public unsafe virtual Il2CppStringArray Platforms
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1011778, RefRangeEnd = 1011786, XrefRangeStart = 1011778, XrefRangeEnd = 1011786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000767C File Offset: 0x0000587C
		public unsafe virtual Dictionary<uint, string> PlatformMap
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_PlatformMap_Public_Virtual_Final_New_get_Dictionary_2_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000076BC File Offset: 0x000058BC
		public unsafe virtual uint DefaultPlatform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000076F8 File Offset: 0x000058F8
		[CallerCount(0)]
		public unsafe virtual void UpdatePlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000772C File Offset: 0x0000592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239953, XrefRangeEnd = 1239974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint getCurrentPlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZenPlatformUtil.NativeMethodInfoPtr_getCurrentPlatform_Protected_Virtual_New_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007774 File Offset: 0x00005974
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setCurrentPlatform(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZenPlatformUtil.NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_New_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000077C0 File Offset: 0x000059C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239974, XrefRangeEnd = 1239982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRunningOnSteamDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000077F0 File Offset: 0x000059F0
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000782C File Offset: 0x00005A2C
		public unsafe virtual uint CurrentPlatform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000786C File Offset: 0x00005A6C
		public unsafe virtual string CurrentPlatformAsString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000078A4 File Offset: 0x00005AA4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZenPlatformUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZenPlatformUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenPlatformUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002A9B File Offset: 0x00000C9B
		public ZenPlatformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000078E0 File Offset: 0x00005AE0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public unsafe static uint DEFAULT
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_DEFAULT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000078FC File Offset: 0x00005AFC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public unsafe static uint TABLET
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_TABLET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_TABLET, (void*)(&value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public unsafe static uint PHONE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_PHONE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_PHONE, (void*)(&value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00007934 File Offset: 0x00005B34
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002ACE File Offset: 0x00000CCE
		public unsafe static uint DESKTOP
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_DESKTOP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_DESKTOP, (void*)(&value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00007950 File Offset: 0x00005B50
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe static uint SWITCH
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_SWITCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_SWITCH, (void*)(&value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000796C File Offset: 0x00005B6C
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002AEA File Offset: 0x00000CEA
		public unsafe static uint STEAMDECK
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_STEAMDECK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_STEAMDECK, (void*)(&value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00007988 File Offset: 0x00005B88
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe static uint XBOX
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ZenPlatformUtil.NativeFieldInfoPtr_XBOX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZenPlatformUtil.NativeFieldInfoPtr_XBOX, (void*)(&value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000079A4 File Offset: 0x00005BA4
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002B06 File Offset: 0x00000D06
		public unsafe uint currentPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenPlatformUtil.NativeFieldInfoPtr_currentPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenPlatformUtil.NativeFieldInfoPtr_currentPlatform)) = value;
			}
		}

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_TABLET;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_PHONE;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_DESKTOP;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_SWITCH;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_STEAMDECK;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_XBOX;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_currentPlatform;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_UNINITIALIZED_Public_Static_get_UInt32_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_platforms_Protected_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_platformMap_Protected_Virtual_New_get_Dictionary_2_UInt32_String_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_Platforms_Public_Virtual_Final_New_get_Il2CppStringArray_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformMap_Public_Virtual_Final_New_get_Dictionary_2_UInt32_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPlatform_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlatform_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_getCurrentPlatform_Protected_Virtual_New_UInt32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_New_Void_UInt32_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatform_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlatform_Public_Virtual_Final_New_set_Void_UInt32_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
