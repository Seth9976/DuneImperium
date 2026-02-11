using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class SerializedVirtualizationData : Object
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x000347C4 File Offset: 0x000329C4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedVirtualizationData()
		{
			Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SerializedVirtualizationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr);
			SerializedVirtualizationData.NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "scrollOffset");
			SerializedVirtualizationData.NativeFieldInfoPtr_firstVisibleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "firstVisibleIndex");
			SerializedVirtualizationData.NativeFieldInfoPtr_contentPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "contentPadding");
			SerializedVirtualizationData.NativeFieldInfoPtr_contentHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "contentHeight");
			SerializedVirtualizationData.NativeFieldInfoPtr_anchoredItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "anchoredItemIndex");
			SerializedVirtualizationData.NativeFieldInfoPtr_anchorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, "anchorOffset");
			SerializedVirtualizationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr, 100664159);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00034880 File Offset: 0x00032A80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedVirtualizationData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedVirtualizationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedVirtualizationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000402D File Offset: 0x0000222D
		public SerializedVirtualizationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000348BC File Offset: 0x00032ABC
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00004036 File Offset: 0x00002236
		public unsafe Vector2 scrollOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_scrollOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_scrollOffset)) = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000348E4 File Offset: 0x00032AE4
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00004051 File Offset: 0x00002251
		public unsafe int firstVisibleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_firstVisibleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_firstVisibleIndex)) = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0003490C File Offset: 0x00032B0C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x0000406C File Offset: 0x0000226C
		public unsafe float contentPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_contentPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_contentPadding)) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00034934 File Offset: 0x00032B34
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00004087 File Offset: 0x00002287
		public unsafe float contentHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_contentHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_contentHeight)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0003495C File Offset: 0x00032B5C
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000040A2 File Offset: 0x000022A2
		public unsafe int anchoredItemIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_anchoredItemIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_anchoredItemIndex)) = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00034984 File Offset: 0x00032B84
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x000040BD File Offset: 0x000022BD
		public unsafe float anchorOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_anchorOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedVirtualizationData.NativeFieldInfoPtr_anchorOffset)) = value;
			}
		}

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_scrollOffset;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleIndex;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_contentPadding;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_contentHeight;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_anchoredItemIndex;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_anchorOffset;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
