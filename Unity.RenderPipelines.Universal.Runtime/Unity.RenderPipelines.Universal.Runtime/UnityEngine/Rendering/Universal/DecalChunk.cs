using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000069 RID: 105
	public class DecalChunk : Object
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x00034D5C File Offset: 0x00032F5C
		// Note: this type is marked as 'beforefieldinit'.
		static DecalChunk()
		{
			Il2CppClassPointerStore<DecalChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr);
			DecalChunk.NativeFieldInfoPtr__count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, "<count>k__BackingField");
			DecalChunk.NativeFieldInfoPtr__capacity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, "<capacity>k__BackingField");
			DecalChunk.NativeFieldInfoPtr__currentJobHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, "<currentJobHandle>k__BackingField");
			DecalChunk.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664539);
			DecalChunk.NativeMethodInfoPtr_set_count_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664540);
			DecalChunk.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664541);
			DecalChunk.NativeMethodInfoPtr_set_capacity_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664542);
			DecalChunk.NativeMethodInfoPtr_get_currentJobHandle_Public_get_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664543);
			DecalChunk.NativeMethodInfoPtr_set_currentJobHandle_Public_set_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664544);
			DecalChunk.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664545);
			DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664546);
			DecalChunk.NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664547);
			DecalChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664548);
			DecalChunk.NativeMethodInfoPtr_ResizeNativeArray_Protected_Void_byref_TransformAccessArray_Il2CppReferenceArray_1_DecalProjector_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664549);
			DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664550);
			DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664551);
			DecalChunk.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr, 100664552);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00034EE0 File Offset: 0x000330E0
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00034F1C File Offset: 0x0003311C
		public unsafe int count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_set_count_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00034F5C File Offset: 0x0003315C
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00034F98 File Offset: 0x00033198
		public unsafe int capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_set_capacity_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00034FD8 File Offset: 0x000331D8
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00035014 File Offset: 0x00033214
		public unsafe JobHandle currentJobHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_get_currentJobHandle_Public_get_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_set_currentJobHandle_Public_set_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00035054 File Offset: 0x00033254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334682, XrefRangeStart = 334680, XrefRangeEnd = 334682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalChunk.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00035090 File Offset: 0x00033290
		[CallerCount(0)]
		public unsafe virtual void RemoveAtSwapBack(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000350DC File Offset: 0x000332DC
		[CallerCount(0)]
		public unsafe virtual void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalChunk.NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00035128 File Offset: 0x00033328
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00035164 File Offset: 0x00033364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606753, XrefRangeEnd = 606760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeNativeArray(ref TransformAccessArray array, Il2CppReferenceArray<DecalProjector> decalProjectors, int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalProjectors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr_ResizeNativeArray_Protected_Void_byref_TransformAccessArray_Il2CppReferenceArray_1_DecalProjector_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000351C4 File Offset: 0x000333C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606760, RefRangeEnd = 606761, XrefRangeStart = 606760, XrefRangeEnd = 606760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.MethodInfoStoreGeneric_RemoveAtSwapBack_Protected_Void_byref_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00035224 File Offset: 0x00033424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606761, RefRangeEnd = 606762, XrefRangeStart = 606761, XrefRangeEnd = 606761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAtSwapBack<T>(ref Il2CppArrayBase<T> array, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecalChunk.MethodInfoStoreGeneric_RemoveAtSwapBack_Protected_Void_byref_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00035298 File Offset: 0x00033498
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalChunk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalChunk.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00005FA9 File Offset: 0x000041A9
		public DecalChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000352D4 File Offset: 0x000334D4
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00005FB2 File Offset: 0x000041B2
		public unsafe int _count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__count_k__BackingField)) = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x000352FC File Offset: 0x000334FC
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00005FCD File Offset: 0x000041CD
		public unsafe int _capacity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__capacity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__capacity_k__BackingField)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00035324 File Offset: 0x00033524
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00005FE8 File Offset: 0x000041E8
		public unsafe JobHandle _currentJobHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__currentJobHandle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalChunk.NativeFieldInfoPtr__currentJobHandle_k__BackingField)) = value;
			}
		}

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr__count_k__BackingField;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr__capacity_k__BackingField;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr__currentJobHandle_k__BackingField;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_set_count_Protected_set_Void_Int32_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_set_capacity_Protected_set_Void_Int32_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_currentJobHandle_Public_get_JobHandle_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_set_currentJobHandle_Public_set_Void_JobHandle_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Virtual_New_Void_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_ResizeNativeArray_Protected_Void_byref_TransformAccessArray_Il2CppReferenceArray_1_DecalProjector_Int32_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200017E RID: 382
		private sealed class MethodInfoStoreGeneric_RemoveAtSwapBack_Protected_Void_byref_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040014D0 RID: 5328
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<DecalChunk>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017F RID: 383
		private sealed class MethodInfoStoreGeneric_RemoveAtSwapBack_Protected_Void_byref_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040014D1 RID: 5329
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecalChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Protected_Void_byref_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<DecalChunk>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
