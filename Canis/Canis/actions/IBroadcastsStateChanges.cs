using System;
using Canis.attributes;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001AB RID: 427
	public class IBroadcastsStateChanges : Il2CppObjectBase
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x00063C34 File Offset: 0x00061E34
		// Note: this type is marked as 'beforefieldinit'.
		static IBroadcastsStateChanges()
		{
			Il2CppClassPointerStore<IBroadcastsStateChanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IBroadcastsStateChanges");
			IBroadcastsStateChanges.NativeMethodInfoPtr_get_HasDirtyState_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBroadcastsStateChanges>.NativeClassPtr, 100667235);
			IBroadcastsStateChanges.NativeMethodInfoPtr_get_LatestState_Public_Abstract_Virtual_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBroadcastsStateChanges>.NativeClassPtr, 100667236);
			IBroadcastsStateChanges.NativeMethodInfoPtr_get_StateTargets_Public_Abstract_Virtual_New_get_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBroadcastsStateChanges>.NativeClassPtr, 100667237);
			IBroadcastsStateChanges.NativeMethodInfoPtr_ClearDirtyState_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBroadcastsStateChanges>.NativeClassPtr, 100667238);
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00063CAC File Offset: 0x00061EAC
		public unsafe virtual bool HasDirtyState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBroadcastsStateChanges.NativeMethodInfoPtr_get_HasDirtyState_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00063CF4 File Offset: 0x00061EF4
		public unsafe virtual IAttribute LatestState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBroadcastsStateChanges.NativeMethodInfoPtr_get_LatestState_Public_Abstract_Virtual_New_get_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00063D40 File Offset: 0x00061F40
		public unsafe virtual IEnumerable<Entity> StateTargets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBroadcastsStateChanges.NativeMethodInfoPtr_get_StateTargets_Public_Abstract_Virtual_New_get_IEnumerable_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00063D8C File Offset: 0x00061F8C
		[CallerCount(0)]
		public unsafe virtual void ClearDirtyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBroadcastsStateChanges.NativeMethodInfoPtr_ClearDirtyState_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00009141 File Offset: 0x00007341
		public IBroadcastsStateChanges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDirtyState_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_get_LatestState_Public_Abstract_Virtual_New_get_IAttribute_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_get_StateTargets_Public_Abstract_Virtual_New_get_IEnumerable_1_Entity_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_ClearDirtyState_Public_Abstract_Virtual_New_Void_0;
	}
}
