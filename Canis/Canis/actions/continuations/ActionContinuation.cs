using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x02000220 RID: 544
	public class ActionContinuation : Object
	{
		// Token: 0x060016A6 RID: 5798 RVA: 0x00074404 File Offset: 0x00072604
		// Note: this type is marked as 'beforefieldinit'.
		static ActionContinuation()
		{
			Il2CppClassPointerStore<ActionContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ActionContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionContinuation>.NativeClassPtr);
			ActionContinuation.NativeMethodInfoPtr_MakeContinuationActions_Public_Abstract_Virtual_New_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionContinuation>.NativeClassPtr, 100668431);
			ActionContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionContinuation>.NativeClassPtr, 100668432);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0007445C File Offset: 0x0007265C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ActionAcrossTargets> MakeContinuationActions(IEnumerable selectionResponse, PlayerEntity selectingPlayer, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionContinuation.NativeMethodInfoPtr_MakeContinuationActions_Public_Abstract_Virtual_New_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000744DC File Offset: 0x000726DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionContinuation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionContinuation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0000AD93 File Offset: 0x00008F93
		public ActionContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuationActions_Public_Abstract_Virtual_New_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
