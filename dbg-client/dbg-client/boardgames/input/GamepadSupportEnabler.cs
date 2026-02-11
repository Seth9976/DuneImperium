using System;
using dwd.core.input.compositeModule.activation;
using dwd.core.input.compositeModule.inputDetection;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.input
{
	// Token: 0x02000135 RID: 309
	public class GamepadSupportEnabler : MonoBehaviour
	{
		// Token: 0x06000E00 RID: 3584 RVA: 0x00049FE4 File Offset: 0x000481E4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadSupportEnabler()
		{
			Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "GamepadSupportEnabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr);
			GamepadSupportEnabler.NativeFieldInfoPtr_forceDisableGamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "forceDisableGamepad");
			GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputForced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "gamepadInputForced");
			GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "gamepadInputAllowed");
			GamepadSupportEnabler.NativeMethodInfoPtr_get_GamePadInputForced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665318);
			GamepadSupportEnabler.NativeMethodInfoPtr_get_GamepadInputAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665319);
			GamepadSupportEnabler.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665320);
			GamepadSupportEnabler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665321);
			GamepadSupportEnabler.NativeMethodInfoPtr_promptForControllerSupport_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665322);
			GamepadSupportEnabler.NativeMethodInfoPtr_SetControllerSupportActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665323);
			GamepadSupportEnabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, 100665324);
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0004A0DC File Offset: 0x000482DC
		public unsafe bool GamePadInputForced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_get_GamePadInputForced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0004A118 File Offset: 0x00048318
		public unsafe bool GamepadInputAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_get_GamepadInputAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004A154 File Offset: 0x00048354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511681, XrefRangeEnd = 511686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004A194 File Offset: 0x00048394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511686, XrefRangeEnd = 511729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004A1C8 File Offset: 0x000483C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511729, XrefRangeEnd = 511734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator promptForControllerSupport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_promptForControllerSupport_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004A208 File Offset: 0x00048408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 511785, RefRangeEnd = 511788, XrefRangeStart = 511734, XrefRangeEnd = 511785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetControllerSupportActive(bool controllerEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr_SetControllerSupportActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004A248 File Offset: 0x00048448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511788, XrefRangeEnd = 511789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadSupportEnabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00008C83 File Offset: 0x00006E83
		public GamepadSupportEnabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0004A284 File Offset: 0x00048484
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00008C8C File Offset: 0x00006E8C
		public unsafe bool forceDisableGamepad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_forceDisableGamepad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_forceDisableGamepad)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0004A2AC File Offset: 0x000484AC
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00008CA7 File Offset: 0x00006EA7
		public unsafe bool gamepadInputForced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputForced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputForced)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0004A2D4 File Offset: 0x000484D4
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00008CC2 File Offset: 0x00006EC2
		public unsafe bool gamepadInputAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler.NativeFieldInfoPtr_gamepadInputAllowed)) = value;
			}
		}

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_forceDisableGamepad;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_gamepadInputForced;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_gamepadInputAllowed;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_get_GamePadInputForced_Public_get_Boolean_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_GamepadInputAllowed_Public_get_Boolean_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_promptForControllerSupport_Private_IEnumerator_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_SetControllerSupportActive_Public_Void_Boolean_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("boardgames.input.GamepadSupportEnabler+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060028A8 RID: 10408 RVA: 0x000A2510 File Offset: 0x000A0710
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr);
				GamepadSupportEnabler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, "<>9");
				GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, "<>9__7_0");
				GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, "<>9__10_0");
				GamepadSupportEnabler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, 100665326);
				GamepadSupportEnabler.__c.NativeMethodInfoPtr__Start_b__7_0_Internal_Boolean_ModuleActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, 100665327);
				GamepadSupportEnabler.__c.NativeMethodInfoPtr__SetControllerSupportActive_b__10_0_Internal_Boolean_ModuleActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr, 100665328);
			}

			// Token: 0x060028A9 RID: 10409 RVA: 0x000A25B4 File Offset: 0x000A07B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadSupportEnabler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028AA RID: 10410 RVA: 0x000A25F0 File Offset: 0x000A07F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511626, XrefRangeEnd = 511630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__7_0(ModuleActivator ma)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ma);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.__c.NativeMethodInfoPtr__Start_b__7_0_Internal_Boolean_ModuleActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028AB RID: 10411 RVA: 0x000A2640 File Offset: 0x000A0840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511630, XrefRangeEnd = 511634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetControllerSupportActive_b__10_0(ModuleActivator ma)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ma);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler.__c.NativeMethodInfoPtr__SetControllerSupportActive_b__10_0_Internal_Boolean_ModuleActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028AC RID: 10412 RVA: 0x00014FA7 File Offset: 0x000131A7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x060028AD RID: 10413 RVA: 0x000A2690 File Offset: 0x000A0890
			// (set) Token: 0x060028AE RID: 10414 RVA: 0x00014FB0 File Offset: 0x000131B0
			public unsafe static GamepadSupportEnabler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadSupportEnabler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x060028AF RID: 10415 RVA: 0x000A26B8 File Offset: 0x000A08B8
			// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00014FC2 File Offset: 0x000131C2
			public unsafe static Func<ModuleActivator, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ModuleActivator, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000A26E0 File Offset: 0x000A08E0
			// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00014FD4 File Offset: 0x000131D4
			public unsafe static Func<ModuleActivator, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ModuleActivator, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GamepadSupportEnabler.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001974 RID: 6516
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001975 RID: 6517
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001976 RID: 6518
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001977 RID: 6519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001978 RID: 6520
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Internal_Boolean_ModuleActivator_0;

			// Token: 0x04001979 RID: 6521
			private static readonly IntPtr NativeMethodInfoPtr__SetControllerSupportActive_b__10_0_Internal_Boolean_ModuleActivator_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("boardgames.input.GamepadSupportEnabler+<Start>d__7")]
		public sealed class _Start_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060028B3 RID: 10419 RVA: 0x000A2708 File Offset: 0x000A0908
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__7()
			{
				Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "<Start>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr);
				GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, "<>1__state");
				GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, "<>2__current");
				GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, "<>4__this");
				GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr__inputDetector_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, "<inputDetector>5__2");
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665329);
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665330);
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665331);
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665332);
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665333);
				GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr, 100665334);
			}

			// Token: 0x060028B4 RID: 10420 RVA: 0x000A27FC File Offset: 0x000A09FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadSupportEnabler._Start_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028B5 RID: 10421 RVA: 0x000A2844 File Offset: 0x000A0A44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028B6 RID: 10422 RVA: 0x000A2878 File Offset: 0x000A0A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511634, XrefRangeEnd = 511659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000A28B4 File Offset: 0x000A0AB4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028B8 RID: 10424 RVA: 0x000A28F4 File Offset: 0x000A0AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511659, XrefRangeEnd = 511664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000A2928 File Offset: 0x000A0B28
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028BA RID: 10426 RVA: 0x00014FE6 File Offset: 0x000131E6
			public _Start_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x060028BB RID: 10427 RVA: 0x000A2968 File Offset: 0x000A0B68
			// (set) Token: 0x060028BC RID: 10428 RVA: 0x00014FEF File Offset: 0x000131EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x060028BD RID: 10429 RVA: 0x000A2990 File Offset: 0x000A0B90
			// (set) Token: 0x060028BE RID: 10430 RVA: 0x0001500A File Offset: 0x0001320A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x060028BF RID: 10431 RVA: 0x000A29C0 File Offset: 0x000A0BC0
			// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00015029 File Offset: 0x00013229
			public unsafe GamepadSupportEnabler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadSupportEnabler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000A29F0 File Offset: 0x000A0BF0
			// (set) Token: 0x060028C2 RID: 10434 RVA: 0x00015048 File Offset: 0x00013248
			public unsafe InputDetector _inputDetector_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr__inputDetector_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._Start_d__7.NativeFieldInfoPtr__inputDetector_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400197A RID: 6522
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400197B RID: 6523
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400197C RID: 6524
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400197D RID: 6525
			private static readonly IntPtr NativeFieldInfoPtr__inputDetector_5__2;

			// Token: 0x0400197E RID: 6526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400197F RID: 6527
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001980 RID: 6528
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001981 RID: 6529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001982 RID: 6530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001983 RID: 6531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000362 RID: 866
		[ObfuscatedName("boardgames.input.GamepadSupportEnabler+<promptForControllerSupport>d__9")]
		public sealed class _promptForControllerSupport_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060028C3 RID: 10435 RVA: 0x000A2A20 File Offset: 0x000A0C20
			// Note: this type is marked as 'beforefieldinit'.
			static _promptForControllerSupport_d__9()
			{
				Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamepadSupportEnabler>.NativeClassPtr, "<promptForControllerSupport>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, "<>1__state");
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, "<>2__current");
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, "<>4__this");
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr__prompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, "<prompt>5__2");
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665335);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665336);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665337);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665338);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665339);
				GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr, 100665340);
			}

			// Token: 0x060028C4 RID: 10436 RVA: 0x000A2B14 File Offset: 0x000A0D14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _promptForControllerSupport_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadSupportEnabler._promptForControllerSupport_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028C5 RID: 10437 RVA: 0x000A2B5C File Offset: 0x000A0D5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028C6 RID: 10438 RVA: 0x000A2B90 File Offset: 0x000A0D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511664, XrefRangeEnd = 511676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x060028C7 RID: 10439 RVA: 0x000A2BCC File Offset: 0x000A0DCC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028C8 RID: 10440 RVA: 0x000A2C0C File Offset: 0x000A0E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511676, XrefRangeEnd = 511681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000A2C40 File Offset: 0x000A0E40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028CA RID: 10442 RVA: 0x00015067 File Offset: 0x00013267
			public _promptForControllerSupport_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x060028CB RID: 10443 RVA: 0x000A2C80 File Offset: 0x000A0E80
			// (set) Token: 0x060028CC RID: 10444 RVA: 0x00015070 File Offset: 0x00013270
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x060028CD RID: 10445 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
			// (set) Token: 0x060028CE RID: 10446 RVA: 0x0001508B File Offset: 0x0001328B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x060028CF RID: 10447 RVA: 0x000A2CD8 File Offset: 0x000A0ED8
			// (set) Token: 0x060028D0 RID: 10448 RVA: 0x000150AA File Offset: 0x000132AA
			public unsafe GamepadSupportEnabler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadSupportEnabler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x060028D1 RID: 10449 RVA: 0x000A2D08 File Offset: 0x000A0F08
			// (set) Token: 0x060028D2 RID: 10450 RVA: 0x000150C9 File Offset: 0x000132C9
			public unsafe ConfirmOrDenyPrompt _prompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr__prompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSupportEnabler._promptForControllerSupport_d__9.NativeFieldInfoPtr__prompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001984 RID: 6532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001985 RID: 6533
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001986 RID: 6534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001987 RID: 6535
			private static readonly IntPtr NativeFieldInfoPtr__prompt_5__2;

			// Token: 0x04001988 RID: 6536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001989 RID: 6537
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400198A RID: 6538
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400198B RID: 6539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400198C RID: 6540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400198D RID: 6541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
