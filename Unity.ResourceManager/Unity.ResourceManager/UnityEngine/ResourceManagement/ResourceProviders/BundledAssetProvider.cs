using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000035 RID: 53
	public class BundledAssetProvider : ResourceProviderBase
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0000FE38 File Offset: 0x0000E038
		// Note: this type is marked as 'beforefieldinit'.
		static BundledAssetProvider()
		{
			Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "BundledAssetProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr);
			BundledAssetProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr, 100663762);
			BundledAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr, 100663763);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000FE90 File Offset: 0x0000E090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140392, XrefRangeEnd = 1140397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BundledAssetProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundledAssetProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000032BD File Offset: 0x000014BD
		public BundledAssetProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000082 RID: 130
		public class InternalOp : Object
		{
			// Token: 0x0600065B RID: 1627 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
			// Note: this type is marked as 'beforefieldinit'.
			static InternalOp()
			{
				Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BundledAssetProvider>.NativeClassPtr, "InternalOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr);
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_AssetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "m_AssetBundle");
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_PreloadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "m_PreloadRequest");
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "m_RequestOperation");
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "m_Result");
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "m_ProvideHandle");
				BundledAssetProvider.InternalOp.NativeFieldInfoPtr_subObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, "subObjectName");
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_T_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663764);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663765);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_BeginAssetLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663766);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663767);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_ActionComplete_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663768);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetArrayResult_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663769);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetListResult_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663770);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetAssetResult_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663771);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetAssetSubObjectResult_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663772);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663773);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr_ProgressCallback_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663774);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663775);
				BundledAssetProvider.InternalOp.NativeMethodInfoPtr__Start_b__7_0_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr, 100663776);
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x0001E548 File Offset: 0x0001C748
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1140120, RefRangeEnd = 1140121, XrefRangeStart = 1140099, XrefRangeEnd = 1140120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T LoadBundleFromDependecies<T>(IList<Object> results) where T : class
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.MethodInfoStoreGeneric_LoadBundleFromDependecies_Internal_Static_T_IList_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x0001E588 File Offset: 0x0001C788
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1140203, RefRangeEnd = 1140204, XrefRangeStart = 1140121, XrefRangeEnd = 1140203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(ProvideHandle provideHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1140259, RefRangeEnd = 1140261, XrefRangeStart = 1140204, XrefRangeEnd = 1140259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BeginAssetLoad()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_BeginAssetLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x0001E604 File Offset: 0x0001C804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140261, XrefRangeEnd = 1140272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool WaitForCompletionHandler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x0001E640 File Offset: 0x0001C840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140272, XrefRangeEnd = 1140340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ActionComplete(AsyncOperation obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_ActionComplete_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x0001E684 File Offset: 0x0001C884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140340, XrefRangeEnd = 1140347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetArrayResult(Il2CppReferenceArray<Object> allAssets)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetArrayResult_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x0001E6C8 File Offset: 0x0001C8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140347, XrefRangeEnd = 1140354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetListResult(Il2CppReferenceArray<Object> allAssets)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetListResult_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x0001E70C File Offset: 0x0001C90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140354, XrefRangeEnd = 1140365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetAssetResult(Object asset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetAssetResult_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x0001E750 File Offset: 0x0001C950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140365, XrefRangeEnd = 1140371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetAssetSubObjectResult(Il2CppReferenceArray<Object> allAssets)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAssets);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_GetAssetSubObjectResult_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000665 RID: 1637 RVA: 0x0001E794 File Offset: 0x0001C994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140371, XrefRangeEnd = 1140390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompleteOperation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140390, XrefRangeEnd = 1140391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float ProgressCallback()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_ProgressCallback_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x0001E804 File Offset: 0x0001CA04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x0001E840 File Offset: 0x0001CA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140391, XrefRangeEnd = 1140392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__7_0(AsyncOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundledAssetProvider.InternalOp.NativeMethodInfoPtr__Start_b__7_0_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x0000469B File Offset: 0x0000289B
			public InternalOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001E884 File Offset: 0x0001CA84
			// (set) Token: 0x0600066B RID: 1643 RVA: 0x000046A4 File Offset: 0x000028A4
			public unsafe AssetBundle m_AssetBundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_AssetBundle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_AssetBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
			// (set) Token: 0x0600066D RID: 1645 RVA: 0x000046C3 File Offset: 0x000028C3
			public unsafe AssetBundleRequest m_PreloadRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_PreloadRequest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_PreloadRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
			// (set) Token: 0x0600066F RID: 1647 RVA: 0x000046E2 File Offset: 0x000028E2
			public unsafe AssetBundleRequest m_RequestOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001E914 File Offset: 0x0001CB14
			// (set) Token: 0x06000671 RID: 1649 RVA: 0x00004701 File Offset: 0x00002901
			public unsafe Object m_Result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_Result);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001E944 File Offset: 0x0001CB44
			// (set) Token: 0x06000673 RID: 1651 RVA: 0x00004720 File Offset: 0x00002920
			public ProvideHandle m_ProvideHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle);
					return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x0001E974 File Offset: 0x0001CB74
			// (set) Token: 0x06000675 RID: 1653 RVA: 0x0000474E File Offset: 0x0000294E
			public unsafe string subObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_subObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundledAssetProvider.InternalOp.NativeFieldInfoPtr_subObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000487 RID: 1159
			private static readonly IntPtr NativeFieldInfoPtr_m_AssetBundle;

			// Token: 0x04000488 RID: 1160
			private static readonly IntPtr NativeFieldInfoPtr_m_PreloadRequest;

			// Token: 0x04000489 RID: 1161
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeFieldInfoPtr_m_Result;

			// Token: 0x0400048B RID: 1163
			private static readonly IntPtr NativeFieldInfoPtr_m_ProvideHandle;

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeFieldInfoPtr_subObjectName;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_T_IList_1_Object_0;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeMethodInfoPtr_BeginAssetLoad_Private_Void_0;

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeMethodInfoPtr_ActionComplete_Private_Void_AsyncOperation_0;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeMethodInfoPtr_GetArrayResult_Private_Void_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr_GetListResult_Private_Void_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeMethodInfoPtr_GetAssetResult_Private_Void_Object_0;

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeMethodInfoPtr_GetAssetSubObjectResult_Private_Void_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Private_Void_0;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr_ProgressCallback_Public_Single_0;

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000499 RID: 1177
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Private_Void_AsyncOperation_0;

			// Token: 0x020000AD RID: 173
			private sealed class MethodInfoStoreGeneric_LoadBundleFromDependecies_Internal_Static_T_IList_1_Object_0<T>
			{
				// Token: 0x04000518 RID: 1304
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BundledAssetProvider.InternalOp.NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_T_IList_1_Object_0, Il2CppClassPointerStore<BundledAssetProvider.InternalOp>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
