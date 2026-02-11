using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000015 RID: 21
	public class CheckCatalogsOperation : AsyncOperationBase<List<string>>
	{
		// Token: 0x060001DD RID: 477 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// Note: this type is marked as 'beforefieldinit'.
		static CheckCatalogsOperation()
		{
			Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "CheckCatalogsOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr);
			CheckCatalogsOperation.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, "m_Addressables");
			CheckCatalogsOperation.NativeFieldInfoPtr_m_LocalHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, "m_LocalHashes");
			CheckCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, "m_LocatorInfos");
			CheckCatalogsOperation.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, "m_DepOp");
			CheckCatalogsOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663718);
			CheckCatalogsOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_String_List_1_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663719);
			CheckCatalogsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663720);
			CheckCatalogsOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663721);
			CheckCatalogsOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663722);
			CheckCatalogsOperation.NativeMethodInfoPtr_ProcessDependentOpResults_Internal_Static_List_1_String_IList_1_AsyncOperationHandle_List_1_ResourceLocatorInfo_List_1_String_byref_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663723);
			CheckCatalogsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, 100663724);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000DD14 File Offset: 0x0000BF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162106, XrefRangeEnd = 1162110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckCatalogsOperation(AddressablesImpl aa)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckCatalogsOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000DD60 File Offset: 0x0000BF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162195, RefRangeEnd = 1162196, XrefRangeStart = 1162110, XrefRangeEnd = 1162195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locatorInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckCatalogsOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_String_List_1_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<List<string>>(intPtr);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162196, XrefRangeEnd = 1162217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckCatalogsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162217, XrefRangeEnd = 1162220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckCatalogsOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000DE2C File Offset: 0x0000C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162220, XrefRangeEnd = 1162226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckCatalogsOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000DE7C File Offset: 0x0000C07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162300, RefRangeEnd = 1162301, XrefRangeStart = 1162226, XrefRangeEnd = 1162300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locatorInfos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localHashes);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &success;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CheckCatalogsOperation.NativeMethodInfoPtr_ProcessDependentOpResults_Internal_Static_List_1_String_IList_1_AsyncOperationHandle_List_1_ResourceLocatorInfo_List_1_String_byref_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			errorString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr4) : null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000DF10 File Offset: 0x0000C110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162301, XrefRangeEnd = 1162308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckCatalogsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000277B File Offset: 0x0000097B
		public CheckCatalogsOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000DF4C File Offset: 0x0000C14C
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002784 File Offset: 0x00000984
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000DF7C File Offset: 0x0000C17C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000027A3 File Offset: 0x000009A3
		public unsafe List<string> m_LocalHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_LocalHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_LocalHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000027C2 File Offset: 0x000009C2
		public unsafe List<ResourceLocatorInfo> m_LocatorInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceLocatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000027E1 File Offset: 0x000009E1
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckCatalogsOperation.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalHashes;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_m_LocatorInfos;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_String_List_1_ResourceLocatorInfo_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDependentOpResults_Internal_Static_List_1_String_IList_1_AsyncOperationHandle_List_1_ResourceLocatorInfo_List_1_String_byref_String_byref_Boolean_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("UnityEngine.AddressableAssets.CheckCatalogsOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060004F8 RID: 1272 RVA: 0x00017E64 File Offset: 0x00016064
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckCatalogsOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr);
				CheckCatalogsOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr, "<>9");
				CheckCatalogsOperation.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr, "<>9__5_0");
				CheckCatalogsOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr, 100663726);
				CheckCatalogsOperation.__c.NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_IResourceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr, 100663727);
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x00017EE0 File Offset: 0x000160E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckCatalogsOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckCatalogsOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x00017F1C File Offset: 0x0001611C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162097, XrefRangeEnd = 1162106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__5_0(IResourceProvider rp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckCatalogsOperation.__c.NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_IResourceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x000040A0 File Offset: 0x000022A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060004FC RID: 1276 RVA: 0x00017F6C File Offset: 0x0001616C
			// (set) Token: 0x060004FD RID: 1277 RVA: 0x000040A9 File Offset: 0x000022A9
			public unsafe static CheckCatalogsOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckCatalogsOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckCatalogsOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckCatalogsOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060004FE RID: 1278 RVA: 0x00017F94 File Offset: 0x00016194
			// (set) Token: 0x060004FF RID: 1279 RVA: 0x000040BB File Offset: 0x000022BB
			public unsafe static Func<IResourceProvider, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckCatalogsOperation.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IResourceProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckCatalogsOperation.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_IResourceProvider_0;
		}
	}
}
