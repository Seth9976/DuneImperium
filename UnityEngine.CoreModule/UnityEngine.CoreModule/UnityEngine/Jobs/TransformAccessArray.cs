using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Jobs
{
	// Token: 0x02000192 RID: 402
	[StructLayout(2)]
	public struct TransformAccessArray
	{
		// Token: 0x06001E1B RID: 7707 RVA: 0x00088540 File Offset: 0x00086740
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAccessArray()
		{
			Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "TransformAccessArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr);
			TransformAccessArray.NativeFieldInfoPtr_m_TransformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, "m_TransformArray");
			TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667455);
			TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667456);
			TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667457);
			TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667458);
			TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667459);
			TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667460);
			TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667461);
			TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667462);
			TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667463);
			TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667464);
			TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667465);
			TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667466);
			TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667467);
			TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667468);
			TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667469);
			TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667470);
			TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100667471);
			TransformAccessArray.SetTransformsDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetTransformsDelegate>("UnityEngine.Jobs.TransformAccessArray::SetTransforms");
			TransformAccessArray.AddInstanceIdDelegateField = IL2CPP.ResolveICall<TransformAccessArray.AddInstanceIdDelegate>("UnityEngine.Jobs.TransformAccessArray::AddInstanceId");
			TransformAccessArray.GetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.GetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::GetCapacity");
			TransformAccessArray.SetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::SetCapacity");
			TransformAccessArray.SetTransformDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetTransformDelegate>("UnityEngine.Jobs.TransformAccessArray::SetTransform");
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00088724 File Offset: 0x00086924
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 677741, RefRangeEnd = 677744, XrefRangeStart = 677738, XrefRangeEnd = 677741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformAccessArray(int capacity, int desiredJobCount = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00088764 File Offset: 0x00086964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677744, XrefRangeEnd = 677747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &array;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000887B4 File Offset: 0x000869B4
		public unsafe bool isCreated
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 677748, RefRangeEnd = 677751, XrefRangeStart = 677747, XrefRangeEnd = 677748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000887E4 File Offset: 0x000869E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 677754, RefRangeEnd = 677758, XrefRangeStart = 677751, XrefRangeEnd = 677754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0008880C File Offset: 0x00086A0C
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetTransformAccessArrayForSchedule()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000650 RID: 1616
		public unsafe Transform this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 677760, RefRangeEnd = 677761, XrefRangeStart = 677758, XrefRangeEnd = 677760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
				}
			}
			set
			{
				TransformAccessArray.SetTransform(this.m_TransformArray, index, value);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0008887C File Offset: 0x00086A7C
		public unsafe int length
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 677763, RefRangeEnd = 677769, XrefRangeStart = 677761, XrefRangeEnd = 677763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000888AC File Offset: 0x00086AAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 677771, RefRangeEnd = 677775, XrefRangeStart = 677769, XrefRangeEnd = 677771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Transform transform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000888E4 File Offset: 0x00086AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677777, RefRangeEnd = 677778, XrefRangeStart = 677775, XrefRangeEnd = 677777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAtSwapBack(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00088918 File Offset: 0x00086B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677778, XrefRangeEnd = 677780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(int capacity, int desiredJobCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00088964 File Offset: 0x00086B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677780, XrefRangeEnd = 677782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyTransformAccessArray(IntPtr transformArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00088998 File Offset: 0x00086B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677782, XrefRangeEnd = 677784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Add(IntPtr transformArrayIntPtr, Transform transform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x000889DC File Offset: 0x00086BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677784, XrefRangeEnd = 677786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00088A1C File Offset: 0x00086C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677788, RefRangeEnd = 677789, XrefRangeStart = 677786, XrefRangeEnd = 677788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00088A5C File Offset: 0x00086C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677791, RefRangeEnd = 677792, XrefRangeStart = 677789, XrefRangeEnd = 677791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00088A9C File Offset: 0x00086C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677792, XrefRangeEnd = 677794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLength(IntPtr transformArrayIntPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00088ADC File Offset: 0x00086CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677794, XrefRangeEnd = 677796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetTransform(IntPtr transformArrayIntPtr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transformArrayIntPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0000B4F2 File Offset: 0x000096F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, ref this));
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00088B2C File Offset: 0x00086D2C
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0000B515 File Offset: 0x00009715
		public int capacity
		{
			get
			{
				return TransformAccessArray.GetCapacity(this.m_TransformArray);
			}
			set
			{
				TransformAccessArray.SetCapacity(this.m_TransformArray, value);
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0000B525 File Offset: 0x00009725
		public void Add(int instanceId)
		{
			TransformAccessArray.AddInstanceId(this.m_TransformArray, instanceId);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000B535 File Offset: 0x00009735
		public void SetTransforms(Il2CppReferenceArray<Transform> transforms)
		{
			TransformAccessArray.SetTransforms(this.m_TransformArray, transforms);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0000B545 File Offset: 0x00009745
		public static void SetTransforms(IntPtr transformArrayIntPtr, Il2CppReferenceArray<Transform> transforms)
		{
			TransformAccessArray.SetTransformsDelegateField(transformArrayIntPtr, IL2CPP.Il2CppObjectBaseToPtr(transforms));
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0000B558 File Offset: 0x00009758
		public static void AddInstanceId(IntPtr transformArrayIntPtr, int instanceId)
		{
			TransformAccessArray.AddInstanceIdDelegateField(transformArrayIntPtr, instanceId);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000B566 File Offset: 0x00009766
		public static int GetCapacity(IntPtr transformArrayIntPtr)
		{
			return TransformAccessArray.GetCapacityDelegateField(transformArrayIntPtr);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0000B573 File Offset: 0x00009773
		public static void SetCapacity(IntPtr transformArrayIntPtr, int capacity)
		{
			TransformAccessArray.SetCapacityDelegateField(transformArrayIntPtr, capacity);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0000B581 File Offset: 0x00009781
		public static void SetTransform(IntPtr transformArrayIntPtr, int index, Transform transform)
		{
			TransformAccessArray.SetTransformDelegateField(transformArrayIntPtr, index, IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformArray;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Transform_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0;

		// Token: 0x04001A80 RID: 6784
		[FieldOffset(0)]
		public IntPtr m_TransformArray;

		// Token: 0x04001A81 RID: 6785
		private static readonly TransformAccessArray.SetTransformsDelegate SetTransformsDelegateField;

		// Token: 0x04001A82 RID: 6786
		private static readonly TransformAccessArray.AddInstanceIdDelegate AddInstanceIdDelegateField;

		// Token: 0x04001A83 RID: 6787
		private static readonly TransformAccessArray.GetCapacityDelegate GetCapacityDelegateField;

		// Token: 0x04001A84 RID: 6788
		private static readonly TransformAccessArray.SetCapacityDelegate SetCapacityDelegateField;

		// Token: 0x04001A85 RID: 6789
		private static readonly TransformAccessArray.SetTransformDelegate SetTransformDelegateField;

		// Token: 0x0200083A RID: 2106
		// (Invoke) Token: 0x06003927 RID: 14631
		private delegate void SetTransformsDelegate(IntPtr transformArrayIntPtr, IntPtr transforms);

		// Token: 0x0200083B RID: 2107
		// (Invoke) Token: 0x06003929 RID: 14633
		private delegate void AddInstanceIdDelegate(IntPtr transformArrayIntPtr, int instanceId);

		// Token: 0x0200083C RID: 2108
		// (Invoke) Token: 0x0600392B RID: 14635
		private delegate int GetCapacityDelegate(IntPtr transformArrayIntPtr);

		// Token: 0x0200083D RID: 2109
		// (Invoke) Token: 0x0600392D RID: 14637
		private delegate void SetCapacityDelegate(IntPtr transformArrayIntPtr, int capacity);

		// Token: 0x0200083E RID: 2110
		// (Invoke) Token: 0x0600392F RID: 14639
		private delegate void SetTransformDelegate(IntPtr transformArrayIntPtr, int index, IntPtr transform);
	}
}
