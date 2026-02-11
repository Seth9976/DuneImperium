using System;
using boardgames.data;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.data
{
	// Token: 0x0200017E RID: 382
	public class WormCanSetColorData : DataComponent
	{
		// Token: 0x06001125 RID: 4389 RVA: 0x0004BA7C File Offset: 0x00049C7C
		// Note: this type is marked as 'beforefieldinit'.
		static WormCanSetColorData()
		{
			Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormCanSetColorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr);
			WormCanSetColorData.NativeFieldInfoPtr_aiColorsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, "aiColorsDisabled");
			WormCanSetColorData.NativeFieldInfoPtr_playerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, "playerType");
			WormCanSetColorData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, 100665675);
			WormCanSetColorData.NativeMethodInfoPtr_get_CanSetColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, 100665676);
			WormCanSetColorData.NativeMethodInfoPtr__ctor_Public_Void_PlayerTypeData_WormDisabledData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, 100665677);
			WormCanSetColorData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr, 100665678);
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0004BB24 File Offset: 0x00049D24
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanSetColorData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0004BB60 File Offset: 0x00049D60
		public unsafe bool CanSetColor
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 710888, RefRangeEnd = 710893, XrefRangeStart = 710888, XrefRangeEnd = 710888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanSetColorData.NativeMethodInfoPtr_get_CanSetColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0004BB9C File Offset: 0x00049D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710896, RefRangeEnd = 710897, XrefRangeStart = 710893, XrefRangeEnd = 710896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCanSetColorData(PlayerTypeData playerType, WormDisabledData aiColorsDisabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanSetColorData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aiColorsDisabled);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanSetColorData.NativeMethodInfoPtr__ctor_Public_Void_PlayerTypeData_WormDisabledData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0004BBFC File Offset: 0x00049DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710897, XrefRangeEnd = 710907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCanSetColorData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public WormCanSetColorData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0004BC40 File Offset: 0x00049E40
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000AFED File Offset: 0x000091ED
		public unsafe WormDisabledData aiColorsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorData.NativeFieldInfoPtr_aiColorsDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDisabledData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorData.NativeFieldInfoPtr_aiColorsDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0004BC70 File Offset: 0x00049E70
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000B00C File Offset: 0x0000920C
		public unsafe PlayerTypeData playerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorData.NativeFieldInfoPtr_playerType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorData.NativeFieldInfoPtr_playerType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_aiColorsDisabled;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_playerType;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSetColor_Public_get_Boolean_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerTypeData_WormDisabledData_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
