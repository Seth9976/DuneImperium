using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;

namespace worm.match.dataRenderers
{
	// Token: 0x02000163 RID: 355
	public class WormSpaceBlockedVoiceRenderer : VersionedDataComponentObserver<WormSpaceBlockedData>
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00047E1C File Offset: 0x0004601C
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpaceBlockedVoiceRenderer()
		{
			Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSpaceBlockedVoiceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr);
			WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_theVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr, "theVoice");
			WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_OnParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr, "OnParam");
			WormSpaceBlockedVoiceRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr, 100665465);
			WormSpaceBlockedVoiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr, 100665466);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00047E9C File Offset: 0x0004609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708820, XrefRangeEnd = 708827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceBlockedVoiceRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00047ED8 File Offset: 0x000460D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708827, XrefRangeEnd = 708830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpaceBlockedVoiceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpaceBlockedVoiceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceBlockedVoiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0000A5F2 File Offset: 0x000087F2
		public WormSpaceBlockedVoiceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00047F14 File Offset: 0x00046114
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x0000A5FB File Offset: 0x000087FB
		public unsafe Animator theVoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_theVoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_theVoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00047F44 File Offset: 0x00046144
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0000A61A File Offset: 0x0000881A
		public unsafe static int OnParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_OnParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormSpaceBlockedVoiceRenderer.NativeFieldInfoPtr_OnParam, (void*)(&value));
			}
		}

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_theVoice;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_OnParam;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
