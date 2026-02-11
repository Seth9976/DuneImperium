using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;
using voodoo;

namespace worm.match.dataRenderers
{
	// Token: 0x02000143 RID: 323
	public class WormLeaderAvatarImageRenderer : VersionedDataComponentObserver<EntityComponent>
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00043E90 File Offset: 0x00042090
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderAvatarImageRenderer()
		{
			Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormLeaderAvatarImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr);
			WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, "atlasName");
			WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, "spriteNameFormat");
			WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, "image");
			WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, "wormEntities");
			WormLeaderAvatarImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, 100665264);
			WormLeaderAvatarImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, 100665265);
			WormLeaderAvatarImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr, 100665266);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00043F4C File Offset: 0x0004214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706697, XrefRangeEnd = 706702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderAvatarImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00043F88 File Offset: 0x00042188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706702, XrefRangeEnd = 706735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderAvatarImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00043FC4 File Offset: 0x000421C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706735, XrefRangeEnd = 706743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderAvatarImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderAvatarImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderAvatarImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00009AE9 File Offset: 0x00007CE9
		public WormLeaderAvatarImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00044000 File Offset: 0x00042200
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00009AF2 File Offset: 0x00007CF2
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00044028 File Offset: 0x00042228
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00009B11 File Offset: 0x00007D11
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00044050 File Offset: 0x00042250
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00009B30 File Offset: 0x00007D30
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00044080 File Offset: 0x00042280
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00009B4F File Offset: 0x00007D4F
		public unsafe WormEntities wormEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_wormEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAvatarImageRenderer.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
