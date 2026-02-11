using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000071 RID: 113
	public class PlaymatPileDataProvider : EntityViewDataProvider
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x0001F314 File Offset: 0x0001D514
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatPileDataProvider()
		{
			Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PlaymatPileDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr);
			PlaymatPileDataProvider.NativeFieldInfoPtr_pileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr, "pileName");
			PlaymatPileDataProvider.NativeFieldInfoPtr_disableIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr, "disableIfNull");
			PlaymatPileDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr, 100664204);
			PlaymatPileDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr, 100664205);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001F394 File Offset: 0x0001D594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113219, XrefRangeEnd = 1113227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPileDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113227, XrefRangeEnd = 1113231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatPileDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPileDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPileDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000053F3 File Offset: 0x000035F3
		public PlaymatPileDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001F42C File Offset: 0x0001D62C
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x000053FC File Offset: 0x000035FC
		public unsafe string pileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileDataProvider.NativeFieldInfoPtr_pileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileDataProvider.NativeFieldInfoPtr_pileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001F454 File Offset: 0x0001D654
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0000541B File Offset: 0x0000361B
		public unsafe bool disableIfNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileDataProvider.NativeFieldInfoPtr_disableIfNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileDataProvider.NativeFieldInfoPtr_disableIfNull)) = value;
			}
		}

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_pileName;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_disableIfNull;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
