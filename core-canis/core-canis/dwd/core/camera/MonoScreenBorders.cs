using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.camera
{
	// Token: 0x020000A4 RID: 164
	public sealed class MonoScreenBorders : MonoBehaviour
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x0003D694 File Offset: 0x0003B894
		// Note: this type is marked as 'beforefieldinit'.
		static MonoScreenBorders()
		{
			Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.camera", "MonoScreenBorders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr);
			MonoScreenBorders.NativeFieldInfoPtr_innerScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "innerScreen");
			MonoScreenBorders.NativeFieldInfoPtr_LeftBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "LeftBorder");
			MonoScreenBorders.NativeFieldInfoPtr_TopBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "TopBorder");
			MonoScreenBorders.NativeFieldInfoPtr_RightBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "RightBorder");
			MonoScreenBorders.NativeFieldInfoPtr_BottomBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "BottomBorder");
			MonoScreenBorders.NativeFieldInfoPtr_GizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, "GizmoColor");
			MonoScreenBorders.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664832);
			MonoScreenBorders.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664833);
			MonoScreenBorders.NativeMethodInfoPtr_applyFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664834);
			MonoScreenBorders.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664835);
			MonoScreenBorders.NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664836);
			MonoScreenBorders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr, 100664837);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		public unsafe Camera Camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863396, XrefRangeEnd = 863414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003D828 File Offset: 0x0003BA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863438, RefRangeEnd = 863440, XrefRangeStart = 863414, XrefRangeEnd = 863438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void applyFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr_applyFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0003D85C File Offset: 0x0003BA5C
		public unsafe ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863440, XrefRangeEnd = 863442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0003D898 File Offset: 0x0003BA98
		public unsafe ScreenRect Rect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863442, XrefRangeEnd = 863444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863444, XrefRangeEnd = 863450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoScreenBorders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoScreenBorders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoScreenBorders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00005DDE File Offset: 0x00003FDE
		public MonoScreenBorders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003D910 File Offset: 0x0003BB10
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00005DE7 File Offset: 0x00003FE7
		public unsafe ScreenBorders innerScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_innerScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenBorders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_innerScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003D940 File Offset: 0x0003BB40
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00005E06 File Offset: 0x00004006
		public unsafe float LeftBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_LeftBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_LeftBorder)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003D968 File Offset: 0x0003BB68
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00005E21 File Offset: 0x00004021
		public unsafe float TopBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_TopBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_TopBorder)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0003D990 File Offset: 0x0003BB90
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00005E3C File Offset: 0x0000403C
		public unsafe float RightBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_RightBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_RightBorder)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003D9B8 File Offset: 0x0003BBB8
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00005E57 File Offset: 0x00004057
		public unsafe float BottomBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_BottomBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_BottomBorder)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003D9E0 File Offset: 0x0003BBE0
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00005E72 File Offset: 0x00004072
		public unsafe Color GizmoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_GizmoColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoScreenBorders.NativeFieldInfoPtr_GizmoColor)) = value;
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_innerScreen;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_LeftBorder;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_TopBorder;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_RightBorder;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_BottomBorder;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_GizmoColor;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_get_Camera_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_applyFields_Private_Void_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
