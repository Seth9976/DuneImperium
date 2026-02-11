using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001D1 RID: 465
	public class WormAnimationEnabledToggle : MonoBehaviour
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00056948 File Offset: 0x00054B48
		// Note: this type is marked as 'beforefieldinit'.
		static WormAnimationEnabledToggle()
		{
			Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAnimationEnabledToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr);
			WormAnimationEnabledToggle.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, "onToggle");
			WormAnimationEnabledToggle.NativeFieldInfoPtr_offToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, "offToggle");
			WormAnimationEnabledToggle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, 100666111);
			WormAnimationEnabledToggle.NativeMethodInfoPtr_ToggleSetup_Private_Static_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, 100666112);
			WormAnimationEnabledToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, 100666113);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000569DC File Offset: 0x00054BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714359, XrefRangeEnd = 714361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationEnabledToggle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00056A10 File Offset: 0x00054C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 714383, RefRangeEnd = 714385, XrefRangeStart = 714361, XrefRangeEnd = 714383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleSetup(Toggle toggle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationEnabledToggle.NativeMethodInfoPtr_ToggleSetup_Private_Static_Void_Toggle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00056A54 File Offset: 0x00054C54
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAnimationEnabledToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationEnabledToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000C9DD File Offset: 0x0000ABDD
		public WormAnimationEnabledToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00056A90 File Offset: 0x00054C90
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000C9E6 File Offset: 0x0000ABE6
		public unsafe Toggle onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00056AC0 File Offset: 0x00054CC0
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000CA05 File Offset: 0x0000AC05
		public unsafe Toggle offToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.NativeFieldInfoPtr_offToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.NativeFieldInfoPtr_offToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_offToggle;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_ToggleSetup_Private_Static_Void_Toggle_Boolean_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D5 RID: 981
		[ObfuscatedName("worm.match.components.WormAnimationEnabledToggle+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060027C6 RID: 10182 RVA: 0x00090C34 File Offset: 0x0008EE34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAnimationEnabledToggle>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr);
				WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr, "value");
				WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr, 100666114);
				WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeMethodInfoPtr__ToggleSetup_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr, 100666115);
			}

			// Token: 0x060027C7 RID: 10183 RVA: 0x00090C9C File Offset: 0x0008EE9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAnimationEnabledToggle.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027C8 RID: 10184 RVA: 0x00090CD8 File Offset: 0x0008EED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714352, XrefRangeEnd = 714359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ToggleSetup_b__0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeMethodInfoPtr__ToggleSetup_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027C9 RID: 10185 RVA: 0x00015D96 File Offset: 0x00013F96
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x060027CA RID: 10186 RVA: 0x00090D18 File Offset: 0x0008EF18
			// (set) Token: 0x060027CB RID: 10187 RVA: 0x00015D9F File Offset: 0x00013F9F
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationEnabledToggle.__c__DisplayClass3_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040016E9 RID: 5865
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040016EA RID: 5866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016EB RID: 5867
			private static readonly IntPtr NativeMethodInfoPtr__ToggleSetup_b__0_Internal_Void_Boolean_0;
		}
	}
}
