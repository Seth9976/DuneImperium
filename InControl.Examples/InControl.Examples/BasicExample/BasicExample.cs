using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace BasicExample
{
	// Token: 0x02000015 RID: 21
	public class BasicExample : MonoBehaviour
	{
		// Token: 0x06000134 RID: 308 RVA: 0x0000674C File Offset: 0x0000494C
		// Note: this type is marked as 'beforefieldinit'.
		static BasicExample()
		{
			Il2CppClassPointerStore<BasicExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "BasicExample", "BasicExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicExample>.NativeClassPtr);
			BasicExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicExample>.NativeClassPtr, 100663426);
			BasicExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicExample>.NativeClassPtr, 100663427);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000067A4 File Offset: 0x000049A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252628, XrefRangeEnd = 1252657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000067D8 File Offset: 0x000049D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002A0D File Offset: 0x00000C0D
		public BasicExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
