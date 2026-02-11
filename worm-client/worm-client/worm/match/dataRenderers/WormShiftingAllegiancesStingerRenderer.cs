using System;
using boardgames.match;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015D RID: 349
	public class WormShiftingAllegiancesStingerRenderer : Observer
	{
		// Token: 0x06000F9A RID: 3994 RVA: 0x00046F8C File Offset: 0x0004518C
		// Note: this type is marked as 'beforefieldinit'.
		static WormShiftingAllegiancesStingerRenderer()
		{
			Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormShiftingAllegiancesStingerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr);
			WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_loseView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, "loseView");
			WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_gainView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, "gainView");
			WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, "entities");
			WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempLoseEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, "tempLoseEntity");
			WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempGainEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, "tempGainEntity");
			WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, 100665411);
			WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, 100665412);
			WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr, 100665413);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004705C File Offset: 0x0004525C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707957, XrefRangeEnd = 708056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00047098 File Offset: 0x00045298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708056, XrefRangeEnd = 708058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000470CC File Offset: 0x000452CC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShiftingAllegiancesStingerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesStingerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0000A376 File Offset: 0x00008576
		public WormShiftingAllegiancesStingerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00047108 File Offset: 0x00045308
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0000A37F File Offset: 0x0000857F
		public unsafe EntityView loseView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_loseView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_loseView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00047138 File Offset: 0x00045338
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0000A39E File Offset: 0x0000859E
		public unsafe EntityView gainView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_gainView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_gainView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00047168 File Offset: 0x00045368
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0000A3BD File Offset: 0x000085BD
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00047198 File Offset: 0x00045398
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0000A3DC File Offset: 0x000085DC
		public unsafe EntityComponent tempLoseEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempLoseEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempLoseEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000471C8 File Offset: 0x000453C8
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x0000A3FB File Offset: 0x000085FB
		public unsafe EntityComponent tempGainEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempGainEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesStingerRenderer.NativeFieldInfoPtr_tempGainEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_loseView;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_gainView;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_tempLoseEntity;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_tempGainEntity;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
