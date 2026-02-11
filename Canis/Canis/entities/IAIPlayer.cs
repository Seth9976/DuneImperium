using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Networking.selection.messages;

namespace Canis.entities
{
	// Token: 0x020000DD RID: 221
	public class IAIPlayer : Il2CppObjectBase
	{
		// Token: 0x06000A30 RID: 2608 RVA: 0x00044A78 File Offset: 0x00042C78
		// Note: this type is marked as 'beforefieldinit'.
		static IAIPlayer()
		{
			Il2CppClassPointerStore<IAIPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IAIPlayer");
			IAIPlayer.NativeMethodInfoPtr_SelectFrom_Public_Abstract_Virtual_New_IEnumerator_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAIPlayer>.NativeClassPtr, 100665448);
			IAIPlayer.NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAIPlayer>.NativeClassPtr, 100665449);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00044AC8 File Offset: 0x00042CC8
		[CallerCount(0)]
		public unsafe virtual IEnumerator SelectFrom(SelectionMessage selection, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAIPlayer.NativeMethodInfoPtr_SelectFrom_Public_Abstract_Virtual_New_IEnumerator_SelectionMessage_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00044B38 File Offset: 0x00042D38
		[CallerCount(0)]
		public unsafe virtual bool IsInSelectionLoop(SelectionMessage selection, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAIPlayer.NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_SelectionMessage_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00005C8F File Offset: 0x00003E8F
		public IAIPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_SelectFrom_Public_Abstract_Virtual_New_IEnumerator_SelectionMessage_Match_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_SelectionMessage_Match_0;
	}
}
