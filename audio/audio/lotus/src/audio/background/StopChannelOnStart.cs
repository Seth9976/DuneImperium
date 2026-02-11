using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus.src.audio.background
{
	// Token: 0x02000018 RID: 24
	public class StopChannelOnStart : MonoBehaviour
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000549C File Offset: 0x0000369C
		// Note: this type is marked as 'beforefieldinit'.
		static StopChannelOnStart()
		{
			Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "StopChannelOnStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr);
			StopChannelOnStart.NativeFieldInfoPtr_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr, "channel");
			StopChannelOnStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr, 100663402);
			StopChannelOnStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr, 100663403);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005508 File Offset: 0x00003708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261884, XrefRangeEnd = 1261890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopChannelOnStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000553C File Offset: 0x0000373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261890, XrefRangeEnd = 1261894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopChannelOnStart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopChannelOnStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopChannelOnStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000026BF File Offset: 0x000008BF
		public StopChannelOnStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005578 File Offset: 0x00003778
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000026C8 File Offset: 0x000008C8
		public unsafe string channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopChannelOnStart.NativeFieldInfoPtr_channel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopChannelOnStart.NativeFieldInfoPtr_channel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_channel;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
