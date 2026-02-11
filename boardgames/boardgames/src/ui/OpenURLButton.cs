using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.src.ui
{
	// Token: 0x02000157 RID: 343
	public class OpenURLButton : MonoBehaviour
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x000468E8 File Offset: 0x00044AE8
		// Note: this type is marked as 'beforefieldinit'.
		static OpenURLButton()
		{
			Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.src.ui", "OpenURLButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr);
			OpenURLButton.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr, 100665855);
			OpenURLButton.NativeMethodInfoPtr_OpenMoreInfoUrl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr, 100665856);
			OpenURLButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr, 100665857);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00046954 File Offset: 0x00044B54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenURLButton.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00046988 File Offset: 0x00044B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000029, XrefRangeEnd = 1000041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMoreInfoUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenURLButton.NativeMethodInfoPtr_OpenMoreInfoUrl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000469CC File Offset: 0x00044BCC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenURLButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenURLButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenURLButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0000A230 File Offset: 0x00008430
		public OpenURLButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_OpenMoreInfoUrl_Public_Void_String_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
