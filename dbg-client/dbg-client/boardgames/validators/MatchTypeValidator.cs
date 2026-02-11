using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.validators
{
	// Token: 0x020000EE RID: 238
	public class MatchTypeValidator : MonoBehaviour
	{
		// Token: 0x06000A4F RID: 2639 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchTypeValidator()
		{
			Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.validators", "MatchTypeValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr);
			MatchTypeValidator.NativeFieldInfoPtr_matchTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, "matchTypes");
			MatchTypeValidator.NativeFieldInfoPtr_validateIfContainsMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, "validateIfContainsMatch");
			MatchTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, "<Valid>k__BackingField");
			MatchTypeValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, 100664786);
			MatchTypeValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, 100664787);
			MatchTypeValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, 100664788);
			MatchTypeValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr, 100664789);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506690, XrefRangeEnd = 506699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTypeValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0003DEE4 File Offset: 0x0003C0E4
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0003DF20 File Offset: 0x0003C120
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTypeValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTypeValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0003DF60 File Offset: 0x0003C160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506699, XrefRangeEnd = 506704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchTypeValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchTypeValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTypeValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00006F04 File Offset: 0x00005104
		public MatchTypeValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0003DF9C File Offset: 0x0003C19C
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00006F0D File Offset: 0x0000510D
		public unsafe Il2CppStringArray matchTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr_matchTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr_matchTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00006F2C File Offset: 0x0000512C
		public unsafe bool validateIfContainsMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr_validateIfContainsMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr_validateIfContainsMatch)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00006F47 File Offset: 0x00005147
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeFieldInfoPtr_matchTypes;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_validateIfContainsMatch;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
