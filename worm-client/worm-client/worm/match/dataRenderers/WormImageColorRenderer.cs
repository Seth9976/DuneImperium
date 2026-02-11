using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013D RID: 317
	public class WormImageColorRenderer : WormColorRenderer
	{
		// Token: 0x06000E43 RID: 3651 RVA: 0x000431DC File Offset: 0x000413DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormImageColorRenderer()
		{
			Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormImageColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr);
			WormImageColorRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, "image");
			WormImageColorRenderer.NativeFieldInfoPtr_colorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, "colorMap");
			WormImageColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, 100665232);
			WormImageColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, 100665233);
			WormImageColorRenderer.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, 100665234);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00043270 File Offset: 0x00041470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706417, XrefRangeEnd = 706430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImageColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000432AC File Offset: 0x000414AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706430, XrefRangeEnd = 706440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImageColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImageColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000432E8 File Offset: 0x000414E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706440, XrefRangeEnd = 706441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__3_0(WormImageColorRenderer.ColorPair pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pair;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImageColorRenderer.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00009810 File Offset: 0x00007A10
		public WormImageColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00043334 File Offset: 0x00041534
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00009819 File Offset: 0x00007A19
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImageColorRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImageColorRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00043364 File Offset: 0x00041564
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00009838 File Offset: 0x00007A38
		public unsafe List<WormImageColorRenderer.ColorPair> colorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImageColorRenderer.NativeFieldInfoPtr_colorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormImageColorRenderer.ColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImageColorRenderer.NativeFieldInfoPtr_colorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_colorMap;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0;

		// Token: 0x0200038F RID: 911
		[Serializable]
		[StructLayout(2)]
		public struct ColorPair
		{
			// Token: 0x060024A1 RID: 9377 RVA: 0x00086E40 File Offset: 0x00085040
			// Note: this type is marked as 'beforefieldinit'.
			static ColorPair()
			{
				Il2CppClassPointerStore<WormImageColorRenderer.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormImageColorRenderer>.NativeClassPtr, "ColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImageColorRenderer.ColorPair>.NativeClassPtr);
				WormImageColorRenderer.ColorPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImageColorRenderer.ColorPair>.NativeClassPtr, "PieceColor");
				WormImageColorRenderer.ColorPair.NativeFieldInfoPtr_ImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImageColorRenderer.ColorPair>.NativeClassPtr, "ImageColor");
			}

			// Token: 0x060024A2 RID: 9378 RVA: 0x000146EC File Offset: 0x000128EC
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormImageColorRenderer.ColorPair>.NativeClassPtr, ref this));
			}

			// Token: 0x04001505 RID: 5381
			private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

			// Token: 0x04001506 RID: 5382
			private static readonly IntPtr NativeFieldInfoPtr_ImageColor;

			// Token: 0x04001507 RID: 5383
			[FieldOffset(0)]
			public PieceColor PieceColor;

			// Token: 0x04001508 RID: 5384
			[FieldOffset(4)]
			public Color ImageColor;
		}
	}
}
