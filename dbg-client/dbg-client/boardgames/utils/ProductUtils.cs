using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.utils
{
	// Token: 0x020000F5 RID: 245
	public class ProductUtils : MonoBehaviour
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x0003E724 File Offset: 0x0003C924
		// Note: this type is marked as 'beforefieldinit'.
		static ProductUtils()
		{
			Il2CppClassPointerStore<ProductUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "ProductUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr);
			ProductUtils.NativeMethodInfoPtr_ArchIDForProduct_Public_Abstract_Virtual_New_ArchetypeID_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664807);
			ProductUtils.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_New_Enum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664808);
			ProductUtils.NativeMethodInfoPtr_ProductForArchId_Public_Abstract_Virtual_New_Enum_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664809);
			ProductUtils.NativeMethodInfoPtr_StringForProduct_Public_Abstract_Virtual_New_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664810);
			ProductUtils.NativeMethodInfoPtr_ProductForString_Public_Abstract_Virtual_New_Enum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664811);
			ProductUtils.NativeMethodInfoPtr_GetProductLocName_Public_Abstract_Virtual_New_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664812);
			ProductUtils.NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_New_Enum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664813);
			ProductUtils.NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664814);
			ProductUtils.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr, 100664815);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0003E808 File Offset: 0x0003CA08
		[CallerCount(0)]
		public unsafe virtual ArchetypeID ArchIDForProduct(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_ArchIDForProduct_Public_Abstract_Virtual_New_ArchetypeID_Enum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0003E860 File Offset: 0x0003CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506790, XrefRangeEnd = 506794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Enum ProductForArchId(string archid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(archid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_New_Enum_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0003E8B8 File Offset: 0x0003CAB8
		[CallerCount(0)]
		public unsafe virtual Enum ProductForArchId(ArchetypeID archid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_ProductForArchId_Public_Abstract_Virtual_New_Enum_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0003E910 File Offset: 0x0003CB10
		[CallerCount(0)]
		public unsafe virtual string StringForProduct(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_StringForProduct_Public_Abstract_Virtual_New_String_Enum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0003E960 File Offset: 0x0003CB60
		[CallerCount(0)]
		public unsafe virtual Enum ProductForString(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_ProductForString_Public_Abstract_Virtual_New_Enum_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
		[CallerCount(0)]
		public unsafe virtual string GetProductLocName(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_GetProductLocName_Public_Abstract_Virtual_New_String_Enum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0003EA08 File Offset: 0x0003CC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506794, XrefRangeEnd = 506799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Enum ProductForNintendoAocIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_New_Enum_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0003EA5C File Offset: 0x0003CC5C
		public unsafe virtual int NintendoAocIndicesCount
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils.NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0003EAA4 File Offset: 0x0003CCA4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00007098 File Offset: 0x00005298
		public ProductUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_ArchIDForProduct_Public_Abstract_Virtual_New_ArchetypeID_Enum_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_ProductForArchId_Public_Virtual_New_Enum_String_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_ProductForArchId_Public_Abstract_Virtual_New_Enum_ArchetypeID_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_StringForProduct_Public_Abstract_Virtual_New_String_Enum_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_ProductForString_Public_Abstract_Virtual_New_Enum_String_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_GetProductLocName_Public_Abstract_Virtual_New_String_Enum_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_New_Enum_Int32_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
