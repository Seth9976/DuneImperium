using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000CE RID: 206
	public class DestroyOnStartup : MonoBehaviour
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x00030FAC File Offset: 0x0002F1AC
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyOnStartup()
		{
			Il2CppClassPointerStore<DestroyOnStartup>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "DestroyOnStartup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyOnStartup>.NativeClassPtr);
			DestroyOnStartup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyOnStartup>.NativeClassPtr, 100664921);
			DestroyOnStartup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyOnStartup>.NativeClassPtr, 100664922);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00031004 File Offset: 0x0002F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993463, XrefRangeEnd = 993468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyOnStartup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00031038 File Offset: 0x0002F238
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyOnStartup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyOnStartup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyOnStartup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00006898 File Offset: 0x00004A98
		public DestroyOnStartup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
