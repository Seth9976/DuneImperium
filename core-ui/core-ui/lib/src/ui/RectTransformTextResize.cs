using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace lib.src.ui
{
	// Token: 0x0200000B RID: 11
	public class RectTransformTextResize : MonoBehaviour
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000040B0 File Offset: 0x000022B0
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformTextResize()
		{
			Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "lib.src.ui", "RectTransformTextResize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr);
			RectTransformTextResize.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, "container");
			RectTransformTextResize.NativeFieldInfoPtr_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, "margin");
			RectTransformTextResize.NativeFieldInfoPtr_tmpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, "tmpText");
			RectTransformTextResize.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, 100663361);
			RectTransformTextResize.NativeMethodInfoPtr_resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, 100663362);
			RectTransformTextResize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr, 100663363);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004158 File Offset: 0x00002358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254018, XrefRangeEnd = 1254026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformTextResize.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000418C File Offset: 0x0000238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254026, XrefRangeEnd = 1254030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformTextResize.NativeMethodInfoPtr_resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000041C0 File Offset: 0x000023C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransformTextResize()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransformTextResize>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformTextResize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002278 File Offset: 0x00000478
		public RectTransformTextResize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000041FC File Offset: 0x000023FC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002281 File Offset: 0x00000481
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000022A0 File Offset: 0x000004A0
		public unsafe float margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_margin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_margin)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004254 File Offset: 0x00002454
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022BB File Offset: 0x000004BB
		public unsafe TMP_Text tmpText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_tmpText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformTextResize.NativeFieldInfoPtr_tmpText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_margin;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_tmpText;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_resize_Private_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
