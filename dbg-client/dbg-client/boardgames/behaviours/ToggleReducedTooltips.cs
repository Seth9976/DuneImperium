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
	// Token: 0x020002B5 RID: 693
	public class ToggleReducedTooltips : MonoBehaviour
	{
		// Token: 0x060020BD RID: 8381 RVA: 0x0008A880 File Offset: 0x00088A80
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleReducedTooltips()
		{
			Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "ToggleReducedTooltips");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr);
			ToggleReducedTooltips.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr, "toggle");
			ToggleReducedTooltips.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr, 100668734);
			ToggleReducedTooltips.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr, 100668735);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0008A8EC File Offset: 0x00088AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542752, XrefRangeEnd = 542779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleReducedTooltips.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0008A920 File Offset: 0x00088B20
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleReducedTooltips()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleReducedTooltips.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00011249 File Offset: 0x0000F449
		public ToggleReducedTooltips(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0008A95C File Offset: 0x00088B5C
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00011252 File Offset: 0x0000F452
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleReducedTooltips.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleReducedTooltips.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A8 RID: 1192
		[ObfuscatedName("boardgames.behaviours.ToggleReducedTooltips+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600388C RID: 14476 RVA: 0x000D155C File Offset: 0x000CF75C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleReducedTooltips>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr);
				ToggleReducedTooltips.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr, "<>9");
				ToggleReducedTooltips.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr, "<>9__1_0");
				ToggleReducedTooltips.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr, 100668737);
				ToggleReducedTooltips.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr, 100668738);
			}

			// Token: 0x0600388D RID: 14477 RVA: 0x000D15D8 File Offset: 0x000CF7D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleReducedTooltips.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleReducedTooltips.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600388E RID: 14478 RVA: 0x000D1614 File Offset: 0x000CF814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542744, XrefRangeEnd = 542752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1_0(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleReducedTooltips.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600388F RID: 14479 RVA: 0x0001D17F File Offset: 0x0001B37F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x06003890 RID: 14480 RVA: 0x000D1654 File Offset: 0x000CF854
			// (set) Token: 0x06003891 RID: 14481 RVA: 0x0001D188 File Offset: 0x0001B388
			public unsafe static ToggleReducedTooltips.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleReducedTooltips.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleReducedTooltips.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleReducedTooltips.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x06003892 RID: 14482 RVA: 0x000D167C File Offset: 0x000CF87C
			// (set) Token: 0x06003893 RID: 14483 RVA: 0x0001D19A File Offset: 0x0001B39A
			public unsafe static UnityAction<bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleReducedTooltips.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleReducedTooltips.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022BF RID: 8895
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040022C0 RID: 8896
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040022C1 RID: 8897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022C2 RID: 8898
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Internal_Void_Boolean_0;
		}
	}
}
