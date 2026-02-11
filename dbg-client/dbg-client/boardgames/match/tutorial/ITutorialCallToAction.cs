using System;
using Canis.attributes;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace boardgames.match.tutorial
{
	// Token: 0x02000254 RID: 596
	public class ITutorialCallToAction : Il2CppObjectBase
	{
		// Token: 0x06001B27 RID: 6951 RVA: 0x000760D4 File Offset: 0x000742D4
		// Note: this type is marked as 'beforefieldinit'.
		static ITutorialCallToAction()
		{
			Il2CppClassPointerStore<ITutorialCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "ITutorialCallToAction");
			ITutorialCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITutorialCallToAction>.NativeClassPtr, 100667637);
			ITutorialCallToAction.NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITutorialCallToAction>.NativeClassPtr, 100667638);
			ITutorialCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITutorialCallToAction>.NativeClassPtr, 100667639);
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00076138 File Offset: 0x00074338
		public unsafe virtual string Identifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITutorialCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0007617C File Offset: 0x0007437C
		[CallerCount(0)]
		public unsafe virtual IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITutorialCallToAction.NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000761D8 File Offset: 0x000743D8
		[CallerCount(0)]
		public unsafe virtual Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITutorialCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000ECCA File Offset: 0x0000CECA
		public ITutorialCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0;
	}
}
