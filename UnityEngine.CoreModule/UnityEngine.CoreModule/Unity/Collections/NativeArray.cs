using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	// Token: 0x0200003C RID: 60
	public sealed class NativeArray<T> : ValueType where T : new()
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0001AD58 File Offset: 0x00018F58
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArray()
		{
			Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr);
			NativeArray<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Buffer");
			NativeArray<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Length");
			NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_AllocatorLabel");
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663430);
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663431);
			NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663432);
			NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663433);
			NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663434);
			NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663435);
			NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663436);
			NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663437);
			NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663438);
			NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663439);
			NativeArray<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663440);
			NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663441);
			NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663442);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663443);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663444);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663445);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663446);
			NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663447);
			NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663448);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663449);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663450);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663451);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663452);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663453);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663454);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663455);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663456);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663457);
			NativeArray<T>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663458);
			NativeArray<T>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663459);
			NativeArray<T>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663460);
			NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663461);
			NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663462);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001B094 File Offset: 0x00019294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643470, RefRangeEnd = 643471, XrefRangeStart = 643466, XrefRangeEnd = 643470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001B0FC File Offset: 0x000192FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643471, XrefRangeEnd = 643475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(Il2CppArrayBase<T> array, Allocator allocator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001B15C File Offset: 0x0001935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643475, XrefRangeEnd = 643479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Allocate(int length, Allocator allocator, out NativeArray<T> array)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new NativeArray<T>(intPtr4));
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001B1C0 File Offset: 0x000193C0
		public unsafe int Length
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643479, XrefRangeEnd = 643480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001B2DC File Offset: 0x000194DC
		public unsafe bool IsCreated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001B320 File Offset: 0x00019520
		[CallerCount(132)]
		[CachedScanResults(RefRangeStart = 643482, RefRangeEnd = 643614, XrefRangeStart = 643480, XrefRangeEnd = 643482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001B358 File Offset: 0x00019558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643614, XrefRangeEnd = 643620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputDeps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643620, XrefRangeEnd = 643622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643622, XrefRangeEnd = 643632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001B438 File Offset: 0x00019638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643632, XrefRangeEnd = 643645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001B474 File Offset: 0x00019674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643645, XrefRangeEnd = 643647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>.Enumerator(intPtr);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643647, XrefRangeEnd = 643651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001B4F4 File Offset: 0x000196F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643651, XrefRangeEnd = 643655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001B538 File Offset: 0x00019738
		[CallerCount(0)]
		public unsafe bool Equals(NativeArray<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001B590 File Offset: 0x00019790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643655, XrefRangeEnd = 643662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001B5E4 File Offset: 0x000197E4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001B628 File Offset: 0x00019828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643663, RefRangeEnd = 643665, XrefRangeStart = 643662, XrefRangeEnd = 643663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(NativeArray<T> left, NativeArray<T> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001B688 File Offset: 0x00019888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643665, XrefRangeEnd = 643674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001B6D8 File Offset: 0x000198D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643674, XrefRangeEnd = 643683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001B728 File Offset: 0x00019928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643683, XrefRangeEnd = 643697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001B788 File Offset: 0x00019988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643697, XrefRangeEnd = 643706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001B7E4 File Offset: 0x000199E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643706, XrefRangeEnd = 643720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001B860 File Offset: 0x00019A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643720, XrefRangeEnd = 643722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643722, XrefRangeEnd = 643734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001B954 File Offset: 0x00019B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643734, XrefRangeEnd = 643742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(Il2CppArrayBase<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0001B9CC File Offset: 0x00019BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643742, XrefRangeEnd = 643750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(NativeArray<T> src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001BA44 File Offset: 0x00019C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643750, XrefRangeEnd = 643752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> InternalReinterpret<U>(int length) where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<U>.MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<U>(intPtr);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001BA90 File Offset: 0x00019C90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 643755, RefRangeEnd = 643761, XrefRangeStart = 643752, XrefRangeEnd = 643755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> Reinterpret<U>() where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<U>.MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<U>(intPtr);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001BACC File Offset: 0x00019CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643765, RefRangeEnd = 643766, XrefRangeStart = 643761, XrefRangeEnd = 643765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expectedTypeSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<U>.MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<U>(intPtr);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001BB18 File Offset: 0x00019D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643766, XrefRangeEnd = 643769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T> GetSubArray(int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001BB70 File Offset: 0x00019D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643771, RefRangeEnd = 643773, XrefRangeStart = 643769, XrefRangeEnd = 643771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T>.ReadOnly AsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>.ReadOnly(intPtr);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003114 File Offset: 0x00001314
		public NativeArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000311D File Offset: 0x0000131D
		public NativeArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001BBAC File Offset: 0x00019DAC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000312F File Offset: 0x0000132F
		public unsafe void* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000314A File Offset: 0x0000134A
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00003165 File Offset: 0x00001365
		public unsafe Allocator m_AllocatorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel)) = value;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001BC20 File Offset: 0x00019E20
		public static void CheckAllocateArguments(int length, Allocator allocator)
		{
			bool flag = allocator <= Allocator.None;
			if (flag)
			{
				throw new ArgumentException("Allocator must be Temp, TempJob or Persistent", "allocator");
			}
			bool flag2 = allocator >= Allocator.FirstUserIndex;
			if (flag2)
			{
				throw new ArgumentException("Use CollectionHelper.CreateNativeArray for custom allocator", "allocator");
			}
			bool flag3 = length < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001BC80 File Offset: 0x00019E80
		public static void IsUnmanagedAndThrow()
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsUnmanaged<T>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("{0} used in NativeArray<{1}> must be unmanaged (contain no managed types).", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003180 File Offset: 0x00001380
		public void CheckElementReadAccess(int index)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003183 File Offset: 0x00001383
		public void CheckElementWriteAccess(int index)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003186 File Offset: 0x00001386
		public unsafe void CopyFrom(NativeArray<T> array)
		{
			NativeArray<T>.Copy(array, *this);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003196 File Offset: 0x00001396
		public unsafe void CopyTo(NativeArray<T> array)
		{
			NativeArray<T>.Copy(*this, array);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		public static bool operator !=(NativeArray<T> left, NativeArray<T> right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000031A6 File Offset: 0x000013A6
		public static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, src.Length);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000031BA File Offset: 0x000013BA
		public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, src.Length);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000031CE File Offset: 0x000013CE
		public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, src.Length);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000031E2 File Offset: 0x000013E2
		public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000031F0 File Offset: 0x000013F0
		public static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000031FE File Offset: 0x000013FE
		public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000320C File Offset: 0x0000140C
		public static void Copy(NativeArray<T>.ReadOnly src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000321B File Offset: 0x0000141B
		public static void Copy(Il2CppArrayBase<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000322A File Offset: 0x0000142A
		public static void Copy(NativeArray<T>.ReadOnly src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00003239 File Offset: 0x00001439
		public unsafe static void CopySafe(NativeArray<T>.ReadOnly src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy((void*)((byte*)dst.m_Buffer + dstIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (void*)((byte*)src.m_Buffer + srcIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (long)(length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		public unsafe static void CopySafe(NativeArray<T>.ReadOnly src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			GCHandle gchandle = GCHandle.Alloc(dst, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy((void*)((byte*)(void*)intPtr + dstIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (void*)((byte*)src.m_Buffer + srcIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (long)(length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
			gchandle.Free();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001BD34 File Offset: 0x00019F34
		public static void CheckCopyPtr(Il2CppArrayBase<T> ptr)
		{
			bool flag = ptr == null;
			if (flag)
			{
				throw new ArgumentNullException("ptr");
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001BD58 File Offset: 0x00019F58
		public static void CheckCopyLengths(int srcLength, int dstLength)
		{
			bool flag = srcLength != dstLength;
			if (flag)
			{
				throw new ArgumentException("source and destination length must be the same");
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001BD7C File Offset: 0x00019F7C
		public static void CheckCopyArguments(int srcLength, int srcIndex, int dstLength, int dstIndex, int length)
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
			}
			bool flag2 = srcIndex < 0 || srcIndex > srcLength || (srcIndex == srcLength && srcLength > 0);
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source NativeArray.");
			}
			bool flag3 = dstIndex < 0 || dstIndex > dstLength || (dstIndex == dstLength && dstLength > 0);
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination NativeArray.");
			}
			bool flag4 = srcIndex + length > srcLength;
			if (flag4)
			{
				throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", "length");
			}
			bool flag5 = srcIndex + length < 0;
			if (flag5)
			{
				throw new ArgumentException("srcIndex + length causes an integer overflow");
			}
			bool flag6 = dstIndex + length > dstLength;
			if (flag6)
			{
				throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", "length");
			}
			bool flag7 = dstIndex + length < 0;
			if (flag7)
			{
				throw new ArgumentException("dstIndex + length causes an integer overflow");
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00003267 File Offset: 0x00001467
		public void CheckReinterpretLoadRange<U>(int sourceIndex) where U : struct
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000326A File Offset: 0x0000146A
		public void CheckReinterpretStoreRange<U>(int destIndex) where U : struct
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001BE60 File Offset: 0x0001A060
		public unsafe U ReinterpretLoad<U>(int sourceIndex) where U : struct
		{
			byte* ptr = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)sourceIndex;
			return Unity.Collections.LowLevel.Unsafe.UnsafeUtility.ReadArrayElement<U>((void*)ptr, 0);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001BE8C File Offset: 0x0001A08C
		public unsafe void ReinterpretStore<U>(int destIndex, U data) where U : struct
		{
			byte* ptr = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)destIndex;
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.WriteArrayElement<U>((void*)ptr, 0, data);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		public static void CheckReinterpretSize<U>() where U : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<U>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Types {0} and {1} are different sizes - direct reinterpretation is not possible. If this is what you intended, use Reinterpret(<type size>)", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001BF00 File Offset: 0x0001A100
		public void CheckReinterpretSize<U>(long tSize, long uSize, int expectedTypeSize, long byteLen, long uLen)
		{
			bool flag = tSize != (long)expectedTypeSize;
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Type {0} was expected to be {1} but is {2} bytes", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), expectedTypeSize, tSize));
			}
			bool flag2 = uLen * uSize != byteLen;
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("Types {0} (array length {1}) and {2} cannot be aliased due to size constraints. The size of the types and lengths involved must line up.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), this.Length, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001BF80 File Offset: 0x0001A180
		public void CheckGetSubArrayArguments(int start, int length)
		{
			bool flag = start < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("start", "start must be >= 0");
			}
			bool flag2 = start + length > this.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("length", String.Format("sub array range {0}-{1} is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
			bool flag3 = start + length < 0;
			if (flag3)
			{
				throw new ArgumentException(String.Format("sub array range {0}-{1} caused an integer overflow and is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001C024 File Offset: 0x0001A224
		public Span<T> AsSpan()
		{
			return new Span<T>(this.m_Buffer, this.m_Length);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001C048 File Offset: 0x0001A248
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			return new ReadOnlySpan<T>(this.m_Buffer, this.m_Length);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001C06C File Offset: 0x0001A26C
		public static implicit operator Span<T>([In] ref NativeArray<T> source)
		{
			return source.AsSpan();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001C084 File Offset: 0x0001A284
		public static implicit operator ReadOnlySpan<T>([In] ref NativeArray<T> source)
		{
			return source.AsReadOnlySpan();
		}

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0;

		// Token: 0x020003C1 RID: 961
		public sealed class Enumerator : ValueType
		{
			// Token: 0x0600305C RID: 12380 RVA: 0x000B6908 File Offset: 0x000B4B08
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr);
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Array");
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Index");
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "value");
				NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663463);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663464);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663465);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663466);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663467);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663468);
			}

			// Token: 0x0600305D RID: 12381 RVA: 0x000B6A24 File Offset: 0x000B4C24
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 643448, RefRangeEnd = 643451, XrefRangeStart = 643448, XrefRangeEnd = 643448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(ref NativeArray<T> array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600305E RID: 12382 RVA: 0x000B6A78 File Offset: 0x000B4C78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600305F RID: 12383 RVA: 0x000B6AB0 File Offset: 0x000B4CB0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003060 RID: 12384 RVA: 0x000B6AF4 File Offset: 0x000B4CF4
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x06003061 RID: 12385 RVA: 0x000B6B2C File Offset: 0x000B4D2C
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x06003062 RID: 12386 RVA: 0x000B6B6C File Offset: 0x000B4D6C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643451, XrefRangeEnd = 643454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003063 RID: 12387 RVA: 0x0001372E File Offset: 0x0001192E
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003064 RID: 12388 RVA: 0x00013737 File Offset: 0x00011937
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x06003065 RID: 12389 RVA: 0x000B6BB0 File Offset: 0x000B4DB0
			// (set) Token: 0x06003066 RID: 12390 RVA: 0x00013749 File Offset: 0x00011949
			public NativeArray<T> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06003067 RID: 12391 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
			// (set) Token: 0x06003068 RID: 12392 RVA: 0x00013777 File Offset: 0x00011977
			public unsafe int m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06003069 RID: 12393 RVA: 0x000B6C08 File Offset: 0x000B4E08
			// (set) Token: 0x0600306A RID: 12394 RVA: 0x000B6C30 File Offset: 0x000B4E30
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04002ADC RID: 10972
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04002ADD RID: 10973
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x04002ADE RID: 10974
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002ADF RID: 10975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0;

			// Token: 0x04002AE0 RID: 10976
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002AE1 RID: 10977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002AE2 RID: 10978
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002AE3 RID: 10979
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04002AE4 RID: 10980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003C2 RID: 962
		public sealed class ReadOnly : ValueType
		{
			// Token: 0x0600306B RID: 12395 RVA: 0x000B6CD8 File Offset: 0x000B4ED8
			// Note: this type is marked as 'beforefieldinit'.
			static ReadOnly()
			{
				Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "ReadOnly"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr);
				NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "m_Buffer");
				NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "m_Length");
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663469);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663470);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663471);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663472);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663473);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663474);
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x000B6DE0 File Offset: 0x000B4FE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 643457, RefRangeEnd = 643459, XrefRangeStart = 643457, XrefRangeEnd = 643457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnly(void* buffer, int length)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x0600306D RID: 12397 RVA: 0x000B6E3C File Offset: 0x000B503C
			public unsafe int Length
			{
				[CallerCount(27)]
				[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170009FE RID: 2558
			public unsafe T this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643459, XrefRangeEnd = 643460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}
			}

			// Token: 0x0600306F RID: 12399 RVA: 0x000B6ECC File Offset: 0x000B50CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643460, XrefRangeEnd = 643462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NativeArray<T>.ReadOnly.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<T>.ReadOnly.Enumerator(intPtr);
			}

			// Token: 0x06003070 RID: 12400 RVA: 0x000B6F08 File Offset: 0x000B5108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643462, XrefRangeEnd = 643466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06003071 RID: 12401 RVA: 0x000B6F4C File Offset: 0x000B514C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003072 RID: 12402 RVA: 0x00013792 File Offset: 0x00011992
			public ReadOnly(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003073 RID: 12403 RVA: 0x0001379B File Offset: 0x0001199B
			public ReadOnly()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
			{
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06003074 RID: 12404 RVA: 0x000B6F90 File Offset: 0x000B5190
			// (set) Token: 0x06003075 RID: 12405 RVA: 0x000137AD File Offset: 0x000119AD
			public unsafe void* m_Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer)) = value;
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x06003076 RID: 12406 RVA: 0x000B6FB4 File Offset: 0x000B51B4
			// (set) Token: 0x06003077 RID: 12407 RVA: 0x000137C8 File Offset: 0x000119C8
			public unsafe int m_Length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length)) = value;
				}
			}

			// Token: 0x04002AE5 RID: 10981
			private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

			// Token: 0x04002AE6 RID: 10982
			private static readonly IntPtr NativeFieldInfoPtr_m_Length;

			// Token: 0x04002AE7 RID: 10983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0;

			// Token: 0x04002AE8 RID: 10984
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

			// Token: 0x04002AE9 RID: 10985
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

			// Token: 0x04002AEA RID: 10986
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

			// Token: 0x04002AEB RID: 10987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04002AEC RID: 10988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000BDE RID: 3038
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060040AE RID: 16558 RVA: 0x000BF850 File Offset: 0x000BDA50
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr);
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "m_Array");
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "m_Index");
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "value");
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663475);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663476);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663477);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663478);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663479);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663480);
				}

				// Token: 0x060040AF RID: 16559 RVA: 0x000BF96C File Offset: 0x000BDB6C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 643448, RefRangeEnd = 643451, XrefRangeStart = 643448, XrefRangeEnd = 643451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator([In] ref NativeArray<T>.ReadOnly array)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060040B0 RID: 16560 RVA: 0x000BF9C0 File Offset: 0x000BDBC0
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060040B1 RID: 16561 RVA: 0x000BF9F8 File Offset: 0x000BDBF8
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060040B2 RID: 16562 RVA: 0x000BFA3C File Offset: 0x000BDC3C
				[CallerCount(0)]
				public unsafe void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000A44 RID: 2628
				// (get) Token: 0x060040B3 RID: 16563 RVA: 0x000BFA74 File Offset: 0x000BDC74
				public unsafe T Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}

				// Token: 0x17000A45 RID: 2629
				// (get) Token: 0x060040B4 RID: 16564 RVA: 0x000BFAB4 File Offset: 0x000BDCB4
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643454, XrefRangeEnd = 643457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060040B5 RID: 16565 RVA: 0x00016903 File Offset: 0x00014B03
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060040B6 RID: 16566 RVA: 0x0001690C File Offset: 0x00014B0C
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17000A41 RID: 2625
				// (get) Token: 0x060040B7 RID: 16567 RVA: 0x000BFAF8 File Offset: 0x000BDCF8
				// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0001691E File Offset: 0x00014B1E
				public NativeArray<T>.ReadOnly m_Array
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array);
						return new NativeArray<T>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000A42 RID: 2626
				// (get) Token: 0x060040B9 RID: 16569 RVA: 0x000BFB28 File Offset: 0x000BDD28
				// (set) Token: 0x060040BA RID: 16570 RVA: 0x0001694C File Offset: 0x00014B4C
				public unsafe int m_Index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
					}
				}

				// Token: 0x17000A43 RID: 2627
				// (get) Token: 0x060040BB RID: 16571 RVA: 0x000BFB50 File Offset: 0x000BDD50
				// (set) Token: 0x060040BC RID: 16572 RVA: 0x000BFB78 File Offset: 0x000BDD78
				public unsafe T value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value);
						Type typeFromHandle = typeof(T);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x04002DCA RID: 11722
				private static readonly IntPtr NativeFieldInfoPtr_m_Array;

				// Token: 0x04002DCB RID: 11723
				private static readonly IntPtr NativeFieldInfoPtr_m_Index;

				// Token: 0x04002DCC RID: 11724
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x04002DCD RID: 11725
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0;

				// Token: 0x04002DCE RID: 11726
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04002DCF RID: 11727
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04002DD0 RID: 11728
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

				// Token: 0x04002DD1 RID: 11729
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

				// Token: 0x04002DD2 RID: 11730
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020003C3 RID: 963
		private sealed class MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0
		{
			// Token: 0x04002AED RID: 10989
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C4 RID: 964
		private sealed class MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_0
		{
			// Token: 0x04002AEE RID: 10990
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C5 RID: 965
		private sealed class MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0
		{
			// Token: 0x04002AEF RID: 10991
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}
	}
}
