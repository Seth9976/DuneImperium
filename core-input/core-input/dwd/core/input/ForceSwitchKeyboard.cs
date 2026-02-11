using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x02000045 RID: 69
	public class ForceSwitchKeyboard : MonoBehaviour
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000D34C File Offset: 0x0000B54C
		// Note: this type is marked as 'beforefieldinit'.
		static ForceSwitchKeyboard()
		{
			Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "ForceSwitchKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr);
			ForceSwitchKeyboard.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr, 100663562);
			ForceSwitchKeyboard.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr, 100663563);
			ForceSwitchKeyboard.NativeMethodInfoPtr_OpenKeyboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr, 100663564);
			ForceSwitchKeyboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr, 100663565);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSwitchKeyboard.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000D400 File Offset: 0x0000B600
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSwitchKeyboard.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000D434 File Offset: 0x0000B634
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSwitchKeyboard.NativeMethodInfoPtr_OpenKeyboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D468 File Offset: 0x0000B668
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceSwitchKeyboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceSwitchKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSwitchKeyboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000332F File Offset: 0x0000152F
		public ForceSwitchKeyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_OpenKeyboard_Public_Void_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
