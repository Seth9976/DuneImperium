using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.ui
{
	// Token: 0x02000126 RID: 294
	public class ZipperLayout : LayoutGroup
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x0003F000 File Offset: 0x0003D200
		// Note: this type is marked as 'beforefieldinit'.
		static ZipperLayout()
		{
			Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "ZipperLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr);
			ZipperLayout.NativeFieldInfoPtr_rowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, "rowHeight");
			ZipperLayout.NativeFieldInfoPtr_staggerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, "staggerSize");
			ZipperLayout.NativeFieldInfoPtr_beginStaggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, "beginStaggered");
			ZipperLayout.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665451);
			ZipperLayout.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665452);
			ZipperLayout.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665453);
			ZipperLayout.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665454);
			ZipperLayout.NativeMethodInfoPtr_setHorizontalLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665455);
			ZipperLayout.NativeMethodInfoPtr_setVerticalLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665456);
			ZipperLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr, 100665457);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997126, XrefRangeEnd = 997127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZipperLayout.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0003F134 File Offset: 0x0003D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997127, XrefRangeEnd = 997135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZipperLayout.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003F170 File Offset: 0x0003D370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997135, XrefRangeEnd = 997145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZipperLayout.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0003F1AC File Offset: 0x0003D3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997145, XrefRangeEnd = 997154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZipperLayout.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setHorizontalLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZipperLayout.NativeMethodInfoPtr_setHorizontalLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0003F21C File Offset: 0x0003D41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setVerticalLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZipperLayout.NativeMethodInfoPtr_setVerticalLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0003F250 File Offset: 0x0003D450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997154, XrefRangeEnd = 997157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZipperLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZipperLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZipperLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000090F1 File Offset: 0x000072F1
		public ZipperLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0003F28C File Offset: 0x0003D48C
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x000090FA File Offset: 0x000072FA
		public unsafe float rowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_rowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_rowHeight)) = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00009115 File Offset: 0x00007315
		public unsafe Vector2 staggerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_staggerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_staggerSize)) = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00009130 File Offset: 0x00007330
		public unsafe bool beginStaggered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_beginStaggered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZipperLayout.NativeFieldInfoPtr_beginStaggered)) = value;
			}
		}

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_rowHeight;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_staggerSize;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_beginStaggered;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_setHorizontalLayout_Private_Void_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_setVerticalLayout_Private_Void_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
