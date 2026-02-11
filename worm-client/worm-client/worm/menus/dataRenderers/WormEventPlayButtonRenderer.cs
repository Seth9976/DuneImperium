using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000089 RID: 137
	public class WormEventPlayButtonRenderer : Subscriber<WormEventData>
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x00029184 File Offset: 0x00027384
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventPlayButtonRenderer()
		{
			Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventPlayButtonRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr);
			WormEventPlayButtonRenderer.NativeFieldInfoPtr_playLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, "playLocKey");
			WormEventPlayButtonRenderer.NativeFieldInfoPtr_closedLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, "closedLocKey");
			WormEventPlayButtonRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, "text");
			WormEventPlayButtonRenderer.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, "button");
			WormEventPlayButtonRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, 100664065);
			WormEventPlayButtonRenderer.NativeMethodInfoPtr_Event_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, 100664066);
			WormEventPlayButtonRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, 100664067);
			WormEventPlayButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr, 100664068);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00029254 File Offset: 0x00027454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695027, XrefRangeEnd = 695037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventPlayButtonRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00029290 File Offset: 0x00027490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695037, XrefRangeEnd = 695042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPlayButtonRenderer.NativeMethodInfoPtr_Event_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000292C4 File Offset: 0x000274C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPlayButtonRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000292F8 File Offset: 0x000274F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695042, XrefRangeEnd = 695050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventPlayButtonRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventPlayButtonRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPlayButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004A63 File Offset: 0x00002C63
		public WormEventPlayButtonRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00029334 File Offset: 0x00027534
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00004A6C File Offset: 0x00002C6C
		public unsafe string playLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_playLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_playLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0002935C File Offset: 0x0002755C
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004A8B File Offset: 0x00002C8B
		public unsafe string closedLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_closedLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_closedLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00029384 File Offset: 0x00027584
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004AAA File Offset: 0x00002CAA
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000293B4 File Offset: 0x000275B4
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPlayButtonRenderer.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_playLocKey;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_closedLocKey;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
