using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	// Token: 0x02000042 RID: 66
	public sealed class NativeSlice<T> : ValueType where T : new()
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0001C440 File Offset: 0x0001A640
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSlice()
		{
			Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSlice`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr);
			NativeSlice<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, "m_Buffer");
			NativeSlice<T>.NativeFieldInfoPtr_m_Stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, "m_Stride");
			NativeSlice<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, "m_Length");
			NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663486);
			NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663487);
			NativeSlice<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663488);
			NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663489);
			NativeSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663490);
			NativeSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663491);
			NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663492);
			NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663493);
			NativeSlice<T>.NativeMethodInfoPtr_get_Stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663494);
			NativeSlice<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663495);
			NativeSlice<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663496);
			NativeSlice<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663497);
			NativeSlice<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663498);
			NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663499);
			NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663500);
			NativeSlice<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663501);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001C628 File Offset: 0x0001A828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643799, RefRangeEnd = 643800, XrefRangeStart = 643799, XrefRangeEnd = 643799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSlice(NativeSlice<T> slice, int start, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(slice));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001C69C File Offset: 0x0001A89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643800, XrefRangeEnd = 643802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSlice(NativeArray<T> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643802, XrefRangeEnd = 643805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator NativeSlice<T>(NativeArray<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeSlice<T>(intPtr);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001C738 File Offset: 0x0001A938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643806, RefRangeEnd = 643807, XrefRangeStart = 643805, XrefRangeEnd = 643806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSlice(NativeArray<T> array, int start, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000085 RID: 133
		public unsafe T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 643808, RefRangeEnd = 643809, XrefRangeStart = 643807, XrefRangeEnd = 643808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643809, XrefRangeEnd = 643810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001C884 File Offset: 0x0001AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643810, XrefRangeEnd = 643818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(NativeSlice<T> slice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(slice));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643818, XrefRangeEnd = 643827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001C918 File Offset: 0x0001AB18
		public unsafe int Stride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Stride_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0001C95C File Offset: 0x0001AB5C
		public unsafe int Length
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001C9A0 File Offset: 0x0001ABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643912, XrefRangeEnd = 643914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSlice<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeSlice<T>.Enumerator(intPtr);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001C9DC File Offset: 0x0001ABDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643914, XrefRangeEnd = 643918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001CA20 File Offset: 0x0001AC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643918, XrefRangeEnd = 643923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001CA64 File Offset: 0x0001AC64
		[CallerCount(0)]
		public unsafe bool Equals(NativeSlice<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001CABC File Offset: 0x0001ACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643923, XrefRangeEnd = 643930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001CB10 File Offset: 0x0001AD10
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000032C6 File Offset: 0x000014C6
		public NativeSlice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000032CF File Offset: 0x000014CF
		public NativeSlice()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0001CB54 File Offset: 0x0001AD54
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000032E1 File Offset: 0x000014E1
		public unsafe byte* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001CB78 File Offset: 0x0001AD78
		// (set) Token: 0x06000261 RID: 609 RVA: 0x000032FC File Offset: 0x000014FC
		public unsafe int m_Stride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Stride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Stride)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00003317 File Offset: 0x00001517
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
		public NativeSlice<U> SliceConvert<U>() where U : struct
		{
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<U>();
			NativeSlice<U> nativeSlice;
			nativeSlice.m_Buffer = this.m_Buffer;
			nativeSlice.m_Stride = num;
			nativeSlice.m_Length = this.m_Length * this.m_Stride / num;
			return nativeSlice;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001CC0C File Offset: 0x0001AE0C
		public NativeSlice<U> SliceWithStride<U>(int offset) where U : struct
		{
			NativeSlice<U> nativeSlice;
			nativeSlice.m_Buffer = this.m_Buffer + offset;
			nativeSlice.m_Stride = this.m_Stride;
			nativeSlice.m_Length = this.m_Length;
			return nativeSlice;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001CC48 File Offset: 0x0001AE48
		public NativeSlice<U> SliceWithStride<U>() where U : struct
		{
			return this.SliceWithStride<U>(0);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003332 File Offset: 0x00001532
		public void CheckReadIndex(int index)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00003335 File Offset: 0x00001535
		public void CheckWriteIndex(int index)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001CC64 File Offset: 0x0001AE64
		public unsafe void CopyTo(NativeArray<T> array)
		{
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpyStride(array.GetUnsafePtr<T>(), num, (*this).GetUnsafeReadOnlyPtr<T>(), this.Stride, num, this.m_Length);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001CCA0 File Offset: 0x0001AEA0
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpyStride((void*)intPtr, num, (*this).GetUnsafeReadOnlyPtr<T>(), this.Stride, num, this.m_Length);
			gchandle.Free();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		public Il2CppArrayBase<T> ToArray()
		{
			Il2CppArrayBase<T> il2CppArrayBase = new Il2CppReferenceArray<T>((long)this.Length);
			this.CopyTo(il2CppArrayBase);
			return il2CppArrayBase;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001CD1C File Offset: 0x0001AF1C
		public static bool operator ==(NativeSlice<T> left, NativeSlice<T> right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001CD38 File Offset: 0x0001AF38
		public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_m_Stride;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_Stride_Public_get_Int32_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020003C8 RID: 968
		public sealed class Enumerator : ValueType
		{
			// Token: 0x0600307D RID: 12413 RVA: 0x000B7180 File Offset: 0x000B5380
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr);
				NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, "m_Array");
				NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, "m_Index");
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663502);
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663503);
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663504);
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663505);
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663506);
				NativeSlice<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663507);
			}

			// Token: 0x0600307E RID: 12414 RVA: 0x000B7288 File Offset: 0x000B5488
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 643788, RefRangeEnd = 643791, XrefRangeStart = 643788, XrefRangeEnd = 643788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(ref NativeSlice<T> array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600307F RID: 12415 RVA: 0x000B72DC File Offset: 0x000B54DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003080 RID: 12416 RVA: 0x000B7314 File Offset: 0x000B5514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643791, XrefRangeEnd = 643793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003081 RID: 12417 RVA: 0x000B7358 File Offset: 0x000B5558
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x06003082 RID: 12418 RVA: 0x000B7390 File Offset: 0x000B5590
			public unsafe T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643793, XrefRangeEnd = 643795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x06003083 RID: 12419 RVA: 0x000B73D0 File Offset: 0x000B55D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643795, XrefRangeEnd = 643799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x000137E3 File Offset: 0x000119E3
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003085 RID: 12421 RVA: 0x000137EC File Offset: 0x000119EC
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06003086 RID: 12422 RVA: 0x000B7414 File Offset: 0x000B5614
			// (set) Token: 0x06003087 RID: 12423 RVA: 0x000137FE File Offset: 0x000119FE
			public NativeSlice<T> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array);
					return new NativeSlice<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x06003088 RID: 12424 RVA: 0x000B7444 File Offset: 0x000B5644
			// (set) Token: 0x06003089 RID: 12425 RVA: 0x0001382C File Offset: 0x00011A2C
			public unsafe int m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			// Token: 0x04002AF2 RID: 10994
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04002AF3 RID: 10995
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x04002AF4 RID: 10996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0;

			// Token: 0x04002AF5 RID: 10997
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002AF6 RID: 10998
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002AF7 RID: 10999
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002AF8 RID: 11000
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04002AF9 RID: 11001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
