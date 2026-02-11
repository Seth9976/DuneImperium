using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000249 RID: 585
	public class GainSolari : GainResources
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x0000AF4D File Offset: 0x0000914D
		// Note: this type is marked as 'beforefieldinit'.
		static GainSolari()
		{
			Il2CppClassPointerStore<GainSolari>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainSolari");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSolari>.NativeClassPtr);
			GainSolari.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSolari>.NativeClassPtr, 100667905);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000BBDA8 File Offset: 0x000B9FA8
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 136654, RefRangeEnd = 136690, XrefRangeStart = 136648, XrefRangeEnd = 136654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSolari(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSolari>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSolari.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0000AF86 File Offset: 0x00009186
		public GainSolari(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
