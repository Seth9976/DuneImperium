using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000268 RID: 616
	public class PaySpice : PayResources
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0000B418 File Offset: 0x00009618
		// Note: this type is marked as 'beforefieldinit'.
		static PaySpice()
		{
			Il2CppClassPointerStore<PaySpice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PaySpice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaySpice>.NativeClassPtr);
			PaySpice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaySpice>.NativeClassPtr, 100668252);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000BEDFC File Offset: 0x000BCFFC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 140437, RefRangeEnd = 140457, XrefRangeStart = 140431, XrefRangeEnd = 140437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaySpice(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaySpice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaySpice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0000B451 File Offset: 0x00009651
		public PaySpice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
