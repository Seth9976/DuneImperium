using System;
using boardgames.match;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x02000145 RID: 325
	public class WormMasterstrokeStingerRenderer : Observer
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00044384 File Offset: 0x00042584
		// Note: this type is marked as 'beforefieldinit'.
		static WormMasterstrokeStingerRenderer()
		{
			Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormMasterstrokeStingerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr);
			WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, "views");
			WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, "entities");
			WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, "tempEntities");
			WormMasterstrokeStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, 100665274);
			WormMasterstrokeStingerRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, 100665275);
			WormMasterstrokeStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr, 100665276);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0004442C File Offset: 0x0004262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706847, XrefRangeEnd = 706913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMasterstrokeStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00044468 File Offset: 0x00042668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706913, XrefRangeEnd = 706928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMasterstrokeStingerRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0004449C File Offset: 0x0004269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706928, XrefRangeEnd = 706940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMasterstrokeStingerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMasterstrokeStingerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMasterstrokeStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00009B96 File Offset: 0x00007D96
		public WormMasterstrokeStingerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x000444D8 File Offset: 0x000426D8
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00009B9F File Offset: 0x00007D9F
		public unsafe Il2CppReferenceArray<EntityView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00044508 File Offset: 0x00042708
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00009BBE File Offset: 0x00007DBE
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00044538 File Offset: 0x00042738
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00009BDD File Offset: 0x00007DDD
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMasterstrokeStingerRenderer.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
