using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	[StructLayout(2)]
	public struct Hash128
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x0005E158 File Offset: 0x0005C358
		// Note: this type is marked as 'beforefieldinit'.
		static Hash128()
		{
			Il2CppClassPointerStore<Hash128>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Hash128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128>.NativeClassPtr);
			Hash128.NativeFieldInfoPtr_u64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_0");
			Hash128.NativeFieldInfoPtr_u64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_1");
			Hash128.NativeFieldInfoPtr_kConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "kConst");
			Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665942);
			Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665943);
			Hash128.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665944);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665945);
			Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665946);
			Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665947);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665948);
			Hash128.NativeMethodInfoPtr_ComputeFromString_Private_Static_Void_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665949);
			Hash128.NativeMethodInfoPtr_Compute_Public_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665950);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665951);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665952);
			Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665953);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665954);
			Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665955);
			Hash128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665956);
			Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665957);
			Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665958);
			Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665959);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665960);
			Hash128.ComputeFromPtrDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromPtrDelegate>("UnityEngine.Hash128::ComputeFromPtr");
			Hash128.ComputeFromArrayDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromArrayDelegate>("UnityEngine.Hash128::ComputeFromArray");
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0005E360 File Offset: 0x0005C560
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 657819, RefRangeEnd = 657827, XrefRangeStart = 657819, XrefRangeEnd = 657819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u32_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005E3BC File Offset: 0x0005C5BC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128(ulong u64_0, ulong u64_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u64_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u64_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		public unsafe bool isValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657827, RefRangeEnd = 657828, XrefRangeStart = 657827, XrefRangeEnd = 657827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0005E42C File Offset: 0x0005C62C
		[CallerCount(0)]
		public unsafe int CompareTo(Hash128 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0005E46C File Offset: 0x0005C66C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 657830, RefRangeEnd = 657836, XrefRangeStart = 657828, XrefRangeEnd = 657830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0005E498 File Offset: 0x0005C698
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 657838, RefRangeEnd = 657847, XrefRangeStart = 657836, XrefRangeEnd = 657838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hash128 Parse(string hashString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hashString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0005E4DC File Offset: 0x0005C6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657847, XrefRangeEnd = 657849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl(Hash128 hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0005E514 File Offset: 0x0005C714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657849, XrefRangeEnd = 657851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeFromString(string data, ref Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ComputeFromString_Private_Static_Void_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005E558 File Offset: 0x0005C758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657853, RefRangeEnd = 657854, XrefRangeStart = 657851, XrefRangeEnd = 657853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hash128 Compute(string data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Compute_Public_Static_Hash128_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0005E59C File Offset: 0x0005C79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657854, XrefRangeEnd = 657857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0005E5E0 File Offset: 0x0005C7E0
		[CallerCount(0)]
		public unsafe bool Equals(Hash128 obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0005E620 File Offset: 0x0005C820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657857, XrefRangeEnd = 657859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0005E650 File Offset: 0x0005C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657859, XrefRangeEnd = 657862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0005E694 File Offset: 0x0005C894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657862, RefRangeEnd = 657864, XrefRangeStart = 657862, XrefRangeEnd = 657862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Hash128 hash1, Hash128 hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657864, RefRangeEnd = 657865, XrefRangeStart = 657864, XrefRangeEnd = 657864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Hash128 hash1, Hash128 hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005E72C File Offset: 0x0005C92C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 657865, RefRangeEnd = 657868, XrefRangeStart = 657865, XrefRangeEnd = 657865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Hash128 x, Hash128 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005E778 File Offset: 0x0005C978
		[CallerCount(0)]
		public unsafe static bool operator >(Hash128 x, Hash128 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005E7C4 File Offset: 0x0005C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657868, XrefRangeEnd = 657870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Parse_Injected(string hashString, out Hash128 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hashString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0005E808 File Offset: 0x0005CA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657870, XrefRangeEnd = 657872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl_Injected(ref Hash128 hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00007DAD File Offset: 0x00005FAD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hash128>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x0005E840 File Offset: 0x0005CA40
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x00007DBF File Offset: 0x00005FBF
		public unsafe static ulong kConst
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(Hash128.NativeFieldInfoPtr_kConst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hash128.NativeFieldInfoPtr_kConst, (void*)(&value));
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00007DCD File Offset: 0x00005FCD
		public static void ComputeFromPtr(IntPtr data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromPtrDelegateField(data, start, count, elemSize, ref hash);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00007DDF File Offset: 0x00005FDF
		public static void ComputeFromArray(Array data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), start, count, elemSize, ref hash);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0005E85C File Offset: 0x0005CA5C
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0005E898 File Offset: 0x0005CA98
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0005E904 File Offset: 0x0005CB04
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0005E958 File Offset: 0x0005CB58
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		public static Hash128 Compute<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005EA48 File Offset: 0x0005CC48
		public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005EAE0 File Offset: 0x0005CCE0
		public unsafe static Hash128 Compute<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* ptr2 = (void*)ptr;
				Hash128 hash = default(Hash128);
				Hash128.ComputeFromPtr((IntPtr)ptr2, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
				return hash;
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005EB18 File Offset: 0x0005CD18
		public static Hash128 Compute(int val)
		{
			Hash128 hash = default(Hash128);
			hash.Append(val);
			return hash;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005EB3C File Offset: 0x0005CD3C
		public static Hash128 Compute(float val)
		{
			Hash128 hash = default(Hash128);
			hash.Append(val);
			return hash;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005EB60 File Offset: 0x0005CD60
		public unsafe static Hash128 Compute(void* data, ulong size)
		{
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref hash);
			return hash;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00007DF6 File Offset: 0x00005FF6
		public void Append(string data)
		{
			Hash128.ComputeFromString(data, ref this);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00007E01 File Offset: 0x00006001
		public void Append<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0005EB90 File Offset: 0x0005CD90
		public void Append<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0005EBF0 File Offset: 0x0005CDF0
		public void Append<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0005EC38 File Offset: 0x0005CE38
		public void Append<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005ECB0 File Offset: 0x0005CEB0
		public void Append<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005ED08 File Offset: 0x0005CF08
		public void Append<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005ED90 File Offset: 0x0005CF90
		public unsafe void Append<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* ptr2 = (void*)ptr;
				Hash128.ComputeFromPtr((IntPtr)ptr2, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00007E23 File Offset: 0x00006023
		public void Append(int val)
		{
			this.ShortHash4((uint)val);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00007E2E File Offset: 0x0000602E
		public unsafe void Append(float val)
		{
			this.ShortHash4(*(uint*)(&val));
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00007E3C File Offset: 0x0000603C
		public unsafe void Append(void* data, ulong size)
		{
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref this);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005EDBC File Offset: 0x0005CFBC
		public void ShortHash4(uint data)
		{
			ulong num = this.u64_0;
			ulong num2 = this.u64_1;
			ulong num3 = 16045690984833335023UL;
			ulong num4 = 16045690984833335023UL;
			num4 += 288230376151711744UL;
			num3 += (ulong)data;
			Hash128.ShortEnd(ref num, ref num2, ref num3, ref num4);
			this.u64_0 = num;
			this.u64_1 = num2;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005EE1C File Offset: 0x0005D01C
		public static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			h3 ^= h2;
			Hash128.Rot64(ref h2, 15);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 52);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 26);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 51);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 28);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 9);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 47);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 54);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 32);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 25);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 63);
			h1 += h0;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00007E50 File Offset: 0x00006050
		public static void Rot64(ref ulong x, int k)
		{
			x = (x << k) | (x >> 64 - k);
		}

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_u64_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr_u64_1;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_kConst;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFromString_Private_Static_Void_String_byref_Hash128_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Static_Hash128_String_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0;

		// Token: 0x040010B7 RID: 4279
		[FieldOffset(0)]
		public ulong u64_0;

		// Token: 0x040010B8 RID: 4280
		[FieldOffset(8)]
		public ulong u64_1;

		// Token: 0x040010B9 RID: 4281
		private static readonly Hash128.ComputeFromPtrDelegate ComputeFromPtrDelegateField;

		// Token: 0x040010BA RID: 4282
		private static readonly Hash128.ComputeFromArrayDelegate ComputeFromArrayDelegateField;

		// Token: 0x020006DA RID: 1754
		// (Invoke) Token: 0x06003692 RID: 13970
		private delegate void ComputeFromPtrDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);

		// Token: 0x020006DB RID: 1755
		// (Invoke) Token: 0x06003694 RID: 13972
		private delegate void ComputeFromArrayDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);
	}
}
