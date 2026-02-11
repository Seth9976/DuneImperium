using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000262 RID: 610
	[Serializable]
	public class PlayableBehaviour : Object
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x000AC6A0 File Offset: 0x000AA8A0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableBehaviour()
		{
			Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr);
			PlayableBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668545);
			PlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668546);
			PlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668547);
			PlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668548);
			PlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668549);
			PlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668550);
			PlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668551);
			PlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668552);
			PlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_New_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668553);
			PlayableBehaviour.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr, 100668554);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000AC798 File Offset: 0x000AA998
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000AC820 File Offset: 0x000AAA20
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGraphStop(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000AC86C File Offset: 0x000AAA6C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlayableCreate(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000AC904 File Offset: 0x000AAB04
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000AC95C File Offset: 0x000AAB5C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000AC9B4 File Offset: 0x000AABB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000ACA0C File Offset: 0x000AAC0C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessFrame(Playable playable, FrameData info, Object playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_New_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000ACA78 File Offset: 0x000AAC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685756, XrefRangeEnd = 685765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableBehaviour.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000101F9 File Offset: 0x0000E3F9
		public PlayableBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00010202 File Offset: 0x0000E402
		public virtual void OnBehaviourDelay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00010205 File Offset: 0x0000E405
		public virtual void PrepareData(Playable playable, FrameData info)
		{
		}

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Virtual_New_Void_Playable_0;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStop_Public_Virtual_New_Void_Playable_0;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_New_Void_Playable_0;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_New_Void_Playable_0;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_New_Void_Playable_FrameData_Object_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;
	}
}
