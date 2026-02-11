using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.dataRenderers
{
	// Token: 0x02000158 RID: 344
	public class SubscriberBasicCropImageRenderer : VersionedSubscriber<ImageLookup>
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x0004EBF8 File Offset: 0x0004CDF8
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberBasicCropImageRenderer()
		{
			Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SubscriberBasicCropImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr);
			SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, "assetPathFormat");
			SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, "cropNameFormat");
			SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, "image");
			SubscriberBasicCropImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, 100665518);
			SubscriberBasicCropImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, 100665519);
			SubscriberBasicCropImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr, 100665520);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004ECA0 File Offset: 0x0004CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513355, XrefRangeEnd = 513359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberBasicCropImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004ECDC File Offset: 0x0004CEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513359, XrefRangeEnd = 513395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberBasicCropImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004ED18 File Offset: 0x0004CF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513395, XrefRangeEnd = 513403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberBasicCropImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberBasicCropImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberBasicCropImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00009766 File Offset: 0x00007966
		public SubscriberBasicCropImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0004ED54 File Offset: 0x0004CF54
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x0000976F File Offset: 0x0000796F
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0004ED7C File Offset: 0x0004CF7C
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x0000978E File Offset: 0x0000798E
		public unsafe string cropNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0004EDA4 File Offset: 0x0004CFA4
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x000097AD File Offset: 0x000079AD
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberBasicCropImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr_cropNameFormat;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
