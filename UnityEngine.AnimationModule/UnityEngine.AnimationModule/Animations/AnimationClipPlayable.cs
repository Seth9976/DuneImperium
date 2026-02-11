using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000027 RID: 39
	[StructLayout(2)]
	public struct AnimationClipPlayable
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClipPlayable()
		{
			Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr);
			AnimationClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, "m_Handle");
			AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663732);
			AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663733);
			AnimationClipPlayable.GetAnimationClipInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetAnimationClipInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetAnimationClipInternal");
			AnimationClipPlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal");
			AnimationClipPlayable.SetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal");
			AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal");
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal");
			AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetRemoveStartOffsetInternal");
			AnimationClipPlayable.SetRemoveStartOffsetInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetRemoveStartOffsetInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal");
			AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetOverrideLoopTimeInternal");
			AnimationClipPlayable.SetOverrideLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetOverrideLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal");
			AnimationClipPlayable.GetLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetLoopTimeInternal");
			AnimationClipPlayable.SetLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal");
			AnimationClipPlayable.GetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetSampleRateInternal");
			AnimationClipPlayable.SetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetSampleRateInternal");
			AnimationClipPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000FE1C File Offset: 0x0000E01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220846, XrefRangeEnd = 1220850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002948 File Offset: 0x00000B48
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000FE5C File Offset: 0x0000E05C
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
		{
			PlayableHandle playableHandle = AnimationClipPlayable.CreateHandle(graph, clip);
			return new AnimationClipPlayable(playableHandle);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000FE7C File Offset: 0x0000E07C
		public static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationClipPlayable.CreateHandleInternal(graph, clip, ref @null);
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

		// Token: 0x060002AB RID: 683 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		public static implicit operator Playable(AnimationClipPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		public static explicit operator AnimationClipPlayable(Playable playable)
		{
			return new AnimationClipPlayable(playable.GetHandle());
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public AnimationClip GetAnimationClip()
		{
			return AnimationClipPlayable.GetAnimationClipInternal(ref this.m_Handle);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000FF10 File Offset: 0x0000E110
		public bool GetApplyFootIK()
		{
			return AnimationClipPlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000295A File Offset: 0x00000B5A
		public void SetApplyFootIK(bool value)
		{
			AnimationClipPlayable.SetApplyFootIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000FF30 File Offset: 0x0000E130
		public bool GetApplyPlayableIK()
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternal(ref this.m_Handle);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000296A File Offset: 0x00000B6A
		public void SetApplyPlayableIK(bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000FF50 File Offset: 0x0000E150
		public bool GetRemoveStartOffset()
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternal(ref this.m_Handle);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000297A File Offset: 0x00000B7A
		public void SetRemoveStartOffset(bool value)
		{
			AnimationClipPlayable.SetRemoveStartOffsetInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000FF70 File Offset: 0x0000E170
		public bool GetOverrideLoopTime()
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000298A File Offset: 0x00000B8A
		public void SetOverrideLoopTime(bool value)
		{
			AnimationClipPlayable.SetOverrideLoopTimeInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000FF90 File Offset: 0x0000E190
		public bool GetLoopTime()
		{
			return AnimationClipPlayable.GetLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000299A File Offset: 0x00000B9A
		public void SetLoopTime(bool value)
		{
			AnimationClipPlayable.SetLoopTimeInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public float GetSampleRate()
		{
			return AnimationClipPlayable.GetSampleRateInternal(ref this.m_Handle);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000029AA File Offset: 0x00000BAA
		public void SetSampleRate(float value)
		{
			AnimationClipPlayable.SetSampleRateInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000029BA File Offset: 0x00000BBA
		public static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return AnimationClipPlayable.CreateHandleInternal_Injected(ref graph, clip, ref handle);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimationClipPlayable.GetAnimationClipInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000029C5 File Offset: 0x00000BC5
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000029D2 File Offset: 0x00000BD2
		public static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetApplyFootIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000029E0 File Offset: 0x00000BE0
		public static bool GetApplyPlayableIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField(ref handle);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000029ED File Offset: 0x00000BED
		public static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000029FB File Offset: 0x00000BFB
		public static bool GetRemoveStartOffsetInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField(ref handle);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002A08 File Offset: 0x00000C08
		public static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetRemoveStartOffsetInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002A16 File Offset: 0x00000C16
		public static bool GetOverrideLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002A23 File Offset: 0x00000C23
		public static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetOverrideLoopTimeInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002A31 File Offset: 0x00000C31
		public static bool GetLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002A3E File Offset: 0x00000C3E
		public static void SetLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetLoopTimeInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static float GetSampleRateInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetSampleRateInternalDelegateField(ref handle);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002A59 File Offset: 0x00000C59
		public static void SetSampleRateInternal(ref PlayableHandle handle, float value)
		{
			AnimationClipPlayable.SetSampleRateInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002A67 File Offset: 0x00000C67
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return AnimationClipPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(clip), ref handle);
		}

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0;

		// Token: 0x040002A7 RID: 679
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040002A8 RID: 680
		private static readonly AnimationClipPlayable.GetAnimationClipInternalDelegate GetAnimationClipInternalDelegateField;

		// Token: 0x040002A9 RID: 681
		private static readonly AnimationClipPlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x040002AA RID: 682
		private static readonly AnimationClipPlayable.SetApplyFootIKInternalDelegate SetApplyFootIKInternalDelegateField;

		// Token: 0x040002AB RID: 683
		private static readonly AnimationClipPlayable.GetApplyPlayableIKInternalDelegate GetApplyPlayableIKInternalDelegateField;

		// Token: 0x040002AC RID: 684
		private static readonly AnimationClipPlayable.SetApplyPlayableIKInternalDelegate SetApplyPlayableIKInternalDelegateField;

		// Token: 0x040002AD RID: 685
		private static readonly AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate GetRemoveStartOffsetInternalDelegateField;

		// Token: 0x040002AE RID: 686
		private static readonly AnimationClipPlayable.SetRemoveStartOffsetInternalDelegate SetRemoveStartOffsetInternalDelegateField;

		// Token: 0x040002AF RID: 687
		private static readonly AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate GetOverrideLoopTimeInternalDelegateField;

		// Token: 0x040002B0 RID: 688
		private static readonly AnimationClipPlayable.SetOverrideLoopTimeInternalDelegate SetOverrideLoopTimeInternalDelegateField;

		// Token: 0x040002B1 RID: 689
		private static readonly AnimationClipPlayable.GetLoopTimeInternalDelegate GetLoopTimeInternalDelegateField;

		// Token: 0x040002B2 RID: 690
		private static readonly AnimationClipPlayable.SetLoopTimeInternalDelegate SetLoopTimeInternalDelegateField;

		// Token: 0x040002B3 RID: 691
		private static readonly AnimationClipPlayable.GetSampleRateInternalDelegate GetSampleRateInternalDelegateField;

		// Token: 0x040002B4 RID: 692
		private static readonly AnimationClipPlayable.SetSampleRateInternalDelegate SetSampleRateInternalDelegateField;

		// Token: 0x040002B5 RID: 693
		private static readonly AnimationClipPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600060F RID: 1551
		private delegate IntPtr GetAnimationClipInternalDelegate(IntPtr handle);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000611 RID: 1553
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000613 RID: 1555
		private delegate void SetApplyFootIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000615 RID: 1557
		private delegate bool GetApplyPlayableIKInternalDelegate(IntPtr handle);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000617 RID: 1559
		private delegate void SetApplyPlayableIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000619 RID: 1561
		private delegate bool GetRemoveStartOffsetInternalDelegate(IntPtr handle);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600061B RID: 1563
		private delegate void SetRemoveStartOffsetInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600061D RID: 1565
		private delegate bool GetOverrideLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600061F RID: 1567
		private delegate void SetOverrideLoopTimeInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000621 RID: 1569
		private delegate bool GetLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000623 RID: 1571
		private delegate void SetLoopTimeInternalDelegate(IntPtr handle, bool value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000625 RID: 1573
		private delegate float GetSampleRateInternalDelegate(IntPtr handle);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000627 RID: 1575
		private delegate void SetSampleRateInternalDelegate(IntPtr handle, float value);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000629 RID: 1577
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr clip, IntPtr handle);
	}
}
