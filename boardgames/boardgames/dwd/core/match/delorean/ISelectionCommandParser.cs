using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;

namespace dwd.core.match.delorean
{
	// Token: 0x0200009F RID: 159
	public class ISelectionCommandParser : Il2CppObjectBase
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00029338 File Offset: 0x00027538
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionCommandParser()
		{
			Il2CppClassPointerStore<ISelectionCommandParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.delorean", "ISelectionCommandParser");
			ISelectionCommandParser.NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionCommandParser>.NativeClassPtr, 100664521);
			ISelectionCommandParser.NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionFinished_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionCommandParser>.NativeClassPtr, 100664522);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00029388 File Offset: 0x00027588
		[CallerCount(0)]
		public unsafe virtual Command GetCommand(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionCommandParser.NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000293E4 File Offset: 0x000275E4
		[CallerCount(0)]
		public unsafe virtual Command GetCommand(SelectionFinished message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionCommandParser.NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionFinished_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000576F File Offset: 0x0000396F
		public ISelectionCommandParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionMessage_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Abstract_Virtual_New_Command_SelectionFinished_0;
	}
}
