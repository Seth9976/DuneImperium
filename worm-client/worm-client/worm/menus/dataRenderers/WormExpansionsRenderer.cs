using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008F RID: 143
	public class WormExpansionsRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x00029D34 File Offset: 0x00027F34
		// Note: this type is marked as 'beforefieldinit'.
		static WormExpansionsRenderer()
		{
			Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormExpansionsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr);
			WormExpansionsRenderer.NativeFieldInfoPtr_setIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr, "setIcons");
			WormExpansionsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr, 100664109);
			WormExpansionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr, 100664110);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00029DA0 File Offset: 0x00027FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695423, XrefRangeEnd = 695446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormExpansionsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00029DDC File Offset: 0x00027FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695446, XrefRangeEnd = 695449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormExpansionsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormExpansionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004C97 File Offset: 0x00002E97
		public WormExpansionsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00029E18 File Offset: 0x00028018
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public unsafe List<WormExpansionsRenderer.SetIconPair> setIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.NativeFieldInfoPtr_setIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormExpansionsRenderer.SetIconPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.NativeFieldInfoPtr_setIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_setIcons;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000307 RID: 775
		[Serializable]
		public sealed class SetIconPair : ValueType
		{
			// Token: 0x06001F40 RID: 8000 RVA: 0x00077AAC File Offset: 0x00075CAC
			// Note: this type is marked as 'beforefieldinit'.
			static SetIconPair()
			{
				Il2CppClassPointerStore<WormExpansionsRenderer.SetIconPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormExpansionsRenderer>.NativeClassPtr, "SetIconPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormExpansionsRenderer.SetIconPair>.NativeClassPtr);
				WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormExpansionsRenderer.SetIconPair>.NativeClassPtr, "set");
				WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormExpansionsRenderer.SetIconPair>.NativeClassPtr, "icon");
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x00011A62 File Offset: 0x0000FC62
			public SetIconPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F42 RID: 8002 RVA: 0x00011A6B File Offset: 0x0000FC6B
			public SetIconPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormExpansionsRenderer.SetIconPair>.NativeClassPtr))
			{
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00077B00 File Offset: 0x00075D00
			// (set) Token: 0x06001F44 RID: 8004 RVA: 0x00011A7D File Offset: 0x0000FC7D
			public unsafe Set set
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_set);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_set)) = value;
				}
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00077B28 File Offset: 0x00075D28
			// (set) Token: 0x06001F46 RID: 8006 RVA: 0x00011A98 File Offset: 0x0000FC98
			public unsafe GameObject icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormExpansionsRenderer.SetIconPair.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeFieldInfoPtr_set;

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeFieldInfoPtr_icon;
		}
	}
}
