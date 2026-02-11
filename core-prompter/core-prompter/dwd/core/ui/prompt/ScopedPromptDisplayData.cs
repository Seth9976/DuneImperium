using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.prompt
{
	// Token: 0x0200000A RID: 10
	public class ScopedPromptDisplayData : Object
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000052FC File Offset: 0x000034FC
		// Note: this type is marked as 'beforefieldinit'.
		static ScopedPromptDisplayData()
		{
			Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt", "ScopedPromptDisplayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr);
			ScopedPromptDisplayData.NativeFieldInfoPtr_ShowModalBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr, "ShowModalBG");
			ScopedPromptDisplayData.NativeFieldInfoPtr_SyncInputLayerToScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr, "SyncInputLayerToScope");
			ScopedPromptDisplayData.NativeFieldInfoPtr_IgnoreBlockingInputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr, "IgnoreBlockingInputContext");
			ScopedPromptDisplayData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr, 100663350);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000537C File Offset: 0x0000357C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1213406, RefRangeEnd = 1213408, XrefRangeStart = 1213405, XrefRangeEnd = 1213406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopedPromptDisplayData(bool showModalBG = true, bool syncInputLayerToScope = true, bool ignoreBlockingInputContext = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedPromptDisplayData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showModalBG;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syncInputLayerToScope;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreBlockingInputContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPromptDisplayData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002306 File Offset: 0x00000506
		public ScopedPromptDisplayData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000053E0 File Offset: 0x000035E0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000230F File Offset: 0x0000050F
		public unsafe bool ShowModalBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_ShowModalBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_ShowModalBG)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00005408 File Offset: 0x00003608
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000232A File Offset: 0x0000052A
		public unsafe bool SyncInputLayerToScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_SyncInputLayerToScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_SyncInputLayerToScope)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005430 File Offset: 0x00003630
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002345 File Offset: 0x00000545
		public unsafe bool IgnoreBlockingInputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_IgnoreBlockingInputContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPromptDisplayData.NativeFieldInfoPtr_IgnoreBlockingInputContext)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_ShowModalBG;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_SyncInputLayerToScope;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreBlockingInputContext;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;
	}
}
