using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.commands
{
	// Token: 0x02000030 RID: 48
	public class ICommandQueue : Il2CppObjectBase
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		// Note: this type is marked as 'beforefieldinit'.
		static ICommandQueue()
		{
			Il2CppClassPointerStore<ICommandQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "ICommandQueue");
			ICommandQueue.NativeMethodInfoPtr_get_Active_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommandQueue>.NativeClassPtr, 100663808);
			ICommandQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommandQueue>.NativeClassPtr, 100663809);
			ICommandQueue.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommandQueue>.NativeClassPtr, 100663810);
			ICommandQueue.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommandQueue>.NativeClassPtr, 100663811);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000C064 File Offset: 0x0000A264
		public unsafe virtual bool Active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommandQueue.NativeMethodInfoPtr_get_Active_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		[CallerCount(0)]
		public unsafe virtual void Enqueue(Command command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommandQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		[CallerCount(0)]
		public unsafe virtual bool Contains(Command command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommandQueue.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000C154 File Offset: 0x0000A354
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommandQueue.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002C30 File Offset: 0x00000E30
		public ICommandQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_Command_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Command_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
	}
}
