using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x0200019A RID: 410
	public class WormPlayerSpacesVisitedData : VersionedDataComponent
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x0004F5B0 File Offset: 0x0004D7B0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerSpacesVisitedData()
		{
			Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPlayerSpacesVisitedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr);
			WormPlayerSpacesVisitedData.NativeFieldInfoPtr_spacesAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr, "spacesAttribute");
			WormPlayerSpacesVisitedData.NativeMethodInfoPtr_get_VisitedSpaces_Public_get_Dictionary_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr, 100665790);
			WormPlayerSpacesVisitedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr, 100665791);
			WormPlayerSpacesVisitedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr, 100665792);
			WormPlayerSpacesVisitedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr, 100665793);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0004F644 File Offset: 0x0004D844
		public unsafe Dictionary<ArchetypeID, int> VisitedSpaces
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 711842, RefRangeEnd = 711844, XrefRangeStart = 711838, XrefRangeEnd = 711842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSpacesVisitedData.NativeMethodInfoPtr_get_VisitedSpaces_Public_get_Dictionary_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ArchetypeID, int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x0004F684 File Offset: 0x0004D884
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711844, XrefRangeEnd = 711848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerSpacesVisitedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0004F6CC File Offset: 0x0004D8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711858, RefRangeEnd = 711859, XrefRangeStart = 711848, XrefRangeEnd = 711858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerSpacesVisitedData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSpacesVisitedData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSpacesVisitedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0004F718 File Offset: 0x0004D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711859, XrefRangeEnd = 711869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerSpacesVisitedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0000B85F File Offset: 0x00009A5F
		public WormPlayerSpacesVisitedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0004F75C File Offset: 0x0004D95C
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000B868 File Offset: 0x00009A68
		public unsafe IAttribute<Dictionary<ArchetypeID, int>> spacesAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSpacesVisitedData.NativeFieldInfoPtr_spacesAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<ArchetypeID, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSpacesVisitedData.NativeFieldInfoPtr_spacesAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_spacesAttribute;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_get_VisitedSpaces_Public_get_Dictionary_2_ArchetypeID_Int32_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
