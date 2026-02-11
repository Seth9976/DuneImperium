using System;
using context;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.input.ui
{
	// Token: 0x0200005E RID: 94
	public class ImageInputCueEnableOnUsable : VersionedView<InputContextManager>
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		// Note: this type is marked as 'beforefieldinit'.
		static ImageInputCueEnableOnUsable()
		{
			Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.ui", "ImageInputCueEnableOnUsable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr);
			ImageInputCueEnableOnUsable.NativeFieldInfoPtr_cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, "cue");
			ImageInputCueEnableOnUsable.NativeFieldInfoPtr_registers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, "registers");
			ImageInputCueEnableOnUsable.NativeFieldInfoPtr_actionLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, "actionLookup");
			ImageInputCueEnableOnUsable.NativeFieldInfoPtr_globalInputDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, "globalInputDispatcher");
			ImageInputCueEnableOnUsable.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, 100663688);
			ImageInputCueEnableOnUsable.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, 100663689);
			ImageInputCueEnableOnUsable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, 100663690);
			ImageInputCueEnableOnUsable.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Private_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, 100663691);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00011B70 File Offset: 0x0000FD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121701, XrefRangeEnd = 1121718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageInputCueEnableOnUsable.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00011BAC File Offset: 0x0000FDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121718, XrefRangeEnd = 1121816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageInputCueEnableOnUsable.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121816, XrefRangeEnd = 1121826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageInputCueEnableOnUsable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCueEnableOnUsable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011C24 File Offset: 0x0000FE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121826, XrefRangeEnd = 1121828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__5_2(InputAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCueEnableOnUsable.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Private_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00004067 File Offset: 0x00002267
		public ImageInputCueEnableOnUsable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00011C74 File Offset: 0x0000FE74
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00004070 File Offset: 0x00002270
		public unsafe ImageInputCue cue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_cue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageInputCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_cue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000408F File Offset: 0x0000228F
		public unsafe Il2CppReferenceArray<IRegisterInputActions> registers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_registers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IRegisterInputActions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_registers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00011CD4 File Offset: 0x0000FED4
		// (set) Token: 0x06000386 RID: 902 RVA: 0x000040AE File Offset: 0x000022AE
		public unsafe Dictionary<string, List<InputAction>> actionLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_actionLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<InputAction>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_actionLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00011D04 File Offset: 0x0000FF04
		// (set) Token: 0x06000388 RID: 904 RVA: 0x000040CD File Offset: 0x000022CD
		public unsafe GlobalInputDispatcher globalInputDispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_globalInputDispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalInputDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCueEnableOnUsable.NativeFieldInfoPtr_globalInputDispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_cue;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_registers;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_actionLookup;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_globalInputDispatcher;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_2_Private_Boolean_InputAction_0;

		// Token: 0x020000C7 RID: 199
		[ObfuscatedName("dwd.core.input.ui.ImageInputCueEnableOnUsable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060008C2 RID: 2242 RVA: 0x00023468 File Offset: 0x00021668
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageInputCueEnableOnUsable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr);
				ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, "<>9");
				ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, "<>9__5_0");
				ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, "<>9__5_1");
				ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, 100663693);
				ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_IRegisterInputActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, 100663694);
				ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_IEnumerable_1_InputAction_IRegisterInputActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr, 100663695);
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x0002350C File Offset: 0x0002170C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageInputCueEnableOnUsable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008C4 RID: 2244 RVA: 0x00023548 File Offset: 0x00021748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121694, XrefRangeEnd = 1121697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_0(IRegisterInputActions r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_IRegisterInputActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x00023598 File Offset: 0x00021798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121697, XrefRangeEnd = 1121701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<InputAction> _dirtyUpdate_b__5_1(IRegisterInputActions r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCueEnableOnUsable.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_IEnumerable_1_InputAction_IRegisterInputActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
				}
			}

			// Token: 0x060008C6 RID: 2246 RVA: 0x00006960 File Offset: 0x00004B60
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x060008C7 RID: 2247 RVA: 0x000235E8 File Offset: 0x000217E8
			// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00006969 File Offset: 0x00004B69
			public unsafe static ImageInputCueEnableOnUsable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageInputCueEnableOnUsable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00023610 File Offset: 0x00021810
			// (set) Token: 0x060008CA RID: 2250 RVA: 0x0000697B File Offset: 0x00004B7B
			public unsafe static Func<IRegisterInputActions, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IRegisterInputActions, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x060008CB RID: 2251 RVA: 0x00023638 File Offset: 0x00021838
			// (set) Token: 0x060008CC RID: 2252 RVA: 0x0000698D File Offset: 0x00004B8D
			public unsafe static Func<IRegisterInputActions, IEnumerable<InputAction>> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IRegisterInputActions, IEnumerable<InputAction>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImageInputCueEnableOnUsable.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000570 RID: 1392
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000571 RID: 1393
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04000572 RID: 1394
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04000573 RID: 1395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000574 RID: 1396
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_IRegisterInputActions_0;

			// Token: 0x04000575 RID: 1397
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_IEnumerable_1_InputAction_IRegisterInputActions_0;
		}
	}
}
