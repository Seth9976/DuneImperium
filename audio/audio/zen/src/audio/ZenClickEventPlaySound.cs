using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.audio
{
	// Token: 0x02000008 RID: 8
	public class ZenClickEventPlaySound : MonoBehaviour
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000324C File Offset: 0x0000144C
		// Note: this type is marked as 'beforefieldinit'.
		static ZenClickEventPlaySound()
		{
			Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "zen.src.audio", "ZenClickEventPlaySound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr);
			ZenClickEventPlaySound.NativeFieldInfoPtr_Click = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, "Click");
			ZenClickEventPlaySound.NativeFieldInfoPtr_StartDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, "StartDrag");
			ZenClickEventPlaySound.NativeFieldInfoPtr_StopDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, "StopDrag");
			ZenClickEventPlaySound.NativeMethodInfoPtr_PlayClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, 100663317);
			ZenClickEventPlaySound.NativeMethodInfoPtr_PlayStartDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, 100663318);
			ZenClickEventPlaySound.NativeMethodInfoPtr_PlayStopDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, 100663319);
			ZenClickEventPlaySound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr, 100663320);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003308 File Offset: 0x00001508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261299, RefRangeEnd = 1261300, XrefRangeStart = 1261297, XrefRangeEnd = 1261299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenClickEventPlaySound.NativeMethodInfoPtr_PlayClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000333C File Offset: 0x0000153C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261302, RefRangeEnd = 1261303, XrefRangeStart = 1261300, XrefRangeEnd = 1261302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStartDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenClickEventPlaySound.NativeMethodInfoPtr_PlayStartDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003370 File Offset: 0x00001570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261305, RefRangeEnd = 1261306, XrefRangeStart = 1261303, XrefRangeEnd = 1261305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStopDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenClickEventPlaySound.NativeMethodInfoPtr_PlayStopDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000033A4 File Offset: 0x000015A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261306, XrefRangeEnd = 1261314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZenClickEventPlaySound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZenClickEventPlaySound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenClickEventPlaySound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021C6 File Offset: 0x000003C6
		public ZenClickEventPlaySound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000033E0 File Offset: 0x000015E0
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021CF File Offset: 0x000003CF
		public unsafe string Click
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_Click);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_Click), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000021EE File Offset: 0x000003EE
		public unsafe string StartDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_StartDrag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_StartDrag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003430 File Offset: 0x00001630
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000220D File Offset: 0x0000040D
		public unsafe string StopDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_StopDrag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenClickEventPlaySound.NativeFieldInfoPtr_StopDrag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_Click;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_StartDrag;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_StopDrag;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_PlayClick_Public_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_PlayStartDrag_Public_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_PlayStopDrag_Public_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
