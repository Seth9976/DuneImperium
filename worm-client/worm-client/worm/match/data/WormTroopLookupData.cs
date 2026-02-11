using System;
using boardgames.match.data;
using Canis.attributes;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x020001A5 RID: 421
	public class WormTroopLookupData : PrefabLookupData
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x00050C38 File Offset: 0x0004EE38
		// Note: this type is marked as 'beforefieldinit'.
		static WormTroopLookupData()
		{
			Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormTroopLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr);
			WormTroopLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, "flavors");
			WormTroopLookupData.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, "cachedVersion");
			WormTroopLookupData.NativeFieldInfoPtr_leaderHouseAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, "leaderHouseAttribute");
			WormTroopLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, 100665841);
			WormTroopLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, 100665842);
			WormTroopLookupData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, 100665843);
			WormTroopLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, 100665844);
			WormTroopLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr, 100665845);
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00050D08 File Offset: 0x0004EF08
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712283, XrefRangeEnd = 712298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00050D54 File Offset: 0x0004EF54
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712298, XrefRangeEnd = 712302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00050D9C File Offset: 0x0004EF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712319, RefRangeEnd = 712320, XrefRangeStart = 712302, XrefRangeEnd = 712319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTroopLookupData(EntityComponent leaderEntityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderEntityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopLookupData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00050DE8 File Offset: 0x0004EFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712320, XrefRangeEnd = 712335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00050E1C File Offset: 0x0004F01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712335, XrefRangeEnd = 712344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0000BACD File Offset: 0x00009CCD
		public WormTroopLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00050E60 File Offset: 0x0004F060
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000BAD6 File Offset: 0x00009CD6
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00050E90 File Offset: 0x0004F090
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0000BAF5 File Offset: 0x00009CF5
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00050EB8 File Offset: 0x0004F0B8
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0000BB10 File Offset: 0x00009D10
		public unsafe IAttribute<Nullable<Houses>> leaderHouseAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_leaderHouseAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<Houses>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopLookupData.NativeFieldInfoPtr_leaderHouseAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_leaderHouseAttribute;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_RebuildFlavors_Private_Void_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
