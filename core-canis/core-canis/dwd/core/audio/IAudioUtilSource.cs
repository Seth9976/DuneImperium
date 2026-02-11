using System;
using dwd.core.audio.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.audio
{
	// Token: 0x0200020D RID: 525
	public class IAudioUtilSource : Il2CppObjectBase
	{
		// Token: 0x06001CEA RID: 7402 RVA: 0x000863D0 File Offset: 0x000845D0
		// Note: this type is marked as 'beforefieldinit'.
		static IAudioUtilSource()
		{
			Il2CppClassPointerStore<IAudioUtilSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio", "IAudioUtilSource");
			IAudioUtilSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAudioUtilSource>.NativeClassPtr, 100667959);
			IAudioUtilSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAudioUtilSource>.NativeClassPtr, 100667960);
			IAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAudioUtilSource>.NativeClassPtr, 100667961);
			IAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAudioUtilSource>.NativeClassPtr, 100667962);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00086448 File Offset: 0x00084648
		[CallerCount(0)]
		public unsafe virtual AudioObject Play(string sound, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAudioUtilSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000864B8 File Offset: 0x000846B8
		[CallerCount(0)]
		public unsafe virtual AudioObject Play(string sound, Vector3 worldPosition, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAudioUtilSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Vector3_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00086534 File Offset: 0x00084734
		[CallerCount(0)]
		public unsafe virtual PlayAudioCommand PlayCommand(string sound, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000865A4 File Offset: 0x000847A4
		[CallerCount(0)]
		public unsafe virtual PlayAudioCommand PlayCommand(string sound, Vector3 worldPosition, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Vector3_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		public IAudioUtilSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Transform_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_AudioObject_String_Vector3_Transform_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Transform_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Abstract_Virtual_New_PlayAudioCommand_String_Vector3_Transform_0;
	}
}
