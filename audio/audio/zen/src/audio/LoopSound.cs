using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.audio
{
	// Token: 0x02000007 RID: 7
	public class LoopSound : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003038 File Offset: 0x00001238
		// Note: this type is marked as 'beforefieldinit'.
		static LoopSound()
		{
			Il2CppClassPointerStore<LoopSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "zen.src.audio", "LoopSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopSound>.NativeClassPtr);
			LoopSound.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, "loop");
			LoopSound.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, "playing");
			LoopSound.NativeFieldInfoPtr_stopLoopingOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, "stopLoopingOnDisable");
			LoopSound.NativeMethodInfoPtr_StartLooping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, 100663313);
			LoopSound.NativeMethodInfoPtr_StopLooping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, 100663314);
			LoopSound.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, 100663315);
			LoopSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopSound>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000030F4 File Offset: 0x000012F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261274, XrefRangeEnd = 1261280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLooping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopSound.NativeMethodInfoPtr_StartLooping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003128 File Offset: 0x00001328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261280, XrefRangeEnd = 1261286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLooping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopSound.NativeMethodInfoPtr_StopLooping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000315C File Offset: 0x0000135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261286, XrefRangeEnd = 1261292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopSound.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003190 File Offset: 0x00001390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261292, XrefRangeEnd = 1261297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopSound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002164 File Offset: 0x00000364
		public LoopSound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000031CC File Offset: 0x000013CC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000216D File Offset: 0x0000036D
		public unsafe string loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_loop);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_loop), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000031F4 File Offset: 0x000013F4
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000218C File Offset: 0x0000038C
		public unsafe AudioObject playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_playing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_playing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021AB File Offset: 0x000003AB
		public unsafe bool stopLoopingOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_stopLoopingOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopSound.NativeFieldInfoPtr_stopLoopingOnDisable)) = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_stopLoopingOnDisable;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_StartLooping_Public_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_StopLooping_Public_Void_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
