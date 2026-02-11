using System;
using Canis.json.events;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x0200002B RID: 43
	public class PlayerSaveData : Object
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x000254D0 File Offset: 0x000236D0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSaveData()
		{
			Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "PlayerSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr);
			PlayerSaveData.NativeFieldInfoPtr_lastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "lastState");
			PlayerSaveData.NativeFieldInfoPtr_displayActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "displayActions");
			PlayerSaveData.NativeMethodInfoPtr_AddDisplayActions_Public_Void_IEnumerable_1_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100663943);
			PlayerSaveData.NativeMethodInfoPtr_IsSelectionMessage_Public_Static_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100663944);
			PlayerSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100663945);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00025564 File Offset: 0x00023764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 549356, RefRangeEnd = 549359, XrefRangeStart = 549317, XrefRangeEnd = 549356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDisplayActions(IEnumerable<DWDEvent> das)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(das);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_AddDisplayActions_Public_Void_IEnumerable_1_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000255A8 File Offset: 0x000237A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549359, XrefRangeEnd = 549362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSelectionMessage(DWDEvent da)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(da);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_IsSelectionMessage_Public_Static_Boolean_DWDEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000255EC File Offset: 0x000237EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSaveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000034E2 File Offset: 0x000016E2
		public PlayerSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00025628 File Offset: 0x00023828
		// (set) Token: 0x060002FB RID: 763 RVA: 0x000034EB File Offset: 0x000016EB
		public unsafe SerializedGameState lastState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_lastState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_lastState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00025658 File Offset: 0x00023858
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000350A File Offset: 0x0000170A
		public unsafe List<DWDEvent> displayActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_displayActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_displayActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_lastState;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_displayActions;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_AddDisplayActions_Public_Void_IEnumerable_1_DWDEvent_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionMessage_Public_Static_Boolean_DWDEvent_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200027D RID: 637
		[ObfuscatedName("Canis.PlayerSaveData+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001AF4 RID: 6900 RVA: 0x0000CDD1 File Offset: 0x0000AFD1
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<PlayerSaveData.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveData.__O>.NativeClassPtr);
				PlayerSaveData.__O.NativeFieldInfoPtr__0___IsSelectionMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.__O>.NativeClassPtr, "<0>__IsSelectionMessage");
			}

			// Token: 0x06001AF5 RID: 6901 RVA: 0x0000CE05 File Offset: 0x0000B005
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00082B58 File Offset: 0x00080D58
			// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000CE0E File Offset: 0x0000B00E
			public unsafe static Func<DWDEvent, bool> _0___IsSelectionMessage
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSaveData.__O.NativeFieldInfoPtr__0___IsSelectionMessage, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSaveData.__O.NativeFieldInfoPtr__0___IsSelectionMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001130 RID: 4400
			private static readonly IntPtr NativeFieldInfoPtr__0___IsSelectionMessage;
		}

		// Token: 0x0200027E RID: 638
		[ObfuscatedName("Canis.PlayerSaveData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AF8 RID: 6904 RVA: 0x00082B80 File Offset: 0x00080D80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr);
				PlayerSaveData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr, "<>9");
				PlayerSaveData.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr, "<>9__2_0");
				PlayerSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr, 100663947);
				PlayerSaveData.__c.NativeMethodInfoPtr__AddDisplayActions_b__2_0_Internal_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr, 100663948);
			}

			// Token: 0x06001AF9 RID: 6905 RVA: 0x00082BFC File Offset: 0x00080DFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x00082C38 File Offset: 0x00080E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549314, XrefRangeEnd = 549317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddDisplayActions_b__2_0(DWDEvent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.__c.NativeMethodInfoPtr__AddDisplayActions_b__2_0_Internal_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AFB RID: 6907 RVA: 0x0000CE20 File Offset: 0x0000B020
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00082C88 File Offset: 0x00080E88
			// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0000CE29 File Offset: 0x0000B029
			public unsafe static PlayerSaveData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSaveData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSaveData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001AFE RID: 6910 RVA: 0x00082CB0 File Offset: 0x00080EB0
			// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000CE3B File Offset: 0x0000B03B
			public unsafe static Func<DWDEvent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSaveData.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSaveData.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001131 RID: 4401
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001132 RID: 4402
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001133 RID: 4403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001134 RID: 4404
			private static readonly IntPtr NativeMethodInfoPtr__AddDisplayActions_b__2_0_Internal_Boolean_DWDEvent_0;
		}
	}
}
