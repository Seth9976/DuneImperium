using System;
using dwd.core.data.composition;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000BF RID: 191
	public class WormVictoryPointSourcesPrompt : FlavoredDismissablePrompt
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x0002F848 File Offset: 0x0002DA48
		// Note: this type is marked as 'beforefieldinit'.
		static WormVictoryPointSourcesPrompt()
		{
			Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormVictoryPointSourcesPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr);
			WormVictoryPointSourcesPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr, 100664299);
			WormVictoryPointSourcesPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr, 100664300);
			WormVictoryPointSourcesPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr, 100664301);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002F8B4 File Offset: 0x0002DAB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696888, RefRangeEnd = 696890, XrefRangeStart = 696879, XrefRangeEnd = 696888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointSourcesPrompt(DataComposition data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002F900 File Offset: 0x0002DB00
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0002F950 File Offset: 0x0002DB50
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005DAE File Offset: 0x00003FAE
		public WormVictoryPointSourcesPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;
	}
}
