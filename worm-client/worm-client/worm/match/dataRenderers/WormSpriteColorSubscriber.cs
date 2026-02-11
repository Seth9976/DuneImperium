using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000166 RID: 358
	public class WormSpriteColorSubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x00048278 File Offset: 0x00046478
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpriteColorSubscriber()
		{
			Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSpriteColorSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr);
			WormSpriteColorSubscriber.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr, "spriteRenderer");
			WormSpriteColorSubscriber.NativeFieldInfoPtr_colorPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr, "colorPairs");
			WormSpriteColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr, 100665473);
			WormSpriteColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr, 100665474);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000482F8 File Offset: 0x000464F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708876, XrefRangeEnd = 708895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpriteColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00048334 File Offset: 0x00046534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708895, XrefRangeEnd = 708905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpriteColorSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpriteColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0000A6B6 File Offset: 0x000088B6
		public WormSpriteColorSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00048370 File Offset: 0x00046570
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x0000A6BF File Offset: 0x000088BF
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorSubscriber.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorSubscriber.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x000483A0 File Offset: 0x000465A0
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x0000A6DE File Offset: 0x000088DE
		public unsafe List<WormSpriteColorSubscriber.ColorPair> colorPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorSubscriber.NativeFieldInfoPtr_colorPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormSpriteColorSubscriber.ColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpriteColorSubscriber.NativeFieldInfoPtr_colorPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_colorPairs;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AE RID: 942
		[Serializable]
		[StructLayout(2)]
		public struct ColorPair
		{
			// Token: 0x060025E3 RID: 9699 RVA: 0x0008A6E0 File Offset: 0x000888E0
			// Note: this type is marked as 'beforefieldinit'.
			static ColorPair()
			{
				Il2CppClassPointerStore<WormSpriteColorSubscriber.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpriteColorSubscriber>.NativeClassPtr, "ColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpriteColorSubscriber.ColorPair>.NativeClassPtr);
				WormSpriteColorSubscriber.ColorPair.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorSubscriber.ColorPair>.NativeClassPtr, "pieceColor");
				WormSpriteColorSubscriber.ColorPair.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpriteColorSubscriber.ColorPair>.NativeClassPtr, "color");
			}

			// Token: 0x060025E4 RID: 9700 RVA: 0x00015129 File Offset: 0x00013329
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormSpriteColorSubscriber.ColorPair>.NativeClassPtr, ref this));
			}

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040015BB RID: 5563
			[FieldOffset(0)]
			public PieceColor pieceColor;

			// Token: 0x040015BC RID: 5564
			[FieldOffset(4)]
			public Color color;
		}
	}
}
