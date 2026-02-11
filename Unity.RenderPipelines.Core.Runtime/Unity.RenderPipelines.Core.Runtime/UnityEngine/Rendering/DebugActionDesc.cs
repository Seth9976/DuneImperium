using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000064 RID: 100
	public class DebugActionDesc : Object
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x0002891C File Offset: 0x00026B1C
		// Note: this type is marked as 'beforefieldinit'.
		static DebugActionDesc()
		{
			Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugActionDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr);
			DebugActionDesc.NativeFieldInfoPtr_axisTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "axisTrigger");
			DebugActionDesc.NativeFieldInfoPtr_buttonTriggerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "buttonTriggerList");
			DebugActionDesc.NativeFieldInfoPtr_keyTriggerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "keyTriggerList");
			DebugActionDesc.NativeFieldInfoPtr_repeatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "repeatMode");
			DebugActionDesc.NativeFieldInfoPtr_repeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "repeatDelay");
			DebugActionDesc.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, 100664285);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000289C4 File Offset: 0x00026BC4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 963494, RefRangeEnd = 963503, XrefRangeStart = 963475, XrefRangeEnd = 963494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugActionDesc()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionDesc.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004CD9 File Offset: 0x00002ED9
		public DebugActionDesc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00028A00 File Offset: 0x00026C00
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public unsafe string axisTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_axisTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_axisTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00028A28 File Offset: 0x00026C28
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00004D01 File Offset: 0x00002F01
		public unsafe List<Il2CppStringArray> buttonTriggerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_buttonTriggerList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_buttonTriggerList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00028A58 File Offset: 0x00026C58
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00004D20 File Offset: 0x00002F20
		public unsafe List<Il2CppStructArray<KeyCode>> keyTriggerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_keyTriggerList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<KeyCode>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_keyTriggerList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00028A88 File Offset: 0x00026C88
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00004D3F File Offset: 0x00002F3F
		public unsafe DebugActionRepeatMode repeatMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_repeatMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_repeatMode)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00028AB0 File Offset: 0x00026CB0
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004D5A File Offset: 0x00002F5A
		public unsafe float repeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_repeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionDesc.NativeFieldInfoPtr_repeatDelay)) = value;
			}
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_axisTrigger;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_buttonTriggerList;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_keyTriggerList;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_repeatMode;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_repeatDelay;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
