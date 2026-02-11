using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public sealed class SpriteState : ValueType
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x00023768 File Offset: 0x00021968
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteState()
		{
			Il2CppClassPointerStore<SpriteState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "SpriteState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteState>.NativeClassPtr);
			SpriteState.NativeFieldInfoPtr_m_HighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_HighlightedSprite");
			SpriteState.NativeFieldInfoPtr_m_PressedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_PressedSprite");
			SpriteState.NativeFieldInfoPtr_m_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_SelectedSprite");
			SpriteState.NativeFieldInfoPtr_m_DisabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_DisabledSprite");
			SpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664465);
			SpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664466);
			SpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664467);
			SpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664468);
			SpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664469);
			SpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664470);
			SpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664471);
			SpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664472);
			SpriteState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664473);
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0002389C File Offset: 0x00021A9C
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x000238E0 File Offset: 0x00021AE0
		public unsafe Sprite highlightedSprite
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00023928 File Offset: 0x00021B28
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0002396C File Offset: 0x00021B6C
		public unsafe Sprite pressedSprite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x000239B4 File Offset: 0x00021BB4
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x000239F8 File Offset: 0x00021BF8
		public unsafe Sprite selectedSprite
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00023A40 File Offset: 0x00021C40
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00023A84 File Offset: 0x00021C84
		public unsafe Sprite disabledSprite
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00023ACC File Offset: 0x00021CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092396, XrefRangeEnd = 1092409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SpriteState other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00004840 File Offset: 0x00002A40
		public SpriteState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004849 File Offset: 0x00002A49
		public SpriteState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteState>.NativeClassPtr))
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00023B24 File Offset: 0x00021D24
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0000485B File Offset: 0x00002A5B
		public unsafe Sprite m_HighlightedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_HighlightedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_HighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00023B54 File Offset: 0x00021D54
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0000487A File Offset: 0x00002A7A
		public unsafe Sprite m_PressedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_PressedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_PressedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00023B84 File Offset: 0x00021D84
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00004899 File Offset: 0x00002A99
		public unsafe Sprite m_SelectedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_SelectedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_SelectedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00023BB4 File Offset: 0x00021DB4
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000048B8 File Offset: 0x00002AB8
		public unsafe Sprite m_DisabledSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_DisabledSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_DisabledSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedSprite;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedSprite;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedSprite;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_m_DisabledSprite;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0;
	}
}
