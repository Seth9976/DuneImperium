using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.utils
{
	// Token: 0x020000F6 RID: 246
	public class ProductUtils<T> : ProductUtils where T : Enum
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductUtils()
		{
			Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "ProductUtils`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr);
			ProductUtils<T>.NativeMethodInfoPtr_archIDForProduct_Protected_Abstract_Virtual_New_ArchetypeID_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664816);
			ProductUtils<T>.NativeMethodInfoPtr_productForArchId_Protected_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664817);
			ProductUtils<T>.NativeMethodInfoPtr_productForArchId_Protected_Abstract_Virtual_New_T_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664818);
			ProductUtils<T>.NativeMethodInfoPtr_stringForProduct_Protected_Abstract_Virtual_New_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664819);
			ProductUtils<T>.NativeMethodInfoPtr_productForString_Protected_Abstract_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664820);
			ProductUtils<T>.NativeMethodInfoPtr_getProductLocName_Protected_Abstract_Virtual_New_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664821);
			ProductUtils<T>.NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664822);
			ProductUtils<T>.NativeMethodInfoPtr_ArchIDForProduct_Public_Virtual_Final_ArchetypeID_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664823);
			ProductUtils<T>.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664824);
			ProductUtils<T>.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664825);
			ProductUtils<T>.NativeMethodInfoPtr_StringForProduct_Public_Virtual_Final_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664826);
			ProductUtils<T>.NativeMethodInfoPtr_ProductForString_Public_Virtual_Final_Enum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664827);
			ProductUtils<T>.NativeMethodInfoPtr_GetProductLocName_Public_Virtual_Final_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664828);
			ProductUtils<T>.NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_Final_Enum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664829);
			ProductUtils<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr, 100664830);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0003EC78 File Offset: 0x0003CE78
		[CallerCount(0)]
		public unsafe virtual ArchetypeID archIDForProduct(T product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = product;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref product;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_archIDForProduct_Protected_Abstract_Virtual_New_ArchetypeID_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr4) : null;
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0003ED0C File Offset: 0x0003CF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506799, XrefRangeEnd = 506809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T productForArchId(string archid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(archid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_productForArchId_Protected_Virtual_New_T_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0003ED64 File Offset: 0x0003CF64
		[CallerCount(0)]
		public unsafe virtual T productForArchId(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_productForArchId_Protected_Abstract_Virtual_New_T_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0003EDBC File Offset: 0x0003CFBC
		[CallerCount(0)]
		public unsafe virtual string stringForProduct(T product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = product;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref product;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_stringForProduct_Protected_Abstract_Virtual_New_String_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0003EE48 File Offset: 0x0003D048
		[CallerCount(0)]
		public unsafe virtual T productForString(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_productForString_Protected_Abstract_Virtual_New_T_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0003EEA0 File Offset: 0x0003D0A0
		[CallerCount(0)]
		public unsafe virtual string getProductLocName(T product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = product;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref product;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_getProductLocName_Protected_Abstract_Virtual_New_String_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0003EF2C File Offset: 0x0003D12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297223, RefRangeEnd = 297224, XrefRangeStart = 297223, XrefRangeEnd = 297224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T productForNintendoAocIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductUtils<T>.NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_New_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0003EF80 File Offset: 0x0003D180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506809, XrefRangeEnd = 506815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ArchetypeID ArchIDForProduct(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_ArchIDForProduct_Public_Virtual_Final_ArchetypeID_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0003EFCC File Offset: 0x0003D1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506815, XrefRangeEnd = 506816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Enum ProductForArchId(string archid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(archid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0003F01C File Offset: 0x0003D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506816, XrefRangeEnd = 506817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Enum ProductForArchId(ArchetypeID archid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0003F06C File Offset: 0x0003D26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506817, XrefRangeEnd = 506821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string StringForProduct(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_StringForProduct_Public_Virtual_Final_String_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0003F0B0 File Offset: 0x0003D2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506821, XrefRangeEnd = 506822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Enum ProductForString(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_ProductForString_Public_Virtual_Final_Enum_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0003F100 File Offset: 0x0003D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506822, XrefRangeEnd = 506826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetProductLocName(Enum product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_GetProductLocName_Public_Virtual_Final_String_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0003F144 File Offset: 0x0003D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506826, XrefRangeEnd = 506827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Enum ProductForNintendoAocIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_Final_Enum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0003F190 File Offset: 0x0003D390
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductUtils<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductUtils<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000070A1 File Offset: 0x000052A1
		public ProductUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_archIDForProduct_Protected_Abstract_Virtual_New_ArchetypeID_T_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_productForArchId_Protected_Virtual_New_T_String_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_productForArchId_Protected_Abstract_Virtual_New_T_ArchetypeID_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_stringForProduct_Protected_Abstract_Virtual_New_String_T_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_productForString_Protected_Abstract_Virtual_New_T_String_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_getProductLocName_Protected_Abstract_Virtual_New_String_T_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_New_T_Int32_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_ArchIDForProduct_Public_Virtual_Final_ArchetypeID_Enum_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_String_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_ProductForArchId_Public_Virtual_Final_Enum_ArchetypeID_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_StringForProduct_Public_Virtual_Final_String_Enum_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_ProductForString_Public_Virtual_Final_Enum_String_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_GetProductLocName_Public_Virtual_Final_String_Enum_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_ProductForNintendoAocIndex_Public_Virtual_Final_Enum_Int32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
