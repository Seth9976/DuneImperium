using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.actions
{
	// Token: 0x020001AC RID: 428
	public class IEventFiredCommand : Il2CppObjectBase
	{
		// Token: 0x06001267 RID: 4711 RVA: 0x00063DC8 File Offset: 0x00061FC8
		// Note: this type is marked as 'beforefieldinit'.
		static IEventFiredCommand()
		{
			Il2CppClassPointerStore<IEventFiredCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IEventFiredCommand");
			IEventFiredCommand.NativeMethodInfoPtr_FiredBy_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventFiredCommand>.NativeClassPtr, 100667239);
			IEventFiredCommand.NativeMethodInfoPtr_IsRepeatable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventFiredCommand>.NativeClassPtr, 100667240);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00063E18 File Offset: 0x00062018
		[CallerCount(0)]
		public unsafe virtual bool FiredBy(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventFiredCommand.NativeMethodInfoPtr_FiredBy_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00063E70 File Offset: 0x00062070
		[CallerCount(0)]
		public unsafe virtual bool IsRepeatable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventFiredCommand.NativeMethodInfoPtr_IsRepeatable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0000914A File Offset: 0x0000734A
		public IEventFiredCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_FiredBy_Public_Abstract_Virtual_New_Boolean_Context_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_IsRepeatable_Public_Abstract_Virtual_New_Boolean_0;
	}
}
