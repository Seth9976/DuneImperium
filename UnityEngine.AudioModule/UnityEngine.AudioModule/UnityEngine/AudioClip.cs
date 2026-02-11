using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public sealed class AudioClip : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003714 File Offset: 0x00001914
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClip()
		{
			Il2CppClassPointerStore<AudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClip>.NativeClassPtr);
			AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMReaderCallback");
			AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMSetPositionCallback");
			AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663303);
			AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663304);
			AudioClip.NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663305);
			AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663306);
			AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663307);
			AudioClip.GetDataDelegateField = IL2CPP.ResolveICall<AudioClip.GetDataDelegate>("UnityEngine.AudioClip::GetData");
			AudioClip.SetDataDelegateField = IL2CPP.ResolveICall<AudioClip.SetDataDelegate>("UnityEngine.AudioClip::SetData");
			AudioClip.Construct_InternalDelegateField = IL2CPP.ResolveICall<AudioClip.Construct_InternalDelegate>("UnityEngine.AudioClip::Construct_Internal");
			AudioClip.GetNameDelegateField = IL2CPP.ResolveICall<AudioClip.GetNameDelegate>("UnityEngine.AudioClip::GetName");
			AudioClip.CreateUserSoundDelegateField = IL2CPP.ResolveICall<AudioClip.CreateUserSoundDelegate>("UnityEngine.AudioClip::CreateUserSound");
			AudioClip.get_samplesDelegateField = IL2CPP.ResolveICall<AudioClip.get_samplesDelegate>("UnityEngine.AudioClip::get_samples");
			AudioClip.get_channelsDelegateField = IL2CPP.ResolveICall<AudioClip.get_channelsDelegate>("UnityEngine.AudioClip::get_channels");
			AudioClip.get_frequencyDelegateField = IL2CPP.ResolveICall<AudioClip.get_frequencyDelegate>("UnityEngine.AudioClip::get_frequency");
			AudioClip.get_isReadyToPlayDelegateField = IL2CPP.ResolveICall<AudioClip.get_isReadyToPlayDelegate>("UnityEngine.AudioClip::get_isReadyToPlay");
			AudioClip.get_loadTypeDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadTypeDelegate>("UnityEngine.AudioClip::get_loadType");
			AudioClip.LoadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.LoadAudioDataDelegate>("UnityEngine.AudioClip::LoadAudioData");
			AudioClip.get_preloadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.get_preloadAudioDataDelegate>("UnityEngine.AudioClip::get_preloadAudioData");
			AudioClip.get_ambisonicDelegateField = IL2CPP.ResolveICall<AudioClip.get_ambisonicDelegate>("UnityEngine.AudioClip::get_ambisonic");
			AudioClip.get_loadInBackgroundDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadInBackgroundDelegate>("UnityEngine.AudioClip::get_loadInBackground");
			AudioClip.get_loadStateDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadStateDelegate>("UnityEngine.AudioClip::get_loadState");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000038B4 File Offset: 0x00001AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258918, XrefRangeEnd = 1258924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000038F0 File Offset: 0x00001AF0
		public unsafe float length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258924, XrefRangeEnd = 1258926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000392C File Offset: 0x00001B2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1258928, RefRangeEnd = 1258931, XrefRangeStart = 1258926, XrefRangeEnd = 1258928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnloadAudioData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003968 File Offset: 0x00001B68
		[CallerCount(0)]
		public unsafe void InvokePCMReaderCallback_Internal(Il2CppStructArray<float> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000039AC File Offset: 0x00001BAC
		[CallerCount(0)]
		public unsafe void InvokePCMSetPositionCallback_Internal(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002169 File Offset: 0x00000369
		public AudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000039EC File Offset: 0x00001BEC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002172 File Offset: 0x00000372
		public unsafe AudioClip.PCMReaderCallback m_PCMReaderCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMReaderCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003A1C File Offset: 0x00001C1C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002191 File Offset: 0x00000391
		public unsafe AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMSetPositionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021B0 File Offset: 0x000003B0
		public static bool GetData(AudioClip clip, [Out] Il2CppStructArray<float> data, int numSamples, int samplesOffset)
		{
			return AudioClip.GetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.Il2CppObjectBaseToPtr(data), numSamples, samplesOffset);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021CA File Offset: 0x000003CA
		public static bool SetData(AudioClip clip, Il2CppStructArray<float> data, int numsamples, int samplesOffset)
		{
			return AudioClip.SetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.Il2CppObjectBaseToPtr(data), numsamples, samplesOffset);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003A4C File Offset: 0x00001C4C
		public static AudioClip Construct_Internal()
		{
			IntPtr intPtr = AudioClip.Construct_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003A74 File Offset: 0x00001C74
		public string GetName()
		{
			IntPtr intPtr = AudioClip.GetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021E4 File Offset: 0x000003E4
		public void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			AudioClip.CreateUserSoundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), lengthSamples, channels, frequency, stream);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002202 File Offset: 0x00000402
		public int samples
		{
			get
			{
				return AudioClip.get_samplesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002214 File Offset: 0x00000414
		public int channels
		{
			get
			{
				return AudioClip.get_channelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002226 File Offset: 0x00000426
		public int frequency
		{
			get
			{
				return AudioClip.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002238 File Offset: 0x00000438
		public bool isReadyToPlay
		{
			get
			{
				return AudioClip.get_isReadyToPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000224A File Offset: 0x0000044A
		public AudioClipLoadType loadType
		{
			get
			{
				return AudioClip.get_loadTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000225C File Offset: 0x0000045C
		public bool LoadAudioData()
		{
			return AudioClip.LoadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000226E File Offset: 0x0000046E
		public bool preloadAudioData
		{
			get
			{
				return AudioClip.get_preloadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002280 File Offset: 0x00000480
		public bool ambisonic
		{
			get
			{
				return AudioClip.get_ambisonicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002292 File Offset: 0x00000492
		public bool loadInBackground
		{
			get
			{
				return AudioClip.get_loadInBackgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000022A4 File Offset: 0x000004A4
		public AudioDataLoadState loadState
		{
			get
			{
				return AudioClip.get_loadStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A98 File Offset: 0x00001C98
		public bool GetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			bool flag = this.channels <= 0;
			bool flag2;
			if (flag)
			{
				Debug.Log(String.Concat("AudioClip.GetData failed; AudioClip ", this.GetName(), " contains no data"));
				flag2 = false;
			}
			else
			{
				int num = ((data != null) ? (data.Length / this.channels) : 0);
				flag2 = AudioClip.GetData(this, data, num, offsetSamples);
			}
			return flag2;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public bool SetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			bool flag = this.channels <= 0;
			bool flag2;
			if (flag)
			{
				Debug.Log(String.Concat("AudioClip.SetData failed; AudioClip ", this.GetName(), " contains no data"));
				flag2 = false;
			}
			else
			{
				bool flag3 = offsetSamples < 0 || offsetSamples >= this.samples;
				if (flag3)
				{
					throw new ArgumentException("AudioClip.SetData failed; invalid offsetSamples");
				}
				bool flag4 = data == null || data.Length == 0;
				if (flag4)
				{
					throw new ArgumentException("AudioClip.SetData failed; invalid data");
				}
				flag2 = AudioClip.SetData(this, data, data.Length / this.channels, offsetSamples);
			}
			return flag2;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003B90 File Offset: 0x00001D90
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, null, null);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003C18 File Offset: 0x00001E18
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003C3C File Offset: 0x00001E3C
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			bool flag2 = lengthSamples <= 0;
			if (flag2)
			{
				throw new ArgumentException("Length of created clip must be larger than 0");
			}
			bool flag3 = channels <= 0;
			if (flag3)
			{
				throw new ArgumentException("Number of channels in created clip must be greater than 0");
			}
			bool flag4 = frequency <= 0;
			if (flag4)
			{
				throw new ArgumentException("Frequency in created clip must be greater than 0");
			}
			AudioClip audioClip = AudioClip.Construct_Internal();
			bool flag5 = pcmreadercallback != null;
			if (flag5)
			{
				audioClip.add_m_PCMReaderCallback(pcmreadercallback);
			}
			bool flag6 = pcmsetpositioncallback != null;
			if (flag6)
			{
				audioClip.add_m_PCMSetPositionCallback(pcmsetpositioncallback);
			}
			audioClip.CreateUserSound(name, lengthSamples, channels, frequency, stream);
			return audioClip;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000022B6 File Offset: 0x000004B6
		public void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022C3 File Offset: 0x000004C3
		public void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022D0 File Offset: 0x000004D0
		public void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022DD File Offset: 0x000004DD
		public void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMReaderCallback;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMSetPositionCallback;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0;

		// Token: 0x0400002C RID: 44
		private static readonly AudioClip.GetDataDelegate GetDataDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly AudioClip.SetDataDelegate SetDataDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly AudioClip.Construct_InternalDelegate Construct_InternalDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly AudioClip.GetNameDelegate GetNameDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly AudioClip.CreateUserSoundDelegate CreateUserSoundDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly AudioClip.get_samplesDelegate get_samplesDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly AudioClip.get_channelsDelegate get_channelsDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly AudioClip.get_frequencyDelegate get_frequencyDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly AudioClip.get_isReadyToPlayDelegate get_isReadyToPlayDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly AudioClip.get_loadTypeDelegate get_loadTypeDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly AudioClip.LoadAudioDataDelegate LoadAudioDataDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly AudioClip.get_preloadAudioDataDelegate get_preloadAudioDataDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly AudioClip.get_ambisonicDelegate get_ambisonicDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly AudioClip.get_loadInBackgroundDelegate get_loadInBackgroundDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly AudioClip.get_loadStateDelegate get_loadStateDelegateField;

		// Token: 0x02000038 RID: 56
		public sealed class PCMReaderCallback : MulticastDelegate
		{
			// Token: 0x0600022D RID: 557 RVA: 0x000032D6 File Offset: 0x000014D6
			// Note: this type is marked as 'beforefieldinit'.
			static PCMReaderCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMReaderCallback");
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663308);
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663309);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x000084D4 File Offset: 0x000066D4
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMReaderCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00008530 File Offset: 0x00006730
			[CallerCount(0)]
			public unsafe void Invoke(Il2CppStructArray<float> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00003314 File Offset: 0x00001514
			public PCMReaderCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000231 RID: 561 RVA: 0x0000331D File Offset: 0x0000151D
			public static implicit operator AudioClip.PCMReaderCallback(Action<Il2CppStructArray<float>> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMReaderCallback>(A_0);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00003325 File Offset: 0x00001525
			public static AudioClip.PCMReaderCallback operator +(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMReaderCallback>();
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00003333 File Offset: 0x00001533
			public static AudioClip.PCMReaderCallback operator -(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMReaderCallback>();
				}
				return delegate2;
			}

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0;
		}

		// Token: 0x02000039 RID: 57
		public sealed class PCMSetPositionCallback : MulticastDelegate
		{
			// Token: 0x06000234 RID: 564 RVA: 0x00003344 File Offset: 0x00001544
			// Note: this type is marked as 'beforefieldinit'.
			static PCMSetPositionCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMSetPositionCallback");
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663310);
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663311);
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00008574 File Offset: 0x00006774
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 677799, RefRangeEnd = 677853, XrefRangeStart = 677799, XrefRangeEnd = 677853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMSetPositionCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000236 RID: 566 RVA: 0x000085D0 File Offset: 0x000067D0
			[CallerCount(0)]
			public unsafe void Invoke(int position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00003382 File Offset: 0x00001582
			public PCMSetPositionCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000338B File Offset: 0x0000158B
			public static implicit operator AudioClip.PCMSetPositionCallback(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMSetPositionCallback>(A_0);
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00003393 File Offset: 0x00001593
			public static AudioClip.PCMSetPositionCallback operator +(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMSetPositionCallback>();
			}

			// Token: 0x0600023A RID: 570 RVA: 0x000033A1 File Offset: 0x000015A1
			public static AudioClip.PCMSetPositionCallback operator -(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMSetPositionCallback>();
				}
				return delegate2;
			}

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate bool GetDataDelegate(IntPtr clip, [Out] IntPtr data, int numSamples, int samplesOffset);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate bool SetDataDelegate(IntPtr clip, IntPtr data, int numsamples, int samplesOffset);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate IntPtr Construct_InternalDelegate();

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate IntPtr GetNameDelegate(IntPtr @this);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate void CreateUserSoundDelegate(IntPtr @this, IntPtr name, int lengthSamples, int channels, int frequency, bool stream);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate int get_samplesDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate int get_channelsDelegate(IntPtr @this);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate int get_frequencyDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate bool get_isReadyToPlayDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate AudioClipLoadType get_loadTypeDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate bool LoadAudioDataDelegate(IntPtr @this);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate bool get_preloadAudioDataDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate bool get_ambisonicDelegate(IntPtr @this);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000256 RID: 598
		private delegate bool get_loadInBackgroundDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000258 RID: 600
		private delegate AudioDataLoadState get_loadStateDelegate(IntPtr @this);
	}
}
