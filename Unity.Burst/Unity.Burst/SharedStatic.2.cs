using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000018 RID: 24
	public static class SharedStatic : Object
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000097A8 File Offset: 0x000079A8
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "SharedStatic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr);
			SharedStatic.NativeMethodInfoPtr_CheckSizeOf_Private_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, 100663528);
			SharedStatic.NativeMethodInfoPtr_CheckResult_Private_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, 100663529);
			SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, 100663530);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009814 File Offset: 0x00007A14
		[CallerCount(0)]
		public unsafe static void CheckSizeOf(uint sizeOf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeOf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.NativeMethodInfoPtr_CheckSizeOf_Private_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009848 File Offset: 0x00007A48
		[CallerCount(0)]
		public unsafe static void CheckResult(void* result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.NativeMethodInfoPtr_CheckResult_Private_Static_Void_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000987C File Offset: 0x00007A7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052516, RefRangeEnd = 1052519, XrefRangeStart = 1052514, XrefRangeEnd = 1052516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getHashCode64;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getSubHashCode64;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002CAD File Offset: 0x00000EAD
		public SharedStatic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_CheckSizeOf_Private_Static_Void_UInt32_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_CheckResult_Private_Static_Void_ptr_Void_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;

		// Token: 0x02000047 RID: 71
		public class PreserveAttribute : Attribute
		{
			// Token: 0x06000326 RID: 806 RVA: 0x000031C4 File Offset: 0x000013C4
			// Note: this type is marked as 'beforefieldinit'.
			static PreserveAttribute()
			{
				Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, "PreserveAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr);
				SharedStatic.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr, 100663531);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000FA34 File Offset: 0x0000DC34
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreserveAttribute()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000328 RID: 808 RVA: 0x000031F8 File Offset: 0x000013F8
			public PreserveAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
