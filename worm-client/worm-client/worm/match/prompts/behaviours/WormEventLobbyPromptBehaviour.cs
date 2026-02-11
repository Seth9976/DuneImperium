using System;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D3 RID: 211
	public class WormEventLobbyPromptBehaviour : PromptBehaviour<IPromptWithData>
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x000338D0 File Offset: 0x00031AD0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLobbyPromptBehaviour()
		{
			Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEventLobbyPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr);
			WormEventLobbyPromptBehaviour.NativeFieldInfoPtr_resignButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr, "resignButton");
			WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr, 100664515);
			WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_Event_Resign_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr, 100664516);
			WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_Event_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr, 100664517);
			WormEventLobbyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr, 100664518);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00033964 File Offset: 0x00031B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699153, XrefRangeEnd = 699173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000339A0 File Offset: 0x00031BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699173, XrefRangeEnd = 699185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_Event_Resign_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000339D4 File Offset: 0x00031BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLobbyPromptBehaviour.NativeMethodInfoPtr_Event_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00033A08 File Offset: 0x00031C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699185, XrefRangeEnd = 699188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLobbyPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLobbyPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLobbyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000697F File Offset: 0x00004B7F
		public WormEventLobbyPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00033A44 File Offset: 0x00031C44
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00006988 File Offset: 0x00004B88
		public unsafe GameObject resignButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLobbyPromptBehaviour.NativeFieldInfoPtr_resignButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLobbyPromptBehaviour.NativeFieldInfoPtr_resignButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr_resignButton;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resign_Public_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_Event_Refresh_Public_Void_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
