using System;
using boardgames.data;
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
	// Token: 0x02000107 RID: 263
	public class WormColorPipSubscriberRenderer : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06000BBF RID: 3007 RVA: 0x0003BA68 File Offset: 0x00039C68
		// Note: this type is marked as 'beforefieldinit'.
		static WormColorPipSubscriberRenderer()
		{
			Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormColorPipSubscriberRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr);
			WormColorPipSubscriberRenderer.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, "sprite");
			WormColorPipSubscriberRenderer.NativeFieldInfoPtr_colorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, "colorMap");
			WormColorPipSubscriberRenderer.NativeFieldInfoPtr_playerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, "playerType");
			WormColorPipSubscriberRenderer.NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, 100664911);
			WormColorPipSubscriberRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, 100664912);
			WormColorPipSubscriberRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, 100664913);
			WormColorPipSubscriberRenderer.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, 100664914);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003BB24 File Offset: 0x00039D24
		public unsafe override ulong version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorPipSubscriberRenderer.NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0003BB6C File Offset: 0x00039D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703619, XrefRangeEnd = 703638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorPipSubscriberRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0003BBA8 File Offset: 0x00039DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703638, XrefRangeEnd = 703648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorPipSubscriberRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorPipSubscriberRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0003BBE4 File Offset: 0x00039DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703648, XrefRangeEnd = 703650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__6_0(WormColorPipSubscriberRenderer.ColorPair pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorPipSubscriberRenderer.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0000832B File Offset: 0x0000652B
		public WormColorPipSubscriberRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0003BC38 File Offset: 0x00039E38
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00008334 File Offset: 0x00006534
		public unsafe Image sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0003BC68 File Offset: 0x00039E68
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00008353 File Offset: 0x00006553
		public unsafe List<WormColorPipSubscriberRenderer.ColorPair> colorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_colorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormColorPipSubscriberRenderer.ColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_colorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0003BC98 File Offset: 0x00039E98
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00008372 File Offset: 0x00006572
		public unsafe PlayerTypeData playerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_playerType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.NativeFieldInfoPtr_playerType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_colorMap;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_playerType;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ColorPair_0;

		// Token: 0x02000369 RID: 873
		[Serializable]
		public sealed class ColorPair : ValueType
		{
			// Token: 0x0600232C RID: 9004 RVA: 0x00082EA4 File Offset: 0x000810A4
			// Note: this type is marked as 'beforefieldinit'.
			static ColorPair()
			{
				Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormColorPipSubscriberRenderer>.NativeClassPtr, "ColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr);
				WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr, "PieceColor");
				WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr, "sprite");
				WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_aiSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr, "aiSprite");
			}

			// Token: 0x0600232D RID: 9005 RVA: 0x00013A40 File Offset: 0x00011C40
			public ColorPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600232E RID: 9006 RVA: 0x00013A49 File Offset: 0x00011C49
			public ColorPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorPipSubscriberRenderer.ColorPair>.NativeClassPtr))
			{
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x0600232F RID: 9007 RVA: 0x00082F0C File Offset: 0x0008110C
			// (set) Token: 0x06002330 RID: 9008 RVA: 0x00013A5B File Offset: 0x00011C5B
			public unsafe PieceColor PieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_PieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_PieceColor)) = value;
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x06002331 RID: 9009 RVA: 0x00082F34 File Offset: 0x00081134
			// (set) Token: 0x06002332 RID: 9010 RVA: 0x00013A76 File Offset: 0x00011C76
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06002333 RID: 9011 RVA: 0x00082F64 File Offset: 0x00081164
			// (set) Token: 0x06002334 RID: 9012 RVA: 0x00013A95 File Offset: 0x00011C95
			public unsafe Sprite aiSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_aiSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorPipSubscriberRenderer.ColorPair.NativeFieldInfoPtr_aiSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001437 RID: 5175
			private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

			// Token: 0x04001438 RID: 5176
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04001439 RID: 5177
			private static readonly IntPtr NativeFieldInfoPtr_aiSprite;
		}
	}
}
