using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x02000167 RID: 359
	public class WormStingerChosenArchetypeRenderer : Observer
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x000483D0 File Offset: 0x000465D0
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerChosenArchetypeRenderer()
		{
			Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormStingerChosenArchetypeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr);
			WormStingerChosenArchetypeRenderer.NativeFieldInfoPtr_chosenArchetypeView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr, "chosenArchetypeView");
			WormStingerChosenArchetypeRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr, 100665475);
			WormStingerChosenArchetypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr, 100665476);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0004843C File Offset: 0x0004663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708905, XrefRangeEnd = 708930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerChosenArchetypeRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00048478 File Offset: 0x00046678
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerChosenArchetypeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerChosenArchetypeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerChosenArchetypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0000A6FD File Offset: 0x000088FD
		public WormStingerChosenArchetypeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000484B4 File Offset: 0x000466B4
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x0000A706 File Offset: 0x00008906
		public unsafe EntityView chosenArchetypeView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerChosenArchetypeRenderer.NativeFieldInfoPtr_chosenArchetypeView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerChosenArchetypeRenderer.NativeFieldInfoPtr_chosenArchetypeView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_chosenArchetypeView;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
