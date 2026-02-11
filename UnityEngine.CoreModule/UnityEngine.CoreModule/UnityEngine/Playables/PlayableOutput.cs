using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000266 RID: 614
	[StructLayout(2)]
	public struct PlayableOutput
	{
		// Token: 0x06002A77 RID: 10871 RVA: 0x000AD910 File Offset: 0x000ABB10
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutput()
		{
			Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr);
			PlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_Handle");
			PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_NullPlayableOutput");
			PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100668570);
			PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100668571);
			PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100668572);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000AD9A4 File Offset: 0x000ABBA4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000ADA08 File Offset: 0x000ABC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685863, XrefRangeEnd = 685873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutput other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00010968 File Offset: 0x0000EB68
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000ADA48 File Offset: 0x000ABC48
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0001097A File Offset: 0x0000EB7A
		public unsafe static PlayableOutput m_NullPlayableOutput
		{
			get
			{
				PlayableOutput playableOutput;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&playableOutput));
				return playableOutput;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x000ADA64 File Offset: 0x000ABC64
		public static PlayableOutput Null
		{
			get
			{
				return PlayableOutput.m_NullPlayableOutput;
			}
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000ADA7C File Offset: 0x000ABC7C
		public bool IsPlayableOutputOfType<T>() where T : struct
		{
			return this.GetHandle().IsPlayableOutputOfType<T>();
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000ADA9C File Offset: 0x000ABC9C
		public Type GetPlayableOutputType()
		{
			return this.GetHandle().GetPlayableOutputType();
		}

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayableOutput;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0;

		// Token: 0x04002549 RID: 9545
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
