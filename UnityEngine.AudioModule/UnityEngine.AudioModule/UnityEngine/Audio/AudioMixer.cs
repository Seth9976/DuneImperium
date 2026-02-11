using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x0200000E RID: 14
	public class AudioMixer : Object
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00006CE4 File Offset: 0x00004EE4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixer()
		{
			Il2CppClassPointerStore<AudioMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr);
			AudioMixer.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663426);
			AudioMixer.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663427);
			AudioMixer.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663428);
			AudioMixer.NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663429);
			AudioMixer.NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663430);
			AudioMixer.NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663431);
			AudioMixer.NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663432);
			AudioMixer.NativeMethodInfoPtr_TransitionToSnapshots_Public_Void_Il2CppReferenceArray_1_AudioMixerSnapshot_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663433);
			AudioMixer.NativeMethodInfoPtr_get_updateMode_Public_get_AudioMixerUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663434);
			AudioMixer.NativeMethodInfoPtr_set_updateMode_Public_set_Void_AudioMixerUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663435);
			AudioMixer.NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663436);
			AudioMixer.NativeMethodInfoPtr_ClearFloat_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663437);
			AudioMixer.NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663438);
			AudioMixer.NativeMethodInfoPtr_GetAbsoluteAudibilityFromGroup_Internal_Single_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663439);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006E2C File Offset: 0x0000502C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259401, XrefRangeEnd = 1259405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioMixer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006E68 File Offset: 0x00005068
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00006EA8 File Offset: 0x000050A8
		public unsafe AudioMixerGroup outputAudioMixerGroup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259405, XrefRangeEnd = 1259407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259407, XrefRangeEnd = 1259409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006EEC File Offset: 0x000050EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259409, XrefRangeEnd = 1259411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioMixerSnapshot FindSnapshot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006F3C File Offset: 0x0000513C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259411, XrefRangeEnd = 1259413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<AudioMixerGroup> FindMatchingGroups(string subPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioMixerGroup>>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006F8C File Offset: 0x0000518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259413, XrefRangeEnd = 1259458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapshot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeToReach;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006FDC File Offset: 0x000051DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259458, XrefRangeEnd = 1259460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapshot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeToReach;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000702C File Offset: 0x0000522C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259460, XrefRangeEnd = 1259462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToSnapshots(Il2CppReferenceArray<AudioMixerSnapshot> snapshots, Il2CppStructArray<float> weights, float timeToReach)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapshots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weights);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeToReach;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_TransitionToSnapshots_Public_Void_Il2CppReferenceArray_1_AudioMixerSnapshot_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00007090 File Offset: 0x00005290
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000070CC File Offset: 0x000052CC
		public unsafe AudioMixerUpdateMode updateMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259462, XrefRangeEnd = 1259464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_get_updateMode_Public_get_AudioMixerUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259464, XrefRangeEnd = 1259466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_set_updateMode_Public_set_Void_AudioMixerUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000710C File Offset: 0x0000530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259466, XrefRangeEnd = 1259468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007168 File Offset: 0x00005368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259468, XrefRangeEnd = 1259470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ClearFloat(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_ClearFloat_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000071B8 File Offset: 0x000053B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259470, XrefRangeEnd = 1259472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetFloat(string name, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00007214 File Offset: 0x00005414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259472, XrefRangeEnd = 1259474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAbsoluteAudibilityFromGroup(AudioMixerGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_GetAbsoluteAudibilityFromGroup_Internal_Single_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000026E6 File Offset: 0x000008E6
		public AudioMixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToSnapshots_Public_Void_Il2CppReferenceArray_1_AudioMixerSnapshot_Il2CppStructArray_1_Single_Single_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_updateMode_Public_get_AudioMixerUpdateMode_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_set_updateMode_Public_set_Void_AudioMixerUpdateMode_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_ClearFloat_Public_Boolean_String_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteAudibilityFromGroup_Internal_Single_AudioMixerGroup_0;
	}
}
