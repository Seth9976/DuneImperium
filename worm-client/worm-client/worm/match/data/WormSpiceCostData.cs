using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x020001A1 RID: 417
	public class WormSpiceCostData : WormCostData
	{
		// Token: 0x0600128A RID: 4746 RVA: 0x000504AC File Offset: 0x0004E6AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpiceCostData()
		{
			Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormSpiceCostData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr);
			WormSpiceCostData.NativeFieldInfoPtr_discountAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, "discountAttribute");
			WormSpiceCostData.NativeFieldInfoPtr_additionalDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, "additionalDiscount");
			WormSpiceCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665825);
			WormSpiceCostData.NativeMethodInfoPtr_get_Discount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665826);
			WormSpiceCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665827);
			WormSpiceCostData.NativeMethodInfoPtr_SetDiscountAttribute_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665828);
			WormSpiceCostData.NativeMethodInfoPtr_SetAdditionalDiscount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665829);
			WormSpiceCostData.NativeMethodInfoPtr_ClearDiscount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665830);
			WormSpiceCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr, 100665831);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00050590 File Offset: 0x0004E790
		public unsafe override AttributeDefinition<Nullable<int>> Definition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712196, XrefRangeEnd = 712200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpiceCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x000505DC File Offset: 0x0004E7DC
		public unsafe int Discount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712200, XrefRangeEnd = 712204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostData.NativeMethodInfoPtr_get_Discount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00050618 File Offset: 0x0004E818
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 711377, RefRangeEnd = 711381, XrefRangeStart = 711377, XrefRangeEnd = 711381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpiceCostData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpiceCostData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00050664 File Offset: 0x0004E864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712216, RefRangeEnd = 712217, XrefRangeStart = 712204, XrefRangeEnd = 712216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDiscountAttribute(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostData.NativeMethodInfoPtr_SetDiscountAttribute_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x000506A8 File Offset: 0x0004E8A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 514363, RefRangeEnd = 514365, XrefRangeStart = 514363, XrefRangeEnd = 514365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditionalDiscount(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostData.NativeMethodInfoPtr_SetAdditionalDiscount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000506E8 File Offset: 0x0004E8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712219, RefRangeEnd = 712220, XrefRangeStart = 712217, XrefRangeEnd = 712219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDiscount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostData.NativeMethodInfoPtr_ClearDiscount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0005071C File Offset: 0x0004E91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712220, XrefRangeEnd = 712235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpiceCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000BA12 File Offset: 0x00009C12
		public WormSpiceCostData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00050760 File Offset: 0x0004E960
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x0000BA1B File Offset: 0x00009C1B
		public unsafe IAttribute<Nullable<int>> discountAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostData.NativeFieldInfoPtr_discountAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostData.NativeFieldInfoPtr_discountAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00050790 File Offset: 0x0004E990
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x0000BA3A File Offset: 0x00009C3A
		public unsafe int additionalDiscount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostData.NativeFieldInfoPtr_additionalDiscount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostData.NativeFieldInfoPtr_additionalDiscount)) = value;
			}
		}

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr_discountAttribute;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_additionalDiscount;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_Discount_Public_get_Int32_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_SetDiscountAttribute_Public_Void_IHasAttributes_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalDiscount_Public_Void_Int32_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_ClearDiscount_Public_Void_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
