using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.save
{
	// Token: 0x020000BF RID: 191
	public class SaveNoop : SaveRequest
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x00041CF4 File Offset: 0x0003FEF4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveNoop()
		{
			Il2CppClassPointerStore<SaveNoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.save", "SaveNoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr);
			SaveNoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, 100665004);
			SaveNoop.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, 100665005);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00041D4C File Offset: 0x0003FF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864260, XrefRangeEnd = 864261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveNoop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveNoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00041D88 File Offset: 0x0003FF88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyTo(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveNoop.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000064C0 File Offset: 0x000046C0
		public SaveNoop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0;
	}
}
