using System;
using Canis;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.actions.cost
{
	// Token: 0x020002F3 RID: 755
	public class HasFactionInfluence : CostAction
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x000D1BD4 File Offset: 0x000CFDD4
		// Note: this type is marked as 'beforefieldinit'.
		static HasFactionInfluence()
		{
			Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "HasFactionInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr);
			HasFactionInfluence.NativeFieldInfoPtr_influenceRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, "influenceRequirement");
			HasFactionInfluence.NativeFieldInfoPtr_influenceComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, "influenceComparer");
			HasFactionInfluence.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, "faction");
			HasFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670635);
			HasFactionInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670636);
			HasFactionInfluence.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670637);
			HasFactionInfluence.NativeMethodInfoPtr_AtLeast_Public_Static_HasFactionInfluence_Factions_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670638);
			HasFactionInfluence.NativeMethodInfoPtr_MoreThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670639);
			HasFactionInfluence.NativeMethodInfoPtr_AtMost_Public_Static_HasFactionInfluence_Factions_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670640);
			HasFactionInfluence.NativeMethodInfoPtr_LessThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, 100670641);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000D1CCC File Offset: 0x000CFECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172406, XrefRangeEnd = 172408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasFactionInfluence(Factions faction, int influenceRequirement, Func<int, int, bool> influenceComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influenceRequirement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(influenceComparer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000D1D48 File Offset: 0x000CFF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172408, XrefRangeEnd = 172413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasFactionInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000D1D94 File Offset: 0x000CFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172413, XrefRangeEnd = 172421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasFactionInfluence.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000D1DEC File Offset: 0x000CFFEC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 172441, RefRangeEnd = 172468, XrefRangeStart = 172421, XrefRangeEnd = 172441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasFactionInfluence AtLeast(Factions faction, int influence, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.NativeMethodInfoPtr_AtLeast_Public_Static_HasFactionInfluence_Factions_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasFactionInfluence>(intPtr3) : null;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000D1E4C File Offset: 0x000D004C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172468, XrefRangeEnd = 172488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasFactionInfluence MoreThan(Factions faction, int influence, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.NativeMethodInfoPtr_MoreThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasFactionInfluence>(intPtr3) : null;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x000D1EAC File Offset: 0x000D00AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172488, XrefRangeEnd = 172508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasFactionInfluence AtMost(Factions faction, int influence, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.NativeMethodInfoPtr_AtMost_Public_Static_HasFactionInfluence_Factions_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasFactionInfluence>(intPtr3) : null;
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000D1F0C File Offset: 0x000D010C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172508, XrefRangeEnd = 172528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasFactionInfluence LessThan(Factions faction, int influence, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.NativeMethodInfoPtr_LessThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasFactionInfluence>(intPtr3) : null;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		public HasFactionInfluence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x000D1F6C File Offset: 0x000D016C
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x0000CFB5 File Offset: 0x0000B1B5
		public unsafe int influenceRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_influenceRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_influenceRequirement)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000D1F94 File Offset: 0x000D0194
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		public unsafe Func<int, int, bool> influenceComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_influenceComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_influenceComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000D1FC4 File Offset: 0x000D01C4
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x0000CFEF File Offset: 0x0000B1EF
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_influenceRequirement;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_influenceComparer;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasFactionInfluence_Factions_Int32_Match_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasFactionInfluence_Factions_Int32_Match_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasFactionInfluence_Factions_Int32_Match_0;

		// Token: 0x0200079D RID: 1949
		[ObfuscatedName("worm.canis.actions.cost.HasFactionInfluence+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006E1B RID: 28187 RVA: 0x00203F94 File Offset: 0x00202194
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr);
				HasFactionInfluence.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, "<>9");
				HasFactionInfluence.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, "<>9__6_0");
				HasFactionInfluence.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, "<>9__7_0");
				HasFactionInfluence.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, "<>9__8_0");
				HasFactionInfluence.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, "<>9__9_0");
				HasFactionInfluence.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, 100670643);
				HasFactionInfluence.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, 100670644);
				HasFactionInfluence.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, 100670645);
				HasFactionInfluence.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, 100670646);
				HasFactionInfluence.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr, 100670647);
			}

			// Token: 0x06006E1C RID: 28188 RVA: 0x00204088 File Offset: 0x00202288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFactionInfluence.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006E1D RID: 28189 RVA: 0x002040C4 File Offset: 0x002022C4
			[CallerCount(0)]
			public unsafe bool _AtLeast_b__6_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006E1E RID: 28190 RVA: 0x0020411C File Offset: 0x0020231C
			[CallerCount(0)]
			public unsafe bool _MoreThan_b__7_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006E1F RID: 28191 RVA: 0x00204174 File Offset: 0x00202374
			[CallerCount(0)]
			public unsafe bool _AtMost_b__8_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006E20 RID: 28192 RVA: 0x002041CC File Offset: 0x002023CC
			[CallerCount(0)]
			public unsafe bool _LessThan_b__9_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006E21 RID: 28193 RVA: 0x0002BCAE File Offset: 0x00029EAE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E2B RID: 7723
			// (get) Token: 0x06006E22 RID: 28194 RVA: 0x00204224 File Offset: 0x00202424
			// (set) Token: 0x06006E23 RID: 28195 RVA: 0x0002BCB7 File Offset: 0x00029EB7
			public unsafe static HasFactionInfluence.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasFactionInfluence.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E2C RID: 7724
			// (get) Token: 0x06006E24 RID: 28196 RVA: 0x0020424C File Offset: 0x0020244C
			// (set) Token: 0x06006E25 RID: 28197 RVA: 0x0002BCC9 File Offset: 0x00029EC9
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E2D RID: 7725
			// (get) Token: 0x06006E26 RID: 28198 RVA: 0x00204274 File Offset: 0x00202474
			// (set) Token: 0x06006E27 RID: 28199 RVA: 0x0002BCDB File Offset: 0x00029EDB
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E2E RID: 7726
			// (get) Token: 0x06006E28 RID: 28200 RVA: 0x0020429C File Offset: 0x0020249C
			// (set) Token: 0x06006E29 RID: 28201 RVA: 0x0002BCED File Offset: 0x00029EED
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E2F RID: 7727
			// (get) Token: 0x06006E2A RID: 28202 RVA: 0x002042C4 File Offset: 0x002024C4
			// (set) Token: 0x06006E2B RID: 28203 RVA: 0x0002BCFF File Offset: 0x00029EFF
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasFactionInfluence.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004721 RID: 18209
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004722 RID: 18210
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04004723 RID: 18211
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04004724 RID: 18212
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04004725 RID: 18213
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04004726 RID: 18214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004727 RID: 18215
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004728 RID: 18216
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004729 RID: 18217
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x0400472A RID: 18218
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x0200079E RID: 1950
		[ObfuscatedName("worm.canis.actions.cost.HasFactionInfluence+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06006E2C RID: 28204 RVA: 0x002042EC File Offset: 0x002024EC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasFactionInfluence>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr);
				HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, "<>1__state");
				HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, "<>2__current");
				HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670648);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670649);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670650);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670651);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670652);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670653);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670654);
				HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr, 100670655);
			}

			// Token: 0x06006E2D RID: 28205 RVA: 0x002043F4 File Offset: 0x002025F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFactionInfluence._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006E2E RID: 28206 RVA: 0x0020443C File Offset: 0x0020263C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006E2F RID: 28207 RVA: 0x00204470 File Offset: 0x00202670
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E33 RID: 7731
			// (get) Token: 0x06006E30 RID: 28208 RVA: 0x002044AC File Offset: 0x002026AC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006E31 RID: 28209 RVA: 0x002044EC File Offset: 0x002026EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172399, XrefRangeEnd = 172404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E34 RID: 7732
			// (get) Token: 0x06006E32 RID: 28210 RVA: 0x00204520 File Offset: 0x00202720
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006E33 RID: 28211 RVA: 0x00204560 File Offset: 0x00202760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172404, XrefRangeEnd = 172406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006E34 RID: 28212 RVA: 0x002045A0 File Offset: 0x002027A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionInfluence._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006E35 RID: 28213 RVA: 0x0002BD11 File Offset: 0x00029F11
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E30 RID: 7728
			// (get) Token: 0x06006E36 RID: 28214 RVA: 0x002045E0 File Offset: 0x002027E0
			// (set) Token: 0x06006E37 RID: 28215 RVA: 0x0002BD1A File Offset: 0x00029F1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E31 RID: 7729
			// (get) Token: 0x06006E38 RID: 28216 RVA: 0x00204608 File Offset: 0x00202808
			// (set) Token: 0x06006E39 RID: 28217 RVA: 0x0002BD35 File Offset: 0x00029F35
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E32 RID: 7730
			// (get) Token: 0x06006E3A RID: 28218 RVA: 0x00204638 File Offset: 0x00202838
			// (set) Token: 0x06006E3B RID: 28219 RVA: 0x0002BD54 File Offset: 0x00029F54
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionInfluence._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400472B RID: 18219
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400472C RID: 18220
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400472D RID: 18221
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400472E RID: 18222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400472F RID: 18223
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004730 RID: 18224
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004731 RID: 18225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004732 RID: 18226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004733 RID: 18227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004734 RID: 18228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004735 RID: 18229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
