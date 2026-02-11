using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace products.rewards
{
	// Token: 0x02000006 RID: 6
	public class NoReward : RewardDefinition
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000020E7 File Offset: 0x000002E7
		// Note: this type is marked as 'beforefieldinit'.
		static NoReward()
		{
			Il2CppClassPointerStore<NoReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "products.rewards", "NoReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoReward>.NativeClassPtr);
			NoReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoReward>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003978 File Offset: 0x00001B78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoReward()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002120 File Offset: 0x00000320
		public NoReward(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
