using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x0200000B RID: 11
	public class AudioSampleProvider : Object
	{
		// Token: 0x060000BB RID: 187 RVA: 0x000061FC File Offset: 0x000043FC
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSampleProvider()
		{
			Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Experimental.Audio", "AudioSampleProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr);
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesAvailable");
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesOverflow");
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663420);
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663421);
			AudioSampleProvider.InternalCreateSampleProviderDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalCreateSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalCreateSampleProvider");
			AudioSampleProvider.InternalRemoveDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalRemoveDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalRemove");
			AudioSampleProvider.InternalGetFormatInfoDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFormatInfoDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFormatInfo");
			AudioSampleProvider.InternalGetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetScriptingPtr");
			AudioSampleProvider.InternalSetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetScriptingPtr");
			AudioSampleProvider.InternalIsValidDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalIsValidDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalIsValid");
			AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetMaxSampleFrameCount");
			AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetAvailableSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSilencePadding");
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSilencePadding");
			AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetConsumeSampleFramesNativeFunctionPtr");
			AudioSampleProvider.InternalQueueSampleFramesDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalQueueSampleFramesDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalQueueSampleFrames");
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000063B8 File Offset: 0x000045B8
		[CallerCount(0)]
		public unsafe void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000063F8 File Offset: 0x000045F8
		[CallerCount(0)]
		public unsafe void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref droppedSampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000233E File Offset: 0x0000053E
		public AudioSampleProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00006438 File Offset: 0x00004638
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002347 File Offset: 0x00000547
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002366 File Offset: 0x00000566
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006498 File Offset: 0x00004698
		public static AudioSampleProvider Lookup(uint providerId, Object ownerObj, ushort trackIndex)
		{
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.InternalGetScriptingPtr(providerId);
			bool flag = audioSampleProvider != null || !AudioSampleProvider.InternalIsValid(providerId);
			AudioSampleProvider audioSampleProvider2;
			if (flag)
			{
				audioSampleProvider2 = audioSampleProvider;
			}
			else
			{
				audioSampleProvider2 = new AudioSampleProvider(providerId, ownerObj, trackIndex);
			}
			return audioSampleProvider2;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000064D0 File Offset: 0x000046D0
		public static AudioSampleProvider Create(ushort channelCount, uint sampleRate)
		{
			uint num = AudioSampleProvider.InternalCreateSampleProvider(channelCount, sampleRate);
			bool flag = !AudioSampleProvider.InternalIsValid(num);
			AudioSampleProvider audioSampleProvider;
			if (flag)
			{
				audioSampleProvider = null;
			}
			else
			{
				audioSampleProvider = new AudioSampleProvider(num, null, 0);
			}
			return audioSampleProvider;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006504 File Offset: 0x00004704
		public ~AudioSampleProvider()
		{
			this.owner = null;
			this.Dispose();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000653C File Offset: 0x0000473C
		public void Dispose()
		{
			bool flag = this.id > 0U;
			if (flag)
			{
				AudioSampleProvider.InternalSetScriptingPtr(this.id, null);
				bool flag2 = this.owner == null;
				if (flag2)
				{
					AudioSampleProvider.InternalRemove(this.id);
				}
				this.id = 0U;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002385 File Offset: 0x00000585
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002392 File Offset: 0x00000592
		public uint id
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000239F File Offset: 0x0000059F
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000023AC File Offset: 0x000005AC
		public ushort trackIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000023B9 File Offset: 0x000005B9
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000023C6 File Offset: 0x000005C6
		public Object owner
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00006594 File Offset: 0x00004794
		public bool valid
		{
			get
			{
				return AudioSampleProvider.InternalIsValid(this.id);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000023D3 File Offset: 0x000005D3
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000023E0 File Offset: 0x000005E0
		public ushort channelCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000023ED File Offset: 0x000005ED
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000023FA File Offset: 0x000005FA
		public uint sampleRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000065B4 File Offset: 0x000047B4
		public uint maxSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetMaxSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000065D4 File Offset: 0x000047D4
		public uint availableSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetAvailableSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000065F4 File Offset: 0x000047F4
		public uint freeSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006614 File Offset: 0x00004814
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002407 File Offset: 0x00000607
		public uint freeSampleFrameCountLowThreshold
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThreshold(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetFreeSampleFrameCountLowThreshold(this.id, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006634 File Offset: 0x00004834
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002417 File Offset: 0x00000617
		public bool enableSampleFramesAvailableEvents
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEvents(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSampleFramesAvailableEvents(this.id, value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00006654 File Offset: 0x00004854
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002427 File Offset: 0x00000627
		public bool enableSilencePadding
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSilencePadding(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSilencePadding(this.id, value);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002437 File Offset: 0x00000637
		public uint ConsumeSampleFrames(NativeArray<float> sampleFrames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006674 File Offset: 0x00004874
		public uint QueueSampleFrames(NativeArray<float> sampleFrames)
		{
			bool flag = this.channelCount == 0;
			uint num;
			if (flag)
			{
				num = 0U;
			}
			else
			{
				num = AudioSampleProvider.InternalQueueSampleFrames(this.id, (IntPtr)sampleFrames.GetUnsafeReadOnlyPtr<float>(), (uint)(sampleFrames.Length / (int)this.channelCount));
			}
			return num;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002444 File Offset: 0x00000644
		public void add_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002451 File Offset: 0x00000651
		public void remove_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000245E File Offset: 0x0000065E
		public void add_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000246B File Offset: 0x0000066B
		public void remove_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002478 File Offset: 0x00000678
		public void ClearSampleFramesAvailableNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandler(this.id);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002487 File Offset: 0x00000687
		public void ClearSampleFramesOverflowNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandler(this.id);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002496 File Offset: 0x00000696
		public static uint InternalCreateSampleProvider(ushort channelCount, uint sampleRate)
		{
			return AudioSampleProvider.InternalCreateSampleProviderDelegateField(channelCount, sampleRate);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000024A4 File Offset: 0x000006A4
		public static void InternalRemove(uint providerId)
		{
			AudioSampleProvider.InternalRemoveDelegateField(providerId);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000024B1 File Offset: 0x000006B1
		public static void InternalGetFormatInfo(uint providerId, out ushort chCount, out uint sRate)
		{
			AudioSampleProvider.InternalGetFormatInfoDelegateField(providerId, out chCount, out sRate);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000066BC File Offset: 0x000048BC
		public static AudioSampleProvider InternalGetScriptingPtr(uint providerId)
		{
			IntPtr intPtr = AudioSampleProvider.InternalGetScriptingPtrDelegateField(providerId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider>(intPtr2) : null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000024C0 File Offset: 0x000006C0
		public static void InternalSetScriptingPtr(uint providerId, AudioSampleProvider provider)
		{
			AudioSampleProvider.InternalSetScriptingPtrDelegateField(providerId, IL2CPP.Il2CppObjectBaseToPtr(provider));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000024D3 File Offset: 0x000006D3
		public static bool InternalIsValid(uint providerId)
		{
			return AudioSampleProvider.InternalIsValidDelegateField(providerId);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000024E0 File Offset: 0x000006E0
		public static uint InternalGetMaxSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000024ED File Offset: 0x000006ED
		public static uint InternalGetAvailableSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000024FA File Offset: 0x000006FA
		public static uint InternalGetFreeSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002507 File Offset: 0x00000707
		public static uint InternalGetFreeSampleFrameCountLowThreshold(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField(providerId);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002514 File Offset: 0x00000714
		public static void InternalSetFreeSampleFrameCountLowThreshold(uint providerId, uint sampleFrameCount)
		{
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField(providerId, sampleFrameCount);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002522 File Offset: 0x00000722
		public static bool InternalGetEnableSampleFramesAvailableEvents(uint providerId)
		{
			return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField(providerId);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000252F File Offset: 0x0000072F
		public static void InternalSetEnableSampleFramesAvailableEvents(uint providerId, bool enable)
		{
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField(providerId, enable);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000253D File Offset: 0x0000073D
		public static void InternalSetSampleFramesAvailableNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000254C File Offset: 0x0000074C
		public static void InternalClearSampleFramesAvailableNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField(providerId);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002559 File Offset: 0x00000759
		public static void InternalSetSampleFramesOverflowNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002568 File Offset: 0x00000768
		public static void InternalClearSampleFramesOverflowNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField(providerId);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002575 File Offset: 0x00000775
		public static bool InternalGetEnableSilencePadding(uint id)
		{
			return AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField(id);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002582 File Offset: 0x00000782
		public static void InternalSetEnableSilencePadding(uint id, bool enabled)
		{
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField(id, enabled);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002590 File Offset: 0x00000790
		public static IntPtr InternalGetConsumeSampleFramesNativeFunctionPtr()
		{
			return AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000259C File Offset: 0x0000079C
		public static uint InternalQueueSampleFrames(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount)
		{
			return AudioSampleProvider.InternalQueueSampleFramesDelegateField(id, interleavedSampleFrames, sampleFrameCount);
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesAvailable;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesOverflow;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0;

		// Token: 0x040000AB RID: 171
		private static readonly AudioSampleProvider.InternalCreateSampleProviderDelegate InternalCreateSampleProviderDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly AudioSampleProvider.InternalRemoveDelegate InternalRemoveDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly AudioSampleProvider.InternalGetFormatInfoDelegate InternalGetFormatInfoDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly AudioSampleProvider.InternalGetScriptingPtrDelegate InternalGetScriptingPtrDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly AudioSampleProvider.InternalSetScriptingPtrDelegate InternalSetScriptingPtrDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly AudioSampleProvider.InternalIsValidDelegate InternalIsValidDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate InternalGetMaxSampleFrameCountDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate InternalGetAvailableSampleFrameCountDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate InternalGetFreeSampleFrameCountDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate InternalGetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate InternalSetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate InternalGetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate InternalSetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate InternalSetSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate InternalClearSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate InternalSetSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate InternalClearSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly AudioSampleProvider.InternalGetEnableSilencePaddingDelegate InternalGetEnableSilencePaddingDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly AudioSampleProvider.InternalSetEnableSilencePaddingDelegate InternalSetEnableSilencePaddingDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly AudioSampleProvider.InternalQueueSampleFramesDelegate InternalQueueSampleFramesDelegateField;

		// Token: 0x02000049 RID: 73
		public sealed class SampleFramesHandler : MulticastDelegate
		{
			// Token: 0x06000259 RID: 601 RVA: 0x000033B2 File Offset: 0x000015B2
			// Note: this type is marked as 'beforefieldinit'.
			static SampleFramesHandler()
			{
				Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "SampleFramesHandler");
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663422);
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663423);
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00008610 File Offset: 0x00006810
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 320543, RefRangeEnd = 320545, XrefRangeStart = 320543, XrefRangeEnd = 320545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SampleFramesHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025B RID: 603 RVA: 0x0000866C File Offset: 0x0000686C
			[CallerCount(0)]
			public unsafe void Invoke(AudioSampleProvider provider, uint sampleFrameCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025C RID: 604 RVA: 0x000033F0 File Offset: 0x000015F0
			public SampleFramesHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600025D RID: 605 RVA: 0x000033F9 File Offset: 0x000015F9
			public static implicit operator AudioSampleProvider.SampleFramesHandler(Action<AudioSampleProvider, uint> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSampleProvider.SampleFramesHandler>(A_0);
			}

			// Token: 0x0600025E RID: 606 RVA: 0x00003401 File Offset: 0x00001601
			public static AudioSampleProvider.SampleFramesHandler operator +(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSampleProvider.SampleFramesHandler>();
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000340F File Offset: 0x0000160F
			public static AudioSampleProvider.SampleFramesHandler operator -(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSampleProvider.SampleFramesHandler>();
				}
				return delegate2;
			}

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0;
		}

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate uint InternalCreateSampleProviderDelegate(ushort channelCount, uint sampleRate);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void InternalRemoveDelegate(uint providerId);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate void InternalGetFormatInfoDelegate(uint providerId, [Out] IntPtr chCount, [Out] IntPtr sRate);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate IntPtr InternalGetScriptingPtrDelegate(uint providerId);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate void InternalSetScriptingPtrDelegate(uint providerId, IntPtr provider);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate bool InternalIsValidDelegate(uint providerId);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate uint InternalGetMaxSampleFrameCountDelegate(uint providerId);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate uint InternalGetAvailableSampleFrameCountDelegate(uint providerId);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate uint InternalGetFreeSampleFrameCountDelegate(uint providerId);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate uint InternalGetFreeSampleFrameCountLowThresholdDelegate(uint providerId);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate void InternalSetFreeSampleFrameCountLowThresholdDelegate(uint providerId, uint sampleFrameCount);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate bool InternalGetEnableSampleFramesAvailableEventsDelegate(uint providerId);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate void InternalSetEnableSampleFramesAvailableEventsDelegate(uint providerId, bool enable);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate void InternalSetSampleFramesAvailableNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate void InternalClearSampleFramesAvailableNativeHandlerDelegate(uint providerId);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600027F RID: 639
		private delegate void InternalSetSampleFramesOverflowNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000281 RID: 641
		private delegate void InternalClearSampleFramesOverflowNativeHandlerDelegate(uint providerId);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000283 RID: 643
		private delegate bool InternalGetEnableSilencePaddingDelegate(uint id);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000285 RID: 645
		private delegate void InternalSetEnableSilencePaddingDelegate(uint id, bool enabled);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000287 RID: 647
		private delegate IntPtr InternalGetConsumeSampleFramesNativeFunctionPtrDelegate();

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000289 RID: 649
		private delegate uint InternalQueueSampleFramesDelegate(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount);
	}
}
