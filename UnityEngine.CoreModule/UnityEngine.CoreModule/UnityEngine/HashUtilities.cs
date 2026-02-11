using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000EB RID: 235
	public static class HashUtilities : Object
	{
		// Token: 0x060012EC RID: 4844 RVA: 0x00007E67 File Offset: 0x00006067
		// Note: this type is marked as 'beforefieldinit'.
		static HashUtilities()
		{
			Il2CppClassPointerStore<HashUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr);
			HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr, 100665961);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0005EF28 File Offset: 0x0005D128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657873, RefRangeEnd = 657874, XrefRangeStart = 657872, XrefRangeEnd = 657873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendHash(ref Hash128 inHash, ref Hash128 outHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inHash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00007EA0 File Offset: 0x000060A0
		public HashUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0005EF68 File Offset: 0x0005D168
		public unsafe static void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* ptr2 = ptr;
				int* ptr3 = stackalloc int[(UIntPtr)64];
				for (int i = 0; i < 16; i++)
				{
					ptr3[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr3, 64UL, ptr2);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0005EFC4 File Offset: 0x0005D1C4
		public unsafe static void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* ptr2 = ptr;
				int* ptr3 = stackalloc int[(UIntPtr)12];
				for (int i = 0; i < 3; i++)
				{
					ptr3[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr3, 12UL, ptr2);
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0005F01C File Offset: 0x0005D21C
		public unsafe static void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct
		{
			void* ptr = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref value);
			ulong num = (ulong)((long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
			Hash128* ptr2 = (Hash128*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<Hash128>(ref hash);
			HashUnsafeUtilities.ComputeHash128(ptr, num, ptr2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00007EA9 File Offset: 0x000060A9
		public static void ComputeHash128(Il2CppStructArray<byte> value, ref Hash128 hash)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0;
	}
}
