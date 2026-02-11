using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000269 RID: 617
	public class PaySolari : PayResources
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x0000B45A File Offset: 0x0000965A
		// Note: this type is marked as 'beforefieldinit'.
		static PaySolari()
		{
			Il2CppClassPointerStore<PaySolari>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PaySolari");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaySolari>.NativeClassPtr);
			PaySolari.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaySolari>.NativeClassPtr, 100668253);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000BEE58 File Offset: 0x000BD058
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 140463, RefRangeEnd = 140475, XrefRangeStart = 140457, XrefRangeEnd = 140463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaySolari(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaySolari>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaySolari.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0000B493 File Offset: 0x00009693
		public PaySolari(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
