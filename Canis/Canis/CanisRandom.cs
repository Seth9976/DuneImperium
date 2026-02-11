using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis
{
	// Token: 0x02000022 RID: 34
	public class CanisRandom : Random
	{
		// Token: 0x0600013A RID: 314 RVA: 0x0001DE84 File Offset: 0x0001C084
		// Note: this type is marked as 'beforefieldinit'.
		static CanisRandom()
		{
			Il2CppClassPointerStore<CanisRandom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "CanisRandom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr);
			CanisRandom.NativeFieldInfoPtr_NotSoRandomValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, "NotSoRandomValues");
			CanisRandom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663503);
			CanisRandom.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663504);
			CanisRandom.NativeMethodInfoPtr_Next_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663505);
			CanisRandom.NativeMethodInfoPtr_Next_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663506);
			CanisRandom.NativeMethodInfoPtr_NextGuid_Public_Virtual_New_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663507);
			CanisRandom.NativeMethodInfoPtr_Push_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663508);
			CanisRandom.NativeMethodInfoPtr_Element_Public_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663509);
			CanisRandom.NativeMethodInfoPtr_Elements_Public_IEnumerable_1_T_Int32_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663510);
			CanisRandom.NativeMethodInfoPtr_WeightedElement_Public_T_IReadOnlyList_1_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663511);
			CanisRandom.NativeMethodInfoPtr_WeightedElementStruct_Public_Nullable_1_T_IReadOnlyList_1_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663512);
			CanisRandom.NativeMethodInfoPtr_NormalDeviation_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663513);
			CanisRandom.NativeMethodInfoPtr_NormalValue_Public_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, 100663514);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 544481, RefRangeEnd = 544482, XrefRangeStart = 544470, XrefRangeEnd = 544481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisRandom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 544493, RefRangeEnd = 544494, XrefRangeStart = 544482, XrefRangeEnd = 544493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisRandom(int seed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001E03C File Offset: 0x0001C23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544494, XrefRangeEnd = 544495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisRandom.NativeMethodInfoPtr_Next_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001E084 File Offset: 0x0001C284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544495, XrefRangeEnd = 544496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Next(int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisRandom.NativeMethodInfoPtr_Next_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544496, XrefRangeEnd = 544509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Guid NextGuid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisRandom.NativeMethodInfoPtr_NextGuid_Public_Virtual_New_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001E120 File Offset: 0x0001C320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544509, XrefRangeEnd = 544513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.NativeMethodInfoPtr_Push_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001E160 File Offset: 0x0001C360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544513, XrefRangeEnd = 544516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Element<T>(IReadOnlyList<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.MethodInfoStoreGeneric_Element_Public_T_IReadOnlyList_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 544522, RefRangeEnd = 544523, XrefRangeStart = 544516, XrefRangeEnd = 544522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Elements<T>(int numToTake, IReadOnlyList<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numToTake;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.MethodInfoStoreGeneric_Elements_Public_IEnumerable_1_T_Int32_IReadOnlyList_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001E20C File Offset: 0x0001C40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544523, XrefRangeEnd = 544549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T WeightedElement<T>(IReadOnlyList<ValueTuple<T, double>> collection) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.MethodInfoStoreGeneric_WeightedElement_Public_T_IReadOnlyList_1_ValueTuple_2_T_Double_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001E258 File Offset: 0x0001C458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544549, XrefRangeEnd = 544595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<T> WeightedElementStruct<T>(IReadOnlyList<ValueTuple<T, double>> collection) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.MethodInfoStoreGeneric_WeightedElementStruct_Public_Nullable_1_T_IReadOnlyList_1_ValueTuple_2_T_Double_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<T>(intPtr);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544595, XrefRangeEnd = 544600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double NormalDeviation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.NativeMethodInfoPtr_NormalDeviation_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544600, XrefRangeEnd = 544605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double NormalValue(double mean, double stdDeviation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mean;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stdDeviation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.NativeMethodInfoPtr_NormalValue_Public_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000298B File Offset: 0x00000B8B
		public CanisRandom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0001E334 File Offset: 0x0001C534
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002994 File Offset: 0x00000B94
		public unsafe Stack<int> NotSoRandomValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom.NativeFieldInfoPtr_NotSoRandomValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom.NativeFieldInfoPtr_NotSoRandomValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_NotSoRandomValues;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_Int32_Int32_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_NextGuid_Public_Virtual_New_Guid_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Element_Public_T_IReadOnlyList_1_T_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Elements_Public_IEnumerable_1_T_Int32_IReadOnlyList_1_T_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_WeightedElement_Public_T_IReadOnlyList_1_ValueTuple_2_T_Double_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_WeightedElementStruct_Public_Nullable_1_T_IReadOnlyList_1_ValueTuple_2_T_Double_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_NormalDeviation_Public_Double_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_NormalValue_Public_Double_Double_Double_0;

		// Token: 0x0200024E RID: 590
		[ObfuscatedName("Canis.CanisRandom+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : Object where T : new()
		{
			// Token: 0x060018B0 RID: 6320 RVA: 0x0007B604 File Offset: 0x00079804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr);
				CanisRandom.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr, "<>9");
				CanisRandom.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				CanisRandom.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr, 100663516);
				CanisRandom.__c__10<T>.NativeMethodInfoPtr__WeightedElementStruct_b__10_0_Internal_Double_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr, 100663517);
			}

			// Token: 0x060018B1 RID: 6321 RVA: 0x0007B6BC File Offset: 0x000798BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisRandom.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018B2 RID: 6322 RVA: 0x0007B6F8 File Offset: 0x000798F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544387, XrefRangeEnd = 544390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _WeightedElementStruct_b__10_0(ValueTuple<T, double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.__c__10<T>.NativeMethodInfoPtr__WeightedElementStruct_b__10_0_Internal_Double_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018B3 RID: 6323 RVA: 0x0000BCB8 File Offset: 0x00009EB8
			public __c__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0007B74C File Offset: 0x0007994C
			// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000BCC1 File Offset: 0x00009EC1
			public unsafe static CanisRandom.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisRandom.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisRandom.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisRandom.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0007B774 File Offset: 0x00079974
			// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000BCD3 File Offset: 0x00009ED3
			public unsafe static Func<ValueTuple<T, double>, double> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisRandom.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisRandom.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FCC RID: 4044
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FCD RID: 4045
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04000FCE RID: 4046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FCF RID: 4047
			private static readonly IntPtr NativeMethodInfoPtr__WeightedElementStruct_b__10_0_Internal_Double_ValueTuple_2_T_Double_0;
		}

		// Token: 0x0200024F RID: 591
		[ObfuscatedName("Canis.CanisRandom+<>c__9`1")]
		[Serializable]
		public sealed class __c__9<T> : Object where T : class
		{
			// Token: 0x060018B8 RID: 6328 RVA: 0x0007B79C File Offset: 0x0007999C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__9()
			{
				Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, "<>c__9`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr);
				CanisRandom.__c__9<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr, "<>9");
				CanisRandom.__c__9<T>.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr, "<>9__9_0");
				CanisRandom.__c__9<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr, 100663519);
				CanisRandom.__c__9<T>.NativeMethodInfoPtr__WeightedElement_b__9_0_Internal_Double_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr, 100663520);
			}

			// Token: 0x060018B9 RID: 6329 RVA: 0x0007B854 File Offset: 0x00079A54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__9()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisRandom.__c__9<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.__c__9<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018BA RID: 6330 RVA: 0x0007B890 File Offset: 0x00079A90
			[CallerCount(0)]
			public unsafe double _WeightedElement_b__9_0(ValueTuple<T, double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom.__c__9<T>.NativeMethodInfoPtr__WeightedElement_b__9_0_Internal_Double_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018BB RID: 6331 RVA: 0x0000BCE5 File Offset: 0x00009EE5
			public __c__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x060018BC RID: 6332 RVA: 0x0007B8E4 File Offset: 0x00079AE4
			// (set) Token: 0x060018BD RID: 6333 RVA: 0x0000BCEE File Offset: 0x00009EEE
			public unsafe static CanisRandom.__c__9<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisRandom.__c__9<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisRandom.__c__9<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisRandom.__c__9<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x060018BE RID: 6334 RVA: 0x0007B90C File Offset: 0x00079B0C
			// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000BD00 File Offset: 0x00009F00
			public unsafe static Func<ValueTuple<T, double>, double> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisRandom.__c__9<T>.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisRandom.__c__9<T>.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FD0 RID: 4048
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FD1 RID: 4049
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04000FD2 RID: 4050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FD3 RID: 4051
			private static readonly IntPtr NativeMethodInfoPtr__WeightedElement_b__9_0_Internal_Double_ValueTuple_2_T_Double_0;
		}

		// Token: 0x02000250 RID: 592
		[ObfuscatedName("Canis.CanisRandom+<Elements>d__8`1")]
		public sealed class _Elements_d__8<T> : Object
		{
			// Token: 0x060018C0 RID: 6336 RVA: 0x0007B934 File Offset: 0x00079B34
			// Note: this type is marked as 'beforefieldinit'.
			static _Elements_d__8()
			{
				Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisRandom>.NativeClassPtr, "<Elements>d__8`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr);
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>1__state");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>2__current");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>l__initialThreadId");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "collection");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>3__collection");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>4__this");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_numToTake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "numToTake");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__numToTake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>3__numToTake");
				CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, "<>7__wrap1");
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663521);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663522);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663523);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663524);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663525);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663526);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663527);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663528);
				CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr, 100663529);
			}

			// Token: 0x060018C1 RID: 6337 RVA: 0x0007BB04 File Offset: 0x00079D04
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Elements_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisRandom._Elements_d__8<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018C2 RID: 6338 RVA: 0x0007BB4C File Offset: 0x00079D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544390, XrefRangeEnd = 544395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018C3 RID: 6339 RVA: 0x0007BB80 File Offset: 0x00079D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544395, XrefRangeEnd = 544444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018C4 RID: 6340 RVA: 0x0007BBBC File Offset: 0x00079DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544444, XrefRangeEnd = 544454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0007BBF0 File Offset: 0x00079DF0
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060018C6 RID: 6342 RVA: 0x0007BC2C File Offset: 0x00079E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0007BC60 File Offset: 0x00079E60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018C8 RID: 6344 RVA: 0x0007BCA0 File Offset: 0x00079EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544454, XrefRangeEnd = 544462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060018C9 RID: 6345 RVA: 0x0007BCE0 File Offset: 0x00079EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544462, XrefRangeEnd = 544470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisRandom._Elements_d__8<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060018CA RID: 6346 RVA: 0x0000BD12 File Offset: 0x00009F12
			public _Elements_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x060018CB RID: 6347 RVA: 0x0007BD20 File Offset: 0x00079F20
			// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000BD1B File Offset: 0x00009F1B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x060018CD RID: 6349 RVA: 0x0007BD48 File Offset: 0x00079F48
			// (set) Token: 0x060018CE RID: 6350 RVA: 0x0007BD70 File Offset: 0x00079F70
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___2__current);
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

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x060018CF RID: 6351 RVA: 0x0007BE18 File Offset: 0x0007A018
			// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000BD36 File Offset: 0x00009F36
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0007BE40 File Offset: 0x0007A040
			// (set) Token: 0x060018D2 RID: 6354 RVA: 0x0000BD51 File Offset: 0x00009F51
			public unsafe IReadOnlyList<T> collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0007BE70 File Offset: 0x0007A070
			// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0000BD70 File Offset: 0x00009F70
			public unsafe IReadOnlyList<T> __3__collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0007BEA0 File Offset: 0x0007A0A0
			// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0000BD8F File Offset: 0x00009F8F
			public unsafe CanisRandom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisRandom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0007BED0 File Offset: 0x0007A0D0
			// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0000BDAE File Offset: 0x00009FAE
			public unsafe int numToTake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_numToTake);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr_numToTake)) = value;
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0007BEF8 File Offset: 0x0007A0F8
			// (set) Token: 0x060018DA RID: 6362 RVA: 0x0000BDC9 File Offset: 0x00009FC9
			public unsafe int __3__numToTake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__numToTake);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___3__numToTake)) = value;
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x060018DB RID: 6363 RVA: 0x0007BF20 File Offset: 0x0007A120
			// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000BDE4 File Offset: 0x00009FE4
			public List<int>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___7__wrap1);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisRandom._Elements_d__8<T>.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000FD4 RID: 4052
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FD5 RID: 4053
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FD6 RID: 4054
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000FD7 RID: 4055
			private static readonly IntPtr NativeFieldInfoPtr_collection;

			// Token: 0x04000FD8 RID: 4056
			private static readonly IntPtr NativeFieldInfoPtr___3__collection;

			// Token: 0x04000FD9 RID: 4057
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FDA RID: 4058
			private static readonly IntPtr NativeFieldInfoPtr_numToTake;

			// Token: 0x04000FDB RID: 4059
			private static readonly IntPtr NativeFieldInfoPtr___3__numToTake;

			// Token: 0x04000FDC RID: 4060
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000FDD RID: 4061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FDE RID: 4062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FDF RID: 4063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FE0 RID: 4064
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000FE1 RID: 4065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04000FE2 RID: 4066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FE3 RID: 4067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FE4 RID: 4068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000FE5 RID: 4069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000251 RID: 593
		private sealed class MethodInfoStoreGeneric_Element_Public_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x04000FE6 RID: 4070
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisRandom.NativeMethodInfoPtr_Element_Public_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<CanisRandom>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000252 RID: 594
		private sealed class MethodInfoStoreGeneric_Elements_Public_IEnumerable_1_T_Int32_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x04000FE7 RID: 4071
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisRandom.NativeMethodInfoPtr_Elements_Public_IEnumerable_1_T_Int32_IReadOnlyList_1_T_0, Il2CppClassPointerStore<CanisRandom>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000253 RID: 595
		private sealed class MethodInfoStoreGeneric_WeightedElement_Public_T_IReadOnlyList_1_ValueTuple_2_T_Double_0<T>
		{
			// Token: 0x04000FE8 RID: 4072
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisRandom.NativeMethodInfoPtr_WeightedElement_Public_T_IReadOnlyList_1_ValueTuple_2_T_Double_0, Il2CppClassPointerStore<CanisRandom>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000254 RID: 596
		private sealed class MethodInfoStoreGeneric_WeightedElementStruct_Public_Nullable_1_T_IReadOnlyList_1_ValueTuple_2_T_Double_0<T>
		{
			// Token: 0x04000FE9 RID: 4073
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisRandom.NativeMethodInfoPtr_WeightedElementStruct_Public_Nullable_1_T_IReadOnlyList_1_ValueTuple_2_T_Double_0, Il2CppClassPointerStore<CanisRandom>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
