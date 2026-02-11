using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D3 RID: 211
	public sealed class X509ChainElementCollection : Object
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x00050B84 File Offset: 0x0004ED84
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElementCollection()
		{
			Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr);
			X509ChainElementCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, "_list");
			X509ChainElementCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665331);
			X509ChainElementCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665332);
			X509ChainElementCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665333);
			X509ChainElementCollection.NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665334);
			X509ChainElementCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665335);
			X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665336);
			X509ChainElementCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509ChainElementEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665337);
			X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665338);
			X509ChainElementCollection.NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665339);
			X509ChainElementCollection.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665340);
			X509ChainElementCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100665341);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00050CA4 File Offset: 0x0004EEA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 454576, RefRangeEnd = 454579, XrefRangeStart = 454570, XrefRangeEnd = 454576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		public unsafe int Count
		{
			[CallerCount(212)]
			[CachedScanResults(RefRangeStart = 390432, RefRangeEnd = 390644, XrefRangeStart = 390432, XrefRangeEnd = 390644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00050D1C File Offset: 0x0004EF1C
		public unsafe bool IsSynchronized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454579, XrefRangeEnd = 454580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000440 RID: 1088
		public unsafe X509ChainElement this[int index]
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 454582, RefRangeEnd = 454596, XrefRangeStart = 454580, XrefRangeEnd = 454582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElement>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00050DA4 File Offset: 0x0004EFA4
		public unsafe Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454596, XrefRangeEnd = 454597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00050DE4 File Offset: 0x0004EFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454598, RefRangeEnd = 454599, XrefRangeStart = 454597, XrefRangeEnd = 454598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00050E34 File Offset: 0x0004F034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454599, XrefRangeEnd = 454607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElementEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509ChainElementEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00050E74 File Offset: 0x0004F074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454607, XrefRangeEnd = 454615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00050EB4 File Offset: 0x0004F0B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 454624, RefRangeEnd = 454629, XrefRangeStart = 454615, XrefRangeEnd = 454624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454630, RefRangeEnd = 454632, XrefRangeStart = 454629, XrefRangeEnd = 454630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00050F2C File Offset: 0x0004F12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454635, RefRangeEnd = 454636, XrefRangeStart = 454632, XrefRangeEnd = 454635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000070F2 File Offset: 0x000052F2
		public X509ChainElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00050F7C File Offset: 0x0004F17C
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x000070FB File Offset: 0x000052FB
		public unsafe ArrayList _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509ChainElementEnumerator_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_X509Certificate2_0;
	}
}
