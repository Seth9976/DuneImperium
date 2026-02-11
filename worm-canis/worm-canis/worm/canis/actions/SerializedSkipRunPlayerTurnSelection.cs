using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000298 RID: 664
	public class SerializedSkipRunPlayerTurnSelection : SerializedAction
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x000C46E0 File Offset: 0x000C28E0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipRunPlayerTurnSelection()
		{
			Il2CppClassPointerStore<SerializedSkipRunPlayerTurnSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedSkipRunPlayerTurnSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipRunPlayerTurnSelection>.NativeClassPtr);
			SerializedSkipRunPlayerTurnSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipRunPlayerTurnSelection>.NativeClassPtr, 100668827);
			SerializedSkipRunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipRunPlayerTurnSelection>.NativeClassPtr, 100668828);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000C4738 File Offset: 0x000C2938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146985, XrefRangeEnd = 146989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipRunPlayerTurnSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000C4794 File Offset: 0x000C2994
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipRunPlayerTurnSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipRunPlayerTurnSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipRunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0000BD2A File Offset: 0x00009F2A
		public SerializedSkipRunPlayerTurnSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
