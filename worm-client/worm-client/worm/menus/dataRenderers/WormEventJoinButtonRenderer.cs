using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000087 RID: 135
	public class WormEventJoinButtonRenderer : Subscriber<WormEventData>
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x00028D44 File Offset: 0x00026F44
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventJoinButtonRenderer()
		{
			Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventJoinButtonRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr);
			WormEventJoinButtonRenderer.NativeFieldInfoPtr_joinLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, "joinLocKey");
			WormEventJoinButtonRenderer.NativeFieldInfoPtr_closedLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, "closedLocKey");
			WormEventJoinButtonRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, "text");
			WormEventJoinButtonRenderer.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, "button");
			WormEventJoinButtonRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, 100664059);
			WormEventJoinButtonRenderer.NativeMethodInfoPtr_Event_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, 100664060);
			WormEventJoinButtonRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, 100664061);
			WormEventJoinButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr, 100664062);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00028E14 File Offset: 0x00027014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694968, XrefRangeEnd = 694969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventJoinButtonRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00028E50 File Offset: 0x00027050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694969, XrefRangeEnd = 694974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Join()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinButtonRenderer.NativeMethodInfoPtr_Event_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00028E84 File Offset: 0x00027084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695000, RefRangeEnd = 695001, XrefRangeStart = 694974, XrefRangeEnd = 695000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinButtonRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00028EB8 File Offset: 0x000270B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695001, XrefRangeEnd = 695009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventJoinButtonRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventJoinButtonRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinButtonRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00004959 File Offset: 0x00002B59
		public WormEventJoinButtonRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00028EF4 File Offset: 0x000270F4
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00004962 File Offset: 0x00002B62
		public unsafe string joinLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_joinLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_joinLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00028F1C File Offset: 0x0002711C
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00004981 File Offset: 0x00002B81
		public unsafe string closedLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_closedLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_closedLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00028F44 File Offset: 0x00027144
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000049A0 File Offset: 0x00002BA0
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00028F74 File Offset: 0x00027174
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000049BF File Offset: 0x00002BBF
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventJoinButtonRenderer.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_joinLocKey;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_closedLocKey;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_Event_Join_Public_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
