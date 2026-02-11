using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace worm.match.commands
{
	// Token: 0x0200023C RID: 572
	public class WormRunOnlinePlayFlow : Command
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x00063294 File Offset: 0x00061494
		// Note: this type is marked as 'beforefieldinit'.
		static WormRunOnlinePlayFlow()
		{
			Il2CppClassPointerStore<WormRunOnlinePlayFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormRunOnlinePlayFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRunOnlinePlayFlow>.NativeClassPtr);
			WormRunOnlinePlayFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunOnlinePlayFlow>.NativeClassPtr, 100666760);
			WormRunOnlinePlayFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunOnlinePlayFlow>.NativeClassPtr, 100666761);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000632EC File Offset: 0x000614EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719122, XrefRangeEnd = 719142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRunOnlinePlayFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00063338 File Offset: 0x00061538
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRunOnlinePlayFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRunOnlinePlayFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRunOnlinePlayFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0000E947 File Offset: 0x0000CB47
		public WormRunOnlinePlayFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
