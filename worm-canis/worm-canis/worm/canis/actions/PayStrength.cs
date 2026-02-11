using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200026B RID: 619
	public class PayStrength : PayResources
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x0000B4DE File Offset: 0x000096DE
		// Note: this type is marked as 'beforefieldinit'.
		static PayStrength()
		{
			Il2CppClassPointerStore<PayStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PayStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayStrength>.NativeClassPtr);
			PayStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayStrength>.NativeClassPtr, 100668255);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000BEF10 File Offset: 0x000BD110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140482, XrefRangeEnd = 140488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayStrength(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayStrength>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000B517 File Offset: 0x00009717
		public PayStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
