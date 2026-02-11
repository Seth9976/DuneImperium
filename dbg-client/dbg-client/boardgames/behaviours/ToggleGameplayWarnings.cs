using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace boardgames.behaviours
{
	// Token: 0x020002B4 RID: 692
	public class ToggleGameplayWarnings : MonoBehaviour
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x0008A774 File Offset: 0x00088974
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleGameplayWarnings()
		{
			Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "ToggleGameplayWarnings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr);
			ToggleGameplayWarnings.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr, "toggle");
			ToggleGameplayWarnings.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr, 100668729);
			ToggleGameplayWarnings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr, 100668730);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0008A7E0 File Offset: 0x000889E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542717, XrefRangeEnd = 542744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGameplayWarnings.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0008A814 File Offset: 0x00088A14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleGameplayWarnings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGameplayWarnings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00011221 File Offset: 0x0000F421
		public ToggleGameplayWarnings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0008A850 File Offset: 0x00088A50
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0001122A File Offset: 0x0000F42A
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGameplayWarnings.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGameplayWarnings.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A7 RID: 1191
		[ObfuscatedName("boardgames.behaviours.ToggleGameplayWarnings+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06003884 RID: 14468 RVA: 0x000D1414 File Offset: 0x000CF614
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleGameplayWarnings>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr);
				ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr, "<>9");
				ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr, "<>9__1_0");
				ToggleGameplayWarnings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr, 100668732);
				ToggleGameplayWarnings.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr, 100668733);
			}

			// Token: 0x06003885 RID: 14469 RVA: 0x000D1490 File Offset: 0x000CF690
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGameplayWarnings.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGameplayWarnings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003886 RID: 14470 RVA: 0x000D14CC File Offset: 0x000CF6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542709, XrefRangeEnd = 542717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1_0(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGameplayWarnings.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003887 RID: 14471 RVA: 0x0001D152 File Offset: 0x0001B352
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B7 RID: 4279
			// (get) Token: 0x06003888 RID: 14472 RVA: 0x000D150C File Offset: 0x000CF70C
			// (set) Token: 0x06003889 RID: 14473 RVA: 0x0001D15B File Offset: 0x0001B35B
			public unsafe static ToggleGameplayWarnings.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGameplayWarnings.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x0600388A RID: 14474 RVA: 0x000D1534 File Offset: 0x000CF734
			// (set) Token: 0x0600388B RID: 14475 RVA: 0x0001D16D File Offset: 0x0001B36D
			public unsafe static UnityAction<bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGameplayWarnings.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022BB RID: 8891
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040022BC RID: 8892
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040022BD RID: 8893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022BE RID: 8894
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0;
		}
	}
}
