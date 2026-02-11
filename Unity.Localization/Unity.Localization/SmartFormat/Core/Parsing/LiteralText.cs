using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007A RID: 122
	public class LiteralText : FormatItem
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x0001ED9C File Offset: 0x0001CF9C
		// Note: this type is marked as 'beforefieldinit'.
		static LiteralText()
		{
			Il2CppClassPointerStore<LiteralText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "LiteralText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiteralText>.NativeClassPtr);
			LiteralText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralText>.NativeClassPtr, 100664369);
			LiteralText.NativeMethodInfoPtr_ConvertCharacterLiteralsToUnicode_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralText>.NativeClassPtr, 100664370);
			LiteralText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralText>.NativeClassPtr, 100664371);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001EE08 File Offset: 0x0001D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073554, XrefRangeEnd = 1073557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiteralText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001EE4C File Offset: 0x0001D04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073577, RefRangeEnd = 1073578, XrefRangeStart = 1073557, XrefRangeEnd = 1073577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertCharacterLiteralsToUnicode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiteralText.NativeMethodInfoPtr_ConvertCharacterLiteralsToUnicode_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001EE84 File Offset: 0x0001D084
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiteralText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiteralText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiteralText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000042EC File Offset: 0x000024EC
		public LiteralText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_ConvertCharacterLiteralsToUnicode_Private_String_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
