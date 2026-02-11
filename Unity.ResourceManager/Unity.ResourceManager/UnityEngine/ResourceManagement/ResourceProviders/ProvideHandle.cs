using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003A RID: 58
	public sealed class ProvideHandle : ValueType
	{
		// Token: 0x06000303 RID: 771 RVA: 0x000106C8 File Offset: 0x0000E8C8
		// Note: this type is marked as 'beforefieldinit'.
		static ProvideHandle()
		{
			Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "ProvideHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr);
			ProvideHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, "m_Version");
			ProvideHandle.NativeFieldInfoPtr_m_InternalOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, "m_InternalOp");
			ProvideHandle.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, "m_ResourceManager");
			ProvideHandle.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_IGenericProviderOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663790);
			ProvideHandle.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663791);
			ProvideHandle.NativeMethodInfoPtr_get_InternalOp_Internal_get_IGenericProviderOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663792);
			ProvideHandle.NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663793);
			ProvideHandle.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663794);
			ProvideHandle.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663795);
			ProvideHandle.NativeMethodInfoPtr_get_DependencyCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663796);
			ProvideHandle.NativeMethodInfoPtr_GetDependency_Public_TDepObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663797);
			ProvideHandle.NativeMethodInfoPtr_GetDependencies_Public_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663798);
			ProvideHandle.NativeMethodInfoPtr_SetProgressCallback_Public_Void_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663799);
			ProvideHandle.NativeMethodInfoPtr_SetDownloadProgressCallbacks_Public_Void_Func_1_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663800);
			ProvideHandle.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663801);
			ProvideHandle.NativeMethodInfoPtr_Complete_Public_Void_T_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, 100663802);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010838 File Offset: 0x0000EA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140481, XrefRangeEnd = 1140486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProvideHandle(ResourceManager rm, IGenericProviderOperation op)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_IGenericProviderOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0001089C File Offset: 0x0000EA9C
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140486, XrefRangeEnd = 1140487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000108E0 File Offset: 0x0000EAE0
		public unsafe IGenericProviderOperation InternalOp
		{
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 1140490, RefRangeEnd = 1140544, XrefRangeStart = 1140487, XrefRangeEnd = 1140490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_InternalOp_Internal_get_IGenericProviderOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGenericProviderOperation>(intPtr3) : null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00010924 File Offset: 0x0000EB24
		public unsafe ResourceManager ResourceManager
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00010968 File Offset: 0x0000EB68
		public unsafe Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1140549, RefRangeEnd = 1140559, XrefRangeStart = 1140544, XrefRangeEnd = 1140549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000109AC File Offset: 0x0000EBAC
		public unsafe IResourceLocation Location
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1140564, RefRangeEnd = 1140586, XrefRangeStart = 1140559, XrefRangeEnd = 1140564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public unsafe int DependencyCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140586, XrefRangeEnd = 1140591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_get_DependencyCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010A34 File Offset: 0x0000EC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1140597, RefRangeEnd = 1140598, XrefRangeStart = 1140591, XrefRangeEnd = 1140597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TDepObject GetDependency<TDepObject>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.MethodInfoStoreGeneric_GetDependency_Public_TDepObject_Int32_0<TDepObject>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDepObject>(intPtr, false, true);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010A80 File Offset: 0x0000EC80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1140603, RefRangeEnd = 1140605, XrefRangeStart = 1140598, XrefRangeEnd = 1140603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDependencies(IList<Object> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_GetDependencies_Public_Void_IList_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1140611, RefRangeEnd = 1140616, XrefRangeStart = 1140605, XrefRangeEnd = 1140611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgressCallback(Func<float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_SetProgressCallback_Public_Void_Func_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010B10 File Offset: 0x0000ED10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1140622, RefRangeEnd = 1140623, XrefRangeStart = 1140616, XrefRangeEnd = 1140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDownloadProgressCallbacks(Func<DownloadStatus> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_SetDownloadProgressCallbacks_Public_Void_Func_1_DownloadStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00010B58 File Offset: 0x0000ED58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1140629, RefRangeEnd = 1140635, XrefRangeStart = 1140623, XrefRangeEnd = 1140629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitForCompletionCallback(Func<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Void_Func_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1140647, RefRangeEnd = 1140672, XrefRangeStart = 1140635, XrefRangeEnd = 1140647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete<T>(T result, bool status, Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = result;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProvideHandle.MethodInfoStoreGeneric_Complete_Public_Void_T_Boolean_Exception_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000339D File Offset: 0x0000159D
		public ProvideHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000033A6 File Offset: 0x000015A6
		public ProvideHandle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr))
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00010C40 File Offset: 0x0000EE40
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000033B8 File Offset: 0x000015B8
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00010C68 File Offset: 0x0000EE68
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000033D3 File Offset: 0x000015D3
		public unsafe IGenericProviderOperation m_InternalOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_InternalOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGenericProviderOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_InternalOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00010C98 File Offset: 0x0000EE98
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000033F2 File Offset: 0x000015F2
		public unsafe ResourceManager m_ResourceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_ResourceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvideHandle.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalOp;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_IGenericProviderOperation_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalOp_Internal_get_IGenericProviderOperation_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyCount_Public_get_Int32_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_GetDependency_Public_TDepObject_Int32_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Void_IList_1_Object_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_SetProgressCallback_Public_Void_Func_1_Single_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadProgressCallbacks_Public_Void_Func_1_DownloadStatus_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Void_Func_1_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_T_Boolean_Exception_0;

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_GetDependency_Public_TDepObject_Int32_0<TDepObject>
		{
			// Token: 0x0400049B RID: 1179
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProvideHandle.NativeMethodInfoPtr_GetDependency_Public_TDepObject_Int32_0, Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDepObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000085 RID: 133
		private sealed class MethodInfoStoreGeneric_Complete_Public_Void_T_Boolean_Exception_0<T>
		{
			// Token: 0x0400049C RID: 1180
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProvideHandle.NativeMethodInfoPtr_Complete_Public_Void_T_Boolean_Exception_0, Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
