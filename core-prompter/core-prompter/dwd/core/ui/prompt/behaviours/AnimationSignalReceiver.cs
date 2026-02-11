using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000032 RID: 50
	public class AnimationSignalReceiver : VersionedSubscriber<AnimationSignalData>
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x0000A1DC File Offset: 0x000083DC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSignalReceiver()
		{
			Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "AnimationSignalReceiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr);
			AnimationSignalReceiver.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, "animator");
			AnimationSignalReceiver.NativeFieldInfoPtr_currentBools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, "currentBools");
			AnimationSignalReceiver.NativeFieldInfoPtr_scratchBools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, "scratchBools");
			AnimationSignalReceiver.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, 100663518);
			AnimationSignalReceiver.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, 100663519);
			AnimationSignalReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr, 100663520);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A284 File Offset: 0x00008484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214242, XrefRangeEnd = 1214246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationSignalReceiver.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214246, XrefRangeEnd = 1214305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationSignalReceiver.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A2FC File Offset: 0x000084FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214305, XrefRangeEnd = 1214320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSignalReceiver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignalReceiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002F76 File Offset: 0x00001176
		public AnimationSignalReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000A338 File Offset: 0x00008538
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002F7F File Offset: 0x0000117F
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002F9E File Offset: 0x0000119E
		public unsafe HashSet<string> currentBools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_currentBools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_currentBools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002FBD File Offset: 0x000011BD
		public unsafe HashSet<string> scratchBools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_scratchBools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalReceiver.NativeFieldInfoPtr_scratchBools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_currentBools;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_scratchBools;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
