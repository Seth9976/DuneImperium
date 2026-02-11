using System;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.actions.continuations
{
	// Token: 0x02000228 RID: 552
	public class IHasManySelectors : Il2CppObjectBase
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x0000AF8F File Offset: 0x0000918F
		// Note: this type is marked as 'beforefieldinit'.
		static IHasManySelectors()
		{
			Il2CppClassPointerStore<IHasManySelectors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "IHasManySelectors");
			IHasManySelectors.NativeMethodInfoPtr_HandleOtherSelection_Public_Abstract_Virtual_New_Void_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasManySelectors>.NativeClassPtr, 100668506);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00075928 File Offset: 0x00073B28
		[CallerCount(0)]
		public unsafe virtual void HandleOtherSelection(PlayerEntity selectingPlayer, PendingSelection otherSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasManySelectors.NativeMethodInfoPtr_HandleOtherSelection_Public_Abstract_Virtual_New_Void_PlayerEntity_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0000AFBE File Offset: 0x000091BE
		public IHasManySelectors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_HandleOtherSelection_Public_Abstract_Virtual_New_Void_PlayerEntity_PendingSelection_0;
	}
}
