using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using localization;

namespace boardgames.datarenderers
{
	// Token: 0x0200016C RID: 364
	public class AvatarTextFormatRenderer : VersionedSubscriber<AvatarDataComponent>
	{
		// Token: 0x06001035 RID: 4149 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarTextFormatRenderer()
		{
			Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "AvatarTextFormatRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr);
			AvatarTextFormatRenderer.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr, "format");
			AvatarTextFormatRenderer.NativeFieldInfoPtr_localizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr, "localizer");
			AvatarTextFormatRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr, 100665575);
			AvatarTextFormatRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr, 100665576);
			AvatarTextFormatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr, 100665577);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00050D74 File Offset: 0x0004EF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513864, XrefRangeEnd = 513872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarTextFormatRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00050DA8 File Offset: 0x0004EFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513872, XrefRangeEnd = 513877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarTextFormatRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00050DE4 File Offset: 0x0004EFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513877, XrefRangeEnd = 513883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarTextFormatRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarTextFormatRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarTextFormatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00009DAE File Offset: 0x00007FAE
		public AvatarTextFormatRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00050E20 File Offset: 0x0004F020
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00009DB7 File Offset: 0x00007FB7
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarTextFormatRenderer.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarTextFormatRenderer.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00050E48 File Offset: 0x0004F048
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00009DD6 File Offset: 0x00007FD6
		public unsafe TMPLocalizer localizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarTextFormatRenderer.NativeFieldInfoPtr_localizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMPLocalizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarTextFormatRenderer.NativeFieldInfoPtr_localizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_localizer;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
