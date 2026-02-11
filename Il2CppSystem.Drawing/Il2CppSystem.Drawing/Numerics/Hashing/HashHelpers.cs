using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics.Hashing
{
	// Token: 0x02000002 RID: 2
	public static class HashHelpers : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000218C File Offset: 0x0000038C
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Drawing.dll", "System.Numerics.Hashing", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "RandomSeed");
			HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021E4 File Offset: 0x000003E4
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 1226398, RefRangeEnd = 1226511, XrefRangeStart = 1226398, XrefRangeEnd = 1226398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static int RandomSeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_RandomSeed;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;
	}
}
