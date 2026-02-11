using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.canis.dbg_client.camera
{
	// Token: 0x02000032 RID: 50
	public class SetupKabbageCanvas : MonoBehaviour
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
		// Note: this type is marked as 'beforefieldinit'.
		static SetupKabbageCanvas()
		{
			Il2CppClassPointerStore<SetupKabbageCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "lib.canis.dbg_client.camera", "SetupKabbageCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupKabbageCanvas>.NativeClassPtr);
			SetupKabbageCanvas.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupKabbageCanvas>.NativeClassPtr, 100663668);
			SetupKabbageCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupKabbageCanvas>.NativeClassPtr, 100663669);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001F908 File Offset: 0x0001DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689884, XrefRangeEnd = 689895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupKabbageCanvas.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001F93C File Offset: 0x0001DB3C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupKabbageCanvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupKabbageCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupKabbageCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002FE4 File Offset: 0x000011E4
		public SetupKabbageCanvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
