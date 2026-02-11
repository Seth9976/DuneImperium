using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D5 RID: 213
	public class WormEventsSelectPromptBehaviour : MonoBehaviour
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00033BC4 File Offset: 0x00031DC4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsSelectPromptBehaviour()
		{
			Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEventsSelectPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr);
			WormEventsSelectPromptBehaviour.NativeMethodInfoPtr_Event_Join_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr, 100664521);
			WormEventsSelectPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr, 100664522);
			WormEventsSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr, 100664523);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00033C30 File Offset: 0x00031E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699225, XrefRangeEnd = 699230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Join(DataComposition eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsSelectPromptBehaviour.NativeMethodInfoPtr_Event_Join_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00033C74 File Offset: 0x00031E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699230, XrefRangeEnd = 699235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsSelectPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00033CA8 File Offset: 0x00031EA8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsSelectPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsSelectPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000069EA File Offset: 0x00004BEA
		public WormEventsSelectPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_Event_Join_Public_Void_DataComposition_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
