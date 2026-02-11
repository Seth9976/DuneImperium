using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000043 RID: 67
	public class BidirectionalDictionary<TFirst, TSecond> : Object
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x000301F0 File Offset: 0x0002E3F0
		// Note: this type is marked as 'beforefieldinit'.
		static BidirectionalDictionary()
		{
			Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "BidirectionalDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr);
			BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__firstToSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, "_firstToSecond");
			BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__secondToFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, "_secondToFirst");
			BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateFirstErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, "_duplicateFirstErrorMessage");
			BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateSecondErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, "_duplicateSecondErrorMessage");
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664569);
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664570);
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664571);
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_Set_Public_Void_TFirst_TSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664572);
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_TryGetByFirst_Public_Boolean_TFirst_byref_TSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664573);
			BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_TryGetBySecond_Public_Boolean_TSecond_byref_TFirst_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr, 100664574);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00030338 File Offset: 0x0002E538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739271, XrefRangeEnd = 739288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00030374 File Offset: 0x0002E574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739288, XrefRangeEnd = 739301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstEqualityComparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondEqualityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000303D4 File Offset: 0x0002E5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739312, RefRangeEnd = 739313, XrefRangeStart = 739301, XrefRangeEnd = 739312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<TFirst, TSecond>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstEqualityComparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondEqualityComparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(duplicateFirstErrorMessage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(duplicateSecondErrorMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00030458 File Offset: 0x0002E658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739325, RefRangeEnd = 739327, XrefRangeStart = 739313, XrefRangeEnd = 739325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(TFirst first, TSecond second)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TFirst).IsValueType)
				{
					TFirst tfirst = first;
					intPtr = ((tfirst is string) ? IL2CPP.ManagedStringToIl2Cpp(tfirst as string) : IL2CPP.Il2CppObjectBaseToPtr(tfirst as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref first;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TSecond).IsValueType)
			{
				TSecond tsecond = second;
				intPtr2 = ((tsecond is string) ? IL2CPP.ManagedStringToIl2Cpp(tsecond as string) : IL2CPP.Il2CppObjectBaseToPtr(tsecond as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref second;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_Set_Public_Void_TFirst_TSecond_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00030518 File Offset: 0x0002E718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739329, RefRangeEnd = 739330, XrefRangeStart = 739327, XrefRangeEnd = 739329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetByFirst(TFirst first, out TSecond second)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TFirst).IsValueType)
				{
					TFirst tfirst = first;
					intPtr = ((tfirst is string) ? IL2CPP.ManagedStringToIl2Cpp(tfirst as string) : IL2CPP.Il2CppObjectBaseToPtr(tfirst as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref first;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TSecond).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref second;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_TryGetByFirst_Public_Boolean_TFirst_byref_TSecond_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TSecond).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				second = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TSecond>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000305EC File Offset: 0x0002E7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739332, RefRangeEnd = 739334, XrefRangeStart = 739330, XrefRangeEnd = 739332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetBySecond(TSecond second, out TFirst first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TSecond).IsValueType)
				{
					TSecond tsecond = second;
					intPtr = ((tsecond is string) ? IL2CPP.ManagedStringToIl2Cpp(tsecond as string) : IL2CPP.Il2CppObjectBaseToPtr(tsecond as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref second;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TFirst).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref first;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<TFirst, TSecond>.NativeMethodInfoPtr_TryGetBySecond_Public_Boolean_TSecond_byref_TFirst_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TFirst).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				first = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TFirst>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00003E87 File Offset: 0x00002087
		public BidirectionalDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000306C0 File Offset: 0x0002E8C0
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00003E90 File Offset: 0x00002090
		public unsafe IDictionary<TFirst, TSecond> _firstToSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__firstToSecond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<TFirst, TSecond>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__firstToSecond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000306F0 File Offset: 0x0002E8F0
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00003EAF File Offset: 0x000020AF
		public unsafe IDictionary<TSecond, TFirst> _secondToFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__secondToFirst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<TSecond, TFirst>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__secondToFirst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00030720 File Offset: 0x0002E920
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00003ECE File Offset: 0x000020CE
		public unsafe string _duplicateFirstErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateFirstErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateFirstErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00030748 File Offset: 0x0002E948
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00003EED File Offset: 0x000020ED
		public unsafe string _duplicateSecondErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateSecondErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<TFirst, TSecond>.NativeFieldInfoPtr__duplicateSecondErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__firstToSecond;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr__secondToFirst;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr__duplicateFirstErrorMessage;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr__duplicateSecondErrorMessage;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TFirst_IEqualityComparer_1_TSecond_String_String_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_TFirst_TSecond_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_TryGetByFirst_Public_Boolean_TFirst_byref_TSecond_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBySecond_Public_Boolean_TSecond_byref_TFirst_0;
	}
}
