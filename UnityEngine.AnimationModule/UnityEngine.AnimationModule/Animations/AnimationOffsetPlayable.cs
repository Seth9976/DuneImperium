using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002C RID: 44
	[StructLayout(2)]
	public struct AnimationOffsetPlayable
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationOffsetPlayable()
		{
			Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationOffsetPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr);
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_Handle");
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663747);
			AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663748);
			AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663749);
			AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected");
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetPositionInternal_Injected");
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetPositionInternal_Injected");
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetRotationInternal_Injected");
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetRotationInternal_Injected");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00010FB8 File Offset: 0x0000F1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220913, XrefRangeEnd = 1220922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationOffsetPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00010FEC File Offset: 0x0000F1EC
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001101C File Offset: 0x0000F21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220922, XrefRangeEnd = 1220930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationOffsetPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002FE6 File Offset: 0x000011E6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001105C File Offset: 0x0000F25C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00002FF8 File Offset: 0x000011F8
		public unsafe static AnimationOffsetPlayable m_NullPlayable
		{
			get
			{
				AnimationOffsetPlayable animationOffsetPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationOffsetPlayable));
				return animationOffsetPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00011078 File Offset: 0x0000F278
		public static AnimationOffsetPlayable Null
		{
			get
			{
				return AnimationOffsetPlayable.m_NullPlayable;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00011090 File Offset: 0x0000F290
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			PlayableHandle playableHandle = AnimationOffsetPlayable.CreateHandle(graph, position, rotation, inputCount);
			return new AnimationOffsetPlayable(playableHandle);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000110B4 File Offset: 0x0000F2B4
		public static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationOffsetPlayable.CreateHandleInternal(graph, position, rotation, ref @null);
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

		// Token: 0x0600037E RID: 894 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public static implicit operator Playable(AnimationOffsetPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011110 File Offset: 0x0000F310
		public static explicit operator AnimationOffsetPlayable(Playable playable)
		{
			return new AnimationOffsetPlayable(playable.GetHandle());
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00011130 File Offset: 0x0000F330
		public Vector3 GetPosition()
		{
			return AnimationOffsetPlayable.GetPositionInternal(ref this.m_Handle);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003006 File Offset: 0x00001206
		public void SetPosition(Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00011150 File Offset: 0x0000F350
		public Quaternion GetRotation()
		{
			return AnimationOffsetPlayable.GetRotationInternal(ref this.m_Handle);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003016 File Offset: 0x00001216
		public void SetRotation(Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00003026 File Offset: 0x00001226
		public static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			return AnimationOffsetPlayable.CreateHandleInternal_Injected(ref graph, ref position, ref rotation, ref handle);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00011170 File Offset: 0x0000F370
		public static Vector3 GetPositionInternal(ref PlayableHandle handle)
		{
			Vector3 vector;
			AnimationOffsetPlayable.GetPositionInternal_Injected(ref handle, out vector);
			return vector;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003034 File Offset: 0x00001234
		public static void SetPositionInternal(ref PlayableHandle handle, Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_Injected(ref handle, ref value);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00011188 File Offset: 0x0000F388
		public static Quaternion GetRotationInternal(ref PlayableHandle handle)
		{
			Quaternion quaternion;
			AnimationOffsetPlayable.GetRotationInternal_Injected(ref handle, out quaternion);
			return quaternion;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000303E File Offset: 0x0000123E
		public static void SetRotationInternal(ref PlayableHandle handle, Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_Injected(ref handle, ref value);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003048 File Offset: 0x00001248
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle)
		{
			return AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref position, ref rotation, ref handle);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003058 File Offset: 0x00001258
		public static void GetPositionInternal_Injected(ref PlayableHandle handle, out Vector3 ret)
		{
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003066 File Offset: 0x00001266
		public static void SetPositionInternal_Injected(ref PlayableHandle handle, ref Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003074 File Offset: 0x00001274
		public static void GetRotationInternal_Injected(ref PlayableHandle handle, out Quaternion ret)
		{
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003082 File Offset: 0x00001282
		public static void SetRotationInternal_Injected(ref PlayableHandle handle, ref Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0;

		// Token: 0x040002FD RID: 765
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040002FE RID: 766
		private static readonly AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x040002FF RID: 767
		private static readonly AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate GetPositionInternal_InjectedDelegateField;

		// Token: 0x04000300 RID: 768
		private static readonly AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate SetPositionInternal_InjectedDelegateField;

		// Token: 0x04000301 RID: 769
		private static readonly AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate GetRotationInternal_InjectedDelegateField;

		// Token: 0x04000302 RID: 770
		private static readonly AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate SetRotationInternal_InjectedDelegateField;

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000685 RID: 1669
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr position, IntPtr rotation, IntPtr handle);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000687 RID: 1671
		private delegate void GetPositionInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x06000689 RID: 1673
		private delegate void SetPositionInternal_InjectedDelegate(IntPtr handle, IntPtr value);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x0600068B RID: 1675
		private delegate void GetRotationInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600068D RID: 1677
		private delegate void SetRotationInternal_InjectedDelegate(IntPtr handle, IntPtr value);
	}
}
