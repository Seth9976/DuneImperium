using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000165 RID: 357
	public class WormSpriteColorRenderer : WormColorRenderer
	{
		// Token: 0x06000FF7 RID: 4087 RVA: 0x000480B8 File Offset: 0x000462B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpriteColorRenderer()
		{
			Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSpriteColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr);
			WormSpriteColorRenderer.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, "sprite");
			WormSpriteColorRenderer.NativeFieldInfoPtr_colorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, "colorMap");
			WormSpriteColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, 100665470);
			WormSpriteColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, 100665471);
			WormSpriteColorRenderer.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, 100665472);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004814C File Offset: 0x0004634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708854, XrefRangeEnd = 708868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpriteColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00048188 File Offset: 0x00046388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708868, XrefRangeEnd = 708876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpriteColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpriteColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x000481C4 File Offset: 0x000463C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__3_0(WormSpriteColorRenderer.ColorPair pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpriteColorRenderer.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0000A66F File Offset: 0x0000886F
		public WormSpriteColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00048218 File Offset: 0x00046418
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0000A678 File Offset: 0x00008878
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00048248 File Offset: 0x00046448
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0000A697 File Offset: 0x00008897
		public unsafe List<WormSpriteColorRenderer.ColorPair> colorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.NativeFieldInfoPtr_colorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormSpriteColorRenderer.ColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.NativeFieldInfoPtr_colorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_colorMap;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_ColorPair_0;

		// Token: 0x020003AD RID: 941
		[Serializable]
		public sealed class ColorPair : ValueType
		{
			// Token: 0x060025DC RID: 9692 RVA: 0x0008A634 File Offset: 0x00088834
			// Note: this type is marked as 'beforefieldinit'.
			static ColorPair()
			{
				Il2CppClassPointerStore<WormSpriteColorRenderer.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpriteColorRenderer>.NativeClassPtr, "ColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpriteColorRenderer.ColorPair>.NativeClassPtr);
				WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorRenderer.ColorPair>.NativeClassPtr, "PieceColor");
				WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorRenderer.ColorPair>.NativeClassPtr, "sprite");
			}

			// Token: 0x060025DD RID: 9693 RVA: 0x000150D4 File Offset: 0x000132D4
			public ColorPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060025DE RID: 9694 RVA: 0x000150DD File Offset: 0x000132DD
			public ColorPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpriteColorRenderer.ColorPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x060025DF RID: 9695 RVA: 0x0008A688 File Offset: 0x00088888
			// (set) Token: 0x060025E0 RID: 9696 RVA: 0x000150EF File Offset: 0x000132EF
			public unsafe PieceColor PieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_PieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_PieceColor)) = value;
				}
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0008A6B0 File Offset: 0x000888B0
			// (set) Token: 0x060025E2 RID: 9698 RVA: 0x0001510A File Offset: 0x0001330A
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorRenderer.ColorPair.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeFieldInfoPtr_sprite;
		}
	}
}
