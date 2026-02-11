using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization
{
	// Token: 0x0200001B RID: 27
	public sealed class CallbackArray<TDelegate> : ValueType where TDelegate : Delegate
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000E64C File Offset: 0x0000C84C
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackArray()
		{
			Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "CallbackArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr);
			CallbackArray<TDelegate>.NativeFieldInfoPtr_k_AllocationIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "k_AllocationIncrement");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_SingleDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_SingleDelegate");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MultipleDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_MultipleDelegates");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_AddCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_AddCallbacks");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_RemoveCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_RemoveCallbacks");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_Length");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_CannotMutateCallbacksArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_CannotMutateCallbacksArray");
			CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MutatedDuringCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_MutatedDuringCallback");
			CallbackArray<TDelegate>.NativeMethodInfoPtr_get_SingleDelegate_Public_get_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663569);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_get_MultiDelegates_Public_get_Il2CppArrayBase_1_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663570);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663571);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_Add_Public_Void_TDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663572);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_RemoveByMovingTail_Public_Void_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663573);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_LockForChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663574);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_UnlockForChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663575);
			CallbackArray<TDelegate>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100663576);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public unsafe TDelegate SingleDelegate
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_get_SingleDelegate_Public_get_TDelegate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, false, true);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000E838 File Offset: 0x0000CA38
		public unsafe Il2CppArrayBase<TDelegate> MultiDelegates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_get_MultiDelegates_Public_get_Il2CppArrayBase_1_TDelegate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TDelegate>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000E874 File Offset: 0x0000CA74
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1066386, RefRangeEnd = 1066393, XrefRangeStart = 1066374, XrefRangeEnd = 1066386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TDelegate callback, int capacityIncrement = 5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDelegate).IsValueType)
				{
					TDelegate tdelegate = callback;
					intPtr = ((tdelegate is string) ? IL2CPP.ManagedStringToIl2Cpp(tdelegate as string) : IL2CPP.Il2CppObjectBaseToPtr(tdelegate as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref callback;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacityIncrement;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_Add_Public_Void_TDelegate_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000E944 File Offset: 0x0000CB44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1066399, RefRangeEnd = 1066406, XrefRangeStart = 1066393, XrefRangeEnd = 1066399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveByMovingTail(TDelegate callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDelegate).IsValueType)
				{
					TDelegate tdelegate = callback;
					intPtr = ((tdelegate is string) ? IL2CPP.ManagedStringToIl2Cpp(tdelegate as string) : IL2CPP.Il2CppObjectBaseToPtr(tdelegate as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref callback;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_RemoveByMovingTail_Public_Void_TDelegate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1066406, RefRangeEnd = 1066410, XrefRangeStart = 1066406, XrefRangeEnd = 1066406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockForChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_LockForChanges_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1066446, RefRangeEnd = 1066450, XrefRangeStart = 1066410, XrefRangeEnd = 1066446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockForChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_UnlockForChanges_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000EA34 File Offset: 0x0000CC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066451, RefRangeEnd = 1066453, XrefRangeStart = 1066450, XrefRangeEnd = 1066451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArray<TDelegate>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002910 File Offset: 0x00000B10
		public CallbackArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002919 File Offset: 0x00000B19
		public CallbackArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr))
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000292B File Offset: 0x00000B2B
		public unsafe static int k_AllocationIncrement
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CallbackArray<TDelegate>.NativeFieldInfoPtr_k_AllocationIncrement, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackArray<TDelegate>.NativeFieldInfoPtr_k_AllocationIncrement, (void*)(&value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000EA88 File Offset: 0x0000CC88
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		public unsafe TDelegate m_SingleDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_SingleDelegate);
				return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_SingleDelegate);
				Type typeFromHandle = typeof(TDelegate);
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000EB58 File Offset: 0x0000CD58
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002939 File Offset: 0x00000B39
		public unsafe Il2CppArrayBase<TDelegate> m_MultipleDelegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MultipleDelegates);
				return Il2CppArrayBase<TDelegate>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MultipleDelegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000EB80 File Offset: 0x0000CD80
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002958 File Offset: 0x00000B58
		public unsafe List<TDelegate> m_AddCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_AddCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TDelegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_AddCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002977 File Offset: 0x00000B77
		public unsafe List<TDelegate> m_RemoveCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_RemoveCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TDelegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_RemoveCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002996 File Offset: 0x00000B96
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000EC08 File Offset: 0x0000CE08
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000029B1 File Offset: 0x00000BB1
		public unsafe bool m_CannotMutateCallbacksArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_CannotMutateCallbacksArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_CannotMutateCallbacksArray)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000EC30 File Offset: 0x0000CE30
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000029CC File Offset: 0x00000BCC
		public unsafe bool m_MutatedDuringCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MutatedDuringCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArray<TDelegate>.NativeFieldInfoPtr_m_MutatedDuringCallback)) = value;
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_k_AllocationIncrement;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleDelegate;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleDelegates;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_AddCallbacks;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveCallbacks;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_CannotMutateCallbacksArray;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_MutatedDuringCallback;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_SingleDelegate_Public_get_TDelegate_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiDelegates_Public_get_Il2CppArrayBase_1_TDelegate_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TDelegate_Int32_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_RemoveByMovingTail_Public_Void_TDelegate_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_LockForChanges_Public_Void_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_UnlockForChanges_Public_Void_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
