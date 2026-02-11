using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x0200019C RID: 412
	[Serializable]
	public class SerializedChainedAction : SerializedAction
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x00062158 File Offset: 0x00060358
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedChainedAction()
		{
			Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedChainedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr);
			SerializedChainedAction.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr, "Actions");
			SerializedChainedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr, 100667104);
			SerializedChainedAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr, 100667105);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000621C4 File Offset: 0x000603C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584742, XrefRangeEnd = 584762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedChainedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00062220 File Offset: 0x00060420
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedChainedAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChainedAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00008EAC File Offset: 0x000070AC
		public SerializedChainedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0006225C File Offset: 0x0006045C
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x00008EB5 File Offset: 0x000070B5
		public unsafe Il2CppReferenceArray<SerializedAction> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChainedAction.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChainedAction.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DB RID: 987
		[ObfuscatedName("Canis.actions.SerializedChainedAction+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060029E6 RID: 10726 RVA: 0x000B45E0 File Offset: 0x000B27E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedChainedAction>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr);
				SerializedChainedAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr, "match");
				SerializedChainedAction.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr, 100667106);
				SerializedChainedAction.__c__DisplayClass1_0.NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr, 100667107);
			}

			// Token: 0x060029E7 RID: 10727 RVA: 0x000B4648 File Offset: 0x000B2848
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChainedAction.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChainedAction.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029E8 RID: 10728 RVA: 0x000B4684 File Offset: 0x000B2884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action _GenAction_b__0(SerializedAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChainedAction.__c__DisplayClass1_0.NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060029E9 RID: 10729 RVA: 0x0001406E File Offset: 0x0001226E
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x060029EA RID: 10730 RVA: 0x000B46D4 File Offset: 0x000B28D4
			// (set) Token: 0x060029EB RID: 10731 RVA: 0x00014077 File Offset: 0x00012277
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChainedAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChainedAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A2E RID: 6702
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001A2F RID: 6703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A30 RID: 6704
			private static readonly IntPtr NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0;
		}
	}
}
