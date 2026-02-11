using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x0200018F RID: 399
	public class WormHouseData : VersionedDataComponent
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x0004E144 File Offset: 0x0004C344
		// Note: this type is marked as 'beforefieldinit'.
		static WormHouseData()
		{
			Il2CppClassPointerStore<WormHouseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormHouseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr);
			WormHouseData.NativeFieldInfoPtr_houseAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr, "houseAttribute");
			WormHouseData.NativeMethodInfoPtr_get_House_Public_get_Houses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr, 100665752);
			WormHouseData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr, 100665753);
			WormHouseData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr, 100665754);
			WormHouseData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr, 100665755);
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0004E1D8 File Offset: 0x0004C3D8
		public unsafe Houses House
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711589, XrefRangeEnd = 711595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHouseData.NativeMethodInfoPtr_get_House_Public_get_Houses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004E214 File Offset: 0x0004C414
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711595, XrefRangeEnd = 711599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHouseData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0004E25C File Offset: 0x0004C45C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 711609, RefRangeEnd = 711612, XrefRangeStart = 711599, XrefRangeEnd = 711609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHouseData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHouseData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHouseData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711612, XrefRangeEnd = 711626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHouseData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0000B5A9 File Offset: 0x000097A9
		public WormHouseData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000B5B2 File Offset: 0x000097B2
		public unsafe IAttribute<Nullable<Houses>> houseAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHouseData.NativeFieldInfoPtr_houseAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<Houses>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHouseData.NativeFieldInfoPtr_houseAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_houseAttribute;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_House_Public_get_Houses_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
