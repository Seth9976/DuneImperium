using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Utils.enums
{
	// Token: 0x0200003D RID: 61
	public sealed class EnumData<T> : Object where T : new()
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0000EB74 File Offset: 0x0000CD74
		// Note: this type is marked as 'beforefieldinit'.
		static EnumData()
		{
			Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "Utils.enums", "EnumData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr);
			EnumData<T>.NativeFieldInfoPtr_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, "Comparer");
			EnumData<T>.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, "Length");
			EnumData<T>.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, "Names");
			EnumData<T>.NativeFieldInfoPtr_IntValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, "IntValues");
			EnumData<T>.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, "Values");
			EnumData<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663889);
			EnumData<T>.NativeMethodInfoPtr_TryParse_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663890);
			EnumData<T>.NativeMethodInfoPtr_FromInt_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663891);
			EnumData<T>.NativeMethodInfoPtr_IntValue_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663892);
			EnumData<T>.NativeMethodInfoPtr_GetName_Public_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663893);
			EnumData<T>.NativeMethodInfoPtr_GetName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr, 100663894);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184546, RefRangeEnd = 1184547, XrefRangeStart = 1184478, XrefRangeEnd = 1184546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumData<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1184551, RefRangeEnd = 1184553, XrefRangeStart = 1184547, XrefRangeEnd = 1184551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryParse(string name, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr_TryParse_Public_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000ED94 File Offset: 0x0000CF94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1184556, RefRangeEnd = 1184558, XrefRangeStart = 1184553, XrefRangeEnd = 1184556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FromInt(int intValue, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intValue;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr_FromInt_Public_Boolean_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000EE2C File Offset: 0x0000D02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184584, RefRangeEnd = 1184585, XrefRangeStart = 1184558, XrefRangeEnd = 1184584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IntValue(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr_IntValue_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184605, RefRangeEnd = 1184606, XrefRangeStart = 1184585, XrefRangeEnd = 1184605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr_GetName_Public_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000EF30 File Offset: 0x0000D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184606, XrefRangeEnd = 1184657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName(int intValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumData<T>.NativeMethodInfoPtr_GetName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002B13 File Offset: 0x00000D13
		public EnumData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000EF74 File Offset: 0x0000D174
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002B1C File Offset: 0x00000D1C
		public unsafe EqualityComparer<T> Comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002B3B File Offset: 0x00000D3B
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002B56 File Offset: 0x00000D56
		public unsafe ReadOnlyCollection<string> Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002B75 File Offset: 0x00000D75
		public unsafe ReadOnlyCollection<int> IntValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_IntValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_IntValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000F02C File Offset: 0x0000D22C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe ReadOnlyCollection<T> Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData<T>.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_Comparer;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_Names;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_IntValues;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_Values;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Boolean_String_byref_T_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_FromInt_Public_Boolean_Int32_byref_T_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_IntValue_Public_Int32_T_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_T_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_Int32_0;
	}
}
