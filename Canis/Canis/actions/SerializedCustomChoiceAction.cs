using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001A6 RID: 422
	[Serializable]
	public class SerializedCustomChoiceAction : SerializedAction
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x000633A4 File Offset: 0x000615A4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedCustomChoiceAction()
		{
			Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedCustomChoiceAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr);
			SerializedCustomChoiceAction.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr, "Actions");
			SerializedCustomChoiceAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr, 100667195);
			SerializedCustomChoiceAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr, 100667196);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00063410 File Offset: 0x00061610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585231, XrefRangeEnd = 585254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedCustomChoiceAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0006346C File Offset: 0x0006166C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedCustomChoiceAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedCustomChoiceAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0000903B File Offset: 0x0000723B
		public SerializedCustomChoiceAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000634A8 File Offset: 0x000616A8
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00009044 File Offset: 0x00007244
		public unsafe Il2CppReferenceArray<SerializedAction> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCustomChoiceAction.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCustomChoiceAction.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E6 RID: 998
		[ObfuscatedName("Canis.actions.SerializedCustomChoiceAction+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002A89 RID: 10889 RVA: 0x000B6644 File Offset: 0x000B4844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedCustomChoiceAction>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr);
				SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr, "match");
				SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr, 100667197);
				SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr, 100667198);
			}

			// Token: 0x06002A8A RID: 10890 RVA: 0x000B66AC File Offset: 0x000B48AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedCustomChoiceAction.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A8B RID: 10891 RVA: 0x000B66E8 File Offset: 0x000B48E8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002A8C RID: 10892 RVA: 0x0001456E File Offset: 0x0001276E
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000B6738 File Offset: 0x000B4938
			// (set) Token: 0x06002A8E RID: 10894 RVA: 0x00014577 File Offset: 0x00012777
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCustomChoiceAction.__c__DisplayClass1_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A94 RID: 6804
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001A95 RID: 6805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A96 RID: 6806
			private static readonly IntPtr NativeMethodInfoPtr__GenAction_b__0_Internal_Action_SerializedAction_0;
		}
	}
}
