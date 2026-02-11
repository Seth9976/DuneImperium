using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000291 RID: 657
	public class SerializedSkipRunCombatSelection : SerializedAction
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x000C3804 File Offset: 0x000C1A04
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipRunCombatSelection()
		{
			Il2CppClassPointerStore<SerializedSkipRunCombatSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedSkipRunCombatSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipRunCombatSelection>.NativeClassPtr);
			SerializedSkipRunCombatSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipRunCombatSelection>.NativeClassPtr, 100668741);
			SerializedSkipRunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipRunCombatSelection>.NativeClassPtr, 100668742);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000C385C File Offset: 0x000C1A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146465, XrefRangeEnd = 146469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipRunCombatSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000C38B8 File Offset: 0x000C1AB8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipRunCombatSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipRunCombatSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipRunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0000BB80 File Offset: 0x00009D80
		public SerializedSkipRunCombatSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
