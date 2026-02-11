using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x0200019C RID: 412
	public class WormResourcesData : VersionedDataComponent
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x0004F90C File Offset: 0x0004DB0C
		// Note: this type is marked as 'beforefieldinit'.
		static WormResourcesData()
		{
			Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormResourcesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr);
			WormResourcesData.NativeFieldInfoPtr_spiceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, "spiceAttribute");
			WormResourcesData.NativeFieldInfoPtr_waterAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, "waterAttribute");
			WormResourcesData.NativeFieldInfoPtr_solariAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, "solariAttribute");
			WormResourcesData.NativeMethodInfoPtr_get_Spice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665797);
			WormResourcesData.NativeMethodInfoPtr_get_Water_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665798);
			WormResourcesData.NativeMethodInfoPtr_get_Solari_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665799);
			WormResourcesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665800);
			WormResourcesData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665801);
			WormResourcesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr, 100665802);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0004F9F0 File Offset: 0x0004DBF0
		public unsafe int Spice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711890, XrefRangeEnd = 711896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResourcesData.NativeMethodInfoPtr_get_Spice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0004FA2C File Offset: 0x0004DC2C
		public unsafe int Water
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711896, XrefRangeEnd = 711902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResourcesData.NativeMethodInfoPtr_get_Water_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0004FA68 File Offset: 0x0004DC68
		public unsafe int Solari
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711902, XrefRangeEnd = 711908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResourcesData.NativeMethodInfoPtr_get_Solari_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0004FAA4 File Offset: 0x0004DCA4
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711908, XrefRangeEnd = 711915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResourcesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711926, RefRangeEnd = 711927, XrefRangeStart = 711915, XrefRangeEnd = 711926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResourcesData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResourcesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResourcesData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0004FB38 File Offset: 0x0004DD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711927, XrefRangeEnd = 711964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResourcesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0000B8AF File Offset: 0x00009AAF
		public WormResourcesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0004FB7C File Offset: 0x0004DD7C
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public unsafe IAttribute<Nullable<int>> spiceAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_spiceAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_spiceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0004FBAC File Offset: 0x0004DDAC
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0000B8D7 File Offset: 0x00009AD7
		public unsafe IAttribute<Nullable<int>> waterAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_waterAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_waterAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x0004FBDC File Offset: 0x0004DDDC
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0000B8F6 File Offset: 0x00009AF6
		public unsafe IAttribute<Nullable<int>> solariAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_solariAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesData.NativeFieldInfoPtr_solariAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_spiceAttribute;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_waterAttribute;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_solariAttribute;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_get_Spice_Public_get_Int32_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_get_Water_Public_get_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_get_Solari_Public_get_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
