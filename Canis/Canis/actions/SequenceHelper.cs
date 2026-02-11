using System;
using Canis.attributes;
using Canis.data;
using Canis.entities;
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
	// Token: 0x020001E0 RID: 480
	public class SequenceHelper : Object
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x0006B504 File Offset: 0x00069704
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceHelper()
		{
			Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SequenceHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr);
			SequenceHelper.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, "name");
			SequenceHelper.NativeFieldInfoPtr_seq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, "seq");
			SequenceHelper.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, "attributes");
			SequenceHelper.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, "Match");
			SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667757);
			SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_String_SequenceID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667758);
			SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_DBGSequence_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667759);
			SequenceHelper.NativeMethodInfoPtr_Has_Public_SequenceHelper_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667760);
			SequenceHelper.NativeMethodInfoPtr_GetName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667761);
			SequenceHelper.NativeMethodInfoPtr_GetAttributes_Public_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667762);
			SequenceHelper.NativeMethodInfoPtr_SetAttributes_Public_Void_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667763);
			SequenceHelper.NativeMethodInfoPtr_Start_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667764);
			SequenceHelper.NativeMethodInfoPtr_Start_Public_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667765);
			SequenceHelper.NativeMethodInfoPtr_Resume_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667766);
			SequenceHelper.NativeMethodInfoPtr_Resume_Public_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667767);
			SequenceHelper.NativeMethodInfoPtr_Stop_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667768);
			SequenceHelper.NativeMethodInfoPtr_Stop_Public_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667769);
			SequenceHelper.NativeMethodInfoPtr_Suspend_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667770);
			SequenceHelper.NativeMethodInfoPtr_Suspend_Public_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667771);
			SequenceHelper.NativeMethodInfoPtr__Stop_b__15_0_Private_Boolean_DBGSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667772);
			SequenceHelper.NativeMethodInfoPtr__Stop_b__16_0_Private_Boolean_DBGSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr, 100667773);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0006B6D8 File Offset: 0x000698D8
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 588856, RefRangeEnd = 588927, XrefRangeStart = 588842, XrefRangeEnd = 588856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceHelper(string name, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0006B738 File Offset: 0x00069938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588936, RefRangeEnd = 588938, XrefRangeStart = 588927, XrefRangeEnd = 588936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceHelper(string name, SequenceID sequenceID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequenceID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_String_SequenceID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0006B7A8 File Offset: 0x000699A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588948, RefRangeEnd = 588950, XrefRangeStart = 588938, XrefRangeEnd = 588948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceHelper(DBGSequence sequence, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr__ctor_Public_Void_DBGSequence_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0006B808 File Offset: 0x00069A08
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 588953, RefRangeEnd = 588966, XrefRangeStart = 588950, XrefRangeEnd = 588953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceHelper Has<T>(AttributeDefinition<T> attribute, T value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.MethodInfoStoreGeneric_Has_Public_SequenceHelper_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr4) : null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0006B8A0 File Offset: 0x00069AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588966, XrefRangeEnd = 588970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_GetName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0006B8D8 File Offset: 0x00069AD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 588974, RefRangeEnd = 588978, XrefRangeStart = 588970, XrefRangeEnd = 588974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_GetAttributes_Public_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0006B918 File Offset: 0x00069B18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 588979, RefRangeEnd = 588982, XrefRangeStart = 588978, XrefRangeEnd = 588979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(MutableAttributes attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_SetAttributes_Public_Void_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0006B95C File Offset: 0x00069B5C
		[CallerCount(153)]
		[CachedScanResults(RefRangeStart = 589014, RefRangeEnd = 589167, XrefRangeStart = 588982, XrefRangeEnd = 589014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Start_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0006B99C File Offset: 0x00069B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 589199, RefRangeEnd = 589201, XrefRangeStart = 589167, XrefRangeEnd = 589199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Start(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Start_Public_Action_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0006B9EC File Offset: 0x00069BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 589210, RefRangeEnd = 589211, XrefRangeStart = 589201, XrefRangeEnd = 589210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Resume_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0006BA2C File Offset: 0x00069C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589211, XrefRangeEnd = 589220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Resume(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Resume_Public_Action_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006BA7C File Offset: 0x00069C7C
		[CallerCount(161)]
		[CachedScanResults(RefRangeStart = 589251, RefRangeEnd = 589412, XrefRangeStart = 589220, XrefRangeEnd = 589251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Stop_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0006BABC File Offset: 0x00069CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 589443, RefRangeEnd = 589445, XrefRangeStart = 589412, XrefRangeEnd = 589443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Stop(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Stop_Public_Action_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0006BB0C File Offset: 0x00069D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 589452, RefRangeEnd = 589453, XrefRangeStart = 589445, XrefRangeEnd = 589452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Suspend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Suspend_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0006BB4C File Offset: 0x00069D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589453, XrefRangeEnd = 589460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Suspend(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr_Suspend_Public_Action_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0006BB9C File Offset: 0x00069D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589460, XrefRangeEnd = 589464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Stop_b__15_0(DBGSequence _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr__Stop_b__15_0_Private_Boolean_DBGSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0006BBEC File Offset: 0x00069DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589464, XrefRangeEnd = 589468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Stop_b__16_0(DBGSequence _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceHelper.NativeMethodInfoPtr__Stop_b__16_0_Private_Boolean_DBGSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00009EB6 File Offset: 0x000080B6
		public SequenceHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006BC3C File Offset: 0x00069E3C
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00009EBF File Offset: 0x000080BF
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006BC64 File Offset: 0x00069E64
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00009EDE File Offset: 0x000080DE
		public unsafe SequenceID seq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_seq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_seq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006BC94 File Offset: 0x00069E94
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00009EFD File Offset: 0x000080FD
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00009F1C File Offset: 0x0000811C
		public unsafe Match Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_Match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceHelper.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_seq;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Match_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SequenceID_Match_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGSequence_Match_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_SequenceHelper_AttributeDefinition_1_T_T_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_MutableAttributes_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Public_Void_MutableAttributes_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Action_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Action_PlayerEntity_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Action_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Action_PlayerEntity_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Action_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Action_PlayerEntity_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_Suspend_Public_Action_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_Suspend_Public_Action_PlayerEntity_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr__Stop_b__15_0_Private_Boolean_DBGSequence_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr__Stop_b__16_0_Private_Boolean_DBGSequence_0;

		// Token: 0x0200041B RID: 1051
		private sealed class MethodInfoStoreGeneric_Has_Public_SequenceHelper_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x04001CD8 RID: 7384
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceHelper.NativeMethodInfoPtr_Has_Public_SequenceHelper_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<SequenceHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
