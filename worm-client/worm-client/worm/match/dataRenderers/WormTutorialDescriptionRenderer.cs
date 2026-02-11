using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x0200016F RID: 367
	public class WormTutorialDescriptionRenderer : VersionedSubscriber<SerializedMatchComponent>
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x00049170 File Offset: 0x00047370
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialDescriptionRenderer()
		{
			Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTutorialDescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr);
			WormTutorialDescriptionRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr, "text");
			WormTutorialDescriptionRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr, 100665504);
			WormTutorialDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr, 100665505);
			WormTutorialDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr, 100665506);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000491F0 File Offset: 0x000473F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709180, XrefRangeEnd = 709185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialDescriptionRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0004922C File Offset: 0x0004742C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709185, XrefRangeEnd = 709194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00049268 File Offset: 0x00047468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709194, XrefRangeEnd = 709197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialDescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialDescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0000A9AA File Offset: 0x00008BAA
		public WormTutorialDescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x000492A4 File Offset: 0x000474A4
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0000A9B3 File Offset: 0x00008BB3
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialDescriptionRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialDescriptionRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
