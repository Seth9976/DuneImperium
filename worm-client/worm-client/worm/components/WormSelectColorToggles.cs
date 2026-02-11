using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.components
{
	// Token: 0x0200007D RID: 125
	public class WormSelectColorToggles : MonoBehaviour
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00027A40 File Offset: 0x00025C40
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectColorToggles()
		{
			Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.components", "WormSelectColorToggles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr);
			WormSelectColorToggles.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, "colors");
			WormSelectColorToggles.NativeMethodInfoPtr_SetIsOn_Public_Void_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, 100664001);
			WormSelectColorToggles.NativeMethodInfoPtr_AddListeners_Public_Void_Action_1_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, 100664002);
			WormSelectColorToggles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, 100664003);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00027AC0 File Offset: 0x00025CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694359, XrefRangeEnd = 694361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.NativeMethodInfoPtr_SetIsOn_Public_Void_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00027B00 File Offset: 0x00025D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694381, RefRangeEnd = 694382, XrefRangeStart = 694361, XrefRangeEnd = 694381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListeners(Action<PieceColor> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.NativeMethodInfoPtr_AddListeners_Public_Void_Action_1_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00027B44 File Offset: 0x00025D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694382, XrefRangeEnd = 694390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectColorToggles()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000045F1 File Offset: 0x000027F1
		public WormSelectColorToggles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00027B80 File Offset: 0x00025D80
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x000045FA File Offset: 0x000027FA
		public unsafe Il2CppReferenceArray<WormSelectColorToggles.ColorTogglePair> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormSelectColorToggles.ColorTogglePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_PieceColor_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_AddListeners_Public_Void_Action_1_PieceColor_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F6 RID: 758
		[Serializable]
		public sealed class ColorTogglePair : ValueType
		{
			// Token: 0x06001EB1 RID: 7857 RVA: 0x00076150 File Offset: 0x00074350
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTogglePair()
			{
				Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, "ColorTogglePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr);
				WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr, "color");
				WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr, "toggle");
			}

			// Token: 0x06001EB2 RID: 7858 RVA: 0x00011653 File Offset: 0x0000F853
			public ColorTogglePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x0001165C File Offset: 0x0000F85C
			public ColorTogglePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr))
			{
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x000761A4 File Offset: 0x000743A4
			// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0001166E File Offset: 0x0000F86E
			public unsafe PieceColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x000761CC File Offset: 0x000743CC
			// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00011689 File Offset: 0x0000F889
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.ColorTogglePair.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C4 RID: 4548
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040011C5 RID: 4549
			private static readonly IntPtr NativeFieldInfoPtr_toggle;
		}

		// Token: 0x020002F7 RID: 759
		[ObfuscatedName("worm.components.WormSelectColorToggles+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x000761FC File Offset: 0x000743FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_0>.NativeClassPtr);
				WormSelectColorToggles.__c__DisplayClass3_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_0>.NativeClassPtr, "handler");
				WormSelectColorToggles.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_0>.NativeClassPtr, 100664004);
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x00076250 File Offset: 0x00074450
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x000116A8 File Offset: 0x0000F8A8
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0007628C File Offset: 0x0007448C
			// (set) Token: 0x06001EBC RID: 7868 RVA: 0x000116B1 File Offset: 0x0000F8B1
			public unsafe Action<PieceColor> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PieceColor>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F8 RID: 760
		[ObfuscatedName("worm.components.WormSelectColorToggles+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06001EBD RID: 7869 RVA: 0x000762BC File Offset: 0x000744BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectColorToggles>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr);
				WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_currentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr, "currentColor");
				WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				WormSelectColorToggles.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr, 100664005);
				WormSelectColorToggles.__c__DisplayClass3_1.NativeMethodInfoPtr__AddListeners_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr, 100664006);
			}

			// Token: 0x06001EBE RID: 7870 RVA: 0x00076338 File Offset: 0x00074538
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectColorToggles.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EBF RID: 7871 RVA: 0x00076374 File Offset: 0x00074574
			[CallerCount(0)]
			public unsafe void _AddListeners_b__0(bool on)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref on;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectColorToggles.__c__DisplayClass3_1.NativeMethodInfoPtr__AddListeners_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x000116D0 File Offset: 0x0000F8D0
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x000763B4 File Offset: 0x000745B4
			// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x000116D9 File Offset: 0x0000F8D9
			public unsafe PieceColor currentColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_currentColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_currentColor)) = value;
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x000763DC File Offset: 0x000745DC
			// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x000116F4 File Offset: 0x0000F8F4
			public unsafe WormSelectColorToggles.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectColorToggles.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectColorToggles.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C8 RID: 4552
			private static readonly IntPtr NativeFieldInfoPtr_currentColor;

			// Token: 0x040011C9 RID: 4553
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040011CA RID: 4554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011CB RID: 4555
			private static readonly IntPtr NativeMethodInfoPtr__AddListeners_b__0_Internal_Void_Boolean_0;
		}
	}
}
