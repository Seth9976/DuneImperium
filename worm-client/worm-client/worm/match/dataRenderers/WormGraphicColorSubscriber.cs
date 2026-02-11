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
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000132 RID: 306
	public class WormGraphicColorSubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06000DC5 RID: 3525 RVA: 0x00041AF8 File Offset: 0x0003FCF8
		// Note: this type is marked as 'beforefieldinit'.
		static WormGraphicColorSubscriber()
		{
			Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGraphicColorSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr);
			WormGraphicColorSubscriber.NativeFieldInfoPtr_colorPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, "colorPairs");
			WormGraphicColorSubscriber.NativeFieldInfoPtr_graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, "graphic");
			WormGraphicColorSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, 100665160);
			WormGraphicColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, 100665161);
			WormGraphicColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, 100665162);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00041B8C File Offset: 0x0003FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705911, XrefRangeEnd = 705916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGraphicColorSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705916, XrefRangeEnd = 705934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGraphicColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00041C04 File Offset: 0x0003FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705934, XrefRangeEnd = 705944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGraphicColorSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraphicColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000942B File Offset: 0x0000762B
		public WormGraphicColorSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00041C40 File Offset: 0x0003FE40
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00009434 File Offset: 0x00007634
		public unsafe List<WormGraphicColorSubscriber.ColorPair> colorPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraphicColorSubscriber.NativeFieldInfoPtr_colorPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormGraphicColorSubscriber.ColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraphicColorSubscriber.NativeFieldInfoPtr_colorPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00041C70 File Offset: 0x0003FE70
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00009453 File Offset: 0x00007653
		public unsafe Graphic graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraphicColorSubscriber.NativeFieldInfoPtr_graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraphicColorSubscriber.NativeFieldInfoPtr_graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_colorPairs;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_graphic;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000387 RID: 903
		[Serializable]
		[StructLayout(2)]
		public struct ColorPair
		{
			// Token: 0x0600244F RID: 9295 RVA: 0x00085EA4 File Offset: 0x000840A4
			// Note: this type is marked as 'beforefieldinit'.
			static ColorPair()
			{
				Il2CppClassPointerStore<WormGraphicColorSubscriber.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGraphicColorSubscriber>.NativeClassPtr, "ColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGraphicColorSubscriber.ColorPair>.NativeClassPtr);
				WormGraphicColorSubscriber.ColorPair.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGraphicColorSubscriber.ColorPair>.NativeClassPtr, "pieceColor");
				WormGraphicColorSubscriber.ColorPair.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGraphicColorSubscriber.ColorPair>.NativeClassPtr, "color");
			}

			// Token: 0x06002450 RID: 9296 RVA: 0x00014459 File Offset: 0x00012659
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormGraphicColorSubscriber.ColorPair>.NativeClassPtr, ref this));
			}

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040014CE RID: 5326
			[FieldOffset(0)]
			public PieceColor pieceColor;

			// Token: 0x040014CF RID: 5327
			[FieldOffset(4)]
			public Color color;
		}
	}
}
