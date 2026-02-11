using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x020001A0 RID: 416
	public class WormSolariCostData : WormCostData
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x00050218 File Offset: 0x0004E418
		// Note: this type is marked as 'beforefieldinit'.
		static WormSolariCostData()
		{
			Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormSolariCostData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr);
			WormSolariCostData.NativeFieldInfoPtr_discountAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, "discountAttribute");
			WormSolariCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665819);
			WormSolariCostData.NativeMethodInfoPtr_get_Cost_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665820);
			WormSolariCostData.NativeMethodInfoPtr_get_Discount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665821);
			WormSolariCostData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665822);
			WormSolariCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665823);
			WormSolariCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr, 100665824);
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000502D4 File Offset: 0x0004E4D4
		public unsafe override AttributeDefinition<Nullable<int>> Definition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712153, XrefRangeEnd = 712157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSolariCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00050320 File Offset: 0x0004E520
		public unsafe override int Cost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712157, XrefRangeEnd = 712167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSolariCostData.NativeMethodInfoPtr_get_Cost_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00050368 File Offset: 0x0004E568
		public unsafe int Discount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 712171, RefRangeEnd = 712173, XrefRangeStart = 712167, XrefRangeEnd = 712171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSolariCostData.NativeMethodInfoPtr_get_Discount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000503A4 File Offset: 0x0004E5A4
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712173, XrefRangeEnd = 712179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSolariCostData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000503EC File Offset: 0x0004E5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712187, RefRangeEnd = 712188, XrefRangeStart = 712179, XrefRangeEnd = 712187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSolariCostData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSolariCostData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSolariCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00050438 File Offset: 0x0004E638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712188, XrefRangeEnd = 712196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSolariCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000B9EA File Offset: 0x00009BEA
		public WormSolariCostData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0005047C File Offset: 0x0004E67C
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		public unsafe IAttribute<Nullable<int>> discountAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostData.NativeFieldInfoPtr_discountAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostData.NativeFieldInfoPtr_discountAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr_discountAttribute;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_get_Cost_Public_Virtual_get_Int32_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_get_Discount_Public_get_Int32_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
