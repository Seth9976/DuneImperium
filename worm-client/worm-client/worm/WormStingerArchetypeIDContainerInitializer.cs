using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.boardgames.src.match;
using worm.match.components.stingers;

namespace worm
{
	// Token: 0x0200003C RID: 60
	public class WormStingerArchetypeIDContainerInitializer : WormStingerContainerInitializer
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00021000 File Offset: 0x0001F200
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerArchetypeIDContainerInitializer()
		{
			Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormStingerArchetypeIDContainerInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr);
			WormStingerArchetypeIDContainerInitializer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr, "archetypeProvider");
			WormStingerArchetypeIDContainerInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr, 100663733);
			WormStingerArchetypeIDContainerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr, 100663734);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0002106C File Offset: 0x0001F26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690523, XrefRangeEnd = 690560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerArchetypeIDContainerInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000210BC File Offset: 0x0001F2BC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerArchetypeIDContainerInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerArchetypeIDContainerInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerArchetypeIDContainerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000339F File Offset: 0x0000159F
		public WormStingerArchetypeIDContainerInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000210F8 File Offset: 0x0001F2F8
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000033A8 File Offset: 0x000015A8
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDContainerInitializer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDContainerInitializer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
