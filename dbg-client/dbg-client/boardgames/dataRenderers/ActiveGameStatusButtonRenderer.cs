using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.datarenderers
{
	// Token: 0x02000168 RID: 360
	public class ActiveGameStatusButtonRenderer : VersionedSubscriber<ReconnectableGameData>
	{
		// Token: 0x06001010 RID: 4112 RVA: 0x00050654 File Offset: 0x0004E854
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveGameStatusButtonRenderer()
		{
			Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ActiveGameStatusButtonRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr);
			ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_continueGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr, "continueGameButton");
			ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_viewGameResultsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr, "viewGameResultsButton");
			ActiveGameStatusButtonRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr, 100665564);
			ActiveGameStatusButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr, 100665565);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000506D4 File Offset: 0x0004E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513808, XrefRangeEnd = 513815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveGameStatusButtonRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00050710 File Offset: 0x0004E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513815, XrefRangeEnd = 513818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveGameStatusButtonRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveGameStatusButtonRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveGameStatusButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00009C77 File Offset: 0x00007E77
		public ActiveGameStatusButtonRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0005074C File Offset: 0x0004E94C
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00009C80 File Offset: 0x00007E80
		public unsafe GameObject continueGameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_continueGameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_continueGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0005077C File Offset: 0x0004E97C
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00009C9F File Offset: 0x00007E9F
		public unsafe GameObject viewGameResultsButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_viewGameResultsButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameStatusButtonRenderer.NativeFieldInfoPtr_viewGameResultsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_continueGameButton;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_viewGameResultsButton;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
