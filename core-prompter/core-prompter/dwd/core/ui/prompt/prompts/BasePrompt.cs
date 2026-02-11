using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000015 RID: 21
	public class BasePrompt : Object
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00006AB8 File Offset: 0x00004CB8
		// Note: this type is marked as 'beforefieldinit'.
		static BasePrompt()
		{
			Il2CppClassPointerStore<BasePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "BasePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr);
			BasePrompt.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, "tags");
			BasePrompt.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, "<Resolved>k__BackingField");
			BasePrompt.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663380);
			BasePrompt.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663381);
			BasePrompt.NativeMethodInfoPtr_addTags_Protected_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663382);
			BasePrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663383);
			BasePrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663384);
			BasePrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr, 100663385);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006B88 File Offset: 0x00004D88
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1213504, RefRangeEnd = 1213514, XrefRangeStart = 1213493, XrefRangeEnd = 1213504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasePrompt([Optional] Il2CppStringArray args)
		{
			if (args == null)
			{
				args = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePrompt.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006BE0 File Offset: 0x00004DE0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1213539, RefRangeEnd = 1213563, XrefRangeStart = 1213514, XrefRangeEnd = 1213539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePrompt.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006C1C File Offset: 0x00004E1C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1213569, RefRangeEnd = 1213584, XrefRangeStart = 1213563, XrefRangeEnd = 1213569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addTags([Optional] Il2CppStringArray newTags)
		{
			if (newTags == null)
			{
				newTags = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newTags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePrompt.NativeMethodInfoPtr_addTags_Protected_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00006C6C File Offset: 0x00004E6C
		public unsafe virtual IEnumerable<string> PrefabLookupTags
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00006CB8 File Offset: 0x00004EB8
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000286A File Offset: 0x00000A6A
		public BasePrompt(params string[] args)
			: this(new Il2CppStringArray(args))
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002878 File Offset: 0x00000A78
		public void addTags(params string[] newTags)
		{
			this.addTags(new Il2CppStringArray(newTags));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002886 File Offset: 0x00000A86
		public BasePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00006D34 File Offset: 0x00004F34
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000288F File Offset: 0x00000A8F
		public unsafe List<string> tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePrompt.NativeFieldInfoPtr_tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePrompt.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000028AE File Offset: 0x00000AAE
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePrompt.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePrompt.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_addTags_Protected_Void_Il2CppStringArray_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_New_get_IEnumerable_1_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0;
	}
}
