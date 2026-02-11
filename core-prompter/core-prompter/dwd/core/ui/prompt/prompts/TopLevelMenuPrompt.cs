using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200002A RID: 42
	public class TopLevelMenuPrompt : Object
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00008F9C File Offset: 0x0000719C
		// Note: this type is marked as 'beforefieldinit'.
		static TopLevelMenuPrompt()
		{
			Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "TopLevelMenuPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr);
			TopLevelMenuPrompt.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, "<Resolved>k__BackingField");
			TopLevelMenuPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663450);
			TopLevelMenuPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663451);
			TopLevelMenuPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663452);
			TopLevelMenuPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663453);
			TopLevelMenuPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663454);
			TopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr, 100663455);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009058 File Offset: 0x00007258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213858, XrefRangeEnd = 1213859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopLevelMenuPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000090A8 File Offset: 0x000072A8
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopLevelMenuPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000090E4 File Offset: 0x000072E4
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00009120 File Offset: 0x00007320
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopLevelMenuPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopLevelMenuPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009160 File Offset: 0x00007360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TopLevelMenuPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000919C File Offset: 0x0000739C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TopLevelMenuPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TopLevelMenuPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002D7A File Offset: 0x00000F7A
		public TopLevelMenuPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000091D8 File Offset: 0x000073D8
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002D83 File Offset: 0x00000F83
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopLevelMenuPrompt.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopLevelMenuPrompt.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
