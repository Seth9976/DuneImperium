using System;
using System.Runtime.InteropServices;
using Canis.actions.serialized;
using Canis.analytics;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001BB RID: 443
	public class Move : Action
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x00065684 File Offset: 0x00063884
		// Note: this type is marked as 'beforefieldinit'.
		static Move()
		{
			Il2CppClassPointerStore<Move>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "Move");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Move>.NativeClassPtr);
			Move.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "destination");
			Move.NativeFieldInfoPtr_destinationGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "destinationGen");
			Move.NativeFieldInfoPtr_positionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "positionInParent");
			Move.NativeFieldInfoPtr_displayPositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "displayPositionInParent");
			Move.NativeFieldInfoPtr_analyticsBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "analyticsBuilder");
			Move.NativeFieldInfoPtr_SelectedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "SelectedTarget");
			Move.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667323);
			Move.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667324);
			Move.NativeMethodInfoPtr__ctor_Public_Void_SerializedMove_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667325);
			Move.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667326);
			Move.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667327);
			Move.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667328);
			Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667329);
			Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667330);
			Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_IEnumerable_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667331);
			Move.NativeMethodInfoPtr__execute_b__9_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100667332);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000657F4 File Offset: 0x000639F4
		[CallerCount(133)]
		[CachedScanResults(RefRangeStart = 585870, RefRangeEnd = 586003, XrefRangeStart = 585866, XrefRangeEnd = 585870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move(Entity destination, Match m, Nullable<int> positionInParent = null, Nullable<int> displayPositionInParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayPositionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00065880 File Offset: 0x00063A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586003, XrefRangeEnd = 586007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move(Func<Entity, Entity> destinationGen, Match m, Nullable<int> positionInParent = null, Nullable<int> displayPositionInParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destinationGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayPositionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0006590C File Offset: 0x00063B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586007, XrefRangeEnd = 586020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move(SerializedMove serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr__ctor_Public_Void_SerializedMove_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0006596C File Offset: 0x00063B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586020, XrefRangeEnd = 586026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Move.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000659B8 File Offset: 0x00063BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586026, XrefRangeEnd = 586034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Move.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00065A14 File Offset: 0x00063C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586034, XrefRangeEnd = 586040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00065A64 File Offset: 0x00063C64
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 586051, RefRangeEnd = 586063, XrefRangeStart = 586040, XrefRangeEnd = 586051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move WithAnalytics(string subEvent, [Optional] Il2CppReferenceArray<ValueTuple<string, Object>> data)
		{
			if (data == null)
			{
				data = new Il2CppStructArray<ValueTuple<string, Object>>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Move>(intPtr3) : null;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00065AD4 File Offset: 0x00063CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586063, XrefRangeEnd = 586095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move WithAnalytics(string subEvent, Dictionary<string, Object> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Move>(intPtr3) : null;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00065B38 File Offset: 0x00063D38
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 586109, RefRangeEnd = 586118, XrefRangeStart = 586095, XrefRangeEnd = 586109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Move WithAnalytics(string subEvent, IEnumerable<ValueTuple<string, Object>> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr_WithAnalytics_Public_Move_String_IEnumerable_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Move>(intPtr3) : null;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00065B9C File Offset: 0x00063D9C
		[CallerCount(0)]
		public unsafe bool _execute_b__9_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.NativeMethodInfoPtr__execute_b__9_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0000934C File Offset: 0x0000754C
		public Move WithAnalytics(string subEvent, params ValueTuple<string, Object>[] data)
		{
			return this.WithAnalytics(subEvent, new Il2CppReferenceArray<ValueTuple<string, Object>>(data));
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0000935B File Offset: 0x0000755B
		public Move(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00065BEC File Offset: 0x00063DEC
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x00009364 File Offset: 0x00007564
		public unsafe Entity destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00065C1C File Offset: 0x00063E1C
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00009383 File Offset: 0x00007583
		public unsafe Func<Entity, Entity> destinationGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_destinationGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_destinationGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00065C4C File Offset: 0x00063E4C
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x000093A2 File Offset: 0x000075A2
		public Nullable<int> positionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_positionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_positionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00065C7C File Offset: 0x00063E7C
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x000093D0 File Offset: 0x000075D0
		public Nullable<int> displayPositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_displayPositionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_displayPositionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00065CAC File Offset: 0x00063EAC
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x000093FE File Offset: 0x000075FE
		public unsafe AnalyticsMessageBuilder analyticsBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_analyticsBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_analyticsBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00065CDC File Offset: 0x00063EDC
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0000941D File Offset: 0x0000761D
		public unsafe Entity SelectedTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_SelectedTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move.NativeFieldInfoPtr_SelectedTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr_destination;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr_destinationGen;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_positionInParent;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr_displayPositionInParent;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_analyticsBuilder;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTarget;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_Nullable_1_Int32_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedMove_Match_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_WithAnalytics_Public_Move_String_Dictionary_2_String_Object_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_WithAnalytics_Public_Move_String_IEnumerable_1_ValueTuple_2_String_Object_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__9_0_Private_Boolean_Entity_0;

		// Token: 0x020003F0 RID: 1008
		[ObfuscatedName("Canis.actions.Move+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002B39 RID: 11065 RVA: 0x000B8834 File Offset: 0x000B6A34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Move.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Move>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Move.__c>.NativeClassPtr);
				Move.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move.__c>.NativeClassPtr, "<>9");
				Move.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move.__c>.NativeClassPtr, "<>9__13_0");
				Move.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move.__c>.NativeClassPtr, 100667334);
				Move.__c.NativeMethodInfoPtr__WithAnalytics_b__13_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move.__c>.NativeClassPtr, 100667335);
			}

			// Token: 0x06002B3A RID: 11066 RVA: 0x000B88B0 File Offset: 0x000B6AB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B3B RID: 11067 RVA: 0x000B88EC File Offset: 0x000B6AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585801, XrefRangeEnd = 585806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, Object> _WithAnalytics_b__13_0(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move.__c.NativeMethodInfoPtr__WithAnalytics_b__13_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06002B3C RID: 11068 RVA: 0x00014B1E File Offset: 0x00012D1E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000B893C File Offset: 0x000B6B3C
			// (set) Token: 0x06002B3E RID: 11070 RVA: 0x00014B27 File Offset: 0x00012D27
			public unsafe static Move.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Move.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Move.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Move.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000B8964 File Offset: 0x000B6B64
			// (set) Token: 0x06002B40 RID: 11072 RVA: 0x00014B39 File Offset: 0x00012D39
			public unsafe static Func<KeyValuePair<string, Object>, ValueTuple<string, Object>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Move.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, ValueTuple<string, Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Move.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B03 RID: 6915
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B04 RID: 6916
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04001B05 RID: 6917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B06 RID: 6918
			private static readonly IntPtr NativeMethodInfoPtr__WithAnalytics_b__13_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0;
		}

		// Token: 0x020003F1 RID: 1009
		[ObfuscatedName("Canis.actions.Move+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06002B41 RID: 11073 RVA: 0x000B898C File Offset: 0x000B6B8C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Move>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr);
				Move._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, "<>1__state");
				Move._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, "<>2__current");
				Move._execute_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, "<>l__initialThreadId");
				Move._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, "<>4__this");
				Move._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667336);
				Move._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667337);
				Move._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667338);
				Move._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667339);
				Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667340);
				Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667341);
				Move._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667342);
				Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr, 100667343);
			}

			// Token: 0x06002B42 RID: 11074 RVA: 0x000B8AA8 File Offset: 0x000B6CA8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B43 RID: 11075 RVA: 0x000B8AF0 File Offset: 0x000B6CF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B44 RID: 11076 RVA: 0x000B8B24 File Offset: 0x000B6D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585806, XrefRangeEnd = 585859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000B8B60 File Offset: 0x000B6D60
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x000B8BA0 File Offset: 0x000B6DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585859, XrefRangeEnd = 585864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000B8BD4 File Offset: 0x000B6DD4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B48 RID: 11080 RVA: 0x000B8C14 File Offset: 0x000B6E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585864, XrefRangeEnd = 585866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002B49 RID: 11081 RVA: 0x000B8C54 File Offset: 0x000B6E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Move._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B4A RID: 11082 RVA: 0x00014B4B File Offset: 0x00012D4B
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000B8C94 File Offset: 0x000B6E94
			// (set) Token: 0x06002B4C RID: 11084 RVA: 0x00014B54 File Offset: 0x00012D54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000B8CBC File Offset: 0x000B6EBC
			// (set) Token: 0x06002B4E RID: 11086 RVA: 0x00014B6F File Offset: 0x00012D6F
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000B8CEC File Offset: 0x000B6EEC
			// (set) Token: 0x06002B50 RID: 11088 RVA: 0x00014B8E File Offset: 0x00012D8E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000B8D14 File Offset: 0x000B6F14
			// (set) Token: 0x06002B52 RID: 11090 RVA: 0x00014BA9 File Offset: 0x00012DA9
			public unsafe Move __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Move>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Move._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B07 RID: 6919
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B08 RID: 6920
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B09 RID: 6921
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001B0A RID: 6922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B0B RID: 6923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B0C RID: 6924
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B0D RID: 6925
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B0E RID: 6926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001B0F RID: 6927
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B10 RID: 6928
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B11 RID: 6929
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001B12 RID: 6930
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
