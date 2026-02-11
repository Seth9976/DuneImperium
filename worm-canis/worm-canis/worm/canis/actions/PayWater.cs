using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000267 RID: 615
	public class PayWater : PayResources
	{
		// Token: 0x06001A34 RID: 6708 RVA: 0x0000B3D6 File Offset: 0x000095D6
		// Note: this type is marked as 'beforefieldinit'.
		static PayWater()
		{
			Il2CppClassPointerStore<PayWater>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PayWater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayWater>.NativeClassPtr);
			PayWater.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayWater>.NativeClassPtr, 100668251);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000BEDA0 File Offset: 0x000BCFA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140426, RefRangeEnd = 140431, XrefRangeStart = 140420, XrefRangeEnd = 140426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayWater(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayWater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayWater.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000B40F File Offset: 0x0000960F
		public PayWater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
