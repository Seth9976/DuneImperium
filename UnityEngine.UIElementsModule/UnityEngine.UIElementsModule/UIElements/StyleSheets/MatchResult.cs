using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000292 RID: 658
	public sealed class MatchResult : ValueType
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x000CF8A8 File Offset: 0x000CDAA8
		// Note: this type is marked as 'beforefieldinit'.
		static MatchResult()
		{
			Il2CppClassPointerStore<MatchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "MatchResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchResult>.NativeClassPtr);
			MatchResult.NativeFieldInfoPtr_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchResult>.NativeClassPtr, "errorCode");
			MatchResult.NativeFieldInfoPtr_errorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchResult>.NativeClassPtr, "errorValue");
			MatchResult.NativeMethodInfoPtr_get_success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchResult>.NativeClassPtr, 100670389);
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000CF914 File Offset: 0x000CDB14
		public unsafe bool success
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 358675, RefRangeEnd = 358676, XrefRangeStart = 358675, XrefRangeEnd = 358675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchResult.NativeMethodInfoPtr_get_success_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x00013FE7 File Offset: 0x000121E7
		public MatchResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00013FF0 File Offset: 0x000121F0
		public MatchResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchResult>.NativeClassPtr))
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000CF958 File Offset: 0x000CDB58
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00014002 File Offset: 0x00012202
		public unsafe MatchResultErrorCode errorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchResult.NativeFieldInfoPtr_errorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchResult.NativeFieldInfoPtr_errorCode)) = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000CF980 File Offset: 0x000CDB80
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x0001401D File Offset: 0x0001221D
		public unsafe string errorValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchResult.NativeFieldInfoPtr_errorValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchResult.NativeFieldInfoPtr_errorValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeFieldInfoPtr_errorCode;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeFieldInfoPtr_errorValue;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr_get_success_Public_get_Boolean_0;
	}
}
