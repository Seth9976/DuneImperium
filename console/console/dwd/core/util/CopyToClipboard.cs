using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000008 RID: 8
	public class CopyToClipboard : MonoBehaviour
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003624 File Offset: 0x00001824
		// Note: this type is marked as 'beforefieldinit'.
		static CopyToClipboard()
		{
			Il2CppClassPointerStore<CopyToClipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.util", "CopyToClipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyToClipboard>.NativeClassPtr);
			CopyToClipboard.NativeMethodInfoPtr_Copy_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyToClipboard>.NativeClassPtr, 100663311);
			CopyToClipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyToClipboard>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000367C File Offset: 0x0000187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255499, XrefRangeEnd = 1255500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyToClipboard.NativeMethodInfoPtr_Copy_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000036C0 File Offset: 0x000018C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyToClipboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyToClipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyToClipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002292 File Offset: 0x00000492
		public CopyToClipboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
