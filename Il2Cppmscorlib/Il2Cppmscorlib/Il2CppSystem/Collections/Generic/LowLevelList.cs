using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FC RID: 1276
	public class LowLevelList<T> : Object
	{
		// Token: 0x06004EAD RID: 20141 RVA: 0x0016D408 File Offset: 0x0016B608
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelList()
		{
			Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "LowLevelList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr);
			LowLevelList<T>.NativeFieldInfoPtr__defaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, "_defaultCapacity");
			LowLevelList<T>.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, "_items");
			LowLevelList<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, "_size");
			LowLevelList<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, "_version");
			LowLevelList<T>.NativeFieldInfoPtr_s_emptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, "s_emptyArray");
			LowLevelList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675139);
			LowLevelList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675140);
			LowLevelList<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675141);
			LowLevelList<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675142);
			LowLevelList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675143);
			LowLevelList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675144);
			LowLevelList<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675145);
			LowLevelList<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675146);
			LowLevelList<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675147);
			LowLevelList<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675148);
			LowLevelList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675149);
			LowLevelList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675150);
			LowLevelList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675151);
			LowLevelList<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675152);
			LowLevelList<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675153);
			LowLevelList<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675154);
			LowLevelList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675155);
			LowLevelList<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675156);
			LowLevelList<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr, 100675157);
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0016D654 File Offset: 0x0016B854
		[CallerCount(3294)]
		[CachedScanResults(RefRangeStart = 1420741, RefRangeEnd = 1424035, XrefRangeStart = 1420741, XrefRangeEnd = 1424035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x0016D690 File Offset: 0x0016B890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425758, XrefRangeEnd = 1425771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x0016D6D8 File Offset: 0x0016B8D8
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x0016D714 File Offset: 0x0016B914
		public unsafe int Capacity
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425771, XrefRangeEnd = 1425775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x0016D754 File Offset: 0x0016B954
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001449 RID: 5193
		public unsafe virtual T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1425775, RefRangeEnd = 1425776, XrefRangeStart = 1425775, XrefRangeEnd = 1425775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1425777, RefRangeEnd = 1425778, XrefRangeStart = 1425776, XrefRangeEnd = 1425777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x0016D860 File Offset: 0x0016BA60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1425780, RefRangeEnd = 1425788, XrefRangeStart = 1425778, XrefRangeEnd = 1425780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x0016D8D8 File Offset: 0x0016BAD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1425793, RefRangeEnd = 1425797, XrefRangeStart = 1425788, XrefRangeEnd = 1425793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0016D918 File Offset: 0x0016BB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425798, RefRangeEnd = 1425799, XrefRangeStart = 1425797, XrefRangeEnd = 1425798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x0016D95C File Offset: 0x0016BB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x0016D990 File Offset: 0x0016BB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425799, XrefRangeEnd = 1425800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x0016DA14 File Offset: 0x0016BC14
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1027787, RefRangeEnd = 1027799, XrefRangeStart = 1027787, XrefRangeEnd = 1027799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0016DA64 File Offset: 0x0016BC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425801, RefRangeEnd = 1425802, XrefRangeStart = 1425800, XrefRangeEnd = 1425801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x0016DAE8 File Offset: 0x0016BCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425805, RefRangeEnd = 1425806, XrefRangeStart = 1425802, XrefRangeEnd = 1425805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Insert(int index, T item)
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
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x0016DB70 File Offset: 0x0016BD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425838, RefRangeEnd = 1425839, XrefRangeStart = 1425806, XrefRangeEnd = 1425838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRange(int index, IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x0016DBC0 File Offset: 0x0016BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425839, XrefRangeEnd = 1425840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x0016DC44 File Offset: 0x0016BE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1425840, RefRangeEnd = 1425842, XrefRangeStart = 1425840, XrefRangeEnd = 1425840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveAll(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x0016DC94 File Offset: 0x0016BE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425842, XrefRangeEnd = 1425844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelList<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x0001C67B File Offset: 0x0001A87B
		public LowLevelList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x0016DCD4 File Offset: 0x0016BED4
		// (set) Token: 0x06004EC3 RID: 20163 RVA: 0x0001C684 File Offset: 0x0001A884
		public unsafe static int _defaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LowLevelList<T>.NativeFieldInfoPtr__defaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowLevelList<T>.NativeFieldInfoPtr__defaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x0016DCF0 File Offset: 0x0016BEF0
		// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x0001C692 File Offset: 0x0001A892
		public unsafe Il2CppArrayBase<T> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__items);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x0016DD18 File Offset: 0x0016BF18
		// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x0001C6B1 File Offset: 0x0001A8B1
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x0016DD40 File Offset: 0x0016BF40
		// (set) Token: 0x06004EC9 RID: 20169 RVA: 0x0001C6CC File Offset: 0x0001A8CC
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelList<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x0016DD68 File Offset: 0x0016BF68
		// (set) Token: 0x06004ECB RID: 20171 RVA: 0x0001C6E7 File Offset: 0x0001A8E7
		public unsafe static Il2CppArrayBase<T> s_emptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LowLevelList<T>.NativeFieldInfoPtr_s_emptyArray, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowLevelList<T>.NativeFieldInfoPtr_s_emptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400403B RID: 16443
		private static readonly IntPtr NativeFieldInfoPtr__defaultCapacity;

		// Token: 0x0400403C RID: 16444
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x0400403D RID: 16445
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400403E RID: 16446
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400403F RID: 16447
		private static readonly IntPtr NativeFieldInfoPtr_s_emptyArray;

		// Token: 0x04004040 RID: 16448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004041 RID: 16449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004042 RID: 16450
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04004043 RID: 16451
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0;

		// Token: 0x04004044 RID: 16452
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04004045 RID: 16453
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04004046 RID: 16454
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04004047 RID: 16455
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04004048 RID: 16456
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x04004049 RID: 16457
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0;

		// Token: 0x0400404A RID: 16458
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400404B RID: 16459
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400404D RID: 16461
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x0400404E RID: 16462
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x0400404F RID: 16463
		private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0;

		// Token: 0x04004050 RID: 16464
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04004051 RID: 16465
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0;

		// Token: 0x04004052 RID: 16466
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;
	}
}
