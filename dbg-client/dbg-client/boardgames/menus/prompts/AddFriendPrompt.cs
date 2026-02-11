using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C3 RID: 451
	public class AddFriendPrompt : BasePrompt
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x0005EFDC File Offset: 0x0005D1DC
		// Note: this type is marked as 'beforefieldinit'.
		static AddFriendPrompt()
		{
			Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "AddFriendPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr);
			AddFriendPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, "<Result>k__BackingField");
			AddFriendPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, 100666263);
			AddFriendPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, 100666264);
			AddFriendPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, 100666265);
			AddFriendPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, 100666266);
			AddFriendPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr, 100666267);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005F084 File Offset: 0x0005D284
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		public unsafe virtual string Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005F100 File Offset: 0x0005D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520229, XrefRangeEnd = 520230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(string result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005F144 File Offset: 0x0005D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520230, XrefRangeEnd = 520231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005F178 File Offset: 0x0005D378
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520201, XrefRangeEnd = 520229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFriendPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0000B8B1 File Offset: 0x00009AB1
		public AddFriendPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0005F1B4 File Offset: 0x0005D3B4
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0000B8BA File Offset: 0x00009ABA
		public unsafe string _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_String_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
