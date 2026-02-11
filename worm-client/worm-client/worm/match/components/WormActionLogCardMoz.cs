using System;
using boardgames.moz;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001CC RID: 460
	public class WormActionLogCardMoz : BaseMoz
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x00055D34 File Offset: 0x00053F34
		// Note: this type is marked as 'beforefieldinit'.
		static WormActionLogCardMoz()
		{
			Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormActionLogCardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr);
			WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, "mozContainerPrefab");
			WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, "mozContainerInstance");
			WormActionLogCardMoz.NativeFieldInfoPtr_overlayCanvasRectT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, "overlayCanvasRectT");
			WormActionLogCardMoz.NativeFieldInfoPtr_mozPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, "mozPile");
			WormActionLogCardMoz.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, 100666078);
			WormActionLogCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, 100666079);
			WormActionLogCardMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, 100666080);
			WormActionLogCardMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, 100666081);
			WormActionLogCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, 100666082);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00055E18 File Offset: 0x00054018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713879, XrefRangeEnd = 713884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardMoz.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00055E4C File Offset: 0x0005404C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713884, XrefRangeEnd = 713922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLogCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00055E9C File Offset: 0x0005409C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLogCardMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00055ED8 File Offset: 0x000540D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713922, XrefRangeEnd = 713933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLogCardMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00055F14 File Offset: 0x00054114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510035, RefRangeEnd = 510036, XrefRangeStart = 510035, XrefRangeEnd = 510036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActionLogCardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
		public WormActionLogCardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00055F50 File Offset: 0x00054150
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0000C7AA File Offset: 0x0000A9AA
		public unsafe GameObject mozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00055F80 File Offset: 0x00054180
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
		public unsafe GameObject mozContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00055FB0 File Offset: 0x000541B0
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		public unsafe RectTransform overlayCanvasRectT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_overlayCanvasRectT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_overlayCanvasRectT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00055FE0 File Offset: 0x000541E0
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0000C807 File Offset: 0x0000AA07
		public unsafe ContainerView mozPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardMoz.NativeFieldInfoPtr_mozPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerPrefab;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerInstance;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_overlayCanvasRectT;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_mozPile;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D1 RID: 977
		[ObfuscatedName("worm.match.components.WormActionLogCardMoz+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060027A3 RID: 10147 RVA: 0x000905F0 File Offset: 0x0008E7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormActionLogCardMoz>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr);
				WormActionLogCardMoz.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr, "<>9");
				WormActionLogCardMoz.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr, "<>9__5_0");
				WormActionLogCardMoz.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr, 100666084);
				WormActionLogCardMoz.__c.NativeMethodInfoPtr__initMoz_b__5_0_Internal_EntityComponent_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr, 100666085);
			}

			// Token: 0x060027A4 RID: 10148 RVA: 0x0009066C File Offset: 0x0008E86C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogCardMoz.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardMoz.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027A5 RID: 10149 RVA: 0x000906A8 File Offset: 0x0008E8A8
			[CallerCount(0)]
			public unsafe EntityComponent _initMoz_b__5_0(UnitView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardMoz.__c.NativeMethodInfoPtr__initMoz_b__5_0_Internal_EntityComponent_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x060027A6 RID: 10150 RVA: 0x00015C98 File Offset: 0x00013E98
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000906F8 File Offset: 0x0008E8F8
			// (set) Token: 0x060027A8 RID: 10152 RVA: 0x00015CA1 File Offset: 0x00013EA1
			public unsafe static WormActionLogCardMoz.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormActionLogCardMoz.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActionLogCardMoz.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormActionLogCardMoz.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x060027A9 RID: 10153 RVA: 0x00090720 File Offset: 0x0008E920
			// (set) Token: 0x060027AA RID: 10154 RVA: 0x00015CB3 File Offset: 0x00013EB3
			public unsafe static Func<UnitView, EntityComponent> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormActionLogCardMoz.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormActionLogCardMoz.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__5_0_Internal_EntityComponent_UnitView_0;
		}
	}
}
