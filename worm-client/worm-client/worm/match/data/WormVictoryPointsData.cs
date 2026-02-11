using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x020001A6 RID: 422
	public class WormVictoryPointsData : VersionedDataComponent
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x00050EE8 File Offset: 0x0004F0E8
		// Note: this type is marked as 'beforefieldinit'.
		static WormVictoryPointsData()
		{
			Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormVictoryPointsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr);
			WormVictoryPointsData.NativeFieldInfoPtr_vpAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, "vpAttribute");
			WormVictoryPointsData.NativeFieldInfoPtr_vpSourcesAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, "vpSourcesAttribute");
			WormVictoryPointsData.NativeMethodInfoPtr_get_Vp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, 100665846);
			WormVictoryPointsData.NativeMethodInfoPtr_get_VPSources_Public_get_IReadOnlyDictionary_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, 100665847);
			WormVictoryPointsData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, 100665848);
			WormVictoryPointsData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, 100665849);
			WormVictoryPointsData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr, 100665850);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00050FA4 File Offset: 0x0004F1A4
		public unsafe int Vp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 712350, RefRangeEnd = 712351, XrefRangeStart = 712344, XrefRangeEnd = 712350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointsData.NativeMethodInfoPtr_get_Vp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00050FE0 File Offset: 0x0004F1E0
		public unsafe IReadOnlyDictionary<EntityID, int> VPSources
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 712360, RefRangeEnd = 712367, XrefRangeStart = 712351, XrefRangeEnd = 712360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointsData.NativeMethodInfoPtr_get_VPSources_Public_get_IReadOnlyDictionary_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<EntityID, int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00051020 File Offset: 0x0004F220
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712367, XrefRangeEnd = 712372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointsData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00051068 File Offset: 0x0004F268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712384, RefRangeEnd = 712385, XrefRangeStart = 712372, XrefRangeEnd = 712384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointsData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointsData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000510B4 File Offset: 0x0004F2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712385, XrefRangeEnd = 712399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointsData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0000BB2F File Offset: 0x00009D2F
		public WormVictoryPointsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000510F8 File Offset: 0x0004F2F8
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x0000BB38 File Offset: 0x00009D38
		public unsafe IAttribute<Nullable<int>> vpAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsData.NativeFieldInfoPtr_vpAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsData.NativeFieldInfoPtr_vpAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00051128 File Offset: 0x0004F328
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x0000BB57 File Offset: 0x00009D57
		public unsafe IAttribute<Dictionary<EntityID, int>> vpSourcesAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsData.NativeFieldInfoPtr_vpSourcesAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<EntityID, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsData.NativeFieldInfoPtr_vpSourcesAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_vpAttribute;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_vpSourcesAttribute;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_get_Vp_Public_get_Int32_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_get_VPSources_Public_get_IReadOnlyDictionary_2_EntityID_Int32_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
