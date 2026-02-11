using System;
using Canis.attributes;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.attributes.providers
{
	// Token: 0x0200016F RID: 367
	public class LocalPlayerAttributesProvider : MonoBehaviour
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x0004A298 File Offset: 0x00048498
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerAttributesProvider()
		{
			Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "LocalPlayerAttributesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr);
			LocalPlayerAttributesProvider.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr, "entitiesProvider");
			LocalPlayerAttributesProvider.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr, "localPlayer");
			LocalPlayerAttributesProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr, 100666014);
			LocalPlayerAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr, 100666015);
			LocalPlayerAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr, 100666016);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0004A32C File Offset: 0x0004852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001021, XrefRangeEnd = 1001024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerAttributesProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0004A360 File Offset: 0x00048560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001024, XrefRangeEnd = 1001032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0004A3A0 File Offset: 0x000485A0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerAttributesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerAttributesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000AA71 File Offset: 0x00008C71
		public LocalPlayerAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0004A3DC File Offset: 0x000485DC
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x0000AA7A File Offset: 0x00008C7A
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerAttributesProvider.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerAttributesProvider.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x0004A40C File Offset: 0x0004860C
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x0000AA99 File Offset: 0x00008C99
		public unsafe EntityComponent localPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerAttributesProvider.NativeFieldInfoPtr_localPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerAttributesProvider.NativeFieldInfoPtr_localPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_localPlayer;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
