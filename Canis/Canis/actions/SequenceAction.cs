using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Canis.data;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.actions
{
	// Token: 0x020001DE RID: 478
	public class SequenceAction : WrappedAction
	{
		// Token: 0x0600143C RID: 5180 RVA: 0x0006AE84 File Offset: 0x00069084
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceAction()
		{
			Il2CppClassPointerStore<SequenceAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SequenceAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr);
			SequenceAction.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, "name");
			SequenceAction.NativeFieldInfoPtr_sequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, "sequenceID");
			SequenceAction.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, "attributes");
			SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_String_Match_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667747);
			SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667748);
			SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedSequenceAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667749);
			SequenceAction.NativeMethodInfoPtr_Has_Public_SequenceAction_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667750);
			SequenceAction.NativeMethodInfoPtr_PreAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667751);
			SequenceAction.NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667752);
			SequenceAction.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667753);
			SequenceAction.NativeMethodInfoPtr__PostAction_b__8_0_Private_Boolean_DBGSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr, 100667754);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0006AF90 File Offset: 0x00069190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 588691, RefRangeEnd = 588692, XrefRangeStart = 588684, XrefRangeEnd = 588691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceAction(string name, Match m, [Optional] Il2CppReferenceArray<Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Action>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_String_Match_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0006B00C File Offset: 0x0006920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588692, XrefRangeEnd = 588699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceAction(string name, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0006B06C File Offset: 0x0006926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588699, XrefRangeEnd = 588728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceAction(Match m, SerializedSequenceAction serializedSequenceAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializedSequenceAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceAction.NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedSequenceAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0006B0CC File Offset: 0x000692CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588728, XrefRangeEnd = 588736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceAction Has<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceAction.MethodInfoStoreGeneric_Has_Public_SequenceAction_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SequenceAction>(intPtr4) : null;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0006B164 File Offset: 0x00069364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588736, XrefRangeEnd = 588769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action PreAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceAction.NativeMethodInfoPtr_PreAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0006B1C0 File Offset: 0x000693C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588769, XrefRangeEnd = 588800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action PostAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceAction.NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006B21C File Offset: 0x0006941C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588800, XrefRangeEnd = 588807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedWrappedAction MakeSerializedWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceAction.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedWrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006B278 File Offset: 0x00069478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588807, XrefRangeEnd = 588811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PostAction_b__8_0(DBGSequence _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceAction.NativeMethodInfoPtr__PostAction_b__8_0_Private_Boolean_DBGSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00009DDA File Offset: 0x00007FDA
		public SequenceAction(string name, Match m, params Action[] actions)
			: this(name, m, new Il2CppReferenceArray<Action>(actions))
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00009DEA File Offset: 0x00007FEA
		public SequenceAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0006B2C8 File Offset: 0x000694C8
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x00009DF3 File Offset: 0x00007FF3
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0006B2F0 File Offset: 0x000694F0
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00009E12 File Offset: 0x00008012
		public unsafe SequenceID sequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_sequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_sequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0006B320 File Offset: 0x00069520
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00009E31 File Offset: 0x00008031
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceAction.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_sequenceID;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Match_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Match_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedSequenceAction_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_SequenceAction_AttributeDefinition_1_T_T_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_PreAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr__PostAction_b__8_0_Private_Boolean_DBGSequence_0;

		// Token: 0x0200041A RID: 1050
		private sealed class MethodInfoStoreGeneric_Has_Public_SequenceAction_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x04001CD7 RID: 7383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceAction.NativeMethodInfoPtr_Has_Public_SequenceAction_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<SequenceAction>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
