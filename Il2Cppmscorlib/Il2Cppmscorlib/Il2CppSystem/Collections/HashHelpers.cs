using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004B9 RID: 1209
	public static class HashHelpers : Object
	{
		// Token: 0x06004A49 RID: 19017 RVA: 0x00157780 File Offset: 0x00155980
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_primes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "primes");
			HashHelpers.NativeFieldInfoPtr_s_serializationInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "s_serializationInfoTable");
			HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100674093);
			HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100674094);
			HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100674095);
			HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100674096);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00157828 File Offset: 0x00155A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414841, XrefRangeEnd = 1414842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrime(int candidate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref candidate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00157868 File Offset: 0x00155A68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1414857, RefRangeEnd = 1414863, XrefRangeStart = 1414842, XrefRangeEnd = 1414857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrime(int min)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x001578A8 File Offset: 0x00155AA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1414864, RefRangeEnd = 1414869, XrefRangeStart = 1414863, XrefRangeEnd = 1414864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExpandPrime(int oldSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06004A4D RID: 19021 RVA: 0x001578E8 File Offset: 0x00155AE8
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1414885, RefRangeEnd = 1414888, XrefRangeStart = 1414869, XrefRangeEnd = 1414885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x0001B43A File Offset: 0x0001963A
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x0015791C File Offset: 0x00155B1C
		// (set) Token: 0x06004A50 RID: 19024 RVA: 0x0001B443 File Offset: 0x00019643
		public unsafe static Il2CppStructArray<int> primes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_primes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_primes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x00157944 File Offset: 0x00155B44
		// (set) Token: 0x06004A52 RID: 19026 RVA: 0x0001B455 File Offset: 0x00019655
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_s_serializationInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_s_serializationInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeFieldInfoPtr_primes;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeFieldInfoPtr_s_serializationInfoTable;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;
	}
}
