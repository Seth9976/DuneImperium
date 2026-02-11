using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000154 RID: 340
	public class ProgressionStatusRenderer : VersionedSubscriber<ProgressionData>
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x0004E4A8 File Offset: 0x0004C6A8
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressionStatusRenderer()
		{
			Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "ProgressionStatusRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr);
			ProgressionStatusRenderer.NativeFieldInfoPtr_lockedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr, "lockedObject");
			ProgressionStatusRenderer.NativeFieldInfoPtr_completedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr, "completedObject");
			ProgressionStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr, 100665506);
			ProgressionStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr, 100665507);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004E528 File Offset: 0x0004C728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513285, XrefRangeEnd = 513289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProgressionStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0004E564 File Offset: 0x0004C764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressionStatusRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionStatusRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressionStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000095ED File Offset: 0x000077ED
		public ProgressionStatusRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x000095F6 File Offset: 0x000077F6
		public unsafe GameObject lockedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionStatusRenderer.NativeFieldInfoPtr_lockedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionStatusRenderer.NativeFieldInfoPtr_lockedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00009615 File Offset: 0x00007815
		public unsafe GameObject completedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionStatusRenderer.NativeFieldInfoPtr_completedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressionStatusRenderer.NativeFieldInfoPtr_completedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_lockedObject;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_completedObject;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
