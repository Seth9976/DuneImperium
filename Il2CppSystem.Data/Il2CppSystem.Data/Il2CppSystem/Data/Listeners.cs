using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Data
{
	// Token: 0x02000077 RID: 119
	public sealed class Listeners<TElem> : Object where TElem : class
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x00038DAC File Offset: 0x00036FAC
		// Note: this type is marked as 'beforefieldinit'.
		static Listeners()
		{
			Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Listeners`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElem>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr);
			Listeners<TElem>.NativeFieldInfoPtr__listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "_listeners");
			Listeners<TElem>.NativeFieldInfoPtr__filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "_filter");
			Listeners<TElem>.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "_objectID");
			Listeners<TElem>.NativeFieldInfoPtr__listenerReaderCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "_listenerReaderCount");
			Listeners<TElem>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Func_2_TElem_TElem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665134);
			Listeners<TElem>.NativeMethodInfoPtr_get_HasListeners_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665135);
			Listeners<TElem>.NativeMethodInfoPtr_Add_Internal_Void_TElem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665136);
			Listeners<TElem>.NativeMethodInfoPtr_IndexOfReference_Internal_Int32_TElem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665137);
			Listeners<TElem>.NativeMethodInfoPtr_Remove_Internal_Void_TElem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665138);
			Listeners<TElem>.NativeMethodInfoPtr_Notify_Internal_Void_T1_T2_T3_Action_4_TElem_TElem_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665139);
			Listeners<TElem>.NativeMethodInfoPtr_RemoveNullListeners_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, 100665140);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00038EF4 File Offset: 0x000370F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907378, RefRangeEnd = 907379, XrefRangeStart = 907372, XrefRangeEnd = 907378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Listeners(int ObjectID, Listeners<TElem>.Func<TElem, bool> notifyFilter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ObjectID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notifyFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Func_2_TElem_TElem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00038F50 File Offset: 0x00037150
		public unsafe bool HasListeners
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 510862, RefRangeEnd = 510872, XrefRangeStart = 510862, XrefRangeEnd = 510872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr_get_HasListeners_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00038F8C File Offset: 0x0003718C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907383, RefRangeEnd = 907384, XrefRangeStart = 907379, XrefRangeEnd = 907383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TElem listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElem).IsValueType)
				{
					TElem telem = listener;
					intPtr = ((telem is string) ? IL2CPP.ManagedStringToIl2Cpp(telem as string) : IL2CPP.Il2CppObjectBaseToPtr(telem as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref listener;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr_Add_Internal_Void_TElem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00039004 File Offset: 0x00037204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907384, XrefRangeEnd = 907385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfReference(TElem listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElem).IsValueType)
				{
					TElem telem = listener;
					intPtr = ((telem is string) ? IL2CPP.ManagedStringToIl2Cpp(telem as string) : IL2CPP.Il2CppObjectBaseToPtr(telem as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref listener;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr_IndexOfReference_Internal_Int32_TElem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00039088 File Offset: 0x00037288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907389, RefRangeEnd = 907390, XrefRangeStart = 907385, XrefRangeEnd = 907389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(TElem listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElem).IsValueType)
				{
					TElem telem = listener;
					intPtr = ((telem is string) ? IL2CPP.ManagedStringToIl2Cpp(telem as string) : IL2CPP.Il2CppObjectBaseToPtr(telem as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref listener;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr_Remove_Internal_Void_TElem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00039100 File Offset: 0x00037300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907397, RefRangeEnd = 907398, XrefRangeStart = 907390, XrefRangeEnd = 907397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners<TElem>.Action<TElem, T1, T2, T3> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = arg1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Listeners<T1>.MethodInfoStoreGeneric_Notify_Internal_Void_T1_T2_T3_Action_4_TElem_TElem_T1_T2_T3_0<T2, T3>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003921C File Offset: 0x0003741C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907400, RefRangeEnd = 907401, XrefRangeStart = 907398, XrefRangeEnd = 907400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullListeners(int nullIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.NativeMethodInfoPtr_RemoveNullListeners_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00005523 File Offset: 0x00003723
		public Listeners(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0003925C File Offset: 0x0003745C
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0000552C File Offset: 0x0000372C
		public unsafe List<TElem> _listeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__listeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TElem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__listeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003928C File Offset: 0x0003748C
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000554B File Offset: 0x0000374B
		public unsafe Listeners<TElem>.Func<TElem, bool> _filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listeners<TElem>.Func<TElem, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000392BC File Offset: 0x000374BC
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0000556A File Offset: 0x0000376A
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000392E4 File Offset: 0x000374E4
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005585 File Offset: 0x00003785
		public unsafe int _listenerReaderCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__listenerReaderCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listeners<TElem>.NativeFieldInfoPtr__listenerReaderCount)) = value;
			}
		}

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr__listeners;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr__filter;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr__listenerReaderCount;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Func_2_TElem_TElem_Boolean_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_get_HasListeners_Internal_get_Boolean_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_TElem_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfReference_Internal_Int32_TElem_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_TElem_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_Notify_Internal_Void_T1_T2_T3_Action_4_TElem_TElem_T1_T2_T3_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullListeners_Private_Void_Int32_0;

		// Token: 0x020000EC RID: 236
		public sealed class Action<T1, T2, T3, T4> : MulticastDelegate
		{
			// Token: 0x06001507 RID: 5383 RVA: 0x00063BDC File Offset: 0x00061DDC
			// Note: this type is marked as 'beforefieldinit'.
			static Action()
			{
				Il2CppClassPointerStore<Listeners<TElem>.Action<T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "Action`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElem>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
				})).TypeHandle.value);
				Listeners<TElem>.Action<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>.Action<T1, T2, T3, T4>>.NativeClassPtr, 100665141);
				Listeners<TElem>.Action<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>.Action<T1, T2, T3, T4>>.NativeClassPtr, 100665142);
			}

			// Token: 0x06001508 RID: 5384 RVA: 0x00063CA8 File Offset: 0x00061EA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 907218, RefRangeEnd = 907219, XrefRangeStart = 907209, XrefRangeEnd = 907218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listeners<TElem>.Action<T1, T2, T3, T4>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.Action<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001509 RID: 5385 RVA: 0x00063D04 File Offset: 0x00061F04
			[CallerCount(0)]
			public unsafe void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = arg1;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref arg1;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T2).IsValueType)
				{
					T2 t2 = arg2;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref arg2;
				}
				ptr3 = intPtr2;
				ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3;
				if (!typeof(T3).IsValueType)
				{
					T3 t3 = arg3;
					intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
				}
				else
				{
					intPtr3 = ref arg3;
				}
				ptr4 = intPtr3;
				ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr4;
				if (!typeof(T4).IsValueType)
				{
					T4 t4 = arg4;
					intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
				}
				else
				{
					intPtr4 = ref arg4;
				}
				ptr5 = intPtr4;
				IntPtr intPtr6;
				IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.Action<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
				Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			}

			// Token: 0x0600150A RID: 5386 RVA: 0x00007F8C File Offset: 0x0000618C
			public Action(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600150B RID: 5387 RVA: 0x00007F95 File Offset: 0x00006195
			public static implicit operator Listeners<TElem>.Action<T1, T2, T3, T4>(global::System.Action<T1, T2, T3, T4> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listeners<TElem>.Action<T1, T2, T3, T4>>(A_0);
			}

			// Token: 0x0600150C RID: 5388 RVA: 0x00007F9D File Offset: 0x0000619D
			public static Listeners<TElem>.Action<T1, T2, T3, T4>operator +(Listeners<TElem>.Action<T1, T2, T3, T4> A_0, Listeners<TElem>.Action<T1, T2, T3, T4> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Listeners<TElem>.Action<T1, T2, T3, T4>>();
			}

			// Token: 0x0600150D RID: 5389 RVA: 0x00007FAB File Offset: 0x000061AB
			public static Listeners<TElem>.Action<T1, T2, T3, T4>operator -(Listeners<TElem>.Action<T1, T2, T3, T4> A_0, Listeners<TElem>.Action<T1, T2, T3, T4> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Listeners<TElem>.Action<T1, T2, T3, T4>>();
				}
				return delegate2;
			}

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0;
		}

		// Token: 0x020000ED RID: 237
		public sealed class Func<T1, TResult> : MulticastDelegate
		{
			// Token: 0x0600150E RID: 5390 RVA: 0x00063E58 File Offset: 0x00062058
			// Note: this type is marked as 'beforefieldinit'.
			static Func()
			{
				Il2CppClassPointerStore<Listeners<TElem>.Func<T1, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listeners<TElem>>.NativeClassPtr, "Func`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElem>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				Listeners<TElem>.Func<T1, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>.Func<T1, TResult>>.NativeClassPtr, 100665143);
				Listeners<TElem>.Func<T1, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listeners<TElem>.Func<T1, TResult>>.NativeClassPtr, 100665144);
			}

			// Token: 0x0600150F RID: 5391 RVA: 0x00063F00 File Offset: 0x00062100
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 907228, RefRangeEnd = 907372, XrefRangeStart = 907219, XrefRangeEnd = 907228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Func(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listeners<TElem>.Func<T1, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.Func<T1, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001510 RID: 5392 RVA: 0x00063F5C File Offset: 0x0006215C
			[CallerCount(0)]
			public unsafe TResult Invoke(T1 arg1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = arg1;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref arg1;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Listeners<TElem>.Func<T1, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
				}
			}

			// Token: 0x06001511 RID: 5393 RVA: 0x00007FBC File Offset: 0x000061BC
			public Func(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001512 RID: 5394 RVA: 0x00007FC5 File Offset: 0x000061C5
			public static implicit operator Listeners<TElem>.Func<T1, TResult>(global::System.Func<T1, TResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listeners<TElem>.Func<T1, TResult>>(A_0);
			}

			// Token: 0x06001513 RID: 5395 RVA: 0x00007FCD File Offset: 0x000061CD
			public static Listeners<TElem>.Func<T1, TResult>operator +(Listeners<TElem>.Func<T1, TResult> A_0, Listeners<TElem>.Func<T1, TResult> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Listeners<TElem>.Func<T1, TResult>>();
			}

			// Token: 0x06001514 RID: 5396 RVA: 0x00007FDB File Offset: 0x000061DB
			public static Listeners<TElem>.Func<T1, TResult>operator -(Listeners<TElem>.Func<T1, TResult> A_0, Listeners<TElem>.Func<T1, TResult> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Listeners<TElem>.Func<T1, TResult>>();
				}
				return delegate2;
			}

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0;
		}

		// Token: 0x020000EE RID: 238
		private sealed class MethodInfoStoreGeneric_Notify_Internal_Void_T1_T2_T3_Action_4_TElem_TElem_T1_T2_T3_0<T2, T3>
		{
			// Token: 0x0400117E RID: 4478
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Listeners<T1>.NativeMethodInfoPtr_Notify_Internal_Void_T1_T2_T3_Action_4_TElem_TElem_T1_T2_T3_0, Il2CppClassPointerStore<Listeners<T1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}
	}
}
