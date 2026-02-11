using System;
using boardgames.match;
using Canis.attributes;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x02000229 RID: 553
	public class WormStingerContainerInitializer : MonoBehaviour
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x000617B0 File Offset: 0x0005F9B0
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerContainerInitializer()
		{
			Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerContainerInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr);
			WormStingerContainerInitializer.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, "container");
			WormStingerContainerInitializer.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, "tempPile");
			WormStingerContainerInitializer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, "entities");
			WormStingerContainerInitializer.NativeMethodInfoPtr_get_Entities_Protected_get_DBGEntities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, 100666650);
			WormStingerContainerInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, 100666651);
			WormStingerContainerInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, 100666652);
			WormStingerContainerInitializer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, 100666653);
			WormStingerContainerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr, 100666654);
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00061880 File Offset: 0x0005FA80
		public unsafe DBGEntities Entities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718088, XrefRangeEnd = 718093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerContainerInitializer.NativeMethodInfoPtr_get_Entities_Protected_get_DBGEntities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr3) : null;
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000618C0 File Offset: 0x0005FAC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 718133, RefRangeEnd = 718137, XrefRangeStart = 718093, XrefRangeEnd = 718133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerContainerInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_New_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00061910 File Offset: 0x0005FB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718137, XrefRangeEnd = 718139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerContainerInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00061944 File Offset: 0x0005FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718139, XrefRangeEnd = 718140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerContainerInitializer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00061978 File Offset: 0x0005FB78
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerContainerInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerContainerInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerContainerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0000E5AD File Offset: 0x0000C7AD
		public WormStingerContainerInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x000619B4 File Offset: 0x0005FBB4
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0000E5B6 File Offset: 0x0000C7B6
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x000619E4 File Offset: 0x0005FBE4
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000E5D5 File Offset: 0x0000C7D5
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00061A14 File Offset: 0x0005FC14
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerContainerInitializer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Protected_get_DBGEntities_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_New_Void_IHasAttributes_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
