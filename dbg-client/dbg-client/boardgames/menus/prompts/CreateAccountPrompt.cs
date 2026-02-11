using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001EA RID: 490
	public class CreateAccountPrompt : BasePrompt
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00067CAC File Offset: 0x00065EAC
		// Note: this type is marked as 'beforefieldinit'.
		static CreateAccountPrompt()
		{
			Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "CreateAccountPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr);
			CreateAccountPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, "<Result>k__BackingField");
			CreateAccountPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, 100666651);
			CreateAccountPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, 100666652);
			CreateAccountPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, 100666653);
			CreateAccountPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, 100666654);
			CreateAccountPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr, 100666655);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00067D54 File Offset: 0x00065F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524987, XrefRangeEnd = 524994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateAccountPrompt(string email)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAccountPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(email);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00067DA0 File Offset: 0x00065FA0
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00067DD8 File Offset: 0x00065FD8
		public unsafe virtual ValueTuple<string, string, string> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, string, string>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524994, XrefRangeEnd = 524995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00067E20 File Offset: 0x00066020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524996, RefRangeEnd = 524997, XrefRangeStart = 524995, XrefRangeEnd = 524996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(ValueTuple<string, string, string> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00067E68 File Offset: 0x00066068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524997, XrefRangeEnd = 525001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0000CE0F File Offset: 0x0000B00F
		public CreateAccountPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00067E9C File Offset: 0x0006609C
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000CE18 File Offset: 0x0000B018
		public ValueTuple<string, string, string> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return new ValueTuple<string, string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, string, string>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, string, string>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_String_String_String_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_String_String_String_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_String_String_String_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
