using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000041 RID: 65
	public class LegacyResourcesProvider : ResourceProviderBase
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00011614 File Offset: 0x0000F814
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyResourcesProvider()
		{
			Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "LegacyResourcesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr);
			LegacyResourcesProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr, 100663822);
			LegacyResourcesProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr, 100663823);
			LegacyResourcesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr, 100663824);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00011680 File Offset: 0x0000F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140780, XrefRangeEnd = 1140833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pi));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyResourcesProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000116D4 File Offset: 0x0000F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140833, XrefRangeEnd = 1140842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(IResourceLocation location, Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyResourcesProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00011734 File Offset: 0x0000F934
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyResourcesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000034FB File Offset: 0x000016FB
		public LegacyResourcesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000086 RID: 134
		public class InternalOp : Object
		{
			// Token: 0x06000679 RID: 1657 RVA: 0x0001EA98 File Offset: 0x0001CC98
			// Note: this type is marked as 'beforefieldinit'.
			static InternalOp()
			{
				Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyResourcesProvider>.NativeClassPtr, "InternalOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr);
				LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, "m_RequestOperation");
				LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, "m_ProvideHandle");
				LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, 100663825);
				LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, 100663826);
				LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, 100663827);
				LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_PercentComplete_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, 100663828);
				LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr, 100663829);
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x0001EB50 File Offset: 0x0001CD50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140702, XrefRangeEnd = 1140739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(ProvideHandle provideHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x0001EB98 File Offset: 0x0001CD98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140739, XrefRangeEnd = 1140750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool WaitForCompletionHandler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x0001EBD4 File Offset: 0x0001CDD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1140778, RefRangeEnd = 1140779, XrefRangeStart = 1140750, XrefRangeEnd = 1140778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AsyncOperationCompleted(AsyncOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x0001EC18 File Offset: 0x0001CE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140779, XrefRangeEnd = 1140780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float PercentComplete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr_PercentComplete_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x0001EC54 File Offset: 0x0001CE54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyResourcesProvider.InternalOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x0000476D File Offset: 0x0000296D
			public InternalOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001EC90 File Offset: 0x0001CE90
			// (set) Token: 0x06000681 RID: 1665 RVA: 0x00004776 File Offset: 0x00002976
			public unsafe ResourceRequest m_RequestOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
			// (set) Token: 0x06000683 RID: 1667 RVA: 0x00004795 File Offset: 0x00002995
			public ProvideHandle m_ProvideHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle);
					return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyResourcesProvider.InternalOp.NativeFieldInfoPtr_m_ProvideHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400049D RID: 1181
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeFieldInfoPtr_m_ProvideHandle;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_AsyncOperation_0;

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeMethodInfoPtr_PercentComplete_Public_Single_0;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
