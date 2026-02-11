using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.datarenderers
{
	// Token: 0x0200016B RID: 363
	public class AvatarImageAtlasRenderer : VersionedSubscriber<AvatarDataComponent>
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x00050B54 File Offset: 0x0004ED54
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImageAtlasRenderer()
		{
			Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "AvatarImageAtlasRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr);
			AvatarImageAtlasRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr, "atlasName");
			AvatarImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr, "spriteNameFormat");
			AvatarImageAtlasRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr, "image");
			AvatarImageAtlasRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr, 100665573);
			AvatarImageAtlasRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr, 100665574);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00050BE8 File Offset: 0x0004EDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513840, XrefRangeEnd = 513858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarImageAtlasRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00050C24 File Offset: 0x0004EE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513858, XrefRangeEnd = 513864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarImageAtlasRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarImageAtlasRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImageAtlasRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00009D48 File Offset: 0x00007F48
		public AvatarImageAtlasRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00050C60 File Offset: 0x0004EE60
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00009D51 File Offset: 0x00007F51
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00050C88 File Offset: 0x0004EE88
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00009D70 File Offset: 0x00007F70
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00050CB0 File Offset: 0x0004EEB0
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00009D8F File Offset: 0x00007F8F
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImageAtlasRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
