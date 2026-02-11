using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200025F RID: 607
	public class IPlayableBehaviour : Il2CppObjectBase
	{
		// Token: 0x06002981 RID: 10625 RVA: 0x000ABEA8 File Offset: 0x000AA0A8
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableBehaviour()
		{
			Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableBehaviour");
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668526);
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668527);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668528);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668529);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668530);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668531);
			IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668532);
			IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100668533);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000ABF70 File Offset: 0x000AA170
		[CallerCount(0)]
		public unsafe virtual void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000ABFBC File Offset: 0x000AA1BC
		[CallerCount(0)]
		public unsafe virtual void OnGraphStop(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000AC008 File Offset: 0x000AA208
		[CallerCount(0)]
		public unsafe virtual void OnPlayableCreate(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000AC054 File Offset: 0x000AA254
		[CallerCount(0)]
		public unsafe virtual void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000AC0F8 File Offset: 0x000AA2F8
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000AC150 File Offset: 0x000AA350
		[CallerCount(0)]
		public unsafe virtual void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000AC1A8 File Offset: 0x000AA3A8
		[CallerCount(0)]
		public unsafe virtual void ProcessFrame(Playable playable, FrameData info, Object playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000101C7 File Offset: 0x0000E3C7
		public IPlayableBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0;
	}
}
