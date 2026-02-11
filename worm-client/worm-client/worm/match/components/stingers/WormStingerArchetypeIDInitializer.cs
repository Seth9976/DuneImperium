using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x02000228 RID: 552
	public class WormStingerArchetypeIDInitializer : MonoBehaviour
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x00061608 File Offset: 0x0005F808
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerArchetypeIDInitializer()
		{
			Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerArchetypeIDInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr);
			WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr, "view");
			WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr, "archetypeProvider");
			WormStingerArchetypeIDInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr, 100666647);
			WormStingerArchetypeIDInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr, 100666648);
			WormStingerArchetypeIDInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr, 100666649);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0006169C File Offset: 0x0005F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718067, XrefRangeEnd = 718087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerArchetypeIDInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000616E0 File Offset: 0x0005F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718087, XrefRangeEnd = 718088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerArchetypeIDInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00061714 File Offset: 0x0005F914
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerArchetypeIDInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerArchetypeIDInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerArchetypeIDInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0000E566 File Offset: 0x0000C766
		public WormStingerArchetypeIDInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00061750 File Offset: 0x0005F950
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000E56F File Offset: 0x0000C76F
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00061780 File Offset: 0x0005F980
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0000E58E File Offset: 0x0000C78E
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerArchetypeIDInitializer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
