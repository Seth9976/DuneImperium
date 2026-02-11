using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics.Hashing
{
	// Token: 0x02000468 RID: 1128
	public static class HashHelpers : Object
	{
		// Token: 0x06004374 RID: 17268 RVA: 0x0013DE58 File Offset: 0x0013C058
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics.Hashing", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "RandomSeed");
			HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673259);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x0013DEB0 File Offset: 0x0013C0B0
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 1226398, RefRangeEnd = 1226511, XrefRangeStart = 1226398, XrefRangeEnd = 1226511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06004376 RID: 17270 RVA: 0x0001871A File Offset: 0x0001691A
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x0013DEFC File Offset: 0x0013C0FC
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x00018723 File Offset: 0x00016923
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

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeFieldInfoPtr_RandomSeed;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;
	}
}
