using System;
using dwd.core.audio.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.audio
{
	// Token: 0x0200020E RID: 526
	public class DefaultAudioUtilSource : global::Il2CppSystem.Object
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x00086620 File Offset: 0x00084820
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultAudioUtilSource()
		{
			Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio", "DefaultAudioUtilSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr);
			DefaultAudioUtilSource.NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr, 100667963);
			DefaultAudioUtilSource.NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr, 100667964);
			DefaultAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr, 100667965);
			DefaultAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr, 100667966);
			DefaultAudioUtilSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr, 100667967);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000866B4 File Offset: 0x000848B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886068, XrefRangeEnd = 886080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAudioUtilSource.NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00086724 File Offset: 0x00084924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886080, XrefRangeEnd = 886097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AudioObject Play(string sound, Transform parent = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAudioUtilSource.NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00086788 File Offset: 0x00084988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886097, XrefRangeEnd = 886103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PlayAudioCommand PlayCommand(string sound, Transform parent = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000867EC File Offset: 0x000849EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886103, XrefRangeEnd = 886109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAudioUtilSource.NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0008685C File Offset: 0x00084A5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultAudioUtilSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultAudioUtilSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAudioUtilSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0000C5A9 File Offset: 0x0000A7A9
		public DefaultAudioUtilSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Vector3_Transform_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Final_New_AudioObject_String_Transform_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Transform_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Virtual_Final_New_PlayAudioCommand_String_Vector3_Transform_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
