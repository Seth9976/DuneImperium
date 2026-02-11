using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002B RID: 43
	[StructLayout(2)]
	public struct AnimationMotionXToDeltaPlayable
	{
		// Token: 0x06000362 RID: 866 RVA: 0x00010C80 File Offset: 0x0000EE80
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMotionXToDeltaPlayable()
		{
			Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMotionXToDeltaPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr);
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_Handle");
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663743);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663744);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663745);
			AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::IsAbsoluteMotionInternal");
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotionInternal");
			AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00010D44 File Offset: 0x0000EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220897, XrefRangeEnd = 1220906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00010D78 File Offset: 0x0000EF78
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220906, XrefRangeEnd = 1220913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002F83 File Offset: 0x00001183
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002F95 File Offset: 0x00001195
		public unsafe static AnimationMotionXToDeltaPlayable m_NullPlayable
		{
			get
			{
				AnimationMotionXToDeltaPlayable animationMotionXToDeltaPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationMotionXToDeltaPlayable));
				return animationMotionXToDeltaPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00010E04 File Offset: 0x0000F004
		public static AnimationMotionXToDeltaPlayable Null
		{
			get
			{
				return AnimationMotionXToDeltaPlayable.m_NullPlayable;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00010E1C File Offset: 0x0000F01C
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
		{
			PlayableHandle playableHandle = AnimationMotionXToDeltaPlayable.CreateHandle(graph);
			return new AnimationMotionXToDeltaPlayable(playableHandle);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00010E3C File Offset: 0x0000F03C
		public static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationMotionXToDeltaPlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(1);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00010E78 File Offset: 0x0000F078
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00010E98 File Offset: 0x0000F098
		public static explicit operator AnimationMotionXToDeltaPlayable(Playable playable)
		{
			return new AnimationMotionXToDeltaPlayable(playable.GetHandle());
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		public bool IsAbsoluteMotion()
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternal(ref this.m_Handle);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002FA3 File Offset: 0x000011A3
		public void SetAbsoluteMotion(bool value)
		{
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002FB3 File Offset: 0x000011B3
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002FBD File Offset: 0x000011BD
		public static bool IsAbsoluteMotionInternal(ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField(ref handle);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002FCA File Offset: 0x000011CA
		public static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value)
		{
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegateField(ref handle, value);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002FD8 File Offset: 0x000011D8
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0;

		// Token: 0x040002F4 RID: 756
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040002F5 RID: 757
		private static readonly AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate IsAbsoluteMotionInternalDelegateField;

		// Token: 0x040002F6 RID: 758
		private static readonly AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegate SetAbsoluteMotionInternalDelegateField;

		// Token: 0x040002F7 RID: 759
		private static readonly AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600067F RID: 1663
		private delegate bool IsAbsoluteMotionInternalDelegate(IntPtr handle);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x06000681 RID: 1665
		private delegate void SetAbsoluteMotionInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000683 RID: 1667
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
