using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x0200015A RID: 346
	public class SubscriberImageTextureRenderer : VersionedSubscriber<ImageLookup>
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x0004EF74 File Offset: 0x0004D174
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberImageTextureRenderer()
		{
			Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SubscriberImageTextureRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr);
			SubscriberImageTextureRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr, "assetPathFormat");
			SubscriberImageTextureRenderer.NativeFieldInfoPtr_cachedRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr, "cachedRenderer");
			SubscriberImageTextureRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr, 100665524);
			SubscriberImageTextureRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr, 100665525);
			SubscriberImageTextureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr, 100665526);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0004F008 File Offset: 0x0004D208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513419, XrefRangeEnd = 513423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberImageTextureRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0004F044 File Offset: 0x0004D244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513423, XrefRangeEnd = 513443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberImageTextureRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0004F080 File Offset: 0x0004D280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513443, XrefRangeEnd = 513449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberImageTextureRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberImageTextureRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberImageTextureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00009813 File Offset: 0x00007A13
		public SubscriberImageTextureRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0004F0BC File Offset: 0x0004D2BC
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x0000981C File Offset: 0x00007A1C
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageTextureRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageTextureRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0004F0E4 File Offset: 0x0004D2E4
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x0000983B File Offset: 0x00007A3B
		public unsafe Renderer cachedRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageTextureRenderer.NativeFieldInfoPtr_cachedRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageTextureRenderer.NativeFieldInfoPtr_cachedRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr_cachedRenderer;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
