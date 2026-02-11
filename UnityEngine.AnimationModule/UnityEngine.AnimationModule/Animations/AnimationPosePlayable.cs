using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002E RID: 46
	[StructLayout(2)]
	public struct AnimationPosePlayable
	{
		// Token: 0x06000399 RID: 921 RVA: 0x00011300 File Offset: 0x0000F500
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPosePlayable()
		{
			Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPosePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr);
			AnimationPosePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_Handle");
			AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663751);
			AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663752);
			AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663753);
			AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetMustReadPreviousPoseInternal");
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetMustReadPreviousPoseInternal");
			AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetReadDefaultPoseInternal");
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetReadDefaultPoseInternal");
			AnimationPosePlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetApplyFootIKInternal");
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetApplyFootIKInternal");
			AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationPosePlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00011400 File Offset: 0x0000F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220930, XrefRangeEnd = 1220939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPosePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00011434 File Offset: 0x0000F634
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00011464 File Offset: 0x0000F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220939, XrefRangeEnd = 1220947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationPosePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000030C5 File Offset: 0x000012C5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000114A4 File Offset: 0x0000F6A4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x000030D7 File Offset: 0x000012D7
		public unsafe static AnimationPosePlayable m_NullPlayable
		{
			get
			{
				AnimationPosePlayable animationPosePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationPosePlayable));
				return animationPosePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000114C0 File Offset: 0x0000F6C0
		public static AnimationPosePlayable Null
		{
			get
			{
				return AnimationPosePlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000114D8 File Offset: 0x0000F6D8
		public static AnimationPosePlayable Create(PlayableGraph graph)
		{
			PlayableHandle playableHandle = AnimationPosePlayable.CreateHandle(graph);
			return new AnimationPosePlayable(playableHandle);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000114F8 File Offset: 0x0000F6F8
		public static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationPosePlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00011528 File Offset: 0x0000F728
		public static implicit operator Playable(AnimationPosePlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00011548 File Offset: 0x0000F748
		public static explicit operator AnimationPosePlayable(Playable playable)
		{
			return new AnimationPosePlayable(playable.GetHandle());
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00011568 File Offset: 0x0000F768
		public bool GetMustReadPreviousPose()
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternal(ref this.m_Handle);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000030E5 File Offset: 0x000012E5
		public void SetMustReadPreviousPose(bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00011588 File Offset: 0x0000F788
		public bool GetReadDefaultPose()
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternal(ref this.m_Handle);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000030F5 File Offset: 0x000012F5
		public void SetReadDefaultPose(bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000115A8 File Offset: 0x0000F7A8
		public bool GetApplyFootIK()
		{
			return AnimationPosePlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003105 File Offset: 0x00001305
		public void SetApplyFootIK(bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003115 File Offset: 0x00001315
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000311F File Offset: 0x0000131F
		public static bool GetMustReadPreviousPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField(ref handle);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000312C File Offset: 0x0000132C
		public static void SetMustReadPreviousPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000313A File Offset: 0x0000133A
		public static bool GetReadDefaultPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField(ref handle);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003147 File Offset: 0x00001347
		public static void SetReadDefaultPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003155 File Offset: 0x00001355
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003162 File Offset: 0x00001362
		public static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003170 File Offset: 0x00001370
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0;

		// Token: 0x0400030C RID: 780
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400030D RID: 781
		private static readonly AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate GetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x0400030E RID: 782
		private static readonly AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate SetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x0400030F RID: 783
		private static readonly AnimationPosePlayable.GetReadDefaultPoseInternalDelegate GetReadDefaultPoseInternalDelegateField;

		// Token: 0x04000310 RID: 784
		private static readonly AnimationPosePlayable.SetReadDefaultPoseInternalDelegate SetReadDefaultPoseInternalDelegateField;

		// Token: 0x04000311 RID: 785
		private static readonly AnimationPosePlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x04000312 RID: 786
		private static readonly AnimationPosePlayable.SetApplyFootIKInternalDelegate SetApplyFootIKInternalDelegateField;

		// Token: 0x04000313 RID: 787
		private static readonly AnimationPosePlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000693 RID: 1683
		private delegate bool GetMustReadPreviousPoseInternalDelegate(IntPtr handle);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000695 RID: 1685
		private delegate void SetMustReadPreviousPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000697 RID: 1687
		private delegate bool GetReadDefaultPoseInternalDelegate(IntPtr handle);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000699 RID: 1689
		private delegate void SetReadDefaultPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x0600069B RID: 1691
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600069D RID: 1693
		private delegate void SetApplyFootIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600069F RID: 1695
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
