using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001B5 RID: 437
	public class SerializedMatchAction<TMatch, TPlayer> : SerializedStateMachineAction where TMatch : Match where TPlayer : PlayerEntity
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x00064C54 File Offset: 0x00062E54
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMatchAction()
		{
			Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedMatchAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr);
			SerializedMatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_CurrentPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr, "CurrentPlayerID");
			SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667283);
			SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GenMatchAction_Protected_Abstract_Virtual_New_MatchAction_2_TMatch_TPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667284);
			SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667285);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00064D24 File Offset: 0x00062F24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375631, RefRangeEnd = 375635, XrefRangeStart = 375631, XrefRangeEnd = 375635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00064D74 File Offset: 0x00062F74
		[CallerCount(0)]
		public unsafe virtual MatchAction<TMatch, TPlayer> GenMatchAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GenMatchAction_Protected_Abstract_Virtual_New_MatchAction_2_TMatch_TPlayer_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchAction<TMatch, TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00064DD0 File Offset: 0x00062FD0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMatchAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMatchAction<TMatch, TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchAction<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000922E File Offset: 0x0000742E
		public SerializedMatchAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00064E0C File Offset: 0x0006300C
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00009237 File Offset: 0x00007437
		public unsafe AccountID CurrentPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_CurrentPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_CurrentPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPlayerID;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_GenMatchAction_Protected_Abstract_Virtual_New_MatchAction_2_TMatch_TPlayer_Match_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
