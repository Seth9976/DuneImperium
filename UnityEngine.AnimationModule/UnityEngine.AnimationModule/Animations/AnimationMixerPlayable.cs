using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002A RID: 42
	[StructLayout(2)]
	public struct AnimationMixerPlayable
	{
		// Token: 0x06000353 RID: 851 RVA: 0x00010A4C File Offset: 0x0000EC4C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMixerPlayable()
		{
			Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr);
			AnimationMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, "m_Handle");
			AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663739);
			AnimationMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663740);
			AnimationMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663741);
			AnimationMixerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationMixerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220881, XrefRangeEnd = 1220890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationMixerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00010B24 File Offset: 0x0000ED24
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00010B54 File Offset: 0x0000ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220890, XrefRangeEnd = 1220897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002F4B File Offset: 0x0000114B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00010B94 File Offset: 0x0000ED94
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002F5D File Offset: 0x0000115D
		public unsafe static AnimationMixerPlayable m_NullPlayable
		{
			get
			{
				AnimationMixerPlayable animationMixerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationMixerPlayable));
				return animationMixerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		public static AnimationMixerPlayable Null
		{
			get
			{
				return AnimationMixerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights)
		{
			return AnimationMixerPlayable.Create(graph, inputCount);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public static AnimationMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount)
		{
			PlayableHandle playableHandle = AnimationMixerPlayable.CreateHandle(graph, inputCount);
			return new AnimationMixerPlayable(playableHandle);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00010C04 File Offset: 0x0000EE04
		public static PlayableHandle CreateHandle(PlayableGraph graph, [Optional] int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationMixerPlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(inputCount);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00010C40 File Offset: 0x0000EE40
		public static implicit operator Playable(AnimationMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00010C60 File Offset: 0x0000EE60
		public static explicit operator AnimationMixerPlayable(Playable playable)
		{
			return new AnimationMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002F6B File Offset: 0x0000116B
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMixerPlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002F75 File Offset: 0x00001175
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMixerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0;

		// Token: 0x040002ED RID: 749
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040002EE RID: 750
		private static readonly AnimationMixerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x0600067D RID: 1661
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
