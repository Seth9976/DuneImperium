using System;
using Canis.entities;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x02000180 RID: 384
	public class IMessageActionFactory : Il2CppObjectBase
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x000087CD File Offset: 0x000069CD
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageActionFactory()
		{
			Il2CppClassPointerStore<IMessageActionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IMessageActionFactory");
			IMessageActionFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageActionFactory>.NativeClassPtr, 100666816);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0005E224 File Offset: 0x0005C424
		[CallerCount(0)]
		public unsafe virtual Action Create(NetworkMessageEvent message, Match m, PlayerEntity player, bool waitForResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageActionFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x000087FC File Offset: 0x000069FC
		public IMessageActionFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0;
	}
}
