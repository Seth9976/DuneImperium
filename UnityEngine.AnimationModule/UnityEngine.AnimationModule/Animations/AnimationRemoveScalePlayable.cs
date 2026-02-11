using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002F RID: 47
	[StructLayout(2)]
	public struct AnimationRemoveScalePlayable
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationRemoveScalePlayable()
		{
			Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationRemoveScalePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr);
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_Handle");
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663755);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663756);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663757);
			AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001166C File Offset: 0x0000F86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220947, XrefRangeEnd = 1220956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationRemoveScalePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000116A0 File Offset: 0x0000F8A0
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000116D0 File Offset: 0x0000F8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220956, XrefRangeEnd = 1220964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationRemoveScalePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000317E File Offset: 0x0000137E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00011710 File Offset: 0x0000F910
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003190 File Offset: 0x00001390
		public unsafe static AnimationRemoveScalePlayable m_NullPlayable
		{
			get
			{
				AnimationRemoveScalePlayable animationRemoveScalePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationRemoveScalePlayable));
				return animationRemoveScalePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0001172C File Offset: 0x0000F92C
		public static AnimationRemoveScalePlayable Null
		{
			get
			{
				return AnimationRemoveScalePlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00011744 File Offset: 0x0000F944
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
		{
			PlayableHandle playableHandle = AnimationRemoveScalePlayable.CreateHandle(graph, inputCount);
			return new AnimationRemoveScalePlayable(playableHandle);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00011764 File Offset: 0x0000F964
		public static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationRemoveScalePlayable.CreateHandleInternal(graph, ref @null);
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

		// Token: 0x060003BD RID: 957 RVA: 0x000117A0 File Offset: 0x0000F9A0
		public static implicit operator Playable(AnimationRemoveScalePlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000117C0 File Offset: 0x0000F9C0
		public static explicit operator AnimationRemoveScalePlayable(Playable playable)
		{
			return new AnimationRemoveScalePlayable(playable.GetHandle());
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000319E File Offset: 0x0000139E
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationRemoveScalePlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000031A8 File Offset: 0x000013A8
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0;

		// Token: 0x04000319 RID: 793
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400031A RID: 794
		private static readonly AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060006A1 RID: 1697
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
