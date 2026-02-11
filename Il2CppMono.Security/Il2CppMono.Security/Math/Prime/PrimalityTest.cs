using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000040 RID: 64
	public sealed class PrimalityTest : MulticastDelegate
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00012B78 File Offset: 0x00010D78
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTest()
		{
			Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime", "PrimalityTest");
			PrimalityTest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663878);
			PrimalityTest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663879);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00012BC8 File Offset: 0x00010DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151990, XrefRangeEnd = 1151999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimalityTest(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00012C24 File Offset: 0x00010E24
		[CallerCount(0)]
		public unsafe bool Invoke(BigInteger bi, ConfidenceFactor confidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003A1E File Offset: 0x00001C1E
		public PrimalityTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003A27 File Offset: 0x00001C27
		public static implicit operator PrimalityTest(Func<BigInteger, ConfidenceFactor, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrimalityTest>(A_0);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003A2F File Offset: 0x00001C2F
		public static PrimalityTest operator +(PrimalityTest A_0, PrimalityTest A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrimalityTest>();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003A3D File Offset: 0x00001C3D
		public static PrimalityTest operator -(PrimalityTest A_0, PrimalityTest A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrimalityTest>();
			}
			return delegate2;
		}

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
