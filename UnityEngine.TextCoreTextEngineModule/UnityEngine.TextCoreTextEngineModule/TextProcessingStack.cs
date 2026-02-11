using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000036 RID: 54
	public sealed class TextProcessingStack<T> : ValueType
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00017C98 File Offset: 0x00015E98
		// Note: this type is marked as 'beforefieldinit'.
		static TextProcessingStack()
		{
			Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextProcessingStack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr);
			TextProcessingStack<T>.NativeFieldInfoPtr_itemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "itemStack");
			TextProcessingStack<T>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "index");
			TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "m_DefaultItem");
			TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "m_Capacity");
			TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "m_RolloverSize");
			TextProcessingStack<T>.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, "m_Count");
			TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663685);
			TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663686);
			TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663687);
			TextProcessingStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663688);
			TextProcessingStack<T>.NativeMethodInfoPtr_get_current_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663689);
			TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TextProcessingStack_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663690);
			TextProcessingStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663691);
			TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663692);
			TextProcessingStack<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663693);
			TextProcessingStack<T>.NativeMethodInfoPtr_Remove_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663694);
			TextProcessingStack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663695);
			TextProcessingStack<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663696);
			TextProcessingStack<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663697);
			TextProcessingStack<T>.NativeMethodInfoPtr_CurrentItem_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr, 100663698);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00017E94 File Offset: 0x00016094
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1049653, RefRangeEnd = 1049670, XrefRangeStart = 1049653, XrefRangeEnd = 1049670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextProcessingStack(Il2CppArrayBase<T> stack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00017EE4 File Offset: 0x000160E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1049674, RefRangeEnd = 1049679, XrefRangeStart = 1049674, XrefRangeEnd = 1049679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextProcessingStack(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00017F30 File Offset: 0x00016130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextProcessingStack(int capacity, int rolloverSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rolloverSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00017F8C File Offset: 0x0001618C
		public unsafe int Count
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00017FD0 File Offset: 0x000161D0
		public unsafe T current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_get_current_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00018010 File Offset: 0x00016210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105591, XrefRangeEnd = 1105597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefault(Il2CppReferenceArray<TextProcessingStack<T>> stack, T item)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TextProcessingStack_1_T_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00018090 File Offset: 0x00016290
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1049689, RefRangeEnd = 1049697, XrefRangeStart = 1049689, XrefRangeEnd = 1049697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000180C8 File Offset: 0x000162C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105601, RefRangeEnd = 1105604, XrefRangeStart = 1105597, XrefRangeEnd = 1105601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_SetDefault_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00018148 File Offset: 0x00016348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049707, RefRangeEnd = 1049708, XrefRangeStart = 1049707, XrefRangeEnd = 1049708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000181C8 File Offset: 0x000163C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105604, RefRangeEnd = 1105606, XrefRangeStart = 1105604, XrefRangeEnd = 1105604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Remove_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00018208 File Offset: 0x00016408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105606, XrefRangeEnd = 1105608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00018288 File Offset: 0x00016488
		[CallerCount(0)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000182C8 File Offset: 0x000164C8
		[CallerCount(0)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00018308 File Offset: 0x00016508
		[CallerCount(0)]
		public unsafe T CurrentItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextProcessingStack<T>.NativeMethodInfoPtr_CurrentItem_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000057EB File Offset: 0x000039EB
		public TextProcessingStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000057F4 File Offset: 0x000039F4
		public TextProcessingStack()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingStack<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00018348 File Offset: 0x00016548
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00005806 File Offset: 0x00003A06
		public unsafe Il2CppArrayBase<T> itemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_itemStack);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_itemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00018370 File Offset: 0x00016570
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00005825 File Offset: 0x00003A25
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00018398 File Offset: 0x00016598
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x000183C0 File Offset: 0x000165C0
		public unsafe T m_DefaultItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_DefaultItem);
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00018468 File Offset: 0x00016668
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00005840 File Offset: 0x00003A40
		public unsafe int m_Capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_Capacity)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00018490 File Offset: 0x00016690
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000585B File Offset: 0x00003A5B
		public unsafe int m_RolloverSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_RolloverSize)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000184B8 File Offset: 0x000166B8
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00005876 File Offset: 0x00003A76
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextProcessingStack<T>.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000184E0 File Offset: 0x000166E0
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00005891 File Offset: 0x00003A91
		public int rolloverSize
		{
			get
			{
				return this.m_RolloverSize;
			}
			set
			{
				this.m_RolloverSize = value;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000184F8 File Offset: 0x000166F8
		public T PreviousItem()
		{
			bool flag = this.index > 1;
			T t;
			if (flag)
			{
				t = this.itemStack[this.index - 2];
			}
			else
			{
				t = this.itemStack[0];
			}
			return t;
		}

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_itemStack;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultItem;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_m_Capacity;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_m_RolloverSize;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_get_T_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Internal_Static_Void_Il2CppReferenceArray_1_TextProcessingStack_1_T_T_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_T_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_T_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_T_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_CurrentItem_Public_T_0;

		// Token: 0x040004FA RID: 1274
		public const int k_DefaultCapacity = 4;
	}
}
