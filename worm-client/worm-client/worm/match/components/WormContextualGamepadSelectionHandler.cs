using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001DF RID: 479
	public class WormContextualGamepadSelectionHandler : MonoBehaviour
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x00058674 File Offset: 0x00056874
		// Note: this type is marked as 'beforefieldinit'.
		static WormContextualGamepadSelectionHandler()
		{
			Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormContextualGamepadSelectionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr);
			WormContextualGamepadSelectionHandler.NativeFieldInfoPtr_attemptSelectionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr, "attemptSelectionOrder");
			WormContextualGamepadSelectionHandler.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr, 100666214);
			WormContextualGamepadSelectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr, 100666215);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000586E0 File Offset: 0x000568E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714941, XrefRangeEnd = 714983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextualGamepadSelectionHandler.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00058714 File Offset: 0x00056914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714983, XrefRangeEnd = 714988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormContextualGamepadSelectionHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextualGamepadSelectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0000CE4B File Offset: 0x0000B04B
		public WormContextualGamepadSelectionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00058750 File Offset: 0x00056950
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x0000CE54 File Offset: 0x0000B054
		public unsafe Il2CppReferenceArray<GameObject> attemptSelectionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextualGamepadSelectionHandler.NativeFieldInfoPtr_attemptSelectionOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextualGamepadSelectionHandler.NativeFieldInfoPtr_attemptSelectionOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_attemptSelectionOrder;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DF RID: 991
		[ObfuscatedName("worm.match.components.WormContextualGamepadSelectionHandler+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002840 RID: 10304 RVA: 0x000921F0 File Offset: 0x000903F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr);
				WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr, "<>9");
				WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr, "<>9__1_0");
				WormContextualGamepadSelectionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr, 100666217);
				WormContextualGamepadSelectionHandler.__c.NativeMethodInfoPtr__Event_Select_b__1_0_Internal_IEnumerable_1_Selectable_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr, 100666218);
			}

			// Token: 0x06002841 RID: 10305 RVA: 0x0009226C File Offset: 0x0009046C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContextualGamepadSelectionHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextualGamepadSelectionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002842 RID: 10306 RVA: 0x000922A8 File Offset: 0x000904A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714937, XrefRangeEnd = 714941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Selectable> _Event_Select_b__1_0(GameObject root)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextualGamepadSelectionHandler.__c.NativeMethodInfoPtr__Event_Select_b__1_0_Internal_IEnumerable_1_Selectable_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
				}
			}

			// Token: 0x06002843 RID: 10307 RVA: 0x0001617C File Offset: 0x0001437C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06002844 RID: 10308 RVA: 0x000922F8 File Offset: 0x000904F8
			// (set) Token: 0x06002845 RID: 10309 RVA: 0x00016185 File Offset: 0x00014385
			public unsafe static WormContextualGamepadSelectionHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormContextualGamepadSelectionHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06002846 RID: 10310 RVA: 0x00092320 File Offset: 0x00090520
			// (set) Token: 0x06002847 RID: 10311 RVA: 0x00016197 File Offset: 0x00014397
			public unsafe static Func<GameObject, IEnumerable<Selectable>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<Selectable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormContextualGamepadSelectionHandler.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeMethodInfoPtr__Event_Select_b__1_0_Internal_IEnumerable_1_Selectable_GameObject_0;
		}
	}
}
