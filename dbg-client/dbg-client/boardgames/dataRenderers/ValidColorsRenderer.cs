using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace boardgames.datarenderers
{
	// Token: 0x0200017A RID: 378
	public class ValidColorsRenderer : VersionedSubscriber<ValidColorsDataComponent>
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x00052234 File Offset: 0x00050434
		// Note: this type is marked as 'beforefieldinit'.
		static ValidColorsRenderer()
		{
			Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ValidColorsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr);
			ValidColorsRenderer.NativeFieldInfoPtr_colorSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, "colorSelectables");
			ValidColorsRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, 100665631);
			ValidColorsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, 100665632);
			ValidColorsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, 100665633);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000522B4 File Offset: 0x000504B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514209, XrefRangeEnd = 514238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidColorsRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000522F0 File Offset: 0x000504F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514238, XrefRangeEnd = 514278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidColorsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0005232C File Offset: 0x0005052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514278, XrefRangeEnd = 514281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidColorsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000A0C6 File Offset: 0x000082C6
		public ValidColorsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x00052368 File Offset: 0x00050568
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x0000A0CF File Offset: 0x000082CF
		public unsafe Il2CppReferenceArray<ValidColorsRenderer.ColorTogglePair> colorSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.NativeFieldInfoPtr_colorSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValidColorsRenderer.ColorTogglePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.NativeFieldInfoPtr_colorSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_colorSelectables;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000373 RID: 883
		[Serializable]
		public class ColorTogglePair : Object
		{
			// Token: 0x0600298B RID: 10635 RVA: 0x000A4C08 File Offset: 0x000A2E08
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTogglePair()
			{
				Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, "ColorTogglePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr);
				ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr, "Color");
				ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr, "Toggle");
				ValidColorsRenderer.ColorTogglePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr, 100665634);
			}

			// Token: 0x0600298C RID: 10636 RVA: 0x000A4C70 File Offset: 0x000A2E70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTogglePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidColorsRenderer.ColorTogglePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsRenderer.ColorTogglePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600298D RID: 10637 RVA: 0x00015735 File Offset: 0x00013935
			public ColorTogglePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x0600298E RID: 10638 RVA: 0x000A4CAC File Offset: 0x000A2EAC
			// (set) Token: 0x0600298F RID: 10639 RVA: 0x0001573E File Offset: 0x0001393E
			public unsafe string Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Color);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Color), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002990 RID: 10640 RVA: 0x000A4CD4 File Offset: 0x000A2ED4
			// (set) Token: 0x06002991 RID: 10641 RVA: 0x0001575D File Offset: 0x0001395D
			public unsafe Toggle Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsRenderer.ColorTogglePair.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019F0 RID: 6640
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x040019F1 RID: 6641
			private static readonly IntPtr NativeFieldInfoPtr_Toggle;

			// Token: 0x040019F2 RID: 6642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000374 RID: 884
		[ObfuscatedName("boardgames.datarenderers.ValidColorsRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002992 RID: 10642 RVA: 0x000A4D04 File Offset: 0x000A2F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidColorsRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr);
				ValidColorsRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, "<>9");
				ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, "<>9__3_0");
				ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, "<>9__3_1");
				ValidColorsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, 100665636);
				ValidColorsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_ColorTogglePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, 100665637);
				ValidColorsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_ColorTogglePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr, 100665638);
			}

			// Token: 0x06002993 RID: 10643 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidColorsRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002994 RID: 10644 RVA: 0x000A4DE4 File Offset: 0x000A2FE4
			[CallerCount(0)]
			public unsafe bool _dirtyUpdate_b__3_0(ValidColorsRenderer.ColorTogglePair colorSelectable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorSelectable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_ColorTogglePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002995 RID: 10645 RVA: 0x000A4E34 File Offset: 0x000A3034
			[CallerCount(0)]
			public unsafe bool _dirtyUpdate_b__3_1(ValidColorsRenderer.ColorTogglePair colorSelectable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorSelectable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_ColorTogglePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002996 RID: 10646 RVA: 0x0001577C File Offset: 0x0001397C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x06002997 RID: 10647 RVA: 0x000A4E84 File Offset: 0x000A3084
			// (set) Token: 0x06002998 RID: 10648 RVA: 0x00015785 File Offset: 0x00013985
			public unsafe static ValidColorsRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidColorsRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x06002999 RID: 10649 RVA: 0x000A4EAC File Offset: 0x000A30AC
			// (set) Token: 0x0600299A RID: 10650 RVA: 0x00015797 File Offset: 0x00013997
			public unsafe static Func<ValidColorsRenderer.ColorTogglePair, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValidColorsRenderer.ColorTogglePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x0600299B RID: 10651 RVA: 0x000A4ED4 File Offset: 0x000A30D4
			// (set) Token: 0x0600299C RID: 10652 RVA: 0x000157A9 File Offset: 0x000139A9
			public unsafe static Func<ValidColorsRenderer.ColorTogglePair, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValidColorsRenderer.ColorTogglePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidColorsRenderer.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019F3 RID: 6643
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019F4 RID: 6644
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040019F5 RID: 6645
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040019F6 RID: 6646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019F7 RID: 6647
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_ColorTogglePair_0;

			// Token: 0x040019F8 RID: 6648
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_ColorTogglePair_0;
		}
	}
}
