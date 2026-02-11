using System;
using dwd.core.audio.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.audio
{
	// Token: 0x0200020C RID: 524
	public static class AudioUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x00086000 File Offset: 0x00084200
		// Note: this type is marked as 'beforefieldinit'.
		static AudioUtil()
		{
			Il2CppClassPointerStore<AudioUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio", "AudioUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr);
			AudioUtil.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, "_source");
			AudioUtil.NativeMethodInfoPtr_get_source_Private_Static_get_IAudioUtilSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667950);
			AudioUtil.NativeMethodInfoPtr_set_source_Private_Static_set_Void_IAudioUtilSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667951);
			AudioUtil.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667952);
			AudioUtil.NativeMethodInfoPtr_SetSource_Public_Static_Void_IAudioUtilSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667953);
			AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667954);
			AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667955);
			AudioUtil.NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667956);
			AudioUtil.NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667957);
			AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_PlayAudioLocation_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100667958);
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000860F8 File Offset: 0x000842F8
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0008612C File Offset: 0x0008432C
		public unsafe static IAudioUtilSource source
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 886019, RefRangeEnd = 886023, XrefRangeStart = 886009, XrefRangeEnd = 886019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_get_source_Private_Static_get_IAudioUtilSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAudioUtilSource>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886023, XrefRangeEnd = 886033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_set_source_Private_Static_set_Void_IAudioUtilSource_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00086164 File Offset: 0x00084364
		public unsafe static bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886033, XrefRangeEnd = 886035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00086194 File Offset: 0x00084394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSource(IAudioUtilSource source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_SetSource_Public_Static_Void_IAudioUtilSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000861CC File Offset: 0x000843CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 886041, RefRangeEnd = 886050, XrefRangeStart = 886035, XrefRangeEnd = 886041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioObject Play(string sound, Transform parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00086224 File Offset: 0x00084424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886054, RefRangeEnd = 886055, XrefRangeStart = 886050, XrefRangeEnd = 886054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioObject Play(string sound, Vector3 worldPosition, Transform parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00086288 File Offset: 0x00084488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886055, XrefRangeEnd = 886061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayAudioCommand PlayCommand(string sound, Transform parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000862E0 File Offset: 0x000844E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886061, XrefRangeEnd = 886065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayAudioCommand PlayCommand(string sound, Vector3 worldPosition, Transform parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Vector3_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAudioCommand>(intPtr3) : null;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00086344 File Offset: 0x00084544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886067, RefRangeEnd = 886068, XrefRangeStart = 886065, XrefRangeEnd = 886067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioObject Play(string sound, PlayAudioLocation location, Transform parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref location;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_PlayAudioLocation_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0000C585 File Offset: 0x0000A785
		public AudioUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000863A8 File Offset: 0x000845A8
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0000C58E File Offset: 0x0000A78E
		public unsafe static IAudioUtilSource _source
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioUtil.NativeFieldInfoPtr__source, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAudioUtilSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioUtil.NativeFieldInfoPtr__source, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Private_Static_get_IAudioUtilSource_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_set_source_Private_Static_set_Void_IAudioUtilSource_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Static_Void_IAudioUtilSource_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Transform_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_PlayCommand_Public_Static_PlayAudioCommand_String_Vector3_Transform_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_PlayAudioLocation_Transform_0;
	}
}
