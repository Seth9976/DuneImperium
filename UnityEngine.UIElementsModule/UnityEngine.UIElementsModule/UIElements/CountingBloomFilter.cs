using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000099 RID: 153
	[StructLayout(2)]
	public struct CountingBloomFilter
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x00052EC4 File Offset: 0x000510C4
		// Note: this type is marked as 'beforefieldinit'.
		static CountingBloomFilter()
		{
			Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CountingBloomFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr);
			CountingBloomFilter.NativeFieldInfoPtr_m_Counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, "m_Counters");
			CountingBloomFilter.NativeMethodInfoPtr_AdjustSlot_Private_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665470);
			CountingBloomFilter.NativeMethodInfoPtr_Hash1_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665471);
			CountingBloomFilter.NativeMethodInfoPtr_Hash2_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665472);
			CountingBloomFilter.NativeMethodInfoPtr_IsSlotEmpty_Private_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665473);
			CountingBloomFilter.NativeMethodInfoPtr_InsertHash_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665474);
			CountingBloomFilter.NativeMethodInfoPtr_RemoveHash_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665475);
			CountingBloomFilter.NativeMethodInfoPtr_ContainsHash_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, 100665476);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00052F94 File Offset: 0x00051194
		[CallerCount(0)]
		public unsafe void AdjustSlot(uint index, bool increment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref increment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_AdjustSlot_Private_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00052FD4 File Offset: 0x000511D4
		[CallerCount(0)]
		public unsafe uint Hash1(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_Hash1_Private_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00053014 File Offset: 0x00051214
		[CallerCount(0)]
		public unsafe uint Hash2(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_Hash2_Private_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00053054 File Offset: 0x00051254
		[CallerCount(0)]
		public unsafe bool IsSlotEmpty(uint index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_IsSlotEmpty_Private_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00053094 File Offset: 0x00051294
		[CallerCount(0)]
		public unsafe void InsertHash(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_InsertHash_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000530C8 File Offset: 0x000512C8
		[CallerCount(0)]
		public unsafe void RemoveHash(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_RemoveHash_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000530FC File Offset: 0x000512FC
		[CallerCount(0)]
		public unsafe bool ContainsHash(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountingBloomFilter.NativeMethodInfoPtr_ContainsHash_Public_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00007CB3 File Offset: 0x00005EB3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_m_Counters;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_AdjustSlot_Private_Void_UInt32_Boolean_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_Hash1_Private_UInt32_UInt32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_Hash2_Private_UInt32_UInt32_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_IsSlotEmpty_Private_Boolean_UInt32_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_InsertHash_Public_Void_UInt32_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHash_Public_Void_UInt32_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_ContainsHash_Public_Boolean_UInt32_0;

		// Token: 0x04000AA6 RID: 2726
		[FieldOffset(0)]
		public CountingBloomFilter._m_Counters_e__FixedBuffer m_Counters;

		// Token: 0x04000AA7 RID: 2727
		public const int KEY_SIZE = 14;

		// Token: 0x04000AA8 RID: 2728
		public const uint ARRAY_SIZE = 16384U;

		// Token: 0x04000AA9 RID: 2729
		public const int KEY_MASK = 16383;

		// Token: 0x020003D5 RID: 981
		[ObfuscatedName("UnityEngine.UIElements.CountingBloomFilter+<m_Counters>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_Counters_e__FixedBuffer
		{
			// Token: 0x060039EF RID: 14831 RVA: 0x0001881E File Offset: 0x00016A1E
			// Note: this type is marked as 'beforefieldinit'.
			static _m_Counters_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CountingBloomFilter._m_Counters_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountingBloomFilter>.NativeClassPtr, "<m_Counters>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountingBloomFilter._m_Counters_e__FixedBuffer>.NativeClassPtr);
				CountingBloomFilter._m_Counters_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountingBloomFilter._m_Counters_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x060039F0 RID: 14832 RVA: 0x00018852 File Offset: 0x00016A52
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CountingBloomFilter._m_Counters_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040028ED RID: 10477
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040028EE RID: 10478
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
