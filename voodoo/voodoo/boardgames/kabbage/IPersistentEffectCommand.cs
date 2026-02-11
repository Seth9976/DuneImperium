using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.kabbage
{
	// Token: 0x02000094 RID: 148
	public class IPersistentEffectCommand : Il2CppObjectBase
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x000267D4 File Offset: 0x000249D4
		// Note: this type is marked as 'beforefieldinit'.
		static IPersistentEffectCommand()
		{
			Il2CppClassPointerStore<IPersistentEffectCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "IPersistentEffectCommand");
			IPersistentEffectCommand.NativeMethodInfoPtr_TriggerOutro_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistentEffectCommand>.NativeClassPtr, 100664560);
			IPersistentEffectCommand.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistentEffectCommand>.NativeClassPtr, 100664561);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00026824 File Offset: 0x00024A24
		[CallerCount(0)]
		public unsafe virtual void TriggerOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPersistentEffectCommand.NativeMethodInfoPtr_TriggerOutro_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00026860 File Offset: 0x00024A60
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPersistentEffectCommand.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000643C File Offset: 0x0000463C
		public IPersistentEffectCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_TriggerOutro_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
