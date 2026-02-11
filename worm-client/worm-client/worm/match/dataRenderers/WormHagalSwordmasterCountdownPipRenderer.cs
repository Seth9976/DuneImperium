using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000134 RID: 308
	public class WormHagalSwordmasterCountdownPipRenderer : VersionedView<IAttribute<Nullable<int>>>
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00041E40 File Offset: 0x00040040
		// Note: this type is marked as 'beforefieldinit'.
		static WormHagalSwordmasterCountdownPipRenderer()
		{
			Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHagalSwordmasterCountdownPipRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr);
			WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_doneRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "doneRound");
			WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "colors");
			WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_currentColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "currentColors");
			WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "sprite");
			WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, 100665166);
			WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, 100665167);
			WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_Event_UpdateColor_Public_Void_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, 100665168);
			WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, 100665169);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00041F10 File Offset: 0x00040110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705962, XrefRangeEnd = 705978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00041F4C File Offset: 0x0004014C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705978, XrefRangeEnd = 705990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00041F88 File Offset: 0x00040188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 706004, RefRangeEnd = 706005, XrefRangeStart = 705990, XrefRangeEnd = 706004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateColor(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr_Event_UpdateColor_Public_Void_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00041FC8 File Offset: 0x000401C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706005, XrefRangeEnd = 706015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHagalSwordmasterCountdownPipRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownPipRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000094B9 File Offset: 0x000076B9
		public WormHagalSwordmasterCountdownPipRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00042004 File Offset: 0x00040204
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000094C2 File Offset: 0x000076C2
		public unsafe int doneRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_doneRound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_doneRound)) = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0004202C File Offset: 0x0004022C
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x000094DD File Offset: 0x000076DD
		public unsafe Il2CppStructArray<WormHagalSwordmasterCountdownPipRenderer.ColorSet> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WormHagalSwordmasterCountdownPipRenderer.ColorSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0004205C File Offset: 0x0004025C
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x000094FC File Offset: 0x000076FC
		public unsafe WormHagalSwordmasterCountdownPipRenderer.ColorSet currentColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_currentColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_currentColors)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00042084 File Offset: 0x00040284
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00009517 File Offset: 0x00007717
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_doneRound;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_currentColors;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateColor_Public_Void_PieceColor_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000388 RID: 904
		[Serializable]
		[StructLayout(2)]
		public struct ColorSet
		{
			// Token: 0x06002451 RID: 9297 RVA: 0x00085EF8 File Offset: 0x000840F8
			// Note: this type is marked as 'beforefieldinit'.
			static ColorSet()
			{
				Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "ColorSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr);
				WormHagalSwordmasterCountdownPipRenderer.ColorSet.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr, "pieceColor");
				WormHagalSwordmasterCountdownPipRenderer.ColorSet.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr, "color");
				WormHagalSwordmasterCountdownPipRenderer.ColorSet.NativeFieldInfoPtr_doneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr, "doneColor");
			}

			// Token: 0x06002452 RID: 9298 RVA: 0x0001446B File Offset: 0x0001266B
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.ColorSet>.NativeClassPtr, ref this));
			}

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeFieldInfoPtr_doneColor;

			// Token: 0x040014D3 RID: 5331
			[FieldOffset(0)]
			public PieceColor pieceColor;

			// Token: 0x040014D4 RID: 5332
			[FieldOffset(4)]
			public Color color;

			// Token: 0x040014D5 RID: 5333
			[FieldOffset(20)]
			public Color doneColor;
		}

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("worm.match.dataRenderers.WormHagalSwordmasterCountdownPipRenderer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002453 RID: 9299 RVA: 0x00085F60 File Offset: 0x00084160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr);
				WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr, "color");
				WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665170);
				WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_UpdateColor_b__0_Internal_Boolean_ColorSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665171);
			}

			// Token: 0x06002454 RID: 9300 RVA: 0x00085FC8 File Offset: 0x000841C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002455 RID: 9301 RVA: 0x00086004 File Offset: 0x00084204
			[CallerCount(0)]
			public unsafe bool _Event_UpdateColor_b__0(WormHagalSwordmasterCountdownPipRenderer.ColorSet c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_UpdateColor_b__0_Internal_Boolean_ColorSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002456 RID: 9302 RVA: 0x0001447D File Offset: 0x0001267D
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06002457 RID: 9303 RVA: 0x00086050 File Offset: 0x00084250
			// (set) Token: 0x06002458 RID: 9304 RVA: 0x00014486 File Offset: 0x00012686
			public unsafe PieceColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownPipRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeMethodInfoPtr__Event_UpdateColor_b__0_Internal_Boolean_ColorSet_0;
		}
	}
}
