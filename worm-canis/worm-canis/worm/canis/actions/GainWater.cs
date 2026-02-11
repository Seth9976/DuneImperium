using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000247 RID: 583
	public class GainWater : GainResources
	{
		// Token: 0x06001968 RID: 6504 RVA: 0x0000AEE3 File Offset: 0x000090E3
		// Note: this type is marked as 'beforefieldinit'.
		static GainWater()
		{
			Il2CppClassPointerStore<GainWater>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainWater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainWater>.NativeClassPtr);
			GainWater.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainWater>.NativeClassPtr, 100667900);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000BBB54 File Offset: 0x000B9D54
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 136578, RefRangeEnd = 136593, XrefRangeStart = 136572, XrefRangeEnd = 136578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainWater(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainWater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainWater.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0000AF1C File Offset: 0x0000911C
		public GainWater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
