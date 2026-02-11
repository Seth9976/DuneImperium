using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000091 RID: 145
	public static class BufferManager : Object
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x000406A0 File Offset: 0x0003E8A0
		// Note: this type is marked as 'beforefieldinit'.
		static BufferManager()
		{
			Il2CppClassPointerStore<BufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "BufferManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferManager>.NativeClassPtr);
			BufferManager.NativeFieldInfoPtr_ReferenceCounterPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "ReferenceCounterPool");
			BufferManager.NativeFieldInfoPtr_BufferPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "BufferPools");
			BufferManager.NativeFieldInfoPtr_ReferenceCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "ReferenceCounters");
			BufferManager.NativeFieldInfoPtr_FreeFunctionPin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "FreeFunctionPin");
			BufferManager.NativeFieldInfoPtr_FreeFunctionPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "FreeFunctionPointer");
			BufferManager.NativeFieldInfoPtr_Bucket512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket512");
			BufferManager.NativeFieldInfoPtr_Bucket1Kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket1Kb");
			BufferManager.NativeFieldInfoPtr_Bucket4Kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket4Kb");
			BufferManager.NativeFieldInfoPtr_Bucket16Kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket16Kb");
			BufferManager.NativeFieldInfoPtr_Bucket64Kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket64Kb");
			BufferManager.NativeFieldInfoPtr_Bucket256Kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "Bucket256Kb");
			BufferManager.NativeMethodInfoPtr_Get_Public_Static_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665222);
			BufferManager.NativeMethodInfoPtr_Free_Private_Static_Void_ptr_NetMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665223);
			BufferManager.NativeMethodInfoPtr_AllocateReferenceCounter_Private_Static_ReferenceCounter_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665224);
			BufferManager.NativeMethodInfoPtr_FreeReferenceCounter_Private_Static_Void_ReferenceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665225);
			BufferManager.NativeMethodInfoPtr_AllocateBuffer_Private_Static_Void_Int32_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665226);
			BufferManager.NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665227);
			BufferManager.NativeMethodInfoPtr_GetBucketSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665228);
			BufferManager.NativeMethodInfoPtr_GetBucketLimit_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, 100665229);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0004084C File Offset: 0x0003EA4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936738, RefRangeEnd = 936740, XrefRangeStart = 936722, XrefRangeEnd = 936738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Get(int size, int referenceCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referenceCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_Get_Public_Static_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00040898 File Offset: 0x0003EA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936740, XrefRangeEnd = 936785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free(NetMsg* msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = msg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_Free_Private_Static_Void_ptr_NetMsg_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000408CC File Offset: 0x0003EACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936809, RefRangeEnd = 936810, XrefRangeStart = 936785, XrefRangeEnd = 936809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referenceCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_AllocateReferenceCounter_Private_Static_ReferenceCounter_IntPtr_Int32_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferManager.ReferenceCounter>(intPtr3) : null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00040928 File Offset: 0x0003EB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936829, RefRangeEnd = 936830, XrefRangeStart = 936810, XrefRangeEnd = 936829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeReferenceCounter(BufferManager.ReferenceCounter counter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(counter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_FreeReferenceCounter_Private_Static_Void_ReferenceCounter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00040960 File Offset: 0x0003EB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936841, RefRangeEnd = 936842, XrefRangeStart = 936830, XrefRangeEnd = 936841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref minimumSize;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_AllocateBuffer_Private_Static_Void_Int32_byref_IntPtr_byref_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000409B0 File Offset: 0x0003EBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936857, RefRangeEnd = 936858, XrefRangeStart = 936842, XrefRangeEnd = 936857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeBuffer(IntPtr ptr, int size)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000409F0 File Offset: 0x0003EBF0
		[CallerCount(0)]
		public unsafe static int GetBucketSize(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_GetBucketSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00040A30 File Offset: 0x0003EC30
		[CallerCount(0)]
		public unsafe static int GetBucketLimit(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.NativeMethodInfoPtr_GetBucketLimit_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000240E File Offset: 0x0000060E
		public BufferManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00040A70 File Offset: 0x0003EC70
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00002417 File Offset: 0x00000617
		public unsafe static Stack<BufferManager.ReferenceCounter> ReferenceCounterPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_ReferenceCounterPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<BufferManager.ReferenceCounter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_ReferenceCounterPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00040A98 File Offset: 0x0003EC98
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00002429 File Offset: 0x00000629
		public unsafe static Dictionary<int, Stack<IntPtr>> BufferPools
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_BufferPools, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Stack<IntPtr>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_BufferPools, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00040AC0 File Offset: 0x0003ECC0
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000243B File Offset: 0x0000063B
		public unsafe static Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_ReferenceCounters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IntPtr, BufferManager.ReferenceCounter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_ReferenceCounters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00040AE8 File Offset: 0x0003ECE8
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe static BufferManager.FreeFn FreeFunctionPin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_FreeFunctionPin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferManager.FreeFn>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_FreeFunctionPin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00040B10 File Offset: 0x0003ED10
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0000245F File Offset: 0x0000065F
		public unsafe static IntPtr FreeFunctionPointer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_FreeFunctionPointer, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_FreeFunctionPointer, (void*)(&value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00040B2C File Offset: 0x0003ED2C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe static int Bucket512
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket512, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket512, (void*)(&value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00040B48 File Offset: 0x0003ED48
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000247B File Offset: 0x0000067B
		public unsafe static int Bucket1Kb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket1Kb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket1Kb, (void*)(&value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00040B64 File Offset: 0x0003ED64
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00002489 File Offset: 0x00000689
		public unsafe static int Bucket4Kb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket4Kb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket4Kb, (void*)(&value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00040B80 File Offset: 0x0003ED80
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00002497 File Offset: 0x00000697
		public unsafe static int Bucket16Kb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket16Kb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket16Kb, (void*)(&value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00040B9C File Offset: 0x0003ED9C
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x000024A5 File Offset: 0x000006A5
		public unsafe static int Bucket64Kb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket64Kb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket64Kb, (void*)(&value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00040BB8 File Offset: 0x0003EDB8
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x000024B3 File Offset: 0x000006B3
		public unsafe static int Bucket256Kb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BufferManager.NativeFieldInfoPtr_Bucket256Kb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BufferManager.NativeFieldInfoPtr_Bucket256Kb, (void*)(&value));
			}
		}

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceCounterPool;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_BufferPools;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceCounters;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_FreeFunctionPin;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_FreeFunctionPointer;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_Bucket512;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr_Bucket1Kb;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeFieldInfoPtr_Bucket4Kb;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeFieldInfoPtr_Bucket16Kb;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeFieldInfoPtr_Bucket64Kb;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr_Bucket256Kb;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_IntPtr_Int32_Int32_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_Free_Private_Static_Void_ptr_NetMsg_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_AllocateReferenceCounter_Private_Static_ReferenceCounter_IntPtr_Int32_Int32_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_FreeReferenceCounter_Private_Static_Void_ReferenceCounter_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_AllocateBuffer_Private_Static_Void_Int32_byref_IntPtr_byref_Int32_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketSize_Private_Static_Int32_Int32_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketLimit_Private_Static_Int32_Int32_0;

		// Token: 0x0200021B RID: 539
		public sealed class ReferenceCounter : Object
		{
			// Token: 0x06001B07 RID: 6919 RVA: 0x00080CD0 File Offset: 0x0007EED0
			// Note: this type is marked as 'beforefieldinit'.
			static ReferenceCounter()
			{
				Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "ReferenceCounter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr);
				BufferManager.ReferenceCounter.NativeFieldInfoPtr__Pointer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, "<Pointer>k__BackingField");
				BufferManager.ReferenceCounter.NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, "<Size>k__BackingField");
				BufferManager.ReferenceCounter.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, "_count");
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_get_Pointer_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665231);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_set_Pointer_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665232);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665233);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665234);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_Set_Public_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665235);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr_Decrement_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665236);
				BufferManager.ReferenceCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr, 100665237);
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00080DC4 File Offset: 0x0007EFC4
			// (set) Token: 0x06001B09 RID: 6921 RVA: 0x00080E00 File Offset: 0x0007F000
			public unsafe IntPtr Pointer
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_get_Pointer_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_set_Pointer_Private_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00080E40 File Offset: 0x0007F040
			// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00080E7C File Offset: 0x0007F07C
			public unsafe int Size
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001B0C RID: 6924 RVA: 0x00080EBC File Offset: 0x0007F0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936699, XrefRangeEnd = 936719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(IntPtr ptr, int size, int referenceCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ref ptr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referenceCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_Set_Public_Void_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0D RID: 6925 RVA: 0x00080F18 File Offset: 0x0007F118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936719, XrefRangeEnd = 936722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Decrement()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr_Decrement_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B0E RID: 6926 RVA: 0x00080F54 File Offset: 0x0007F154
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReferenceCounter()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferManager.ReferenceCounter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.ReferenceCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0F RID: 6927 RVA: 0x00008ED4 File Offset: 0x000070D4
			public ReferenceCounter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001B10 RID: 6928 RVA: 0x00080F90 File Offset: 0x0007F190
			// (set) Token: 0x06001B11 RID: 6929 RVA: 0x00008EDD File Offset: 0x000070DD
			public unsafe IntPtr _Pointer_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__Pointer_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__Pointer_k__BackingField)) = value;
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00080FB8 File Offset: 0x0007F1B8
			// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00008EF8 File Offset: 0x000070F8
			public unsafe int _Size_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__Size_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__Size_k__BackingField)) = value;
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00080FE0 File Offset: 0x0007F1E0
			// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00008F13 File Offset: 0x00007113
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferManager.ReferenceCounter.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x04001FD8 RID: 8152
			private static readonly IntPtr NativeFieldInfoPtr__Pointer_k__BackingField;

			// Token: 0x04001FD9 RID: 8153
			private static readonly IntPtr NativeFieldInfoPtr__Size_k__BackingField;

			// Token: 0x04001FDA RID: 8154
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04001FDB RID: 8155
			private static readonly IntPtr NativeMethodInfoPtr_get_Pointer_Public_get_IntPtr_0;

			// Token: 0x04001FDC RID: 8156
			private static readonly IntPtr NativeMethodInfoPtr_set_Pointer_Private_set_Void_IntPtr_0;

			// Token: 0x04001FDD RID: 8157
			private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;

			// Token: 0x04001FDE RID: 8158
			private static readonly IntPtr NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0;

			// Token: 0x04001FDF RID: 8159
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_IntPtr_Int32_Int32_0;

			// Token: 0x04001FE0 RID: 8160
			private static readonly IntPtr NativeMethodInfoPtr_Decrement_Public_Boolean_0;

			// Token: 0x04001FE1 RID: 8161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021C RID: 540
		public sealed class FreeFn : MulticastDelegate
		{
			// Token: 0x06001B16 RID: 6934 RVA: 0x00081008 File Offset: 0x0007F208
			// Note: this type is marked as 'beforefieldinit'.
			static FreeFn()
			{
				Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferManager>.NativeClassPtr, "FreeFn");
				BufferManager.FreeFn.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr, 100665238);
				BufferManager.FreeFn.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_NetMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr, 100665239);
				BufferManager.FreeFn.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_NetMsg_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr, 100665240);
				BufferManager.FreeFn.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr, 100665241);
			}

			// Token: 0x06001B17 RID: 6935 RVA: 0x0008107C File Offset: 0x0007F27C
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FreeFn(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferManager.FreeFn>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.FreeFn.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B18 RID: 6936 RVA: 0x000810D8 File Offset: 0x0007F2D8
			[CallerCount(0)]
			public unsafe void Invoke(NetMsg* msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = msg;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.FreeFn.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_NetMsg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B19 RID: 6937 RVA: 0x00081118 File Offset: 0x0007F318
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = msg;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.FreeFn.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_NetMsg_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B1A RID: 6938 RVA: 0x00081188 File Offset: 0x0007F388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferManager.FreeFn.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1B RID: 6939 RVA: 0x00008F2E File Offset: 0x0000712E
			public FreeFn(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FE2 RID: 8162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FE3 RID: 8163
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_NetMsg_0;

			// Token: 0x04001FE4 RID: 8164
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_NetMsg_AsyncCallback_Object_0;

			// Token: 0x04001FE5 RID: 8165
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
