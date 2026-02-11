using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000117 RID: 279
	public class WormEventsForColorRenderer : WormColorRenderer
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x0003F1B4 File Offset: 0x0003D3B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForColorRenderer()
		{
			Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr);
			WormEventsForColorRenderer.NativeFieldInfoPtr_colorEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr, "colorEventPairs");
			WormEventsForColorRenderer.NativeFieldInfoPtr_currentPieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr, "currentPieceColor");
			WormEventsForColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr, 100665057);
			WormEventsForColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr, 100665058);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003F234 File Offset: 0x0003D434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704967, XrefRangeEnd = 704990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0003F270 File Offset: 0x0003D470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704990, XrefRangeEnd = 705000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00008CA6 File Offset: 0x00006EA6
		public WormEventsForColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0003F2AC File Offset: 0x0003D4AC
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00008CAF File Offset: 0x00006EAF
		public unsafe List<WormEventsForColorRenderer.ColorEventPair> colorEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.NativeFieldInfoPtr_colorEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForColorRenderer.ColorEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.NativeFieldInfoPtr_colorEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00008CCE File Offset: 0x00006ECE
		public Nullable<PieceColor> currentPieceColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.NativeFieldInfoPtr_currentPieceColor);
				return new Nullable<PieceColor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PieceColor>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.NativeFieldInfoPtr_currentPieceColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PieceColor>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_colorEventPairs;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_currentPieceColor;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000378 RID: 888
		[Serializable]
		public sealed class ColorEventPair : ValueType
		{
			// Token: 0x060023C2 RID: 9154 RVA: 0x000848C8 File Offset: 0x00082AC8
			// Note: this type is marked as 'beforefieldinit'.
			static ColorEventPair()
			{
				Il2CppClassPointerStore<WormEventsForColorRenderer.ColorEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForColorRenderer>.NativeClassPtr, "ColorEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForColorRenderer.ColorEventPair>.NativeClassPtr);
				WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorRenderer.ColorEventPair>.NativeClassPtr, "PieceColor");
				WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorRenderer.ColorEventPair>.NativeClassPtr, "Event");
			}

			// Token: 0x060023C3 RID: 9155 RVA: 0x00013F11 File Offset: 0x00012111
			public ColorEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023C4 RID: 9156 RVA: 0x00013F1A File Offset: 0x0001211A
			public ColorEventPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForColorRenderer.ColorEventPair>.NativeClassPtr))
			{
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0008491C File Offset: 0x00082B1C
			// (set) Token: 0x060023C6 RID: 9158 RVA: 0x00013F2C File Offset: 0x0001212C
			public unsafe PieceColor PieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_PieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_PieceColor)) = value;
				}
			}

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x060023C7 RID: 9159 RVA: 0x00084944 File Offset: 0x00082B44
			// (set) Token: 0x060023C8 RID: 9160 RVA: 0x00013F47 File Offset: 0x00012147
			public unsafe UnityEvent Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_Event);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorRenderer.ColorEventPair.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeFieldInfoPtr_Event;
		}
	}
}
