using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200027C RID: 636
	[StructLayout(2)]
	public struct TextureMixerPlayable
	{
		// Token: 0x06002B5E RID: 11102 RVA: 0x000AFA44 File Offset: 0x000ADC44
		// Note: this type is marked as 'beforefieldinit'.
		static TextureMixerPlayable()
		{
			Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TextureMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
			TextureMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, "m_Handle");
			TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100668626);
			TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100668627);
			TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000AFAC0 File Offset: 0x000ADCC0
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000AFAF0 File Offset: 0x000ADCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686200, XrefRangeEnd = 686207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextureMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00010F05 File Offset: 0x0000F105
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000AFB30 File Offset: 0x000ADD30
		public static TextureMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = TextureMixerPlayable.CreateHandle(graph);
			return new TextureMixerPlayable(playableHandle);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000AFB50 File Offset: 0x000ADD50
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000AFB84 File Offset: 0x000ADD84
		public static implicit operator UnityEngine.Playables.Playable(TextureMixerPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000AFBA4 File Offset: 0x000ADDA4
		public static explicit operator TextureMixerPlayable(UnityEngine.Playables.Playable playable)
		{
			return new TextureMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00010F17 File Offset: 0x0000F117
		public static bool CreateTextureMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField(ref graph, ref handle);
		}

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;

		// Token: 0x0400266F RID: 9839
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04002670 RID: 9840
		private static readonly TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

		// Token: 0x02000A6C RID: 2668
		// (Invoke) Token: 0x06003DFC RID: 15868
		private delegate bool CreateTextureMixerPlayableInternalDelegate(IntPtr graph, IntPtr handle);
	}
}
