using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.src.audio
{
	// Token: 0x0200000E RID: 14
	public class AudioCategoryDuckingDictionary : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003AC0 File Offset: 0x00001CC0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioCategoryDuckingDictionary()
		{
			Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio", "AudioCategoryDuckingDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr);
			AudioCategoryDuckingDictionary.NativeFieldInfoPtr_duckingConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr, "duckingConfigs");
			AudioCategoryDuckingDictionary.NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr, "dict");
			AudioCategoryDuckingDictionary.NativeMethodInfoPtr_GetConfiguration_Public_AudioDuckingConfiguration_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr, 100663333);
			AudioCategoryDuckingDictionary.NativeMethodInfoPtr_BuildDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr, 100663334);
			AudioCategoryDuckingDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr, 100663335);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003B54 File Offset: 0x00001D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261426, XrefRangeEnd = 1261447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioDuckingConfiguration GetConfiguration(AudioCategory cat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategoryDuckingDictionary.NativeMethodInfoPtr_GetConfiguration_Public_AudioDuckingConfiguration_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioDuckingConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003BA4 File Offset: 0x00001DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261492, RefRangeEnd = 1261493, XrefRangeStart = 1261447, XrefRangeEnd = 1261492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildDict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategoryDuckingDictionary.NativeMethodInfoPtr_BuildDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003BD8 File Offset: 0x00001DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261493, XrefRangeEnd = 1261508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioCategoryDuckingDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioCategoryDuckingDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategoryDuckingDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002319 File Offset: 0x00000519
		public AudioCategoryDuckingDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002322 File Offset: 0x00000522
		public unsafe List<AudioDuckingConfiguration> duckingConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategoryDuckingDictionary.NativeFieldInfoPtr_duckingConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioDuckingConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategoryDuckingDictionary.NativeFieldInfoPtr_duckingConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003C44 File Offset: 0x00001E44
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002341 File Offset: 0x00000541
		public unsafe Dictionary<string, AudioDuckingConfiguration> dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategoryDuckingDictionary.NativeFieldInfoPtr_dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AudioDuckingConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategoryDuckingDictionary.NativeFieldInfoPtr_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_duckingConfigs;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_dict;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetConfiguration_Public_AudioDuckingConfiguration_AudioCategory_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_BuildDict_Private_Void_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
