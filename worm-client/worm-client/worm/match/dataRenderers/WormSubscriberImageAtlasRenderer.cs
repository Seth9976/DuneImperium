using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x02000168 RID: 360
	public class WormSubscriberImageAtlasRenderer : VersionedSubscriber<ImageLookup>
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x000484E4 File Offset: 0x000466E4
		// Note: this type is marked as 'beforefieldinit'.
		static WormSubscriberImageAtlasRenderer()
		{
			Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSubscriberImageAtlasRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr);
			WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, "atlasName");
			WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, "spriteNameFormat");
			WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, "image");
			WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, "spriteRenderer");
			WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, 100665477);
			WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, 100665478);
			WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr, 100665479);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000485A0 File Offset: 0x000467A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708930, XrefRangeEnd = 708942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000485DC File Offset: 0x000467DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708942, XrefRangeEnd = 708978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00048618 File Offset: 0x00046818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708978, XrefRangeEnd = 708986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSubscriberImageAtlasRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSubscriberImageAtlasRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSubscriberImageAtlasRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0000A725 File Offset: 0x00008925
		public WormSubscriberImageAtlasRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00048654 File Offset: 0x00046854
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x0000A72E File Offset: 0x0000892E
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0004867C File Offset: 0x0004687C
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x0000A74D File Offset: 0x0000894D
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x000486A4 File Offset: 0x000468A4
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x0000A76C File Offset: 0x0000896C
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000486D4 File Offset: 0x000468D4
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x0000A78B File Offset: 0x0000898B
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriberImageAtlasRenderer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
