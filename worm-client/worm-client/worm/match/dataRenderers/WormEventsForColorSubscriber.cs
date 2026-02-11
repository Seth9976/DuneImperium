using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000118 RID: 280
	public class WormEventsForColorSubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003F30C File Offset: 0x0003D50C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForColorSubscriber()
		{
			Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForColorSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr);
			WormEventsForColorSubscriber.NativeFieldInfoPtr_colorEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr, "colorEventPairs");
			WormEventsForColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr, 100665059);
			WormEventsForColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr, 100665060);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0003F378 File Offset: 0x0003D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705000, XrefRangeEnd = 705022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003F3B4 File Offset: 0x0003D5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705022, XrefRangeEnd = 705032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForColorSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00008CFC File Offset: 0x00006EFC
		public WormEventsForColorSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00008D05 File Offset: 0x00006F05
		public unsafe List<WormEventsForColorSubscriber.ColorEventPair> colorEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.NativeFieldInfoPtr_colorEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForColorSubscriber.ColorEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.NativeFieldInfoPtr_colorEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_colorEventPairs;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000379 RID: 889
		[Serializable]
		public sealed class ColorEventPair : ValueType
		{
			// Token: 0x060023C9 RID: 9161 RVA: 0x00084974 File Offset: 0x00082B74
			// Note: this type is marked as 'beforefieldinit'.
			static ColorEventPair()
			{
				Il2CppClassPointerStore<WormEventsForColorSubscriber.ColorEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForColorSubscriber>.NativeClassPtr, "ColorEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForColorSubscriber.ColorEventPair>.NativeClassPtr);
				WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorSubscriber.ColorEventPair>.NativeClassPtr, "PieceColor");
				WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForColorSubscriber.ColorEventPair>.NativeClassPtr, "Event");
			}

			// Token: 0x060023CA RID: 9162 RVA: 0x00013F66 File Offset: 0x00012166
			public ColorEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023CB RID: 9163 RVA: 0x00013F6F File Offset: 0x0001216F
			public ColorEventPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForColorSubscriber.ColorEventPair>.NativeClassPtr))
			{
			}

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x060023CC RID: 9164 RVA: 0x000849C8 File Offset: 0x00082BC8
			// (set) Token: 0x060023CD RID: 9165 RVA: 0x00013F81 File Offset: 0x00012181
			public unsafe PieceColor PieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor)) = value;
				}
			}

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x060023CE RID: 9166 RVA: 0x000849F0 File Offset: 0x00082BF0
			// (set) Token: 0x060023CF RID: 9167 RVA: 0x00013F9C File Offset: 0x0001219C
			public unsafe UnityEvent Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeFieldInfoPtr_Event;
		}
	}
}
