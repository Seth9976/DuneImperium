using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.canis
{
	// Token: 0x02000046 RID: 70
	public class RunLandingFlowEvent : MonoBehaviour
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00026204 File Offset: 0x00024404
		// Note: this type is marked as 'beforefieldinit'.
		static RunLandingFlowEvent()
		{
			Il2CppClassPointerStore<RunLandingFlowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "RunLandingFlowEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLandingFlowEvent>.NativeClassPtr);
			RunLandingFlowEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLandingFlowEvent>.NativeClassPtr, 100663721);
			RunLandingFlowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLandingFlowEvent>.NativeClassPtr, 100663722);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0002625C File Offset: 0x0002445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498939, XrefRangeEnd = 498944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLandingFlowEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00026290 File Offset: 0x00024490
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunLandingFlowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLandingFlowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLandingFlowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000032E2 File Offset: 0x000014E2
		public RunLandingFlowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Event_Run_Public_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
