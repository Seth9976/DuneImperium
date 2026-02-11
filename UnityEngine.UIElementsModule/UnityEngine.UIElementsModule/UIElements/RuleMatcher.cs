using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E6 RID: 486
	public sealed class RuleMatcher : ValueType
	{
		// Token: 0x06002689 RID: 9865 RVA: 0x000AB5E4 File Offset: 0x000A97E4
		// Note: this type is marked as 'beforefieldinit'.
		static RuleMatcher()
		{
			Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RuleMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr);
			RuleMatcher.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr, "sheet");
			RuleMatcher.NativeFieldInfoPtr_complexSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr, "complexSelector");
			RuleMatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr, 100669138);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000AB650 File Offset: 0x000A9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342261, XrefRangeEnd = 342262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuleMatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
		public RuleMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		public RuleMatcher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuleMatcher>.NativeClassPtr))
		{
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x000AB68C File Offset: 0x000A988C
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x0000F9F2 File Offset: 0x0000DBF2
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleMatcher.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleMatcher.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x000AB6BC File Offset: 0x000A98BC
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x0000FA11 File Offset: 0x0000DC11
		public unsafe StyleComplexSelector complexSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleMatcher.NativeFieldInfoPtr_complexSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleMatcher.NativeFieldInfoPtr_complexSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_complexSelector;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
