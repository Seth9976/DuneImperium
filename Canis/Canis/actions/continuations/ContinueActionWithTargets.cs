using System;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class ContinueActionWithTargets : ActionContinuation
	{
		// Token: 0x060016B8 RID: 5816 RVA: 0x000747CC File Offset: 0x000729CC
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueActionWithTargets()
		{
			Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ContinueActionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr);
			ContinueActionWithTargets.NativeFieldInfoPtr_ResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, "ResolutionGen");
			ContinueActionWithTargets.NativeFieldInfoPtr_ParentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, "ParentContext");
			ContinueActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, "SkippedResolutionGen");
			ContinueActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_ContinueActionWithTargets_Action_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668446);
			ContinueActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668447);
			ContinueActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668448);
			ContinueActionWithTargets.NativeMethodInfoPtr_MakeActsAcrossTargets_Private_ActionAcrossTargets_Match_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668449);
			ContinueActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668450);
			ContinueActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668451);
			ContinueActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, 100668452);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000748C4 File Offset: 0x00072AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 593792, RefRangeEnd = 593793, XrefRangeStart = 593776, XrefRangeEnd = 593792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContinueActionWithTargets Instance(Action resolutionGen, Context parentContext, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_ContinueActionWithTargets_Action_Context_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContinueActionWithTargets>(intPtr3) : null;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0007492C File Offset: 0x00072B2C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueActionWithTargets(SerializedAction resolutionGen, SerializedContext parentContext, SerializedAction skippedResolutionGen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skippedResolutionGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0007499C File Offset: 0x00072B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593793, XrefRangeEnd = 593801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ActionAcrossTargets> MakeContinuationActions(IEnumerable selectionResponse, PlayerEntity selectingPlayer, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionResponse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00074A1C File Offset: 0x00072C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 593831, RefRangeEnd = 593832, XrefRangeStart = 593801, XrefRangeEnd = 593831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionAcrossTargets MakeActsAcrossTargets(Match match, Il2CppReferenceArray<Object> typedResponses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typedResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr_MakeActsAcrossTargets_Private_ActionAcrossTargets_Match_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr3) : null;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00074A80 File Offset: 0x00072C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593832, XrefRangeEnd = 593834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GenResolution(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00074AD0 File Offset: 0x00072CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593834, XrefRangeEnd = 593836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context GenParentContext(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00074B20 File Offset: 0x00072D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593836, XrefRangeEnd = 593837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GenSkippedResolution(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0000AE0B File Offset: 0x0000900B
		public ContinueActionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00074B70 File Offset: 0x00072D70
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x0000AE14 File Offset: 0x00009014
		public unsafe SerializedAction ResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_ResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_ResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00074BA0 File Offset: 0x00072DA0
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x0000AE33 File Offset: 0x00009033
		public unsafe SerializedContext ParentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_ParentContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_ParentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00074BD0 File Offset: 0x00072DD0
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000AE52 File Offset: 0x00009052
		public unsafe SerializedAction SkippedResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionGen;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeFieldInfoPtr_ParentContext;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr_SkippedResolutionGen;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_ContinueActionWithTargets_Action_Context_Match_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_MakeActsAcrossTargets_Private_ActionAcrossTargets_Match_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0;

		// Token: 0x02000465 RID: 1125
		[ObfuscatedName("Canis.actions.continuations.ContinueActionWithTargets+<MakeContinuationActions>d__5")]
		public sealed class _MakeContinuationActions_d__5 : Object
		{
			// Token: 0x06003230 RID: 12848 RVA: 0x000CE970 File Offset: 0x000CCB70
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeContinuationActions_d__5()
			{
				Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueActionWithTargets>.NativeClassPtr, "<MakeContinuationActions>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>1__state");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>2__current");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_selectionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "selectionResponse");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__selectionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>3__selectionResponse");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>4__this");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "match");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, "<>3__match");
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668453);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668454);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668455);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668456);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668457);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668458);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668459);
				ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr, 100668460);
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x000CEADC File Offset: 0x000CCCDC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeContinuationActions_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueActionWithTargets._MakeContinuationActions_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003232 RID: 12850 RVA: 0x000CEB24 File Offset: 0x000CCD24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003233 RID: 12851 RVA: 0x000CEB58 File Offset: 0x000CCD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593733, XrefRangeEnd = 593761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x06003234 RID: 12852 RVA: 0x000CEB94 File Offset: 0x000CCD94
			public unsafe ActionAcrossTargets System.Collections.Generic.IEnumerator<Canis.actions.continuations.ActionAcrossTargets>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr3) : null;
				}
			}

			// Token: 0x06003235 RID: 12853 RVA: 0x000CEBD4 File Offset: 0x000CCDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593761, XrefRangeEnd = 593766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06003236 RID: 12854 RVA: 0x000CEC08 File Offset: 0x000CCE08
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003237 RID: 12855 RVA: 0x000CEC48 File Offset: 0x000CCE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593766, XrefRangeEnd = 593776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ActionAcrossTargets> System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionAcrossTargets>>(intPtr3) : null;
			}

			// Token: 0x06003238 RID: 12856 RVA: 0x000CEC88 File Offset: 0x000CCE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003239 RID: 12857 RVA: 0x000180D5 File Offset: 0x000162D5
			public _MakeContinuationActions_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x0600323A RID: 12858 RVA: 0x000CECC8 File Offset: 0x000CCEC8
			// (set) Token: 0x0600323B RID: 12859 RVA: 0x000180DE File Offset: 0x000162DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D45 RID: 3397
			// (get) Token: 0x0600323C RID: 12860 RVA: 0x000CECF0 File Offset: 0x000CCEF0
			// (set) Token: 0x0600323D RID: 12861 RVA: 0x000180F9 File Offset: 0x000162F9
			public unsafe ActionAcrossTargets __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x0600323E RID: 12862 RVA: 0x000CED20 File Offset: 0x000CCF20
			// (set) Token: 0x0600323F RID: 12863 RVA: 0x00018118 File Offset: 0x00016318
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06003240 RID: 12864 RVA: 0x000CED48 File Offset: 0x000CCF48
			// (set) Token: 0x06003241 RID: 12865 RVA: 0x00018133 File Offset: 0x00016333
			public unsafe IEnumerable selectionResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_selectionResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_selectionResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06003242 RID: 12866 RVA: 0x000CED78 File Offset: 0x000CCF78
			// (set) Token: 0x06003243 RID: 12867 RVA: 0x00018152 File Offset: 0x00016352
			public unsafe IEnumerable __3__selectionResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__selectionResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__selectionResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06003244 RID: 12868 RVA: 0x000CEDA8 File Offset: 0x000CCFA8
			// (set) Token: 0x06003245 RID: 12869 RVA: 0x00018171 File Offset: 0x00016371
			public unsafe ContinueActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x06003246 RID: 12870 RVA: 0x000CEDD8 File Offset: 0x000CCFD8
			// (set) Token: 0x06003247 RID: 12871 RVA: 0x00018190 File Offset: 0x00016390
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x06003248 RID: 12872 RVA: 0x000CEE08 File Offset: 0x000CD008
			// (set) Token: 0x06003249 RID: 12873 RVA: 0x000181AF File Offset: 0x000163AF
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueActionWithTargets._MakeContinuationActions_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F62 RID: 8034
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F63 RID: 8035
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F64 RID: 8036
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F65 RID: 8037
			private static readonly IntPtr NativeFieldInfoPtr_selectionResponse;

			// Token: 0x04001F66 RID: 8038
			private static readonly IntPtr NativeFieldInfoPtr___3__selectionResponse;

			// Token: 0x04001F67 RID: 8039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F68 RID: 8040
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F69 RID: 8041
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001F6A RID: 8042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F6B RID: 8043
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F6C RID: 8044
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F6D RID: 8045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0;

			// Token: 0x04001F6E RID: 8046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F6F RID: 8047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F70 RID: 8048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0;

			// Token: 0x04001F71 RID: 8049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
