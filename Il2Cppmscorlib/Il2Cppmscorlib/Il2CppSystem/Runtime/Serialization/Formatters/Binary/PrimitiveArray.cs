using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000376 RID: 886
	public sealed class PrimitiveArray : Object
	{
		// Token: 0x06003741 RID: 14145 RVA: 0x0010EC30 File Offset: 0x0010CE30
		// Note: this type is marked as 'beforefieldinit'.
		static PrimitiveArray()
		{
			Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "PrimitiveArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr);
			PrimitiveArray.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "code");
			PrimitiveArray.NativeFieldInfoPtr_booleanA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "booleanA");
			PrimitiveArray.NativeFieldInfoPtr_charA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "charA");
			PrimitiveArray.NativeFieldInfoPtr_doubleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "doubleA");
			PrimitiveArray.NativeFieldInfoPtr_int16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int16A");
			PrimitiveArray.NativeFieldInfoPtr_int32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int32A");
			PrimitiveArray.NativeFieldInfoPtr_int64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int64A");
			PrimitiveArray.NativeFieldInfoPtr_sbyteA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "sbyteA");
			PrimitiveArray.NativeFieldInfoPtr_singleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "singleA");
			PrimitiveArray.NativeFieldInfoPtr_uint16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint16A");
			PrimitiveArray.NativeFieldInfoPtr_uint32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint32A");
			PrimitiveArray.NativeFieldInfoPtr_uint64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint64A");
			PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100671592);
			PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100671593);
			PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100671594);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0010ED8C File Offset: 0x0010CF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391177, RefRangeEnd = 1391178, XrefRangeStart = 1391175, XrefRangeEnd = 1391177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimitiveArray(InternalPrimitiveTypeE code, Array array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x0010EDE8 File Offset: 0x0010CFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391195, RefRangeEnd = 1391196, XrefRangeStart = 1391178, XrefRangeEnd = 1391195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(InternalPrimitiveTypeE code, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0010EE38 File Offset: 0x0010D038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391203, RefRangeEnd = 1391204, XrefRangeStart = 1391196, XrefRangeEnd = 1391203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0001427F File Offset: 0x0001247F
		public PrimitiveArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x0010EE88 File Offset: 0x0010D088
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x00014288 File Offset: 0x00012488
		public unsafe InternalPrimitiveTypeE code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code)) = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x0010EEB0 File Offset: 0x0010D0B0
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x000142A3 File Offset: 0x000124A3
		public unsafe Il2CppStructArray<bool> booleanA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0010EEE0 File Offset: 0x0010D0E0
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x000142C2 File Offset: 0x000124C2
		public unsafe Il2CppStructArray<char> charA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0010EF10 File Offset: 0x0010D110
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x000142E1 File Offset: 0x000124E1
		public unsafe Il2CppStructArray<double> doubleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0010EF40 File Offset: 0x0010D140
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x00014300 File Offset: 0x00012500
		public unsafe Il2CppStructArray<short> int16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x0010EF70 File Offset: 0x0010D170
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x0001431F File Offset: 0x0001251F
		public unsafe Il2CppStructArray<int> int32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0010EFA0 File Offset: 0x0010D1A0
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x0001433E File Offset: 0x0001253E
		public unsafe Il2CppStructArray<long> int64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x0010EFD0 File Offset: 0x0010D1D0
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x0001435D File Offset: 0x0001255D
		public unsafe Il2CppStructArray<sbyte> sbyteA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x0010F000 File Offset: 0x0010D200
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x0001437C File Offset: 0x0001257C
		public unsafe Il2CppStructArray<float> singleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0010F030 File Offset: 0x0010D230
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x0001439B File Offset: 0x0001259B
		public unsafe Il2CppStructArray<ushort> uint16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x0010F060 File Offset: 0x0010D260
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x000143BA File Offset: 0x000125BA
		public unsafe Il2CppStructArray<uint> uint32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0010F090 File Offset: 0x0010D290
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x000143D9 File Offset: 0x000125D9
		public unsafe Il2CppStructArray<ulong> uint64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeFieldInfoPtr_booleanA;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeFieldInfoPtr_charA;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeFieldInfoPtr_doubleA;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeFieldInfoPtr_int16A;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeFieldInfoPtr_int32A;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeFieldInfoPtr_int64A;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeFieldInfoPtr_sbyteA;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeFieldInfoPtr_singleA;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeFieldInfoPtr_uint16A;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeFieldInfoPtr_uint32A;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeFieldInfoPtr_uint64A;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0;
	}
}
