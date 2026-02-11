using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002AE RID: 686
	public class RunLocalPlayFlowEvent : MonoBehaviour
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x00089D60 File Offset: 0x00087F60
		// Note: this type is marked as 'beforefieldinit'.
		static RunLocalPlayFlowEvent()
		{
			Il2CppClassPointerStore<RunLocalPlayFlowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "RunLocalPlayFlowEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLocalPlayFlowEvent>.NativeClassPtr);
			RunLocalPlayFlowEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLocalPlayFlowEvent>.NativeClassPtr, 100668699);
			RunLocalPlayFlowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLocalPlayFlowEvent>.NativeClassPtr, 100668700);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00089DB8 File Offset: 0x00087FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542522, XrefRangeEnd = 542527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLocalPlayFlowEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00089DEC File Offset: 0x00087FEC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunLocalPlayFlowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLocalPlayFlowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLocalPlayFlowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0001106C File Offset: 0x0000F26C
		public RunLocalPlayFlowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_Event_Run_Public_Void_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
