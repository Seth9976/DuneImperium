using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace core.ui
{
	// Token: 0x02000008 RID: 8
	public class TMPSubmitOnEnter : SubmitOnEnter
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003534 File Offset: 0x00001734
		// Note: this type is marked as 'beforefieldinit'.
		static TMPSubmitOnEnter()
		{
			Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "core.ui", "TMPSubmitOnEnter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr);
			TMPSubmitOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr, 100663317);
			TMPSubmitOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr, 100663318);
			TMPSubmitOnEnter.NativeMethodInfoPtr_clearInputText_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr, 100663319);
			TMPSubmitOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000035B4 File Offset: 0x000017B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253528, XrefRangeEnd = 1253541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPSubmitOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253541, XrefRangeEnd = 1253546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void removeListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPSubmitOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000362C File Offset: 0x0000182C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253546, XrefRangeEnd = 1253553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void clearInputText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPSubmitOnEnter.NativeMethodInfoPtr_clearInputText_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003668 File Offset: 0x00001868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPSubmitOnEnter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPSubmitOnEnter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPSubmitOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000021CE File Offset: 0x000003CE
		public TMPSubmitOnEnter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_clearInputText_Protected_Virtual_Void_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
