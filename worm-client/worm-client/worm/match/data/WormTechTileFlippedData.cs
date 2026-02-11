using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x020001A4 RID: 420
	public class WormTechTileFlippedData : VersionedDataComponent
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x00050A60 File Offset: 0x0004EC60
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechTileFlippedData()
		{
			Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormTechTileFlippedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr);
			WormTechTileFlippedData.NativeFieldInfoPtr_flippedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr, "flippedAttribute");
			WormTechTileFlippedData.NativeMethodInfoPtr_get_Flipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr, 100665837);
			WormTechTileFlippedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr, 100665838);
			WormTechTileFlippedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr, 100665839);
			WormTechTileFlippedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr, 100665840);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00050AF4 File Offset: 0x0004ECF4
		public unsafe bool Flipped
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712254, XrefRangeEnd = 712258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileFlippedData.NativeMethodInfoPtr_get_Flipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00050B30 File Offset: 0x0004ED30
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712258, XrefRangeEnd = 712262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechTileFlippedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00050B78 File Offset: 0x0004ED78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 712269, RefRangeEnd = 712271, XrefRangeStart = 712262, XrefRangeEnd = 712269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTileFlippedData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTileFlippedData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileFlippedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00050BC4 File Offset: 0x0004EDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712271, XrefRangeEnd = 712283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechTileFlippedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0000BAA5 File Offset: 0x00009CA5
		public WormTechTileFlippedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00050C08 File Offset: 0x0004EE08
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0000BAAE File Offset: 0x00009CAE
		public unsafe IAttribute<Nullable<bool>> flippedAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileFlippedData.NativeFieldInfoPtr_flippedAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileFlippedData.NativeFieldInfoPtr_flippedAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_flippedAttribute;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_get_Flipped_Public_get_Boolean_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
