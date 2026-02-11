using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200006E RID: 110
	public sealed class TMP_TextProcessingStack<T> : ValueType
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x000387F8 File Offset: 0x000369F8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextProcessingStack()
		{
			Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextProcessingStack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr);
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_itemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "itemStack");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "index");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "m_DefaultItem");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "m_Capacity");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "m_RolloverSize");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "m_Count");
			TMP_TextProcessingStack<T>.NativeFieldInfoPtr_k_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, "k_DefaultCapacity");
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664840);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664841);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664842);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664843);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_current_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664844);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_rolloverSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664845);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_set_rolloverSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664846);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TMP_TextProcessingStack_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664847);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664848);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664849);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664850);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Remove_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664851);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664852);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664853);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664854);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_CurrentItem_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664855);
			TMP_TextProcessingStack<T>.NativeMethodInfoPtr_PreviousItem_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr, 100664856);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00038A44 File Offset: 0x00036C44
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1049653, RefRangeEnd = 1049670, XrefRangeStart = 1049652, XrefRangeEnd = 1049653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextProcessingStack(Il2CppArrayBase<T> stack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00038A94 File Offset: 0x00036C94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1049674, RefRangeEnd = 1049679, XrefRangeStart = 1049670, XrefRangeEnd = 1049674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextProcessingStack(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00038AE0 File Offset: 0x00036CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049679, XrefRangeEnd = 1049683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextProcessingStack(int capacity, int rolloverSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rolloverSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00038B3C File Offset: 0x00036D3C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00038B80 File Offset: 0x00036D80
		public unsafe T current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_current_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00038BC0 File Offset: 0x00036DC0
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00038C04 File Offset: 0x00036E04
		public unsafe int rolloverSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_get_rolloverSize_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_set_rolloverSize_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00038C48 File Offset: 0x00036E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049683, XrefRangeEnd = 1049689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefault(Il2CppReferenceArray<TMP_TextProcessingStack<T>> stack, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TMP_TextProcessingStack_1_T_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00038CC8 File Offset: 0x00036EC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1049689, RefRangeEnd = 1049697, XrefRangeStart = 1049689, XrefRangeEnd = 1049689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00038D00 File Offset: 0x00036F00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1049701, RefRangeEnd = 1049707, XrefRangeStart = 1049697, XrefRangeEnd = 1049701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00038D80 File Offset: 0x00036F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049707, RefRangeEnd = 1049708, XrefRangeStart = 1049707, XrefRangeEnd = 1049707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00038E00 File Offset: 0x00037000
		[CallerCount(0)]
		public unsafe T Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Remove_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00038E40 File Offset: 0x00037040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049708, XrefRangeEnd = 1049710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00038EC0 File Offset: 0x000370C0
		[CallerCount(0)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00038F00 File Offset: 0x00037100
		[CallerCount(0)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00038F40 File Offset: 0x00037140
		[CallerCount(0)]
		public unsafe T CurrentItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_CurrentItem_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00038F80 File Offset: 0x00037180
		[CallerCount(0)]
		public unsafe T PreviousItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextProcessingStack<T>.NativeMethodInfoPtr_PreviousItem_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000089D1 File Offset: 0x00006BD1
		public TMP_TextProcessingStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000089DA File Offset: 0x00006BDA
		public TMP_TextProcessingStack()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextProcessingStack<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00038FC0 File Offset: 0x000371C0
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000089EC File Offset: 0x00006BEC
		public unsafe Il2CppArrayBase<T> itemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_itemStack);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_itemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00038FE8 File Offset: 0x000371E8
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00008A0B File Offset: 0x00006C0B
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00039010 File Offset: 0x00037210
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00039038 File Offset: 0x00037238
		public unsafe T m_DefaultItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem);
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

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000390E0 File Offset: 0x000372E0
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00008A26 File Offset: 0x00006C26
		public unsafe int m_Capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity)) = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00039108 File Offset: 0x00037308
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00008A41 File Offset: 0x00006C41
		public unsafe int m_RolloverSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize)) = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00039130 File Offset: 0x00037330
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00008A5C File Offset: 0x00006C5C
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00039158 File Offset: 0x00037358
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00008A77 File Offset: 0x00006C77
		public unsafe static int k_DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_k_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextProcessingStack<T>.NativeFieldInfoPtr_k_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_itemStack;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultItem;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_m_Capacity;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_m_RolloverSize;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultCapacity;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_get_T_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_rolloverSize_Public_get_Int32_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_set_rolloverSize_Public_set_Void_Int32_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TMP_TextProcessingStack_1_T_T_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_T_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_T_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_T_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_CurrentItem_Public_T_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_PreviousItem_Public_T_0;
	}
}
