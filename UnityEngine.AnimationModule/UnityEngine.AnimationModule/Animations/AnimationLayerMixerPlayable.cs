using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000029 RID: 41
	[StructLayout(2)]
	public struct AnimationLayerMixerPlayable
	{
		// Token: 0x0600033D RID: 829 RVA: 0x0001064C File Offset: 0x0000E84C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationLayerMixerPlayable()
		{
			Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationLayerMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr);
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_Handle");
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663734);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663735);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663736);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetSingleLayerOptimizationInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663737);
			AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal");
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal");
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal");
			AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00010730 File Offset: 0x0000E930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1220864, RefRangeEnd = 1220865, XrefRangeStart = 1220850, XrefRangeEnd = 1220864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref singleLayerOptimization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00010770 File Offset: 0x0000E970
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220865, XrefRangeEnd = 1220872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationLayerMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000107E0 File Offset: 0x0000E9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220872, XrefRangeEnd = 1220881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetSingleLayerOptimizationInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002EE2 File Offset: 0x000010E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00010820 File Offset: 0x0000EA20
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00002EF4 File Offset: 0x000010F4
		public unsafe static AnimationLayerMixerPlayable m_NullPlayable
		{
			get
			{
				AnimationLayerMixerPlayable animationLayerMixerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationLayerMixerPlayable));
				return animationLayerMixerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0001083C File Offset: 0x0000EA3C
		public static AnimationLayerMixerPlayable Null
		{
			get
			{
				return AnimationLayerMixerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00010854 File Offset: 0x0000EA54
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount)
		{
			return AnimationLayerMixerPlayable.Create(graph, inputCount, true);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00010870 File Offset: 0x0000EA70
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization)
		{
			PlayableHandle playableHandle = AnimationLayerMixerPlayable.CreateHandle(graph, inputCount);
			AnimationLayerMixerPlayable animationLayerMixerPlayable = new AnimationLayerMixerPlayable(playableHandle, singleLayerOptimization);
			return animationLayerMixerPlayable;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00010894 File Offset: 0x0000EA94
		public static PlayableHandle CreateHandle(PlayableGraph graph, [Optional] int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationLayerMixerPlayable.CreateHandleInternal(graph, ref @null);
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

		// Token: 0x06000349 RID: 841 RVA: 0x000108D0 File Offset: 0x0000EAD0
		public static implicit operator Playable(AnimationLayerMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000108F0 File Offset: 0x0000EAF0
		public static explicit operator AnimationLayerMixerPlayable(Playable playable)
		{
			return new AnimationLayerMixerPlayable(playable.GetHandle(), true);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00010910 File Offset: 0x0000EB10
		public bool IsLayerAdditive(uint layerIndex)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00010974 File Offset: 0x0000EB74
		public void SetLayerAdditive(uint layerIndex, bool value)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			AnimationLayerMixerPlayable.SetLayerAdditiveInternal(ref this.m_Handle, layerIndex, value);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000109D4 File Offset: 0x0000EBD4
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			bool flag2 = mask == null;
			if (flag2)
			{
				throw new ArgumentNullException("mask");
			}
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternal(ref this.m_Handle, layerIndex, mask);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002F02 File Offset: 0x00001102
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationLayerMixerPlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002F0C File Offset: 0x0000110C
		public static bool IsLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex)
		{
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002F1A File Offset: 0x0000111A
		public static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value)
		{
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField(ref handle, layerIndex, value);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002F29 File Offset: 0x00001129
		public static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask)
		{
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegateField(ref handle, layerIndex, IL2CPP.Il2CppObjectBaseToPtr(mask));
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002F3D File Offset: 0x0000113D
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_Boolean_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_SetSingleLayerOptimizationInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040002E3 RID: 739
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040002E4 RID: 740
		private static readonly AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate IsLayerAdditiveInternalDelegateField;

		// Token: 0x040002E5 RID: 741
		private static readonly AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate SetLayerAdditiveInternalDelegateField;

		// Token: 0x040002E6 RID: 742
		private static readonly AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegate SetLayerMaskFromAvatarMaskInternalDelegateField;

		// Token: 0x040002E7 RID: 743
		private static readonly AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000675 RID: 1653
		private delegate bool IsLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000677 RID: 1655
		private delegate void SetLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex, bool value);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000679 RID: 1657
		private delegate void SetLayerMaskFromAvatarMaskInternalDelegate(IntPtr handle, uint layerIndex, IntPtr mask);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x0600067B RID: 1659
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
