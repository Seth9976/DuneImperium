using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.dataRenderers
{
	// Token: 0x02000157 RID: 343
	public class SubscriberAtlasImageRenderer : VersionedSubscriber<ImageLookup>
	{
		// Token: 0x06000F6F RID: 3951 RVA: 0x0004EA1C File Offset: 0x0004CC1C
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberAtlasImageRenderer()
		{
			Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SubscriberAtlasImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr);
			SubscriberAtlasImageRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, "atlasName");
			SubscriberAtlasImageRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, "spriteNameFormat");
			SubscriberAtlasImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, "image");
			SubscriberAtlasImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, 100665515);
			SubscriberAtlasImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, 100665516);
			SubscriberAtlasImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr, 100665517);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0004EAC4 File Offset: 0x0004CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513326, XrefRangeEnd = 513330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberAtlasImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0004EB00 File Offset: 0x0004CD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513330, XrefRangeEnd = 513347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberAtlasImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513347, XrefRangeEnd = 513355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberAtlasImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberAtlasImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberAtlasImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00009700 File Offset: 0x00007900
		public SubscriberAtlasImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0004EB78 File Offset: 0x0004CD78
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00009709 File Offset: 0x00007909
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00009728 File Offset: 0x00007928
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004EBC8 File Offset: 0x0004CDC8
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00009747 File Offset: 0x00007947
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberAtlasImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
