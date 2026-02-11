using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200024C RID: 588
	public class GainRevealStrength : GainResources
	{
		// Token: 0x0600197C RID: 6524 RVA: 0x0000B013 File Offset: 0x00009213
		// Note: this type is marked as 'beforefieldinit'.
		static GainRevealStrength()
		{
			Il2CppClassPointerStore<GainRevealStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainRevealStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainRevealStrength>.NativeClassPtr);
			GainRevealStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainRevealStrength>.NativeClassPtr, 100667908);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000BBEBC File Offset: 0x000BA0BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 136730, RefRangeEnd = 136739, XrefRangeStart = 136724, XrefRangeEnd = 136730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainRevealStrength(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainRevealStrength>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainRevealStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0000B04C File Offset: 0x0000924C
		public GainRevealStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
