using System;
using Canis.actions.serialized;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.continuations
{
	// Token: 0x02000222 RID: 546
	[Serializable]
	public class SerializedActionAcrossTargets : Object
	{
		// Token: 0x060016AE RID: 5806 RVA: 0x0007461C File Offset: 0x0007281C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedActionAcrossTargets()
		{
			Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "SerializedActionAcrossTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr);
			SerializedActionAcrossTargets.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, "Action");
			SerializedActionAcrossTargets.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, "Context");
			SerializedActionAcrossTargets.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, "Targets");
			SerializedActionAcrossTargets.NativeMethodInfoPtr_Deserialize_Public_ActionAcrossTargets_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, 100668442);
			SerializedActionAcrossTargets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, 100668443);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000746B0 File Offset: 0x000728B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593731, RefRangeEnd = 593733, XrefRangeStart = 593697, XrefRangeEnd = 593731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionAcrossTargets Deserialize(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedActionAcrossTargets.NativeMethodInfoPtr_Deserialize_Public_ActionAcrossTargets_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr3) : null;
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00074700 File Offset: 0x00072900
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedActionAcrossTargets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedActionAcrossTargets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0000ADA5 File Offset: 0x00008FA5
		public SerializedActionAcrossTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x0007473C File Offset: 0x0007293C
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public unsafe SerializedAction Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0007476C File Offset: 0x0007296C
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000ADCD File Offset: 0x00008FCD
		public unsafe SerializedContext Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0007479C File Offset: 0x0007299C
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public unsafe Il2CppStringArray Targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_Context;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeFieldInfoPtr_Targets;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_ActionAcrossTargets_Match_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000464 RID: 1124
		[ObfuscatedName("Canis.actions.continuations.SerializedActionAcrossTargets+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600322A RID: 12842 RVA: 0x000CE84C File Offset: 0x000CCA4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedActionAcrossTargets>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr);
				SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr, "match");
				SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr, 100668444);
				SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeMethodInfoPtr__Deserialize_b__0_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr, 100668445);
			}

			// Token: 0x0600322B RID: 12843 RVA: 0x000CE8B4 File Offset: 0x000CCAB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedActionAcrossTargets.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600322C RID: 12844 RVA: 0x000CE8F0 File Offset: 0x000CCAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593696, XrefRangeEnd = 593697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _Deserialize_b__0(string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeMethodInfoPtr__Deserialize_b__0_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600322D RID: 12845 RVA: 0x000180AD File Offset: 0x000162AD
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x0600322E RID: 12846 RVA: 0x000CE940 File Offset: 0x000CCB40
			// (set) Token: 0x0600322F RID: 12847 RVA: 0x000180B6 File Offset: 0x000162B6
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedActionAcrossTargets.__c__DisplayClass3_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F5F RID: 8031
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F60 RID: 8032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F61 RID: 8033
			private static readonly IntPtr NativeMethodInfoPtr__Deserialize_b__0_Internal_Object_String_0;
		}
	}
}
