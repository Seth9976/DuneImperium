using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.Canis.menus.ui
{
	// Token: 0x0200001D RID: 29
	public class OfflineMatchesSaveIconRenderer : VersionedSubscriber<SerializedMatchComponent>
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00021230 File Offset: 0x0001F430
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMatchesSaveIconRenderer()
		{
			Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.Canis.menus.ui", "OfflineMatchesSaveIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr);
			OfflineMatchesSaveIconRenderer.NativeFieldInfoPtr_saveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr, "saveIcon");
			OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr, 100663525);
			OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr, 100663526);
			OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr, 100663527);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000212B0 File Offset: 0x0001F4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497282, XrefRangeEnd = 497287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasSavedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000212EC File Offset: 0x0001F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497287, XrefRangeEnd = 497298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00021328 File Offset: 0x0001F528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497298, XrefRangeEnd = 497301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMatchesSaveIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMatchesSaveIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000026E8 File Offset: 0x000008E8
		public OfflineMatchesSaveIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00021364 File Offset: 0x0001F564
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000026F1 File Offset: 0x000008F1
		public unsafe GameObject saveIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchesSaveIconRenderer.NativeFieldInfoPtr_saveIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchesSaveIconRenderer.NativeFieldInfoPtr_saveIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_saveIcon;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
