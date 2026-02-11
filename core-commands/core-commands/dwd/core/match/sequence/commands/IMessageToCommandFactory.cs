using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.sequence.commands
{
	// Token: 0x0200000B RID: 11
	public class IMessageToCommandFactory : Il2CppObjectBase
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000022D0 File Offset: 0x000004D0
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageToCommandFactory()
		{
			Il2CppClassPointerStore<IMessageToCommandFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence.commands", "IMessageToCommandFactory");
			IMessageToCommandFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Command_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageToCommandFactory>.NativeClassPtr, 100663328);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005844 File Offset: 0x00003A44
		[CallerCount(0)]
		public unsafe virtual Command Create(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageToCommandFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Command_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022FF File Offset: 0x000004FF
		public IMessageToCommandFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Command_Object_0;
	}
}
