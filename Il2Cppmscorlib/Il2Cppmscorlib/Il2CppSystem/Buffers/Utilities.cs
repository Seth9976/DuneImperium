using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000517 RID: 1303
	public static class Utilities : Object
	{
		// Token: 0x06004FB1 RID: 20401 RVA: 0x00172D5C File Offset: 0x00170F5C
		// Note: this type is marked as 'beforefieldinit'.
		static Utilities()
		{
			Il2CppClassPointerStore<Utilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "Utilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utilities>.NativeClassPtr);
			Utilities.NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100675320);
			Utilities.NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100675321);
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00172DB4 File Offset: 0x00170FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426800, RefRangeEnd = 1426802, XrefRangeStart = 1426800, XrefRangeEnd = 1426800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SelectBucketIndex(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00172DF4 File Offset: 0x00170FF4
		[CallerCount(0)]
		public unsafe static int GetMaxSizeForBucket(int binIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utilities.NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x0001C9B6 File Offset: 0x0001ABB6
		public Utilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040F0 RID: 16624
		private static readonly IntPtr NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0;

		// Token: 0x040040F1 RID: 16625
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0;
	}
}
